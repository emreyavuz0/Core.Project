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
			RuleFor(x => x.WriterPassword).Equal(x => x.WriterConfirmPassword).WithMessage("Şifre Eşleşmiyor");
			RuleFor(x => x.WriterPassword).Matches("[A-Z]").WithMessage("En az bir büyük karakter kullanmalısın");
			RuleFor(x => x.WriterPassword).Matches("[a-z]").WithMessage("En az bir küçük karakter kullanmalısın");
			RuleFor(x => x.WriterPassword).Matches("[0-9]").WithMessage("En az bir sayı karakteri kullanmalısın");
			RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("En az 8 karakter kullanmalısınız");
		}
	}
}
