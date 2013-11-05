using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Quartz
{
    public static class JobDataMapExtensions
    {
        public static bool TryGet<T>(this JobDataMap map, string key, out T returnVal) where T: class, new()
        {

            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                returnVal = output as T;
                return (returnVal != null);
            }
            else
            {
                returnVal = null;
                return false;
            }

        }

        public static bool TryGetString(this JobDataMap map, string key, out string returnVal) {

            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                returnVal = (output as string); // Try cast to string, if success returnVal is not null
                
                // if cast failed, try calling ToString()
                if(null == returnVal)
                    returnVal = (output == null) ? null : output.ToString();
                
                return (returnVal != null);
            }
            else
            {
                returnVal = null;
                return false;
            }

        }

        public static bool TryGetBoolean(this JobDataMap map, string key, out bool returnVal) {
        
            if(null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Boolean.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = false;
                return false;
            }
        
        }

        public static bool TryGetByte(this JobDataMap map, string key, out byte returnVal)
        {

            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Byte.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0;
                return false;
            }
        }

        public static bool TryGetShort(this JobDataMap map, string key, out short returnVal)
        {

            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Int16.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0;
                return false;
            }
        }

        public static bool TryGetInt(this JobDataMap map, string key, out int returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Int32.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0;
                return false;
            }
        }

        public static bool TryGetLong(this JobDataMap map, string key, out long returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {                 
                return Int64.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0L;
                return false;
            }
        }

        public static bool TryGetFloat(this JobDataMap map, string key, out float returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Single.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0.0F;
                return false;
            }
        }
        
        public static bool TryGetDouble(this JobDataMap map, string key, out double returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Double.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0.0D;
                return false;
            }
        }


        public static bool TryGetDecimal(this JobDataMap map, string key, out decimal returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Decimal.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = 0.0M;
                return false;
            }
        }

        public static bool TryGetChar(this JobDataMap map, string key, out char returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return Char.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = default(char);
                return false;
            }
        }

        public static bool TryGetDateTime(this JobDataMap map, string key, out DateTime returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return DateTime.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = DateTime.MinValue;
                return false;
            }
        }

        public static bool TryGetDateTimeOffset(this JobDataMap map, string key, out DateTimeOffset returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return DateTimeOffset.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = DateTimeOffset.MinValue;
                return false;
            }
        }

        public static bool TryGetTimeSpan(this JobDataMap map, string key, out TimeSpan returnVal)
        {
            if (null == map)
                throw new ArgumentNullException("map");

            object output;
            if (map.TryGetValue(key, out output))
            {
                return TimeSpan.TryParse(Convert.ToString(output, CultureInfo.InvariantCulture), out returnVal);
            }
            else
            {
                returnVal = TimeSpan.Zero;
                return false;
            }
        }
    }
}
