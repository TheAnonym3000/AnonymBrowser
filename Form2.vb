Public Class Form2
    Private Sub Start(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.SE = "Google" Then
            RadioButton2.Checked = True
        ElseIf My.Settings.SE = "Bing" Then
            RadioButton3.Checked = True
        ElseIf My.Settings.SE = "DuckDuckGo" Then
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Button1_Click() Handles Button1.Click
        If RadioButton2.Checked = True Then
            My.Settings.SE = "Google"
        ElseIf RadioButton1.Checked = True Then
            My.Settings.SE = "DuckDuckGo"
        ElseIf RadioButton3.Checked = True Then
            My.Settings.SE = "Bing"
        End If
    End Sub
    Private Sub Button1_Click2() Handles Button1.Click
        My.Settings.Save()
        My.Settings.Reload()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class