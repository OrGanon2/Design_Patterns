using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfresponsibiltyHW
{
    public class Car_Assemblies : Cars
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

                    Console.WriteLine("Car failed Second Check up moving to third Check up");
                    next.Handle();
                }
            }


        }
    }
}
