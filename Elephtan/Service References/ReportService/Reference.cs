﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elephtan.ReportService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestMessage", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.ReportService.ReportFindRequest))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportFindRequest", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class ReportFindRequest : Elephtan.ReportService.RequestMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReportTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TopItemRangeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MonthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((object.ReferenceEquals(this.StartDateField, value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((object.ReferenceEquals(this.EndDateField, value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ReportType {
            get {
                return this.ReportTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportTypeField, value) != true)) {
                    this.ReportTypeField = value;
                    this.RaisePropertyChanged("ReportType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string TopItemRange {
            get {
                return this.TopItemRangeField;
            }
            set {
                if ((object.ReferenceEquals(this.TopItemRangeField, value) != true)) {
                    this.TopItemRangeField = value;
                    this.RaisePropertyChanged("TopItemRange");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Year {
            get {
                return this.YearField;
            }
            set {
                if ((object.ReferenceEquals(this.YearField, value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Month {
            get {
                return this.MonthField;
            }
            set {
                if ((object.ReferenceEquals(this.MonthField, value) != true)) {
                    this.MonthField = value;
                    this.RaisePropertyChanged("Month");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryIdField, value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemIdField, value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseMessage", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Elephtan.ReportService.ReportFindResponse))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportFindResponse", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class ReportFindResponse : Elephtan.ReportService.ResponseMessage {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Elephtan.ReportService.ReportDepartmentItemInfo[] ReportDepartmentItemInfoListField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Elephtan.ReportService.ReportDepartmentItemInfo[] ReportDepartmentItemInfoList {
            get {
                return this.ReportDepartmentItemInfoListField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportDepartmentItemInfoListField, value) != true)) {
                    this.ReportDepartmentItemInfoListField = value;
                    this.RaisePropertyChanged("ReportDepartmentItemInfoList");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportDepartmentItemInfo", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class ReportDepartmentItemInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Elephtan.ReportService.ReportItemInfo[] ReportItemInfoListField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Elephtan.ReportService.ReportItemInfo[] ReportItemInfoList {
            get {
                return this.ReportItemInfoListField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportItemInfoListField, value) != true)) {
                    this.ReportItemInfoListField = value;
                    this.RaisePropertyChanged("ReportItemInfoList");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportItemInfo", Namespace="http://www.nus.edu.sg/storeservcie")]
    [System.SerializableAttribute()]
    public partial class ReportItemInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AppliedQuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YearMonthStringField;
        
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
        public string ItemName {
            get {
                return this.ItemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemNameField, value) != true)) {
                    this.ItemNameField = value;
                    this.RaisePropertyChanged("ItemName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string AppliedQuantity {
            get {
                return this.AppliedQuantityField;
            }
            set {
                if ((object.ReferenceEquals(this.AppliedQuantityField, value) != true)) {
                    this.AppliedQuantityField = value;
                    this.RaisePropertyChanged("AppliedQuantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string YearMonthString {
            get {
                return this.YearMonthStringField;
            }
            set {
                if ((object.ReferenceEquals(this.YearMonthStringField, value) != true)) {
                    this.YearMonthStringField = value;
                    this.RaisePropertyChanged("YearMonthString");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie", ConfigurationName="ReportService.ReportServiceSoap")]
    public interface ReportServiceSoap {
        
        // CODEGEN: Generating message contract since element name request from namespace http://www.nus.edu.sg/storeservcie is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/QueryReport", ReplyAction="*")]
        Elephtan.ReportService.QueryReportResponse QueryReport(Elephtan.ReportService.QueryReportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nus.edu.sg/storeservcie/QueryReport", ReplyAction="*")]
        System.Threading.Tasks.Task<Elephtan.ReportService.QueryReportResponse> QueryReportAsync(Elephtan.ReportService.QueryReportRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryReportRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryReport", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.ReportService.QueryReportRequestBody Body;
        
        public QueryReportRequest() {
        }
        
        public QueryReportRequest(Elephtan.ReportService.QueryReportRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class QueryReportRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.ReportService.ReportFindRequest request;
        
        public QueryReportRequestBody() {
        }
        
        public QueryReportRequestBody(Elephtan.ReportService.ReportFindRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryReportResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryReportResponse", Namespace="http://www.nus.edu.sg/storeservcie", Order=0)]
        public Elephtan.ReportService.QueryReportResponseBody Body;
        
        public QueryReportResponse() {
        }
        
        public QueryReportResponse(Elephtan.ReportService.QueryReportResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nus.edu.sg/storeservcie")]
    public partial class QueryReportResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Elephtan.ReportService.ReportFindResponse QueryReportResult;
        
        public QueryReportResponseBody() {
        }
        
        public QueryReportResponseBody(Elephtan.ReportService.ReportFindResponse QueryReportResult) {
            this.QueryReportResult = QueryReportResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ReportServiceSoapChannel : Elephtan.ReportService.ReportServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportServiceSoapClient : System.ServiceModel.ClientBase<Elephtan.ReportService.ReportServiceSoap>, Elephtan.ReportService.ReportServiceSoap {
        
        public ReportServiceSoapClient() {
        }
        
        public ReportServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReportServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Elephtan.ReportService.QueryReportResponse Elephtan.ReportService.ReportServiceSoap.QueryReport(Elephtan.ReportService.QueryReportRequest request) {
            return base.Channel.QueryReport(request);
        }
        
        public Elephtan.ReportService.ReportFindResponse QueryReport(Elephtan.ReportService.ReportFindRequest request) {
            Elephtan.ReportService.QueryReportRequest inValue = new Elephtan.ReportService.QueryReportRequest();
            inValue.Body = new Elephtan.ReportService.QueryReportRequestBody();
            inValue.Body.request = request;
            Elephtan.ReportService.QueryReportResponse retVal = ((Elephtan.ReportService.ReportServiceSoap)(this)).QueryReport(inValue);
            return retVal.Body.QueryReportResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Elephtan.ReportService.QueryReportResponse> Elephtan.ReportService.ReportServiceSoap.QueryReportAsync(Elephtan.ReportService.QueryReportRequest request) {
            return base.Channel.QueryReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<Elephtan.ReportService.QueryReportResponse> QueryReportAsync(Elephtan.ReportService.ReportFindRequest request) {
            Elephtan.ReportService.QueryReportRequest inValue = new Elephtan.ReportService.QueryReportRequest();
            inValue.Body = new Elephtan.ReportService.QueryReportRequestBody();
            inValue.Body.request = request;
            return ((Elephtan.ReportService.ReportServiceSoap)(this)).QueryReportAsync(inValue);
        }
    }
}