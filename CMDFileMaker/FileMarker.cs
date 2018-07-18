using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CMDFileMaker
{
    class FileMarker
    {

      

        public FileMarker(List<string> codeTOFile)
        {
           


            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            this.makefile(codeTOFile, folderPath);


        }


        private void makefile(List<string> codeTOFile, string folderPath)
        {
            string path = folderPath + @"\MyTest.cmd";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                    foreach(string text in codeTOFile)
                    {
                        sw.WriteLine(text);
                    }
                }
            }



        }




    }
}
