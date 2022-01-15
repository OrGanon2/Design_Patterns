using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfresponsibiltyHW
{
    public abstract class Cars 
    {
        public bool IsOk { get; set; }

        protected Cars next;


        public void SetNext(Cars next)
        {
            this.next = next;
        }

        public abstract void Handle();
    }
}
