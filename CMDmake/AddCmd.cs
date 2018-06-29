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


            foreach (var item in Enum.GetValues(typeof(enumCmd)).Cast<enumCmd>())
            {

                this.CMDCombobox.Items.Add(this.CE.GetDescriptionFromEnum(item));

            }



            dynamic MyDynamic = new ExpandoObject();

            MyDynamic.name = "hey";

            MyDynamic.Code = enumCmd.Url;

            this.CmdCode = MyDynamic;
        }

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
                   
                    break;

            }



        }

        private void hideAllgroup()
        {
            this.groupUrl.Hide();
        }
    }
}
