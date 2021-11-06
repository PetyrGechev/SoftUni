using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
   public interface ICitizen : IIdentifiable,IBirthday,IAge
    {
        public string Name { get;}
    }
}
