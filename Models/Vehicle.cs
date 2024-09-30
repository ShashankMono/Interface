using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse.Models
{
    internal interface Vehicle
    {
        public int Engine {  get; set; }
        public string ModelName { get; set; }
        public string CompanyName { get; set; }

        string EngineCC();
        string BuildByCompany();
        string ModelNameOfVehicle();
    }
}
