<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathApplication
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
        Me.txtAddNumberToList = New System.Windows.Forms.TextBox()
        Me.bntAddNumberToList = New System.Windows.Forms.Button()
        Me.numberList = New System.Windows.Forms.ListBox()
        Me.bntMean = New System.Windows.Forms.Button()
        Me.bntMedian = New System.Windows.Forms.Button()
        Me.bntMode = New System.Windows.Forms.Button()
        Me.bntClearList = New System.Windows.Forms.Button()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtMedian = New System.Windows.Forms.TextBox()
        Me.txtMode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAddNumberToList
        '
        Me.txtAddNumberToList.Location = New System.Drawing.Point(64, 172)
        Me.txtAddNumberToList.Name = "txtAddNumberToList"
        Me.txtAddNumberToList.Size = New System.Drawing.Size(100, 23)
        Me.txtAddNumberToList.TabIndex = 0
        '
        'bntAddNumberToList
        '
        Me.bntAddNumberToList.Location = New System.Drawing.Point(64, 213)
        Me.bntAddNumberToList.Name = "bntAddNumberToList"
        Me.bntAddNumberToList.Size = New System.Drawing.Size(100, 27)
        Me.bntAddNumberToList.TabIndex = 1
        Me.bntAddNumberToList.Text = "Add Number to List"
        Me.bntAddNumberToList.UseVisualStyleBackColor = True
        '
        'numberList
        '
        Me.numberList.FormattingEnabled = True
        Me.numberList.ItemHeight = 15
        Me.numberList.Location = New System.Drawing.Point(203, 26)
        Me.numberList.Name = "numberList"
        Me.numberList.Size = New System.Drawing.Size(124, 379)
        Me.numberList.TabIndex = 2
        '
        'bntMean
        '
        Me.bntMean.Location = New System.Drawing.Point(369, 102)
        Me.bntMean.Name = "bntMean"
        Me.bntMean.Size = New System.Drawing.Size(86, 48)
        Me.bntMean.TabIndex = 3
        Me.bntMean.Text = "Mean"
        Me.bntMean.UseVisualStyleBackColor = True
        '
        'bntMedian
        '
        Me.bntMedian.Location = New System.Drawing.Point(369, 172)
        Me.bntMedian.Name = "bntMedian"
        Me.bntMedian.Size = New System.Drawing.Size(86, 48)
        Me.bntMedian.TabIndex = 4
        Me.bntMedian.Text = "Median"
        Me.bntMedian.UseVisualStyleBackColor = True
        '
        'bntMode
        '
        Me.bntMode.Location = New System.Drawing.Point(369, 242)
        Me.bntMode.Name = "bntMode"
        Me.bntMode.Size = New System.Drawing.Size(86, 48)
        Me.bntMode.TabIndex = 5
        Me.bntMode.Text = "Mean"
        Me.bntMode.UseVisualStyleBackColor = True
        '
        'bntClearList
        '
        Me.bntClearList.Location = New System.Drawing.Point(369, 330)
        Me.bntClearList.Name = "bntClearList"
        Me.bntClearList.Size = New System.Drawing.Size(86, 48)
        Me.bntClearList.TabIndex = 6
        Me.bntClearList.Text = "Clear List"
        Me.bntClearList.UseVisualStyleBackColor = True
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(489, 119)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(40, 15)
        Me.lblMean.TabIndex = 7
        Me.lblMean.Text = "Mean:"
        '
        'lblMedian
        '
        Me.lblMedian.AutoSize = True
        Me.lblMedian.Location = New System.Drawing.Point(489, 189)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(50, 15)
        Me.lblMedian.TabIndex = 8
        Me.lblMedian.Text = "Median:"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(489, 259)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(41, 15)
        Me.lblMode.TabIndex = 9
        Me.lblMode.Text = "Mode:"
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(554, 116)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.ReadOnly = True
        Me.txtMean.Size = New System.Drawing.Size(74, 23)
        Me.txtMean.TabIndex = 10
        '
        'txtMedian
        '
        Me.txtMedian.Location = New System.Drawing.Point(554, 186)
        Me.txtMedian.Name = "txtMedian"
        Me.txtMedian.ReadOnly = True
        Me.txtMedian.Size = New System.Drawing.Size(74, 23)
        Me.txtMedian.TabIndex = 11
        '
        'txtMode
        '
        Me.txtMode.Location = New System.Drawing.Point(554, 256)
        Me.txtMode.Name = "txtMode"
        Me.txtMode.ReadOnly = True
        Me.txtMode.Size = New System.Drawing.Size(74, 23)
        Me.txtMode.TabIndex = 12
        '
        'MathApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMode)
        Me.Controls.Add(Me.txtMedian)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.bntClearList)
        Me.Controls.Add(Me.bntMode)
        Me.Controls.Add(Me.bntMedian)
        Me.Controls.Add(Me.bntMean)
        Me.Controls.Add(Me.numberList)
        Me.Controls.Add(Me.bntAddNumberToList)
        Me.Controls.Add(Me.txtAddNumberToList)
        Me.Name = "MathApplication"
        Me.Text = "Math Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddNumberToList As TextBox
    Friend WithEvents bntAddNumberToList As Button
    Friend WithEvents numberList As ListBox
    Friend WithEvents bntMean As Button
    Friend WithEvents bntMedian As Button
    Friend WithEvents bntMode As Button
    Friend WithEvents bntClearList As Button
    Friend WithEvents lblMean As Label
    Friend WithEvents lblMedian As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents txtMean As TextBox
    Friend WithEvents txtMedian As TextBox
    Friend WithEvents txtMode As TextBox
End Class
