﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elephtan.DepartmentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestMessage", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.DepartmentService.DepartmentManageRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.DepartmentService.DepartmentFindRequest))]
    public partial class RequestMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RequestUserNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RequestUserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string RequestUserNo {
            get {
                return this.RequestUserNoField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestUserNoField, value) != true)) {
                    this.RequestUserNoField = value;
                    this.RaisePropertyChanged("RequestUserNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string RequestUserId {
            get {
                return this.RequestUserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestUserIdField, value) != true)) {
                    this.RequestUserIdField = value;
                    this.RaisePropertyChanged("RequestUserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentManageRequest", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class DepartmentManageRequest : Elephtan.DepartmentService.RequestMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaxNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RepresentativeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HeadIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CollectionPointIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentIdField, value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string DepartmentCode {
            get {
                return this.DepartmentCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentCodeField, value) != true)) {
                    this.DepartmentCodeField = value;
                    this.RaisePropertyChanged("DepartmentCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TelephoneNo {
            get {
                return this.TelephoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneNoField, value) != true)) {
                    this.TelephoneNoField = value;
                    this.RaisePropertyChanged("TelephoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string FaxNo {
            get {
                return this.FaxNoField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxNoField, value) != true)) {
                    this.FaxNoField = value;
                    this.RaisePropertyChanged("FaxNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string RepresentativeId {
            get {
                return this.RepresentativeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RepresentativeIdField, value) != true)) {
                    this.RepresentativeIdField = value;
                    this.RaisePropertyChanged("RepresentativeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string HeadId {
            get {
                return this.HeadIdField;
            }
            set {
                if ((object.ReferenceEquals(this.HeadIdField, value) != true)) {
                    this.HeadIdField = value;
                    this.RaisePropertyChanged("HeadId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string CollectionPointId {
            get {
                return this.CollectionPointIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CollectionPointIdField, value) != true)) {
                    this.CollectionPointIdField = value;
                    this.RaisePropertyChanged("CollectionPointId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentFindRequest", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class DepartmentFindRequest : Elephtan.DepartmentService.RequestMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentIdField, value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseMessage", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.DepartmentService.DepartmentManageResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.DepartmentService.DepartmentFindResponse))]
    public partial class ResponseMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceResponseCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceResponseMessgeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ServiceResponseCode {
            get {
                return this.ServiceResponseCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceResponseCodeField, value) != true)) {
                    this.ServiceResponseCodeField = value;
                    this.RaisePropertyChanged("ServiceResponseCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ServiceResponseMessge {
            get {
                return this.ServiceResponseMessgeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceResponseMessgeField, value) != true)) {
                    this.ServiceResponseMessgeField = value;
                    this.RaisePropertyChanged("ServiceResponseMessge");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentManageResponse", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class DepartmentManageResponse : Elephtan.DepartmentService.ResponseMessage {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentFindResponse", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class DepartmentFindResponse : Elephtan.DepartmentService.ResponseMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CollectionAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HeadNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RepresentativeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CollectionTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StoreClertNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaxNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RepresentativeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HeadIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CollectionPointIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CollectionAddress {
            get {
                return this.CollectionAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.CollectionAddressField, value) != true)) {
                    this.CollectionAddressField = value;
                    this.RaisePropertyChanged("CollectionAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string HeadName {
            get {
                return this.HeadNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HeadNameField, value) != true)) {
                    this.HeadNameField = value;
                    this.RaisePropertyChanged("HeadName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string RepresentativeName {
            get {
                return this.RepresentativeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RepresentativeNameField, value) != true)) {
                    this.RepresentativeNameField = value;
                    this.RaisePropertyChanged("RepresentativeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string CollectionTime {
            get {
                return this.CollectionTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.CollectionTimeField, value) != true)) {
                    this.CollectionTimeField = value;
                    this.RaisePropertyChanged("CollectionTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string StoreClertName {
            get {
                return this.StoreClertNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreClertNameField, value) != true)) {
                    this.StoreClertNameField = value;
                    this.RaisePropertyChanged("StoreClertName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentIdField, value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string DepartmentCode {
            get {
                return this.DepartmentCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentCodeField, value) != true)) {
                    this.DepartmentCodeField = value;
                    this.RaisePropertyChanged("DepartmentCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string TelephoneNo {
            get {
                return this.TelephoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneNoField, value) != true)) {
                    this.TelephoneNoField = value;
                    this.RaisePropertyChanged("TelephoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string FaxNo {
            get {
                return this.FaxNoField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxNoField, value) != true)) {
                    this.FaxNoField = value;
                    this.RaisePropertyChanged("FaxNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string RepresentativeId {
            get {
                return this.RepresentativeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RepresentativeIdField, value) != true)) {
                    this.RepresentativeIdField = value;
                    this.RaisePropertyChanged("RepresentativeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string HeadId {
            get {
                return this.HeadIdField;
            }
            set {
                if ((object.ReferenceEquals(this.HeadIdField, value) != true)) {
                    this.HeadIdField = value;
                    this.RaisePropertyChanged("HeadId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string CollectionPointId {
            get {
                return this.CollectionPointIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CollectionPointIdField, value) != true)) {
                    this.CollectionPointIdField = value;
                    this.RaisePropertyChanged("CollectionPointId");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie", ConfigurationName="DepartmentService.DepartmentServiceSoap")]
    public interface DepartmentServiceSoap {
        
        // CODEGEN: Generating message contract since element name departmentFindRequest from namespace http://www.nus.edu.sg/storeservcie is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/QueryDepartment", ReplyAction="*")]
        Elephtan.DepartmentService.QueryDepartmentResponse QueryDepartment(Elephtan.DepartmentService.QueryDepartmentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/QueryDepartment", ReplyAction="*")]
        System.Threading.Tasks.Task<Elephtan.DepartmentService.QueryDepartmentResponse> QueryDepartmentAsync(Elephtan.DepartmentService.QueryDepartmentRequest request);
        
        // CODEGEN: Generating message contract since element name departmentManageRequest from namespace http://www.nus.edu.sg/storeservcie is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/UpdateDepartmentCollectionInfo", ReplyAction="*")]
        Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponse UpdateDepartmentCollectionInfo(Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/UpdateDepartmentCollectionInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponse> UpdateDepartmentCollectionInfoAsync(Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryDepartmentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryDepartment", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DepartmentService.QueryDepartmentRequestBody Body;
        
        public QueryDepartmentRequest() {
        }
        
        public QueryDepartmentRequest(Elephtan.DepartmentService.QueryDepartmentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class QueryDepartmentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DepartmentService.DepartmentFindRequest departmentFindRequest;
        
        public QueryDepartmentRequestBody() {
        }
        
        public QueryDepartmentRequestBody(Elephtan.DepartmentService.DepartmentFindRequest departmentFindRequest) {
            this.departmentFindRequest = departmentFindRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryDepartmentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryDepartmentResponse", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DepartmentService.QueryDepartmentResponseBody Body;
        
        public QueryDepartmentResponse() {
        }
        
        public QueryDepartmentResponse(Elephtan.DepartmentService.QueryDepartmentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class QueryDepartmentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DepartmentService.DepartmentFindResponse QueryDepartmentResult;
        
        public QueryDepartmentResponseBody() {
        }
        
        public QueryDepartmentResponseBody(Elephtan.DepartmentService.DepartmentFindResponse QueryDepartmentResult) {
            this.QueryDepartmentResult = QueryDepartmentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateDepartmentCollectionInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateDepartmentCollectionInfo", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequestBody Body;
        
        public UpdateDepartmentCollectionInfoRequest() {
        }
        
        public UpdateDepartmentCollectionInfoRequest(Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class UpdateDepartmentCollectionInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DepartmentService.DepartmentManageRequest departmentManageRequest;
        
        public UpdateDepartmentCollectionInfoRequestBody() {
        }
        
        public UpdateDepartmentCollectionInfoRequestBody(Elephtan.DepartmentService.DepartmentManageRequest departmentManageRequest) {
            this.departmentManageRequest = departmentManageRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateDepartmentCollectionInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateDepartmentCollectionInfoResponse", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponseBody Body;
        
        public UpdateDepartmentCollectionInfoResponse() {
        }
        
        public UpdateDepartmentCollectionInfoResponse(Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class UpdateDepartmentCollectionInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DepartmentService.DepartmentManageResponse UpdateDepartmentCollectionInfoResult;
        
        public UpdateDepartmentCollectionInfoResponseBody() {
        }
        
        public UpdateDepartmentCollectionInfoResponseBody(Elephtan.DepartmentService.DepartmentManageResponse UpdateDepartmentCollectionInfoResult) {
            this.UpdateDepartmentCollectionInfoResult = UpdateDepartmentCollectionInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DepartmentServiceSoapChannel : Elephtan.DepartmentService.DepartmentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DepartmentServiceSoapClient : System.ServiceModel.ClientBase<Elephtan.DepartmentService.DepartmentServiceSoap>, Elephtan.DepartmentService.DepartmentServiceSoap {
        
        public DepartmentServiceSoapClient() {
        }
        
        public DepartmentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DepartmentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartmentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartmentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Elephtan.DepartmentService.QueryDepartmentResponse Elephtan.DepartmentService.DepartmentServiceSoap.QueryDepartment(Elephtan.DepartmentService.QueryDepartmentRequest request) {
            return base.Channel.QueryDepartment(request);
        }
        
        public Elephtan.DepartmentService.DepartmentFindResponse QueryDepartment(Elephtan.DepartmentService.DepartmentFindRequest departmentFindRequest) {
            Elephtan.DepartmentService.QueryDepartmentRequest inValue = new Elephtan.DepartmentService.QueryDepartmentRequest();
            inValue.Body = new Elephtan.DepartmentService.QueryDepartmentRequestBody();
            inValue.Body.departmentFindRequest = departmentFindRequest;
            Elephtan.DepartmentService.QueryDepartmentResponse retVal = ((Elephtan.DepartmentService.DepartmentServiceSoap)(this)).QueryDepartment(inValue);
            return retVal.Body.QueryDepartmentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Elephtan.DepartmentService.QueryDepartmentResponse> Elephtan.DepartmentService.DepartmentServiceSoap.QueryDepartmentAsync(Elephtan.DepartmentService.QueryDepartmentRequest request) {
            return base.Channel.QueryDepartmentAsync(request);
        }
        
        public System.Threading.Tasks.Task<Elephtan.DepartmentService.QueryDepartmentResponse> QueryDepartmentAsync(Elephtan.DepartmentService.DepartmentFindRequest departmentFindRequest) {
            Elephtan.DepartmentService.QueryDepartmentRequest inValue = new Elephtan.DepartmentService.QueryDepartmentRequest();
            inValue.Body = new Elephtan.DepartmentService.QueryDepartmentRequestBody();
            inValue.Body.departmentFindRequest = departmentFindRequest;
            return ((Elephtan.DepartmentService.DepartmentServiceSoap)(this)).QueryDepartmentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponse Elephtan.DepartmentService.DepartmentServiceSoap.UpdateDepartmentCollectionInfo(Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest request) {
            return base.Channel.UpdateDepartmentCollectionInfo(request);
        }
        
        public Elephtan.DepartmentService.DepartmentManageResponse UpdateDepartmentCollectionInfo(Elephtan.DepartmentService.DepartmentManageRequest departmentManageRequest) {
            Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest inValue = new Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest();
            inValue.Body = new Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequestBody();
            inValue.Body.departmentManageRequest = departmentManageRequest;
            Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponse retVal = ((Elephtan.DepartmentService.DepartmentServiceSoap)(this)).UpdateDepartmentCollectionInfo(inValue);
            return retVal.Body.UpdateDepartmentCollectionInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponse> Elephtan.DepartmentService.DepartmentServiceSoap.UpdateDepartmentCollectionInfoAsync(Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest request) {
            return base.Channel.UpdateDepartmentCollectionInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Elephtan.DepartmentService.UpdateDepartmentCollectionInfoResponse> UpdateDepartmentCollectionInfoAsync(Elephtan.DepartmentService.DepartmentManageRequest departmentManageRequest) {
            Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest inValue = new Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequest();
            inValue.Body = new Elephtan.DepartmentService.UpdateDepartmentCollectionInfoRequestBody();
            inValue.Body.departmentManageRequest = departmentManageRequest;
            return ((Elephtan.DepartmentService.DepartmentServiceSoap)(this)).UpdateDepartmentCollectionInfoAsync(inValue);
        }
    }
}
