using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportByVessel InVe = new ImportByVessel
            {
                Name = "Cable Innovator",
                VesselNumber = 1058764,
                importType = ImportType.Machinery,
                Agents = VesselAgents.AQUAMARINE_LIMITED
            };
            Console.WriteLine(InVe.ToString());
            GenericImportType<ImportByVessel> ImportProducts = new GenericImportType<ImportByVessel>();
            IGenericImportType<ImportByVessel> genericImportType = ImportProducts;
            Console.WriteLine(genericImportType.GetGenericImportType(InVe));

            Console.WriteLine("\n");

            ImportByVessel IVe = new ImportByVessel
            {
                Name = "Discover Bay",
                VesselNumber = 1057925,
                importType = ImportType.Fruits,
                Agents = VesselAgents.BANGLADESH_SHIPPING_CORPORATION
            };
            Console.WriteLine(IVe.ToString());
            SpecificImportType<ImportByVessel> SIT = new SpecificImportType<ImportByVessel>();
            Console.WriteLine(SIT.GetSpecificImportType(IVe));
            Console.WriteLine("\n");

            ImportByVessel IBV = new ImportByVessel
            {
                Name = "Dragon",
                VesselNumber = 1057658,
                importType = ImportType.Medicine,
                Agents = VesselAgents.Seven_SEAS_INTERNATIONAL
            };
            Console.WriteLine(IBV.ToString());
            SpecificImportType<ImportByVessel> IT = new SpecificImportType<ImportByVessel>();
            Console.WriteLine(SIT.GetSpecificImportType(IBV));

            Console.ReadKey();

        }
    }
}
