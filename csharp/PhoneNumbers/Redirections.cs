using System.Reflection;
using System.Text.RegularExpressions;

namespace PhoneNumbers
{
    public static class Redirections
    {
        public const RegexOptions Compiled = RegexOptions.Compiled;

        public static Assembly GetAssembly()
        {
            return typeof(Redirections).Assembly;
        }
    }
}
