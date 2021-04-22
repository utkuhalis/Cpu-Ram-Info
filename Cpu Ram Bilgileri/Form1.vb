Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim cpu As Integer = 0
        Dim ram As Integer = 0

        cpu = cpuinfo.NextValue
        ram = raminfo.NextValue

        Label1.Text = "İşlemci " & cpu & "%"
        Label2.Text = "Memory " & ram & "%"

        ProgressBar1.Value = cpu
        ProgressBar2.Value = ram
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
