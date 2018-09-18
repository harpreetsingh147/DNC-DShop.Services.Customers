﻿using System;
using DShop.Common.Messages;
using Newtonsoft.Json;

namespace DShop.Services.Customers.Messages.Events
{
    [MessageNamespace("products")]
    public class ProductCreated : IEvent
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Vendor { get; }
        public decimal Price { get; }

        [JsonConstructor]
        public ProductCreated(Guid id, string name, 
            string description, string vendor, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Vendor = vendor;
            Price = price;
        }
    }
}
