using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moudles
{
    public class SingleNew
    {
        /// <summary>
        /// 控制对象的实例化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetT<T>() where T : class,new ()
        {
            return new T();
        }
    }
}
