using System;
using System.Reflection;

namespace NPoco.FluentMappings
{
    public class ColumnDefinition
    {
        public PropertyInfo PropertyInfo { get; set; }
        public string DbColumnName { get; set; }
        public Type DbColumnType { get; set; }
        public bool? ResultColumn { get; set; }
        public bool? IgnoreColumn { get; set; }
        public bool? VersionColumn { get; set; }
        public bool? ForceUtc { get; set; }
    }
}