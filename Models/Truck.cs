using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse.Models
{
    internal class Truck:Vehicle
    {
        public int Engine { get; set; }
        public string ModelName { get; set; }
        public string CompanyName { get; set; }

        public Truck(int engineCC, string model, string Cname)
        {
            Engine = engineCC;
            ModelName = model;
            CompanyName = Cname;
        }
        public string EngineCC()
        {
            return $"The Truck hase engine of {Engine}cc";
        }
        public string BuildByCompany()
        {
            return $"The Truck if build by company {CompanyName}";
        }
        public string ModelNameOfVehicle()
        {
            return $"The model name is {ModelName}";
        }
    }
}
