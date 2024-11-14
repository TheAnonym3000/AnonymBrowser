Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub checkAdress() Handles WebView.NavigationCompleted
        txbAdress.Text = WebView.Source.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebView.CanGoBack Then
            WebView.GoBack()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If WebView.CanGoForward Then
            WebView.GoForward()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebView.Refresh()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebView.CoreWebView2.Navigate(txbAdress.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.SE = "DuckDuckGo" Then
            WebView.CoreWebView2.Navigate(My.Settings.DuckDuckGo + txbSearch.Text)
        ElseIf My.Settings.SE = "Google" Then
            WebView.CoreWebView2.Navigate(My.Settings.Google + txbSearch.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebView.CoreWebView2.Navigate(My.Settings.Bing + txbSearch.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
