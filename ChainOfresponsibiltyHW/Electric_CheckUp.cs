using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfresponsibiltyHW
{
    public class Electric_CheckUp : Cars
    {

        public override void Handle()
        {
            int Grade = new Random().Next(1, 11);
            if (Grade > 6)
            {
                IsOk = true;
                Console.WriteLine("Car is Fully Functional");
            }
            else
            {
                if (next != null)
                {

                    Console.WriteLine("Car failed Third  Check up moving to Fourth Check up");
                    next.Handle();
                }
            }


        }
    }
    
}
