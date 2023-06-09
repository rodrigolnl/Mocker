﻿using System.Reflection;
using Mocker.Enums;

namespace Mocker
{
    public class Rule
    {
        internal PropertyInfo Property { get; set; }
        internal RuleType RuleType { get; set; }
        internal Preset? Preset { get; set; }
        internal dynamic? Value { get; set; }
        internal string? Format { get; set; }
        internal Func<object, dynamic>? PropertySource { get; set; }
        internal Operator? Operator { get; set; }
        internal If? Conditional { get; set; }
        internal Func<object, bool>? Statement { get; set; }

    }
}
