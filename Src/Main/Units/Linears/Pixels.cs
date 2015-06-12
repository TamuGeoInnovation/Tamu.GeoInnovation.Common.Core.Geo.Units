namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Pixels : LinearUnit
    {
        public Pixels()
            : base((int)UnitManager.UnitCodes.LINEAR_PIXELS, UnitManager.UNIT_NAME_LINEAR_PIXELS, LinearUnitTypes.Pixels)
        { }

        public Pixels(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_PIXELS, UnitManager.UNIT_NAME_LINEAR_PIXELS, LinearUnitTypes.Pixels)
        {
            DoubleValue = value;
        }
    }
}
