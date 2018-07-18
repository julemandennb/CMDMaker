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
        private List<string> codeTOFile;

        public controller(List<dynamic> CmdCode)
        {
            this.CmdCode = CmdCode;
            this.codeTOFile = new List<string>();



            foreach(dynamic itme in this.CmdCode)
            {
                if(itme.EnumCmd == enumCmd.Url)
                {
                    UrlClass url = new UrlClass(itme.code);
                    this.codeTOFile.Add(url.getCMDCode());
                }
                else if(itme.EnumCmd == enumCmd.ping)
                {

                    PingClass ping = new PingClass(itme.code);
                    this.codeTOFile.Add(ping.getCMDCode());

                }






            }
        }



    }
}
