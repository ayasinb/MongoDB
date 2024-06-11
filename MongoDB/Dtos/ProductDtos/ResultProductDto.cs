﻿namespace MongoDB.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
