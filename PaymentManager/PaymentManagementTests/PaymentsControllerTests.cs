using System;
using Xunit;
using PaymentManagement.Controllers;
using PaymentManagement.Model;
using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PaymentManagement;

namespace PaymentManagementTests
{
    public class PaymentsControllerTests
    {
        private Payment payment1 = new Payment
        {
            Id =  1,
            Amount = 500,
            Currency = "$",
            Source = "Ciprian Ursulean",
            Date = new DateTime(2020, 12, 31),
            Destination = "Spantu Theodor Ioan",
            Status = "complete",
            latitude = 334.231f,
            longitude = 123
        };

        private Payment payment2 = new Payment
        {
            Id = 2,
            Amount = 7000,
            Currency = "$",
            Source = "Balanica Gabriel",
            Date = new DateTime(2020, 12, 31),
            Destination = "Spantu Theodor Ioan",
            Status = "complete",
            latitude = 133.231f,
            longitude = 33
        };

        [Fact]
        public void GetPayments_ShouldReturnAllPayments()
        {
 
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "PaymentsGet")
                .Options;
            var context = new DataContext(_options);

            var controller = new PaymentsController(context);

            context.Payment.Add(payment1);
            context.Payment.Add(payment2);
            context.SaveChanges();

            var payments = controller.GetPayments().Result.Value.ToList();

            Assert.Equal(payment1, payments[0]);
            Assert.Equal(payment2, payments[1]);
        }

        [Fact]
        public void GetByIdPayment_ShouldReturnPaymentById()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "PaymentGetById")
                .Options;
            var context = new DataContext(_options);

            var controller = new PaymentsController(context);

            context.Payment.Add(payment1);

            var payment = controller.GetPaymentById(1).Result.Value;

            Assert.Equal(payment, payment1);

        }

        [Fact]
        public void UpdatePayment()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "UpdatePayment")
                .EnableSensitiveDataLogging()
                .Options;
            var context = new DataContext(_options);

            var controller = new PaymentsController(context);

            context.Payment.Add(payment1);
            context.SaveChanges();

            //The entity is not being tracked by the context
            context.Entry(payment1).State = EntityState.Detached;

            Payment payment3 = new Payment
            {
                Id = 1,
                Amount = 9000,
                Currency = "$",
                Source = "Balanica Gabriel",
                Date = new DateTime(2020, 12, 30),
                Destination = "Spantu Theodor Ioan",
                Status = "complete",
                latitude = 93.231f,
                longitude = 44.2f
            };

            var updateResult = controller.PutPayment(1, payment3).Result;

            Assert.IsType<OkResult>(updateResult);

        }

        [Fact]
        public void DeletePayment()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "PaymentDelete")
                .Options;
            var context = new DataContext(_options);

            var controller = new PaymentsController(context);

            context.Payment.Add(payment1);

            context.SaveChanges();

            controller.DeletePayment(1);

            var card = controller.GetPaymentById(1).Result.Value;

            Assert.Null(card);
        }

        [Fact]
        public void CreatePayment()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "PaymentCreate")
                .Options;
            var context = new DataContext(_options);

            var controller = new PaymentsController(context);

            controller.PostPayment(payment1);

            var createdPayment = controller.GetPaymentById(payment1.Id).Result.Value;

            Assert.Equal(createdPayment, payment1);
        }



    }
}
