using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.Data.Entities.Identity;
using Back.Models;

namespace Back.Validations
{
    public class LoginVMValidator : AbstractValidator<LoginViewModel>
    {
        public LoginVMValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email address is required!")
                .EmailAddress().WithMessage("Email is not valid!");
            RuleFor(x => x.Password)
                .NotEmpty().WithName("Password").WithMessage("Password is required")
                .MinimumLength(5).WithName("Password").WithMessage("Password minimum length is 5");
            //.Matches("[A-Z]").WithName("Password").WithMessage("Password must contain one or more capital letters.")
            //.Matches("[a-z]").WithName("Password").WithMessage("Password must contain one or more lowercase letters.")
            //.Matches(@"\d").WithName("Password").WithMessage("Password must contain one or more digits.")
            //.Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithName("Password").WithMessage("Password must contain one or more special characters.")
            //.Matches("^[^£# “”]*$").WithName("Password").WithMessage("Password must not contain the following characters £ # “” or spaces.");
            RuleFor(x => x.AcceptedTerms)
                .NotEmpty().WithMessage("Не согласні з нашими правилами");
                //Must(x => x == false || x == true)


        }
    }
}
