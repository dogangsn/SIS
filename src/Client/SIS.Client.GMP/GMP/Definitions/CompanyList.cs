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
using SIS.Model.Models.GMP.Definitions;

namespace SIS.App.Screens.GMP.Definitions
{
    public partial class CompanyList : DevExpress.XtraEditors.XtraForm
    {
        //Repository _repository;
        public CompanyList()
        {
            InitializeComponent();
            //_repository = new Repository();
        }

        List<CompanyDTO> _List_Company = new List<CompanyDTO>();


        #region Record
        public void do_refresh()
        {
            //_List_Company = _repository.Run<DefinitionsService, List<CompanyDTO>>(x => x.GetList_Company());
            //bs_companyList.DataSource = _List_Company;
        }

        #endregion

        #region FORM

        private void CompanyList_Load(object sender, EventArgs e)
        {
            do_refresh();
        }



        #endregion

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CompanyDTO oRow = (CompanyDTO)gcv_company.GetFocusedRow();
            if (oRow != null)
            {
                //if (bl.message.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                //{
                //    var result = _repository.Run<DefinitionsService, ActionResponse<CompanyDTO>>(x => x.DeleteCompany(oRow.RecId));
                //    do_refresh();
                //}
            }
        }

        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bl.GMP.CompanyEdit(Data.FormOpenType.New, 0);
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (CompanyDTO)gcv_company.GetFocusedRow();
            if (oRow == null) return;
            //bl.GMP.CompanyEdit(Data.FormOpenType.Edit, oRow.RecId);
            
        }

        private void bbi_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
    }
}