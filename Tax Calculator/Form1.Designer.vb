<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PreTaxBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PerTaxBox = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TaxValBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PostTaxBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PerTaxBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreTaxBox
        '
        Me.PreTaxBox.AccessibleName = "PreTaxBox"
        Me.PreTaxBox.Location = New System.Drawing.Point(161, 38)
        Me.PreTaxBox.Name = "PreTaxBox"
        Me.PreTaxBox.Size = New System.Drawing.Size(235, 22)
        Me.PreTaxBox.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input Pre Tax Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Percent Tax"
        '
        'PerTaxBox
        '
        Me.PerTaxBox.AccessibleName = "PerTaxBox"
        Me.PerTaxBox.DecimalPlaces = 2
        Me.PerTaxBox.Location = New System.Drawing.Point(215, 114)
        Me.PerTaxBox.Name = "PerTaxBox"
        Me.PerTaxBox.Size = New System.Drawing.Size(120, 22)
        Me.PerTaxBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tax Value"
        '
        'TaxValBox
        '
        Me.TaxValBox.AccessibleName = "TaxValBox"
        Me.TaxValBox.Location = New System.Drawing.Point(150, 173)
        Me.TaxValBox.Name = "TaxValBox"
        Me.TaxValBox.Size = New System.Drawing.Size(246, 22)
        Me.TaxValBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Value After Tax"
        '
        'PostTaxBox
        '
        Me.PostTaxBox.AccessibleName = "PostTaxBox"
        Me.PostTaxBox.Location = New System.Drawing.Point(150, 233)
        Me.PostTaxBox.Name = "PostTaxBox"
        Me.PostTaxBox.Size = New System.Drawing.Size(246, 22)
        Me.PostTaxBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PostTaxBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TaxValBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PerTaxBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PreTaxBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PerTaxBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PreTaxBox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PerTaxBox As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TaxValBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PostTaxBox As TextBox
    Friend WithEvents Button1 As Button
End Class
