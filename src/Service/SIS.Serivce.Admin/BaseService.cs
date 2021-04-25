using SIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIS.Service.Admin
{
    public abstract class BaseService
    {

        //public DateTime GetSqlDateTime(Syskod.DataAccess.Admin.AdminContext _db)
        //{
        //    var _return = _db.Database.SqlQuery<DateTime>("Select GetDate()").FirstOrDefault();
        //    return _return;
        //}
        //public DateTime GetSqlDateTime(Syskod.DataAccess.Hotel.HotelListContex _db)
        //{
        //    var _return = _db.Database.SqlQuery<DateTime>("Select GetDate()").FirstOrDefault();
        //    return _return;
        //}

        //public List<Logs> CreateLogs(Syskod.DataAccess.Admin.AdminContext _db, PostValue _PostValue, string _TableName, int _MasterId, int _ReservationId, List<string> excludeFields = null)
        //{
        //    List<Logs> _List_Logs = new List<Logs>();
        //    DateTime _DateNow = GetSqlDateTime(_db);
        //  //  DateTime _HotelDate = GetHotelDate(_db, _PostValue.CompanyId.Value);


        //    var modifiedEntities = _db.ChangeTracker.Entries().Where(p => p.State == EntityState.Modified).ToList();
        //    DateTime _DateTime = _DateNow;

        //    foreach (var change in modifiedEntities)
        //    {
        //        var entityName = change.Entity.GetType().Name;

        //        foreach (var _PropertyNames in change.OriginalValues.PropertyNames)
        //        {
        //            if (excludeFields?.Contains(_PropertyNames) ?? false)
        //            {
        //                continue;
        //            }

        //            var _OriginalValues = change.OriginalValues[_PropertyNames];
        //            var _CurrentValues = change.CurrentValues[_PropertyNames];
        //            if (_OriginalValues == null) _OriginalValues = "";
        //            if (_CurrentValues == null) _CurrentValues = "";
        //            if (_OriginalValues.ToString() != _CurrentValues.ToString())
        //            {
        //                if (_MasterId == 0) _MasterId = Convert.ToInt32(change.OriginalValues["RecId"]);
        //                //if (_PropertyNames != "UpdateDate" && _PropertyNames != "UpdateUser")
        //                //{
        //                Logs _Logs = new Logs();
        //                _Logs.ADateTime = _DateTime;
        //                _Logs.AType = 0;
        //                _Logs.CompanyCode = _PostValue.CompanyCode;
        //                _Logs.CompanyRecId = _PostValue.CompanyId;
        //                _Logs.FieldName = _PropertyNames;
        //                _Logs.FormName = _PostValue.FormName;
        //                _Logs.HotelDate = _DateTime.Date;
        //                _Logs.MasterId = _MasterId;
        //                _Logs.New = _CurrentValues.ToString();
        //                _Logs.Old = _OriginalValues.ToString();
        //                _Logs.PCName = _PostValue.PcName;
        //                _Logs.PtcId = 0;
        //                _Logs.ResId = _ReservationId;
        //                _Logs.TableId = Convert.ToInt32(change.OriginalValues["RecId"]);
        //                _Logs.TableName = entityName;// _TableName;
        //                _Logs.UserCode = _PostValue.UserCode;
        //                _List_Logs.Add(_Logs);
        //                // }
        //            }
        //        }

        //    }

        //    if (_List_Logs.Count > 0)
        //    {
        //        _db.Logs.AddRange(_List_Logs);
        //    }

        //    return _List_Logs;
        //}



    }
}
