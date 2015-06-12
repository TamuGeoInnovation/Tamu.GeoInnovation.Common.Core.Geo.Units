namespace USC.GISResearchLab.Common.Geographics.Units.NonLinears
{
    public class NonLinearUnit : Unit
    {
        #region Properties
        private NonLinearUnitTypes _NonLinearUnitTypes;
        public NonLinearUnitTypes NonLinearUnitTypes
        {
            get { return _NonLinearUnitTypes; }
            set { _NonLinearUnitTypes = value; }
        }
        #endregion

        public NonLinearUnit()
        {
        }

        public NonLinearUnit(int code, string name, NonLinearUnitTypes nonLinearUnitTypes)
        {
            Name = name;
            Code = code;
            UnitType = UnitTypes.NonLinear;
            NonLinearUnitTypes = nonLinearUnitTypes;
        }
    }
}
