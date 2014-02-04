using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GenerateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TemplatesExportTemplate> templates = new List<TemplatesExportTemplate>();
            foreach (var template in GenerationTypes.templates)
            {
                foreach (var typeDesciption in GenerationTypes.types)
                {
                    templates.Add(new TemplatesExportTemplate()
                    {
                        Categories = "Mnemonics",
                        Context = new TemplatesExportTemplateContext()
                        {
                            CSharpContext = new TemplatesExportTemplateContextCSharpContext()
                            {
                                context = template.Context,
                                minimumLanguageVersion = 2.0m
                            },
                        },
                        description = string.Empty,
                        reformat = "true",
                        shortcut = string.Format("{0}{1}", template.Shortcut, typeDesciption.Shortcut),
                        shortenQualifiedReferences = "true",
                        text = string.Format(template.Text,typeDesciption.Type,typeDesciption.DefaultValue),
                        Variables = new[]
                        {
                            new TemplatesExportTemplateVariable(){name = }, 
                        }
                    });
                }
            }
        }

    }

    public class GenerationTypes
    {
        public static List<TypeDesciption> types = new List<TypeDesciption>()
        {
            new TypeDesciption("b", "bool", "false"),
            new TypeDesciption("c", "char", "0"),
            new TypeDesciption("f", "float", "0.0f"),
            new TypeDesciption("by", "byte", "0"),
            new TypeDesciption("d", "double", "0.0"),
            new TypeDesciption("i", "int", "0"),
            new TypeDesciption("de", "decimal", "0M"),
            new TypeDesciption("s", "string", "\"\""),
            new TypeDesciption("l", "long", "0"),
            new TypeDesciption("u", "uint", "0"),
            new TypeDesciption("g", "System.Guid", "System.Guid.NewGuid()"),
            new TypeDesciption("d8", "System.DateTime", "System.DateTime.UtcNow"),
            new TypeDesciption("sb", "System.Text.StringBuilder", "new System.Text.StringBuilder()")
        };

        public static List<TemplateDescription> templates = new List<TemplateDescription>()
        {
            new TemplateDescription("v", "private {0} $fieldname$;", Scope.TypeDeclaration ),
            new TemplateDescription("v", "{0} $variableName$ = {1};", Scope.Statement )
        }; 
    }

    public class Scope
    {
        public static string TypeDeclaration = "TypeMember, TypeAndNamespace";
        public static string MemberDeclaration = "TypeMember";
        public static string Statement = "Statement";
    }

    public class TemplateDescription
    {
        public string Shortcut { get; set; }
        public string Text { get; set; }
        public string Context { get; set; }

        public TemplateDescription(string shortcut, string text, string context)
        {
            Shortcut = shortcut;
            Text = text;
            Context = context;
        }
    }

    public class TypeDesciption
    {
        public string Shortcut { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }

        public TypeDesciption(string shortcut, string type, string defaultValue)
        {
            Shortcut = shortcut;
            Type = type;
            DefaultValue = defaultValue;
        }
    }
}
