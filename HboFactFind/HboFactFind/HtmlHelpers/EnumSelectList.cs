using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace HboFactFind.HtmlHelpers
{
    public static class EnumSelectList
    {
        public static SelectList ToSelectList<T>(this T enumeration)
        {
            var source = Enum.GetValues(typeof (T));
            var items = new Dictionary<object, string>();
            var displayAttributeType = typeof (DisplayAttribute);
            foreach (var value in source)
            {
                var field = value.GetType().GetField(value.ToString());
                var attrs = (DisplayAttribute) field.
                    GetCustomAttributes(displayAttributeType, false).FirstOrDefault();
                items.Add(value, attrs != null ? attrs.GetName() : value.ToString());
            }
            return new SelectList(items, "Key", "Value", enumeration);
        }
    }
}