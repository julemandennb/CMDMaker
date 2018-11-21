using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMDFileMaker.objFolde;
using EnumClass;

namespace CMDFileMaker
{
    public class controller
    {

        private List<objectClass> CmdCode;
        private List<string> codeTOFile;

        public controller(List<objectClass> CmdCode)
        {
            this.CmdCode = CmdCode;
            this.codeTOFile = new List<string>();



            foreach(objectClass itme in this.CmdCode)
            {
                if(itme.GetSetenumCmd == enumCmd.Url)
                {
                    UrlClass url = new UrlClass(itme.GetSetCode);
                    this.codeTOFile.Add(url.getCMDCode());
                }
                else if(itme.GetSetenumCmd == enumCmd.ping)
                {

                    PingClass ping = new PingClass(itme.GetSetCode);
                    this.codeTOFile.Add(ping.getCMDCode());

                }






            }


            FileMarker FF = new FileMarker(this.codeTOFile);
        }



    }
}
