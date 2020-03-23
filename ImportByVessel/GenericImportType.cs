using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    public class GenericImportType<T> : IGenericImportType<T>
    {
        string IGenericImportType<T>.GetGenericImportType(T obj)
        {

            VesselImportProductType VIPT = new VesselImportProductType();

            string ImportProductType = string.Empty;

            if (obj is ImportByVessel)
            {
                ImportByVessel IV = obj as ImportByVessel;
                switch (IV.importType)
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
                        ImportProductType = "Only three types of products have been imported to Bangladesh";
                        break;

                }

            }
            else
            {
                ImportProductType = "Nothing is found";
            }
            return ImportProductType;
        }
    }
}
