using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormThongTinTacGia : Form
    {
        public FormThongTinTacGia()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/nguyenhuy158");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nguyenhuy158");
        }
    }
}
