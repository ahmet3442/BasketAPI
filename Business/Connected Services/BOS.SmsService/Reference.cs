//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOS.SmsService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VersionResponse", Namespace="http://tempuri.org/")]
    public partial class VersionResponse : object
    {
        
        private string DeploymentField;
        
        private string DeploymentDateField;
        
        private string VersionIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Deployment
        {
            get
            {
                return this.DeploymentField;
            }
            set
            {
                this.DeploymentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string DeploymentDate
        {
            get
            {
                return this.DeploymentDateField;
            }
            set
            {
                this.DeploymentDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string VersionID
        {
            get
            {
                return this.VersionIDField;
            }
            set
            {
                this.VersionIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SMSSenderTypes", Namespace="http://tempuri.org/")]
    public enum SMSSenderTypes : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Birlesikodm = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Teskkart = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GeceTransferi = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FamilUp = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Kapora = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SmsResult", Namespace="http://tempuri.org/")]
    public partial class SmsResult : object
    {
        
        private string ErrorCodeField;
        
        private string ErrorDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ErrorCode
        {
            get
            {
                return this.ErrorCodeField;
            }
            set
            {
                this.ErrorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ErrorDescription
        {
            get
            {
                return this.ErrorDescriptionField;
            }
            set
            {
                this.ErrorDescriptionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BOS.SmsService.SendSMSV2Soap")]
    public interface SendSMSV2Soap
    {
        
        // CODEGEN: Generating message contract since element name GetVersionResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetVersion", ReplyAction="*")]
        BOS.SmsService.GetVersionResponse GetVersion(BOS.SmsService.GetVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetVersion", ReplyAction="*")]
        System.Threading.Tasks.Task<BOS.SmsService.GetVersionResponse> GetVersionAsync(BOS.SmsService.GetVersionRequest request);
        
        // CODEGEN: Generating message contract since element name messageBody from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueueSmsMessage", ReplyAction="*")]
        BOS.SmsService.QueueSmsMessageResponse QueueSmsMessage(BOS.SmsService.QueueSmsMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueueSmsMessage", ReplyAction="*")]
        System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageResponse> QueueSmsMessageAsync(BOS.SmsService.QueueSmsMessageRequest request);
        
        // CODEGEN: Generating message contract since element name messageBody from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueueSmsMessageBirlesikodm", ReplyAction="*")]
        BOS.SmsService.QueueSmsMessageBirlesikodmResponse QueueSmsMessageBirlesikodm(BOS.SmsService.QueueSmsMessageBirlesikodmRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueueSmsMessageBirlesikodm", ReplyAction="*")]
        System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageBirlesikodmResponse> QueueSmsMessageBirlesikodmAsync(BOS.SmsService.QueueSmsMessageBirlesikodmRequest request);
        
        // CODEGEN: Generating message contract since element name messageBody from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueueSmsMessageBirlesikodmInfo", ReplyAction="*")]
        BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponse QueueSmsMessageBirlesikodmInfo(BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueueSmsMessageBirlesikodmInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponse> QueueSmsMessageBirlesikodmInfoAsync(BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVersionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVersion", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.GetVersionRequestBody Body;
        
        public GetVersionRequest()
        {
        }
        
        public GetVersionRequest(BOS.SmsService.GetVersionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetVersionRequestBody
    {
        
        public GetVersionRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVersionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVersionResponse", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.GetVersionResponseBody Body;
        
        public GetVersionResponse()
        {
        }
        
        public GetVersionResponse(BOS.SmsService.GetVersionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetVersionResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BOS.SmsService.VersionResponse GetVersionResult;
        
        public GetVersionResponseBody()
        {
        }
        
        public GetVersionResponseBody(BOS.SmsService.VersionResponse GetVersionResult)
        {
            this.GetVersionResult = GetVersionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueueSmsMessageRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueueSmsMessage", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.QueueSmsMessageRequestBody Body;
        
        public QueueSmsMessageRequest()
        {
        }
        
        public QueueSmsMessageRequest(BOS.SmsService.QueueSmsMessageRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueueSmsMessageRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string messageBody;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string phoneNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public BOS.SmsService.SMSSenderTypes smsSender;
        
        public QueueSmsMessageRequestBody()
        {
        }
        
        public QueueSmsMessageRequestBody(string messageBody, string phoneNumber, BOS.SmsService.SMSSenderTypes smsSender)
        {
            this.messageBody = messageBody;
            this.phoneNumber = phoneNumber;
            this.smsSender = smsSender;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueueSmsMessageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueueSmsMessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.QueueSmsMessageResponseBody Body;
        
        public QueueSmsMessageResponse()
        {
        }
        
        public QueueSmsMessageResponse(BOS.SmsService.QueueSmsMessageResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueueSmsMessageResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BOS.SmsService.SmsResult QueueSmsMessageResult;
        
        public QueueSmsMessageResponseBody()
        {
        }
        
        public QueueSmsMessageResponseBody(BOS.SmsService.SmsResult QueueSmsMessageResult)
        {
            this.QueueSmsMessageResult = QueueSmsMessageResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueueSmsMessageBirlesikodmRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueueSmsMessageBirlesikodm", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.QueueSmsMessageBirlesikodmRequestBody Body;
        
        public QueueSmsMessageBirlesikodmRequest()
        {
        }
        
        public QueueSmsMessageBirlesikodmRequest(BOS.SmsService.QueueSmsMessageBirlesikodmRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueueSmsMessageBirlesikodmRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string messageBody;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string phoneNumber;
        
        public QueueSmsMessageBirlesikodmRequestBody()
        {
        }
        
        public QueueSmsMessageBirlesikodmRequestBody(string messageBody, string phoneNumber)
        {
            this.messageBody = messageBody;
            this.phoneNumber = phoneNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueueSmsMessageBirlesikodmResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueueSmsMessageBirlesikodmResponse", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.QueueSmsMessageBirlesikodmResponseBody Body;
        
        public QueueSmsMessageBirlesikodmResponse()
        {
        }
        
        public QueueSmsMessageBirlesikodmResponse(BOS.SmsService.QueueSmsMessageBirlesikodmResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueueSmsMessageBirlesikodmResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BOS.SmsService.SmsResult QueueSmsMessageBirlesikodmResult;
        
        public QueueSmsMessageBirlesikodmResponseBody()
        {
        }
        
        public QueueSmsMessageBirlesikodmResponseBody(BOS.SmsService.SmsResult QueueSmsMessageBirlesikodmResult)
        {
            this.QueueSmsMessageBirlesikodmResult = QueueSmsMessageBirlesikodmResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueueSmsMessageBirlesikodmInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueueSmsMessageBirlesikodmInfo", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequestBody Body;
        
        public QueueSmsMessageBirlesikodmInfoRequest()
        {
        }
        
        public QueueSmsMessageBirlesikodmInfoRequest(BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueueSmsMessageBirlesikodmInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string messageBody;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string phoneNumber;
        
        public QueueSmsMessageBirlesikodmInfoRequestBody()
        {
        }
        
        public QueueSmsMessageBirlesikodmInfoRequestBody(string messageBody, string phoneNumber)
        {
            this.messageBody = messageBody;
            this.phoneNumber = phoneNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueueSmsMessageBirlesikodmInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueueSmsMessageBirlesikodmInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponseBody Body;
        
        public QueueSmsMessageBirlesikodmInfoResponse()
        {
        }
        
        public QueueSmsMessageBirlesikodmInfoResponse(BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueueSmsMessageBirlesikodmInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BOS.SmsService.SmsResult QueueSmsMessageBirlesikodmInfoResult;
        
        public QueueSmsMessageBirlesikodmInfoResponseBody()
        {
        }
        
        public QueueSmsMessageBirlesikodmInfoResponseBody(BOS.SmsService.SmsResult QueueSmsMessageBirlesikodmInfoResult)
        {
            this.QueueSmsMessageBirlesikodmInfoResult = QueueSmsMessageBirlesikodmInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface SendSMSV2SoapChannel : BOS.SmsService.SendSMSV2Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class SendSMSV2SoapClient : System.ServiceModel.ClientBase<BOS.SmsService.SendSMSV2Soap>, BOS.SmsService.SendSMSV2Soap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SendSMSV2SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SendSMSV2SoapClient.GetBindingForEndpoint(endpointConfiguration), SendSMSV2SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SendSMSV2SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SendSMSV2SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SendSMSV2SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SendSMSV2SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SendSMSV2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BOS.SmsService.GetVersionResponse BOS.SmsService.SendSMSV2Soap.GetVersion(BOS.SmsService.GetVersionRequest request)
        {
            return base.Channel.GetVersion(request);
        }
        
        public BOS.SmsService.VersionResponse GetVersion()
        {
            BOS.SmsService.GetVersionRequest inValue = new BOS.SmsService.GetVersionRequest();
            inValue.Body = new BOS.SmsService.GetVersionRequestBody();
            BOS.SmsService.GetVersionResponse retVal = ((BOS.SmsService.SendSMSV2Soap)(this)).GetVersion(inValue);
            return retVal.Body.GetVersionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BOS.SmsService.GetVersionResponse> BOS.SmsService.SendSMSV2Soap.GetVersionAsync(BOS.SmsService.GetVersionRequest request)
        {
            return base.Channel.GetVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<BOS.SmsService.GetVersionResponse> GetVersionAsync()
        {
            BOS.SmsService.GetVersionRequest inValue = new BOS.SmsService.GetVersionRequest();
            inValue.Body = new BOS.SmsService.GetVersionRequestBody();
            return ((BOS.SmsService.SendSMSV2Soap)(this)).GetVersionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BOS.SmsService.QueueSmsMessageResponse BOS.SmsService.SendSMSV2Soap.QueueSmsMessage(BOS.SmsService.QueueSmsMessageRequest request)
        {
            return base.Channel.QueueSmsMessage(request);
        }
        
        public BOS.SmsService.SmsResult QueueSmsMessage(string messageBody, string phoneNumber, BOS.SmsService.SMSSenderTypes smsSender)
        {
            BOS.SmsService.QueueSmsMessageRequest inValue = new BOS.SmsService.QueueSmsMessageRequest();
            inValue.Body = new BOS.SmsService.QueueSmsMessageRequestBody();
            inValue.Body.messageBody = messageBody;
            inValue.Body.phoneNumber = phoneNumber;
            inValue.Body.smsSender = smsSender;
            BOS.SmsService.QueueSmsMessageResponse retVal = ((BOS.SmsService.SendSMSV2Soap)(this)).QueueSmsMessage(inValue);
            return retVal.Body.QueueSmsMessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageResponse> BOS.SmsService.SendSMSV2Soap.QueueSmsMessageAsync(BOS.SmsService.QueueSmsMessageRequest request)
        {
            return base.Channel.QueueSmsMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageResponse> QueueSmsMessageAsync(string messageBody, string phoneNumber, BOS.SmsService.SMSSenderTypes smsSender)
        {
            BOS.SmsService.QueueSmsMessageRequest inValue = new BOS.SmsService.QueueSmsMessageRequest();
            inValue.Body = new BOS.SmsService.QueueSmsMessageRequestBody();
            inValue.Body.messageBody = messageBody;
            inValue.Body.phoneNumber = phoneNumber;
            inValue.Body.smsSender = smsSender;
            return ((BOS.SmsService.SendSMSV2Soap)(this)).QueueSmsMessageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BOS.SmsService.QueueSmsMessageBirlesikodmResponse BOS.SmsService.SendSMSV2Soap.QueueSmsMessageBirlesikodm(BOS.SmsService.QueueSmsMessageBirlesikodmRequest request)
        {
            return base.Channel.QueueSmsMessageBirlesikodm(request);
        }
        
        public BOS.SmsService.SmsResult QueueSmsMessageBirlesikodm(string messageBody, string phoneNumber)
        {
            BOS.SmsService.QueueSmsMessageBirlesikodmRequest inValue = new BOS.SmsService.QueueSmsMessageBirlesikodmRequest();
            inValue.Body = new BOS.SmsService.QueueSmsMessageBirlesikodmRequestBody();
            inValue.Body.messageBody = messageBody;
            inValue.Body.phoneNumber = phoneNumber;
            BOS.SmsService.QueueSmsMessageBirlesikodmResponse retVal = ((BOS.SmsService.SendSMSV2Soap)(this)).QueueSmsMessageBirlesikodm(inValue);
            return retVal.Body.QueueSmsMessageBirlesikodmResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageBirlesikodmResponse> BOS.SmsService.SendSMSV2Soap.QueueSmsMessageBirlesikodmAsync(BOS.SmsService.QueueSmsMessageBirlesikodmRequest request)
        {
            return base.Channel.QueueSmsMessageBirlesikodmAsync(request);
        }
        
        public System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageBirlesikodmResponse> QueueSmsMessageBirlesikodmAsync(string messageBody, string phoneNumber)
        {
            BOS.SmsService.QueueSmsMessageBirlesikodmRequest inValue = new BOS.SmsService.QueueSmsMessageBirlesikodmRequest();
            inValue.Body = new BOS.SmsService.QueueSmsMessageBirlesikodmRequestBody();
            inValue.Body.messageBody = messageBody;
            inValue.Body.phoneNumber = phoneNumber;
            return ((BOS.SmsService.SendSMSV2Soap)(this)).QueueSmsMessageBirlesikodmAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponse BOS.SmsService.SendSMSV2Soap.QueueSmsMessageBirlesikodmInfo(BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest request)
        {
            return base.Channel.QueueSmsMessageBirlesikodmInfo(request);
        }
        
        public BOS.SmsService.SmsResult QueueSmsMessageBirlesikodmInfo(string messageBody, string phoneNumber)
        {
            BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest inValue = new BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest();
            inValue.Body = new BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequestBody();
            inValue.Body.messageBody = messageBody;
            inValue.Body.phoneNumber = phoneNumber;
            BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponse retVal = ((BOS.SmsService.SendSMSV2Soap)(this)).QueueSmsMessageBirlesikodmInfo(inValue);
            return retVal.Body.QueueSmsMessageBirlesikodmInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponse> BOS.SmsService.SendSMSV2Soap.QueueSmsMessageBirlesikodmInfoAsync(BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest request)
        {
            return base.Channel.QueueSmsMessageBirlesikodmInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<BOS.SmsService.QueueSmsMessageBirlesikodmInfoResponse> QueueSmsMessageBirlesikodmInfoAsync(string messageBody, string phoneNumber)
        {
            BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest inValue = new BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequest();
            inValue.Body = new BOS.SmsService.QueueSmsMessageBirlesikodmInfoRequestBody();
            inValue.Body.messageBody = messageBody;
            inValue.Body.phoneNumber = phoneNumber;
            return ((BOS.SmsService.SendSMSV2Soap)(this)).QueueSmsMessageBirlesikodmInfoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SendSMSV2Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.SendSMSV2Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SendSMSV2Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://test-notification-v2.birlesikodeme.com:58245/SendSMSV2.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.SendSMSV2Soap12))
            {
                return new System.ServiceModel.EndpointAddress("https://test-notification-v2.birlesikodeme.com:58245/SendSMSV2.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            SendSMSV2Soap,
            
            SendSMSV2Soap12,
        }
    }
}
