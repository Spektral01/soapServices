﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientSOAP.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISoapService")]
    public interface ISoapService {
        
        // CODEGEN: Контракт генерации сообщений с именем str из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/MaxChar", ReplyAction="*")]
        ClientSOAP.ServiceReference1.MaxCharResponse MaxChar(ClientSOAP.ServiceReference1.MaxCharRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/MaxChar", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientSOAP.ServiceReference1.MaxCharResponse> MaxCharAsync(ClientSOAP.ServiceReference1.MaxCharRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MaxCharRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MaxChar", Namespace="http://tempuri.org/", Order=0)]
        public ClientSOAP.ServiceReference1.MaxCharRequestBody Body;
        
        public MaxCharRequest() {
        }
        
        public MaxCharRequest(ClientSOAP.ServiceReference1.MaxCharRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MaxCharRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string str;
        
        public MaxCharRequestBody() {
        }
        
        public MaxCharRequestBody(string str) {
            this.str = str;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MaxCharResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MaxCharResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientSOAP.ServiceReference1.MaxCharResponseBody Body;
        
        public MaxCharResponse() {
        }
        
        public MaxCharResponse(ClientSOAP.ServiceReference1.MaxCharResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MaxCharResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MaxCharResult;
        
        public MaxCharResponseBody() {
        }
        
        public MaxCharResponseBody(string MaxCharResult) {
            this.MaxCharResult = MaxCharResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISoapServiceChannel : ClientSOAP.ServiceReference1.ISoapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SoapServiceClient : System.ServiceModel.ClientBase<ClientSOAP.ServiceReference1.ISoapService>, ClientSOAP.ServiceReference1.ISoapService {
        
        public SoapServiceClient() {
        }
        
        public SoapServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SoapServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoapServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientSOAP.ServiceReference1.MaxCharResponse ClientSOAP.ServiceReference1.ISoapService.MaxChar(ClientSOAP.ServiceReference1.MaxCharRequest request) {
            return base.Channel.MaxChar(request);
        }
        
        public string MaxChar(string str) {
            ClientSOAP.ServiceReference1.MaxCharRequest inValue = new ClientSOAP.ServiceReference1.MaxCharRequest();
            inValue.Body = new ClientSOAP.ServiceReference1.MaxCharRequestBody();
            inValue.Body.str = str;
            ClientSOAP.ServiceReference1.MaxCharResponse retVal = ((ClientSOAP.ServiceReference1.ISoapService)(this)).MaxChar(inValue);
            return retVal.Body.MaxCharResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientSOAP.ServiceReference1.MaxCharResponse> ClientSOAP.ServiceReference1.ISoapService.MaxCharAsync(ClientSOAP.ServiceReference1.MaxCharRequest request) {
            return base.Channel.MaxCharAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientSOAP.ServiceReference1.MaxCharResponse> MaxCharAsync(string str) {
            ClientSOAP.ServiceReference1.MaxCharRequest inValue = new ClientSOAP.ServiceReference1.MaxCharRequest();
            inValue.Body = new ClientSOAP.ServiceReference1.MaxCharRequestBody();
            inValue.Body.str = str;
            return ((ClientSOAP.ServiceReference1.ISoapService)(this)).MaxCharAsync(inValue);
        }
    }
}
