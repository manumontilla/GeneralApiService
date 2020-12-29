using EstructuraServicioGeneral.Interfaces.Maps;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructuraServicioGeneral.Controllers
{
    [ApiController]
    public class FooController: ControllerBase
    {
        private readonly IFooMap _fooMap;

        public FooController(IFooMap fooMap)
        {
            _fooMap = fooMap;
        }

        public async Task<IActionResult> GetFoos() {
            return Ok(await _fooMap.GetFoos());
        }

        public async Task<IActionResult> GetFoo(string idFoo) {
            return Ok(await _fooMap.GetFoo(idFoo));
        }
    }

}
