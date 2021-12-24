using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl_
{
   public interface IPerson : IIdentifiable,IBirthday
    {
        public string Name { get;}
    }
}
