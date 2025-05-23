﻿using AutoMapper;
using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DataAccessLayer.Concrete;
using FoodyProject.DtoLayer.ProductDto;
using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }


        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

        [HttpGet("ProductCountByCategoryNameSebze")]
        public IActionResult ProductCountByCategoryNameSebze()
        {
            return Ok(_productService.TProductCountByCategoryNameSebze());
        }

        [HttpGet("ProductCountByCategoryNameMeyve")]
        public IActionResult ProductCountByCategoryNameMeyve()
        {
            return Ok(_productService.TProductCountByCategoryNameMeyve());
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }
        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }
        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }

        ////[HttpGet("ProductListWithCategory")]
        ////public IActionResult ProductListWithCategory(int id)
        ////{
        ////    var context = new FoodyContext();
        ////    var values = context.Products
        ////        .Include(x => x.Category)
        ////        .Where(x => x.Category.CategoryID == id)
        ////        .Select(y => new ResultProductWithCategoryDto
        ////        {
        ////            Description = y.Description,
        ////            ImageUrl = y.ImageUrl,
        ////            Price = y.Price,
        ////            ProductID = y.ProductID,
        ////            ProductName = y.ProductName,
        ////            ProductStatus = y.ProductStatus,
        ////            CategoryName = y.Category.CategoryName,
        ////        })
        ////        .ToList();

        ////    return Ok(values);
        ////}
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory(string category)
        {
            var context = new FoodyContext();

            var query = context.Products.Include(x => x.Category).AsQueryable();

            if (!string.IsNullOrEmpty(category) && category != "Tümü")
            {
                query = query.Where(x => x.Category.CategoryName == category);
            }

            var values = query.Select(y => new ResultProductWithCategoryDto
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName,
            }).ToList();

            return Ok(values);
        }



        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus,
                CategoryID = createProductDto.CategoryID
            });
            return Ok("Ürün Eklendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductID = updateProductDto.ProductID,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                CategoryID = updateProductDto.CategoryID
            });
            return Ok("Ürün Güncellendi");
        }
    }
}
