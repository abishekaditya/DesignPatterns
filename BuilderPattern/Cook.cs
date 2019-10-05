namespace BuilderPattern {

    // This class can also be called the Director
    public class Cook {
        private IBuilder _builder;
        public Cook(IBuilder builder) {
            AcceptBuilder(builder);
        }

        public void ChangeBuilder(IBuilder builder) {
            AcceptBuilder(builder);
        }

        public  Hamburger Build() {
            _builder.AddIngredients();
            _builder.AddShape();
            _builder.AddSize();
            return _builder.Build();
        }

        private void AcceptBuilder(IBuilder builder) {
            _builder = builder;
            _builder.Reset();
        }
    }
}
