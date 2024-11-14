<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        WebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        txbAdress = New TextBox()
        Button6 = New Button()
        txbSearch = New TextBox()
        CType(WebView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WebView
        ' 
        WebView.AllowExternalDrop = True
        WebView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        WebView.BackColor = Color.White
        WebView.CreationProperties = Nothing
        WebView.DefaultBackgroundColor = Color.White
        WebView.Location = New Point(-1, 34)
        WebView.Name = "WebView"
        WebView.Size = New Size(985, 532)
        WebView.Source = New Uri("https://anonymtendo.wordpress.com", UriKind.Absolute)
        WebView.TabIndex = 0
        WebView.ZoomFactor = 1R
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(933, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(39, 23)
        Button1.TabIndex = 2
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Location = New Point(888, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(39, 23)
        Button2.TabIndex = 3
        Button2.Text = "Go"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(39, 23)
        Button3.TabIndex = 4
        Button3.Text = "<"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(57, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(39, 23)
        Button4.TabIndex = 5
        Button4.Text = ">"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(102, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(39, 23)
        Button5.TabIndex = 6
        Button5.Text = "R"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txbAdress
        ' 
        txbAdress.Location = New Point(147, 4)
        txbAdress.Name = "txbAdress"
        txbAdress.PlaceholderText = "URL"
        txbAdress.Size = New Size(283, 23)
        txbAdress.TabIndex = 7
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(436, 5)
        Button6.Name = "Button6"
        Button6.Size = New Size(39, 23)
        Button6.TabIndex = 8
        Button6.Text = "Go"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' txbSearch
        ' 
        txbSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txbSearch.Location = New Point(686, 5)
        txbSearch.Name = "txbSearch"
        txbSearch.PlaceholderText = "Search"
        txbSearch.Size = New Size(196, 23)
        txbSearch.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(984, 561)
        Controls.Add(Button6)
        Controls.Add(txbAdress)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txbSearch)
        Controls.Add(WebView)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1000, 600)
        Name = "Form1"
        Text = "AnonymBrowser"
        WindowState = FormWindowState.Maximized
        CType(WebView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WebView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txbAdress As TextBox
    Friend WithEvents Button6 As Button
    Public WithEvents txbSearch As TextBox

End Class
