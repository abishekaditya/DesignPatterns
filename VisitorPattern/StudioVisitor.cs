using System;

namespace VisitorPattern
{
    public class StudioVisitor : IUnitVisitor
    {
        public void VisitApartment(Apartment apartment)
        {
        }

        public void VisitStudio(Studio studio)
        {
            Console.WriteLine("This is a studio");
        }

        public void VisitBedroom(Bedroom bedroom)
        {
        }

        public void VisitLivingRoom(LivingRoom livingRoom)
        {
        }
    }
}