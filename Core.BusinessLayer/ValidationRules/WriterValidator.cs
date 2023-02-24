using Core.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad soyad boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-Posta adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Minimum 2 karakter girmelisiniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Maksimum 50 karakter girebilirsiniz");
        }
    }
}
