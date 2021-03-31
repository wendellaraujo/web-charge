using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpPost]
        public async Task<ActionResult<PersonPhoneRequest>> Add([FromBody] PersonPhoneDto personPhoneDto)
        {
            var response = await _facade.Add(personPhoneDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<PersonPhoneRequest>> Update([FromBody] PersonPhoneDto personPhoneDto)
        {
            var response = await _facade.Update(personPhoneDto);
            return Ok(response);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var response = await _facade.Delete(id);
            return Ok(response);
        }
       

    }
}
