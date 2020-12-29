using EstructuraServicioGeneral.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraServicioGeneral.Interfaces.Respository
{
    public interface IFooRepository
    {
        Task<FooModel> GetFoo(string id);
        Task<List<FooModel>> GetFoos();
    }
}
