using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumClass;

namespace CMDFileMaker
{
    public class controller
    {

        private List<dynamic> CmdCode;
        private string codeTOFile;

        public controller(List<dynamic> CmdCode)
        {
            this.CmdCode = CmdCode;




            foreach(dynamic itme in this.CmdCode)
            {
                if(itme.EnumCmd == enumCmd.Url)
                {
                    UrlClass url = new UrlClass(itme.code);

                }
                else if(itme.EnumCmd == enumCmd.Url)
                {

                }






            }
        }



    }
}
