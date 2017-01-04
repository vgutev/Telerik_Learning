using System;

namespace DefiningClasses2
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum 
        | AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public int Major { get; set; }
        public int Manor { get; set; }

        public VersionAttribute(int major, int manor)
        {
            this.Major = major;
            this.Manor = manor;
        }
        
        public override string ToString()
        {
            string value = string.Format("Version: {0}.{1}", Major, Manor);
            return value;
        }
    }
}
