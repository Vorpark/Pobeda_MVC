﻿namespace Pobeda.Domain.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
