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
        /// til at faer Description
        /// </summary>
        /// <param name="FruitType"></param>
        /// <returns></returns>
        public string GetDescriptionFromEnum(Enum FruitType)
        {
            FieldInfo fi = FruitType.GetType().GetField(FruitType.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return FruitType.ToString();
            }
        }
    }
}
