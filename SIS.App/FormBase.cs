using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.App
{
    public class FormBase : DevExpress.XtraEditors.XtraForm
    {
        protected override void OnLoad(EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyPreview = true;

            base.OnLoad(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
