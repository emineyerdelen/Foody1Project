using FoodyProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace FoodyProject.WebApi.Hubs
{
    public class SignalRHub:Hub
    {
        FoodyContext context = new FoodyContext();
        public async Task SendCategoryCount()
        {
           var value=  context.Categories.Count();
            await Clients.All.SendAsync("ReceiverCategoryCount", value);
        }
    }
}
