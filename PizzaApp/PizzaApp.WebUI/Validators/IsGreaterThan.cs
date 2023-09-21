using System.ComponentModel.DataAnnotations;

namespace PizzaApp.WebUI.Validators
{
    public class IsGreaterThan : ValidationAttribute
    {
        public IsGreaterThan(double value)
        {
            this.Value = value;
        }

        public double Value { get; set; }

        public override bool IsValid(object? value)
        {
            var intValue = value as double?;

            if (intValue == null)
            {
                return false;
            }

            if (intValue == 0)
            {
                return false;
            }

            if (intValue < Value)
            {
                return false;
            }

            return true;
        }
    }
}
