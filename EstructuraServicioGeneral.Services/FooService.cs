using EstructuraServicioGeneral.Interfaces.Respository;
using EstructuraServicioGeneral.Interfaces.Services;
using EstructuraServicioGeneral.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraServicioGeneral.Services
{
    public class FooService : IFooService
    {
        private IFooRepository _fooRepository;
        public FooService(IFooRepository fooRepository)
        {
            _fooRepository = fooRepository;
        }
        public async Task<FooModel> GetFoo(string id)
        {
            return await _fooRepository.GetFoo(id);
        }

        public async Task<List<FooModel>> GetFoos()
        {
            return await _fooRepository.GetFoos();
        }
    }
}
