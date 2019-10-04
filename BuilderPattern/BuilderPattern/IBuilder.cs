namespace BuilderPattern {
    public interface IBuilder {
        void AddIngredients();
        void AddShape();
        void AddSize();
        void Reset();
        Hamburger Build();
    }
}
