//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by the Mvp.Xml.XsdGen tool.
//     Tool Version:    1.1.1.0
//     Runtime Version: 2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
// Workaround for bug http://lab.msdn.microsoft.com/productfeedback/viewfeedback.aspx?feedbackid=d457a36e-0ce8-4368-9a27-92762860d8e1
#pragma warning disable 1591
namespace Microsoft.Practices.RecipeFramework.Configuration.Manifest
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/pag/gax-manifest", IsNullable=false)]
    public partial class RecipeFramework
    {
        
        private Host[] hostsField;
        
        private GuidancePackage[] guidancePackagesField;
        
        private string schemaVersionField;
        
        private TraceLevel traceLevelField;
        
        public RecipeFramework()
        {
            this.schemaVersionField = "1.0";
            this.traceLevelField = TraceLevel.Error;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Host", IsNullable=false)]
        public Host[] Hosts
        {
            get
            {
                return this.hostsField;
            }
            set
            {
                this.hostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GuidancePackage", IsNullable=false)]
        public GuidancePackage[] GuidancePackages
        {
            get
            {
                return this.guidancePackagesField;
            }
            set
            {
                this.guidancePackagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(TraceLevel.Error)]
        public TraceLevel TraceLevel
        {
            get
            {
                return this.traceLevelField;
            }
            set
            {
                this.traceLevelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/pag/gax-manifest", IsNullable=false)]
    public partial class Host
    {
        
        private string nameField;
        
        private string installerTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InstallerType
        {
            get
            {
                return this.installerTypeField;
            }
            set
            {
                this.installerTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/pag/gax-manifest", IsNullable=false)]
    public partial class GuidancePackage
    {
        
        private string nameField;
        
        private string captionField;
        
        private string descriptionField;
        
        private string versionField;
        
        private string hostField;
        
        private string guidField;
        
        private string configurationFileField;
        
        private string timestampField;
        
        public GuidancePackage()
        {
            this.hostField = "VisualStudio";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("VisualStudio")]
        public string Host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfigurationFile
        {
            get
            {
                return this.configurationFileField;
            }
            set
            {
                this.configurationFileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/pag/gax-manifest")]
    public enum TraceLevel
    {
        
        /// <remarks/>
        Error,
        
        /// <remarks/>
        Info,
        
        /// <remarks/>
        Off,
        
        /// <remarks/>
        Warning,
        
        /// <remarks/>
        Verbose,
    }
}

#pragma warning restore 1591