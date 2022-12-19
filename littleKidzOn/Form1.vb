Imports System.Threading
Public Class Form1
    Public KeepAliveDelegate As Threading.TimerCallback
    Public KeepAliveTimer As System.Threading.Timer
    Dim count As Integer

    Dim ss, tt, vv As Integer
    Dim ROW_NUMBER As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        KeepAliveDelegate = AddressOf KeepAliveTimerHandler
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustPhone.Text = ""
        txtCustName.Text = ""
        txtCustCount.Text = ""
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtCustPhone.Text = "" And txtCustName.Text = "" And txtCustCount.Text = "" Then
            MessageBox.Show("Please Enter all the fields.")
        Else
            DataGridView1.Rows.Add(txtCustPhone.Text, txtCustName.Text, txtCustCount.Text)
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                'MessageBox.Show("Text -" + DataGridView1.Rows(i).Cells(0).Value)
                If DataGridView1.Rows(i).Cells(0).Value = txtCustPhone.Text Then
                    ROW_NUMBER = i
                    'MessageBox.Show(ROW_NUMBER)
                    'Timer1.Enabled = True
                    'Timer1.Interval = 1000
                    'Timer1.Start()
                    count = 0
                    KeepAliveTimer = New System.Threading.Timer(KeepAliveDelegate, Nothing, 1000, 1000)
                    KeepAliveTimer.Change(1000, 1000)
                    Exit For
                End If
            Next
            txtCustPhone.Text = ""
            txtCustName.Text = ""
            txtCustCount.Text = ""

            'Dim rowCount As Integer
            'If Not DataGridView1.Rows.Cast(Of DataGridViewRow)().Any(Function(row) row.IsNewRow) Then
            'rowCount = 0
            'Elses
            'rowCount = DataGridView1.Rows.Count
            'End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Stop" Then
            'Dim dr As DataGridViewRow = DataGridView1.CurrentRow
            'Dim cindex As Integer
            'cindex = dr.Index
            'Timer1.Stop()
            KeepAliveTimer.Change(0, System.Threading.Timeout.Infinite)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DataGridView1.Rows(ROW_NUMBER).Cells(3).Value = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If (vv > 59) Then
            vv = 0
            tt = tt + 1
        End If
        If tt = 2 Then
            vv = 0
            tt = 0
            DataGridView1.Rows(ROW_NUMBER).Cells(3).Value = "00:00:00"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub KeepAliveTimerHandler(ByVal state As Object)
        AccessControl()
    End Sub

    Private Sub AccessControl()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            DataGridView1.Rows(ROW_NUMBER).Cells(3).Value = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
            vv = vv + 1
            If (vv > 59) Then
                vv = 0
                tt = tt + 1
            End If
            If tt = 2 Then
                vv = 0
                tt = 0
                DataGridView1.Rows(ROW_NUMBER).Cells(3).Value = "00:00:00"
                KeepAliveTimer.Dispose()
            End If
            'count = count + 1
            'DataGridView1.Rows(ROW_NUMBER).Cells(3).Value = "00:00:00"
            'DataGridView1.Rows(ROW_NUMBER).Cells(3).Value = count.ToString
        End If
    End Sub
End Class
