using ParseTheParcel.PackageTypeData;

namespace ParseTheParcel.PackageCostDetails
{
    public class PackageCost
    {
        public decimal GetPackageDeliveryCost(PackageType packageSize)
        {
            switch (packageSize)
            {
                case PackageType.Small:
                    return 5;
                case PackageType.Medium:
                    return (decimal)7.5;
                case PackageType.Large:
                    return (decimal)8.5;
            }
            return 0;
        }
    }
}