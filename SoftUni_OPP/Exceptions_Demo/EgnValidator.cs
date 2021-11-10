using System;

namespace ExceptionsDemos
{
    public enum Gender
    {
        Male = 1,
        Female = 2,
    }

    public class EgnValidator : IEgnValidator
    {
        // TODO: dictionary of cities

        /// <summary>
        /// Generate all valid EGN numbers for given criteria.
        /// </summary>
        /// <param name="birthDate">Date of birth.</param>
        /// <param name="city">The city where EGN holders are born in.</param>
        /// <param name="isMale">True for male, false for female</param>
        /// <returns>List of all valid EGN numbers</returns>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="InvalidCityException"></exception>
        public string[] Generate(DateTime birthDate, string city, bool isMale)
        {
            if (birthDate.Year < 1800) // [1800-2099]
            {
                throw new ArgumentOutOfRangeException("birthDate", "Birth date should be greater or equal to 1800");
            }

            if (birthDate.Year > 2099) // [1800-2099]
            {
                throw new ArgumentOutOfRangeException("birthDate", "Birth date should be less or equal to 2099");
            }

            if (city == null)
            {
                throw new ArgumentNullException("birthDate");
            }

            if (city != "София-град")
            {
                throw new InvalidCityException(city);
            }

            // TODO: Add more checks and exception

            return new string[0];
        }

        
        public bool Validate(string egn)
        {
            if (egn == null)
            {
                throw new ArgumentNullException("egn");
            }

            throw new NotImplementedException();
        }
    }
}
