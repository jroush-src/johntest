//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class EmployeesGrid
        : global::Microsoft.LightSwitch.Framework.Client.ScreenObject<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass>
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private EmployeesGrid() : base("LightSwitchApplication:EmployeesGrid")
        {
            global::LightSwitchApplication.EmployeesGrid.DetailsClass.Initialize(this);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static EmployeesGrid CreateInstance()
        {
            return new global::LightSwitchApplication.EmployeesGrid(
            );
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_Activated();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_Saving(ref bool handled);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_Saved();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_Closing(ref bool cancel);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EmployeesGrid_SaveError(global::System.Exception exception, ref bool handled);
     
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)((global::Microsoft.LightSwitch.Details.Client.IScreenDetails)this.Details).DataWorkspace;
            }
        }
        
        #endregion
 
        partial void Employees_SelectionChanged();

        partial void Employees_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e);

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Employees_Loaded(bool succeeded);

        /// <summary>
        /// Gets the Employees visual collection. The collection contains all records currently shown on the respective list or grid control.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.Client.VisualCollection<global::LightSwitchApplication.Employee> Employees
        {
            get
            {
                return global::LightSwitchApplication.EmployeesGrid.DetailsClass.GetValue(this, global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties.Employees);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Employees_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySet, global::LightSwitchApplication.EmployeesGrid.DetailsClass.CommandSet, global::LightSwitchApplication.EmployeesGrid.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializePropertyEntry = global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties.Employees;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass>.Entry
                __EmployeesGridEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass>.Entry(
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeInitializeDataWorkspace,
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeSavingEvent,
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeSavedEvent,
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeClosingEvent,
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeCreated,
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeActivated,
                    global::LightSwitchApplication.EmployeesGrid.DetailsClass.__EmployeesGrid_InvokeSaveErrorEvent);
            private static void __EmployeesGrid_InvokeInitializeDataWorkspace(global::LightSwitchApplication.EmployeesGrid s, global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
            {
                s.EmployeesGrid_InitializeDataWorkspace(saveChangesTo);
            }
            private static bool __EmployeesGrid_InvokeSavingEvent(global::LightSwitchApplication.EmployeesGrid s)
            {
                bool handled = false;
                s.EmployeesGrid_Saving(ref handled);
                return handled;
            }
            private static void __EmployeesGrid_InvokeSavedEvent(global::LightSwitchApplication.EmployeesGrid s)
            {
                s.EmployeesGrid_Saved();
            }
            private static bool __EmployeesGrid_InvokeClosingEvent(global::LightSwitchApplication.EmployeesGrid s)
            {
                bool cancel = false;
                s.EmployeesGrid_Closing(ref cancel);
                return cancel;
            }
            private static void __EmployeesGrid_InvokeCreated(global::LightSwitchApplication.EmployeesGrid s)
            {
                s.EmployeesGrid_Created();
            }
            private static void __EmployeesGrid_InvokeActivated(global::LightSwitchApplication.EmployeesGrid s)
            {
                s.EmployeesGrid_Activated();
            }
            private static bool __EmployeesGrid_InvokeSaveErrorEvent(global::LightSwitchApplication.EmployeesGrid s, global::System.Exception ex)
            {
                bool handled = false;
                s.EmployeesGrid_SaveError(ex, ref handled);
                return handled;
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.EmployeesGrid.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.EmployeesGrid.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            private global::Microsoft.LightSwitch.IDataServiceQueryable EmployeesQuery()
            {
                return this.Screen.DataWorkspace.ApplicationData.Employees;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.Employee>.Data _Employees;

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenPropertySet<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.Employee> Employees
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.Employee>)base.GetItem(global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties.Employees);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCommandSet<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenMethodSet<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.Employee>.Entry
                    Employees = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.Employee>.Entry(
                        "Employees",
                        global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties._Employees_Stub,
                        global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties._Employees_Validate,
                        global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties._Employees_CreateQuery,
                        global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties._Employees_SelectionChanged,
                        global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties._Employees_OnCollectionChanged,
                        global::LightSwitchApplication.EmployeesGrid.DetailsClass.PropertySetProperties._Employees_OnLoaded);
                private static void _Employees_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCollectionProperty<global::LightSwitchApplication.EmployeesGrid, global::LightSwitchApplication.EmployeesGrid.DetailsClass, global::LightSwitchApplication.Employee>.Data> c, global::LightSwitchApplication.EmployeesGrid.DetailsClass d, object sf)
                {
                    c(d, ref d._Employees, sf);
                }
                private static void _Employees_Validate(global::LightSwitchApplication.EmployeesGrid s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.Employees_Validate(r);
                }
                private static global::Microsoft.LightSwitch.IDataServiceQueryable _Employees_CreateQuery(global::LightSwitchApplication.EmployeesGrid.DetailsClass d, object[] args)
                {
                    return d.EmployeesQuery();
                }
                private static void _Employees_SelectionChanged(global::LightSwitchApplication.EmployeesGrid s)
                {
                    s.Employees_SelectionChanged();
                }
                private static void _Employees_OnCollectionChanged(global::LightSwitchApplication.EmployeesGrid s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    s.Employees_Changed(e);
                }
                private static void _Employees_OnLoaded(global::LightSwitchApplication.EmployeesGrid s, bool succeeded)
                {
                    s.Employees_Loaded(succeeded);
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {
            }
        }
    }
}
