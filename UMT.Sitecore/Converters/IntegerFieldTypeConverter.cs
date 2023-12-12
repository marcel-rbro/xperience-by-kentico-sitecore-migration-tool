﻿using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using UMT.Sitecore.Abstractions;

namespace UMT.Sitecore.Converters
{
    public class IntegerFieldTypeConverter : IFieldTypeConverter
    {
        public virtual object Convert(Field field, Item item)
        {
            return (object)(int.TryParse(field.Value, out var number) ? number : 0);
        }
    }
}
