using System;
using System.Linq;

namespace ShellDotSp.Plugin.GariglioCore.Core.Util
    {
    public class ObjActivator
        {
        public static T GetInstance<T>(string strFullyQualifiedName, params object[] args)
            {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                {
                return (T)Activator.CreateInstance(type, args);
                }

            var assemblyes = (from x
                              in AppDomain.CurrentDomain.GetAssemblies()
                              where x.FullName.Contains("ShellDotSp")
                              select x).ToList();

            foreach (var asm in assemblyes)
                {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    {
                    return (T)Activator.CreateInstance(type, args);
                    }
                }

            return default(T);
            }
        }
    }
