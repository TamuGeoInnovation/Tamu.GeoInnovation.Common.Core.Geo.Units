namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Miles : LinearUnit
    {
        public Miles()
            : base((int)UnitManager.UnitCodes.LINEAR_MILES, UnitManager.UNIT_NAME_LINEAR_MILES, LinearUnitTypes.Miles)
        { }

        public Miles(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_MILES, UnitManager.UNIT_NAME_LINEAR_MILES, LinearUnitTypes.Miles)
        {
            DoubleValue = value;
        }
    }
}
