using System;
using Xunit;
using PaymentManagement.Controllers;
using PaymentManagement.Model;
using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace PaymentManagementTests
{
    public class BankAccountsControllerTests
    {
        private readonly IServiceProvider serviceProvider;
        public BankAccountsControllerTests()
        {
            var services = new ServiceCollection();

            string _databaseName = "BankAccounts";

            string randomNumber = (new Random().Next()).ToString();

            _databaseName += randomNumber;

            services.AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: _databaseName));

            serviceProvider = services.BuildServiceProvider();
        }

        private BankAccount bankAccount1 = new BankAccount
        {
            Id = "18379133",
            BankName = "Raiffeisen Bank",
            Balance = 65,
            AccountType = "STUDENT",
            UserId = 1
        };

        private BankAccount bankAccount2 = new BankAccount
        {
            Id = "15532133",
            BankName = "BCR",
            Balance = 12,
            AccountType = "BUSINESS",
            UserId = 1
        };

        [Fact]
        public void GetBankAccounts_ShouldReturnBankAccounts()
        {

            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);
            context.BankAccount.Add(bankAccount2);

            var bankAccounts = controller.GetBankAccounts().Value.ToList();

            Assert.Equal(bankAccount1, bankAccounts[0]);
            Assert.Equal(bankAccount2, bankAccounts[1]);
        }

        [Fact]
        public void TransferAmountBetweenUsers()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);
            context.BankAccount.Add(bankAccount2);
            context.SaveChanges();

            double initialBalanceBankAccount1 = bankAccount1.Balance;
            double initialBalanceBankAccount2 = bankAccount2.Balance;

            string amount = "10";

            List<string> transferData = new List<string> { "10", bankAccount1.UserId.ToString(), bankAccount2.UserId.ToString() };

            var transferResult = controller.TransferBetweenUsers(transferData);

            Assert.Equal(initialBalanceBankAccount1 - Single.Parse(amount), bankAccount1.Balance - Single.Parse(amount));
            Assert.Equal(initialBalanceBankAccount2 + Single.Parse(amount), bankAccount2.Balance + Single.Parse(amount));
        }

        [Fact]
        public void GetByIdBankAccount_ShouldReturnBankAccountById()
        {

            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);

            var bankAccount = controller.GetBankAccountById(bankAccount1.Id).Result.Value;

            Assert.Equal(bankAccount1, bankAccount);

        }

        [Fact]
        public void UpdateBankAccount()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);
            context.SaveChanges();

            //The entity is not being tracked by the context
            context.Entry(bankAccount1).State = EntityState.Detached;

            BankAccount bankAccount3 = new BankAccount
            {
                Id = "18379133",
                BankName = "First Bank",
                Balance = 33.98,
                AccountType = "BUSINESS",
                UserId = 2
            };

            var updateResult = controller.PutBankAccount(Int32.Parse(bankAccount3.Id), bankAccount3).Result;


            Assert.IsType<OkResult>(updateResult);

        }

        [Fact]
        public void DeleteBankAccount()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);

            context.SaveChanges();

            controller.DeleteBankAccount("18379133");

            var bankAccount = controller.GetBankAccountById("18379133").Result.Value;

            Assert.Null(bankAccount);

        }

        [Fact]
        public void CreateBankAccount()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new BankAccountsController(context);

            controller.PostBankAccount(bankAccount1);

            var createdBankAccount = controller.GetBankAccountById(bankAccount1.Id).Result.Value;

            Assert.Equal(createdBankAccount, bankAccount1);
        }
    }
}
