using System;

namespace wildlings_backend.Models
{
    public class Period

    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public bool InPeriod(DateTime time)
        {
            return time > Start && time < End;
        }
    }
}