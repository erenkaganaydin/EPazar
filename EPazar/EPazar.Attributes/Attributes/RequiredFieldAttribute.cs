using System;
using System.Reflection;

namespace EPazar.Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public sealed class RequiredFieldAttribute : Attribute
    {
        public static class RequiredField
        {
            #region Properties

            private static string value;

            #endregion Properties

            #region Check

            public static bool Check(object type)
            {
                var valueType = type.GetType();
                var property = valueType.GetProperties();

                foreach (PropertyInfo item in property)
                {
                    var requiredProperty = item.GetCustomAttributes(typeof(RequiredFieldAttribute), true);

                    if (requiredProperty.Length == 0)
                    {
                        switch (item.GetValue(type).GetType().Name)
                        {
                            case "Int16":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "Int32":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "Int64":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "ushort":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "short":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "Double":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "Decimal":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "String":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "Boolean":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            case "Single":
                                value = item.GetValue(type)
                                            .ToString();
                                break;

                            default:
                                break;
                        }

                        if (string.IsNullOrEmpty(value))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            #endregion Check
        }
    }
}