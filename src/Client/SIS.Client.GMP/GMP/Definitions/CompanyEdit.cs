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
using SIS.App.Tool;
using SIS.Model.Models.Utilities;
using System.IO;
using SIS.Client.GMP.Utils;

namespace SIS.App.Screens.GMP.Definitions
{
    public partial class CompanyEdit : DevExpress.XtraEditors.XtraForm
    {
        public CompanyEdit()
        {
            InitializeComponent();
        }

        AppTools appTools = new AppTools();
        public SIS.Data.FormOpenType _FormOpenType;
        byte[] imgbyte;

        public CompanyDTO __company = new CompanyDTO();

        #region record

        private void do_save()
        {
            if (bl.message.get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    bs_Company.EndEdit();
                    if (imgbyte != null)
                    {
                        __company.Logo = imgbyte;
                    }
                    //var response = bl._repository.Run<DefinitionsService, ActionResponse<CompanyDTO>>(x => x.Save_Company(__company));
                    //if (response.ResponseType != ResponseType.Ok)
                    //{
                    //    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //}
                    //else
                    //{
                    //    this.Close();
                    //}
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void CompanyEdit_Load(object sender, EventArgs e)
        {
            if (_FormOpenType == Data.FormOpenType.New)
            {

            }
            if (_FormOpenType == Data.FormOpenType.Edit)
            {

            }
            bs_Company.DataSource = __company;
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void btnLogoYukle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image to Upload.";
                dlg.Filter = "Image File (*.jpg;*.bmp;*.gif,*.png)|*.jpg;*.bmp;*.gif;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        String imageName = dlg.FileName;
                        Bitmap bmp = new Bitmap(imageName);
                        pcLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                        pcLogo.Image = (Image)bmp;
                        FileStream fstream = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                        imgbyte = new byte[fstream.Length];
                        fstream.Read(imgbyte, 0, Convert.ToInt32(fstream.Length));
                        fstream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void btn_LogoSil_Click(object sender, EventArgs e)
        {
            pcLogo.Image = null;
            __company.Logo = null;
        }
    }
}