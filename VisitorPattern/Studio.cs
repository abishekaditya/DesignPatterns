namespace VisitorPattern
{
    public class Studio : Unit
    {
        public Studio(params Unit[] units) : base(units)
        {
        }

        public override void Accept(IUnitVisitor visitor)
        {
            visitor.VisitStudio(this);
            base.Accept(visitor);
        }

        public override string ToString()
        {
            return "Studio";
        }
    }
}