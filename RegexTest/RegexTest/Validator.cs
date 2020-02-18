using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Validator : AbstractValidator<Vendas>
    {
        public void VendasValidator()
        {
            RuleFor(v => v.Data).Must(ValidateData).WithMessage("Data preenchida incorretamente.");
        }

        public bool ValidateData(DateTime data)
        {
            string compare = data.ToString();
            Regex rgx = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            return rgx.IsMatch(compare); 
        }
    }
}
