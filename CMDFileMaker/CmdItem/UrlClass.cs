using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFileMaker
{
    internal class UrlClass
    {
        private string url;

        public UrlClass(string url)
        {

            this.url = url;


        }


        public string getCMDCode()
        {

            return "explorer " + this.url;


        }

    }
}
