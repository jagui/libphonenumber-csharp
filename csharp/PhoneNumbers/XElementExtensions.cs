using System;
using System.Linq;
using System.Xml.Linq;

namespace PhoneNumbers
{
    public static class XElementExtensions
    {
        public static bool HasAttribute(this XElement xElement, string attribute)
        {
            if (String.IsNullOrEmpty(attribute)) return false;
            return xElement.Attributes().Any(xa => String.Equals(xa.Name.LocalName, attribute));
        }

        public static string GetAttribute(this XElement xElement, string attribute)
        {
            return xElement.HasAttribute(attribute) ? xElement.Attribute(attribute).Value : String.Empty;
        }
        public static XElement[] GetElementsByTagName(this XElement xElement, string tagName)
        {
            return xElement.Descendants(tagName).ToArray();
        }
    }
}