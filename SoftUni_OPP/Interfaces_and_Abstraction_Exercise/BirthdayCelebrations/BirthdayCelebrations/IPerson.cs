using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public interface ICitizen : IIdentifiable,IBirthday,IAge
    {
        public string Name { get;}
    }
}
