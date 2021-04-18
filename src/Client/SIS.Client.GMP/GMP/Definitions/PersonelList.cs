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
using SIS.Data.App;
using SIS.Data;
using SIS.Model.Models.Utilities;
using SIS.Client.GMP.Utils;

namespace SIS.App.Screens.GMP.Definitions
{
    public partial class PersonelList : DevExpress.XtraEditors.XtraForm
    {
        public PersonelList()
        {
            InitializeComponent();
        }

        public List<PersonelsDTO> __dl_List_Personels = new List<PersonelsDTO>();
        GetValue _getValue = new GetValue(); 

        #region Record

        public void do_refresh()
        {
            try
            {
                //_getValue.CompanyId = AppMain.CompanyRecId;
                //__dl_List_Personels = bl._repository.Run<DefinitionsService, List<PersonelsDTO>>(x => x.GetList_Personel(_getValue));
                //bs_Personels.DataSource = __dl_List_Personels;
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        private void PersonelList_Load(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bl.GMP.PersonelEdit(FormOpenType.New, 0);
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (PersonelsDTO)gcv_PersonelList.GetFocusedRow();
            if (oRow == null) return;
            //bl.GMP.PersonelEdit(FormOpenType.Edit, oRow.RecId);
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelsDTO oRow = (PersonelsDTO)gcv_PersonelList.GetFocusedRow();
            if (oRow != null)
            {
                if (bl.message.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    //var result = bl._repository.Run<DefinitionsService, ActionResponse<PersonelsDTO>>(x => x.DeletePersonel(oRow.RecId));
                    //do_refresh();
                }
            }
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
    }
}