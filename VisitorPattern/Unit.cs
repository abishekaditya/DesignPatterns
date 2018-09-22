namespace VisitorPattern
{
    public abstract class Unit
    {
        private Unit[] _units;

        public Unit(params Unit[] units)
        {
            _units = units;
        }

        public virtual void Accept(IUnitVisitor visitor)
        {
            foreach (var unit in _units)
            {
                unit.Accept(visitor);
            }
        }

        public abstract string ToString();
    }
}