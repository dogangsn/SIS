using SIS.App.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.App
{
    public class Screns
    {
        public void Help(Form _MdiForm)
        {
            Helps Help = new Helps();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }




    }
}
