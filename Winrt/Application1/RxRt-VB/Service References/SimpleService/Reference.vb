﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17379
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 11.0.50214.1
'
Namespace SimpleService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="SimpleService.ISimpleServicesvc")>  _
    Public Interface ISimpleServicesvc
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISimpleServicesvc/DoSomethingCool", ReplyAction:="http://tempuri.org/ISimpleServicesvc/DoSomethingCoolResponse")>  _
        Function DoSomethingCoolAsync(ByVal input As String) As System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ISimpleServicesvcChannel
        Inherits SimpleService.ISimpleServicesvc, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SimpleServicesvcClient
        Inherits System.ServiceModel.ClientBase(Of SimpleService.ISimpleServicesvc)
        Implements SimpleService.ISimpleServicesvc
        
        ''' <summary>
        ''' Implement this partial method to configure the service endpoint.
        ''' </summary>
        ''' <param name="serviceEndpoint">The endpoint to configure</param>
        ''' <param name="clientCredentials">The client credentials</param>
        Partial Private Shared Sub ConfigureEndpoint(ByVal serviceEndpoint As System.ServiceModel.Description.ServiceEndpoint, ByVal clientCredentials As System.ServiceModel.Description.ClientCredentials)
        End Sub
        
        Public Sub New()
            MyBase.New(SimpleServicesvcClient.GetDefaultBinding, SimpleServicesvcClient.GetDefaultEndpointAddress)
            Me.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISimpleServicesvc.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal endpointConfiguration As EndpointConfiguration)
            MyBase.New(SimpleServicesvcClient.GetBindingForEndpoint(endpointConfiguration), SimpleServicesvcClient.GetEndpointAddress(endpointConfiguration))
            Me.Endpoint.Name = endpointConfiguration.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal endpointConfiguration As EndpointConfiguration, ByVal remoteAddress As String)
            MyBase.New(SimpleServicesvcClient.GetBindingForEndpoint(endpointConfiguration), New System.ServiceModel.EndpointAddress(remoteAddress))
            Me.Endpoint.Name = endpointConfiguration.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal endpointConfiguration As EndpointConfiguration, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(SimpleServicesvcClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
            Me.Endpoint.Name = endpointConfiguration.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function DoSomethingCoolAsync(ByVal input As String) As System.Threading.Tasks.Task(Of String) Implements SimpleService.ISimpleServicesvc.DoSomethingCoolAsync
            Return MyBase.Channel.DoSomethingCoolAsync(input)
        End Function
        
        Public Overridable Function OpenAsync() As System.Threading.Tasks.Task
            Return System.Threading.Tasks.Task.Factory.FromAsync(CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(Nothing, Nothing), AddressOf CType(Me,System.ServiceModel.ICommunicationObject).EndOpen)
        End Function
        
        Public Overridable Function CloseAsync() As System.Threading.Tasks.Task
            Return System.Threading.Tasks.Task.Factory.FromAsync(CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(Nothing, Nothing), AddressOf CType(Me,System.ServiceModel.ICommunicationObject).EndClose)
        End Function
        
        Private Shared Function GetBindingForEndpoint(ByVal endpointConfiguration As EndpointConfiguration) As System.ServiceModel.Channels.Binding
            If (endpointConfiguration = EndpointConfiguration.BasicHttpBinding_ISimpleServicesvc) Then
                Dim result As System.ServiceModel.BasicHttpBinding = New System.ServiceModel.BasicHttpBinding()
                result.MaxBufferSize = Integer.MaxValue
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max
                result.MaxReceivedMessageSize = Integer.MaxValue
                result.AllowCookies = true
                Return result
            End If
            Throw New System.InvalidOperationException(String.Format("Could not find endpoint with name '{0}'.", endpointConfiguration))
        End Function
        
        Private Shared Function GetEndpointAddress(ByVal endpointConfiguration As EndpointConfiguration) As System.ServiceModel.EndpointAddress
            If (endpointConfiguration = EndpointConfiguration.BasicHttpBinding_ISimpleServicesvc) Then
                Return New System.ServiceModel.EndpointAddress("http://localhost:58836/SimpleServicesvc.svc")
            End If
            Throw New System.InvalidOperationException(String.Format("Could not find endpoint with name '{0}'.", endpointConfiguration))
        End Function
        
        Private Shared Function GetDefaultBinding() As System.ServiceModel.Channels.Binding
            Return SimpleServicesvcClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISimpleServicesvc)
        End Function
        
        Private Shared Function GetDefaultEndpointAddress() As System.ServiceModel.EndpointAddress
            Return SimpleServicesvcClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISimpleServicesvc)
        End Function
        
        Public Enum EndpointConfiguration
            
            BasicHttpBinding_ISimpleServicesvc
        End Enum
    End Class
End Namespace
