<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(66, 48)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 43)
        Button2.TabIndex = 1
        Button2.Text = "Passenger Details"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(244, 48)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 43)
        Button3.TabIndex = 2
        Button3.Text = "Search Flights"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(409, 48)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 43)
        Button4.TabIndex = 3
        Button4.Text = "Book Flights"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(66, 174)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(702, 150)
        DataGridView1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(66, 136)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 32)
        Button1.TabIndex = 7
        Button1.Text = "Show my flights"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(703, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 8
        Button5.Text = "Log Out"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' User_Homepage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(780, 415)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Name = "User_Homepage"
        Text = "User_Homepage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
End Class
