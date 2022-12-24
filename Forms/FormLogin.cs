using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QuanLyXiNghiepMay.Properties;
using QuanLyXiNghiepMay.R;
using QuanLyXiNghiepMay.R.ControlerForForm;
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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();

            //enter handle login
            this.AcceptButton = simpleButtonLogin;
        }

        public bool CheckLogin(string username, string password)
        {
            return username == Constance.USERNAME
                && password == Constance.PASSWORD;
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin(textEditUsername.Text, textEditPassword.Text ))
            {
                // close current form and open new form
                this.Hide();
                var ribbonFormMAIN = new FormMAIN();
                ribbonFormMAIN.Closed += (s, args) => this.Close();
                ribbonFormMAIN.Show();
            }
            else
            {
                // messagebox show error and auto close
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.AutoCloseOptions.Delay = Constance.TIME_OUT;
                args.Caption = MyTemplateString.CAPTION_LOGIN_FAIL;
                args.Text = MyTemplateString.LOGIN_FAIL;
                args.Buttons = new DialogResult[] { DialogResult.OK };
                args.DefaultButtonIndex = 0;
                args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                XtraMessageBox.Show(args).ToString();
            }
        }

        private void XtraFormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void XtraFormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void XtraFormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(MyTemplateString.MESSAGE_EXIT, MyTemplateString.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}