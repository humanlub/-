using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Class1 : IEvaluate
    {
        public int NumOfVariant { get; set; }
        public int ParamValue { get; set; }
        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant;

            int N = numOfVariant; 
            ParamValue = Math.Max(-N, Math.Min(paramValueDefault, N));
        }
        public string Execute_Variant()
        {
            return $"Значение параметра: {ParamValue}";
        }
    }
}
