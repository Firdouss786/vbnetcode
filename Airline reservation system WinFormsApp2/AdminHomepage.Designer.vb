<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_menu
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 25)
        Label1.TabIndex = 0
        Label1.Text = "Admin Home page"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(56, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 32)
        Button1.TabIndex = 1
        Button1.Text = "Add Flight"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(207, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 32)
        Button2.TabIndex = 2
        Button2.Text = "Modify Flight"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(362, 105)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 32)
        Button3.TabIndex = 3
        Button3.Text = "Delete Flight"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(56, 181)
        Button4.Name = "Button4"
        Button4.Size = New Size(115, 29)
        Button4.TabIndex = 4
        Button4.Text = "Passenger Details"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridView1.Location = New Point(12, 216)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(786, 150)
        DataGridView1.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "User Id"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "First Name"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Last Name"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Date of Birth"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Address"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Pin Code"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Phone No"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Email"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Passport No"
        Column9.Name = "Column9"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(739, -1)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 6
        Button5.Text = "Log Out"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Admin_menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(810, 382)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Admin_menu"
        Text = "Admin_menu"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
End Class
