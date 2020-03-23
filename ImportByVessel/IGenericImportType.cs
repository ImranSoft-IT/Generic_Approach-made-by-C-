using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportByVessel
{
    public interface IGenericImportType<T>
    {
        String GetGenericImportType(T obj);
    }
}
