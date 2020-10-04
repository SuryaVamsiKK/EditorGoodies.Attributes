using System;
using UnityEngine;

namespace EGAttributes
{
    public class ReadOnlyAttribute : PropertyAttribute { }

    public class HideAttribute : PropertyAttribute 
    {
        public string boolName;
        public bool editable = false;

        /// <param name="boolName">Name of the dependent boolean</param>
        /// <param name="editable">Whether or not should be a readonly field</param>
        public HideAttribute(string boolName, bool editable = true)
        {
            this.editable = editable;
            this.boolName = boolName;
        }
    }
}
