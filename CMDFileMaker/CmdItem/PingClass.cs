using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFileMaker
{
   public class PingClass
    {

        private string url;

        public PingClass(string url)
        {
            this.url = url;


        }


        public string getCMDCode()
        {

            return "ping " + this.url;


        }


    }
}
