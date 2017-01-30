using FluentValidation;
using Greysis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Services
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            base.RuleFor(t => t.CategoryName).NotEmpty();
            base.RuleFor(t => t.ID).NotEmpty();
        }

    }
}
