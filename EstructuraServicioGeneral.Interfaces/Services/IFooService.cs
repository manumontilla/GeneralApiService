using EstructuraServicioGeneral.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraServicioGeneral.Interfaces.Services
{
    public interface IFooService
    {
        Task<FooModel> GetFoo(string id);
        Task<List<FooModel>> GetFoos();
    }
}
