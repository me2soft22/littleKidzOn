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
        Me.txtCustPhone = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCustCount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gColPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gColCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gColTimer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gColStart = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gColStop = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustPhone
        '
        Me.txtCustPhone.Location = New System.Drawing.Point(288, 48)
        Me.txtCustPhone.Name = "txtCustPhone"
        Me.txtCustPhone.Size = New System.Drawing.Size(141, 20)
        Me.txtCustPhone.TabIndex = 0
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(288, 85)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(141, 20)
        Me.txtCustName.TabIndex = 1
        '
        'txtCustCount
        '
        Me.txtCustCount.Location = New System.Drawing.Point(288, 123)
        Me.txtCustCount.Name = "txtCustCount"
        Me.txtCustCount.Size = New System.Drawing.Size(141, 20)
        Me.txtCustCount.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No of Kids"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Name"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(199, 175)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(117, 31)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "ENTER 'n' START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(342, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 31)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gColPhone, Me.gColName, Me.gColCount, Me.gColTimer, Me.gColStart, Me.gColStop})
        Me.DataGridView1.Location = New System.Drawing.Point(39, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 191)
        Me.DataGridView1.TabIndex = 8
        '
        'Timer1
        '
        '
        'gColPhone
        '
        Me.gColPhone.HeaderText = "CustomerPhone"
        Me.gColPhone.Name = "gColPhone"
        '
        'gColName
        '
        Me.gColName.HeaderText = "CustomerName"
        Me.gColName.Name = "gColName"
        '
        'gColCount
        '
        Me.gColCount.HeaderText = "No Of Kids"
        Me.gColCount.Name = "gColCount"
        '
        'gColTimer
        '
        Me.gColTimer.HeaderText = "Timer"
        Me.gColTimer.Name = "gColTimer"
        '
        'gColStart
        '
        Me.gColStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.gColStart.HeaderText = "START"
        Me.gColStart.Name = "gColStart"
        Me.gColStart.Text = "Start"
        Me.gColStart.UseColumnTextForButtonValue = True
        Me.gColStart.Width = 49
        '
        'gColStop
        '
        Me.gColStop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.gColStop.HeaderText = "STOP"
        Me.gColStop.Name = "gColStop"
        Me.gColStop.Text = "Stop"
        Me.gColStop.UseColumnTextForButtonValue = True
        Me.gColStop.Width = 42
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustCount)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtCustPhone)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustPhone As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustCount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gColPhone As DataGridViewTextBoxColumn
    Friend WithEvents gColName As DataGridViewTextBoxColumn
    Friend WithEvents gColCount As DataGridViewTextBoxColumn
    Friend WithEvents gColTimer As DataGridViewTextBoxColumn
    Friend WithEvents gColStart As DataGridViewButtonColumn
    Friend WithEvents gColStop As DataGridViewButtonColumn
End Class
