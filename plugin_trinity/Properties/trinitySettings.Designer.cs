﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace plugin_trinity.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
    internal sealed partial class trinitySettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static trinitySettings defaultInstance = ((trinitySettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new trinitySettings())));
        
        public static trinitySettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string gatewayIP {
            get {
                return ((string)(this["gatewayIP"]));
            }
            set {
                this["gatewayIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8089")]
        public string gatewayPort {
            get {
                return ((string)(this["gatewayPort"]));
            }
            set {
                this["gatewayPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string localIp {
            get {
                return ((string)(this["localIp"]));
            }
            set {
                this["localIp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20556")]
        public string localPort {
            get {
                return ((string)(this["localPort"]));
            }
            set {
                this["localPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20030515")]
        public uint trinityMagicMainNet {
            get {
                return ((uint)(this["trinityMagicMainNet"]));
            }
            set {
                this["trinityMagicMainNet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("19990331")]
        public uint trinityMagicTestNet {
            get {
                return ((uint)(this["trinityMagicTestNet"]));
            }
            set {
                this["trinityMagicTestNet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7630401")]
        public uint neoMagicMainNet {
            get {
                return ((uint)(this["neoMagicMainNet"]));
            }
            set {
                this["neoMagicMainNet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1953787457")]
        public uint neoMagicTestNet {
            get {
                return ((uint)(this["neoMagicTestNet"]));
            }
            set {
                this["neoMagicTestNet"] = value;
            }
        }
    }
}
