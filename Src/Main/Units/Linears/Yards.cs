namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Yards : LinearUnit
    {
        public Yards()
            : base((int)UnitManager.UnitCodes.LINEAR_YARDS, UnitManager.UNIT_NAME_LINEAR_YARDS, LinearUnitTypes.Yards)
        { }

        public Yards(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_YARDS, UnitManager.UNIT_NAME_LINEAR_YARDS, LinearUnitTypes.Yards)
        {
            DoubleValue = value;
        }
    }
}
