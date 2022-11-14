using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.R.ControlerForForm
{
    internal class ControlerMain
    {

        internal static void openForm(RibbonFormMAIN ribbonFormMain, Type formType)
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

        internal static void showForm(RibbonFormMAIN ribbonFormMain, Form form)
        {
            form.MdiParent = ribbonFormMain;
            form.Show();
        }

        internal static void showForm(FormMain formMain, Form form)
        {
            form.MdiParent = formMain;
            form.Show();
        }

        internal static void showFormNoAttactParent(FormMain formMain, Form form)
        {
            form.Show();
        }

        internal static void exitForm(FormMain formMain)
        {
            if (Controler.isMessageBox(TemplateString.MESSAGE_EXIT, TemplateString.TITLE_WARNING))
            {
                formMain.Dispose();
            }
        }
    }
}
