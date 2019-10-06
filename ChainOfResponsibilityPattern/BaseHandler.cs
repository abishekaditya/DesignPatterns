namespace ChainOfResponsibilityPattern {
    public abstract class BaseHandler : IHandler {
        public void AddChain(IHandler handler) {
            _nextInLine = handler;    
        }

        public abstract double? Handle(double[] values, string action);

        protected IHandler _nextInLine;
    }
}
