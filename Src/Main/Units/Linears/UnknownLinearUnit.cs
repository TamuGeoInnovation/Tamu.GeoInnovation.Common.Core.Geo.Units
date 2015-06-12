namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class UnknownLinearUnit : LinearUnit
    {
        public UnknownLinearUnit()
            : base((int)UnitManager.UnitCodes.Unknown, UnitManager.UNIT_NAME_UNKNOWN, LinearUnitTypes.Unknown)
        { }

        public UnknownLinearUnit(double value)
            : base((int)UnitManager.UnitCodes.Unknown, UnitManager.UNIT_NAME_UNKNOWN, LinearUnitTypes.Unknown)
        {
            DoubleValue = value;
        }
    }
}
