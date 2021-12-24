using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Military_Elite.Interfaces
{
    public interface ISoldier
    {
        //holding id, first name, and last name.
        public string Id { get;}
        public string FirstName { get;}
        public string LastName { get; }
    }
}
