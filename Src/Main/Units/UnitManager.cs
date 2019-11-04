using System;
using USC.GISResearchLab.Common.GeographicObjects.Coordinates;
using USC.GISResearchLab.Common.Geographics.Units.Linears;

namespace USC.GISResearchLab.Common.Geographics.Units
{
    public class UnitManager
    {

        public enum UnitCodes
        {
            Unknown,
            NONLINEAR_DECIMAL_DEGREES, NONLINEAR_DEGREES_MINUTES_SECONDS,
            LINEAR_FEET, LINEAR_INCHES, LINEAR_METERS, LINEAR_KILOMETERS, LINEAR_MILES, LINEAR_YARDS, LINEAR_PIXELS
        }

        public const string UNIT_NAME_NONLINEAR_DECIMAL_DEGREES = "DecimalDegrees";
        public const string UNIT_NAME_NONLINEAR_DEGREES_MINUTES_SECONDS = "DegreesMinutesSeconds";

        public const string UNIT_NAME_LINEAR_FEET = "feet";
        public const string UNIT_NAME_LINEAR_INCHES = "inches";
        public const string UNIT_NAME_LINEAR_METERS = "meters";
        public const string UNIT_NAME_LINEAR_KILOMETERS = "kilometers";
        public const string UNIT_NAME_LINEAR_MILES = "miles";
        public const string UNIT_NAME_LINEAR_YARDS = "yards";
        public const string UNIT_NAME_LINEAR_PIXELS = "pixels";

        public const string UNIT_NAME_UNKNOWN = "unknown";

        static UnitManager()
        {

        }

        public static bool IsUint(string s)
        {
            bool ret = false;
            if (!String.IsNullOrEmpty(s))
            {
                switch (s.ToLower())
                {
                    case UNIT_NAME_NONLINEAR_DECIMAL_DEGREES:
                        ret = true;
                        break;
                    case UNIT_NAME_NONLINEAR_DEGREES_MINUTES_SECONDS:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_FEET:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_INCHES:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_METERS:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_KILOMETERS:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_MILES:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_PIXELS:
                        ret = true;
                        break;
                    case UNIT_NAME_LINEAR_YARDS:
                        ret = true;
                        break;
                    case UNIT_NAME_UNKNOWN:
                        ret = true;
                        break;
                    default:
                        ret = false;
                        break;
                }
            }

            return ret;
        }

        public static Unit FromString(string s)
        {
            Unit ret = null;
            switch (s.ToLower())
            {
                case UNIT_NAME_NONLINEAR_DECIMAL_DEGREES:
                    ret = new DecimalDegrees();
                    break;
                case UNIT_NAME_NONLINEAR_DEGREES_MINUTES_SECONDS:
                    ret = new DegreesMinutesSeconds();
                    break;
                case UNIT_NAME_LINEAR_FEET:
                    ret = new Feet();
                    break;
                case UNIT_NAME_LINEAR_INCHES:
                    ret = new Inches();
                    break;
                case UNIT_NAME_LINEAR_METERS:
                    ret = new Meters();
                    break;
                case UNIT_NAME_LINEAR_KILOMETERS:
                    ret = new Kilometers();
                    break;
                case UNIT_NAME_LINEAR_MILES:
                    ret = new Miles();
                    break;
                case UNIT_NAME_LINEAR_PIXELS:
                    ret = new Pixels();
                    break;
                case UNIT_NAME_LINEAR_YARDS:
                    ret = new Yards();
                    break;
                case UNIT_NAME_UNKNOWN:
                    ret = new UnknownUnit();
                    break;
                default:
                    throw new Exception("Unexpected unit type encountered: " + s);
            }

            return ret;
        }

        public static LinearUnit FromLinearUnitType(LinearUnitTypes u)
        {
            LinearUnit ret = null;
            switch (u)
            {
                case LinearUnitTypes.Feet:
                    ret = new Feet();
                    break;
                case LinearUnitTypes.Inches:
                    ret = new Inches();
                    break;
                case LinearUnitTypes.Meters:
                    ret = new Meters();
                    break;
                case LinearUnitTypes.Kilometers:
                    ret = new Kilometers();
                    break;
                case LinearUnitTypes.Miles:
                    ret = new Miles();
                    break;
                case LinearUnitTypes.Pixels:
                    ret = new Pixels();
                    break;
                case LinearUnitTypes.Yards:
                    ret = new Yards();
                    break;
                case LinearUnitTypes.Unknown:
                    ret = new UnknownLinearUnit();
                    break;
                default:
                    throw new Exception("Unexpected linear unit type encountered: " + u);
            }

            return ret;
        }
    }
}
