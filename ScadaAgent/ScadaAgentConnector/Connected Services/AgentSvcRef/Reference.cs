﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scada.Agent.Connector.AgentSvcRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgentSvcRef.AgentSvc")]
    public interface AgentSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/CreateSession", ReplyAction="http://tempuri.org/AgentSvc/CreateSessionResponse")]
        Scada.Agent.Connector.AgentSvcRef.CreateSessionResponse CreateSession(Scada.Agent.Connector.AgentSvcRef.CreateSessionRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/CreateSession", ReplyAction="http://tempuri.org/AgentSvc/CreateSessionResponse")]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.CreateSessionResponse> CreateSessionAsync(Scada.Agent.Connector.AgentSvcRef.CreateSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Login", ReplyAction="http://tempuri.org/AgentSvc/LoginResponse")]
        Scada.Agent.Connector.AgentSvcRef.LoginResponse Login(Scada.Agent.Connector.AgentSvcRef.LoginRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Login", ReplyAction="http://tempuri.org/AgentSvc/LoginResponse")]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.LoginResponse> LoginAsync(Scada.Agent.Connector.AgentSvcRef.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/IsLoggedOn", ReplyAction="http://tempuri.org/AgentSvc/IsLoggedOnResponse")]
        bool IsLoggedOn(long sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/IsLoggedOn", ReplyAction="http://tempuri.org/AgentSvc/IsLoggedOnResponse")]
        System.Threading.Tasks.Task<bool> IsLoggedOnAsync(long sessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/ControlService", ReplyAction="http://tempuri.org/AgentSvc/ControlServiceResponse")]
        bool ControlService(long sessionID, Scada.Agent.ServiceApp serviceApp, Scada.Agent.ServiceCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/ControlService", ReplyAction="http://tempuri.org/AgentSvc/ControlServiceResponse")]
        System.Threading.Tasks.Task<bool> ControlServiceAsync(long sessionID, Scada.Agent.ServiceApp serviceApp, Scada.Agent.ServiceCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/GetServiceStatus", ReplyAction="http://tempuri.org/AgentSvc/GetServiceStatusResponse")]
        Scada.Agent.Connector.AgentSvcRef.GetServiceStatusResponse GetServiceStatus(Scada.Agent.Connector.AgentSvcRef.GetServiceStatusRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/GetServiceStatus", ReplyAction="http://tempuri.org/AgentSvc/GetServiceStatusResponse")]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.GetServiceStatusResponse> GetServiceStatusAsync(Scada.Agent.Connector.AgentSvcRef.GetServiceStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/GetAvailableConfig", ReplyAction="http://tempuri.org/AgentSvc/GetAvailableConfigResponse")]
        Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigResponse GetAvailableConfig(Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/GetAvailableConfig", ReplyAction="http://tempuri.org/AgentSvc/GetAvailableConfigResponse")]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigResponse> GetAvailableConfigAsync(Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/DownloadConfig", ReplyAction="http://tempuri.org/AgentSvc/DownloadConfigResponse")]
        System.IO.Stream DownloadConfig(long sessionID, Scada.Agent.ConfigOptions configOptions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/DownloadConfig", ReplyAction="http://tempuri.org/AgentSvc/DownloadConfigResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> DownloadConfigAsync(long sessionID, Scada.Agent.ConfigOptions configOptions);
        
        // CODEGEN: Generating message contract since the operation UploadConfig is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/UploadConfig", ReplyAction="http://tempuri.org/AgentSvc/UploadConfigResponse")]
        Scada.Agent.Connector.AgentSvcRef.UploadConfigResponse UploadConfig(Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/UploadConfig", ReplyAction="http://tempuri.org/AgentSvc/UploadConfigResponse")]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.UploadConfigResponse> UploadConfigAsync(Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/PackConfig", ReplyAction="http://tempuri.org/AgentSvc/PackConfigResponse")]
        bool PackConfig(long sessionID, string destFileName, Scada.Agent.ConfigOptions configOptions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/PackConfig", ReplyAction="http://tempuri.org/AgentSvc/PackConfigResponse")]
        System.Threading.Tasks.Task<bool> PackConfigAsync(long sessionID, string destFileName, Scada.Agent.ConfigOptions configOptions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/UnpackConfig", ReplyAction="http://tempuri.org/AgentSvc/UnpackConfigResponse")]
        bool UnpackConfig(long sessionID, string srcFileName, Scada.Agent.ConfigOptions configOptions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/UnpackConfig", ReplyAction="http://tempuri.org/AgentSvc/UnpackConfigResponse")]
        System.Threading.Tasks.Task<bool> UnpackConfigAsync(long sessionID, string srcFileName, Scada.Agent.ConfigOptions configOptions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Browse", ReplyAction="http://tempuri.org/AgentSvc/BrowseResponse")]
        Scada.Agent.Connector.AgentSvcRef.BrowseResponse Browse(Scada.Agent.Connector.AgentSvcRef.BrowseRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/Browse", ReplyAction="http://tempuri.org/AgentSvc/BrowseResponse")]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.BrowseResponse> BrowseAsync(Scada.Agent.Connector.AgentSvcRef.BrowseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/DownloadFile", ReplyAction="http://tempuri.org/AgentSvc/DownloadFileResponse")]
        System.IO.Stream DownloadFile(long sessionID, Scada.Agent.RelPath relPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/DownloadFile", ReplyAction="http://tempuri.org/AgentSvc/DownloadFileResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> DownloadFileAsync(long sessionID, Scada.Agent.RelPath relPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/DownloadFileRest", ReplyAction="http://tempuri.org/AgentSvc/DownloadFileRestResponse")]
        System.IO.Stream DownloadFileRest(long sessionID, Scada.Agent.RelPath relPath, long position);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgentSvc/DownloadFileRest", ReplyAction="http://tempuri.org/AgentSvc/DownloadFileRestResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> DownloadFileRestAsync(long sessionID, Scada.Agent.RelPath relPath, long position);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateSession", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateSessionRequest {
        
        public CreateSessionRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateSessionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateSessionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CreateSessionResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public long sessionID;
        
        public CreateSessionResponse() {
        }
        
        public CreateSessionResponse(bool CreateSessionResult, long sessionID) {
            this.CreateSessionResult = CreateSessionResult;
            this.sessionID = sessionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long sessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string encryptedPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string scadaInstanceName;
        
        public LoginRequest() {
        }
        
        public LoginRequest(long sessionID, string username, string encryptedPassword, string scadaInstanceName) {
            this.sessionID = sessionID;
            this.username = username;
            this.encryptedPassword = encryptedPassword;
            this.scadaInstanceName = scadaInstanceName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool LoginResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string errMsg;
        
        public LoginResponse() {
        }
        
        public LoginResponse(bool LoginResult, string errMsg) {
            this.LoginResult = LoginResult;
            this.errMsg = errMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServiceStatus", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetServiceStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long sessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Scada.Agent.ServiceApp serviceApp;
        
        public GetServiceStatusRequest() {
        }
        
        public GetServiceStatusRequest(long sessionID, Scada.Agent.ServiceApp serviceApp) {
            this.sessionID = sessionID;
            this.serviceApp = serviceApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServiceStatusResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetServiceStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool GetServiceStatusResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Scada.Agent.ServiceStatus status;
        
        public GetServiceStatusResponse() {
        }
        
        public GetServiceStatusResponse(bool GetServiceStatusResult, Scada.Agent.ServiceStatus status) {
            this.GetServiceStatusResult = GetServiceStatusResult;
            this.status = status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAvailableConfig", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAvailableConfigRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long sessionID;
        
        public GetAvailableConfigRequest() {
        }
        
        public GetAvailableConfigRequest(long sessionID) {
            this.sessionID = sessionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAvailableConfigResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAvailableConfigResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool GetAvailableConfigResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Scada.Agent.ConfigParts configParts;
        
        public GetAvailableConfigResponse() {
        }
        
        public GetAvailableConfigResponse(bool GetAvailableConfigResult, Scada.Agent.ConfigParts configParts) {
            this.GetAvailableConfigResult = GetAvailableConfigResult;
            this.configParts = configParts;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConfigUploadMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConfigUploadMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Scada.Agent.ConfigOptions ConfigOptions;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long SessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream Stream;
        
        public ConfigUploadMessage() {
        }
        
        public ConfigUploadMessage(Scada.Agent.ConfigOptions ConfigOptions, long SessionID, System.IO.Stream Stream) {
            this.ConfigOptions = ConfigOptions;
            this.SessionID = SessionID;
            this.Stream = Stream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadConfigResponse {
        
        public UploadConfigResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Browse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BrowseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long sessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Scada.Agent.RelPath relPath;
        
        public BrowseRequest() {
        }
        
        public BrowseRequest(long sessionID, Scada.Agent.RelPath relPath) {
            this.sessionID = sessionID;
            this.relPath = relPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BrowseResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BrowseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool BrowseResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] directories;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] files;
        
        public BrowseResponse() {
        }
        
        public BrowseResponse(bool BrowseResult, string[] directories, string[] files) {
            this.BrowseResult = BrowseResult;
            this.directories = directories;
            this.files = files;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AgentSvcChannel : Scada.Agent.Connector.AgentSvcRef.AgentSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgentSvcClient : System.ServiceModel.ClientBase<Scada.Agent.Connector.AgentSvcRef.AgentSvc>, Scada.Agent.Connector.AgentSvcRef.AgentSvc {
        
        public AgentSvcClient() {
        }
        
        public AgentSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgentSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Scada.Agent.Connector.AgentSvcRef.CreateSessionResponse Scada.Agent.Connector.AgentSvcRef.AgentSvc.CreateSession(Scada.Agent.Connector.AgentSvcRef.CreateSessionRequest request) {
            return base.Channel.CreateSession(request);
        }
        
        public bool CreateSession(out long sessionID) {
            Scada.Agent.Connector.AgentSvcRef.CreateSessionRequest inValue = new Scada.Agent.Connector.AgentSvcRef.CreateSessionRequest();
            Scada.Agent.Connector.AgentSvcRef.CreateSessionResponse retVal = ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).CreateSession(inValue);
            sessionID = retVal.sessionID;
            return retVal.CreateSessionResult;
        }
        
        public System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.CreateSessionResponse> CreateSessionAsync(Scada.Agent.Connector.AgentSvcRef.CreateSessionRequest request) {
            return base.Channel.CreateSessionAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Scada.Agent.Connector.AgentSvcRef.LoginResponse Scada.Agent.Connector.AgentSvcRef.AgentSvc.Login(Scada.Agent.Connector.AgentSvcRef.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public bool Login(long sessionID, string username, string encryptedPassword, string scadaInstanceName, out string errMsg) {
            Scada.Agent.Connector.AgentSvcRef.LoginRequest inValue = new Scada.Agent.Connector.AgentSvcRef.LoginRequest();
            inValue.sessionID = sessionID;
            inValue.username = username;
            inValue.encryptedPassword = encryptedPassword;
            inValue.scadaInstanceName = scadaInstanceName;
            Scada.Agent.Connector.AgentSvcRef.LoginResponse retVal = ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).Login(inValue);
            errMsg = retVal.errMsg;
            return retVal.LoginResult;
        }
        
        public System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.LoginResponse> LoginAsync(Scada.Agent.Connector.AgentSvcRef.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public bool IsLoggedOn(long sessionID) {
            return base.Channel.IsLoggedOn(sessionID);
        }
        
        public System.Threading.Tasks.Task<bool> IsLoggedOnAsync(long sessionID) {
            return base.Channel.IsLoggedOnAsync(sessionID);
        }
        
        public bool ControlService(long sessionID, Scada.Agent.ServiceApp serviceApp, Scada.Agent.ServiceCommand command) {
            return base.Channel.ControlService(sessionID, serviceApp, command);
        }
        
        public System.Threading.Tasks.Task<bool> ControlServiceAsync(long sessionID, Scada.Agent.ServiceApp serviceApp, Scada.Agent.ServiceCommand command) {
            return base.Channel.ControlServiceAsync(sessionID, serviceApp, command);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Scada.Agent.Connector.AgentSvcRef.GetServiceStatusResponse Scada.Agent.Connector.AgentSvcRef.AgentSvc.GetServiceStatus(Scada.Agent.Connector.AgentSvcRef.GetServiceStatusRequest request) {
            return base.Channel.GetServiceStatus(request);
        }
        
        public bool GetServiceStatus(long sessionID, Scada.Agent.ServiceApp serviceApp, out Scada.Agent.ServiceStatus status) {
            Scada.Agent.Connector.AgentSvcRef.GetServiceStatusRequest inValue = new Scada.Agent.Connector.AgentSvcRef.GetServiceStatusRequest();
            inValue.sessionID = sessionID;
            inValue.serviceApp = serviceApp;
            Scada.Agent.Connector.AgentSvcRef.GetServiceStatusResponse retVal = ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).GetServiceStatus(inValue);
            status = retVal.status;
            return retVal.GetServiceStatusResult;
        }
        
        public System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.GetServiceStatusResponse> GetServiceStatusAsync(Scada.Agent.Connector.AgentSvcRef.GetServiceStatusRequest request) {
            return base.Channel.GetServiceStatusAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigResponse Scada.Agent.Connector.AgentSvcRef.AgentSvc.GetAvailableConfig(Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigRequest request) {
            return base.Channel.GetAvailableConfig(request);
        }
        
        public bool GetAvailableConfig(long sessionID, out Scada.Agent.ConfigParts configParts) {
            Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigRequest inValue = new Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigRequest();
            inValue.sessionID = sessionID;
            Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigResponse retVal = ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).GetAvailableConfig(inValue);
            configParts = retVal.configParts;
            return retVal.GetAvailableConfigResult;
        }
        
        public System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigResponse> GetAvailableConfigAsync(Scada.Agent.Connector.AgentSvcRef.GetAvailableConfigRequest request) {
            return base.Channel.GetAvailableConfigAsync(request);
        }
        
        public System.IO.Stream DownloadConfig(long sessionID, Scada.Agent.ConfigOptions configOptions) {
            return base.Channel.DownloadConfig(sessionID, configOptions);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> DownloadConfigAsync(long sessionID, Scada.Agent.ConfigOptions configOptions) {
            return base.Channel.DownloadConfigAsync(sessionID, configOptions);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Scada.Agent.Connector.AgentSvcRef.UploadConfigResponse Scada.Agent.Connector.AgentSvcRef.AgentSvc.UploadConfig(Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage request) {
            return base.Channel.UploadConfig(request);
        }
        
        public void UploadConfig(Scada.Agent.ConfigOptions ConfigOptions, long SessionID, System.IO.Stream Stream) {
            Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage inValue = new Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage();
            inValue.ConfigOptions = ConfigOptions;
            inValue.SessionID = SessionID;
            inValue.Stream = Stream;
            Scada.Agent.Connector.AgentSvcRef.UploadConfigResponse retVal = ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).UploadConfig(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.UploadConfigResponse> Scada.Agent.Connector.AgentSvcRef.AgentSvc.UploadConfigAsync(Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage request) {
            return base.Channel.UploadConfigAsync(request);
        }
        
        public System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.UploadConfigResponse> UploadConfigAsync(Scada.Agent.ConfigOptions ConfigOptions, long SessionID, System.IO.Stream Stream) {
            Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage inValue = new Scada.Agent.Connector.AgentSvcRef.ConfigUploadMessage();
            inValue.ConfigOptions = ConfigOptions;
            inValue.SessionID = SessionID;
            inValue.Stream = Stream;
            return ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).UploadConfigAsync(inValue);
        }
        
        public bool PackConfig(long sessionID, string destFileName, Scada.Agent.ConfigOptions configOptions) {
            return base.Channel.PackConfig(sessionID, destFileName, configOptions);
        }
        
        public System.Threading.Tasks.Task<bool> PackConfigAsync(long sessionID, string destFileName, Scada.Agent.ConfigOptions configOptions) {
            return base.Channel.PackConfigAsync(sessionID, destFileName, configOptions);
        }
        
        public bool UnpackConfig(long sessionID, string srcFileName, Scada.Agent.ConfigOptions configOptions) {
            return base.Channel.UnpackConfig(sessionID, srcFileName, configOptions);
        }
        
        public System.Threading.Tasks.Task<bool> UnpackConfigAsync(long sessionID, string srcFileName, Scada.Agent.ConfigOptions configOptions) {
            return base.Channel.UnpackConfigAsync(sessionID, srcFileName, configOptions);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Scada.Agent.Connector.AgentSvcRef.BrowseResponse Scada.Agent.Connector.AgentSvcRef.AgentSvc.Browse(Scada.Agent.Connector.AgentSvcRef.BrowseRequest request) {
            return base.Channel.Browse(request);
        }
        
        public bool Browse(long sessionID, Scada.Agent.RelPath relPath, out string[] directories, out string[] files) {
            Scada.Agent.Connector.AgentSvcRef.BrowseRequest inValue = new Scada.Agent.Connector.AgentSvcRef.BrowseRequest();
            inValue.sessionID = sessionID;
            inValue.relPath = relPath;
            Scada.Agent.Connector.AgentSvcRef.BrowseResponse retVal = ((Scada.Agent.Connector.AgentSvcRef.AgentSvc)(this)).Browse(inValue);
            directories = retVal.directories;
            files = retVal.files;
            return retVal.BrowseResult;
        }
        
        public System.Threading.Tasks.Task<Scada.Agent.Connector.AgentSvcRef.BrowseResponse> BrowseAsync(Scada.Agent.Connector.AgentSvcRef.BrowseRequest request) {
            return base.Channel.BrowseAsync(request);
        }
        
        public System.IO.Stream DownloadFile(long sessionID, Scada.Agent.RelPath relPath) {
            return base.Channel.DownloadFile(sessionID, relPath);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> DownloadFileAsync(long sessionID, Scada.Agent.RelPath relPath) {
            return base.Channel.DownloadFileAsync(sessionID, relPath);
        }
        
        public System.IO.Stream DownloadFileRest(long sessionID, Scada.Agent.RelPath relPath, long position) {
            return base.Channel.DownloadFileRest(sessionID, relPath, position);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> DownloadFileRestAsync(long sessionID, Scada.Agent.RelPath relPath, long position) {
            return base.Channel.DownloadFileRestAsync(sessionID, relPath, position);
        }
    }
}
