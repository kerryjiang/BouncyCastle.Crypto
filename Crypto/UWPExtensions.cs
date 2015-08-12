using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.BouncyCastle.Utilities
{
    public static class UWPExtensions
    {
        public static string ToUpper(this string source, CultureInfo culture)
        {
            if (culture != CultureInfo.InvariantCulture)
                throw new NotSupportedException();

            return source.ToUpperInvariant();
        }

        public static string ToLower(this string source, CultureInfo culture)
        {
            if (culture != CultureInfo.InvariantCulture)
                throw new NotSupportedException();

            return source.ToLowerInvariant();
        }
    }
}
