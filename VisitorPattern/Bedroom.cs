namespace VisitorPattern
{
    public class Bedroom : Unit
    {
        public Bedroom(params Unit[] units) : base(units)
        {
        }

        public override void Accept(IUnitVisitor visitor)
        {
            visitor.VisitBedroom(this);
            base.Accept(visitor);
        }

        public override string ToString()
        {
            return "Bedroom";
        }
    }
}