using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern {

    public abstract class Tax {

        protected decimal TaxRate = 0;

        protected decimal QuickDeduction = 0;

        public virtual decimal Calculate(decimal income) {
            return income * TaxRate - QuickDeduction;
        }

    }

}