using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWeb.Controllers
{
    [Authorize]
    public class BrandController : Controller
    {
        public IActionResult List()
        {
            var dataservis = new BrandService();
            return View(dataservis.GetList());
        }
    }
}