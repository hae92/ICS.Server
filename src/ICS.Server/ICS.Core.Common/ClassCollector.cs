using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ICS.Core.Common
{
    public class ClassCollector
    {
        public static Func<Assembly> GetExecutingAssembly()
        {
            try
            {
                return Assembly.GetExecutingAssembly;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Dictionary<string, Type> GetClasses(string nameSpace, Type[] list)
        {
            Dictionary<string, Type> classes = new Dictionary<string, Type>();
            for (int index = 0; index < list.Length; index++)
            {
                if (list[index].Namespace == nameSpace)
                {
                    if (classes.ContainsKey(list[index].Name) == false)
                    {
                        classes.Add(list[index].Name, list[index]);
                    }
                }
            }
            return classes;
        }

    }
}
