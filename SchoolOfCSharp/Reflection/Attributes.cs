using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DangerZoneAttribute : Attribute
    {
        public DangerZoneAttribute(int min, int max)
        {
            Minimum = min;
            Maximum = max;
            Message= String.Empty;
        }

        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public string Message { get; set; }
    }

    
    public class Human
    {
        [DangerZone(12, 18, Message = "Danger")]
        public int Age { get; set; }

        public int Date { get; set; }
    }

}
