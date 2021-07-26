using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data
{
    [Serializable]
    public partial class StateObject : ICloneable
    {
        [NotMapped]
        public State RState { get; set; }
        //[NotMapped]
        //public FormIdsIk FormIdsIk { get; set; }
        public Dictionary<string, object> ROriginalValues { get; set; }
        public List<string> RModifiedColumns { get; set; }

        public enum State
        {
            Unchanged, Added, Modified, Deleted, Selected
        }

        public StateObject()
        {
            this.RModifiedColumns = new List<string>();

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
