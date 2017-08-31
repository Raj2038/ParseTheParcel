using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParseTheParcel.PackageCostDetails;
using ParseTheParcel.Models;
using System.Configuration;

namespace ParseTheParcel.Controllers
{
    public class PackageController : Controller
    {
        private readonly PackageCost _packageCost = new PackageCost();
        //GET: Package Details
        public ActionResult Index()
        {
            PackageDimensions model = new PackageDimensions();
            return View(model);
        }

        [HttpPost]
        public ActionResult Result(PackageDimensions model)
        {
            if (IsItOverWeight(model))
            {
                return View("OverWeightPackage");
            }

            model.PackageType = PackageDetailsSize.GetPackageType(model);

            var packageDeliveryCost = _packageCost.GetPackageDeliveryCost(model.PackageType);

            decimal cost = packageDeliveryCost;

            model.Cost = cost;

            return View(model);

        }

        private bool IsItOverWeight(PackageDimensions model)
        {
            int maxWeightAllowed = Convert.ToInt32(ConfigurationManager.AppSettings["MaxWeight"]);

            if (model.Weight > maxWeightAllowed)
            {
                return true;
            }
            return false;
        }
    }
}