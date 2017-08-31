using ParseTheParcel.Models;
using ParseTheParcel.PackageTypeData;
 
namespace ParseTheParcel.Models
{
    public class PackageDimensions
    {
        public int Length { get; set; }

        public int Breath { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public decimal Cost { get; set; }

        public PackageType PackageType { get; set; }
    }
}