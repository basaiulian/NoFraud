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
    public class CardsControllerTests
    {
        private Card card1 = new Card
        {
            Id = 1,
            Number = "7743858418283818",
            ExpirationDate = new DateTime(2022, 10, 10),
            PinCode = "1234",
            CvvCode = "123",
            OwnerId = "1",
            BankName = "BRD",
            BankAccountId = "06478554"
        };

        private Card card2 = new Card
        {
            Id = 2,
            Number = "1172582811399494",
            ExpirationDate = new DateTime(2022, 12, 12),
            PinCode = "4156",
            CvvCode = "612",
            OwnerId = "2",
            BankName = "BCR",
            BankAccountId = "77119876"
        };

        [Fact]
        public void GetCards_ShouldReturnAllCards()
        {
 
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "CardsGet")
                .Options;
            var context = new DataContext(_options);

            var controller = new CardsController(context);

            context.Card.Add(card1);
            context.Card.Add(card2);
            context.SaveChanges();

            var cards = controller.GetCards().Result.Value.ToList();

            Assert.Equal(card1, cards[0]);
            Assert.Equal(card2, cards[1]);
        }

        [Fact]
        public void GetByIdCard_ShouldReturnCardById()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "CardGetById")
                .Options;
            var context = new DataContext(_options);

            var controller = new CardsController(context);

            context.Card.Add(card1);

            var card = controller.GetCardById(1).Result.Value;

            Assert.Equal(card, card1);

        }

        [Fact]
        public void UpdateCard()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "CardUpdate")
                .EnableSensitiveDataLogging()
                .Options;
            var context = new DataContext(_options);

            var controller = new CardsController(context);

            context.Card.Add(card1);
            context.SaveChanges();

            //The entity is not being tracked by the context
            context.Entry(card1).State = EntityState.Detached;

            Card card3 = new Card
            {
                Id = 1,
                Number = "8813582836371494",
                ExpirationDate = new DateTime(2022, 09, 09),
                PinCode = "9913",
                CvvCode = "697",
                OwnerId = "1",
                BankName = "BRD",
                BankAccountId = "91875712"
            };

            var updateResult = controller.PutCard(1, card3).Result;

            Assert.IsType<OkResult>(updateResult);

        }

        [Fact]
        public void DeleteCard()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "CardDelete")
                .Options;
            var context = new DataContext(_options);

            var controller = new CardsController(context);

            context.Card.Add(card1);

            context.SaveChanges();

            controller.DeleteCard(1);

            var card = controller.GetCardById(11).Result.Value;

            Assert.Null(card);
        }

        [Fact]
        public void CreateCard()
        {
            var _options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "CardCreate")
                .Options;
            var context = new DataContext(_options);

            var controller = new CardsController(context);

            controller.PostCard(card1);

            var createdCard = controller.GetCardById(card1.Id).Result.Value;

            Assert.Equal(createdCard, card1);
        }

    }
}
