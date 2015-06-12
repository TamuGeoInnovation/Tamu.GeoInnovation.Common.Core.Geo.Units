using USC.GISResearchLab.Common.Globalization.Constants;

namespace USC.GISResearchLab.Common.Geographics.Units
{
    public class LengthConversionConstants
    {

        // the following are from
        // from http://unit-converter.org/en_length.html

        public static double CENTIMETERS_PER_MILE = METERS_PER_MILE * 1000;
        public static double FEET_PER_MILE = double.Parse("5280", GlobalizationConstants.US_CULTURE_INFO);
        public static double INCHES_PER_MILE = FEET_PER_MILE * 12;
        public static double KILOMETERS_PER_MILE = double.Parse("1.609344", GlobalizationConstants.US_CULTURE_INFO);
        public static double METERS_PER_MILE = KILOMETERS_PER_MILE * 1000;
        public static double YARDS_PER_MILE = double.Parse("1760", GlobalizationConstants.US_CULTURE_INFO);

        public static double CENTIMETERS_PER_METER = double.Parse("1000", GlobalizationConstants.US_CULTURE_INFO);
        public static double FEET_PER_METER = double.Parse("3.28083990", GlobalizationConstants.US_CULTURE_INFO);
        public static double INCHES_PER_METER = double.Parse("39.3700787", GlobalizationConstants.US_CULTURE_INFO);
        public static double KILOMETERS_PER_METER = double.Parse("0.001", GlobalizationConstants.US_CULTURE_INFO);
        public static double MILE_PER_METER = double.Parse("0.000621371192", GlobalizationConstants.US_CULTURE_INFO);
        public static double YARDS_PER_METER = double.Parse("1.09361330", GlobalizationConstants.US_CULTURE_INFO);

        public static double CENTIMETERS_PER_KILOMETER = CENTIMETERS_PER_METER * METERS_PER_KILOMETER;
        public static double FEET_PER_KILOMETER = FEET_PER_METER * METERS_PER_KILOMETER;
        public static double INCHES_PER_KILOMETER = INCHES_PER_METER * METERS_PER_KILOMETER;
        public static double METERS_PER_KILOMETER = double.Parse("1000", GlobalizationConstants.US_CULTURE_INFO);
        public static double MILE_PER_KILOMETER = MILE_PER_METER * METERS_PER_KILOMETER;
        public static double YARDS_PER_KILOMETER = YARDS_PER_METER * METERS_PER_KILOMETER;

        public static double CENTIMETERS_PER_FOOT = double.Parse("30.4800000", GlobalizationConstants.US_CULTURE_INFO);
        public static double INCHES_PER_FOOT = double.Parse("12", GlobalizationConstants.US_CULTURE_INFO);
        public static double KILOMETERS_PER_FOOT = double.Parse("0.000304800000", GlobalizationConstants.US_CULTURE_INFO);
        public static double METERS_PER_FOOT = double.Parse("0.304800000", GlobalizationConstants.US_CULTURE_INFO);
        public static double MILE_PER_FOOT = double.Parse("0.000189393939", GlobalizationConstants.US_CULTURE_INFO);
        public static double YARDS_PER_FOOT = double.Parse("0.333333333", GlobalizationConstants.US_CULTURE_INFO);

        public static double CENTIMETERS_PER_INCH = double.Parse("2.54000000", GlobalizationConstants.US_CULTURE_INFO);
        public static double FEET_PER_INCH = double.Parse("0.0833333333", GlobalizationConstants.US_CULTURE_INFO);
        public static double KILOMETERS_PER_INCH = double.Parse("2.54000000e-5", GlobalizationConstants.US_CULTURE_INFO);
        public static double METERS_PER_INCH = double.Parse("0.0254000000", GlobalizationConstants.US_CULTURE_INFO);
        public static double MILE_PER_INCH = double.Parse("1.57828283e-5", GlobalizationConstants.US_CULTURE_INFO);
        public static double YARDS_PER_INCH = double.Parse("0.0277777778", GlobalizationConstants.US_CULTURE_INFO);

        public static double CENTIMETERS_PER_YARD = double.Parse("91.440", GlobalizationConstants.US_CULTURE_INFO);
        public static double FEET_PER_YARD = double.Parse("3.0", GlobalizationConstants.US_CULTURE_INFO);
        public static double INCHES_PER_YARD = double.Parse("36.0", GlobalizationConstants.US_CULTURE_INFO);
        public static double KILOMETERS_PER_YARD = double.Parse("0.0009144", GlobalizationConstants.US_CULTURE_INFO);
        public static double METERS_PER_YARD = double.Parse("0.914400000", GlobalizationConstants.US_CULTURE_INFO);
        public static double MILE_PER_YARD = double.Parse("0.000568181818", GlobalizationConstants.US_CULTURE_INFO);
        

        public static double METERS_PER_DEGREE_AT_EQUATOR = double.Parse("111319.5", GlobalizationConstants.US_CULTURE_INFO);
        public static double METERS_PER_MINUTE_AT_EQUATOR = double.Parse("1855.325", GlobalizationConstants.US_CULTURE_INFO);
        public static double METERS_PER_SECOND_AT_EQUATOR = double.Parse("30.9220833", GlobalizationConstants.US_CULTURE_INFO);

        public static double MPH_PER_KNOT = double.Parse("1.150779", GlobalizationConstants.US_CULTURE_INFO);

    }
}


/*

Not yet added in
 * 


yard 	TO 	cm 	Multiply yard by 	91.44
yard 	TO 	ft 	Multiply yard by 	3
yard 	TO 	in 	Multiply yard by 	36
yard 	TO 	km 	Multiply yard by 	9.14E-04
yard 	TO 	m 	Multiply yard by 	0.9144
yard 	TO 	mile (nautical) 	Multiply yard by 	4.93E-04
yard 	TO 	mile (statute) 	Multiply yard by 	5.68E-04
yard 	TO 	mm 	Multiply yard by 	914.4

*/