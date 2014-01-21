﻿//
// Shim.System
//
// Copyright © Cureos AB, 2013-2014
// info at cureos dot com
//

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
    public sealed class DisplayNameAttribute : Attribute
    {
        #region CONSTRUCTORS

        public DisplayNameAttribute(string displayName)
        {
        }

        #endregion
    }
}