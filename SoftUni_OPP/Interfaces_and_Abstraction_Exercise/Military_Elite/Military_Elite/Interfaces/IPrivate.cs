using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Interfaces
{
   public  interface IPrivate : ISoldier
    {
        //salary(decimal). 
        public decimal Salary { get; }
    }
}
