Imports System.ComponentModel
Imports System.Configuration.Install

Public Class Installer1

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregue el código de inicialización después de llamar a InitializeComponent

    End Sub

    <Security.Permissions.SecurityPermission(Security.Permissions.SecurityAction.Demand)> _
    Public Overrides Sub Install(ByVal stateSaver As System.Collections.IDictionary)
        MyBase.Install(stateSaver)
    End Sub

    <Security.Permissions.SecurityPermission(Security.Permissions.SecurityAction.Demand)> _
    Public Overrides Sub Commit(ByVal savedState As System.Collections.IDictionary)
        MyBase.Commit(savedState)
    End Sub

    <Security.Permissions.SecurityPermission(Security.Permissions.SecurityAction.Demand)> _
    Public Overrides Sub Rollback(ByVal savedState As System.Collections.IDictionary)
        MyBase.Rollback(savedState)
    End Sub

    <Security.Permissions.SecurityPermission(Security.Permissions.SecurityAction.Demand)> _
    Public Overrides Sub Uninstall(ByVal savedState As System.Collections.IDictionary)
        MyBase.Uninstall(savedState)
    End Sub

End Class
