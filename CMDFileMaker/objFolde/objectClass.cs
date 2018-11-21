using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumClass;

namespace CMDFileMaker.objFolde
{
   public class objectClass
    {

        private string Name;

        private enumCmd enumCmd;

        private string Code;

        public objectClass(string name, enumCmd enumCmd, string code)
        {
            this.Name = name;

            this.enumCmd = enumCmd;

            this.Code = code;
             
        }

        #region Get Set fun
        public string GetSetName { get { return this.Name; } set { this.Name = value; } }

        public enumCmd GetSetenumCmd { get { return this.enumCmd; } set { this.enumCmd = value; } }

        public string GetSetCode { get { return this.Code; } set { this.Code = value; } }



        #endregion




    }
}
