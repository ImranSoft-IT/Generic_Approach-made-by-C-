using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    class SpecificImportType<T> : ISpecificImportType<T>
    {
        public string GetSpecificImportType<T>(T data) where T : ImportByVessel
        {

            VesselImportProductType VIPT = new VesselImportProductType();

            string ImportProductType = string.Empty;
            switch (data.importType)
            {
                case ImportType.Machinery:
                    ImportProductType = VIPT.importProductTypes.Where(I => I.Type == ImportType.Machinery).FirstOrDefault().Details;
                    break;
                case ImportType.Fruits:
                    ImportProductType = VIPT.importProductTypes.Where(I => I.Type == ImportType.Fruits).FirstOrDefault().Details;
                    break;
                case ImportType.Medicine:
                    ImportProductType = VIPT.importProductTypes.Where(I => I.Type == ImportType.Medicine).FirstOrDefault().Details;
                    break;
                default:
                    ImportProductType = "Nothing is found";
                    break;
            }
            return ImportProductType;
        }
    }
}
