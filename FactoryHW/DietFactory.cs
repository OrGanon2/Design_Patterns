using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHW
{
   public static class DietFactory 
    {
        public static IDietBase AllDietBase(int Age,double Weight,double Height)
        {
            double BMI = Weight / Math.Pow(Height, 2);
            if (Age >= 29 && BMI >= 22 && BMI <= 28.9)
            {
                return new Paleo_diet();

            }
            else if (Age >= 30 && BMI >= 28.9 && BMI <= 37.4)
            {
                return new Vegaterian_Diet();
            }
            else if (Age >= 52 && BMI >= 37.4)
            {
                return new Etkines_diet();
            }

            return new NoDiet();
        }
    }
}

