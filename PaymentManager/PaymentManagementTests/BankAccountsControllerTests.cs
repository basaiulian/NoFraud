using System;
using Xunit;
using PaymentManagement.Controllers;
using PaymentManagement.Model;
using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PaymentManagementTests
{
    public class BankAccountsControllerTests
    {
        private BankAccount bankAccount1 = new BankAccount
        {
            Id = "18379133",
            BankName = "Raiffeisen Bank",
            Balance = 65.98,
            AccountType = "STUDENT",
            UserId = 1
        };

        private BankAccount bankAccount2 = new BankAccount
        {
            Id = "15532133",
            BankName = "BCR",
            Balance = 11.28,
            AccountType = "BUSINESS",
            UserId = 1
        };

        [Fact]
        public void GetBankAccounts_ShouldReturnBankAccounts()
        {
 
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "BankAccountsGet")
                .Options;
            var context = new DataContext(_options);

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);
            context.BankAccount.Add(bankAccount2);

            var bankAccounts = controller.GetBankAccounts().Value.ToList();

            Assert.Equal(bankAccount1, bankAccounts[0]);
            Assert.Equal(bankAccount2, bankAccounts[1]);
        }

        [Fact]
        public void GetByIdBankAccount_ShouldReturnBankAccountById()
        { 

            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "BankAccountGetById")
                .Options;
            var context = new DataContext(_options);

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);

            var bankAccount = controller.GetBankAccountById(bankAccount1.Id).Result.Value;

            Assert.Equal(bankAccount1, bankAccount);

        }

        [Fact]
        public void UpdateBankAccount()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "UpdateBankAccount")
                .EnableSensitiveDataLogging()
                .Options;
            var context = new DataContext(_options);

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
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "BankAccountDelete")
                .Options;
            var context = new DataContext(_options);

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
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "BankAccountCreate")
                .Options;
            var context = new DataContext(_options);

            var controller = new BankAccountsController(context);

            controller.PostBankAccount(bankAccount1);

            var createdBankAccount = controller.GetBankAccountById(bankAccount1.Id).Result.Value;

            Assert.Equal(createdBankAccount, bankAccount1);
        }
    }
}
