using System;

namespace RC.FluentValidation.Validation
{
    public class CustomValidation
    {
        public static bool BeValidDate(DateTime date)
        {
            return !date.Equals(default);
        }
    }
}
