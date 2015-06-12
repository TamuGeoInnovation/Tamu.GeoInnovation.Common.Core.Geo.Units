namespace USC.GISResearchLab.Common.Geographics.Units.Linears
{
    public class LinearUnit : Unit
    {

        #region Properties
        private LinearUnitTypes _LinearUnitTypes;
        public LinearUnitTypes LinearUnitTypes
        {
            get { return _LinearUnitTypes; }
            set { _LinearUnitTypes = value; }
        }
        #endregion

        public LinearUnit(int code, string name, LinearUnitTypes linearUnitTypes)
        {
            Name = name;
            Code = code;
            UnitType = UnitTypes.Linear;
            LinearUnitTypes = linearUnitTypes;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
