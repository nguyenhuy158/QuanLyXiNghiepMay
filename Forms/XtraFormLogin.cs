using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QuanLyXiNghiepMay.Properties;
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

        private void XtraFormLogin_Load(object sender, EventArgs e)
        {
            //// Show a splashscreen.
            //FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            //op.Title = "When Only The Best Will Do";
            //op.Subtitle = "DevExpress WinForms Controls";
            //op.RightFooter = "Starting...";
            //op.LeftFooter = "Copyright © 2000 - 2020 Developer Express Inc." + Environment.NewLine + "All Rights reserved.";
            ////op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            ////op.OpacityColor = Color.Gray;
            ////op.Opacity = 130;
            ////op.LogoImageOptions.Image = Resources.icon_logo;

            //DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(
            //    op,
            //    parentForm: this,
            //    useFadeIn: true,
            //    useFadeOut: true
            //);

            ////Do an operation
            //Thread.Sleep(Constance.TIME_OUT);
            ////...

            ////Close the splashscreen
            //DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            //// Logo image.
            //Image myLogoImage = Resources.icon_logo;

            //// Show a splashscreen.
            //SplashScreenManager.ShowSkinSplashScreen(
            //    logoImage: myLogoImage,
            //    title: "When Only The Best Will Do",
            //    subtitle: "DevExpress WinForms Controls",
            //    footer: "Copyright © 2000 - 2020 Developer Express Inc." + Environment.NewLine + "All Rights reserved.",
            //    loading: "Starting...",
            //    parentForm: this
            //);

            ////Do an operation
            ////...
            //Thread.Sleep(Constance.TIME_OUT);


            ////Close the splashscreen
            //DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
    }
}