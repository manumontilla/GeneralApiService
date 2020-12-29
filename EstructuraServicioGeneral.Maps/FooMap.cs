using EstructuraServicioGeneral.Interfaces.Maps;
using EstructuraServicioGeneral.Interfaces.Services;
using EstructuraServicioGeneral.Models;
using EstructuraServicioGeneral.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstructuraServicioGeneral.ViewModels.FooViewModel;

namespace EstructuraServicioGeneral.Maps
{
    public class FooMap : IFooMap
    {

        private IFooService _fooService;
        public FooMap(IFooService fooService)
        {
            _fooService = fooService;
        }
        public async Task<FooExampleVM> GetFoo(string id)
        {
            FooModel fooModel = await _fooService.GetFoo(id);
            return new FooExampleVM() { id = fooModel.id, nombre = fooModel.nombre };
        }

        public async Task<List<FooExampleVM>> GetFoos()
        {
            List<FooModel> fooModel = await _fooService.GetFoos();
            return (from c in fooModel select new FooExampleVM() { id= c.id, nombre = c.nombre}).ToList();
        }
    }
}
