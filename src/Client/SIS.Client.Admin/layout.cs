using SIS.Client.blvalue;
using SIS.Data.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.Client.Admin
{
    public class layout
    {
        public void get_Layout(Form _Form)
        {
            if (AppMain.List_FormLayouts.Where(l => l.ApplicationId == blvalue.AplicationId && l.UserCode == AppMain.AppValue.UserCode && l.FormName == _Form.Name).Count() == 0)
            {
                List<SIS.Entity.Entities.Admin.FormLayouts> _List_FormLayouts = new List<SIS.Entity.Entities.Admin.FormLayouts>();
                switch (AppMain.AppId)
                {
                    case 1:
                        GetValue _GetValue = bl.get_GetValue();
                        _GetValue.IdStr = AppMain.AppValue.UserCode;
                        _GetValue.IdStr2 = _Form.Name;
                        //_List_FormLayouts = bl.blcErp.Run<SIS.Service.Erp.AdminErpService, List<SIS.Entity.Entities.Admin.FormLayouts>>(r => r.get_FormLayouts_List(_GetValue));
                        AppMain.List_FormLayouts.AddRange(_List_FormLayouts);

                        if (_List_FormLayouts.Count == 0)
                        {
                            return;
                        }
                        break;

                    case 2:

                        GetValue _GetValue2 = bl.get_GetValue();
                        _GetValue2.IdStr = AppMain.AppValue.UserCode;
                        _GetValue2.IdStr2 = _Form.Name;
                        //_List_FormLayouts = bl.blchotel.Run<SIS.Service.Pms.AdminHotelService, List<SIS.Entity.Entities.Admin.FormLayouts>>(r => r.get_FormLayouts_List(_GetValue2));
                        AppMain.List_FormLayouts.AddRange(_List_FormLayouts);

                        if (_List_FormLayouts.Count == 0)
                        {
                            return;
                        }
                        break;

                    case 12:

                        GetValue _GetValue3 = bl.get_GetValue();
                        _GetValue3.IdStr = AppMain.AppValue.UserCode;
                        _GetValue3.IdStr2 = _Form.Name;
                        //_List_FormLayouts = bl.blcIK.Run<SIS.Service.Hr.Services.Admin.AdminService, List<SIS.Entity.Entities.Admin.FormLayouts>>(r => r.get_FormLayouts_List(_GetValue3));
                        AppMain.List_FormLayouts.AddRange(_List_FormLayouts);
                        if (_List_FormLayouts.Count == 0)
                        {
                            return;
                        }
                        break;

                }

            }
            foreach (Control oControl in _Form.Controls)
            {
                get_Layout_Control(_Form.Name, oControl);
            }
        }

        public void get_Layout(string _FormName, DevExpress.XtraBars.Docking.DockManager _DockManager)
        {
            try
            {
                if (!AppMain.List_FormLayouts.Any(l => l.ApplicationId == blvalue.AplicationId && l.UserCode == AppMain.AppValue.UserCode && l.FormName == _FormName && l.ControlName == "dockManager1"))
                {

                    SIS.Entity.Entities.Admin.FormLayouts _FormLayoutss = bl.blcAdmin.Run<SIS.Service.Admin.AdminService, SIS.Entity.Entities.Admin.FormLayouts>(r => r.get_FormLayouts(AppMain.AppValue.ConApp, AppMain.AppValue.UserCode, _FormName, "dockManager1"));

                    if (_FormLayoutss != null)
                    {
                        AppMain.List_FormLayouts.Add(_FormLayoutss);
                    }
                    else
                    {
                        if (AppMain.List_FormLayouts.Any(l => l.ApplicationId == blvalue.AplicationId && l.UserCode == AppMain.AppValue.UserCode && l.FormName == _FormName && l.ControlName == "dockManager1"))
                        {
                            AppMain.List_FormLayouts.Remove(_FormLayoutss);
                        }

                    }
                }
                SIS.Entity.Entities.Admin.FormLayouts _FormLayouts = (from l in AppMain.List_FormLayouts
                                                              where
                                                                 l.ApplicationId == blvalue.AplicationId &&
                                                                  l.UserCode == AppMain.AppValue.UserCode
                                                                  && l.FormName == _FormName & l.ControlName == "dockManager1"
                                                              select l).FirstOrDefault();
                if (_FormLayouts != null)
                {
                    _DockManager.BeginUpdate();

                    MemoryStream _MemoryStream = Decompress(_FormLayouts.Layout.ToArray());
                    _MemoryStream.Position = 0;
                    _DockManager.RestoreLayoutFromStream(_MemoryStream);
                    _MemoryStream.Dispose();

                    _DockManager.EndUpdate();
                }
            }
            catch (Exception _Exception)
            {

            }
        }

        private void get_Layout_Control(string _FormName, Control _Control)
        {

            if (_Control.Name == "gc_PrDiscount")
            {

            }

            if (_Control.GetType().Name == "GridControl")
            {

                //get_Layout(_FormName, (DevExpress.XtraGrid.GridControl)_Control);
            }

            if (_Control.GetType().Name == "SearchLookUpEdit")
            {
                //get_Layout(_FormName, (GridView)(((DevExpress.XtraEditors.SearchLookUpEdit)_Control).Properties.View));

            }

            if (_Control.GetType().Name == "ControlContainer")
            {
            }

            if (_Control.GetType().Name == "LayoutControl")
            {
                //get_Layout(_FormName, (DevExpress.XtraLayout.LayoutControl)_Control);
            }

            if (_Control.GetType().Name == "DataLayoutControl")
            {
                //get_Layout(_FormName, (DevExpress.XtraDataLayout.DataLayoutControl)_Control);
            }

            if (_Control.HasChildren == true)
            {
                foreach (Control __Control in _Control.Controls)
                {
                    get_Layout_Control(_FormName, __Control);

                }
            }

        }


        private static MemoryStream Decompress(byte[] gzip)
        {

            using (var stream = new System.IO.Compression.GZipStream(new MemoryStream(gzip), System.IO.Compression.CompressionMode.Decompress))
            {

                const int size = 4096;
                byte[] buffer = new byte[size];
                MemoryStream memory = new MemoryStream();

                int count = 0;
                do
                {
                    count = stream.Read(buffer, 0, size);
                    if (count > 0)
                    {
                        memory.Write(buffer, 0, count);
                    }
                }
                while (count > 0);
                return memory;

            }

        }


    }
}
