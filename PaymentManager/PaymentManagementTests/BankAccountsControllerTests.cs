using System;
using Xunit;
using PaymentManagement.Controllers;
using PaymentManagement.Model;
using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

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

            Assert.Equal("18379133", bankAccounts[0].Id);
            Assert.Equal("15532133", bankAccounts[1].Id);
            Assert.Equal("Raiffeisen Bank", bankAccounts[0].BankName);
            Assert.Equal("BCR", bankAccounts[1].BankName);
            Assert.Equal(65.98, bankAccounts[0].Balance);
            Assert.Equal(11.28, bankAccounts[1].Balance);
            Assert.Equal(1, bankAccounts[0].UserId);
            Assert.Equal(1, bankAccounts[1].UserId);
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


            var bankAccount = controller.GetBankAccountById(Int32.Parse(bankAccount1.Id)).Result.Value;

            Assert.Equal(bankAccount1.Id, bankAccount.Id);
            Assert.Equal("Raiffeisen Bank", bankAccount.BankName);
            Assert.Equal(65.98, bankAccount.Balance);
            Assert.Equal("STUDENT", bankAccount.AccountType);
            Assert.Equal(1, bankAccount.UserId);

        }

        //[Fact]
        //public void UpdateUser()
        //{
        //    var _options = new DbContextOptionsBuilder<DataContext>()
        //        .UseInMemoryDatabase(databaseName: "UpdateUser")
        //        .EnableSensitiveDataLogging()
        //        .Options;
        //    var context = new DataContext(_options);

        //    var controller = new UsersController(context);

        //    context.User.Add(user1);
        //    context.SaveChanges();

        //    User user3 = new User
        //    {
        //        Id = 100,
        //        Address = "Romania, Suceava",
        //        Username = "usertest3",
        //        Password = "parola3",
        //        Email = "user3@admin.com",
        //        PhoneNumber = "0858182111"
        //    };

        //    var updateResult = controller.PutUser(100, user3).Result;


        //    Assert.IsType<OkResult>(updateResult);

        //}

        [Fact]
        public void DeleteUser()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "UserGetById")
                .Options;
            var context = new DataContext(_options);

            var controller = new BankAccountsController(context);

            context.BankAccount.Add(bankAccount1);

            context.SaveChanges();

            var bankAccountsLength1 = context.BankAccount.Count();

            controller.DeleteBankAccount(18379133);

            var bankAccountsLength2 = context.BankAccount.Count();

            Assert.Equal(bankAccountsLength1, bankAccountsLength2 + 1);

        }
    }
}
