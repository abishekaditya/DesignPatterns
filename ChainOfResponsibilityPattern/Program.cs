using System;

namespace ChainOfResponsibilityPattern {
    class Program {
        static void Main(string[] args) {
            //create handlers
            var additionHandler = new AdditionHandler();
            var subtractionHandler = new SubtractionHandler();
            var multiplicationHander = new MultiplicationHandler();
            //create chain
            subtractionHandler.AddChain(multiplicationHander);
            additionHandler.AddChain(subtractionHandler);
            //Execution
            double[] numbers = new double[] { 2, 3, 4, 5 };
            var additionResult = additionHandler.Handle(numbers, "Add");
            var subtractionResult = additionHandler.Handle(numbers, "Minus");
            var multResult = additionHandler.Handle(numbers, "Multiply");
            var divisionResult = additionHandler.Handle(numbers, "divide"); // Divide is not in the chain!!!

            Console.WriteLine("Addition = {0}",additionResult);
            Console.WriteLine("Subtraction = {0}", subtractionResult);
            Console.WriteLine("Multiplication = {0}", multResult);
            Console.WriteLine("Division = {0}", divisionResult);
        }
    }
}
