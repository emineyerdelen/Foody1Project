﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DtoLayer.ProductDto
{
   public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal PreviousPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }
        public string CategoryName { get; set; }
    }
}
