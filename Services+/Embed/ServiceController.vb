Imports System.Net
Imports ServicesPlus.BLL
Imports Unosquare.Labs.EmbedIO
Imports Unosquare.Labs.EmbedIO.Modules

Public Class ServiceController
    Inherits WebApiController

    <WebApiHandler(HttpVerbs.Get, "/api/service/*")>
    Public Async Function GetService(server As WebServer, context As HttpListenerContext) As Threading.Tasks.Task(Of Boolean)
        Dim serviceName As String = String.Empty
        If context.Request.Url.Segments.Count = 4 Then
            serviceName = context.Request.Url.Segments(3).Trim("/")
        End If
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."

        Await manager.GetServicesByMachineAsync()
        If String.IsNullOrEmpty(serviceName) Then
            Return context.JsonResponse(manager.Services.Where(Function(p) p.IsSystem = False).ToList) 'List of services
        Else
            Return context.JsonResponse(manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault)
        End If
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/system/*")>
    Public Async Function GetSystem(server As WebServer, context As HttpListenerContext) As Threading.Tasks.Task(Of Boolean)
        Dim objWmi As New Wmi(Nothing)
        Dim inf = Await objWmi.GetServerInfoAsync(".")
        Return context.JsonResponse(inf)
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/stop/{serviceName}")>
    Public Async Function [Stop](server As WebServer, context As HttpListenerContext, serviceName As String) As Threading.Tasks.Task(Of Boolean)
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."
        Await manager.GetServicesByMachineAsync()
        Dim service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Await manager.ControlServiceAsync(service, OM.WmiMethod.StopService)
        Await manager.GetServicesByMachineAsync() 'Again after action
        service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Return context.JsonResponse(service)
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/start/{serviceName}")>
    Public Async Function Start(server As WebServer, context As HttpListenerContext, serviceName As String) As Threading.Tasks.Task(Of Boolean)
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."
        Await manager.GetServicesByMachineAsync()
        Dim service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Await manager.ControlServiceAsync(service, OM.WmiMethod.StartService)
        Await manager.GetServicesByMachineAsync() 'Again after action
        service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Return context.JsonResponse(service)
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/pause/{serviceName}")>
    Public Async Function Pause(server As WebServer, context As HttpListenerContext, serviceName As String) As Threading.Tasks.Task(Of Boolean)
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."
        Await manager.GetServicesByMachineAsync()
        Dim service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Await manager.ControlServiceAsync(service, OM.WmiMethod.PauseService)
        Await manager.GetServicesByMachineAsync() 'Again after action
        service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Return context.JsonResponse(service)
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/resume/{serviceName}")>
    Public Async Function [Resume](server As WebServer, context As HttpListenerContext, serviceName As String) As Threading.Tasks.Task(Of Boolean)
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."
        Await manager.GetServicesByMachineAsync()
        Dim service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Await manager.ControlServiceAsync(service, OM.WmiMethod.ResumeService)
        Await manager.GetServicesByMachineAsync() 'Again after action
        service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Return context.JsonResponse(service)
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/dependson/{serviceName}")>
    Public Async Function DependsOn(server As WebServer, context As HttpListenerContext, serviceName As String) As Threading.Tasks.Task(Of Boolean)
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."
        Await manager.GetServicesByMachineAsync()
        Dim service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Dim dependsServices = Await service.DependsOnAsync(manager.Services, Nothing)
        Return context.JsonResponse(dependsServices)
    End Function

    <WebApiHandler(HttpVerbs.Get, "/api/dependsonthisservice/{serviceName}")>
    Public Async Function DependsOnThisService(server As WebServer, context As HttpListenerContext, serviceName As String) As Threading.Tasks.Task(Of Boolean)
        Dim manager As New BLL.ServiceManager()
        manager.MachineName = "."
        Await manager.GetServicesByMachineAsync()
        Dim service = manager.Services.Where(Function(p) p.ServiceName = serviceName).FirstOrDefault
        Dim dependsServices = Await service.DependOnThisServiceAsync(manager.Services, Nothing)
        Return context.JsonResponse(dependsServices)
    End Function
End Class
