using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHW
{
    public class Vegaterian_Diet : IDietBase
    {
        public string DietMenu { get; set; } = "no MEAT only ToFu";
        public string GetDiet()
        {
            return DietMenu;
        }
    }
}
