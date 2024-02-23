﻿using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace HouseRentingSystem.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser AgentUser { get; set; }

        public IdentityUser GuestUser { get; set; }

        public Agent Agent { get; set; }

        public Category CottageCategory { get; set; }

        public Category SingleCategory { get; set; }

        public Category DuplexCategory { get; set; }

        public House FirstHouse { get; set; }

        public House SecondHouse { get; set; }

        public House ThirdHouse { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedAgent();
            SeedCategories();
            SeedHouses();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AgentUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };

            AgentUser.PasswordHash =
                 hasher.HashPassword(AgentUser, "agent123");

            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(AgentUser, "guest123");
        }

        private void SeedAgent()
        {
            Agent = new Agent()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                UserId = AgentUser.Id
            };
        }

        private void SeedCategories()
        {
            CottageCategory = new Category()
            {
                Id = 1,
                Name = "Cottage"
            };

            SingleCategory = new Category()
            {
                Id = 2,
                Name = "Single-Family"
            };

            DuplexCategory = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };
        }

        private void SeedHouses()
        {
            FirstHouse = new House()
            {
                Id = 1,
                Title = "Big House Marina",
                Address = "North London, UK (near the border)",
                Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                ImageUrl = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                PricePerMonth = 2100.00M,
                CategoryId = DuplexCategory.Id,
                AgentId = Agent.Id,
                RenterId = GuestUser.Id
            };

            SecondHouse = new House()
            {
                Id = 2,
                Title = "Family House Comfort",
                Address = "Near the Sea Garden in Burgas, Bulgaria",
                Description = "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1",
                PricePerMonth = 1200.00M,
                CategoryId = SingleCategory.Id,
                AgentId = Agent.Id
            };

            ThirdHouse = new House()
            {
                Id = 3,
                Title = "Grand House",
                Address = "Boyana Neighbourhood, Sofia, Bulgaria",
                Description = "This luxurious house is everything you will need. It is just excellent.",
                ImageUrl = "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg",
                PricePerMonth = 2000.00M,
                CategoryId = SingleCategory.Id,
                AgentId = Agent.Id
            };
        }

    }
}
