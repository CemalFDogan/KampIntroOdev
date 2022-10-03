using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public class ToTableAttribute :Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
