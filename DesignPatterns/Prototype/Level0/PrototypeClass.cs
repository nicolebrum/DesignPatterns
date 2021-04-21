using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.Level0
{
    public class PrototypeClass : IPrototype
    {
        private string _exampleField1;
        private int _exampleField2;
        private long _exampleField3;
        private string _exampleField4;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void SetField1(string fieldValue)
        {
            _exampleField1 = fieldValue;
        }
        public void SetField2(int fieldValue)
        {
            _exampleField2 = fieldValue;
        }
        public void SetField3(long fieldValue)
        {
            _exampleField3 = fieldValue;
        }
        public void SetField4(string fieldValue)
        {
            _exampleField4 = fieldValue;
        }

        public string GetField1()
        {
            return _exampleField1;
        }

        public int GetField2()
        {
            return _exampleField2;
        }

        public long GetField3()
        {
            return _exampleField3;
        }

        public string GetField4()
        {
            return _exampleField4;
        }
    }
}
