﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zephyr.Areas.QmsIQCService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://impl.webservice.spc.com", ConfigurationName="QmsIQCService.setIQCInspectRequestPortType")]
    public interface setIQCInspectRequestPortType {
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="urn:setOQCInspectRequest", ReplyAction="urn:setOQCInspectRequestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Zephyr.Areas.QmsIQCService.setOQCInspectRequestResponse setOQCInspectRequest(Zephyr.Areas.QmsIQCService.setOQCInspectRequestRequest request);
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="urn:setIQCInspectRequest", ReplyAction="urn:setIQCInspectRequestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Zephyr.Areas.QmsIQCService.setIQCInspectRequestResponse setIQCInspectRequest(Zephyr.Areas.QmsIQCService.setIQCInspectRequestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setOQCInspectRequest", WrapperNamespace="http://impl.webservice.spc.com", IsWrapped=true)]
    public partial class setOQCInspectRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://impl.webservice.spc.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string oqcJSON;
        
        public setOQCInspectRequestRequest() {
        }
        
        public setOQCInspectRequestRequest(string oqcJSON) {
            this.oqcJSON = oqcJSON;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setOQCInspectRequestResponse", WrapperNamespace="http://impl.webservice.spc.com", IsWrapped=true)]
    public partial class setOQCInspectRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://impl.webservice.spc.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public setOQCInspectRequestResponse() {
        }
        
        public setOQCInspectRequestResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setIQCInspectRequest", WrapperNamespace="http://impl.webservice.spc.com", IsWrapped=true)]
    public partial class setIQCInspectRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://impl.webservice.spc.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string iqcJSON;
        
        public setIQCInspectRequestRequest() {
        }
        
        public setIQCInspectRequestRequest(string iqcJSON) {
            this.iqcJSON = iqcJSON;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setIQCInspectRequestResponse", WrapperNamespace="http://impl.webservice.spc.com", IsWrapped=true)]
    public partial class setIQCInspectRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://impl.webservice.spc.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public setIQCInspectRequestResponse() {
        }
        
        public setIQCInspectRequestResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface setIQCInspectRequestPortTypeChannel : Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class setIQCInspectRequestPortTypeClient : System.ServiceModel.ClientBase<Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType>, Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType {
        
        public setIQCInspectRequestPortTypeClient() {
        }
        
        public setIQCInspectRequestPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public setIQCInspectRequestPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public setIQCInspectRequestPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public setIQCInspectRequestPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Zephyr.Areas.QmsIQCService.setOQCInspectRequestResponse Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType.setOQCInspectRequest(Zephyr.Areas.QmsIQCService.setOQCInspectRequestRequest request) {
            return base.Channel.setOQCInspectRequest(request);
        }
        
        public string setOQCInspectRequest(string oqcJSON) {
            Zephyr.Areas.QmsIQCService.setOQCInspectRequestRequest inValue = new Zephyr.Areas.QmsIQCService.setOQCInspectRequestRequest();
            inValue.oqcJSON = oqcJSON;
            Zephyr.Areas.QmsIQCService.setOQCInspectRequestResponse retVal = ((Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType)(this)).setOQCInspectRequest(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Zephyr.Areas.QmsIQCService.setIQCInspectRequestResponse Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType.setIQCInspectRequest(Zephyr.Areas.QmsIQCService.setIQCInspectRequestRequest request) {
            return base.Channel.setIQCInspectRequest(request);
        }
        
        public string setIQCInspectRequest(string iqcJSON) {
            Zephyr.Areas.QmsIQCService.setIQCInspectRequestRequest inValue = new Zephyr.Areas.QmsIQCService.setIQCInspectRequestRequest();
            inValue.iqcJSON = iqcJSON;
            Zephyr.Areas.QmsIQCService.setIQCInspectRequestResponse retVal = ((Zephyr.Areas.QmsIQCService.setIQCInspectRequestPortType)(this)).setIQCInspectRequest(inValue);
            return retVal.@return;
        }
    }
}
