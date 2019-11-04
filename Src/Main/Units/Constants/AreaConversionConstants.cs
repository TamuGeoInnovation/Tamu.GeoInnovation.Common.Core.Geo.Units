using USC.GISResearchLab.Common.Globalization.Constants;

namespace USC.GISResearchLab.Common.Geographics.Units
{
    public class AreaConversionConstants
    {



        // the following are from
        // from http://unit-converter.org/conversion.php?c_id=4&lang=en

        public static double SQUARE_ACRES_PER_SQUARE_MILE = double.Parse("640.0", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_FEET_PER_SQUARE_MILE = double.Parse("27878400.0", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_INCHES_PER_SQUARE_MILE = double.Parse("4014489600", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_KILOMETERS_PER_SQUARE_MILE = double.Parse("2.58998811", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_METERS_PER_SQUARE_MILE = double.Parse("2589988.11", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_YARDS_PER_SQUARE_MILE = double.Parse("3097600.00", GlobalizationConstants.US_CULTURE_INFO);

        public static double SQUARE_ACRES_PER_SQUARE_KILOMETERS = double.Parse("247.105381", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_FEET_PER_SQUARE_KILOMETERS = double.Parse("10763910.4", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_INCHES_PER_SQUARE_KILOMETERS = double.Parse("1550003100", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_METERS_PER_SQUARE_KILOMETERS = double.Parse("1000000.00", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_MILES_PER_SQUARE_KILOMETERS = double.Parse("0.386102159", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_YARDS_PER_SQUARE_KILOMETERS = double.Parse("1195990.05", GlobalizationConstants.US_CULTURE_INFO);

        public static double SQUARE_ACRES_PER_SQUARE_METERS = double.Parse("0.000247105381", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_FEET_PER_SQUARE_METERS = double.Parse("10.7639104", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_INCHES_PER_SQUARE_METERS = double.Parse("1550.00310", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_KILOMETERS_PER_SQUARE_METERS = double.Parse("0.000001", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_MILES_PER_SQUARE_METERS = double.Parse("0.000000386102159", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_YARDS_PER_SQUARE_METERS = double.Parse("1.19599005", GlobalizationConstants.US_CULTURE_INFO);

        public static double SQUARE_ACRES_PER_SQUARE_FOOT = double.Parse("2.29568411e-5", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_INCHES_PER_SQUARE_FOOT = double.Parse("144.000000", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_KILOMETERS_PER_SQUARE_FOOT = double.Parse("9.29030400e-8", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_METERS_PER_SQUARE_FOOT = double.Parse("0.0929030400", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_MILES_PER_SQUARE_FOOT = double.Parse("3.58700643e-8", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_YARDS_PER_SQUARE_FOOT = double.Parse("0.111111111", GlobalizationConstants.US_CULTURE_INFO);

        public static double SQUARE_ACRES_PER_SQUARE_INCH = double.Parse("1.59422508e-7", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_FEET_PER_SQUARE_INCH = double.Parse("0.00694444444", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_KILOMETERS_PER_SQUARE_INCH = double.Parse("6.45160000e-10", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_METERS_PER_SQUARE_INCH = double.Parse("0.000645160000", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_MILES_PER_SQUARE_INCH = double.Parse("2.49097669e-10", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_YARDS_PER_SQUARE_INCH = double.Parse("0.000771604938", GlobalizationConstants.US_CULTURE_INFO);

        public static double SQUARE_ACRES_PER_SQUARE_YARD = double.Parse("0.000206611570", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_FEET_PER_SQUARE_YARD = double.Parse("9.00000000", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_INCHES_PER_SQUARE_YARD = double.Parse("1296.00000", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_KILOMETERS_PER_SQUARE_YARD = double.Parse("8.36127360e-7", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_METERS_PER_SQUARE_YARD = double.Parse("0.836127360", GlobalizationConstants.US_CULTURE_INFO);
        public static double SQUARE_MILES_PER_SQUARE_YARD = double.Parse("3.22830579e-7", GlobalizationConstants.US_CULTURE_INFO);


    }
}


/*

Not yet added in
 * 
sq m 	TO 	acre 	Multiply sq m by 	2.47E-04
sq m 	TO 	sq ft 	Multiply sq m by 	10.76
sq m 	TO 	sq in 	Multiply sq m by 	1550
sq m 	TO 	sq mile 	Multiply sq m by 	3.86E-07
sq m 	TO 	sq mm 	Multiply sq m by 	1.00E+06
sq m 	TO 	sq yard 	Multiply sq m by 	1.196

sq mm 	TO 	sq cm 	Multiply sq mm by 	0.01
sq mm 	TO 	sq ft 	Multiply sq mm by 	1.08E-05
sq mm 	TO 	sq in 	Multiply sq mm by 	1.55E-03
sq yard 	TO 	acre 	Multiply sq yard by 	2.07E-04
sq yard 	TO 	sq ft 	Multiply sq yard by 	9
sq yard 	TO 	sq in 	Multiply sq yard by 	1296
sq yard 	TO 	sq m 	Multiply sq yard by 	0.8361
sq yard 	TO 	sq mile 	Multiply sq yard by 	3.23E-07

*/
