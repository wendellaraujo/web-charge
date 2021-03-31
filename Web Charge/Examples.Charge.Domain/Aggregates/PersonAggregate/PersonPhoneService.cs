using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();
        public async Task<PersonPhone> Add(PersonPhone personPhone)
        {
            var response = await _personPhoneRepository.Add(personPhone);
            return response;
        }
        public async Task<PersonPhone> Update(PersonPhone personPhone)
        {
            var response = await _personPhoneRepository.Update(personPhone);
            return response;
        }
        public async Task<PersonPhone> Delete(int id)
        {
            var response = await _personPhoneRepository.Delete(id);
            return response;
        }
    }
}
