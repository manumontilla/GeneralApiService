using EstructuraServicioGeneral.Interfaces.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace EstructuraServicioGeneralNoCore.Controllers
{
  
    public class FooController : ApiController
    {
        private IFooMap _fooMap;
        public FooController(IFooMap fooMap)
        {
            _fooMap = fooMap;
        }

        /// <summary>
        /// Función que trae todos los Foo
        /// </summary>
        /// <returns>Foos para mostrar en la web</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("api/Foo")]
        public async Task<IHttpActionResult> GetFoos()
        {
            return Ok(await _fooMap.GetFoos());
        }

        /// <summary>
        /// Funcion que trae el foo seleccionado
        /// </summary>
        /// <param name="idFoo">idFoo a traer</param>
        /// <returns>Foo para mostrar en la web</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("api/Foo/{idFoo}")]
        public async Task<IHttpActionResult> GetFoo(string idFoo)
        {
            return Ok(await _fooMap.GetFoo(idFoo));
        }
    }
}