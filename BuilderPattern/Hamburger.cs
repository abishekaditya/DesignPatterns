using System.Collections.Generic;

namespace BuilderPattern
{
    public class Hamburger
    {
        public int Size { get; set; }
        public string Shape { get; set; }
        public string[] Ingredients { get; set; }
        public override string ToString()
        {
            var hamburger="";
            foreach (var ingredient in Ingredients) {
                hamburger += $"{ingredient} ";
            }
            return $"Ingredients: {hamburger}, Size: {Size}, Shape: {Shape}";
        }
    }
}
