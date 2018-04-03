using System;

namespace Gadgeon.AlertPoint.Utility.ValueObjects
{
  public  class DateTimeGeneral
    {
       public DateTime  Value { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="localdateTime">expect local time</param>
        public DateTimeGeneral(DateTime localdateTime)
        {
            this.Value = localdateTime;//use central convert for all UTC or any sort of time zone info
        }

        public DateTimeGeneral(string localdateTime)
        {
            var dt = DateTime.Parse(localdateTime);
            this.Value = dt;//use central convert for all UTC or any sort of time zone info
        }
    }
}
