using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerDB
{
    /// <summary>
    /// 反射測試類
    /// </summary>
    public class ReflectionTest
    {
        public ReflectionTest()
        {
            Console.WriteLine("無參數構造方法");
        }

        public ReflectionTest(string name)
        {
            Console.WriteLine($"有參數構造方法 參數值是: {name}");
        }
    }
}
