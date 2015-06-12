using System.Text;

namespace USC.GISResearchLab.Common.Geographics.Units
{
    public abstract class Unit
    {
        #region Properties

        public UnitTypes UnitType { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public double DoubleValue { get; set; }

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}: {1}: {2}", Code, Name, DoubleValue);
            return sb.ToString();
        }

    }
}
