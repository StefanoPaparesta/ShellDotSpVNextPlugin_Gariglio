using System;

namespace ShellDotSp.Plugin.GariglioCore.Util
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class XlsColumnAttribute : Attribute
    {
        private string _Description;

        public XlsColumnAttribute(string Description)
        {
            _Description = Description;
        }

        public virtual string Description
        {
            get { return _Description; }
        }
        public virtual int Width { get; set; }
        public virtual VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Center;
        public virtual HorizontalAlignment HorizontallAlignment { get; set; } = HorizontalAlignment.Center;

    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class XlsRowAttribute : Attribute
    {

        public XlsRowAttribute()
        {

        }

        public virtual VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Center;
        public virtual HorizontalAlignment HorizontallAlignment { get; set; } = HorizontalAlignment.Center;
        public virtual string Style { get; set; }

    }


    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class XlsIgnoreAttribute : Attribute
    {
        public XlsIgnoreAttribute()
        {

        }
    }

    public enum HorizontalAlignment
    {
        Left,
        Center,
        Right
    }
    public enum VerticalAlignment
    {
        Top,
        Center,
        Bottom
    }
}
