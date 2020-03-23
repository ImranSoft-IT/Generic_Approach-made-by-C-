using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    class ImportProductType
    {
        public ImportProductType[] importProducts;
        public ImportProductType(ImportType productType, string productDetails) 
        {
            this.Type = productType;
            this.Details = productDetails;
        }

        public ImportProductType()  
        {

        }

        public ImportType Type { get; set; }   
        public string Details { get; set; }    

    }

    class VesselImportProductType
    {
        public ImportProductType[] importProductTypes; 

        public VesselImportProductType()
        {
            importProductTypes = new ImportProductType[]
            {
                new ImportProductType()
                {
                     Details = "Details:- Agriculture, Garment and Textile Machinery Import in Bangladesh.",
                     Type = ImportType.Machinery
                },
                new ImportProductType()
                {
                     Details = "Details:- Import to Bangladesh: dates, avocado, apple, rambutan, kiwi, dragon, etc.",
                     Type = ImportType.Fruits
                },
                new ImportProductType()
                {
                     Details = "Details:- Bangladesh Import expensive drugs and raw materials of all drugs.",
                     Type = ImportType.Medicine
                }

            };
        }
    }
}
