using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMDFileMaker;
using CMDFileMaker.objFolde;

namespace CMDmake
{
    public partial class Form1 : Form
    {
        private List<objectClass> CmdCode;

        public Form1()
        {
            InitializeComponent();

            this.CmdCode = new List<objectClass>();
        }

        private void AddCmd_Click(object sender, EventArgs e)
        {

            this.Hide();

            AddCmd AC = new AddCmd();

            AC.ShowDialog();


            if (AC.CmdCode.nul == false)
            {

                this.cmdAddList.Items.Add(new { AC.CmdCode.name, AC.CmdCode.code });


                this.CmdCode.Add(new objectClass(AC.CmdCode.name,AC.CmdCode.EnumCmd, AC.CmdCode.code));
            }

            this.Show();




        }

        private void buttonMaker_Click(object sender, EventArgs e)
        {
            if (this.CmdCode.Count > 0)
            {
                controller CT = new controller(this.CmdCode);
            }
            else
            {
                MessageBox.Show("No CMD code set");
            }

        }
    }
}
