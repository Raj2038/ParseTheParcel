using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ParseTheParcel.Models
{
    public class PackageDetails
    {
       
            public static PackageDimensions GetPackageDetails(string type)
            {
                var packageDimensions = new PackageDimensions();
                string[] minPackageDetails;

                if (type.ToUpper() == "SMALL")
                {
                minPackageDetails = ConfigurationManager.AppSettings["SmallPackageDetails"].Split(',');
                }
                else if (type.ToUpper() == "MEDIUM")
                {
                minPackageDetails = ConfigurationManager.AppSettings["MediumPackageDetails"].Split(',');
                }
                else
                {
                minPackageDetails = ConfigurationManager.AppSettings["LargePackageDetails"].Split(',');
                }

                //Min package dimensions
                for (int i = 0; i < minPackageDetails.Length; i++)
                {
                    if (i == 0)
                    {
                    packageDimensions.Length = Convert.ToInt32(minPackageDetails[0]);
                    packageDimensions.Breath = Convert.ToInt32(minPackageDetails[1]);
                    packageDimensions.Height = Convert.ToInt32(minPackageDetails[2]);
                    }
                }
                return packageDimensions;
            }
        

    }
}