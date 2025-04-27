using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace FoodyProject.WebApi.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public SignalRHub(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task SendCategoryCount()
        {
           var value=  _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }

        public async Task SendProductCount()
        {
            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);
        }


        public async Task ProductCountByCategoryNameMeyve()
        {
            var value3=_productService.TProductCountByCategoryNameMeyve();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameMeyve", value3);
        }
    }
}
