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

namespace PaymentManagementTests
{
    public class UsersControllerTests
    {
        private User user1 = new User
        {
            Id = 100,
            Address = "Romania, Galati",
            Username = "usertest1",
            Password = "parola1",
            Email = "user1@admin.com",
            PhoneNumber = "0871771111"
        };

        private User user2 = new User
        {
            Id = 200,
            Address = "Romania, Brasov",
            Username = "usertest2",
            Password = "parola2",
            Email = "user2@admin.com",
            PhoneNumber = "0858182111"
        };

        [Fact]
        public void GetUsers_ShouldReturnUsers()
        {
 
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "UsersGet")
                .Options;
            var context = new DataContext(_options);

            var controller = new UsersController(context);

            context.User.Add(user1);
            context.User.Add(user2);

            var users = controller.GetUsers().Value.ToList();

            Assert.Equal(100, users[0].Id);
            Assert.Equal(200, users[1].Id);
            Assert.Equal("usertest1", users[0].Username);
            Assert.Equal("usertest2", users[1].Username);
            Assert.Equal("parola1", users[0].Password);
            Assert.Equal("parola2", users[1].Password);
            Assert.Equal("user1@admin.com", users[0].Email);
            Assert.Equal("user2@admin.com", users[1].Email);
            Assert.Equal("0871771111", users[0].PhoneNumber);
            Assert.Equal("0858182111", users[1].PhoneNumber);

        }

        [Fact]
        public void GetByIdUser_ShouldReturnUserById()
        { 
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "UserGetById")
                .Options;
            var context = new DataContext(_options);

            var controller = new UsersController(context);

            context.User.Add(user1);

            var user = controller.GetUserById(100).Result.Value;

            Assert.Equal(100, user.Id);
            Assert.Equal("usertest1", user.Username);
            Assert.Equal("parola1", user.Password);
            Assert.Equal("user1@admin.com", user.Email);
            Assert.Equal("0871771111", user.PhoneNumber);

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

            var controller = new UsersController(context);

            context.User.Add(user1);

            context.SaveChanges();

            var usersLength1 = context.User.Count();

            controller.DeleteUser(100);

            var usersLength2 = context.User.Count();

            Assert.Equal(usersLength1, usersLength2+1);

        }
    }
}
