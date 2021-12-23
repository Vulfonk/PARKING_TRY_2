using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKING_TRY_2
{
    public class Filter
    {
        public DateTime WithDate;
        public DateTime ToDate;

        public DateTime WithTime;
        public DateTime ToTime;

        public InputStatus? inputStatus;

        public string employerName;

        public List<Passage> Accept(List<Passage> passages)
        {
            var resultPassages = new List<Passage>();

            if (passages.Any(c => c.FullName == employerName))
            {
                resultPassages = passages.Where(c => c.FullName == employerName).ToList();
            }
            else
            {
                resultPassages = passages;
            }

            if (inputStatus != null)
            {
                resultPassages = resultPassages.Where(c => c.InputStatus == inputStatus).ToList();
            }

            if (WithDate != DateTime.MinValue)
            {
                resultPassages = resultPassages.Where(c => c.DateTime.Date >= WithDate).ToList();
            }

            if (ToDate != DateTime.MinValue)
            {
                resultPassages = resultPassages.Where(c => c.DateTime.Date <= ToDate).ToList();
            }

            if (WithTime != DateTime.MinValue)
            {
                resultPassages = resultPassages.Where(c => c.DateTime.TimeOfDay >= WithTime.TimeOfDay).ToList();
            }

            if (ToTime != DateTime.MinValue)
            {
                resultPassages = resultPassages.Where(c => c.DateTime.TimeOfDay <= ToTime.TimeOfDay).ToList();
            }



            return resultPassages;
        }
    }
}
