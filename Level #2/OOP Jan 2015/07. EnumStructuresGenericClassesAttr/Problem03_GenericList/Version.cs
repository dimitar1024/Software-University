namespace Problem03_GenericList
{
    using System;
    using System.Collections.Generic;

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    internal class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
