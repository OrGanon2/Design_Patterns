using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHW
{
    public class Paleo_diet : IDietBase
    {
        public string DietMenu { get; set; } = "CannibalMENU";
        

        public string GetDiet()
        {
           
           return DietMenu;
        }
    }
}
