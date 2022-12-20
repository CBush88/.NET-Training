using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    [AttributeUsage(AttributeTargets.Class | 
        AttributeTargets.Method | 
        AttributeTargets.Struct |
        AttributeTargets.Property,
        AllowMultiple = true)]
    public class DeveloperAttribute : Attribute
    {
        //private fields
        private string name;
        private string level;
        private bool reviewed;

        public DeveloperAttribute(string name, string level)
        {
            this.name = name;
            this.level = level;
            this.reviewed = false;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
        }
        public virtual string Level
        {
            get
            {
                return level;
            }
        }
        public virtual bool Reviewed
        {
            get
            {
                return reviewed;
            }
            set 
            { 
                reviewed = value; 
            }
        }
        public void ShowAttribute()
        {
            Console.WriteLine("");
        }
    }

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Method |
        AttributeTargets.Struct |
        AttributeTargets.Property,
        AllowMultiple = true)]
    public class InfoAttribute : Attribute
    {
        private string info;

        public virtual string Info
        {
            get
            {
                return info;
            }
            set 
            { 
                info = value;
            }
        }
        public InfoAttribute(string info)
        {
            this.info = info;
        }
    }

    [Developer("John Smith", "1", Reviewed = true)]
    [Info("Test Information")]
    internal class CustomAttributeDemo
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(CustomAttributeDemo);
            object[] attr = info.GetCustomAttributes(typeof(DeveloperAttribute), false);
            foreach(object attribute in attr)
            {
                DeveloperAttribute da = (DeveloperAttribute)attribute;
                Console.WriteLine("Name: " + da.Name);
                Console.WriteLine("Level: " + da.Level);
            }

            MemberInfo mInfo = typeof(CustomAttributeDemo);
            object[] attr2 = mInfo.GetCustomAttributes(typeof(InfoAttribute), false);
            foreach(object attribute in attr2)
            {
                InfoAttribute infoAttribute = (InfoAttribute)attribute;
                Console.WriteLine("Info: " + infoAttribute.Info);
            }

            Console.ReadKey();
        }
    }
}
