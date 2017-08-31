using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParseTheParcel.PackageTypeData;


namespace ParseTheParcel.Models
{
    public class PackageDetailsSize
    {
        public static PackageType GetPackageType(PackageDimensions packageDimensions)
        {
            PackageDimensions smallPackage = PackageDetails.GetPackageDetails("Small");
            PackageDimensions mediumPackage = PackageDetails.GetPackageDetails("Medium");
            PackageDimensions largePackage = PackageDetails.GetPackageDetails("Large");

            if (packageDimensions.Length <= smallPackage.Length && packageDimensions.Breath <= smallPackage.Breath
                    && packageDimensions.Height <= smallPackage.Height)
            {
                return PackageType.Small;
            }
            else if (packageDimensions.Length <= mediumPackage.Length && packageDimensions.Breath <= mediumPackage.Breath
                && packageDimensions.Height <= mediumPackage.Height)
            {
                return PackageType.Medium;
            }
            else if (packageDimensions.Length <= largePackage.Length && packageDimensions.Breath <= largePackage.Breath
                && packageDimensions.Height <= largePackage.Height)
            {
                return PackageType.Large;
            }
            else
            {
                return PackageType.None;
            }
        }
    }
}