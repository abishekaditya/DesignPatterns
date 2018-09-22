namespace VisitorPattern
{
    public interface IUnitVisitor
    {
        void VisitApartment(Apartment apartment);
        void VisitStudio(Studio studio);
        void VisitBedroom(Bedroom bedroom);
        void VisitLivingRoom(LivingRoom livingRoom);
    }
}