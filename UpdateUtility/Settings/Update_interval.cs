using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.Settings
{
    public static class Update_interval
    {
        static internal int interval;

        static public void update_interval(int time, string units)
        {
            try
            {
                if (units == "day" || units == "день")
                {
                    interval = time * 86400000;
                }

                if (units == "hour" || units == "час")
                {
                    interval = time * 3600000;
                }

                if (units == "min" || units == "минута")
                {
                    interval = time * 60000;
                }

                if (units == "sec" || units == "секунда")
                {
                    interval = time * 1000;
                }
            }

            catch
            {
                interval = 3600000;
            }
        }

        static internal int update_interval()
        {
            if (interval.ToString() == null)
            {
                return 3600000;
            }
            return interval;
        }
    }
}
