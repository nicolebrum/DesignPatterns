using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Level0
{
    class ReceivesAdaptationClass
    {
        private long _testField1;
        private string _testField2;

        public long GetTestField1()
        {
            return this._testField1;
        }
    }
}
