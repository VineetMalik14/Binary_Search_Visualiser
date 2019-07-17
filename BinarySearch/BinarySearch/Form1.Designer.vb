<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class binSearch
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
        Me.newVal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.arrSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xFind = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.arrStatus = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LowHighPos = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'newVal
        '
        Me.newVal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.newVal.Location = New System.Drawing.Point(1026, 60)
        Me.newVal.Name = "newVal"
        Me.newVal.Size = New System.Drawing.Size(130, 26)
        Me.newVal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(554, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Value To Be Added In The Array:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.Location = New System.Drawing.Point(1226, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(194, 42)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'arrSize
        '
        Me.arrSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.arrSize.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.arrSize.Location = New System.Drawing.Point(1026, 121)
        Me.arrSize.Name = "arrSize"
        Me.arrSize.ReadOnly = True
        Me.arrSize.Size = New System.Drawing.Size(129, 26)
        Me.arrSize.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(610, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number Of Elements In The Array:"
        '
        'xFind
        '
        Me.xFind.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.xFind.Location = New System.Drawing.Point(1028, 216)
        Me.xFind.Name = "xFind"
        Me.xFind.Size = New System.Drawing.Size(128, 26)
        Me.xFind.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(584, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter Value To Be Searched:"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(1228, 111)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(192, 41)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(1179, 199)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(241, 60)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(574, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Status Of The Array After Each Iteration Of Binary Search:"
        '
        'arrStatus
        '
        Me.arrStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.arrStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.arrStatus.Location = New System.Drawing.Point(14, 451)
        Me.arrStatus.Name = "arrStatus"
        Me.arrStatus.ReadOnly = True
        Me.arrStatus.Size = New System.Drawing.Size(1408, 23)
        Me.arrStatus.TabIndex = 10
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.AutoSize = True
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNext.Location = New System.Drawing.Point(733, 384)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(689, 44)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.result.Location = New System.Drawing.Point(1028, 288)
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Size = New System.Drawing.Size(394, 26)
        Me.result.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(900, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Result:"
        '
        'LowHighPos
        '
        Me.LowHighPos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LowHighPos.BackColor = System.Drawing.Color.Khaki
        Me.LowHighPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LowHighPos.ForeColor = System.Drawing.Color.Indigo
        Me.LowHighPos.Location = New System.Drawing.Point(14, 483)
        Me.LowHighPos.Name = "LowHighPos"
        Me.LowHighPos.ReadOnly = True
        Me.LowHighPos.Size = New System.Drawing.Size(1408, 23)
        Me.LowHighPos.TabIndex = 14
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelect.AutoSize = True
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSelect.Location = New System.Drawing.Point(76, 267)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(140, 42)
        Me.btnSelect.TabIndex = 15
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(80, 333)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(125, 20)
        Me.lblFile.TabIndex = 16
        Me.lblFile.Text = "No File Selected"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(70, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Select Input Text File:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.PaleGreen
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.Label7.Location = New System.Drawing.Point(41, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(481, 64)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "BINARY SEARCH"
        '
        'binSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1426, 554)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.LowHighPos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.arrStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.xFind)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.arrSize)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newVal)
        Me.Name = "binSearch"
        Me.Text = "Binary Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newVal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents arrSize As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xFind As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents arrStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents result As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LowHighPos As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
