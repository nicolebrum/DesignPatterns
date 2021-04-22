using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Level0
{
    class AdaptedClass
    {
        private int _testField1;
        private string _testField2;

        public int GetTestField1()
        {
            return this._testField1;
        }
    }
}
