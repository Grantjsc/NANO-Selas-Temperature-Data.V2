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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAssociate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPartNo = New System.Windows.Forms.ComboBox()
        Me.cboProcess = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCHL5 = New System.Windows.Forms.Label()
        Me.lblCHL4 = New System.Windows.Forms.Label()
        Me.lblCHL3 = New System.Windows.Forms.Label()
        Me.lblCHL2 = New System.Windows.Forms.Label()
        Me.lblCHL1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblReady = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SelasTempdbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelasTempDataSet1 = New NANO_Selas_Temperature_Data.SelasTempDataSet1()
        Me.SelasTemp_dbTableAdapter = New NANO_Selas_Temperature_Data.SelasTempDataSet1TableAdapters.SelasTemp_dbTableAdapter()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblExit = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAssociateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPartNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.tbLotNum = New System.Windows.Forms.TextBox()
        Me.lblSec2 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCHL10 = New System.Windows.Forms.Label()
        Me.lblCHL9 = New System.Windows.Forms.Label()
        Me.lblCHL8 = New System.Windows.Forms.Label()
        Me.lblCHL7 = New System.Windows.Forms.Label()
        Me.lblCHL6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SelasTempdbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelasTempDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(270, 12)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(130, 59)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.Location = New System.Drawing.Point(460, 12)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(130, 59)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 50)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(87, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NANO Selas Temperature Data to Infinity"
        '
        'cboAssociate
        '
        Me.cboAssociate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboAssociate.DropDownHeight = 300
        Me.cboAssociate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssociate.FormattingEnabled = True
        Me.cboAssociate.IntegralHeight = False
        Me.cboAssociate.Location = New System.Drawing.Point(440, 219)
        Me.cboAssociate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAssociate.Name = "cboAssociate"
        Me.cboAssociate.Size = New System.Drawing.Size(344, 37)
        Me.cboAssociate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(43, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Part Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(434, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Associate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(39, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Process"
        '
        'cboPartNo
        '
        Me.cboPartNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPartNo.DropDownHeight = 120
        Me.cboPartNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPartNo.FormattingEnabled = True
        Me.cboPartNo.IntegralHeight = False
        Me.cboPartNo.Location = New System.Drawing.Point(45, 219)
        Me.cboPartNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboPartNo.Name = "cboPartNo"
        Me.cboPartNo.Size = New System.Drawing.Size(344, 37)
        Me.cboPartNo.TabIndex = 2
        '
        'cboProcess
        '
        Me.cboProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboProcess.DropDownHeight = 300
        Me.cboProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcess.FormattingEnabled = True
        Me.cboProcess.IntegralHeight = False
        Me.cboProcess.ItemHeight = 29
        Me.cboProcess.Location = New System.Drawing.Point(45, 134)
        Me.cboProcess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProcess.Name = "cboProcess"
        Me.cboProcess.Size = New System.Drawing.Size(344, 37)
        Me.cboProcess.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.lblCHL5)
        Me.GroupBox2.Controls.Add(Me.lblCHL4)
        Me.GroupBox2.Controls.Add(Me.lblCHL3)
        Me.GroupBox2.Controls.Add(Me.lblCHL2)
        Me.GroupBox2.Controls.Add(Me.lblCHL1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(50, 273)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(320, 246)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selas Temperature"
        '
        'lblCHL5
        '
        Me.lblCHL5.AutoSize = True
        Me.lblCHL5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL5.Location = New System.Drawing.Point(185, 194)
        Me.lblCHL5.Name = "lblCHL5"
        Me.lblCHL5.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL5.TabIndex = 9
        Me.lblCHL5.Text = "Temp5"
        '
        'lblCHL4
        '
        Me.lblCHL4.AutoSize = True
        Me.lblCHL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL4.Location = New System.Drawing.Point(185, 155)
        Me.lblCHL4.Name = "lblCHL4"
        Me.lblCHL4.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL4.TabIndex = 8
        Me.lblCHL4.Text = "Temp4"
        '
        'lblCHL3
        '
        Me.lblCHL3.AutoSize = True
        Me.lblCHL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL3.Location = New System.Drawing.Point(185, 117)
        Me.lblCHL3.Name = "lblCHL3"
        Me.lblCHL3.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL3.TabIndex = 7
        Me.lblCHL3.Text = "Temp3"
        '
        'lblCHL2
        '
        Me.lblCHL2.AutoSize = True
        Me.lblCHL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL2.Location = New System.Drawing.Point(185, 78)
        Me.lblCHL2.Name = "lblCHL2"
        Me.lblCHL2.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL2.TabIndex = 6
        Me.lblCHL2.Text = "Temp2"
        '
        'lblCHL1
        '
        Me.lblCHL1.AutoSize = True
        Me.lblCHL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL1.Location = New System.Drawing.Point(185, 38)
        Me.lblCHL1.Name = "lblCHL1"
        Me.lblCHL1.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL1.TabIndex = 5
        Me.lblCHL1.Text = "Temp1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Channel 5:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 29)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Channel 4:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Channel 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Channel 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Channel 1:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(38, 527)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(345, 23)
        Me.ProgressBar1.TabIndex = 15
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.ForeColor = System.Drawing.SystemColors.Control
        Me.lblReady.Location = New System.Drawing.Point(243, 527)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(300, 36)
        Me.lblReady.TabIndex = 10
        Me.lblReady.Text = "Data ready for export!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(434, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 31)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Lot Number"
        '
        'SelasTempdbBindingSource
        '
        Me.SelasTempdbBindingSource.DataMember = "SelasTemp_db"
        Me.SelasTempdbBindingSource.DataSource = Me.SelasTempDataSet1
        '
        'SelasTempDataSet1
        '
        Me.SelasTempDataSet1.DataSetName = "SelasTempDataSet1"
        Me.SelasTempDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelasTemp_dbTableAdapter
        '
        Me.SelasTemp_dbTableAdapter.ClearBeforeFill = True
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSec.Location = New System.Drawing.Point(177, 557)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(0, 20)
        Me.lblSec.TabIndex = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.Control
        Me.lblExit.Location = New System.Drawing.Point(263, 667)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(256, 25)
        Me.lblExit.TabIndex = 19
        Me.lblExit.Text = "*Exit the application to reset."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 32)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAssociateToolStripMenuItem, Me.AddProcessToolStripMenuItem, Me.AddPartNumberToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(84, 28)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddAssociateToolStripMenuItem
        '
        Me.AddAssociateToolStripMenuItem.Image = CType(resources.GetObject("AddAssociateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddAssociateToolStripMenuItem.Name = "AddAssociateToolStripMenuItem"
        Me.AddAssociateToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.AddAssociateToolStripMenuItem.Text = "Add Associate"
        '
        'AddProcessToolStripMenuItem
        '
        Me.AddProcessToolStripMenuItem.Image = CType(resources.GetObject("AddProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddProcessToolStripMenuItem.Name = "AddProcessToolStripMenuItem"
        Me.AddProcessToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.AddProcessToolStripMenuItem.Text = "Add Process"
        '
        'AddPartNumberToolStripMenuItem
        '
        Me.AddPartNumberToolStripMenuItem.Image = CType(resources.GetObject("AddPartNumberToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddPartNumberToolStripMenuItem.Name = "AddPartNumberToolStripMenuItem"
        Me.AddPartNumberToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.AddPartNumberToolStripMenuItem.Text = "Add Part Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.btnEnable)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Location = New System.Drawing.Point(-21, 581)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(878, 82)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(610, 6)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(221, 69)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(48, 6)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(197, 69)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'tbLotNum
        '
        Me.tbLotNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLotNum.Location = New System.Drawing.Point(440, 134)
        Me.tbLotNum.Name = "tbLotNum"
        Me.tbLotNum.Size = New System.Drawing.Size(344, 36)
        Me.tbLotNum.TabIndex = 3
        '
        'lblSec2
        '
        Me.lblSec2.AutoSize = True
        Me.lblSec2.BackColor = System.Drawing.Color.Transparent
        Me.lblSec2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec2.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSec2.Location = New System.Drawing.Point(593, 557)
        Me.lblSec2.Name = "lblSec2"
        Me.lblSec2.Size = New System.Drawing.Size(0, 20)
        Me.lblSec2.TabIndex = 41
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(442, 527)
        Me.ProgressBar2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(345, 23)
        Me.ProgressBar2.TabIndex = 40
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.lblCHL10)
        Me.GroupBox3.Controls.Add(Me.lblCHL9)
        Me.GroupBox3.Controls.Add(Me.lblCHL8)
        Me.GroupBox3.Controls.Add(Me.lblCHL7)
        Me.GroupBox3.Controls.Add(Me.lblCHL6)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(454, 273)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(320, 246)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selas Temperature 2nd Timer"
        '
        'lblCHL10
        '
        Me.lblCHL10.AutoSize = True
        Me.lblCHL10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL10.Location = New System.Drawing.Point(185, 194)
        Me.lblCHL10.Name = "lblCHL10"
        Me.lblCHL10.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL10.TabIndex = 9
        Me.lblCHL10.Text = "Temp5"
        '
        'lblCHL9
        '
        Me.lblCHL9.AutoSize = True
        Me.lblCHL9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL9.Location = New System.Drawing.Point(185, 155)
        Me.lblCHL9.Name = "lblCHL9"
        Me.lblCHL9.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL9.TabIndex = 8
        Me.lblCHL9.Text = "Temp4"
        '
        'lblCHL8
        '
        Me.lblCHL8.AutoSize = True
        Me.lblCHL8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL8.Location = New System.Drawing.Point(185, 117)
        Me.lblCHL8.Name = "lblCHL8"
        Me.lblCHL8.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL8.TabIndex = 7
        Me.lblCHL8.Text = "Temp3"
        '
        'lblCHL7
        '
        Me.lblCHL7.AutoSize = True
        Me.lblCHL7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL7.Location = New System.Drawing.Point(185, 78)
        Me.lblCHL7.Name = "lblCHL7"
        Me.lblCHL7.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL7.TabIndex = 6
        Me.lblCHL7.Text = "Temp2"
        '
        'lblCHL6
        '
        Me.lblCHL6.AutoSize = True
        Me.lblCHL6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHL6.Location = New System.Drawing.Point(185, 38)
        Me.lblCHL6.Name = "lblCHL6"
        Me.lblCHL6.Size = New System.Drawing.Size(90, 29)
        Me.lblCHL6.TabIndex = 5
        Me.lblCHL6.Text = "Temp1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 29)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Channel 5:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(45, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Channel 4:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(45, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 29)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Channel 3:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(45, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 29)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Channel 2:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(45, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 29)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Channel 1:"
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.Black
        Me.btnEnable.Location = New System.Drawing.Point(270, 12)
        Me.btnEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(130, 59)
        Me.btnEnable.TabIndex = 25
        Me.btnEnable.Text = "Enable Export button"
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(834, 700)
        Me.Controls.Add(Me.lblReady)
        Me.Controls.Add(Me.lblSec2)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tbLotNum)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboProcess)
        Me.Controls.Add(Me.cboPartNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAssociate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selas Temperature Data "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SelasTempdbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelasTempDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExport As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SelasTempDataSet1 As SelasTempDataSet1
    Friend WithEvents SelasTempdbBindingSource As BindingSource
    Friend WithEvents SelasTemp_dbTableAdapter As SelasTempDataSet1TableAdapters.SelasTemp_dbTableAdapter
    Friend WithEvents cboAssociate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboPartNo As ComboBox
    Friend WithEvents cboProcess As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCHL5 As Label
    Friend WithEvents lblCHL4 As Label
    Friend WithEvents lblCHL3 As Label
    Friend WithEvents lblCHL2 As Label
    Friend WithEvents lblCHL1 As Label
    Friend WithEvents lblReady As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents lblExit As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAssociateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents AddProcessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPartNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer4 As Timer
    Friend WithEvents tbLotNum As TextBox
    Friend WithEvents lblSec2 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblCHL10 As Label
    Friend WithEvents lblCHL9 As Label
    Friend WithEvents lblCHL8 As Label
    Friend WithEvents lblCHL7 As Label
    Friend WithEvents lblCHL6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnEnable As Button
End Class
