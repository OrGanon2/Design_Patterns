using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHW
{
    public class NoDiet : IDietBase
    {
        public string DietMenu { get; set; } = "You healthy mother *****";

       public string GetDiet()
        {

            return DietMenu;
        }
    }
}
