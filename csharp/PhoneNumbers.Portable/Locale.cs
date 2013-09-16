using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace PhoneNumbers
{
    public class LocaleData
    {
        private static Dictionary<String, Dictionary<String, String>> _data;

        public static Dictionary<String, Dictionary<String, String>> Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new Dictionary<string, Dictionary<string, string>>();
                    var asm = Redirections.GetAssembly();
                    var name = asm.GetManifestResourceNames().FirstOrDefault(n => n.EndsWith("localedata")) ?? "missing";
                    using (var ms = asm.GetManifestResourceStream(name))
                    {
                        var serializer = new DataContractJsonSerializer(_data.GetType());
                        ms.Position = 0;
                        _data = (Dictionary<String, Dictionary<String, String>>)serializer.ReadObject(ms);
                    }
                }
                return _data;
            }
        }
    }
}
