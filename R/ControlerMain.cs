using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.R.ControlerForForm
{
    public class ControlerMain
    {

        public static void openForm(FormMAIN ribbonFormMain, Type formType)
        {
            foreach (Form form in ribbonFormMain.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    form.Activate();
                    return;
                }
            }

            Form formNew = (Form)Activator.CreateInstance(formType);
            showForm(ribbonFormMain, formNew);
        }

        internal static void showForm(FormMAIN ribbonFormMain, Form form)
        {
            form.MdiParent = ribbonFormMain;
            form.Show();
        }

        internal static void showForm(FormMainOld formMain, Form form)
        {
            form.MdiParent = formMain;
            form.Show();
        }

        internal static void showFormNoAttactParent(FormMainOld formMain, Form form)
        {
            form.Show();
        }

        internal static void exitForm(Form form)
        {
            if (Controler.isMessageBox(MyTemplateString.MESSAGE_EXIT, MyTemplateString.TITLE_WARNING))
            {
                form.Dispose();
            }
        }
    }
}
