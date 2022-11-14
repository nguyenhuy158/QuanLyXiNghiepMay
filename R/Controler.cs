using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.R
{
    internal class Controler
    {
        internal static bool isMessageBox(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK;
        }

        internal static void messageBoxShow(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        internal static bool isTextInputValid(string text)
        {
            return String.IsNullOrEmpty(text) == false && text.Length < 50;
        }

        internal static bool isNumberInputValid(int num)
        {
            return num > 0;
        }

        internal static bool isNumberInputValid(string text)
        {
            return isNumberInputValid(int.Parse(text));
        }

        internal static void loadDataSource(DataGridView dataGridView1, string KEY)
        {
            (new Precenter()).getData(dataGridView1, KEY);
        }
    }
}
