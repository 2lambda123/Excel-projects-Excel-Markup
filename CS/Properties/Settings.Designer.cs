﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Markup.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Anthony Duguid")]
        public string App_Author {
            get {
                return ((string)(this["App_Author"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Markup_LastShapeName {
            get {
                return ((string)(this["Markup_LastShapeName"]));
            }
            set {
                this["Markup_LastShapeName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("A")]
        public string Markup_RevisionTriangleCharacter {
            get {
                return ((string)(this["Markup_RevisionTriangleCharacter"]));
            }
            set {
                this["Markup_RevisionTriangleCharacter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color Markup_ShapeLineColor {
            get {
                return ((global::System.Drawing.Color)(this["Markup_ShapeLineColor"]));
            }
            set {
                this["Markup_ShapeLineColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyy-MM-ddThh:mm:ss:fffzzz")]
        public string Markup_ShapeDateFormat {
            get {
                return ((string)(this["Markup_ShapeDateFormat"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Temp")]
        public string App_LogFilePath {
            get {
                return ((string)(this["App_LogFilePath"]));
            }
            set {
                this["App_LogFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/Office-projects/")]
        public string App_PathReadMe {
            get {
                return ((string)(this["App_PathReadMe"]));
            }
            set {
                this["App_PathReadMe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/Office-projects/")]
        public string App_PathNewIssue {
            get {
                return ((string)(this["App_PathNewIssue"]));
            }
            set {
                this["App_PathNewIssue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("07/31/2017 13:05:00")]
        public global::System.DateTime App_ReleaseDate {
            get {
                return ((global::System.DateTime)(this["App_ReleaseDate"]));
            }
            set {
                this["App_ReleaseDate"] = value;
            }
        }
    }
}