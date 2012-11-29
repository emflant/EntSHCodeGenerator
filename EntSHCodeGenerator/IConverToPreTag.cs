using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntSHCodeGenerator
{
    interface IConverToPreTag
    {
        string[] getRule();
        string convert(string source, string languageType);
    }
}
