﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TemplatesExport {
    
    private TemplatesExportTemplate[] templateField;
    
    private string familyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Template")]
    public TemplatesExportTemplate[] Template {
        get {
            return this.templateField;
        }
        set {
            this.templateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string family {
        get {
            return this.familyField;
        }
        set {
            this.familyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplatesExportTemplate {
    
    private TemplatesExportTemplateContext contextField;
    
    private object categoriesField;
    
    private TemplatesExportTemplateVariable[] variablesField;
    
    private object customPropertiesField;
    
    private string uidField;
    
    private string shortcutField;
    
    private string descriptionField;
    
    private string textField;
    
    private string reformatField;
    
    private string shortenQualifiedReferencesField;
    
    /// <remarks/>
    public TemplatesExportTemplateContext Context {
        get {
            return this.contextField;
        }
        set {
            this.contextField = value;
        }
    }
    
    /// <remarks/>
    public object Categories {
        get {
            return this.categoriesField;
        }
        set {
            this.categoriesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Variable", IsNullable=false)]
    public TemplatesExportTemplateVariable[] Variables {
        get {
            return this.variablesField;
        }
        set {
            this.variablesField = value;
        }
    }
    
    /// <remarks/>
    public object CustomProperties {
        get {
            return this.customPropertiesField;
        }
        set {
            this.customPropertiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uid {
        get {
            return this.uidField;
        }
        set {
            this.uidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string shortcut {
        get {
            return this.shortcutField;
        }
        set {
            this.shortcutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string reformat {
        get {
            return this.reformatField;
        }
        set {
            this.reformatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string shortenQualifiedReferences {
        get {
            return this.shortenQualifiedReferencesField;
        }
        set {
            this.shortenQualifiedReferencesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplatesExportTemplateContext {
    
    private TemplatesExportTemplateContextCSharpContext cSharpContextField;
    
    /// <remarks/>
    public TemplatesExportTemplateContextCSharpContext CSharpContext {
        get {
            return this.cSharpContextField;
        }
        set {
            this.cSharpContextField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplatesExportTemplateContextCSharpContext {
    
    private string contextField;
    
    private decimal minimumLanguageVersionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string context {
        get {
            return this.contextField;
        }
        set {
            this.contextField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal minimumLanguageVersion {
        get {
            return this.minimumLanguageVersionField;
        }
        set {
            this.minimumLanguageVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplatesExportTemplateVariable {
    
    private string nameField;
    
    private string expressionField;
    
    private int initialRangeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expression {
        get {
            return this.expressionField;
        }
        set {
            this.expressionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int initialRange {
        get {
            return this.initialRangeField;
        }
        set {
            this.initialRangeField = value;
        }
    }
}