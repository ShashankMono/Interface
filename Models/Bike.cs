using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse.Models
{
    internal class Bike:Vehicle
    {
        public int Engine { get; set; }
        public string ModelName { get; set; }
        public string CompanyName { get; set; }

        public Bike(int engineCC,string model,string Cname)
        {
            Engine = engineCC;
            ModelName = model;
            CompanyName = Cname;
        }

        public String EngineCC()
        {
            return $"The Bike hase engine of { Engine}cc";
        }
        public string BuildByCompany()
        {
            return $"The Bike if build by company { CompanyName}";
        }
        public string ModelNameOfVehicle()
        {
            return $"The model name is { ModelName}";
        }
    }
}
