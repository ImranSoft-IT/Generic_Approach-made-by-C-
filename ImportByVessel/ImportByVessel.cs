using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    public enum ImportType
    {
        Machinery,
        Fruits,
        Medicine
    }
    public enum VesselAgents
    {
        Seven_SEAS_INTERNATIONAL,
        AQUAMARINE_LIMITED,
        BANGLADESH_SHIPPING_CORPORATION
    }
    public class ImportByVessel
    {
        public string Name { get; set; }
        public int VesselNumber { get; set; }
        public ImportType importType { get; set; }
        public VesselAgents Agents { get; set; }

        public override string ToString()
        {
            return $"Vessel Name: {this.Name},\nVessel Number: {this.VesselNumber},\nImport Type: {this.importType}, \nAgent Name: {this.Agents}";
        }
    }
}
