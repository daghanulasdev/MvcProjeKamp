using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adini bos gecemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadini bos gecemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkimda kismini bos gecemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kismini bos gecemezsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail kismini bos gecemezsiniz");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lutfen en az 2 karakter girisi yapiniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lutfen 50 karakterden fazla deger girisi yapmayiniz");

            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lutfen en az 2 karakter girisi yapiniz");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lutfen 50 karakterden fazla deger girisi yapmayiniz");


        }
    }
}
