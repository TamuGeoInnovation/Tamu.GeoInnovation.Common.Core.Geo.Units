using System;
using USC.GISResearchLab.Common.Geographics.Units;
using USC.GISResearchLab.Common.Geographics.Units.NonLinears;
using USC.GISResearchLab.Common.Globalization.Constants;

namespace USC.GISResearchLab.Common.GeographicObjects.Coordinates
{
    /// <summary>
    /// Summary description for DecimalDegrees.
    /// </summary>
    public class DegreesMinutesSeconds : NonLinearUnit
    {

        #region Properties
        private int _Degrees;
        private int _Minutes;
        private double _Seconds;

        public int Degrees
        {
            get { return _Degrees; }
            set { _Degrees = value; }
        }

        public int Minutes
        {
            get { return _Minutes; }
            set { _Minutes = value; }
        }

        public double Seconds
        {
            get { return _Seconds; }
            set { _Seconds = value; }
        }

        #endregion


        public DegreesMinutesSeconds()
            : base((int)UnitManager.UnitCodes.NONLINEAR_DEGREES_MINUTES_SECONDS, UnitManager.UNIT_NAME_NONLINEAR_DEGREES_MINUTES_SECONDS, NonLinearUnitTypes.DegreesMinutesSeconds)
        {
        }

        public DegreesMinutesSeconds(int degrees, int minutes, double seconds)
            : base((int)UnitManager.UnitCodes.NONLINEAR_DEGREES_MINUTES_SECONDS, UnitManager.UNIT_NAME_NONLINEAR_DEGREES_MINUTES_SECONDS, NonLinearUnitTypes.DegreesMinutesSeconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public DegreesMinutesSeconds(double[] dms)
            : base((int)UnitManager.UnitCodes.NONLINEAR_DEGREES_MINUTES_SECONDS, UnitManager.UNIT_NAME_NONLINEAR_DEGREES_MINUTES_SECONDS, NonLinearUnitTypes.DegreesMinutesSeconds)
        {
            if (dms.Length == 3)
            {
                Degrees = Convert.ToInt32(dms[0]);
                Minutes = Convert.ToInt32(dms[1]);
                Seconds = dms[2];
            }
            else
            {
                throw new Exception("Error creating DegreesMinutesSeconds: double[] parameter must be length=3");
            }
        }


        public static DegreesMinutesSeconds FromNMEAString(string nmeaDegreesString, string direction)
        {
            DegreesMinutesSeconds ret = new DegreesMinutesSeconds();
            ret.Degrees = Convert.ToInt32(GetNMEADegrees(nmeaDegreesString, direction));
            ret.Minutes = Convert.ToInt32(GetNMEAMinutes(nmeaDegreesString));
            ret.Seconds = GetNMEASeconds(nmeaDegreesString);
            return ret;
        }

        public static double GetNMEADegrees(string str, string dir)
        {
            double ret;

            if (str.IndexOf(".") != -1)
            {
                str = str.Substring(0, str.IndexOf("."));
            }

            str = str.Substring(0, str.Length - 2);

            ret = double.Parse(str, GlobalizationConstants.US_CULTURE_INFO);
            if (dir.ToUpper().Equals("S") || dir.ToUpper().Equals("W"))
            {
                ret = ret * -1;
            }
            return ret;
        }

        public static double GetNMEAMinutes(string str)
        {
            double ret;

            if (str.IndexOf(".") != -1)
            {
                str = str.Substring(0, str.IndexOf("."));
            }

            str = str.Substring(str.Length - 2);

            ret = double.Parse(str, GlobalizationConstants.US_CULTURE_INFO);
            return ret;
        }

        public static double GetNMEASeconds(string str)
        {
            double ret;
            if (str.IndexOf(".") != -1)
            {
                str = str.Substring(str.IndexOf("."));
            }

            ret = double.Parse(str, GlobalizationConstants.US_CULTURE_INFO);
            ret = ret * 60;

            return ret;
        }

        public double ToDecimalDegrees()
        {
            bool isNeg = false;
            if (Degrees < 0)
            {
                isNeg = true;
                Degrees = Degrees * -1;
            }

            double ret = Degrees + (Minutes / 60) + ((Seconds / 60) / 60);

            if (isNeg)
            {
                ret = ret * -1;
            }

            return ret;
        }
    }
}