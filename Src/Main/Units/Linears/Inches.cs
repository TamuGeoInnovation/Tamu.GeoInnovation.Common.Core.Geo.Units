namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class Inches : LinearUnit
    {
        public Inches()
            : base((int)UnitManager.UnitCodes.LINEAR_INCHES, UnitManager.UNIT_NAME_LINEAR_INCHES, LinearUnitTypes.Inches)
        { }

        public Inches(double value)
            : base((int)UnitManager.UnitCodes.LINEAR_INCHES, UnitManager.UNIT_NAME_LINEAR_INCHES, LinearUnitTypes.Inches)
        {
            DoubleValue = value;
        }
    }
}
