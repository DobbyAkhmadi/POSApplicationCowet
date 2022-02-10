Public Class F_SplashScreen
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub F_SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim frm As New F_Makanan
        'frm.TopLevel = False
        'frm.Parent = Me.splitContainerControl.Panel2

        'frm.Show()
    End Sub
End Class
