using SIS.Model.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data
{
    public class ReturnProcess
    {
        public ReturnProcess()
        {
            messages = new List<SelectIdValue>();
        }
        public bool processok { get; set; }
        public int Id { get; set; }
        public int errortype { get; set; }
        public string error { get; set; }
        public List<SelectIdValue> messages { get; set; }
        public byte[] byteval { get; set; }
        public string stringval { get; set; }
        public string stringval2 { get; set; }
        public string bpmMessage { get; set; }
        public List<int> Ids { get; set; }
    }

    public class ActionResponse<T> where T : class
    {
        public ResponseType ResponseType { get; set; }

        public string Message { get; set; }
        public T Response { get; set; }
        public List<T> Responses { get; set; }

        public ActionResponse()
        {

        }

    }

    public enum ResponseType
    {
        Ok = 1,
        Warning = 2,
        Error = 3
    }
}
