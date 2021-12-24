using System.Collections.Generic;

namespace Military_Elite.Interfaces
{
    public interface ILieutenantGeneral:IPrivate
    {
        public IReadOnlyCollection<IPrivate> Privates { get;}
    }
}