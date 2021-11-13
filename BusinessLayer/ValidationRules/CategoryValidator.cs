using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() //constructor metodu
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Alanını Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 Karakter Girişi Yapın.");
            RuleFor(x => x.CategoryDescription).MaximumLength(20).WithMessage("Lütfen 20 Karakterden fazla değer girişi yapmayınız.");
        }
    }
}
