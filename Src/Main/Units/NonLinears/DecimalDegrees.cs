using System;
using System.Text;
using USC.GISResearchLab.Common.Geographics.Units;
using USC.GISResearchLab.Common.Geographics.Units.NonLinears;
using USC.GISResearchLab.Common.Globalization.Constants;
using USC.GISResearchLab.Common.Utils.Numbers;

namespace USC.GISResearchLab.Common.GeographicObjects.Coordinates
{
    /// <summary>
    /// Summary description for DecimalDegrees.
    /// </summary>
    public class DecimalDegrees : NonLinearUnit
    {
        #region Properties

        public double Degrees { get; set; }
        #endregion

        public DecimalDegrees()
            : base((int)UnitManager.UnitCodes.NONLINEAR_DECIMAL_DEGREES, UnitManager.UNIT_NAME_NONLINEAR_DECIMAL_DEGREES, NonLinearUnitTypes.DecimalDegrees)
        {
        }

        public DecimalDegrees(double degrees)
            : base((int)UnitManager.UnitCodes.NONLINEAR_DECIMAL_DEGREES, UnitManager.UNIT_NAME_NONLINEAR_DECIMAL_DEGREES, NonLinearUnitTypes.DecimalDegrees)
        {
            Degrees = degrees;
        }

        public static string ToHoursMinutesString(string degrees, string directional, bool isLatitude)
        {
            string hours;
            string minutes;
            if (isLatitude)
            {
                hours = degrees.Substring(0, 2);
                minutes = degrees.Substring(2);
            }
            else
            {
                hours = degrees.Substring(0, 3);
                minutes = degrees.Substring(3);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}°{1}\"{2}", hours, minutes, directional);

            return sb.ToString();
        }

        public double[] ToDegreesMinutesSeconds()
        {
            double[] ret = new double[3];
            bool isNegative = (Degrees < 0);
            double absDegrees = System.Math.Abs(Degrees);

            double retDegrees = NumberUtils.getWholeNumberPart(absDegrees);
            if (isNegative)
            {
                retDegrees = -1.0 * retDegrees;
            }

            double minutesTemp = NumberUtils.getFractionalPart(absDegrees) * 60;
            double minutes = NumberUtils.getWholeNumberPart(minutesTemp);
            double secondsTemp = NumberUtils.getFractionalPart(minutesTemp);
            double seconds = secondsTemp * 60;

            ret[0] = retDegrees;
            ret[1] = minutes;
            ret[2] = seconds;

            return ret;
        }

        public static DecimalDegrees FromActiveLogString(string activeLogDegreesString, string activeLogMinutesSeconds)
        {

            double decimalDegrees = GetActiveLogDegrees(activeLogDegreesString);
            double decimalDegreesMinSec = Convert.ToDouble(activeLogMinutesSeconds);
            double decimalDegreesMinSecScaled = decimalDegreesMinSec / 60.0;

            double decimalDegreesFull = 0;

            if (decimalDegrees > 0)
            {
                decimalDegreesFull = decimalDegrees + decimalDegreesMinSecScaled;
            }
            else
            {
                decimalDegreesFull = decimalDegrees - decimalDegreesMinSecScaled;
            }

            return new DecimalDegrees(decimalDegreesFull);

        }

        public static double GetActiveLogDegrees(string str)
        {
            double ret;

            string direction = str.Substring(0, 1);
            string degrees = str.Substring(1);

            ret = double.Parse(degrees, GlobalizationConstants.US_CULTURE_INFO);
            if (direction.ToUpper().Equals("S") || direction.ToUpper().Equals("W"))
            {
                ret = ret * -1;
            }
            return ret;
        }
    }
}