using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private IPersonPhoneService _personPhoneService;
        private IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonPhoneResponse> Add(PersonPhoneDto personPhoneDto)
        {
            var personPhone = _mapper.Map<PersonPhoneDto, PersonPhone>(personPhoneDto);
            var personPhoneResponse = await _personPhoneService.Add(personPhone);
            var response = new PersonPhoneResponse();
            response.PersonPhoneObject = new PersonPhoneDto();
            response.PersonPhoneObject = _mapper.Map<PersonPhone, PersonPhoneDto>(personPhoneResponse);
            return response;
        }

        public async Task<PersonPhoneResponse> Delete(int id)
        {
            var personPhoneResponse = await _personPhoneService.Delete(id);
            var response = new PersonPhoneResponse();
            response.PersonPhoneObject = new PersonPhoneDto();
            response.PersonPhoneObject = _mapper.Map<PersonPhone, PersonPhoneDto>(personPhoneResponse);
            return response;

        }

        public async Task<PersonPhoneResponse> Update(PersonPhoneDto personPhoneDto)
        {
            var personPhone = _mapper.Map<PersonPhoneDto, PersonPhone>(personPhoneDto);
            var personPhoneResponse = await _personPhoneService.Update(personPhone);
            var response = new PersonPhoneResponse();
            response.PersonPhoneObject = new PersonPhoneDto();
            response.PersonPhoneObject = _mapper.Map<PersonPhone, PersonPhoneDto>(personPhoneResponse);
            return response;
        }

        public async Task<PersonPhoneResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonPhoneResponse();
            response.PersonPhoneObjects = new List<PersonPhoneDto>();
            response.PersonPhoneObjects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
            return response;
        }

       
    }
}
