using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.Level0
{
    class SingletonLevel0
    {
        static private SingletonLevel0 _singletonObject;

        private SingletonLevel0()
        {

        }

        static public SingletonLevel0 GetSingleton()
        {
            if (_singletonObject == null)
            {
                _singletonObject = new SingletonLevel0();
                return _singletonObject;
            }
            return _singletonObject;
        }
    }
}
