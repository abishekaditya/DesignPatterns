using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern {
    public class AdditionHandler : BaseHandler {
        public override double? Handle(double[] values, string action) {
            if (action.ToLower() == "add") {
                double result=0.0;
                foreach (var value in values) {
                    result += value;
                }
                return result;
            }
            else {
                return _nextInLine?.Handle(values,action);
            }
        }
    }
}
