namespace VisitorPattern
{
    public class Apartment : Unit
    {
        public Apartment(params Unit[] units) : base(units)
        {
        }

        public override void Accept(IUnitVisitor visitor)
        {
            visitor.VisitApartment(this);
            base.Accept(visitor);
        }

        public override string ToString()
        {
            return "Apartment";
        }
    }
}