﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elephtan.DelegationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestMessage", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.DelegationService.DelegationFindRequest))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DelegationFindRequest", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class DelegationFindRequest : Elephtan.DelegationService.RequestMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorizationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromUserId1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToUserId1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StartTime1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EndTime1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DelegationStatus1Field;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string AuthorizationId {
            get {
                return this.AuthorizationIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorizationIdField, value) != true)) {
                    this.AuthorizationIdField = value;
                    this.RaisePropertyChanged("AuthorizationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string FromUserId1 {
            get {
                return this.FromUserId1Field;
            }
            set {
                if ((object.ReferenceEquals(this.FromUserId1Field, value) != true)) {
                    this.FromUserId1Field = value;
                    this.RaisePropertyChanged("FromUserId1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ToUserId1 {
            get {
                return this.ToUserId1Field;
            }
            set {
                if ((object.ReferenceEquals(this.ToUserId1Field, value) != true)) {
                    this.ToUserId1Field = value;
                    this.RaisePropertyChanged("ToUserId1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string StartTime1 {
            get {
                return this.StartTime1Field;
            }
            set {
                if ((object.ReferenceEquals(this.StartTime1Field, value) != true)) {
                    this.StartTime1Field = value;
                    this.RaisePropertyChanged("StartTime1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string EndTime1 {
            get {
                return this.EndTime1Field;
            }
            set {
                if ((object.ReferenceEquals(this.EndTime1Field, value) != true)) {
                    this.EndTime1Field = value;
                    this.RaisePropertyChanged("EndTime1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string DelegationStatus1 {
            get {
                return this.DelegationStatus1Field;
            }
            set {
                if ((object.ReferenceEquals(this.DelegationStatus1Field, value) != true)) {
                    this.DelegationStatus1Field = value;
                    this.RaisePropertyChanged("DelegationStatus1");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DelegationFindResponse", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class DelegationFindResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceResponseMessgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceResponseCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorizationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromUserId1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToUserId1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StartTime1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EndTime1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DelegationStatus1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToUserNameField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string AuthorizationId {
            get {
                return this.AuthorizationIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorizationIdField, value) != true)) {
                    this.AuthorizationIdField = value;
                    this.RaisePropertyChanged("AuthorizationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string FromUserId1 {
            get {
                return this.FromUserId1Field;
            }
            set {
                if ((object.ReferenceEquals(this.FromUserId1Field, value) != true)) {
                    this.FromUserId1Field = value;
                    this.RaisePropertyChanged("FromUserId1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ToUserId1 {
            get {
                return this.ToUserId1Field;
            }
            set {
                if ((object.ReferenceEquals(this.ToUserId1Field, value) != true)) {
                    this.ToUserId1Field = value;
                    this.RaisePropertyChanged("ToUserId1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string StartTime1 {
            get {
                return this.StartTime1Field;
            }
            set {
                if ((object.ReferenceEquals(this.StartTime1Field, value) != true)) {
                    this.StartTime1Field = value;
                    this.RaisePropertyChanged("StartTime1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string EndTime1 {
            get {
                return this.EndTime1Field;
            }
            set {
                if ((object.ReferenceEquals(this.EndTime1Field, value) != true)) {
                    this.EndTime1Field = value;
                    this.RaisePropertyChanged("EndTime1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string DelegationStatus1 {
            get {
                return this.DelegationStatus1Field;
            }
            set {
                if ((object.ReferenceEquals(this.DelegationStatus1Field, value) != true)) {
                    this.DelegationStatus1Field = value;
                    this.RaisePropertyChanged("DelegationStatus1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string ToUserName {
            get {
                return this.ToUserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ToUserNameField, value) != true)) {
                    this.ToUserNameField = value;
                    this.RaisePropertyChanged("ToUserName");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie", ConfigurationName="DelegationService.DelegationServiceSoap")]
    public interface DelegationServiceSoap {
        
        // CODEGEN: Generating message contract since element name request from namespace http://www.nus.edu.sg/storeservcie is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/addDelegation", ReplyAction="*")]
        Elephtan.DelegationService.addDelegationResponse addDelegation(Elephtan.DelegationService.addDelegationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/addDelegation", ReplyAction="*")]
        System.Threading.Tasks.Task<Elephtan.DelegationService.addDelegationResponse> addDelegationAsync(Elephtan.DelegationService.addDelegationRequest request);
        
        // CODEGEN: Generating message contract since element name request from namespace http://www.nus.edu.sg/storeservcie is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/updateDelegation", ReplyAction="*")]
        Elephtan.DelegationService.updateDelegationResponse updateDelegation(Elephtan.DelegationService.updateDelegationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/updateDelegation", ReplyAction="*")]
        System.Threading.Tasks.Task<Elephtan.DelegationService.updateDelegationResponse> updateDelegationAsync(Elephtan.DelegationService.updateDelegationRequest request);
        
        // CODEGEN: Generating message contract since element name request from namespace http://www.nus.edu.sg/storeservcie is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/findDelegation", ReplyAction="*")]
        Elephtan.DelegationService.findDelegationResponse findDelegation(Elephtan.DelegationService.findDelegationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/findDelegation", ReplyAction="*")]
        System.Threading.Tasks.Task<Elephtan.DelegationService.findDelegationResponse> findDelegationAsync(Elephtan.DelegationService.findDelegationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addDelegationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addDelegation", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DelegationService.addDelegationRequestBody Body;
        
        public addDelegationRequest() {
        }
        
        public addDelegationRequest(Elephtan.DelegationService.addDelegationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class addDelegationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DelegationService.DelegationFindRequest request;
        
        public addDelegationRequestBody() {
        }
        
        public addDelegationRequestBody(Elephtan.DelegationService.DelegationFindRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addDelegationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addDelegationResponse", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DelegationService.addDelegationResponseBody Body;
        
        public addDelegationResponse() {
        }
        
        public addDelegationResponse(Elephtan.DelegationService.addDelegationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class addDelegationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DelegationService.DelegationFindResponse addDelegationResult;
        
        public addDelegationResponseBody() {
        }
        
        public addDelegationResponseBody(Elephtan.DelegationService.DelegationFindResponse addDelegationResult) {
            this.addDelegationResult = addDelegationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateDelegationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateDelegation", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DelegationService.updateDelegationRequestBody Body;
        
        public updateDelegationRequest() {
        }
        
        public updateDelegationRequest(Elephtan.DelegationService.updateDelegationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class updateDelegationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DelegationService.DelegationFindRequest request;
        
        public updateDelegationRequestBody() {
        }
        
        public updateDelegationRequestBody(Elephtan.DelegationService.DelegationFindRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateDelegationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateDelegationResponse", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DelegationService.updateDelegationResponseBody Body;
        
        public updateDelegationResponse() {
        }
        
        public updateDelegationResponse(Elephtan.DelegationService.updateDelegationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class updateDelegationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DelegationService.DelegationFindResponse updateDelegationResult;
        
        public updateDelegationResponseBody() {
        }
        
        public updateDelegationResponseBody(Elephtan.DelegationService.DelegationFindResponse updateDelegationResult) {
            this.updateDelegationResult = updateDelegationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class findDelegationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="findDelegation", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DelegationService.findDelegationRequestBody Body;
        
        public findDelegationRequest() {
        }
        
        public findDelegationRequest(Elephtan.DelegationService.findDelegationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class findDelegationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DelegationService.DelegationFindRequest request;
        
        public findDelegationRequestBody() {
        }
        
        public findDelegationRequestBody(Elephtan.DelegationService.DelegationFindRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class findDelegationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="findDelegationResponse", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.DelegationService.findDelegationResponseBody Body;
        
        public findDelegationResponse() {
        }
        
        public findDelegationResponse(Elephtan.DelegationService.findDelegationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class findDelegationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.DelegationService.DelegationFindResponse findDelegationResult;
        
        public findDelegationResponseBody() {
        }
        
        public findDelegationResponseBody(Elephtan.DelegationService.DelegationFindResponse findDelegationResult) {
            this.findDelegationResult = findDelegationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DelegationServiceSoapChannel : Elephtan.DelegationService.DelegationServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DelegationServiceSoapClient : System.ServiceModel.ClientBase<Elephtan.DelegationService.DelegationServiceSoap>, Elephtan.DelegationService.DelegationServiceSoap {
        
        public DelegationServiceSoapClient() {
        }
        
        public DelegationServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DelegationServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DelegationServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DelegationServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Elephtan.DelegationService.addDelegationResponse Elephtan.DelegationService.DelegationServiceSoap.addDelegation(Elephtan.DelegationService.addDelegationRequest request) {
            return base.Channel.addDelegation(request);
        }
        
        public Elephtan.DelegationService.DelegationFindResponse addDelegation(Elephtan.DelegationService.DelegationFindRequest request) {
            Elephtan.DelegationService.addDelegationRequest inValue = new Elephtan.DelegationService.addDelegationRequest();
            inValue.Body = new Elephtan.DelegationService.addDelegationRequestBody();
            inValue.Body.request = request;
            Elephtan.DelegationService.addDelegationResponse retVal = ((Elephtan.DelegationService.DelegationServiceSoap)(this)).addDelegation(inValue);
            return retVal.Body.addDelegationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Elephtan.DelegationService.addDelegationResponse> Elephtan.DelegationService.DelegationServiceSoap.addDelegationAsync(Elephtan.DelegationService.addDelegationRequest request) {
            return base.Channel.addDelegationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Elephtan.DelegationService.addDelegationResponse> addDelegationAsync(Elephtan.DelegationService.DelegationFindRequest request) {
            Elephtan.DelegationService.addDelegationRequest inValue = new Elephtan.DelegationService.addDelegationRequest();
            inValue.Body = new Elephtan.DelegationService.addDelegationRequestBody();
            inValue.Body.request = request;
            return ((Elephtan.DelegationService.DelegationServiceSoap)(this)).addDelegationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Elephtan.DelegationService.updateDelegationResponse Elephtan.DelegationService.DelegationServiceSoap.updateDelegation(Elephtan.DelegationService.updateDelegationRequest request) {
            return base.Channel.updateDelegation(request);
        }
        
        public Elephtan.DelegationService.DelegationFindResponse updateDelegation(Elephtan.DelegationService.DelegationFindRequest request) {
            Elephtan.DelegationService.updateDelegationRequest inValue = new Elephtan.DelegationService.updateDelegationRequest();
            inValue.Body = new Elephtan.DelegationService.updateDelegationRequestBody();
            inValue.Body.request = request;
            Elephtan.DelegationService.updateDelegationResponse retVal = ((Elephtan.DelegationService.DelegationServiceSoap)(this)).updateDelegation(inValue);
            return retVal.Body.updateDelegationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Elephtan.DelegationService.updateDelegationResponse> Elephtan.DelegationService.DelegationServiceSoap.updateDelegationAsync(Elephtan.DelegationService.updateDelegationRequest request) {
            return base.Channel.updateDelegationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Elephtan.DelegationService.updateDelegationResponse> updateDelegationAsync(Elephtan.DelegationService.DelegationFindRequest request) {
            Elephtan.DelegationService.updateDelegationRequest inValue = new Elephtan.DelegationService.updateDelegationRequest();
            inValue.Body = new Elephtan.DelegationService.updateDelegationRequestBody();
            inValue.Body.request = request;
            return ((Elephtan.DelegationService.DelegationServiceSoap)(this)).updateDelegationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Elephtan.DelegationService.findDelegationResponse Elephtan.DelegationService.DelegationServiceSoap.findDelegation(Elephtan.DelegationService.findDelegationRequest request) {
            return base.Channel.findDelegation(request);
        }
        
        public Elephtan.DelegationService.DelegationFindResponse findDelegation(Elephtan.DelegationService.DelegationFindRequest request) {
            Elephtan.DelegationService.findDelegationRequest inValue = new Elephtan.DelegationService.findDelegationRequest();
            inValue.Body = new Elephtan.DelegationService.findDelegationRequestBody();
            inValue.Body.request = request;
            Elephtan.DelegationService.findDelegationResponse retVal = ((Elephtan.DelegationService.DelegationServiceSoap)(this)).findDelegation(inValue);
            return retVal.Body.findDelegationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Elephtan.DelegationService.findDelegationResponse> Elephtan.DelegationService.DelegationServiceSoap.findDelegationAsync(Elephtan.DelegationService.findDelegationRequest request) {
            return base.Channel.findDelegationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Elephtan.DelegationService.findDelegationResponse> findDelegationAsync(Elephtan.DelegationService.DelegationFindRequest request) {
            Elephtan.DelegationService.findDelegationRequest inValue = new Elephtan.DelegationService.findDelegationRequest();
            inValue.Body = new Elephtan.DelegationService.findDelegationRequestBody();
            inValue.Body.request = request;
            return ((Elephtan.DelegationService.DelegationServiceSoap)(this)).findDelegationAsync(inValue);
        }
    }
}
