﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DtoLayer.CategoryDto
{
    public class GetCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
