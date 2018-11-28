using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnumClass;
using System.Dynamic;

namespace CMDmake
{
    public partial class AddCmd : Form
    {
        private CodeToEnum CE = new CodeToEnum();

        public dynamic CmdCode;

        private enumCmd SELEnumCmd;

        public AddCmd()
        {
            InitializeComponent();

            // add all enum from enumCmd to CMDCombobox
            foreach (var item in Enum.GetValues(typeof(enumCmd)).Cast<enumCmd>())
            {

                this.CMDCombobox.Items.Add(this.CE.GetDescriptionFromEnum(item));

            }
            // to set CMDCombobox.SelectedIndex to 0
            this.CMDCombobox.SelectedIndex = 0;
            this.CmdCode = new ExpandoObject();

        }

        /// <summary>
        /// user Selected a new index check vise group to show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CMDCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hideAllgroup();

            int indx = this.CMDCombobox.SelectedIndex;

            this.SELEnumCmd = (enumCmd)Enum.ToObject(typeof(enumCmd), (indx-1));

            switch (this.SELEnumCmd)
            {
                case enumCmd.Url:
                    this.groupUrl.Show();
                    break;
                case enumCmd.ping:
                    this.groupUrl.Show();
                    break;

            }



        }

        /// <summary>
        /// hide all group
        /// </summary>
        private void hideAllgroup()
        {
            this.groupUrl.Hide();
        }

        private void AddCmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.CmdCode.nul = false;
                if (this.SELEnumCmd == enumCmd.Url || this.SELEnumCmd == enumCmd.ping)
                {

                    this.CmdCode.name = this.CE.GetDescriptionFromEnum(this.SELEnumCmd);

                    this.CmdCode.code = this.textBoxUrl.Text;

                    this.CmdCode.EnumCmd = this.SELEnumCmd;
                }
                else
                {
                    this.CmdCode.nul = true;
                }

            }
            catch
            {
                this.CmdCode.nul = true;
            }



        }
    }
}
