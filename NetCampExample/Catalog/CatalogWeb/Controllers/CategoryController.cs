using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWeb.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}