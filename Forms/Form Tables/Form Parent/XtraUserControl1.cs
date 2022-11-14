using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent
{
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControl1()
        {
            InitializeComponent();
        }

        private void XtraUserControl1_Load(object sender, EventArgs e)
        {
            Root.ExpandButtonVisible = true;
            //Root.Location = DevExpress.Utils.GroupElementLocation.AfterText;
        }
    }
}
