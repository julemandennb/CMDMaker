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
    }
}
