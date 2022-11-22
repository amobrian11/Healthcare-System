using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class Call
    {
        public int CallID { get; set; }
        public string CallerNumb { get; set; }
        public DateTime TimeStarted { get; set; }
        public DateTime TimeEnded { get; set; }
        public DateTime Date { get; set; }

        public Call() { }

        public Call(int callID, string callerNumb, DateTime timeStarted, DateTime timeEnded, DateTime date)
        {
            this.CallID = callID;
            this.CallerNumb = callerNumb;
            this.TimeStarted = timeStarted;
            this.TimeEnded = timeEnded;
            this.Date = date;
        }
    }
}
