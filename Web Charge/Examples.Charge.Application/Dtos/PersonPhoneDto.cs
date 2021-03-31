using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Examples.Charge.Application.Dtos
{
    public class PersonPhoneDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int BusinessEntityID { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int PhoneNumberTypeID { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string PhoneNumber { get; set; }
    }
}
