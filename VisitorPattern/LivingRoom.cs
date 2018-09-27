namespace VisitorPattern
{
    public class LivingRoom: Unit
    {
        public LivingRoom(params Unit[] units) : base(units)
        {
        }

        public override void Accept(IUnitVisitor visitor)
        {
            visitor.VisitLivingRoom(this);
            base.Accept(visitor);
        }

        public override string ToString()
        {
            return "Living Room";
        }
    }
}