﻿namespace FoodyProject.WebUI.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal PreviousPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }
    }
}
