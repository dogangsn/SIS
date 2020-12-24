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
using SIS.App.Tool;
using SIS.Model.Models.GMP.Definitions;

namespace SIS.App.Screens.GMP.Definitions
{
    public partial class PersonelEdit : DevExpress.XtraEditors.XtraForm
    {
        public PersonelEdit()
        {
            InitializeComponent();
        }


        AppTools appTools = new AppTools();
        public SIS.Data.FormOpenType _FormOpenType;

        public PersonelsDTO _personels = new PersonelsDTO();


        private void PersonelEdit_Load(object sender, EventArgs e)
        {
            bs_Personels.DataSource = _personels;
        }
    }
}