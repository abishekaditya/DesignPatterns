using System;

namespace BuilderPattern {
    
    public class WifesHamburgerBuilder : IBuilder {
        private Hamburger _hamburger;
        public void AddIngredients() {
            _hamburger.Ingredients = new string[] { "Bread", "Salad" };
        }

        public void AddShape() {
            _hamburger.Shape = "Cuboid";
        }

        public void AddSize() {
            _hamburger.Size = 6; //inches
        }

        public void Reset() {
            _hamburger = new Hamburger();
        }
        public Hamburger Build() {
            return _hamburger;
        }
    }
}
