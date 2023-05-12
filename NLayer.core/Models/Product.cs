﻿namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string? QRCode { get; set; }
        public Category Category { get; set; }
        public ProductFeature productFeature { get; set; }
    }
}
