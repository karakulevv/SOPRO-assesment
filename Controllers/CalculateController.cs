using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOPRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Context = SOPRO.Data.DbContext;

namespace SOPRO.Controllers
{
    public class CalculateController : Controller
    {
        private readonly Context _db;

        public CalculateController(Context db)
        {
            _db = db;
        }

        [Authorize]
        public ActionResult Index(int Id)
        {
            var package = _db.Package.FirstOrDefault(a => a.Id.Equals(Id));
            decimal VAT = 0;
            if (package.Name.Equals(Union.EU.ToString()))
            {
                VAT = (decimal)0.18 * package.CurrencyAmount;
            }
            if (package.Name.Equals(Union.UK.ToString()))
            {
                VAT = (decimal)0.15 * package.CurrencyAmount;
            }
            return View(VAT);
        }
    }
}
