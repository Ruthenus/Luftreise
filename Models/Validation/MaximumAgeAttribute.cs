using System.ComponentModel.DataAnnotations;

namespace Luftreise_Command_project_.Models.Validation
{
    public class MaximumAgeAttribute : ValidationAttribute
    {
        private readonly int _maximumAge;

        public MaximumAgeAttribute(int maximumAge)
        {
            _maximumAge = maximumAge;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Вкажіть дату народження");

            if (value is not DateTime birthDate)
                return new ValidationResult("Невірна дата народження");

            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
                age--;

            if (birthDate > today)
                return new ValidationResult("Дата народження не може бути в майбутньому");

            if (age > _maximumAge)
                return new ValidationResult($"Користувач повинен мати щонайбільше {_maximumAge} роки");

            return ValidationResult.Success;
        }
    }
}