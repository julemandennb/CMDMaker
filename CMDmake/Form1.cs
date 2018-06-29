using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.cmdAddList.Items.Add(new { AC.CmdCode.name, AC.CmdCode.Code });

            this.CmdCode.Add(AC.CmdCode);

            //test
            this.Show();




        }
    }
}
