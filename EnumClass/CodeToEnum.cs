using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumClass
{
    public class CodeToEnum
    {


        /// <summary>
        /// to get description from Enum
        /// </summary>
        /// <param name="enumCmd"></param>
        /// <returns></returns>
        public string GetDescriptionFromEnum(Enum enumCmd)
        {
            FieldInfo fi = enumCmd.GetType().GetField(enumCmd.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return enumCmd.ToString();
            }
        }
    }
}
