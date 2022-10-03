using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredPropertyAttribute : Attribute
    {
    }
}
