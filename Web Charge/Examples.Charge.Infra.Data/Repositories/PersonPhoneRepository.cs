using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public async Task<PersonPhone> Add(PersonPhone personPhone)
        {
            _context.PersonPhone.Add(personPhone);
            await _context.SaveChangesAsync();
            return personPhone;
        }

        public async Task<PersonPhone> Update(PersonPhone personPhone)
        {
            _context.PersonPhone.Update(personPhone);
            await _context.SaveChangesAsync();
            return personPhone;
        }

        public async Task<PersonPhone> Delete(int id)
        {
            var personPhone = await _context.PersonPhone
                     .SingleOrDefaultAsync(x => x.BusinessEntityID == id);

            _context.PersonPhone.Remove(personPhone);
            await _context.SaveChangesAsync();
            return personPhone;

        }
    }
}
