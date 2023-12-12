﻿using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using UMT.Sitecore.Abstractions;

namespace UMT.Sitecore.Converters
{
    public class DateTimeFieldTypeConverter : IFieldTypeConverter
    {
        public virtual object Convert(Field field, Item item)
        {
            var dateField = (DateField)field;
            return dateField != null ? dateField.DateTime : (object)null;
        }
    }
}
