using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();
        Task<PersonPhone> Add(PersonPhone personPhone);
        Task<PersonPhone> Update(PersonPhone personPhone);
        Task<PersonPhone> Delete(int id);
    }
}
