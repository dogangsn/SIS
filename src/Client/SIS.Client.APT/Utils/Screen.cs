using SIS.Client.APT.APT.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.Client.APT.Utils
{
    public class Screen
    {
        public void Info(Form _MdiForm)
        {
            Info _info = new Info();
            _info.MdiParent = _MdiForm;
            _info.Show();
        }
    }
}
