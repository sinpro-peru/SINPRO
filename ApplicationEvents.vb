Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            Frm_Principal.NotifyIcon1.Visible = False
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            e.ExitApplication = False

            Try

                If Frm_Principal.conex.State = ConnectionState.Closed Or Frm_Principal.conex.State = ConnectionState.Broken Then

                    Frm_Principal.conex.Open()

                Else

                    MsgBox("El sistema encontró un error inesperado y se cerrará luego de esta advertencia!", MsgBoxStyle.Critical, "Error")
                    MsgBox("Descripción del error: '" & e.Exception.ToString & "'")
                    Frm_Principal.NotifyIcon1.Visible = False
                    Process.Start("Tesis Nueva.exe")
                    End


                End If

            Catch ex As Exception

                MsgBox("El sistema encontró un error inesperado y se cerrará luego de esta advertencia!", MsgBoxStyle.Critical, "Error")
                MsgBox("Descripción del error: '" & e.Exception.ToString & "'")
                Frm_Principal.NotifyIcon1.Visible = False
                Process.Start("Tesis Nueva.exe")
                End

            End Try

        End Sub
    End Class

End Namespace

