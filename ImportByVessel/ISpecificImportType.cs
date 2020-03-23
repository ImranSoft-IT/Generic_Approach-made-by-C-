using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    public interface ISpecificImportType<T>
    {
        string GetSpecificImportType<T>(T data) where T : ImportByVessel;
    }
}
