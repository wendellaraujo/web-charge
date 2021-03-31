using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneResponse> FindAllAsync();

        Task<PersonPhoneResponse> Add(PersonPhoneDto personPhoneDto);

        Task<PersonPhoneResponse> Update(PersonPhoneDto personPhoneDto);

        Task<PersonPhoneResponse> Delete(int id);

    }
}
