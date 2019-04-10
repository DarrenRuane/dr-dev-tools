using System;
using System.ComponentModel;
using System.Linq;

namespace DRDevTools.Utility.ExtensionMethods
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns the Description of the specific value of the Enum passed in as 'value' if it has one.
        /// Returns the ToString() of the Enum value otherwise.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            if (fi == null)
                return value.ToString();

            var attribute = fi.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
            if (attribute == null)
                return value.ToString();

            var description = ((DescriptionAttribute)attribute).Description;
            return string.IsNullOrEmpty(description) ? value.ToString() : description;
        }

        /// <summary>
        /// Returns a string array of the Descriptions* of the Enum Type. 
        /// Note that this function operates on the Type and not a Value of the Enum.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <remarks>
        /// * Or their value.ToString() result if a Description Attribute is undefined
        /// </remarks>
        public static string[] GetDescriptions(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");

            if (!enumType.IsEnum)
                throw new InvalidOperationException("Type must be an enum.");

            var valuesWithinTheEnum = Enum.GetValues(enumType).Cast<Enum>().ToList();
            var numberOfValuesInTheEnum = valuesWithinTheEnum.Count;

            var descriptions = new string[numberOfValuesInTheEnum];

            for (var i = 0; i < numberOfValuesInTheEnum; i++)
                descriptions[i] = valuesWithinTheEnum[i].GetDescription();

            return descriptions;
        }
    }
}