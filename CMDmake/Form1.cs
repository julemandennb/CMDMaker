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

namespace CMDmake
{
    public partial class Form1 : Form
    {
        private List<dynamic> CmdCode;

        public Form1()
        {
            InitializeComponent();

            this.CmdCode = new List<dynamic>();
        }

        private void AddCmd_Click(object sender, EventArgs e)
        {

            this.Hide();

            AddCmd AC = new AddCmd();

            AC.ShowDialog();


            if (AC.CmdCode.nul == false)
            {

                this.cmdAddList.Items.Add(new { AC.CmdCode.name, AC.CmdCode.code });

                this.CmdCode.Add(AC.CmdCode);
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
