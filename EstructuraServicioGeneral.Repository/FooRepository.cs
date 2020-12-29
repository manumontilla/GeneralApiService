using EstructuraServicioGeneral.Interfaces.Respository;
using EstructuraServicioGeneral.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstructuraServicioGeneral.Repository
{
    public class  FooRepository : IFooRepository
    {
   
        public async Task<FooModel> GetFoo(string id)
        {
            // Consulta BD
            FooModel foo = new FooModel() { id = "Clave", nombre = "Nombre Foo", visible = true };
            return foo;
        }



        public async Task<List<FooModel>> GetFoos()
        {
            FooModel foo1 = new FooModel() { id = "Clave1", nombre = "Nombre Foo 1", visible = true };
            FooModel foo2= new FooModel() { id = "Clave2", nombre = "Nombre Foo 2", visible = true };
            List<FooModel> listFoo = new List<FooModel>();
            listFoo.Add(foo1);
            listFoo.Add(foo2);
            return listFoo;
        }
    }
}
