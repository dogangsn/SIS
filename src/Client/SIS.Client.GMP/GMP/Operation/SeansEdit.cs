using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SIS.Data;

namespace SIS.App.Screens.GMP.Operation
{
    public partial class SeansEdit : DevExpress.XtraEditors.XtraForm
    {
        public SeansEdit()
        {
            InitializeComponent();
        }

        public FormOpenType _FormOpenType;
        public OperationProductType _operationType;

        #region Record
        private void empty_control()
        {

        }

        private void do_save()
        {

        }
        private void do_Refresh_List_Form()
        {
            //Form _Form = FormTool.get_OpenForm("CustomerList");
            //if (_Form != null)
            //{
            //    ((CustomerList)_Form).do_refresh();
            //}
            //_Form = null;

        }
        #endregion

        private void SeansEdit_Load(object sender, EventArgs e)
        {

        }
    }
}