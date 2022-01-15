using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHW
{
    public class Etkines_diet : IDietBase
    {
        public string DietMenu { get; set; } = "No spagetti for you!! only Soup NEXT !~";

        public string GetDiet()
        {
            return DietMenu;
        }
    }
}
