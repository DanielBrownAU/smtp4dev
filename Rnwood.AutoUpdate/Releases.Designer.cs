// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 2.8.2.29599
//    <NameSpace>Rnwood.AutoUpdate</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><IncludeSerializeMethod>False</IncludeSerializeMethod><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>True</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings>
//  <auto-generated>
// ------------------------------------------------------------------------------
namespace Rnwood.AutoUpdate
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rnwood.co.uk/AutoUpdate/Releases")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.rnwood.co.uk/AutoUpdate/Releases", IsNullable = false)]
    public partial class Releases
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Release> releaseField;

        public Releases()
        {
            if ((this.releaseField == null))
            {
                this.releaseField = new List<Release>();
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Release")]
        public List<Release> Release
        {
            get
            {
                return this.releaseField;
            }
            set
            {
                this.releaseField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rnwood.co.uk/AutoUpdate/Releases")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.rnwood.co.uk/AutoUpdate/Releases", IsNullable = false)]
    public partial class Release
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private releaseStatus statusField;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string URL { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string DetailsURL { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version { get; set; }
        
        public Release()
        {
            this.statusField = releaseStatus.release;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(releaseStatus.release)]
        public releaseStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.rnwood.co.uk/AutoUpdate/Releases")]
    public enum releaseStatus
    {

        /// <remarks/>
        release,

        /// <remarks/>
        prerelease,
    }
}
