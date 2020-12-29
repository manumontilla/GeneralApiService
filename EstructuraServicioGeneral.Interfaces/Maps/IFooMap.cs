using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static EstructuraServicioGeneral.ViewModels.FooViewModel;

namespace EstructuraServicioGeneral.Interfaces.Maps
{
    public interface IFooMap
    {
        Task<FooExampleVM> GetFoo(string id);
        Task<List<FooExampleVM>> GetFoos();
    }
}
