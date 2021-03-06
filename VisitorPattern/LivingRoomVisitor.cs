using System;

namespace VisitorPattern
{
    public class LivingRoomVisitor : IUnitVisitor
    {
        public void VisitApartment(Apartment apartment)
        {
        }

        public void VisitStudio(Studio studio)
        {
        }

        public void VisitBedroom(Bedroom bedroom)
        {
        }

        public void VisitLivingRoom(LivingRoom livingRoom)
        {
            Console.WriteLine("This is the living room");
        }
    }
}