using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SimpleFac.Models;

namespace SimpleFac
{
    public class SimpleFac
    {
        private static SimpleFac _instance;

        private SimpleFac()
        {
            _containerList = new List<RegisterComponent>();
        }

        #region container

        private IList<RegisterComponent> _containerList;
            #endregion

        [MethodImplAttribute(MethodImplOptions.Synchronized)]
        public static SimpleFac GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SimpleFac();
            }
            return _instance;
        }

        public void Register(Type source, Type destination)
        {
            _containerList.Add(new RegisterComponent
            {
                Source = source,
                Destination = destination
            });
        }

        public T Resolve<T>()
        {
            var typeofClass = typeof (T);
            foreach (var registerComponent in _containerList)
            {
                if (registerComponent.Source == typeofClass)
                {
                    return (T)Activator.CreateInstance(registerComponent.Destination); ;
                }
            }
            return default(T);
        }
    }
}
