using DevExpress.XtraEditors;
using QuanLyXiNghiepMay.R;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyXiNghiepMay
{
    public partial class XtraFormLogin : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormLogin()
        {
            InitializeComponent();

            //enter handle login
            this.AcceptButton = simpleButtonLogin;
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            if (textEditUsername.Text == Constance.USERNAME
                && textEditPassword.Text == Constance.PASSWORD)
            {
                // close current form and open new form
                this.Hide();
                var ribbonFormMAIN = new RibbonFormMAIN();
                ribbonFormMAIN.Closed += (s, args) => this.Close();
                ribbonFormMAIN.Show();
            }
            else
            {
                // messagebox show error and auto close
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.AutoCloseOptions.Delay = Constance.TIME_OUT;
                args.Caption = TemplateString.CAPTION_LOGIN_FAIL;
                args.Text = TemplateString.LOGIN_FAIL;
                args.Buttons = new DialogResult[] { DialogResult.OK };
                args.DefaultButtonIndex = 0;
                args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(args).ToString();
            }
        }

        private void XtraFormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}