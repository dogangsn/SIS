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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Name = "FormBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBase_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBase_KeyDown);
            this.ResumeLayout(false);

        }

        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormBase_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
