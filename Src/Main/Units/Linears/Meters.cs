namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Meters : LinearUnit
    {
        public Meters()
            : base((int)UnitManager.UnitCodes.LINEAR_METERS, UnitManager.UNIT_NAME_LINEAR_METERS, LinearUnitTypes.Meters)
        { }

        public Meters(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_METERS, UnitManager.UNIT_NAME_LINEAR_METERS, LinearUnitTypes.Meters)
        {
            DoubleValue = value;
        }
    }
}
