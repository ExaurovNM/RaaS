﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SyncAnchor", Namespace="http://www.radiantrfid.com/rms/")]
    [System.SerializableAttribute()]
    public partial class SyncAnchor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] AnchorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Anchor {
            get {
                return this.AnchorField;
            }
            set {
                if ((object.ReferenceEquals(this.AnchorField, value) != true)) {
                    this.AnchorField = value;
                    this.RaisePropertyChanged("Anchor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RowSetOfTagReadwHn9YQzw", Namespace="http://www.radiantrfid.com/rms/")]
    [System.SerializableAttribute()]
    public partial class RowSetOfTagReadwHn9YQzw : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasMoreDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.TagRead[] RowsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasMoreData {
            get {
                return this.HasMoreDataField;
            }
            set {
                if ((this.HasMoreDataField.Equals(value) != true)) {
                    this.HasMoreDataField = value;
                    this.RaisePropertyChanged("HasMoreData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.TagRead[] Rows {
            get {
                return this.RowsField;
            }
            set {
                if ((object.ReferenceEquals(this.RowsField, value) != true)) {
                    this.RowsField = value;
                    this.RaisePropertyChanged("Rows");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TagRead", Namespace="http://www.radiantrfid.com/rms/")]
    [System.SerializableAttribute()]
    public partial class TagRead : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte AntennaMaskField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid DeviceIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EpcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EventTimeUtcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAccessGrantedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> RssiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte AntennaMask {
            get {
                return this.AntennaMaskField;
            }
            set {
                if ((this.AntennaMaskField.Equals(value) != true)) {
                    this.AntennaMaskField = value;
                    this.RaisePropertyChanged("AntennaMask");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid DeviceID {
            get {
                return this.DeviceIDField;
            }
            set {
                if ((this.DeviceIDField.Equals(value) != true)) {
                    this.DeviceIDField = value;
                    this.RaisePropertyChanged("DeviceID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Epc {
            get {
                return this.EpcField;
            }
            set {
                if ((object.ReferenceEquals(this.EpcField, value) != true)) {
                    this.EpcField = value;
                    this.RaisePropertyChanged("Epc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventTimeUtc {
            get {
                return this.EventTimeUtcField;
            }
            set {
                if ((this.EventTimeUtcField.Equals(value) != true)) {
                    this.EventTimeUtcField = value;
                    this.RaisePropertyChanged("EventTimeUtc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAccessGranted {
            get {
                return this.IsAccessGrantedField;
            }
            set {
                if ((this.IsAccessGrantedField.Equals(value) != true)) {
                    this.IsAccessGrantedField = value;
                    this.RaisePropertyChanged("IsAccessGranted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Rssi {
            get {
                return this.RssiField;
            }
            set {
                if ((this.RssiField.Equals(value) != true)) {
                    this.RssiField = value;
                    this.RaisePropertyChanged("Rssi");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.radiantrfid.com/rms/", ConfigurationName="TagReadHistoryRepositoryService.TagReadHistoryRepository")]
    public interface TagReadHistoryRepository {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetZeroAnchor", ReplyAction="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetZeroAnchorResponse")]
        RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor GetZeroAnchor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetCurrentAnchor", ReplyAction="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetCurrentAnchorResponse")]
        RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor GetCurrentAnchor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetCurrentAnchorWithConte" +
            "xt", ReplyAction="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetCurrentAnchorWithConte" +
            "xtResponse")]
        RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor GetCurrentAnchorWithContext(string applicationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetTagReadsAutoSize", ReplyAction="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetTagReadsAutoSizeRespon" +
            "se")]
        RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.RowSetOfTagReadwHn9YQzw GetTagReadsAutoSize(RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor lastReceivedAnchor, RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor newReceivedAnchor, int firstResult);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetTagReads", ReplyAction="http://www.radiantrfid.com/rms/TagReadHistoryRepository/GetTagReadsResponse")]
        RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.RowSetOfTagReadwHn9YQzw GetTagReads(RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor lastReceivedAnchor, RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor newReceivedAnchor, int firstResult, int maxResults);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TagReadHistoryRepositoryChannel : RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.TagReadHistoryRepository, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TagReadHistoryRepositoryClient : System.ServiceModel.ClientBase<RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.TagReadHistoryRepository>, RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.TagReadHistoryRepository {
        
        public TagReadHistoryRepositoryClient() {
        }
        
        public TagReadHistoryRepositoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TagReadHistoryRepositoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TagReadHistoryRepositoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TagReadHistoryRepositoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor GetZeroAnchor() {
            return base.Channel.GetZeroAnchor();
        }
        
        public RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor GetCurrentAnchor() {
            return base.Channel.GetCurrentAnchor();
        }
        
        public RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor GetCurrentAnchorWithContext(string applicationName) {
            return base.Channel.GetCurrentAnchorWithContext(applicationName);
        }
        
        public RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.RowSetOfTagReadwHn9YQzw GetTagReadsAutoSize(RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor lastReceivedAnchor, RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor newReceivedAnchor, int firstResult) {
            return base.Channel.GetTagReadsAutoSize(lastReceivedAnchor, newReceivedAnchor, firstResult);
        }
        
        public RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.RowSetOfTagReadwHn9YQzw GetTagReads(RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor lastReceivedAnchor, RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService.SyncAnchor newReceivedAnchor, int firstResult, int maxResults) {
            return base.Channel.GetTagReads(lastReceivedAnchor, newReceivedAnchor, firstResult, maxResults);
        }
    }
}
