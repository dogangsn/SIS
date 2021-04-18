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

namespace SIS.App.Screens.GMP.Customer
{
    public partial class ReservationList : DevExpress.XtraEditors.XtraForm
    {
        public ReservationList()
        {
            InitializeComponent();
        }

        private void bbi_NewReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReservationEdit frm = new ReservationEdit();
            frm.ShowDialog();
        }
    }
}