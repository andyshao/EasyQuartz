﻿using System;

namespace EasyQuartz
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class JobIgnoreAttribute : Attribute
    {
    }
}
