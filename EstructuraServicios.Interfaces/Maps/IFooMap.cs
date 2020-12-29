using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraServicioGeneral.Interfaces.Maps
{
    public interface IFooMap
    {
        Task<string> GetFoo(string idFoo);
        Task<string> GetFoos(List<string>)
    }
}
