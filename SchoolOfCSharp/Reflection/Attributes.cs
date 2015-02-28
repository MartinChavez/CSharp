using System;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Property)] //You can create class(or method) level attributes
    public class DangerZoneAttribute : Attribute //In order to create attributes you need to inherit from Attribute Interface
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
