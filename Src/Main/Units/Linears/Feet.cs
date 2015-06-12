namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Feet : LinearUnit
    {
        public Feet()
            : base((int)UnitManager.UnitCodes.LINEAR_FEET, UnitManager.UNIT_NAME_LINEAR_FEET, LinearUnitTypes.Feet)
        { }

        public Feet(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_FEET, UnitManager.UNIT_NAME_LINEAR_FEET, LinearUnitTypes.Feet)
        {
            DoubleValue = value;
        }
    }
}
