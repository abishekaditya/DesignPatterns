using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main()
        {
            var apartment = new Apartment(new LivingRoom(), new Bedroom(), new Bedroom());
            var studio = new Studio(new LivingRoom(), new Bedroom());
            Console.WriteLine("Visiting an Apartment");
            apartment.Accept(new ApartmentVisitor());
            apartment.Accept(new LivingRoomVisitor());
            apartment.Accept(new BedroomVisitor());
            
            Console.WriteLine("Visiting a Studio");
            studio.Accept(new StudioVisitor());
            studio.Accept(new LivingRoomVisitor());
            studio.Accept(new BedroomVisitor());
        }
    }
}