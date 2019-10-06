namespace ChainOfResponsibilityPattern {
    public interface IHandler {
        void AddChain(IHandler handler);
        double? Handle(double[] values, string action);
    }
}
