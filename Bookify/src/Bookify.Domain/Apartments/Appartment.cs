﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments
{
    public sealed class Appartment :Entity
    {
        public Appartment(Guid id):base(id)
        {
            
        }
        
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Country { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public decimal PriceAmount { get; private set; }
        public string PriceCurrency { get; private set; }
        public decimal CleaningFeeAmount { get; private set; }
        public string CleaningCurrency { get; private set; }
        public DateTime? LastBookedOnUtc { get; private set; }
        public List<Amenity> Amenities { get; private set; } = new();

    }
}