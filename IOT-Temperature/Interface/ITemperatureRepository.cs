using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperatures;

namespace IOT_Temperature.Interface
{
    public interface ITemperatureRepository
    {
        void AddData(TemperatureData tempdata);
    }
}
