using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelCompany.Domain;

namespace TravelCompany.Models.ViewComponents
{
    public class ServiceListViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public ServiceListViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
