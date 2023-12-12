using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel 2 alanı boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Alanı Boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı En Az 100 Karakterden Oluşmaktadır");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmaktadır");

        }
    }
}
