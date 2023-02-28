using Core.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLayer.ValidationRules
{
	public class ContactValidator:AbstractValidator<Contact>
	{
		public ContactValidator() 
		{
			RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("Ad bölümü boş geçilemez.");
			RuleFor(x => x.ContactMail).NotEmpty().WithMessage("E-Posta bölümü boş geçilemez.");
			RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Konu bölümü boş geçilemez.");
			RuleFor(x => x.ContactMessage).MinimumLength(50).WithMessage("Mesaj bölümü en az 50 karakter girmelisiniz.");
			RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mesaj bölümü boş geçilemez.");
		}
	}
}
