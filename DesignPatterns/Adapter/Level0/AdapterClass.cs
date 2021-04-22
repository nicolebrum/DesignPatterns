using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Level0
{
    class AdapterClass
    {
        private AdaptedClass _adaptedClass;

        public AdapterClass(AdaptedClass adaptedClass)
        {
            _adaptedClass = adaptedClass;
        }

        public ReceivesAdaptationClass ConvertAdptedToReceivesAdaptation()
        {
            return new ReceivesAdaptationClass();
        }
    }
}
