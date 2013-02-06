//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Employee
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class Employee :
        global::System.ServiceModel.DomainServices.Client.Entity,
        global::LightSwitchApplication.Employee.DetailsClass.IImplementation
    {
        public override object GetIdentity()
        {
            if (this.__host != null && this.__host.IsNewlyAdded)
            {
                return null;
            }
    
            return this._Id;
        }
        [global::System.ComponentModel.DataAnnotations.Key()]
        [global::System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.ValidateProperty("Id", value);
                    this._Id = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        private int _Id;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (this._Name != value)
                {
                    this.RaiseDataMemberChanging("Name");
                    this.ValidateProperty("Name", value);
                    this._Name = value;
                    this.RaiseDataMemberChanged("Name");
                }
            }
        }
        private string _Name;
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(e.PropertyName);
            }
        }
        #endregion
    }
    #endregion
    
    #region ApplicationData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationData
        : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext
    {
        public ApplicationData(global::Microsoft.LightSwitch.IDataService dataService)
            : base(dataService, global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext.CreateWcfDomainClient<IApplicationDataContract>(new global::System.Uri("LightSwitchApplication-Implementation-ApplicationDataDomainService.svc", global::System.UriKind.Relative)))
        {
        }
    
        public global::System.ServiceModel.DomainServices.Client.EntitySet<global::LightSwitchApplication.Implementation.Employee> EmployeeEntityList
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::LightSwitchApplication.Implementation.Employee>();
            }
        }
        protected override global::System.ServiceModel.DomainServices.Client.EntityContainer CreateEntityContainer()
        {
            return new ApplicationDataEntityContainer();
        }
    
        internal sealed class ApplicationDataEntityContainer : global::System.ServiceModel.DomainServices.Client.EntityContainer
        {
            public ApplicationDataEntityContainer()
            {
                this.CreateEntitySet<global::LightSwitchApplication.Implementation.Employee>(global::System.ServiceModel.DomainServices.Client.EntitySetOperations.All);
            }
        }
    
        #region Service Contract Interface
    
        [global::System.ServiceModel.ServiceContract]
        public interface IApplicationDataContract
        {
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/Employees_Single", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/Employees_SingleResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/Employees_SingleDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginEmployees_Single(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Employee> EndEmployees_Single(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/Employees_SingleOrDefault", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/Employees_SingleOrDefaultResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/Employees_SingleOrDefaultDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginEmployees_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Employee> EndEmployees_SingleOrDefault(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/Employees_All", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/Employees_AllResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/Employees_AllDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginEmployees_All(string frameworkOperators, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Employee> EndEmployees_All(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/SubmitChanges", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/SubmitChangesResponse"),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/SubmitChangesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginSubmitChanges(global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> changeSet, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> EndSubmitChanges(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/__GetEntitySetCanInformation", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/__GetEntitySetCanInformationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/__GetEntitySetCanInformationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__GetEntitySetCanInformation(string entitySetName, global::System.AsyncCallback callback, global::System.Object asyncState);
            int End__GetEntitySetCanInformation(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/__CanExecuteOperation", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/__CanExecuteOperationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/__CanExecuteOperationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__CanExecuteOperation(string operationName, global::System.AsyncCallback callback, global::System.Object asyncState);
            bool End__CanExecuteOperation(global::System.IAsyncResult result);
            
        }
    
        #endregion
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Employee))
            {
                return new global::LightSwitchApplication.Implementation.Employee();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationData(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Employee) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Employee);
            }
            return null;
        }
    }
}
