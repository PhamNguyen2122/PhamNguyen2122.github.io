using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace LAP456.Viewmodels
{
    public class ValidTime : ValidationAttribute

    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "hh:mm", CultureInfo.CurrentCulture,

                DateTimeStyles.NoCurrentDateDefault, out dateTime
            );
            return isValid;
        }
    }
}