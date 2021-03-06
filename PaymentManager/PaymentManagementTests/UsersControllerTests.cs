using Xunit;
using PaymentManagement.Controllers;
using PaymentManagement.Model;
using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;

namespace PaymentManagementTests
{
    public class UsersControllerTests
    {
        private readonly IServiceProvider serviceProvider;

        public UsersControllerTests()
        {
            var services = new ServiceCollection();

            string _databaseName = "Users";

            string randomNumber = (new Random().Next()).ToString();

            _databaseName += randomNumber;

            services.AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: _databaseName));

            serviceProvider = services.BuildServiceProvider();
        }

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
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            context.User.Add(user1);
            context.User.Add(user2);

            var users = controller.GetUsers().Value.ToList();

            Assert.Equal(user1, users[0]);
            Assert.Equal(user2, users[1]);

        }

        [Fact]
        public void EmailUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            context.User.Add(user1);
            context.SaveChanges();

            var result = controller.EmailUser(user1.Email);

            Assert.True(result == 1);

        }

        [Fact]
        public void FindUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            controller.PostUser(user1);

            List<string> userData = new List<string> { "usertest1", "parola1" };

            int userId = controller.FindUser(userData);

            Assert.True(userId != -1);

        }

        [Fact]
        public void GetByIdUser_ShouldReturnUserById()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            context.User.Add(user1);

            var user = controller.GetUserById(100).Result.Value;

            Assert.Equal(user, user1);

        }

        [Fact]
        public void UpdateUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            context.User.Add(user1);
            context.SaveChanges();

            //The entity is not being tracked by the context
            context.Entry(user1).State = EntityState.Detached;

            User user3 = new User
            {
                Id = 100,
                Address = "Romania, Suceava",
                Username = "usertest3",
                Password = "parola3",
                Email = "user3@admin.com",
                PhoneNumber = "0858182111"
            };

            var updateResult = controller.PutUser(100, user3).Result;


            Assert.IsType<OkResult>(updateResult);

        }

        [Fact]
        public void DeleteUser()
        { 
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            context.User.Add(user1);

            context.SaveChanges();

            controller.DeleteUser(100);

            var user = controller.GetUserById(100).Result.Value;

            Assert.Null(user);
        }

        [Fact]
        public void CreateUser()
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            var controller = new UsersController(context);

            controller.PostUser(user1);

            var createdUser = controller.GetUserById(user1.Id).Result.Value;

            Assert.Equal(createdUser, user1);
        }
    }
}
