using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.App.Tools
{
    public class FormTool
    {
        public static Form get_OpenForm(string _FormName, string tagName = "")
        {
            Form _FormHave = null;
            foreach (Form _Form in Application.OpenForms)
            {
                if (string.IsNullOrEmpty(tagName))
                {
                    if (_Form.Name == _FormName)
                    {
                        _FormHave = _Form;
                        break;
                    }
                }
                else
                {
                    if (_Form.Tag != null && _Form.Tag.ToString() == tagName)
                    {
                        _FormHave = _Form;
                        break;
                    }
                }
            }

            return _FormHave;

        }
    }
}
