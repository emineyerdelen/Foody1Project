﻿using FoodyProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyProject.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCount();
        int ProductCountByCategoryNameSebze();
        int ProductCountByCategoryNameMeyve();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
    }
}
