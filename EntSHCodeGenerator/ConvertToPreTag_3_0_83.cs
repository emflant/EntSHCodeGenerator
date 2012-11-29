using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntSHCodeGenerator
{
    class ConvertToPreTag_3_0_83 : IConverToPreTag
    {
        // applescript            @shBrushAppleScript.js
        // actionscript3 as3      @shBrushAS3.js
        // bash shell             @shBrushBash.js
        // coldfusion cf          @shBrushColdFusion.js
        // cpp c                  @shBrushCpp.js
        // c# c-sharp csharp      @shBrushCSharp.js
        // css                    @shBrushCss.js
        // delphi pascal          @shBrushDelphi.js
        // diff patch pas         @shBrushDiff.js
        // erl erlang             @shBrushErlang.js
        // groovy                 @shBrushGroovy.js
        // java                   @shBrushJava.js
        // jfx javafx             @shBrushJavaFX.js
        // js jscript javascript  @shBrushJScript.js
        // perl pl                @shBrushPerl.js
        // php                    @shBrushPhp.js
        // text plain             @shBrushPlain.js
        // py python              @shBrushPython.js
        // ruby rails ror rb      @shBrushRuby.js
        // sass scss              @shBrushSass.js
        // scala                  @shBrushScala.js
        // sql                    @shBrushSql.js
        // vb vbnet               @shBrushVb.js
        // xml xhtml xslt html    @shBrushXml.js

        
        public string[] getRule()
        {
            string[] strRule = {
                               
                  "applescript            @shBrushAppleScript.js"
                , "actionscript3 as3      @shBrushAS3.js        "
                , "bash shell             @shBrushBash.js       "
                , "coldfusion cf          @shBrushColdFusion.js "
                , "cpp c                  @shBrushCpp.js        "
                , "c# c-sharp csharp      @shBrushCSharp.js     "
                , "css                    @shBrushCss.js        "
                , "delphi pascal          @shBrushDelphi.js     "
                , "diff patch pas         @shBrushDiff.js       "
                , "erl erlang             @shBrushErlang.js     "
                , "groovy                 @shBrushGroovy.js     "
                , "java                   @shBrushJava.js       "
                , "jfx javafx             @shBrushJavaFX.js     "
                , "js jscript javascript  @shBrushJScript.js    "
                , "perl pl                @shBrushPerl.js       "
                , "php                    @shBrushPhp.js        "
                , "text plain             @shBrushPlain.js      "
                , "py python              @shBrushPython.js     "
                , "ruby rails ror rb      @shBrushRuby.js       "
                , "sass scss              @shBrushSass.js       "
                , "scala                  @shBrushScala.js      "
                , "sql                    @shBrushSql.js        "
                , "vb vbnet               @shBrushVb.js         "
                , "xml xhtml xslt html    @shBrushXml.js        "
                               
                };

            return strRule;
        }

        
        public string convert(string source, string languageType)
        {
            String[] strarr = languageType.Split(' ');

            string str1 = source.Replace("<", "&lt;");
            string str2 = str1.Replace(">", "&gt;");

            StringBuilder sb = new StringBuilder();
            sb.Append("<pre class=\"brush: ");
            sb.Append(strarr[0]);
            sb.Append(";\">\n");
            sb.Append(str2);
            sb.Append("\n</pre>");

            //<PRE class="brush: css;">

            return sb.ToString();
        }

    }
}
