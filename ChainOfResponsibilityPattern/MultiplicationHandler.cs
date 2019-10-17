namespace ChainOfResponsibilityPattern {
    public class MultiplicationHandler : BaseHandler {
        public override double? Handle(double[] values, string action) {
            if (action.ToLower() == "multiply") {
                var result = 1.0;
                foreach (var value in values) {
                    result *= value;
                }
                return result;
            }
            else {
                return _nextInLine?.Handle(values, action);
            }
        }
    }
}
