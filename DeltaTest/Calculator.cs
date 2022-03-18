using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaTest
{
    public class Calculator
    {
        private IAddition _additionUnit;

        public Calculator(IAddition additionUnit)
        {
            _additionUnit = additionUnit;
        }

        public int Add(int i1, int i2)
        {
            return _additionUnit.Add(i1, i2);
        }
    }
}
