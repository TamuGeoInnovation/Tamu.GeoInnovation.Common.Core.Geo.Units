namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Kilometers : LinearUnit
    {
        public Kilometers()
            : base((int)UnitManager.UnitCodes.LINEAR_KILOMETERS, UnitManager.UNIT_NAME_LINEAR_KILOMETERS, LinearUnitTypes.Kilometers)
        { }

        public Kilometers(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_KILOMETERS, UnitManager.UNIT_NAME_LINEAR_KILOMETERS, LinearUnitTypes.Kilometers)
        {
            DoubleValue = value;
        }
    }
}
