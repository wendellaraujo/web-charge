using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        Task<List<PersonPhone>> FindAllAsync();
        Task<PersonPhone> Add(PersonPhone personPhone);
        Task<PersonPhone> Update(PersonPhone personPhone);
        Task<PersonPhone> Delete(int id);
    }
}
