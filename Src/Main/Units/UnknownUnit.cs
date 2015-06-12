namespace USC.GISResearchLab.Common.Geographics.Units
{
    public class UnknownUnit : Unit
    {
        public UnknownUnit()
        { 
            Code = (int)UnitManager.UnitCodes.Unknown; 
            Name = UnitManager.UNIT_NAME_UNKNOWN;
            UnitType = UnitTypes.Unknown;
         }

        public UnknownUnit(double value)
        {
            Code = (int)UnitManager.UnitCodes.Unknown;
            Name = UnitManager.UNIT_NAME_UNKNOWN;
            UnitType = UnitTypes.Unknown;
            DoubleValue = value;
        }
    }
}
