using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Context = SOPRO.Data.DbContext;
using System.Security.Claims;
using SOPRO.Models;
using System;

namespace SOPRO.Controllers
{
    public class PackageController : Controller
    {
        private readonly Context _db;

        public PackageController (Context db)
        {
            _db = db;
        }

        // GET: PackageController
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Country = _db.Users.First(a => a.Id.Equals(userId)).Country;
            Union enumCountry = (Union)Enum.Parse(typeof(Union), Country);
            var listPackages = _db.Package.Where(p => p.Union.Equals(enumCountry)).ToList();

            return View(listPackages);
        }
    }
}
