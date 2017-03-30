<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.Btnparameter = New System.Windows.Forms.Button()
        Me.BtnEscInter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRun = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        Me.BtnAnnotations = New System.Windows.Forms.Button()
        Me.BtnShowRoi = New System.Windows.Forms.Button()
        Me.ButShutter = New System.Windows.Forms.Button()
        Me.CamShutter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbSelRoi = New System.Windows.Forms.ComboBox()
        Me.ROIProcess = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmbImg = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSave1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ChkALive = New System.Windows.Forms.CheckBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSolutoon = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSetVariable = New System.Windows.Forms.Button()
        Me.GroupBoxSetVariable = New System.Windows.Forms.GroupBox()
        Me.CCDPath = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Text10 = New System.Windows.Forms.MaskedTextBox()
        Me.Text9 = New System.Windows.Forms.MaskedTextBox()
        Me.Text8 = New System.Windows.Forms.MaskedTextBox()
        Me.Text7 = New System.Windows.Forms.MaskedTextBox()
        Me.Text6 = New System.Windows.Forms.MaskedTextBox()
        Me.Text5 = New System.Windows.Forms.MaskedTextBox()
        Me.Text4 = New System.Windows.Forms.MaskedTextBox()
        Me.Text3 = New System.Windows.Forms.MaskedTextBox()
        Me.Text2 = New System.Windows.Forms.MaskedTextBox()
        Me.Text1 = New System.Windows.Forms.MaskedTextBox()
        Me.Text0 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AxIpeDspCtrl1 = New AxIpeDspCtrlLib.AxIpeDspCtrl()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxSetVariable.SuspendLayout()
        CType(Me.AxIpeDspCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(137, 11)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(101, 55)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "运行程序"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(262, 11)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(101, 55)
        Me.BtnStop.TabIndex = 2
        Me.BtnStop.Text = "停止程序"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Btnparameter
        '
        Me.Btnparameter.Location = New System.Drawing.Point(387, 11)
        Me.Btnparameter.Name = "Btnparameter"
        Me.Btnparameter.Size = New System.Drawing.Size(101, 55)
        Me.Btnparameter.TabIndex = 3
        Me.Btnparameter.Text = "检测设定"
        Me.Btnparameter.UseVisualStyleBackColor = True
        '
        'BtnEscInter
        '
        Me.BtnEscInter.Location = New System.Drawing.Point(637, 11)
        Me.BtnEscInter.Name = "BtnEscInter"
        Me.BtnEscInter.Size = New System.Drawing.Size(101, 55)
        Me.BtnEscInter.TabIndex = 4
        Me.BtnEscInter.Text = "退出程序"
        Me.BtnEscInter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRun)
        Me.GroupBox1.Controls.Add(Me.BtnModify)
        Me.GroupBox1.Controls.Add(Me.BtnAnnotations)
        Me.GroupBox1.Controls.Add(Me.BtnShowRoi)
        Me.GroupBox1.Controls.Add(Me.ButShutter)
        Me.GroupBox1.Controls.Add(Me.CamShutter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbSelRoi)
        Me.GroupBox1.Controls.Add(Me.ROIProcess)
        Me.GroupBox1.Controls.Add(Me.CmbImg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtnSave1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(745, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 556)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "检测设定"
        '
        'BtnRun
        '
        Me.BtnRun.Location = New System.Drawing.Point(19, 471)
        Me.BtnRun.Name = "BtnRun"
        Me.BtnRun.Size = New System.Drawing.Size(85, 42)
        Me.BtnRun.TabIndex = 37
        Me.BtnRun.Text = "测试"
        Me.BtnRun.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(84, 281)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(75, 23)
        Me.BtnModify.TabIndex = 36
        Me.BtnModify.Text = "处理图形"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnAnnotations
        '
        Me.BtnAnnotations.Location = New System.Drawing.Point(162, 281)
        Me.BtnAnnotations.Name = "BtnAnnotations"
        Me.BtnAnnotations.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnotations.TabIndex = 35
        Me.BtnAnnotations.Text = "检测点"
        Me.BtnAnnotations.UseVisualStyleBackColor = True
        '
        'BtnShowRoi
        '
        Me.BtnShowRoi.Location = New System.Drawing.Point(6, 281)
        Me.BtnShowRoi.Name = "BtnShowRoi"
        Me.BtnShowRoi.Size = New System.Drawing.Size(75, 23)
        Me.BtnShowRoi.TabIndex = 34
        Me.BtnShowRoi.Text = "显示框"
        Me.BtnShowRoi.UseVisualStyleBackColor = True
        '
        'ButShutter
        '
        Me.ButShutter.Location = New System.Drawing.Point(163, 338)
        Me.ButShutter.Name = "ButShutter"
        Me.ButShutter.Size = New System.Drawing.Size(66, 21)
        Me.ButShutter.TabIndex = 33
        Me.ButShutter.Text = "刷新"
        Me.ButShutter.UseVisualStyleBackColor = True
        '
        'CamShutter
        '
        Me.CamShutter.Location = New System.Drawing.Point(74, 339)
        Me.CamShutter.Name = "CamShutter"
        Me.CamShutter.Size = New System.Drawing.Size(67, 21)
        Me.CamShutter.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "曝光时间"
        '
        'CmbSelRoi
        '
        Me.CmbSelRoi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbSelRoi.FormattingEnabled = True
        Me.CmbSelRoi.Location = New System.Drawing.Point(87, 82)
        Me.CmbSelRoi.Name = "CmbSelRoi"
        Me.CmbSelRoi.Size = New System.Drawing.Size(142, 20)
        Me.CmbSelRoi.TabIndex = 29
        '
        'ROIProcess
        '
        Me.ROIProcess.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ROIProcess.FullRowSelect = True
        Me.ROIProcess.GridLines = True
        Me.ROIProcess.Location = New System.Drawing.Point(6, 137)
        Me.ROIProcess.Name = "ROIProcess"
        Me.ROIProcess.Size = New System.Drawing.Size(230, 120)
        Me.ROIProcess.TabIndex = 28
        Me.ROIProcess.TabStop = False
        Me.ROIProcess.UseCompatibleStateImageBehavior = False
        Me.ROIProcess.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "编号"
        Me.ColumnHeader3.Width = 66
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "检测工具"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 160
        '
        'CmbImg
        '
        Me.CmbImg.FormattingEnabled = True
        Me.CmbImg.Location = New System.Drawing.Point(87, 20)
        Me.CmbImg.Name = "CmbImg"
        Me.CmbImg.Size = New System.Drawing.Size(142, 20)
        Me.CmbImg.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "选择工位"
        '
        'BtnSave1
        '
        Me.BtnSave1.Location = New System.Drawing.Point(144, 471)
        Me.BtnSave1.Name = "BtnSave1"
        Me.BtnSave1.Size = New System.Drawing.Size(85, 42)
        Me.BtnSave1.TabIndex = 8
        Me.BtnSave1.Text = "保存程序"
        Me.BtnSave1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = ""
        Me.Label2.Text = "选择检测区域"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'ChkALive
        '
        Me.ChkALive.AutoSize = True
        Me.ChkALive.Location = New System.Drawing.Point(650, 93)
        Me.ChkALive.Name = "ChkALive"
        Me.ChkALive.Size = New System.Drawing.Size(72, 16)
        Me.ChkALive.TabIndex = 11
        Me.ChkALive.Text = "实时图像"
        Me.ChkALive.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Interval = 10
        '
        'BtnSolutoon
        '
        Me.BtnSolutoon.Location = New System.Drawing.Point(12, 11)
        Me.BtnSolutoon.Name = "BtnSolutoon"
        Me.BtnSolutoon.Size = New System.Drawing.Size(101, 55)
        Me.BtnSolutoon.TabIndex = 12
        Me.BtnSolutoon.Text = "加载程序"
        Me.BtnSolutoon.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSetVariable
        '
        Me.BtnSetVariable.Location = New System.Drawing.Point(512, 11)
        Me.BtnSetVariable.Name = "BtnSetVariable"
        Me.BtnSetVariable.Size = New System.Drawing.Size(101, 55)
        Me.BtnSetVariable.TabIndex = 13
        Me.BtnSetVariable.Text = "参数设定"
        Me.BtnSetVariable.UseVisualStyleBackColor = True
        '
        'GroupBoxSetVariable
        '
        Me.GroupBoxSetVariable.Controls.Add(Me.CCDPath)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label37)
        Me.GroupBoxSetVariable.Controls.Add(Me.CheckBox3)
        Me.GroupBoxSetVariable.Controls.Add(Me.CheckBox2)
        Me.GroupBoxSetVariable.Controls.Add(Me.CheckBox1)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label36)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label35)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label34)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label33)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label32)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label31)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label30)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label29)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label28)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label27)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button8)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label26)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label25)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label24)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label23)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label22)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label21)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label20)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label19)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label18)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label17)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label16)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text10)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text9)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text8)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text7)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text6)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text5)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text4)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text3)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text2)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text1)
        Me.GroupBoxSetVariable.Controls.Add(Me.Text0)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label15)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button7)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button6)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button5)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button4)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button3)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button2)
        Me.GroupBoxSetVariable.Controls.Add(Me.Button1)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label14)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label13)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label12)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label11)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label10)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label9)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label8)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label7)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label6)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label4)
        Me.GroupBoxSetVariable.Controls.Add(Me.Label1)
        Me.GroupBoxSetVariable.Location = New System.Drawing.Point(0, 89)
        Me.GroupBoxSetVariable.Name = "GroupBoxSetVariable"
        Me.GroupBoxSetVariable.Size = New System.Drawing.Size(738, 554)
        Me.GroupBoxSetVariable.TabIndex = 14
        Me.GroupBoxSetVariable.TabStop = False
        Me.GroupBoxSetVariable.Text = "参数设定"
        '
        'CCDPath
        '
        Me.CCDPath.AutoSize = True
        Me.CCDPath.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CCDPath.Location = New System.Drawing.Point(134, 392)
        Me.CCDPath.Name = "CCDPath"
        Me.CCDPath.Size = New System.Drawing.Size(77, 14)
        Me.CCDPath.TabIndex = 70
        Me.CCDPath.Text = "未加载程序"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label37.Location = New System.Drawing.Point(24, 392)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(105, 14)
        Me.Label37.TabIndex = 69
        Me.Label37.Text = "当前程序路径："
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(385, 342)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(124, 18)
        Me.CheckBox3.TabIndex = 68
        Me.CheckBox3.Text = "保存NG检测图像"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(199, 342)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(124, 18)
        Me.CheckBox2.TabIndex = 67
        Me.CheckBox2.Text = "保存NG原始图像"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(25, 342)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(110, 18)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "保存所有图像"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(614, 245)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(17, 12)
        Me.Label36.TabIndex = 65
        Me.Label36.Text = "mm"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(614, 194)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(17, 12)
        Me.Label35.TabIndex = 64
        Me.Label35.Text = "mm"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(614, 145)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(17, 12)
        Me.Label34.TabIndex = 63
        Me.Label34.Text = "mm"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(614, 92)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(17, 12)
        Me.Label33.TabIndex = 62
        Me.Label33.Text = "mm"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(614, 41)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(17, 12)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = "mm"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(252, 237)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(17, 12)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "°"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(252, 188)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(17, 12)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "mm"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(252, 143)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(17, 12)
        Me.Label29.TabIndex = 58
        Me.Label29.Text = "mm"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(252, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(17, 12)
        Me.Label28.TabIndex = 57
        Me.Label28.Text = "mm"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(252, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 12)
        Me.Label27.TabIndex = 56
        Me.Label27.Text = "mm"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Location = New System.Drawing.Point(530, 435)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 48)
        Me.Button8.TabIndex = 55
        Me.Button8.Text = "保存设定"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(633, 293)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 12)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "*"
        Me.Label26.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(633, 242)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 12)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "*"
        Me.Label25.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(633, 191)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 12)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "*"
        Me.Label24.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(633, 140)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 12)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "*"
        Me.Label23.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(633, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 12)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "*"
        Me.Label22.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(633, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 12)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "*"
        Me.Label21.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(271, 234)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 12)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "*"
        Me.Label20.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(271, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 12)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "*"
        Me.Label19.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(271, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 12)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "*"
        Me.Label18.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(271, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 12)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "*"
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(271, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 12)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "*"
        Me.Label16.Visible = False
        '
        'Text10
        '
        Me.Text10.Location = New System.Drawing.Point(528, 293)
        Me.Text10.Name = "Text10"
        Me.Text10.Size = New System.Drawing.Size(85, 21)
        Me.Text10.TabIndex = 43
        Me.Text10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text9
        '
        Me.Text9.Location = New System.Drawing.Point(528, 242)
        Me.Text9.Name = "Text9"
        Me.Text9.Size = New System.Drawing.Size(85, 21)
        Me.Text9.TabIndex = 42
        Me.Text9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text8
        '
        Me.Text8.Location = New System.Drawing.Point(528, 191)
        Me.Text8.Name = "Text8"
        Me.Text8.Size = New System.Drawing.Size(85, 21)
        Me.Text8.TabIndex = 41
        Me.Text8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text7
        '
        Me.Text7.Location = New System.Drawing.Point(528, 140)
        Me.Text7.Name = "Text7"
        Me.Text7.Size = New System.Drawing.Size(85, 21)
        Me.Text7.TabIndex = 40
        Me.Text7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text6
        '
        Me.Text6.Location = New System.Drawing.Point(528, 89)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = New System.Drawing.Size(85, 21)
        Me.Text6.TabIndex = 39
        Me.Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text5
        '
        Me.Text5.Location = New System.Drawing.Point(528, 38)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(85, 21)
        Me.Text5.TabIndex = 38
        Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text4
        '
        Me.Text4.Location = New System.Drawing.Point(169, 234)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(82, 21)
        Me.Text4.TabIndex = 37
        Me.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(169, 185)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(82, 21)
        Me.Text3.TabIndex = 36
        Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(169, 136)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(82, 21)
        Me.Text2.TabIndex = 35
        Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(169, 87)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(82, 21)
        Me.Text1.TabIndex = 34
        Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text0
        '
        Me.Text0.Location = New System.Drawing.Point(169, 38)
        Me.Text0.Name = "Text0"
        Me.Text0.Size = New System.Drawing.Size(82, 21)
        Me.Text0.TabIndex = 33
        Me.Text0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 294)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 14)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "方向反转检测"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(169, 293)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(82, 21)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "切除"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Lime
        Me.Button6.Location = New System.Drawing.Point(650, 87)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "切除"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(650, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "切除"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(288, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "切除"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(288, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "切除"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(288, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "切除"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(288, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "切除"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(383, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 14)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "破损二值化强度"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(382, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 14)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "边角宽度上限"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(382, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 14)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "边角区域缩进上限"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(382, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "边缘破损深度上限"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(382, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "边角破损宽度上限"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(382, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 14)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "边缘破损宽度上限"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 14)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "丝印偏转上限"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 14)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "丝印偏移上限"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "电池片宽度标准值"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 14)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "电池片高度标准值"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 14)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "电池片尺寸误差"
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(744, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 50)
        Me.ListBox1.TabIndex = 15
        '
        'AxIpeDspCtrl1
        '
        Me.AxIpeDspCtrl1.Enabled = True
        Me.AxIpeDspCtrl1.Location = New System.Drawing.Point(0, 87)
        Me.AxIpeDspCtrl1.Name = "AxIpeDspCtrl1"
        Me.AxIpeDspCtrl1.OcxState = CType(resources.GetObject("AxIpeDspCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxIpeDspCtrl1.Size = New System.Drawing.Size(739, 556)
        Me.AxIpeDspCtrl1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(997, 655)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBoxSetVariable)
        Me.Controls.Add(Me.BtnSetVariable)
        Me.Controls.Add(Me.BtnSolutoon)
        Me.Controls.Add(Me.ChkALive)
        Me.Controls.Add(Me.BtnEscInter)
        Me.Controls.Add(Me.Btnparameter)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AxIpeDspCtrl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vision"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxSetVariable.ResumeLayout(False)
        Me.GroupBoxSetVariable.PerformLayout()
        CType(Me.AxIpeDspCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents Btnparameter As System.Windows.Forms.Button
    Friend WithEvents BtnEscInter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BtnSave1 As System.Windows.Forms.Button
    Friend WithEvents AxIpeDspCtrl1 As AxIpeDspCtrlLib.AxIpeDspCtrl
    Friend WithEvents CmbImg As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChkALive As System.Windows.Forms.CheckBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents BtnSolutoon As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ROIProcess As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CmbSelRoi As System.Windows.Forms.ComboBox
    Friend WithEvents ButShutter As System.Windows.Forms.Button
    Friend WithEvents CamShutter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnShowRoi As Button
    Friend WithEvents BtnSetVariable As Button
    Friend WithEvents BtnAnnotations As Button
    Friend WithEvents GroupBoxSetVariable As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Text10 As MaskedTextBox
    Friend WithEvents Text9 As MaskedTextBox
    Friend WithEvents Text8 As MaskedTextBox
    Friend WithEvents Text7 As MaskedTextBox
    Friend WithEvents Text6 As MaskedTextBox
    Friend WithEvents Text5 As MaskedTextBox
    Friend WithEvents Text4 As MaskedTextBox
    Friend WithEvents Text3 As MaskedTextBox
    Friend WithEvents Text2 As MaskedTextBox
    Friend WithEvents Text1 As MaskedTextBox
    Friend WithEvents Text0 As MaskedTextBox
    Friend WithEvents BtnModify As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CCDPath As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents BtnRun As Button
    Friend WithEvents ListBox1 As ListBox
End Class
