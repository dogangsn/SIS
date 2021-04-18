using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.App
{
    public class Message
    {
        public bool get_RecordDelete(string _Language = "")
        {
            bool _Return = false;
            //if (XtraMessageBox.Show(language.get_Word_Control("Silinecek Emin misiniz?", _Language), language.get_Word_Control("Soru", _Language), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            if (XtraMessageBox.Show("Silinecek Emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        public bool get_RecordSave(string _Language = "")
        {
            bool _Return = false;
            //if (XtraMessageBox.Show(language.get_Word_Control("Kaydedilecek Emin misiniz?", _Language), language.get_Word_Control("Soru", _Language), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            if (XtraMessageBox.Show("Kaydedilecek Emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        public bool get_Question(string _Question, string _Language = "")
        {
            bool _Return = false;
            //if (XtraMessageBox.Show(language.get_Word_Control(_Question, _Language), language.get_Word_Control("Soru", _Language), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            if (XtraMessageBox.Show(_Question, "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        public void get_Warning(string _Uyarı, string _Language = "")
        {
            //XtraMessageBox.Show(language.get_Word_Control("", _Language) + _Uyarı, language.get_Word_Control("Uyarı", _Language), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            XtraMessageBox.Show("" + _Uyarı, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void get_RecordSave_Error(string _Error, string _Language = "")
        {
            XtraMessageBox.Show("Kaydedilemedi Kayıt ! Hata:" + _Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
