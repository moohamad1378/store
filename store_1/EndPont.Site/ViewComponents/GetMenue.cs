using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Services.Common.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.ViewComponents
{
    public class GetMenue:ViewComponent
    {
        private readonly IGetMenuItemService _getMenuItemService;
        public GetMenue(IGetMenuItemService getMenuItemService)
        {
            _getMenuItemService = getMenuItemService;
        }
        public IViewComponentResult Invoke()
        {
            var menueItem = _getMenuItemService.Execute();
            return View(viewName: "GetMenue", menueItem.Data);
        }
    }
}
