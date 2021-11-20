using System.Linq;
using System.Reflection;
using BindingFlags = System.Reflection.BindingFlags;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {

            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute customAttribute = (MyValidationAttribute)property
                    .GetCustomAttribute(typeof(MyValidationAttribute));
                bool IsValidated = customAttribute.IsValid(property.GetValue(obj));
                if (!IsValidated)
                {
                    return false;
                }
            }


            return true;
        }
    }
}