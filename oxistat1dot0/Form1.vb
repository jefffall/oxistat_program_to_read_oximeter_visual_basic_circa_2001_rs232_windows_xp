'Copyright (C) 2003 SmartWeb Sales
'All rights reserved.
'THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
'EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
'MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

'Requires the Trial or Release version of Visual Studio .NET Professional (or greater).

Option Strict On

Imports System.Text
Imports System.Data.OleDb
'Imports System.Data                      ' State variables
'Imports System.Data.ADO                ' Database
Imports System.Globalization             ' Date






Public Class frmMain
    Inherits System.Windows.Forms.Form


    ' Declare necessary class variables.
    Private m_CommPort As New Rs232()
    Private timesScratchPad As times
    Private m_IsModemFound As Boolean = False
    Private m_ModemPort As Integer = 0
    Private thisport As Integer = 1
    Private commport As String
    Private validCommPort As Boolean = False

   

   

  



#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

            ' So that we only need to set the title of the application once,
            ' we use the AssemblyInfo class (defined in the AssemblyInfo.vb file)
            ' to read the AssemblyTitle attribute.
            Dim ainfo As New AssemblyInfo()

            Me.Text = ainfo.Title
            Me.mnuAbout.Text = String.Format("&About {0} ...", ainfo.Title)
            Me.oxiAppInit()

        Me.TextBox6.Visible = False

       

        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
        Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
        Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
        Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
        Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
        Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents confcomm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents status As System.Windows.Forms.TextBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents Button4 As System.Windows.Forms.Button
        Friend WithEvents Button5 As System.Windows.Forms.Button
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
        Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daPatients As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsPatientsForm1 As oxistat1dot0.dsPatientsForm1
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents daHRrpt As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents daSpO2rpt As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsSpO2rpt1 As oxistat1dot0.dsSpO2rpt
    Friend WithEvents DsHRrpt1 As oxistat1dot0.dsHRrpt
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daRpt As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsRpt As oxistat1dot0.dsRpt

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Me.mnuMain = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.confcomm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.DsRpt = New oxistat1dot0.dsRpt()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DsPatientsForm1 = New oxistat1dot0.dsPatientsForm1()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.DsSpO2rpt1 = New oxistat1dot0.dsSpO2rpt()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.daPatients = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataView1 = New System.Data.DataView()
        Me.daHRrpt = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.daSpO2rpt = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.DsHRrpt1 = New oxistat1dot0.dsHRrpt()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.daRpt = New System.Data.OleDb.OleDbDataAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPatientsForm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DsSpO2rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHRrpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuHelp})
        Me.mnuMain.RightToLeft = CType(resources.GetObject("mnuMain.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'mnuFile
        '
        Me.mnuFile.Enabled = CType(resources.GetObject("mnuFile.Enabled"), Boolean)
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Shortcut = CType(resources.GetObject("mnuFile.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFile.ShowShortcut = CType(resources.GetObject("mnuFile.ShowShortcut"), Boolean)
        Me.mnuFile.Text = resources.GetString("mnuFile.Text")
        Me.mnuFile.Visible = CType(resources.GetObject("mnuFile.Visible"), Boolean)
        '
        'mnuExit
        '
        Me.mnuExit.Enabled = CType(resources.GetObject("mnuExit.Enabled"), Boolean)
        Me.mnuExit.Index = 0
        Me.mnuExit.Shortcut = CType(resources.GetObject("mnuExit.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuExit.ShowShortcut = CType(resources.GetObject("mnuExit.ShowShortcut"), Boolean)
        Me.mnuExit.Text = resources.GetString("mnuExit.Text")
        Me.mnuExit.Visible = CType(resources.GetObject("mnuExit.Visible"), Boolean)
        '
        'mnuHelp
        '
        Me.mnuHelp.Enabled = CType(resources.GetObject("mnuHelp.Enabled"), Boolean)
        Me.mnuHelp.Index = 1
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout})
        Me.mnuHelp.Shortcut = CType(resources.GetObject("mnuHelp.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelp.ShowShortcut = CType(resources.GetObject("mnuHelp.ShowShortcut"), Boolean)
        Me.mnuHelp.Text = resources.GetString("mnuHelp.Text")
        Me.mnuHelp.Visible = CType(resources.GetObject("mnuHelp.Visible"), Boolean)
        '
        'mnuAbout
        '
        Me.mnuAbout.Enabled = CType(resources.GetObject("mnuAbout.Enabled"), Boolean)
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Shortcut = CType(resources.GetObject("mnuAbout.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuAbout.ShowShortcut = CType(resources.GetObject("mnuAbout.ShowShortcut"), Boolean)
        Me.mnuAbout.Text = resources.GetString("mnuAbout.Text")
        Me.mnuAbout.Visible = CType(resources.GetObject("mnuAbout.Visible"), Boolean)
        '
        'txtStatus
        '
        Me.txtStatus.AccessibleDescription = resources.GetString("txtStatus.AccessibleDescription")
        Me.txtStatus.AccessibleName = resources.GetString("txtStatus.AccessibleName")
        Me.txtStatus.Anchor = CType(resources.GetObject("txtStatus.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.AutoSize = CType(resources.GetObject("txtStatus.AutoSize"), Boolean)
        Me.txtStatus.BackColor = System.Drawing.SystemColors.Info
        Me.txtStatus.BackgroundImage = CType(resources.GetObject("txtStatus.BackgroundImage"), System.Drawing.Image)
        Me.txtStatus.Dock = CType(resources.GetObject("txtStatus.Dock"), System.Windows.Forms.DockStyle)
        Me.txtStatus.Enabled = CType(resources.GetObject("txtStatus.Enabled"), Boolean)
        Me.txtStatus.Font = CType(resources.GetObject("txtStatus.Font"), System.Drawing.Font)
        Me.txtStatus.ImeMode = CType(resources.GetObject("txtStatus.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtStatus.Location = CType(resources.GetObject("txtStatus.Location"), System.Drawing.Point)
        Me.txtStatus.MaxLength = CType(resources.GetObject("txtStatus.MaxLength"), Integer)
        Me.txtStatus.Multiline = CType(resources.GetObject("txtStatus.Multiline"), Boolean)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = CType(resources.GetObject("txtStatus.PasswordChar"), Char)
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.RightToLeft = CType(resources.GetObject("txtStatus.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtStatus.ScrollBars = CType(resources.GetObject("txtStatus.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtStatus.Size = CType(resources.GetObject("txtStatus.Size"), System.Drawing.Size)
        Me.txtStatus.TabIndex = CType(resources.GetObject("txtStatus.TabIndex"), Integer)
        Me.txtStatus.Text = resources.GetString("txtStatus.Text")
        Me.txtStatus.TextAlign = CType(resources.GetObject("txtStatus.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtStatus.Visible = CType(resources.GetObject("txtStatus.Visible"), Boolean)
        Me.txtStatus.WordWrap = CType(resources.GetObject("txtStatus.WordWrap"), Boolean)
        '
        'confcomm
        '
        Me.confcomm.AccessibleDescription = CType(resources.GetObject("confcomm.AccessibleDescription"), String)
        Me.confcomm.AccessibleName = CType(resources.GetObject("confcomm.AccessibleName"), String)
        Me.confcomm.Anchor = CType(resources.GetObject("confcomm.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.confcomm.BackColor = System.Drawing.Color.Red
        Me.confcomm.BackgroundImage = CType(resources.GetObject("confcomm.BackgroundImage"), System.Drawing.Image)
        Me.confcomm.Dock = CType(resources.GetObject("confcomm.Dock"), System.Windows.Forms.DockStyle)
        Me.confcomm.Enabled = CType(resources.GetObject("confcomm.Enabled"), Boolean)
        Me.confcomm.FlatStyle = CType(resources.GetObject("confcomm.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.confcomm.Font = CType(resources.GetObject("confcomm.Font"), System.Drawing.Font)
        Me.confcomm.Image = CType(resources.GetObject("confcomm.Image"), System.Drawing.Image)
        Me.confcomm.ImageAlign = CType(resources.GetObject("confcomm.ImageAlign"), System.Drawing.ContentAlignment)
        Me.confcomm.ImageIndex = CType(resources.GetObject("confcomm.ImageIndex"), Integer)
        Me.confcomm.ImeMode = CType(resources.GetObject("confcomm.ImeMode"), System.Windows.Forms.ImeMode)
        Me.confcomm.Location = CType(resources.GetObject("confcomm.Location"), System.Drawing.Point)
        Me.confcomm.Name = "confcomm"
        Me.confcomm.RightToLeft = CType(resources.GetObject("confcomm.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.confcomm.Size = CType(resources.GetObject("confcomm.Size"), System.Drawing.Size)
        Me.confcomm.TabIndex = CType(resources.GetObject("confcomm.TabIndex"), Integer)
        Me.confcomm.Text = resources.GetString("confcomm.Text")
        Me.confcomm.TextAlign = CType(resources.GetObject("confcomm.TextAlign"), System.Drawing.ContentAlignment)
        Me.confcomm.Visible = CType(resources.GetObject("confcomm.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = CType(resources.GetObject("Label1.AccessibleDescription"), String)
        Me.Label1.AccessibleName = CType(resources.GetObject("Label1.AccessibleName"), String)
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'status
        '
        Me.status.AccessibleDescription = CType(resources.GetObject("status.AccessibleDescription"), String)
        Me.status.AccessibleName = CType(resources.GetObject("status.AccessibleName"), String)
        Me.status.Anchor = CType(resources.GetObject("status.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.status.AutoSize = CType(resources.GetObject("status.AutoSize"), Boolean)
        Me.status.BackColor = System.Drawing.SystemColors.Info
        Me.status.BackgroundImage = CType(resources.GetObject("status.BackgroundImage"), System.Drawing.Image)
        Me.status.Dock = CType(resources.GetObject("status.Dock"), System.Windows.Forms.DockStyle)
        Me.status.Enabled = CType(resources.GetObject("status.Enabled"), Boolean)
        Me.status.Font = CType(resources.GetObject("status.Font"), System.Drawing.Font)
        Me.status.ImeMode = CType(resources.GetObject("status.ImeMode"), System.Windows.Forms.ImeMode)
        Me.status.Location = CType(resources.GetObject("status.Location"), System.Drawing.Point)
        Me.status.MaxLength = CType(resources.GetObject("status.MaxLength"), Integer)
        Me.status.Multiline = CType(resources.GetObject("status.Multiline"), Boolean)
        Me.status.Name = "status"
        Me.status.PasswordChar = CType(resources.GetObject("status.PasswordChar"), Char)
        Me.status.ReadOnly = True
        Me.status.RightToLeft = CType(resources.GetObject("status.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.status.ScrollBars = CType(resources.GetObject("status.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.status.Size = CType(resources.GetObject("status.Size"), System.Drawing.Size)
        Me.status.TabIndex = CType(resources.GetObject("status.TabIndex"), Integer)
        Me.status.Text = resources.GetString("status.Text")
        Me.status.TextAlign = CType(resources.GetObject("status.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.status.Visible = CType(resources.GetObject("status.Visible"), Boolean)
        Me.status.WordWrap = CType(resources.GetObject("status.WordWrap"), Boolean)
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = CType(resources.GetObject("Button1.AccessibleDescription"), String)
        Me.Button1.AccessibleName = CType(resources.GetObject("Button1.AccessibleName"), String)
        Me.Button1.Anchor = CType(resources.GetObject("Button1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Dock = CType(resources.GetObject("Button1.Dock"), System.Windows.Forms.DockStyle)
        Me.Button1.Enabled = CType(resources.GetObject("Button1.Enabled"), Boolean)
        Me.Button1.FlatStyle = CType(resources.GetObject("Button1.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button1.Font = CType(resources.GetObject("Button1.Font"), System.Drawing.Font)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = CType(resources.GetObject("Button1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button1.ImageIndex = CType(resources.GetObject("Button1.ImageIndex"), Integer)
        Me.Button1.ImeMode = CType(resources.GetObject("Button1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button1.Location = CType(resources.GetObject("Button1.Location"), System.Drawing.Point)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = CType(resources.GetObject("Button1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button1.Size = CType(resources.GetObject("Button1.Size"), System.Drawing.Size)
        Me.Button1.TabIndex = CType(resources.GetObject("Button1.TabIndex"), Integer)
        Me.Button1.Text = resources.GetString("Button1.Text")
        Me.Button1.TextAlign = CType(resources.GetObject("Button1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button1.Visible = CType(resources.GetObject("Button1.Visible"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = CType(resources.GetObject("Label2.AccessibleDescription"), String)
        Me.Label2.AccessibleName = CType(resources.GetObject("Label2.AccessibleName"), String)
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleDescription = CType(resources.GetObject("TabControl1.AccessibleDescription"), String)
        Me.TabControl1.AccessibleName = CType(resources.GetObject("TabControl1.AccessibleName"), String)
        Me.TabControl1.Alignment = CType(resources.GetObject("TabControl1.Alignment"), System.Windows.Forms.TabAlignment)
        Me.TabControl1.Anchor = CType(resources.GetObject("TabControl1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = CType(resources.GetObject("TabControl1.Appearance"), System.Windows.Forms.TabAppearance)
        Me.TabControl1.BackgroundImage = CType(resources.GetObject("TabControl1.BackgroundImage"), System.Drawing.Image)
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2, Me.TabPage4, Me.TabPage3, Me.TabPage7, Me.TabPage5, Me.TabPage6})
        Me.TabControl1.Dock = CType(resources.GetObject("TabControl1.Dock"), System.Windows.Forms.DockStyle)
        Me.TabControl1.Enabled = CType(resources.GetObject("TabControl1.Enabled"), Boolean)
        Me.TabControl1.Font = CType(resources.GetObject("TabControl1.Font"), System.Drawing.Font)
        Me.TabControl1.ImeMode = CType(resources.GetObject("TabControl1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabControl1.ItemSize = CType(resources.GetObject("TabControl1.ItemSize"), System.Drawing.Size)
        Me.TabControl1.Location = CType(resources.GetObject("TabControl1.Location"), System.Drawing.Point)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = CType(resources.GetObject("TabControl1.Padding"), System.Drawing.Point)
        Me.TabControl1.RightToLeft = CType(resources.GetObject("TabControl1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = CType(resources.GetObject("TabControl1.ShowToolTips"), Boolean)
        Me.TabControl1.Size = CType(resources.GetObject("TabControl1.Size"), System.Drawing.Size)
        Me.TabControl1.TabIndex = CType(resources.GetObject("TabControl1.TabIndex"), Integer)
        Me.TabControl1.Text = resources.GetString("TabControl1.Text")
        Me.TabControl1.Visible = CType(resources.GetObject("TabControl1.Visible"), Boolean)
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleDescription = CType(resources.GetObject("TabPage1.AccessibleDescription"), String)
        Me.TabPage1.AccessibleName = CType(resources.GetObject("TabPage1.AccessibleName"), String)
        Me.TabPage1.Anchor = CType(resources.GetObject("TabPage1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage1.AutoScroll = CType(resources.GetObject("TabPage1.AutoScroll"), Boolean)
        Me.TabPage1.AutoScrollMargin = CType(resources.GetObject("TabPage1.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage1.AutoScrollMinSize = CType(resources.GetObject("TabPage1.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Bitmap)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Dock = CType(resources.GetObject("TabPage1.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage1.Enabled = CType(resources.GetObject("TabPage1.Enabled"), Boolean)
        Me.TabPage1.Font = CType(resources.GetObject("TabPage1.Font"), System.Drawing.Font)
        Me.TabPage1.ImageIndex = CType(resources.GetObject("TabPage1.ImageIndex"), Integer)
        Me.TabPage1.ImeMode = CType(resources.GetObject("TabPage1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage1.Location = CType(resources.GetObject("TabPage1.Location"), System.Drawing.Point)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.RightToLeft = CType(resources.GetObject("TabPage1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage1.Size = CType(resources.GetObject("TabPage1.Size"), System.Drawing.Size)
        Me.TabPage1.TabIndex = CType(resources.GetObject("TabPage1.TabIndex"), Integer)
        Me.TabPage1.Text = resources.GetString("TabPage1.Text")
        Me.TabPage1.ToolTipText = resources.GetString("TabPage1.ToolTipText")
        Me.TabPage1.Visible = CType(resources.GetObject("TabPage1.Visible"), Boolean)
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleDescription = CType(resources.GetObject("TabPage2.AccessibleDescription"), String)
        Me.TabPage2.AccessibleName = CType(resources.GetObject("TabPage2.AccessibleName"), String)
        Me.TabPage2.Anchor = CType(resources.GetObject("TabPage2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage2.AutoScroll = CType(resources.GetObject("TabPage2.AutoScroll"), Boolean)
        Me.TabPage2.AutoScrollMargin = CType(resources.GetObject("TabPage2.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage2.AutoScrollMinSize = CType(resources.GetObject("TabPage2.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Menu
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button18, Me.GroupBox1, Me.Label4})
        Me.TabPage2.Dock = CType(resources.GetObject("TabPage2.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage2.Enabled = CType(resources.GetObject("TabPage2.Enabled"), Boolean)
        Me.TabPage2.Font = CType(resources.GetObject("TabPage2.Font"), System.Drawing.Font)
        Me.TabPage2.ImageIndex = CType(resources.GetObject("TabPage2.ImageIndex"), Integer)
        Me.TabPage2.ImeMode = CType(resources.GetObject("TabPage2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage2.Location = CType(resources.GetObject("TabPage2.Location"), System.Drawing.Point)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.RightToLeft = CType(resources.GetObject("TabPage2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage2.Size = CType(resources.GetObject("TabPage2.Size"), System.Drawing.Size)
        Me.TabPage2.TabIndex = CType(resources.GetObject("TabPage2.TabIndex"), Integer)
        Me.TabPage2.Text = resources.GetString("TabPage2.Text")
        Me.TabPage2.ToolTipText = resources.GetString("TabPage2.ToolTipText")
        Me.TabPage2.Visible = CType(resources.GetObject("TabPage2.Visible"), Boolean)
        '
        'Button18
        '
        Me.Button18.AccessibleDescription = CType(resources.GetObject("Button18.AccessibleDescription"), String)
        Me.Button18.AccessibleName = CType(resources.GetObject("Button18.AccessibleName"), String)
        Me.Button18.Anchor = CType(resources.GetObject("Button18.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button18.BackgroundImage = CType(resources.GetObject("Button18.BackgroundImage"), System.Drawing.Image)
        Me.Button18.Dock = CType(resources.GetObject("Button18.Dock"), System.Windows.Forms.DockStyle)
        Me.Button18.Enabled = CType(resources.GetObject("Button18.Enabled"), Boolean)
        Me.Button18.FlatStyle = CType(resources.GetObject("Button18.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button18.Font = CType(resources.GetObject("Button18.Font"), System.Drawing.Font)
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.ImageAlign = CType(resources.GetObject("Button18.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button18.ImageIndex = CType(resources.GetObject("Button18.ImageIndex"), Integer)
        Me.Button18.ImeMode = CType(resources.GetObject("Button18.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button18.Location = CType(resources.GetObject("Button18.Location"), System.Drawing.Point)
        Me.Button18.Name = "Button18"
        Me.Button18.RightToLeft = CType(resources.GetObject("Button18.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button18.Size = CType(resources.GetObject("Button18.Size"), System.Drawing.Size)
        Me.Button18.TabIndex = CType(resources.GetObject("Button18.TabIndex"), Integer)
        Me.Button18.Text = resources.GetString("Button18.Text")
        Me.Button18.TextAlign = CType(resources.GetObject("Button18.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button18.Visible = CType(resources.GetObject("Button18.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = CType(resources.GetObject("GroupBox1.AccessibleDescription"), String)
        Me.GroupBox1.AccessibleName = CType(resources.GetObject("GroupBox1.AccessibleName"), String)
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label45, Me.Label44, Me.Label43, Me.Label42, Me.Label41, Me.Label40, Me.Label39, Me.Label38, Me.Label37, Me.Label36, Me.Label8, Me.Label7, Me.Label6, Me.Label5})
        Me.GroupBox1.Dock = CType(resources.GetObject("GroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox1.Enabled = CType(resources.GetObject("GroupBox1.Enabled"), Boolean)
        Me.GroupBox1.Font = CType(resources.GetObject("GroupBox1.Font"), System.Drawing.Font)
        Me.GroupBox1.ImeMode = CType(resources.GetObject("GroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox1.Location = CType(resources.GetObject("GroupBox1.Location"), System.Drawing.Point)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = CType(resources.GetObject("GroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox1.Size = CType(resources.GetObject("GroupBox1.Size"), System.Drawing.Size)
        Me.GroupBox1.TabIndex = CType(resources.GetObject("GroupBox1.TabIndex"), Integer)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'Label45
        '
        Me.Label45.AccessibleDescription = CType(resources.GetObject("Label45.AccessibleDescription"), String)
        Me.Label45.AccessibleName = CType(resources.GetObject("Label45.AccessibleName"), String)
        Me.Label45.Anchor = CType(resources.GetObject("Label45.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label45.AutoSize = CType(resources.GetObject("Label45.AutoSize"), Boolean)
        Me.Label45.Dock = CType(resources.GetObject("Label45.Dock"), System.Windows.Forms.DockStyle)
        Me.Label45.Enabled = CType(resources.GetObject("Label45.Enabled"), Boolean)
        Me.Label45.Font = CType(resources.GetObject("Label45.Font"), System.Drawing.Font)
        Me.Label45.Image = CType(resources.GetObject("Label45.Image"), System.Drawing.Image)
        Me.Label45.ImageAlign = CType(resources.GetObject("Label45.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label45.ImageIndex = CType(resources.GetObject("Label45.ImageIndex"), Integer)
        Me.Label45.ImeMode = CType(resources.GetObject("Label45.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label45.Location = CType(resources.GetObject("Label45.Location"), System.Drawing.Point)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = CType(resources.GetObject("Label45.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label45.Size = CType(resources.GetObject("Label45.Size"), System.Drawing.Size)
        Me.Label45.TabIndex = CType(resources.GetObject("Label45.TabIndex"), Integer)
        Me.Label45.Text = resources.GetString("Label45.Text")
        Me.Label45.TextAlign = CType(resources.GetObject("Label45.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label45.Visible = CType(resources.GetObject("Label45.Visible"), Boolean)
        '
        'Label44
        '
        Me.Label44.AccessibleDescription = CType(resources.GetObject("Label44.AccessibleDescription"), String)
        Me.Label44.AccessibleName = CType(resources.GetObject("Label44.AccessibleName"), String)
        Me.Label44.Anchor = CType(resources.GetObject("Label44.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = CType(resources.GetObject("Label44.AutoSize"), Boolean)
        Me.Label44.Dock = CType(resources.GetObject("Label44.Dock"), System.Windows.Forms.DockStyle)
        Me.Label44.Enabled = CType(resources.GetObject("Label44.Enabled"), Boolean)
        Me.Label44.Font = CType(resources.GetObject("Label44.Font"), System.Drawing.Font)
        Me.Label44.Image = CType(resources.GetObject("Label44.Image"), System.Drawing.Image)
        Me.Label44.ImageAlign = CType(resources.GetObject("Label44.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label44.ImageIndex = CType(resources.GetObject("Label44.ImageIndex"), Integer)
        Me.Label44.ImeMode = CType(resources.GetObject("Label44.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label44.Location = CType(resources.GetObject("Label44.Location"), System.Drawing.Point)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = CType(resources.GetObject("Label44.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label44.Size = CType(resources.GetObject("Label44.Size"), System.Drawing.Size)
        Me.Label44.TabIndex = CType(resources.GetObject("Label44.TabIndex"), Integer)
        Me.Label44.Text = resources.GetString("Label44.Text")
        Me.Label44.TextAlign = CType(resources.GetObject("Label44.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label44.Visible = CType(resources.GetObject("Label44.Visible"), Boolean)
        '
        'Label43
        '
        Me.Label43.AccessibleDescription = CType(resources.GetObject("Label43.AccessibleDescription"), String)
        Me.Label43.AccessibleName = CType(resources.GetObject("Label43.AccessibleName"), String)
        Me.Label43.Anchor = CType(resources.GetObject("Label43.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label43.AutoSize = CType(resources.GetObject("Label43.AutoSize"), Boolean)
        Me.Label43.Dock = CType(resources.GetObject("Label43.Dock"), System.Windows.Forms.DockStyle)
        Me.Label43.Enabled = CType(resources.GetObject("Label43.Enabled"), Boolean)
        Me.Label43.Font = CType(resources.GetObject("Label43.Font"), System.Drawing.Font)
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.ImageAlign = CType(resources.GetObject("Label43.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label43.ImageIndex = CType(resources.GetObject("Label43.ImageIndex"), Integer)
        Me.Label43.ImeMode = CType(resources.GetObject("Label43.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label43.Location = CType(resources.GetObject("Label43.Location"), System.Drawing.Point)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = CType(resources.GetObject("Label43.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label43.Size = CType(resources.GetObject("Label43.Size"), System.Drawing.Size)
        Me.Label43.TabIndex = CType(resources.GetObject("Label43.TabIndex"), Integer)
        Me.Label43.Text = resources.GetString("Label43.Text")
        Me.Label43.TextAlign = CType(resources.GetObject("Label43.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label43.Visible = CType(resources.GetObject("Label43.Visible"), Boolean)
        '
        'Label42
        '
        Me.Label42.AccessibleDescription = CType(resources.GetObject("Label42.AccessibleDescription"), String)
        Me.Label42.AccessibleName = CType(resources.GetObject("Label42.AccessibleName"), String)
        Me.Label42.Anchor = CType(resources.GetObject("Label42.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label42.AutoSize = CType(resources.GetObject("Label42.AutoSize"), Boolean)
        Me.Label42.Dock = CType(resources.GetObject("Label42.Dock"), System.Windows.Forms.DockStyle)
        Me.Label42.Enabled = CType(resources.GetObject("Label42.Enabled"), Boolean)
        Me.Label42.Font = CType(resources.GetObject("Label42.Font"), System.Drawing.Font)
        Me.Label42.Image = CType(resources.GetObject("Label42.Image"), System.Drawing.Image)
        Me.Label42.ImageAlign = CType(resources.GetObject("Label42.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label42.ImageIndex = CType(resources.GetObject("Label42.ImageIndex"), Integer)
        Me.Label42.ImeMode = CType(resources.GetObject("Label42.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label42.Location = CType(resources.GetObject("Label42.Location"), System.Drawing.Point)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = CType(resources.GetObject("Label42.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label42.Size = CType(resources.GetObject("Label42.Size"), System.Drawing.Size)
        Me.Label42.TabIndex = CType(resources.GetObject("Label42.TabIndex"), Integer)
        Me.Label42.Text = resources.GetString("Label42.Text")
        Me.Label42.TextAlign = CType(resources.GetObject("Label42.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label42.Visible = CType(resources.GetObject("Label42.Visible"), Boolean)
        '
        'Label41
        '
        Me.Label41.AccessibleDescription = CType(resources.GetObject("Label41.AccessibleDescription"), String)
        Me.Label41.AccessibleName = CType(resources.GetObject("Label41.AccessibleName"), String)
        Me.Label41.Anchor = CType(resources.GetObject("Label41.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = CType(resources.GetObject("Label41.AutoSize"), Boolean)
        Me.Label41.Dock = CType(resources.GetObject("Label41.Dock"), System.Windows.Forms.DockStyle)
        Me.Label41.Enabled = CType(resources.GetObject("Label41.Enabled"), Boolean)
        Me.Label41.Font = CType(resources.GetObject("Label41.Font"), System.Drawing.Font)
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.ImageAlign = CType(resources.GetObject("Label41.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label41.ImageIndex = CType(resources.GetObject("Label41.ImageIndex"), Integer)
        Me.Label41.ImeMode = CType(resources.GetObject("Label41.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label41.Location = CType(resources.GetObject("Label41.Location"), System.Drawing.Point)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = CType(resources.GetObject("Label41.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label41.Size = CType(resources.GetObject("Label41.Size"), System.Drawing.Size)
        Me.Label41.TabIndex = CType(resources.GetObject("Label41.TabIndex"), Integer)
        Me.Label41.Text = resources.GetString("Label41.Text")
        Me.Label41.TextAlign = CType(resources.GetObject("Label41.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label41.Visible = CType(resources.GetObject("Label41.Visible"), Boolean)
        '
        'Label40
        '
        Me.Label40.AccessibleDescription = CType(resources.GetObject("Label40.AccessibleDescription"), String)
        Me.Label40.AccessibleName = CType(resources.GetObject("Label40.AccessibleName"), String)
        Me.Label40.Anchor = CType(resources.GetObject("Label40.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = CType(resources.GetObject("Label40.AutoSize"), Boolean)
        Me.Label40.Dock = CType(resources.GetObject("Label40.Dock"), System.Windows.Forms.DockStyle)
        Me.Label40.Enabled = CType(resources.GetObject("Label40.Enabled"), Boolean)
        Me.Label40.Font = CType(resources.GetObject("Label40.Font"), System.Drawing.Font)
        Me.Label40.Image = CType(resources.GetObject("Label40.Image"), System.Drawing.Image)
        Me.Label40.ImageAlign = CType(resources.GetObject("Label40.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label40.ImageIndex = CType(resources.GetObject("Label40.ImageIndex"), Integer)
        Me.Label40.ImeMode = CType(resources.GetObject("Label40.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label40.Location = CType(resources.GetObject("Label40.Location"), System.Drawing.Point)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = CType(resources.GetObject("Label40.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label40.Size = CType(resources.GetObject("Label40.Size"), System.Drawing.Size)
        Me.Label40.TabIndex = CType(resources.GetObject("Label40.TabIndex"), Integer)
        Me.Label40.Text = resources.GetString("Label40.Text")
        Me.Label40.TextAlign = CType(resources.GetObject("Label40.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label40.Visible = CType(resources.GetObject("Label40.Visible"), Boolean)
        '
        'Label39
        '
        Me.Label39.AccessibleDescription = CType(resources.GetObject("Label39.AccessibleDescription"), String)
        Me.Label39.AccessibleName = CType(resources.GetObject("Label39.AccessibleName"), String)
        Me.Label39.Anchor = CType(resources.GetObject("Label39.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = CType(resources.GetObject("Label39.AutoSize"), Boolean)
        Me.Label39.Dock = CType(resources.GetObject("Label39.Dock"), System.Windows.Forms.DockStyle)
        Me.Label39.Enabled = CType(resources.GetObject("Label39.Enabled"), Boolean)
        Me.Label39.Font = CType(resources.GetObject("Label39.Font"), System.Drawing.Font)
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.ImageAlign = CType(resources.GetObject("Label39.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label39.ImageIndex = CType(resources.GetObject("Label39.ImageIndex"), Integer)
        Me.Label39.ImeMode = CType(resources.GetObject("Label39.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label39.Location = CType(resources.GetObject("Label39.Location"), System.Drawing.Point)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = CType(resources.GetObject("Label39.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label39.Size = CType(resources.GetObject("Label39.Size"), System.Drawing.Size)
        Me.Label39.TabIndex = CType(resources.GetObject("Label39.TabIndex"), Integer)
        Me.Label39.Text = resources.GetString("Label39.Text")
        Me.Label39.TextAlign = CType(resources.GetObject("Label39.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label39.Visible = CType(resources.GetObject("Label39.Visible"), Boolean)
        '
        'Label38
        '
        Me.Label38.AccessibleDescription = CType(resources.GetObject("Label38.AccessibleDescription"), String)
        Me.Label38.AccessibleName = CType(resources.GetObject("Label38.AccessibleName"), String)
        Me.Label38.Anchor = CType(resources.GetObject("Label38.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = CType(resources.GetObject("Label38.AutoSize"), Boolean)
        Me.Label38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgOfficeFax"))
        Me.Label38.Dock = CType(resources.GetObject("Label38.Dock"), System.Windows.Forms.DockStyle)
        Me.Label38.Enabled = CType(resources.GetObject("Label38.Enabled"), Boolean)
        Me.Label38.Font = CType(resources.GetObject("Label38.Font"), System.Drawing.Font)
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.ImageAlign = CType(resources.GetObject("Label38.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label38.ImageIndex = CType(resources.GetObject("Label38.ImageIndex"), Integer)
        Me.Label38.ImeMode = CType(resources.GetObject("Label38.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label38.Location = CType(resources.GetObject("Label38.Location"), System.Drawing.Point)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = CType(resources.GetObject("Label38.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label38.Size = CType(resources.GetObject("Label38.Size"), System.Drawing.Size)
        Me.Label38.TabIndex = CType(resources.GetObject("Label38.TabIndex"), Integer)
        Me.Label38.Text = resources.GetString("Label38.Text")
        Me.Label38.TextAlign = CType(resources.GetObject("Label38.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label38.Visible = CType(resources.GetObject("Label38.Visible"), Boolean)
        '
        'DsRpt
        '
        Me.DsRpt.DataSetName = "dsRpt"
        Me.DsRpt.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsRpt.Namespace = "http://www.tempuri.org/dsRpt.xsd"
        '
        'Label37
        '
        Me.Label37.AccessibleDescription = CType(resources.GetObject("Label37.AccessibleDescription"), String)
        Me.Label37.AccessibleName = CType(resources.GetObject("Label37.AccessibleName"), String)
        Me.Label37.Anchor = CType(resources.GetObject("Label37.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = CType(resources.GetObject("Label37.AutoSize"), Boolean)
        Me.Label37.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgOfficePhone"))
        Me.Label37.Dock = CType(resources.GetObject("Label37.Dock"), System.Windows.Forms.DockStyle)
        Me.Label37.Enabled = CType(resources.GetObject("Label37.Enabled"), Boolean)
        Me.Label37.Font = CType(resources.GetObject("Label37.Font"), System.Drawing.Font)
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.ImageAlign = CType(resources.GetObject("Label37.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label37.ImageIndex = CType(resources.GetObject("Label37.ImageIndex"), Integer)
        Me.Label37.ImeMode = CType(resources.GetObject("Label37.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label37.Location = CType(resources.GetObject("Label37.Location"), System.Drawing.Point)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = CType(resources.GetObject("Label37.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label37.Size = CType(resources.GetObject("Label37.Size"), System.Drawing.Size)
        Me.Label37.TabIndex = CType(resources.GetObject("Label37.TabIndex"), Integer)
        Me.Label37.Text = resources.GetString("Label37.Text")
        Me.Label37.TextAlign = CType(resources.GetObject("Label37.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label37.Visible = CType(resources.GetObject("Label37.Visible"), Boolean)
        '
        'Label36
        '
        Me.Label36.AccessibleDescription = CType(resources.GetObject("Label36.AccessibleDescription"), String)
        Me.Label36.AccessibleName = CType(resources.GetObject("Label36.AccessibleName"), String)
        Me.Label36.Anchor = CType(resources.GetObject("Label36.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = CType(resources.GetObject("Label36.AutoSize"), Boolean)
        Me.Label36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgZipCode"))
        Me.Label36.Dock = CType(resources.GetObject("Label36.Dock"), System.Windows.Forms.DockStyle)
        Me.Label36.Enabled = CType(resources.GetObject("Label36.Enabled"), Boolean)
        Me.Label36.Font = CType(resources.GetObject("Label36.Font"), System.Drawing.Font)
        Me.Label36.Image = CType(resources.GetObject("Label36.Image"), System.Drawing.Image)
        Me.Label36.ImageAlign = CType(resources.GetObject("Label36.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label36.ImageIndex = CType(resources.GetObject("Label36.ImageIndex"), Integer)
        Me.Label36.ImeMode = CType(resources.GetObject("Label36.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label36.Location = CType(resources.GetObject("Label36.Location"), System.Drawing.Point)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = CType(resources.GetObject("Label36.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label36.Size = CType(resources.GetObject("Label36.Size"), System.Drawing.Size)
        Me.Label36.TabIndex = CType(resources.GetObject("Label36.TabIndex"), Integer)
        Me.Label36.Text = resources.GetString("Label36.Text")
        Me.Label36.TextAlign = CType(resources.GetObject("Label36.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label36.Visible = CType(resources.GetObject("Label36.Visible"), Boolean)
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = CType(resources.GetObject("Label8.AccessibleDescription"), String)
        Me.Label8.AccessibleName = CType(resources.GetObject("Label8.AccessibleName"), String)
        Me.Label8.Anchor = CType(resources.GetObject("Label8.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = CType(resources.GetObject("Label8.AutoSize"), Boolean)
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgState"))
        Me.Label8.Dock = CType(resources.GetObject("Label8.Dock"), System.Windows.Forms.DockStyle)
        Me.Label8.Enabled = CType(resources.GetObject("Label8.Enabled"), Boolean)
        Me.Label8.Font = CType(resources.GetObject("Label8.Font"), System.Drawing.Font)
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = CType(resources.GetObject("Label8.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label8.ImageIndex = CType(resources.GetObject("Label8.ImageIndex"), Integer)
        Me.Label8.ImeMode = CType(resources.GetObject("Label8.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label8.Location = CType(resources.GetObject("Label8.Location"), System.Drawing.Point)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = CType(resources.GetObject("Label8.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label8.Size = CType(resources.GetObject("Label8.Size"), System.Drawing.Size)
        Me.Label8.TabIndex = CType(resources.GetObject("Label8.TabIndex"), Integer)
        Me.Label8.Text = resources.GetString("Label8.Text")
        Me.Label8.TextAlign = CType(resources.GetObject("Label8.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label8.Visible = CType(resources.GetObject("Label8.Visible"), Boolean)
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = CType(resources.GetObject("Label7.AccessibleDescription"), String)
        Me.Label7.AccessibleName = CType(resources.GetObject("Label7.AccessibleName"), String)
        Me.Label7.Anchor = CType(resources.GetObject("Label7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = CType(resources.GetObject("Label7.AutoSize"), Boolean)
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgCity"))
        Me.Label7.Dock = CType(resources.GetObject("Label7.Dock"), System.Windows.Forms.DockStyle)
        Me.Label7.Enabled = CType(resources.GetObject("Label7.Enabled"), Boolean)
        Me.Label7.Font = CType(resources.GetObject("Label7.Font"), System.Drawing.Font)
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = CType(resources.GetObject("Label7.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label7.ImageIndex = CType(resources.GetObject("Label7.ImageIndex"), Integer)
        Me.Label7.ImeMode = CType(resources.GetObject("Label7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label7.Location = CType(resources.GetObject("Label7.Location"), System.Drawing.Point)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = CType(resources.GetObject("Label7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label7.Size = CType(resources.GetObject("Label7.Size"), System.Drawing.Size)
        Me.Label7.TabIndex = CType(resources.GetObject("Label7.TabIndex"), Integer)
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = CType(resources.GetObject("Label7.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label7.Visible = CType(resources.GetObject("Label7.Visible"), Boolean)
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = CType(resources.GetObject("Label6.AccessibleDescription"), String)
        Me.Label6.AccessibleName = CType(resources.GetObject("Label6.AccessibleName"), String)
        Me.Label6.Anchor = CType(resources.GetObject("Label6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = CType(resources.GetObject("Label6.AutoSize"), Boolean)
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgAddress"))
        Me.Label6.Dock = CType(resources.GetObject("Label6.Dock"), System.Windows.Forms.DockStyle)
        Me.Label6.Enabled = CType(resources.GetObject("Label6.Enabled"), Boolean)
        Me.Label6.Font = CType(resources.GetObject("Label6.Font"), System.Drawing.Font)
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = CType(resources.GetObject("Label6.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label6.ImageIndex = CType(resources.GetObject("Label6.ImageIndex"), Integer)
        Me.Label6.ImeMode = CType(resources.GetObject("Label6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label6.Location = CType(resources.GetObject("Label6.Location"), System.Drawing.Point)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = CType(resources.GetObject("Label6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label6.Size = CType(resources.GetObject("Label6.Size"), System.Drawing.Size)
        Me.Label6.TabIndex = CType(resources.GetObject("Label6.TabIndex"), Integer)
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = CType(resources.GetObject("Label6.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label6.Visible = CType(resources.GetObject("Label6.Visible"), Boolean)
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = CType(resources.GetObject("Label5.AccessibleDescription"), String)
        Me.Label5.AccessibleName = CType(resources.GetObject("Label5.AccessibleName"), String)
        Me.Label5.Anchor = CType(resources.GetObject("Label5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = CType(resources.GetObject("Label5.AutoSize"), Boolean)
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsRpt, "CrystalReportsRptData.OrgName"))
        Me.Label5.Dock = CType(resources.GetObject("Label5.Dock"), System.Windows.Forms.DockStyle)
        Me.Label5.Enabled = CType(resources.GetObject("Label5.Enabled"), Boolean)
        Me.Label5.Font = CType(resources.GetObject("Label5.Font"), System.Drawing.Font)
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = CType(resources.GetObject("Label5.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label5.ImageIndex = CType(resources.GetObject("Label5.ImageIndex"), Integer)
        Me.Label5.ImeMode = CType(resources.GetObject("Label5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label5.Location = CType(resources.GetObject("Label5.Location"), System.Drawing.Point)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = CType(resources.GetObject("Label5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label5.Size = CType(resources.GetObject("Label5.Size"), System.Drawing.Size)
        Me.Label5.TabIndex = CType(resources.GetObject("Label5.TabIndex"), Integer)
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = CType(resources.GetObject("Label5.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label5.Visible = CType(resources.GetObject("Label5.Visible"), Boolean)
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = CType(resources.GetObject("Label4.AccessibleDescription"), String)
        Me.Label4.AccessibleName = CType(resources.GetObject("Label4.AccessibleName"), String)
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = CType(resources.GetObject("Label4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label4.ImageIndex = CType(resources.GetObject("Label4.ImageIndex"), Integer)
        Me.Label4.ImeMode = CType(resources.GetObject("Label4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label4.Location = CType(resources.GetObject("Label4.Location"), System.Drawing.Point)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = CType(resources.GetObject("Label4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label4.Size = CType(resources.GetObject("Label4.Size"), System.Drawing.Size)
        Me.Label4.TabIndex = CType(resources.GetObject("Label4.TabIndex"), Integer)
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = CType(resources.GetObject("Label4.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
        '
        'TabPage4
        '
        Me.TabPage4.AccessibleDescription = CType(resources.GetObject("TabPage4.AccessibleDescription"), String)
        Me.TabPage4.AccessibleName = CType(resources.GetObject("TabPage4.AccessibleName"), String)
        Me.TabPage4.Anchor = CType(resources.GetObject("TabPage4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage4.AutoScroll = CType(resources.GetObject("TabPage4.AutoScroll"), Boolean)
        Me.TabPage4.AutoScrollMargin = CType(resources.GetObject("TabPage4.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage4.AutoScrollMinSize = CType(resources.GetObject("TabPage4.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Menu
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2})
        Me.TabPage4.Dock = CType(resources.GetObject("TabPage4.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage4.Enabled = CType(resources.GetObject("TabPage4.Enabled"), Boolean)
        Me.TabPage4.Font = CType(resources.GetObject("TabPage4.Font"), System.Drawing.Font)
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TabPage4.ImageIndex = CType(resources.GetObject("TabPage4.ImageIndex"), Integer)
        Me.TabPage4.ImeMode = CType(resources.GetObject("TabPage4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage4.Location = CType(resources.GetObject("TabPage4.Location"), System.Drawing.Point)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.RightToLeft = CType(resources.GetObject("TabPage4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage4.Size = CType(resources.GetObject("TabPage4.Size"), System.Drawing.Size)
        Me.TabPage4.TabIndex = CType(resources.GetObject("TabPage4.TabIndex"), Integer)
        Me.TabPage4.Text = resources.GetString("TabPage4.Text")
        Me.TabPage4.ToolTipText = resources.GetString("TabPage4.ToolTipText")
        Me.TabPage4.Visible = CType(resources.GetObject("TabPage4.Visible"), Boolean)
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = CType(resources.GetObject("GroupBox3.AccessibleDescription"), String)
        Me.GroupBox3.AccessibleName = CType(resources.GetObject("GroupBox3.AccessibleName"), String)
        Me.GroupBox3.Anchor = CType(resources.GetObject("GroupBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label35, Me.TextBox7, Me.Label1, Me.Button1, Me.TextBox6, Me.Button11})
        Me.GroupBox3.Dock = CType(resources.GetObject("GroupBox3.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox3.Enabled = CType(resources.GetObject("GroupBox3.Enabled"), Boolean)
        Me.GroupBox3.Font = CType(resources.GetObject("GroupBox3.Font"), System.Drawing.Font)
        Me.GroupBox3.ImeMode = CType(resources.GetObject("GroupBox3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox3.Location = CType(resources.GetObject("GroupBox3.Location"), System.Drawing.Point)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = CType(resources.GetObject("GroupBox3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox3.Size = CType(resources.GetObject("GroupBox3.Size"), System.Drawing.Size)
        Me.GroupBox3.TabIndex = CType(resources.GetObject("GroupBox3.TabIndex"), Integer)
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = resources.GetString("GroupBox3.Text")
        Me.GroupBox3.Visible = CType(resources.GetObject("GroupBox3.Visible"), Boolean)
        '
        'Label35
        '
        Me.Label35.AccessibleDescription = CType(resources.GetObject("Label35.AccessibleDescription"), String)
        Me.Label35.AccessibleName = CType(resources.GetObject("Label35.AccessibleName"), String)
        Me.Label35.Anchor = CType(resources.GetObject("Label35.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = CType(resources.GetObject("Label35.AutoSize"), Boolean)
        Me.Label35.Dock = CType(resources.GetObject("Label35.Dock"), System.Windows.Forms.DockStyle)
        Me.Label35.Enabled = CType(resources.GetObject("Label35.Enabled"), Boolean)
        Me.Label35.Font = CType(resources.GetObject("Label35.Font"), System.Drawing.Font)
        Me.Label35.Image = CType(resources.GetObject("Label35.Image"), System.Drawing.Image)
        Me.Label35.ImageAlign = CType(resources.GetObject("Label35.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label35.ImageIndex = CType(resources.GetObject("Label35.ImageIndex"), Integer)
        Me.Label35.ImeMode = CType(resources.GetObject("Label35.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label35.Location = CType(resources.GetObject("Label35.Location"), System.Drawing.Point)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = CType(resources.GetObject("Label35.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label35.Size = CType(resources.GetObject("Label35.Size"), System.Drawing.Size)
        Me.Label35.TabIndex = CType(resources.GetObject("Label35.TabIndex"), Integer)
        Me.Label35.Text = resources.GetString("Label35.Text")
        Me.Label35.TextAlign = CType(resources.GetObject("Label35.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label35.Visible = CType(resources.GetObject("Label35.Visible"), Boolean)
        '
        'TextBox7
        '
        Me.TextBox7.AccessibleDescription = CType(resources.GetObject("TextBox7.AccessibleDescription"), String)
        Me.TextBox7.AccessibleName = CType(resources.GetObject("TextBox7.AccessibleName"), String)
        Me.TextBox7.Anchor = CType(resources.GetObject("TextBox7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.AutoSize = CType(resources.GetObject("TextBox7.AutoSize"), Boolean)
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox7.BackgroundImage = CType(resources.GetObject("TextBox7.BackgroundImage"), System.Drawing.Image)
        Me.TextBox7.Dock = CType(resources.GetObject("TextBox7.Dock"), System.Windows.Forms.DockStyle)
        Me.TextBox7.Enabled = CType(resources.GetObject("TextBox7.Enabled"), Boolean)
        Me.TextBox7.Font = CType(resources.GetObject("TextBox7.Font"), System.Drawing.Font)
        Me.TextBox7.ImeMode = CType(resources.GetObject("TextBox7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TextBox7.Location = CType(resources.GetObject("TextBox7.Location"), System.Drawing.Point)
        Me.TextBox7.MaxLength = CType(resources.GetObject("TextBox7.MaxLength"), Integer)
        Me.TextBox7.Multiline = CType(resources.GetObject("TextBox7.Multiline"), Boolean)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = CType(resources.GetObject("TextBox7.PasswordChar"), Char)
        Me.TextBox7.RightToLeft = CType(resources.GetObject("TextBox7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TextBox7.ScrollBars = CType(resources.GetObject("TextBox7.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TextBox7.Size = CType(resources.GetObject("TextBox7.Size"), System.Drawing.Size)
        Me.TextBox7.TabIndex = CType(resources.GetObject("TextBox7.TabIndex"), Integer)
        Me.TextBox7.Text = resources.GetString("TextBox7.Text")
        Me.TextBox7.TextAlign = CType(resources.GetObject("TextBox7.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TextBox7.Visible = CType(resources.GetObject("TextBox7.Visible"), Boolean)
        Me.TextBox7.WordWrap = CType(resources.GetObject("TextBox7.WordWrap"), Boolean)
        '
        'TextBox6
        '
        Me.TextBox6.AccessibleDescription = CType(resources.GetObject("TextBox6.AccessibleDescription"), String)
        Me.TextBox6.AccessibleName = CType(resources.GetObject("TextBox6.AccessibleName"), String)
        Me.TextBox6.Anchor = CType(resources.GetObject("TextBox6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.AutoSize = CType(resources.GetObject("TextBox6.AutoSize"), Boolean)
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox6.BackgroundImage = CType(resources.GetObject("TextBox6.BackgroundImage"), System.Drawing.Image)
        Me.TextBox6.Dock = CType(resources.GetObject("TextBox6.Dock"), System.Windows.Forms.DockStyle)
        Me.TextBox6.Enabled = CType(resources.GetObject("TextBox6.Enabled"), Boolean)
        Me.TextBox6.Font = CType(resources.GetObject("TextBox6.Font"), System.Drawing.Font)
        Me.TextBox6.ImeMode = CType(resources.GetObject("TextBox6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TextBox6.Location = CType(resources.GetObject("TextBox6.Location"), System.Drawing.Point)
        Me.TextBox6.MaxLength = CType(resources.GetObject("TextBox6.MaxLength"), Integer)
        Me.TextBox6.Multiline = CType(resources.GetObject("TextBox6.Multiline"), Boolean)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = CType(resources.GetObject("TextBox6.PasswordChar"), Char)
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.RightToLeft = CType(resources.GetObject("TextBox6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TextBox6.ScrollBars = CType(resources.GetObject("TextBox6.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TextBox6.Size = CType(resources.GetObject("TextBox6.Size"), System.Drawing.Size)
        Me.TextBox6.TabIndex = CType(resources.GetObject("TextBox6.TabIndex"), Integer)
        Me.TextBox6.Text = resources.GetString("TextBox6.Text")
        Me.TextBox6.TextAlign = CType(resources.GetObject("TextBox6.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TextBox6.Visible = CType(resources.GetObject("TextBox6.Visible"), Boolean)
        Me.TextBox6.WordWrap = CType(resources.GetObject("TextBox6.WordWrap"), Boolean)
        '
        'Button11
        '
        Me.Button11.AccessibleDescription = CType(resources.GetObject("Button11.AccessibleDescription"), String)
        Me.Button11.AccessibleName = CType(resources.GetObject("Button11.AccessibleName"), String)
        Me.Button11.Anchor = CType(resources.GetObject("Button11.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.Dock = CType(resources.GetObject("Button11.Dock"), System.Windows.Forms.DockStyle)
        Me.Button11.Enabled = CType(resources.GetObject("Button11.Enabled"), Boolean)
        Me.Button11.FlatStyle = CType(resources.GetObject("Button11.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button11.Font = CType(resources.GetObject("Button11.Font"), System.Drawing.Font)
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = CType(resources.GetObject("Button11.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button11.ImageIndex = CType(resources.GetObject("Button11.ImageIndex"), Integer)
        Me.Button11.ImeMode = CType(resources.GetObject("Button11.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button11.Location = CType(resources.GetObject("Button11.Location"), System.Drawing.Point)
        Me.Button11.Name = "Button11"
        Me.Button11.RightToLeft = CType(resources.GetObject("Button11.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button11.Size = CType(resources.GetObject("Button11.Size"), System.Drawing.Size)
        Me.Button11.TabIndex = CType(resources.GetObject("Button11.TabIndex"), Integer)
        Me.Button11.Text = resources.GetString("Button11.Text")
        Me.Button11.TextAlign = CType(resources.GetObject("Button11.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button11.Visible = CType(resources.GetObject("Button11.Visible"), Boolean)
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = CType(resources.GetObject("GroupBox2.AccessibleDescription"), String)
        Me.GroupBox2.AccessibleName = CType(resources.GetObject("GroupBox2.AccessibleName"), String)
        Me.GroupBox2.Anchor = CType(resources.GetObject("GroupBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.status, Me.confcomm, Me.txtStatus})
        Me.GroupBox2.Dock = CType(resources.GetObject("GroupBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox2.Enabled = CType(resources.GetObject("GroupBox2.Enabled"), Boolean)
        Me.GroupBox2.Font = CType(resources.GetObject("GroupBox2.Font"), System.Drawing.Font)
        Me.GroupBox2.ImeMode = CType(resources.GetObject("GroupBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox2.Location = CType(resources.GetObject("GroupBox2.Location"), System.Drawing.Point)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = CType(resources.GetObject("GroupBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox2.Size = CType(resources.GetObject("GroupBox2.Size"), System.Drawing.Size)
        Me.GroupBox2.TabIndex = CType(resources.GetObject("GroupBox2.TabIndex"), Integer)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = resources.GetString("GroupBox2.Text")
        Me.GroupBox2.Visible = CType(resources.GetObject("GroupBox2.Visible"), Boolean)
        '
        'TabPage3
        '
        Me.TabPage3.AccessibleDescription = CType(resources.GetObject("TabPage3.AccessibleDescription"), String)
        Me.TabPage3.AccessibleName = CType(resources.GetObject("TabPage3.AccessibleName"), String)
        Me.TabPage3.Anchor = CType(resources.GetObject("TabPage3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage3.AutoScroll = CType(resources.GetObject("TabPage3.AutoScroll"), Boolean)
        Me.TabPage3.AutoScrollMargin = CType(resources.GetObject("TabPage3.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage3.AutoScrollMinSize = CType(resources.GetObject("TabPage3.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Menu
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label46, Me.Button7, Me.DataGrid1, Me.Button2, Me.Label9, Me.Label3, Me.ListBox1})
        Me.TabPage3.Dock = CType(resources.GetObject("TabPage3.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage3.Enabled = CType(resources.GetObject("TabPage3.Enabled"), Boolean)
        Me.TabPage3.Font = CType(resources.GetObject("TabPage3.Font"), System.Drawing.Font)
        Me.TabPage3.ImageIndex = CType(resources.GetObject("TabPage3.ImageIndex"), Integer)
        Me.TabPage3.ImeMode = CType(resources.GetObject("TabPage3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage3.Location = CType(resources.GetObject("TabPage3.Location"), System.Drawing.Point)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.RightToLeft = CType(resources.GetObject("TabPage3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage3.Size = CType(resources.GetObject("TabPage3.Size"), System.Drawing.Size)
        Me.TabPage3.TabIndex = CType(resources.GetObject("TabPage3.TabIndex"), Integer)
        Me.TabPage3.Text = resources.GetString("TabPage3.Text")
        Me.TabPage3.ToolTipText = resources.GetString("TabPage3.ToolTipText")
        Me.TabPage3.Visible = CType(resources.GetObject("TabPage3.Visible"), Boolean)
        '
        'Label46
        '
        Me.Label46.AccessibleDescription = CType(resources.GetObject("Label46.AccessibleDescription"), String)
        Me.Label46.AccessibleName = CType(resources.GetObject("Label46.AccessibleName"), String)
        Me.Label46.Anchor = CType(resources.GetObject("Label46.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label46.AutoSize = CType(resources.GetObject("Label46.AutoSize"), Boolean)
        Me.Label46.Dock = CType(resources.GetObject("Label46.Dock"), System.Windows.Forms.DockStyle)
        Me.Label46.Enabled = CType(resources.GetObject("Label46.Enabled"), Boolean)
        Me.Label46.Font = CType(resources.GetObject("Label46.Font"), System.Drawing.Font)
        Me.Label46.Image = CType(resources.GetObject("Label46.Image"), System.Drawing.Image)
        Me.Label46.ImageAlign = CType(resources.GetObject("Label46.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label46.ImageIndex = CType(resources.GetObject("Label46.ImageIndex"), Integer)
        Me.Label46.ImeMode = CType(resources.GetObject("Label46.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label46.Location = CType(resources.GetObject("Label46.Location"), System.Drawing.Point)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = CType(resources.GetObject("Label46.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label46.Size = CType(resources.GetObject("Label46.Size"), System.Drawing.Size)
        Me.Label46.TabIndex = CType(resources.GetObject("Label46.TabIndex"), Integer)
        Me.Label46.Text = resources.GetString("Label46.Text")
        Me.Label46.TextAlign = CType(resources.GetObject("Label46.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label46.Visible = CType(resources.GetObject("Label46.Visible"), Boolean)
        '
        'Button7
        '
        Me.Button7.AccessibleDescription = CType(resources.GetObject("Button7.AccessibleDescription"), String)
        Me.Button7.AccessibleName = CType(resources.GetObject("Button7.AccessibleName"), String)
        Me.Button7.Anchor = CType(resources.GetObject("Button7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.Dock = CType(resources.GetObject("Button7.Dock"), System.Windows.Forms.DockStyle)
        Me.Button7.Enabled = CType(resources.GetObject("Button7.Enabled"), Boolean)
        Me.Button7.FlatStyle = CType(resources.GetObject("Button7.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button7.Font = CType(resources.GetObject("Button7.Font"), System.Drawing.Font)
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = CType(resources.GetObject("Button7.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button7.ImageIndex = CType(resources.GetObject("Button7.ImageIndex"), Integer)
        Me.Button7.ImeMode = CType(resources.GetObject("Button7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button7.Location = CType(resources.GetObject("Button7.Location"), System.Drawing.Point)
        Me.Button7.Name = "Button7"
        Me.Button7.RightToLeft = CType(resources.GetObject("Button7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button7.Size = CType(resources.GetObject("Button7.Size"), System.Drawing.Size)
        Me.Button7.TabIndex = CType(resources.GetObject("Button7.TabIndex"), Integer)
        Me.Button7.Text = resources.GetString("Button7.Text")
        Me.Button7.TextAlign = CType(resources.GetObject("Button7.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button7.Visible = CType(resources.GetObject("Button7.Visible"), Boolean)
        '
        'DataGrid1
        '
        Me.DataGrid1.AccessibleDescription = CType(resources.GetObject("DataGrid1.AccessibleDescription"), String)
        Me.DataGrid1.AccessibleName = CType(resources.GetObject("DataGrid1.AccessibleName"), String)
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.DataGrid1.Anchor = CType(resources.GetObject("DataGrid1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.BackgroundImage = CType(resources.GetObject("DataGrid1.BackgroundImage"), System.Drawing.Image)
        Me.DataGrid1.CaptionFont = CType(resources.GetObject("DataGrid1.CaptionFont"), System.Drawing.Font)
        Me.DataGrid1.CaptionText = resources.GetString("DataGrid1.CaptionText")
        Me.DataGrid1.DataMember = "Patients"
        Me.DataGrid1.DataSource = Me.DsPatientsForm1
        Me.DataGrid1.Dock = CType(resources.GetObject("DataGrid1.Dock"), System.Windows.Forms.DockStyle)
        Me.DataGrid1.Enabled = CType(resources.GetObject("DataGrid1.Enabled"), Boolean)
        Me.DataGrid1.Font = CType(resources.GetObject("DataGrid1.Font"), System.Drawing.Font)
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.ImeMode = CType(resources.GetObject("DataGrid1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.DataGrid1.Location = CType(resources.GetObject("DataGrid1.Location"), System.Drawing.Point)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RightToLeft = CType(resources.GetObject("DataGrid1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.DataGrid1.Size = CType(resources.GetObject("DataGrid1.Size"), System.Drawing.Size)
        Me.DataGrid1.TabIndex = CType(resources.GetObject("DataGrid1.TabIndex"), Integer)
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = ""
        Me.DataGrid1.Visible = CType(resources.GetObject("DataGrid1.Visible"), Boolean)
        '
        'DsPatientsForm1
        '
        Me.DsPatientsForm1.DataSetName = "dsPatientsForm1"
        Me.DsPatientsForm1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsPatientsForm1.Namespace = "http://www.tempuri.org/dsPatientsForm1.xsd"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle1.HeaderFont = CType(resources.GetObject("DataGridTableStyle1.HeaderFont"), System.Drawing.Font)
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Patients"
        Me.DataGridTableStyle1.PreferredColumnWidth = CType(resources.GetObject("DataGridTableStyle1.PreferredColumnWidth"), Integer)
        Me.DataGridTableStyle1.PreferredRowHeight = CType(resources.GetObject("DataGridTableStyle1.PreferredRowHeight"), Integer)
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeaderWidth = CType(resources.GetObject("DataGridTableStyle1.RowHeaderWidth"), Integer)
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = CType(resources.GetObject("DataGridTextBoxColumn1.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn1.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn1.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn1.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn1.NullText = resources.GetString("DataGridTextBoxColumn1.NullText")
        Me.DataGridTextBoxColumn1.Width = CType(resources.GetObject("DataGridTextBoxColumn1.Width"), Integer)
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = CType(resources.GetObject("DataGridTextBoxColumn2.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn2.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn2.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn2.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn2.NullText = resources.GetString("DataGridTextBoxColumn2.NullText")
        Me.DataGridTextBoxColumn2.Width = CType(resources.GetObject("DataGridTextBoxColumn2.Width"), Integer)
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = CType(resources.GetObject("DataGridTextBoxColumn3.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn3.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn3.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn3.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn3.NullText = resources.GetString("DataGridTextBoxColumn3.NullText")
        Me.DataGridTextBoxColumn3.Width = CType(resources.GetObject("DataGridTextBoxColumn3.Width"), Integer)
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = CType(resources.GetObject("DataGridTextBoxColumn4.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn4.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn4.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn4.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn4.NullText = resources.GetString("DataGridTextBoxColumn4.NullText")
        Me.DataGridTextBoxColumn4.Width = CType(resources.GetObject("DataGridTextBoxColumn4.Width"), Integer)
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = CType(resources.GetObject("DataGridTextBoxColumn5.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn5.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn5.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn5.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn5.NullText = resources.GetString("DataGridTextBoxColumn5.NullText")
        Me.DataGridTextBoxColumn5.Width = CType(resources.GetObject("DataGridTextBoxColumn5.Width"), Integer)
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = CType(resources.GetObject("DataGridTextBoxColumn6.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn6.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn6.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn6.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn6.NullText = resources.GetString("DataGridTextBoxColumn6.NullText")
        Me.DataGridTextBoxColumn6.Width = CType(resources.GetObject("DataGridTextBoxColumn6.Width"), Integer)
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = CType(resources.GetObject("DataGridTextBoxColumn7.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn7.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn7.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn7.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn7.NullText = resources.GetString("DataGridTextBoxColumn7.NullText")
        Me.DataGridTextBoxColumn7.Width = CType(resources.GetObject("DataGridTextBoxColumn7.Width"), Integer)
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = CType(resources.GetObject("DataGridTextBoxColumn8.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn8.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn8.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn8.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn8.NullText = resources.GetString("DataGridTextBoxColumn8.NullText")
        Me.DataGridTextBoxColumn8.Width = CType(resources.GetObject("DataGridTextBoxColumn8.Width"), Integer)
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = CType(resources.GetObject("DataGridTextBoxColumn9.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn9.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn9.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn9.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn9.NullText = resources.GetString("DataGridTextBoxColumn9.NullText")
        Me.DataGridTextBoxColumn9.Width = CType(resources.GetObject("DataGridTextBoxColumn9.Width"), Integer)
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = CType(resources.GetObject("DataGridTextBoxColumn10.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn10.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn10.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn10.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn10.NullText = resources.GetString("DataGridTextBoxColumn10.NullText")
        Me.DataGridTextBoxColumn10.Width = CType(resources.GetObject("DataGridTextBoxColumn10.Width"), Integer)
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = CType(resources.GetObject("DataGridTextBoxColumn11.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn11.HeaderText", GetType(System.String)), String)
        Me.DataGridTextBoxColumn11.MappingName = CType(configurationAppSettings.GetValue("DataGridTextBoxColumn11.MappingName", GetType(System.String)), String)
        Me.DataGridTextBoxColumn11.NullText = resources.GetString("DataGridTextBoxColumn11.NullText")
        Me.DataGridTextBoxColumn11.Width = CType(resources.GetObject("DataGridTextBoxColumn11.Width"), Integer)
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = CType(resources.GetObject("Button2.AccessibleDescription"), String)
        Me.Button2.AccessibleName = CType(resources.GetObject("Button2.AccessibleName"), String)
        Me.Button2.Anchor = CType(resources.GetObject("Button2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Dock = CType(resources.GetObject("Button2.Dock"), System.Windows.Forms.DockStyle)
        Me.Button2.Enabled = CType(resources.GetObject("Button2.Enabled"), Boolean)
        Me.Button2.FlatStyle = CType(resources.GetObject("Button2.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button2.Font = CType(resources.GetObject("Button2.Font"), System.Drawing.Font)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = CType(resources.GetObject("Button2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button2.ImageIndex = CType(resources.GetObject("Button2.ImageIndex"), Integer)
        Me.Button2.ImeMode = CType(resources.GetObject("Button2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button2.Location = CType(resources.GetObject("Button2.Location"), System.Drawing.Point)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = CType(resources.GetObject("Button2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button2.Size = CType(resources.GetObject("Button2.Size"), System.Drawing.Size)
        Me.Button2.TabIndex = CType(resources.GetObject("Button2.TabIndex"), Integer)
        Me.Button2.Text = resources.GetString("Button2.Text")
        Me.Button2.TextAlign = CType(resources.GetObject("Button2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button2.Visible = CType(resources.GetObject("Button2.Visible"), Boolean)
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = CType(resources.GetObject("Label9.AccessibleDescription"), String)
        Me.Label9.AccessibleName = CType(resources.GetObject("Label9.AccessibleName"), String)
        Me.Label9.Anchor = CType(resources.GetObject("Label9.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = CType(resources.GetObject("Label9.AutoSize"), Boolean)
        Me.Label9.Dock = CType(resources.GetObject("Label9.Dock"), System.Windows.Forms.DockStyle)
        Me.Label9.Enabled = CType(resources.GetObject("Label9.Enabled"), Boolean)
        Me.Label9.Font = CType(resources.GetObject("Label9.Font"), System.Drawing.Font)
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = CType(resources.GetObject("Label9.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label9.ImageIndex = CType(resources.GetObject("Label9.ImageIndex"), Integer)
        Me.Label9.ImeMode = CType(resources.GetObject("Label9.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label9.Location = CType(resources.GetObject("Label9.Location"), System.Drawing.Point)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = CType(resources.GetObject("Label9.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label9.Size = CType(resources.GetObject("Label9.Size"), System.Drawing.Size)
        Me.Label9.TabIndex = CType(resources.GetObject("Label9.TabIndex"), Integer)
        Me.Label9.Text = resources.GetString("Label9.Text")
        Me.Label9.TextAlign = CType(resources.GetObject("Label9.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label9.Visible = CType(resources.GetObject("Label9.Visible"), Boolean)
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = CType(resources.GetObject("Label3.AccessibleDescription"), String)
        Me.Label3.AccessibleName = CType(resources.GetObject("Label3.AccessibleName"), String)
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.Dock = CType(resources.GetObject("Label3.Dock"), System.Windows.Forms.DockStyle)
        Me.Label3.Enabled = CType(resources.GetObject("Label3.Enabled"), Boolean)
        Me.Label3.Font = CType(resources.GetObject("Label3.Font"), System.Drawing.Font)
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = CType(resources.GetObject("Label3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label3.ImageIndex = CType(resources.GetObject("Label3.ImageIndex"), Integer)
        Me.Label3.ImeMode = CType(resources.GetObject("Label3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label3.Location = CType(resources.GetObject("Label3.Location"), System.Drawing.Point)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = CType(resources.GetObject("Label3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label3.Size = CType(resources.GetObject("Label3.Size"), System.Drawing.Size)
        Me.Label3.TabIndex = CType(resources.GetObject("Label3.TabIndex"), Integer)
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = CType(resources.GetObject("Label3.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
        '
        'ListBox1
        '
        Me.ListBox1.AccessibleDescription = CType(resources.GetObject("ListBox1.AccessibleDescription"), String)
        Me.ListBox1.AccessibleName = CType(resources.GetObject("ListBox1.AccessibleName"), String)
        Me.ListBox1.Anchor = CType(resources.GetObject("ListBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackgroundImage = CType(resources.GetObject("ListBox1.BackgroundImage"), System.Drawing.Image)
        Me.ListBox1.ColumnWidth = CType(resources.GetObject("ListBox1.ColumnWidth"), Integer)
        Me.ListBox1.Dock = CType(resources.GetObject("ListBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.ListBox1.Enabled = CType(resources.GetObject("ListBox1.Enabled"), Boolean)
        Me.ListBox1.Font = CType(resources.GetObject("ListBox1.Font"), System.Drawing.Font)
        Me.ListBox1.HorizontalExtent = CType(resources.GetObject("ListBox1.HorizontalExtent"), Integer)
        Me.ListBox1.HorizontalScrollbar = CType(resources.GetObject("ListBox1.HorizontalScrollbar"), Boolean)
        Me.ListBox1.ImeMode = CType(resources.GetObject("ListBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListBox1.IntegralHeight = CType(resources.GetObject("ListBox1.IntegralHeight"), Boolean)
        Me.ListBox1.ItemHeight = CType(resources.GetObject("ListBox1.ItemHeight"), Integer)
        Me.ListBox1.Location = CType(resources.GetObject("ListBox1.Location"), System.Drawing.Point)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = CType(resources.GetObject("ListBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListBox1.ScrollAlwaysVisible = CType(resources.GetObject("ListBox1.ScrollAlwaysVisible"), Boolean)
        Me.ListBox1.Size = CType(resources.GetObject("ListBox1.Size"), System.Drawing.Size)
        Me.ListBox1.TabIndex = CType(resources.GetObject("ListBox1.TabIndex"), Integer)
        Me.ListBox1.Visible = CType(resources.GetObject("ListBox1.Visible"), Boolean)
        '
        'TabPage7
        '
        Me.TabPage7.AccessibleDescription = CType(resources.GetObject("TabPage7.AccessibleDescription"), String)
        Me.TabPage7.AccessibleName = CType(resources.GetObject("TabPage7.AccessibleName"), String)
        Me.TabPage7.Anchor = CType(resources.GetObject("TabPage7.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage7.AutoScroll = CType(resources.GetObject("TabPage7.AutoScroll"), Boolean)
        Me.TabPage7.AutoScrollMargin = CType(resources.GetObject("TabPage7.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage7.AutoScrollMinSize = CType(resources.GetObject("TabPage7.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage7.BackgroundImage = CType(resources.GetObject("TabPage7.BackgroundImage"), System.Drawing.Image)
        Me.TabPage7.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListBox3, Me.Label34, Me.Label33, Me.Label32, Me.Label31, Me.Label30, Me.Label29, Me.Label28, Me.Label27, Me.Label26, Me.Label25, Me.Label24, Me.Label23, Me.Label22, Me.Label21, Me.Label20, Me.Label19, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.Label14, Me.Label13, Me.Label12, Me.Label11, Me.Label10})
        Me.TabPage7.Dock = CType(resources.GetObject("TabPage7.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage7.Enabled = CType(resources.GetObject("TabPage7.Enabled"), Boolean)
        Me.TabPage7.Font = CType(resources.GetObject("TabPage7.Font"), System.Drawing.Font)
        Me.TabPage7.ImageIndex = CType(resources.GetObject("TabPage7.ImageIndex"), Integer)
        Me.TabPage7.ImeMode = CType(resources.GetObject("TabPage7.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage7.Location = CType(resources.GetObject("TabPage7.Location"), System.Drawing.Point)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.RightToLeft = CType(resources.GetObject("TabPage7.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage7.Size = CType(resources.GetObject("TabPage7.Size"), System.Drawing.Size)
        Me.TabPage7.TabIndex = CType(resources.GetObject("TabPage7.TabIndex"), Integer)
        Me.TabPage7.Text = resources.GetString("TabPage7.Text")
        Me.TabPage7.ToolTipText = resources.GetString("TabPage7.ToolTipText")
        Me.TabPage7.Visible = CType(resources.GetObject("TabPage7.Visible"), Boolean)
        '
        'ListBox3
        '
        Me.ListBox3.AccessibleDescription = CType(resources.GetObject("ListBox3.AccessibleDescription"), String)
        Me.ListBox3.AccessibleName = CType(resources.GetObject("ListBox3.AccessibleName"), String)
        Me.ListBox3.Anchor = CType(resources.GetObject("ListBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListBox3.BackgroundImage = CType(resources.GetObject("ListBox3.BackgroundImage"), System.Drawing.Image)
        Me.ListBox3.ColumnWidth = CType(resources.GetObject("ListBox3.ColumnWidth"), Integer)
        Me.ListBox3.Dock = CType(resources.GetObject("ListBox3.Dock"), System.Windows.Forms.DockStyle)
        Me.ListBox3.Enabled = CType(resources.GetObject("ListBox3.Enabled"), Boolean)
        Me.ListBox3.Font = CType(resources.GetObject("ListBox3.Font"), System.Drawing.Font)
        Me.ListBox3.HorizontalExtent = CType(resources.GetObject("ListBox3.HorizontalExtent"), Integer)
        Me.ListBox3.HorizontalScrollbar = CType(resources.GetObject("ListBox3.HorizontalScrollbar"), Boolean)
        Me.ListBox3.ImeMode = CType(resources.GetObject("ListBox3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListBox3.IntegralHeight = CType(resources.GetObject("ListBox3.IntegralHeight"), Boolean)
        Me.ListBox3.ItemHeight = CType(resources.GetObject("ListBox3.ItemHeight"), Integer)
        Me.ListBox3.Location = CType(resources.GetObject("ListBox3.Location"), System.Drawing.Point)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.RightToLeft = CType(resources.GetObject("ListBox3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListBox3.ScrollAlwaysVisible = CType(resources.GetObject("ListBox3.ScrollAlwaysVisible"), Boolean)
        Me.ListBox3.Size = CType(resources.GetObject("ListBox3.Size"), System.Drawing.Size)
        Me.ListBox3.TabIndex = CType(resources.GetObject("ListBox3.TabIndex"), Integer)
        Me.ListBox3.Visible = CType(resources.GetObject("ListBox3.Visible"), Boolean)
        '
        'Label34
        '
        Me.Label34.AccessibleDescription = CType(resources.GetObject("Label34.AccessibleDescription"), String)
        Me.Label34.AccessibleName = CType(resources.GetObject("Label34.AccessibleName"), String)
        Me.Label34.Anchor = CType(resources.GetObject("Label34.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = CType(resources.GetObject("Label34.AutoSize"), Boolean)
        Me.Label34.Dock = CType(resources.GetObject("Label34.Dock"), System.Windows.Forms.DockStyle)
        Me.Label34.Enabled = CType(resources.GetObject("Label34.Enabled"), Boolean)
        Me.Label34.Font = CType(resources.GetObject("Label34.Font"), System.Drawing.Font)
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.ImageAlign = CType(resources.GetObject("Label34.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label34.ImageIndex = CType(resources.GetObject("Label34.ImageIndex"), Integer)
        Me.Label34.ImeMode = CType(resources.GetObject("Label34.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label34.Location = CType(resources.GetObject("Label34.Location"), System.Drawing.Point)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = CType(resources.GetObject("Label34.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label34.Size = CType(resources.GetObject("Label34.Size"), System.Drawing.Size)
        Me.Label34.TabIndex = CType(resources.GetObject("Label34.TabIndex"), Integer)
        Me.Label34.Text = resources.GetString("Label34.Text")
        Me.Label34.TextAlign = CType(resources.GetObject("Label34.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label34.Visible = CType(resources.GetObject("Label34.Visible"), Boolean)
        '
        'Label33
        '
        Me.Label33.AccessibleDescription = CType(resources.GetObject("Label33.AccessibleDescription"), String)
        Me.Label33.AccessibleName = CType(resources.GetObject("Label33.AccessibleName"), String)
        Me.Label33.Anchor = CType(resources.GetObject("Label33.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = CType(resources.GetObject("Label33.AutoSize"), Boolean)
        Me.Label33.Dock = CType(resources.GetObject("Label33.Dock"), System.Windows.Forms.DockStyle)
        Me.Label33.Enabled = CType(resources.GetObject("Label33.Enabled"), Boolean)
        Me.Label33.Font = CType(resources.GetObject("Label33.Font"), System.Drawing.Font)
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.ImageAlign = CType(resources.GetObject("Label33.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label33.ImageIndex = CType(resources.GetObject("Label33.ImageIndex"), Integer)
        Me.Label33.ImeMode = CType(resources.GetObject("Label33.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label33.Location = CType(resources.GetObject("Label33.Location"), System.Drawing.Point)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = CType(resources.GetObject("Label33.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label33.Size = CType(resources.GetObject("Label33.Size"), System.Drawing.Size)
        Me.Label33.TabIndex = CType(resources.GetObject("Label33.TabIndex"), Integer)
        Me.Label33.Text = resources.GetString("Label33.Text")
        Me.Label33.TextAlign = CType(resources.GetObject("Label33.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label33.Visible = CType(resources.GetObject("Label33.Visible"), Boolean)
        '
        'Label32
        '
        Me.Label32.AccessibleDescription = CType(resources.GetObject("Label32.AccessibleDescription"), String)
        Me.Label32.AccessibleName = CType(resources.GetObject("Label32.AccessibleName"), String)
        Me.Label32.Anchor = CType(resources.GetObject("Label32.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = CType(resources.GetObject("Label32.AutoSize"), Boolean)
        Me.Label32.Dock = CType(resources.GetObject("Label32.Dock"), System.Windows.Forms.DockStyle)
        Me.Label32.Enabled = CType(resources.GetObject("Label32.Enabled"), Boolean)
        Me.Label32.Font = CType(resources.GetObject("Label32.Font"), System.Drawing.Font)
        Me.Label32.Image = CType(resources.GetObject("Label32.Image"), System.Drawing.Image)
        Me.Label32.ImageAlign = CType(resources.GetObject("Label32.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label32.ImageIndex = CType(resources.GetObject("Label32.ImageIndex"), Integer)
        Me.Label32.ImeMode = CType(resources.GetObject("Label32.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label32.Location = CType(resources.GetObject("Label32.Location"), System.Drawing.Point)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = CType(resources.GetObject("Label32.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label32.Size = CType(resources.GetObject("Label32.Size"), System.Drawing.Size)
        Me.Label32.TabIndex = CType(resources.GetObject("Label32.TabIndex"), Integer)
        Me.Label32.Text = resources.GetString("Label32.Text")
        Me.Label32.TextAlign = CType(resources.GetObject("Label32.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label32.Visible = CType(resources.GetObject("Label32.Visible"), Boolean)
        '
        'Label31
        '
        Me.Label31.AccessibleDescription = CType(resources.GetObject("Label31.AccessibleDescription"), String)
        Me.Label31.AccessibleName = CType(resources.GetObject("Label31.AccessibleName"), String)
        Me.Label31.Anchor = CType(resources.GetObject("Label31.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = CType(resources.GetObject("Label31.AutoSize"), Boolean)
        Me.Label31.Dock = CType(resources.GetObject("Label31.Dock"), System.Windows.Forms.DockStyle)
        Me.Label31.Enabled = CType(resources.GetObject("Label31.Enabled"), Boolean)
        Me.Label31.Font = CType(resources.GetObject("Label31.Font"), System.Drawing.Font)
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.ImageAlign = CType(resources.GetObject("Label31.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label31.ImageIndex = CType(resources.GetObject("Label31.ImageIndex"), Integer)
        Me.Label31.ImeMode = CType(resources.GetObject("Label31.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label31.Location = CType(resources.GetObject("Label31.Location"), System.Drawing.Point)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = CType(resources.GetObject("Label31.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label31.Size = CType(resources.GetObject("Label31.Size"), System.Drawing.Size)
        Me.Label31.TabIndex = CType(resources.GetObject("Label31.TabIndex"), Integer)
        Me.Label31.Text = resources.GetString("Label31.Text")
        Me.Label31.TextAlign = CType(resources.GetObject("Label31.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label31.Visible = CType(resources.GetObject("Label31.Visible"), Boolean)
        '
        'Label30
        '
        Me.Label30.AccessibleDescription = CType(resources.GetObject("Label30.AccessibleDescription"), String)
        Me.Label30.AccessibleName = CType(resources.GetObject("Label30.AccessibleName"), String)
        Me.Label30.Anchor = CType(resources.GetObject("Label30.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = CType(resources.GetObject("Label30.AutoSize"), Boolean)
        Me.Label30.Dock = CType(resources.GetObject("Label30.Dock"), System.Windows.Forms.DockStyle)
        Me.Label30.Enabled = CType(resources.GetObject("Label30.Enabled"), Boolean)
        Me.Label30.Font = CType(resources.GetObject("Label30.Font"), System.Drawing.Font)
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.ImageAlign = CType(resources.GetObject("Label30.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label30.ImageIndex = CType(resources.GetObject("Label30.ImageIndex"), Integer)
        Me.Label30.ImeMode = CType(resources.GetObject("Label30.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label30.Location = CType(resources.GetObject("Label30.Location"), System.Drawing.Point)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = CType(resources.GetObject("Label30.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label30.Size = CType(resources.GetObject("Label30.Size"), System.Drawing.Size)
        Me.Label30.TabIndex = CType(resources.GetObject("Label30.TabIndex"), Integer)
        Me.Label30.Text = resources.GetString("Label30.Text")
        Me.Label30.TextAlign = CType(resources.GetObject("Label30.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label30.Visible = CType(resources.GetObject("Label30.Visible"), Boolean)
        '
        'Label29
        '
        Me.Label29.AccessibleDescription = CType(resources.GetObject("Label29.AccessibleDescription"), String)
        Me.Label29.AccessibleName = CType(resources.GetObject("Label29.AccessibleName"), String)
        Me.Label29.Anchor = CType(resources.GetObject("Label29.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = CType(resources.GetObject("Label29.AutoSize"), Boolean)
        Me.Label29.Dock = CType(resources.GetObject("Label29.Dock"), System.Windows.Forms.DockStyle)
        Me.Label29.Enabled = CType(resources.GetObject("Label29.Enabled"), Boolean)
        Me.Label29.Font = CType(resources.GetObject("Label29.Font"), System.Drawing.Font)
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.ImageAlign = CType(resources.GetObject("Label29.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label29.ImageIndex = CType(resources.GetObject("Label29.ImageIndex"), Integer)
        Me.Label29.ImeMode = CType(resources.GetObject("Label29.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label29.Location = CType(resources.GetObject("Label29.Location"), System.Drawing.Point)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = CType(resources.GetObject("Label29.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label29.Size = CType(resources.GetObject("Label29.Size"), System.Drawing.Size)
        Me.Label29.TabIndex = CType(resources.GetObject("Label29.TabIndex"), Integer)
        Me.Label29.Text = resources.GetString("Label29.Text")
        Me.Label29.TextAlign = CType(resources.GetObject("Label29.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label29.Visible = CType(resources.GetObject("Label29.Visible"), Boolean)
        '
        'Label28
        '
        Me.Label28.AccessibleDescription = CType(resources.GetObject("Label28.AccessibleDescription"), String)
        Me.Label28.AccessibleName = CType(resources.GetObject("Label28.AccessibleName"), String)
        Me.Label28.Anchor = CType(resources.GetObject("Label28.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = CType(resources.GetObject("Label28.AutoSize"), Boolean)
        Me.Label28.Dock = CType(resources.GetObject("Label28.Dock"), System.Windows.Forms.DockStyle)
        Me.Label28.Enabled = CType(resources.GetObject("Label28.Enabled"), Boolean)
        Me.Label28.Font = CType(resources.GetObject("Label28.Font"), System.Drawing.Font)
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.ImageAlign = CType(resources.GetObject("Label28.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label28.ImageIndex = CType(resources.GetObject("Label28.ImageIndex"), Integer)
        Me.Label28.ImeMode = CType(resources.GetObject("Label28.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label28.Location = CType(resources.GetObject("Label28.Location"), System.Drawing.Point)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = CType(resources.GetObject("Label28.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label28.Size = CType(resources.GetObject("Label28.Size"), System.Drawing.Size)
        Me.Label28.TabIndex = CType(resources.GetObject("Label28.TabIndex"), Integer)
        Me.Label28.Text = resources.GetString("Label28.Text")
        Me.Label28.TextAlign = CType(resources.GetObject("Label28.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label28.Visible = CType(resources.GetObject("Label28.Visible"), Boolean)
        '
        'Label27
        '
        Me.Label27.AccessibleDescription = CType(resources.GetObject("Label27.AccessibleDescription"), String)
        Me.Label27.AccessibleName = CType(resources.GetObject("Label27.AccessibleName"), String)
        Me.Label27.Anchor = CType(resources.GetObject("Label27.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = CType(resources.GetObject("Label27.AutoSize"), Boolean)
        Me.Label27.Dock = CType(resources.GetObject("Label27.Dock"), System.Windows.Forms.DockStyle)
        Me.Label27.Enabled = CType(resources.GetObject("Label27.Enabled"), Boolean)
        Me.Label27.Font = CType(resources.GetObject("Label27.Font"), System.Drawing.Font)
        Me.Label27.Image = CType(resources.GetObject("Label27.Image"), System.Drawing.Image)
        Me.Label27.ImageAlign = CType(resources.GetObject("Label27.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label27.ImageIndex = CType(resources.GetObject("Label27.ImageIndex"), Integer)
        Me.Label27.ImeMode = CType(resources.GetObject("Label27.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label27.Location = CType(resources.GetObject("Label27.Location"), System.Drawing.Point)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = CType(resources.GetObject("Label27.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label27.Size = CType(resources.GetObject("Label27.Size"), System.Drawing.Size)
        Me.Label27.TabIndex = CType(resources.GetObject("Label27.TabIndex"), Integer)
        Me.Label27.Text = resources.GetString("Label27.Text")
        Me.Label27.TextAlign = CType(resources.GetObject("Label27.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label27.Visible = CType(resources.GetObject("Label27.Visible"), Boolean)
        '
        'Label26
        '
        Me.Label26.AccessibleDescription = CType(resources.GetObject("Label26.AccessibleDescription"), String)
        Me.Label26.AccessibleName = CType(resources.GetObject("Label26.AccessibleName"), String)
        Me.Label26.Anchor = CType(resources.GetObject("Label26.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = CType(resources.GetObject("Label26.AutoSize"), Boolean)
        Me.Label26.Dock = CType(resources.GetObject("Label26.Dock"), System.Windows.Forms.DockStyle)
        Me.Label26.Enabled = CType(resources.GetObject("Label26.Enabled"), Boolean)
        Me.Label26.Font = CType(resources.GetObject("Label26.Font"), System.Drawing.Font)
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.ImageAlign = CType(resources.GetObject("Label26.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label26.ImageIndex = CType(resources.GetObject("Label26.ImageIndex"), Integer)
        Me.Label26.ImeMode = CType(resources.GetObject("Label26.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label26.Location = CType(resources.GetObject("Label26.Location"), System.Drawing.Point)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = CType(resources.GetObject("Label26.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label26.Size = CType(resources.GetObject("Label26.Size"), System.Drawing.Size)
        Me.Label26.TabIndex = CType(resources.GetObject("Label26.TabIndex"), Integer)
        Me.Label26.Text = resources.GetString("Label26.Text")
        Me.Label26.TextAlign = CType(resources.GetObject("Label26.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label26.Visible = CType(resources.GetObject("Label26.Visible"), Boolean)
        '
        'Label25
        '
        Me.Label25.AccessibleDescription = CType(resources.GetObject("Label25.AccessibleDescription"), String)
        Me.Label25.AccessibleName = CType(resources.GetObject("Label25.AccessibleName"), String)
        Me.Label25.Anchor = CType(resources.GetObject("Label25.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = CType(resources.GetObject("Label25.AutoSize"), Boolean)
        Me.Label25.Dock = CType(resources.GetObject("Label25.Dock"), System.Windows.Forms.DockStyle)
        Me.Label25.Enabled = CType(resources.GetObject("Label25.Enabled"), Boolean)
        Me.Label25.Font = CType(resources.GetObject("Label25.Font"), System.Drawing.Font)
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.ImageAlign = CType(resources.GetObject("Label25.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label25.ImageIndex = CType(resources.GetObject("Label25.ImageIndex"), Integer)
        Me.Label25.ImeMode = CType(resources.GetObject("Label25.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label25.Location = CType(resources.GetObject("Label25.Location"), System.Drawing.Point)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = CType(resources.GetObject("Label25.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label25.Size = CType(resources.GetObject("Label25.Size"), System.Drawing.Size)
        Me.Label25.TabIndex = CType(resources.GetObject("Label25.TabIndex"), Integer)
        Me.Label25.Text = resources.GetString("Label25.Text")
        Me.Label25.TextAlign = CType(resources.GetObject("Label25.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label25.Visible = CType(resources.GetObject("Label25.Visible"), Boolean)
        '
        'Label24
        '
        Me.Label24.AccessibleDescription = CType(resources.GetObject("Label24.AccessibleDescription"), String)
        Me.Label24.AccessibleName = CType(resources.GetObject("Label24.AccessibleName"), String)
        Me.Label24.Anchor = CType(resources.GetObject("Label24.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = CType(resources.GetObject("Label24.AutoSize"), Boolean)
        Me.Label24.Dock = CType(resources.GetObject("Label24.Dock"), System.Windows.Forms.DockStyle)
        Me.Label24.Enabled = CType(resources.GetObject("Label24.Enabled"), Boolean)
        Me.Label24.Font = CType(resources.GetObject("Label24.Font"), System.Drawing.Font)
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.ImageAlign = CType(resources.GetObject("Label24.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label24.ImageIndex = CType(resources.GetObject("Label24.ImageIndex"), Integer)
        Me.Label24.ImeMode = CType(resources.GetObject("Label24.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label24.Location = CType(resources.GetObject("Label24.Location"), System.Drawing.Point)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = CType(resources.GetObject("Label24.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label24.Size = CType(resources.GetObject("Label24.Size"), System.Drawing.Size)
        Me.Label24.TabIndex = CType(resources.GetObject("Label24.TabIndex"), Integer)
        Me.Label24.Text = resources.GetString("Label24.Text")
        Me.Label24.TextAlign = CType(resources.GetObject("Label24.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label24.Visible = CType(resources.GetObject("Label24.Visible"), Boolean)
        '
        'Label23
        '
        Me.Label23.AccessibleDescription = CType(resources.GetObject("Label23.AccessibleDescription"), String)
        Me.Label23.AccessibleName = CType(resources.GetObject("Label23.AccessibleName"), String)
        Me.Label23.Anchor = CType(resources.GetObject("Label23.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = CType(resources.GetObject("Label23.AutoSize"), Boolean)
        Me.Label23.Dock = CType(resources.GetObject("Label23.Dock"), System.Windows.Forms.DockStyle)
        Me.Label23.Enabled = CType(resources.GetObject("Label23.Enabled"), Boolean)
        Me.Label23.Font = CType(resources.GetObject("Label23.Font"), System.Drawing.Font)
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.ImageAlign = CType(resources.GetObject("Label23.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label23.ImageIndex = CType(resources.GetObject("Label23.ImageIndex"), Integer)
        Me.Label23.ImeMode = CType(resources.GetObject("Label23.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label23.Location = CType(resources.GetObject("Label23.Location"), System.Drawing.Point)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = CType(resources.GetObject("Label23.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label23.Size = CType(resources.GetObject("Label23.Size"), System.Drawing.Size)
        Me.Label23.TabIndex = CType(resources.GetObject("Label23.TabIndex"), Integer)
        Me.Label23.Text = resources.GetString("Label23.Text")
        Me.Label23.TextAlign = CType(resources.GetObject("Label23.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label23.Visible = CType(resources.GetObject("Label23.Visible"), Boolean)
        '
        'Label22
        '
        Me.Label22.AccessibleDescription = CType(resources.GetObject("Label22.AccessibleDescription"), String)
        Me.Label22.AccessibleName = CType(resources.GetObject("Label22.AccessibleName"), String)
        Me.Label22.Anchor = CType(resources.GetObject("Label22.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = CType(resources.GetObject("Label22.AutoSize"), Boolean)
        Me.Label22.Dock = CType(resources.GetObject("Label22.Dock"), System.Windows.Forms.DockStyle)
        Me.Label22.Enabled = CType(resources.GetObject("Label22.Enabled"), Boolean)
        Me.Label22.Font = CType(resources.GetObject("Label22.Font"), System.Drawing.Font)
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.ImageAlign = CType(resources.GetObject("Label22.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label22.ImageIndex = CType(resources.GetObject("Label22.ImageIndex"), Integer)
        Me.Label22.ImeMode = CType(resources.GetObject("Label22.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label22.Location = CType(resources.GetObject("Label22.Location"), System.Drawing.Point)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = CType(resources.GetObject("Label22.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label22.Size = CType(resources.GetObject("Label22.Size"), System.Drawing.Size)
        Me.Label22.TabIndex = CType(resources.GetObject("Label22.TabIndex"), Integer)
        Me.Label22.Text = resources.GetString("Label22.Text")
        Me.Label22.TextAlign = CType(resources.GetObject("Label22.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label22.Visible = CType(resources.GetObject("Label22.Visible"), Boolean)
        '
        'Label21
        '
        Me.Label21.AccessibleDescription = CType(resources.GetObject("Label21.AccessibleDescription"), String)
        Me.Label21.AccessibleName = CType(resources.GetObject("Label21.AccessibleName"), String)
        Me.Label21.Anchor = CType(resources.GetObject("Label21.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = CType(resources.GetObject("Label21.AutoSize"), Boolean)
        Me.Label21.Dock = CType(resources.GetObject("Label21.Dock"), System.Windows.Forms.DockStyle)
        Me.Label21.Enabled = CType(resources.GetObject("Label21.Enabled"), Boolean)
        Me.Label21.Font = CType(resources.GetObject("Label21.Font"), System.Drawing.Font)
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.ImageAlign = CType(resources.GetObject("Label21.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label21.ImageIndex = CType(resources.GetObject("Label21.ImageIndex"), Integer)
        Me.Label21.ImeMode = CType(resources.GetObject("Label21.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label21.Location = CType(resources.GetObject("Label21.Location"), System.Drawing.Point)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = CType(resources.GetObject("Label21.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label21.Size = CType(resources.GetObject("Label21.Size"), System.Drawing.Size)
        Me.Label21.TabIndex = CType(resources.GetObject("Label21.TabIndex"), Integer)
        Me.Label21.Text = resources.GetString("Label21.Text")
        Me.Label21.TextAlign = CType(resources.GetObject("Label21.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label21.Visible = CType(resources.GetObject("Label21.Visible"), Boolean)
        '
        'Label20
        '
        Me.Label20.AccessibleDescription = CType(resources.GetObject("Label20.AccessibleDescription"), String)
        Me.Label20.AccessibleName = CType(resources.GetObject("Label20.AccessibleName"), String)
        Me.Label20.Anchor = CType(resources.GetObject("Label20.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = CType(resources.GetObject("Label20.AutoSize"), Boolean)
        Me.Label20.Dock = CType(resources.GetObject("Label20.Dock"), System.Windows.Forms.DockStyle)
        Me.Label20.Enabled = CType(resources.GetObject("Label20.Enabled"), Boolean)
        Me.Label20.Font = CType(resources.GetObject("Label20.Font"), System.Drawing.Font)
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.ImageAlign = CType(resources.GetObject("Label20.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label20.ImageIndex = CType(resources.GetObject("Label20.ImageIndex"), Integer)
        Me.Label20.ImeMode = CType(resources.GetObject("Label20.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label20.Location = CType(resources.GetObject("Label20.Location"), System.Drawing.Point)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = CType(resources.GetObject("Label20.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label20.Size = CType(resources.GetObject("Label20.Size"), System.Drawing.Size)
        Me.Label20.TabIndex = CType(resources.GetObject("Label20.TabIndex"), Integer)
        Me.Label20.Text = resources.GetString("Label20.Text")
        Me.Label20.TextAlign = CType(resources.GetObject("Label20.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label20.Visible = CType(resources.GetObject("Label20.Visible"), Boolean)
        '
        'Label19
        '
        Me.Label19.AccessibleDescription = CType(resources.GetObject("Label19.AccessibleDescription"), String)
        Me.Label19.AccessibleName = CType(resources.GetObject("Label19.AccessibleName"), String)
        Me.Label19.Anchor = CType(resources.GetObject("Label19.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = CType(resources.GetObject("Label19.AutoSize"), Boolean)
        Me.Label19.Dock = CType(resources.GetObject("Label19.Dock"), System.Windows.Forms.DockStyle)
        Me.Label19.Enabled = CType(resources.GetObject("Label19.Enabled"), Boolean)
        Me.Label19.Font = CType(resources.GetObject("Label19.Font"), System.Drawing.Font)
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = CType(resources.GetObject("Label19.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label19.ImageIndex = CType(resources.GetObject("Label19.ImageIndex"), Integer)
        Me.Label19.ImeMode = CType(resources.GetObject("Label19.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label19.Location = CType(resources.GetObject("Label19.Location"), System.Drawing.Point)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = CType(resources.GetObject("Label19.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label19.Size = CType(resources.GetObject("Label19.Size"), System.Drawing.Size)
        Me.Label19.TabIndex = CType(resources.GetObject("Label19.TabIndex"), Integer)
        Me.Label19.Text = resources.GetString("Label19.Text")
        Me.Label19.TextAlign = CType(resources.GetObject("Label19.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label19.Visible = CType(resources.GetObject("Label19.Visible"), Boolean)
        '
        'Label18
        '
        Me.Label18.AccessibleDescription = CType(resources.GetObject("Label18.AccessibleDescription"), String)
        Me.Label18.AccessibleName = CType(resources.GetObject("Label18.AccessibleName"), String)
        Me.Label18.Anchor = CType(resources.GetObject("Label18.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = CType(resources.GetObject("Label18.AutoSize"), Boolean)
        Me.Label18.Dock = CType(resources.GetObject("Label18.Dock"), System.Windows.Forms.DockStyle)
        Me.Label18.Enabled = CType(resources.GetObject("Label18.Enabled"), Boolean)
        Me.Label18.Font = CType(resources.GetObject("Label18.Font"), System.Drawing.Font)
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImageAlign = CType(resources.GetObject("Label18.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label18.ImageIndex = CType(resources.GetObject("Label18.ImageIndex"), Integer)
        Me.Label18.ImeMode = CType(resources.GetObject("Label18.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label18.Location = CType(resources.GetObject("Label18.Location"), System.Drawing.Point)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = CType(resources.GetObject("Label18.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label18.Size = CType(resources.GetObject("Label18.Size"), System.Drawing.Size)
        Me.Label18.TabIndex = CType(resources.GetObject("Label18.TabIndex"), Integer)
        Me.Label18.Text = resources.GetString("Label18.Text")
        Me.Label18.TextAlign = CType(resources.GetObject("Label18.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label18.Visible = CType(resources.GetObject("Label18.Visible"), Boolean)
        '
        'Label17
        '
        Me.Label17.AccessibleDescription = CType(resources.GetObject("Label17.AccessibleDescription"), String)
        Me.Label17.AccessibleName = CType(resources.GetObject("Label17.AccessibleName"), String)
        Me.Label17.Anchor = CType(resources.GetObject("Label17.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = CType(resources.GetObject("Label17.AutoSize"), Boolean)
        Me.Label17.Dock = CType(resources.GetObject("Label17.Dock"), System.Windows.Forms.DockStyle)
        Me.Label17.Enabled = CType(resources.GetObject("Label17.Enabled"), Boolean)
        Me.Label17.Font = CType(resources.GetObject("Label17.Font"), System.Drawing.Font)
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.ImageAlign = CType(resources.GetObject("Label17.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label17.ImageIndex = CType(resources.GetObject("Label17.ImageIndex"), Integer)
        Me.Label17.ImeMode = CType(resources.GetObject("Label17.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label17.Location = CType(resources.GetObject("Label17.Location"), System.Drawing.Point)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = CType(resources.GetObject("Label17.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label17.Size = CType(resources.GetObject("Label17.Size"), System.Drawing.Size)
        Me.Label17.TabIndex = CType(resources.GetObject("Label17.TabIndex"), Integer)
        Me.Label17.Text = resources.GetString("Label17.Text")
        Me.Label17.TextAlign = CType(resources.GetObject("Label17.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label17.Visible = CType(resources.GetObject("Label17.Visible"), Boolean)
        '
        'Label16
        '
        Me.Label16.AccessibleDescription = CType(resources.GetObject("Label16.AccessibleDescription"), String)
        Me.Label16.AccessibleName = CType(resources.GetObject("Label16.AccessibleName"), String)
        Me.Label16.Anchor = CType(resources.GetObject("Label16.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = CType(resources.GetObject("Label16.AutoSize"), Boolean)
        Me.Label16.Dock = CType(resources.GetObject("Label16.Dock"), System.Windows.Forms.DockStyle)
        Me.Label16.Enabled = CType(resources.GetObject("Label16.Enabled"), Boolean)
        Me.Label16.Font = CType(resources.GetObject("Label16.Font"), System.Drawing.Font)
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.ImageAlign = CType(resources.GetObject("Label16.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label16.ImageIndex = CType(resources.GetObject("Label16.ImageIndex"), Integer)
        Me.Label16.ImeMode = CType(resources.GetObject("Label16.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label16.Location = CType(resources.GetObject("Label16.Location"), System.Drawing.Point)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = CType(resources.GetObject("Label16.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label16.Size = CType(resources.GetObject("Label16.Size"), System.Drawing.Size)
        Me.Label16.TabIndex = CType(resources.GetObject("Label16.TabIndex"), Integer)
        Me.Label16.Text = resources.GetString("Label16.Text")
        Me.Label16.TextAlign = CType(resources.GetObject("Label16.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label16.Visible = CType(resources.GetObject("Label16.Visible"), Boolean)
        '
        'Label15
        '
        Me.Label15.AccessibleDescription = CType(resources.GetObject("Label15.AccessibleDescription"), String)
        Me.Label15.AccessibleName = CType(resources.GetObject("Label15.AccessibleName"), String)
        Me.Label15.Anchor = CType(resources.GetObject("Label15.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = CType(resources.GetObject("Label15.AutoSize"), Boolean)
        Me.Label15.Dock = CType(resources.GetObject("Label15.Dock"), System.Windows.Forms.DockStyle)
        Me.Label15.Enabled = CType(resources.GetObject("Label15.Enabled"), Boolean)
        Me.Label15.Font = CType(resources.GetObject("Label15.Font"), System.Drawing.Font)
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = CType(resources.GetObject("Label15.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label15.ImageIndex = CType(resources.GetObject("Label15.ImageIndex"), Integer)
        Me.Label15.ImeMode = CType(resources.GetObject("Label15.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label15.Location = CType(resources.GetObject("Label15.Location"), System.Drawing.Point)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = CType(resources.GetObject("Label15.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label15.Size = CType(resources.GetObject("Label15.Size"), System.Drawing.Size)
        Me.Label15.TabIndex = CType(resources.GetObject("Label15.TabIndex"), Integer)
        Me.Label15.Text = resources.GetString("Label15.Text")
        Me.Label15.TextAlign = CType(resources.GetObject("Label15.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label15.Visible = CType(resources.GetObject("Label15.Visible"), Boolean)
        '
        'Label14
        '
        Me.Label14.AccessibleDescription = CType(resources.GetObject("Label14.AccessibleDescription"), String)
        Me.Label14.AccessibleName = CType(resources.GetObject("Label14.AccessibleName"), String)
        Me.Label14.Anchor = CType(resources.GetObject("Label14.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = CType(resources.GetObject("Label14.AutoSize"), Boolean)
        Me.Label14.Dock = CType(resources.GetObject("Label14.Dock"), System.Windows.Forms.DockStyle)
        Me.Label14.Enabled = CType(resources.GetObject("Label14.Enabled"), Boolean)
        Me.Label14.Font = CType(resources.GetObject("Label14.Font"), System.Drawing.Font)
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.ImageAlign = CType(resources.GetObject("Label14.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label14.ImageIndex = CType(resources.GetObject("Label14.ImageIndex"), Integer)
        Me.Label14.ImeMode = CType(resources.GetObject("Label14.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label14.Location = CType(resources.GetObject("Label14.Location"), System.Drawing.Point)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = CType(resources.GetObject("Label14.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label14.Size = CType(resources.GetObject("Label14.Size"), System.Drawing.Size)
        Me.Label14.TabIndex = CType(resources.GetObject("Label14.TabIndex"), Integer)
        Me.Label14.Text = resources.GetString("Label14.Text")
        Me.Label14.TextAlign = CType(resources.GetObject("Label14.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label14.Visible = CType(resources.GetObject("Label14.Visible"), Boolean)
        '
        'Label13
        '
        Me.Label13.AccessibleDescription = CType(resources.GetObject("Label13.AccessibleDescription"), String)
        Me.Label13.AccessibleName = CType(resources.GetObject("Label13.AccessibleName"), String)
        Me.Label13.Anchor = CType(resources.GetObject("Label13.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = CType(resources.GetObject("Label13.AutoSize"), Boolean)
        Me.Label13.Dock = CType(resources.GetObject("Label13.Dock"), System.Windows.Forms.DockStyle)
        Me.Label13.Enabled = CType(resources.GetObject("Label13.Enabled"), Boolean)
        Me.Label13.Font = CType(resources.GetObject("Label13.Font"), System.Drawing.Font)
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = CType(resources.GetObject("Label13.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label13.ImageIndex = CType(resources.GetObject("Label13.ImageIndex"), Integer)
        Me.Label13.ImeMode = CType(resources.GetObject("Label13.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label13.Location = CType(resources.GetObject("Label13.Location"), System.Drawing.Point)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = CType(resources.GetObject("Label13.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label13.Size = CType(resources.GetObject("Label13.Size"), System.Drawing.Size)
        Me.Label13.TabIndex = CType(resources.GetObject("Label13.TabIndex"), Integer)
        Me.Label13.Text = resources.GetString("Label13.Text")
        Me.Label13.TextAlign = CType(resources.GetObject("Label13.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label13.Visible = CType(resources.GetObject("Label13.Visible"), Boolean)
        '
        'Label12
        '
        Me.Label12.AccessibleDescription = CType(resources.GetObject("Label12.AccessibleDescription"), String)
        Me.Label12.AccessibleName = CType(resources.GetObject("Label12.AccessibleName"), String)
        Me.Label12.Anchor = CType(resources.GetObject("Label12.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = CType(resources.GetObject("Label12.AutoSize"), Boolean)
        Me.Label12.Dock = CType(resources.GetObject("Label12.Dock"), System.Windows.Forms.DockStyle)
        Me.Label12.Enabled = CType(resources.GetObject("Label12.Enabled"), Boolean)
        Me.Label12.Font = CType(resources.GetObject("Label12.Font"), System.Drawing.Font)
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = CType(resources.GetObject("Label12.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label12.ImageIndex = CType(resources.GetObject("Label12.ImageIndex"), Integer)
        Me.Label12.ImeMode = CType(resources.GetObject("Label12.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label12.Location = CType(resources.GetObject("Label12.Location"), System.Drawing.Point)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = CType(resources.GetObject("Label12.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label12.Size = CType(resources.GetObject("Label12.Size"), System.Drawing.Size)
        Me.Label12.TabIndex = CType(resources.GetObject("Label12.TabIndex"), Integer)
        Me.Label12.Text = resources.GetString("Label12.Text")
        Me.Label12.TextAlign = CType(resources.GetObject("Label12.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label12.Visible = CType(resources.GetObject("Label12.Visible"), Boolean)
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = CType(resources.GetObject("Label11.AccessibleDescription"), String)
        Me.Label11.AccessibleName = CType(resources.GetObject("Label11.AccessibleName"), String)
        Me.Label11.Anchor = CType(resources.GetObject("Label11.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = CType(resources.GetObject("Label11.AutoSize"), Boolean)
        Me.Label11.Dock = CType(resources.GetObject("Label11.Dock"), System.Windows.Forms.DockStyle)
        Me.Label11.Enabled = CType(resources.GetObject("Label11.Enabled"), Boolean)
        Me.Label11.Font = CType(resources.GetObject("Label11.Font"), System.Drawing.Font)
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = CType(resources.GetObject("Label11.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label11.ImageIndex = CType(resources.GetObject("Label11.ImageIndex"), Integer)
        Me.Label11.ImeMode = CType(resources.GetObject("Label11.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label11.Location = CType(resources.GetObject("Label11.Location"), System.Drawing.Point)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = CType(resources.GetObject("Label11.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label11.Size = CType(resources.GetObject("Label11.Size"), System.Drawing.Size)
        Me.Label11.TabIndex = CType(resources.GetObject("Label11.TabIndex"), Integer)
        Me.Label11.Text = resources.GetString("Label11.Text")
        Me.Label11.TextAlign = CType(resources.GetObject("Label11.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label11.Visible = CType(resources.GetObject("Label11.Visible"), Boolean)
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = CType(resources.GetObject("Label10.AccessibleDescription"), String)
        Me.Label10.AccessibleName = CType(resources.GetObject("Label10.AccessibleName"), String)
        Me.Label10.Anchor = CType(resources.GetObject("Label10.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = CType(resources.GetObject("Label10.AutoSize"), Boolean)
        Me.Label10.Dock = CType(resources.GetObject("Label10.Dock"), System.Windows.Forms.DockStyle)
        Me.Label10.Enabled = CType(resources.GetObject("Label10.Enabled"), Boolean)
        Me.Label10.Font = CType(resources.GetObject("Label10.Font"), System.Drawing.Font)
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = CType(resources.GetObject("Label10.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label10.ImageIndex = CType(resources.GetObject("Label10.ImageIndex"), Integer)
        Me.Label10.ImeMode = CType(resources.GetObject("Label10.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label10.Location = CType(resources.GetObject("Label10.Location"), System.Drawing.Point)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = CType(resources.GetObject("Label10.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label10.Size = CType(resources.GetObject("Label10.Size"), System.Drawing.Size)
        Me.Label10.TabIndex = CType(resources.GetObject("Label10.TabIndex"), Integer)
        Me.Label10.Text = resources.GetString("Label10.Text")
        Me.Label10.TextAlign = CType(resources.GetObject("Label10.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label10.Visible = CType(resources.GetObject("Label10.Visible"), Boolean)
        '
        'TabPage5
        '
        Me.TabPage5.AccessibleDescription = CType(resources.GetObject("TabPage5.AccessibleDescription"), String)
        Me.TabPage5.AccessibleName = CType(resources.GetObject("TabPage5.AccessibleName"), String)
        Me.TabPage5.Anchor = CType(resources.GetObject("TabPage5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage5.AutoScroll = CType(resources.GetObject("TabPage5.AutoScroll"), Boolean)
        Me.TabPage5.AutoScrollMargin = CType(resources.GetObject("TabPage5.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage5.AutoScrollMinSize = CType(resources.GetObject("TabPage5.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage5.BackColor = System.Drawing.Color.Gray
        Me.TabPage5.BackgroundImage = CType(resources.GetObject("TabPage5.BackgroundImage"), System.Drawing.Image)
        Me.TabPage5.Controls.AddRange(New System.Windows.Forms.Control() {Me.CrystalReportViewer1})
        Me.TabPage5.Dock = CType(resources.GetObject("TabPage5.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage5.Enabled = CType(resources.GetObject("TabPage5.Enabled"), Boolean)
        Me.TabPage5.Font = CType(resources.GetObject("TabPage5.Font"), System.Drawing.Font)
        Me.TabPage5.ImageIndex = CType(resources.GetObject("TabPage5.ImageIndex"), Integer)
        Me.TabPage5.ImeMode = CType(resources.GetObject("TabPage5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage5.Location = CType(resources.GetObject("TabPage5.Location"), System.Drawing.Point)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.RightToLeft = CType(resources.GetObject("TabPage5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage5.Size = CType(resources.GetObject("TabPage5.Size"), System.Drawing.Size)
        Me.TabPage5.TabIndex = CType(resources.GetObject("TabPage5.TabIndex"), Integer)
        Me.TabPage5.Text = resources.GetString("TabPage5.Text")
        Me.TabPage5.ToolTipText = resources.GetString("TabPage5.ToolTipText")
        Me.TabPage5.Visible = CType(resources.GetObject("TabPage5.Visible"), Boolean)
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.AccessibleDescription = CType(resources.GetObject("CrystalReportViewer1.AccessibleDescription"), String)
        Me.CrystalReportViewer1.AccessibleName = CType(resources.GetObject("CrystalReportViewer1.AccessibleName"), String)
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType(resources.GetObject("CrystalReportViewer1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.AutoScroll = CType(resources.GetObject("CrystalReportViewer1.AutoScroll"), Boolean)
        Me.CrystalReportViewer1.AutoScrollMargin = CType(resources.GetObject("CrystalReportViewer1.AutoScrollMargin"), System.Drawing.Size)
        Me.CrystalReportViewer1.AutoScrollMinSize = CType(resources.GetObject("CrystalReportViewer1.AutoScrollMinSize"), System.Drawing.Size)
        Me.CrystalReportViewer1.BackgroundImage = CType(resources.GetObject("CrystalReportViewer1.BackgroundImage"), System.Drawing.Image)
        Me.CrystalReportViewer1.DisplayBackgroundEdge = CType(resources.GetObject("CrystalReportViewer1.DisplayBackgroundEdge"), Boolean)
        Me.CrystalReportViewer1.DisplayGroupTree = CType(resources.GetObject("CrystalReportViewer1.DisplayGroupTree"), Boolean)
        Me.CrystalReportViewer1.DisplayToolbar = CType(resources.GetObject("CrystalReportViewer1.DisplayToolbar"), Boolean)
        Me.CrystalReportViewer1.Dock = CType(resources.GetObject("CrystalReportViewer1.Dock"), System.Windows.Forms.DockStyle)
        Me.CrystalReportViewer1.Enabled = CType(resources.GetObject("CrystalReportViewer1.Enabled"), Boolean)
        Me.CrystalReportViewer1.EnableDrillDown = CType(resources.GetObject("CrystalReportViewer1.EnableDrillDown"), Boolean)
        Me.CrystalReportViewer1.Font = CType(resources.GetObject("CrystalReportViewer1.Font"), System.Drawing.Font)
        Me.CrystalReportViewer1.ImeMode = CType(resources.GetObject("CrystalReportViewer1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CrystalReportViewer1.Location = CType(resources.GetObject("CrystalReportViewer1.Location"), System.Drawing.Point)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = "C:\Documents and Settings\jfall\My Documents\Visual Studio Projects\oxistat1dot0\" & _
        "CrystalReport1.rpt"
        Me.CrystalReportViewer1.RightToLeft = CType(resources.GetObject("CrystalReportViewer1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CrystalReportViewer1.ShowCloseButton = CType(resources.GetObject("CrystalReportViewer1.ShowCloseButton"), Boolean)
        Me.CrystalReportViewer1.ShowExportButton = CType(resources.GetObject("CrystalReportViewer1.ShowExportButton"), Boolean)
        Me.CrystalReportViewer1.ShowGotoPageButton = CType(resources.GetObject("CrystalReportViewer1.ShowGotoPageButton"), Boolean)
        Me.CrystalReportViewer1.ShowGroupTreeButton = CType(resources.GetObject("CrystalReportViewer1.ShowGroupTreeButton"), Boolean)
        Me.CrystalReportViewer1.ShowPageNavigateButtons = CType(resources.GetObject("CrystalReportViewer1.ShowPageNavigateButtons"), Boolean)
        Me.CrystalReportViewer1.ShowPrintButton = CType(resources.GetObject("CrystalReportViewer1.ShowPrintButton"), Boolean)
        Me.CrystalReportViewer1.ShowRefreshButton = CType(resources.GetObject("CrystalReportViewer1.ShowRefreshButton"), Boolean)
        Me.CrystalReportViewer1.ShowTextSearchButton = CType(resources.GetObject("CrystalReportViewer1.ShowTextSearchButton"), Boolean)
        Me.CrystalReportViewer1.ShowZoomButton = CType(resources.GetObject("CrystalReportViewer1.ShowZoomButton"), Boolean)
        Me.CrystalReportViewer1.Size = CType(resources.GetObject("CrystalReportViewer1.Size"), System.Drawing.Size)
        Me.CrystalReportViewer1.TabIndex = CType(resources.GetObject("CrystalReportViewer1.TabIndex"), Integer)
        Me.CrystalReportViewer1.Visible = CType(resources.GetObject("CrystalReportViewer1.Visible"), Boolean)
        '
        'TabPage6
        '
        Me.TabPage6.AccessibleDescription = CType(resources.GetObject("TabPage6.AccessibleDescription"), String)
        Me.TabPage6.AccessibleName = CType(resources.GetObject("TabPage6.AccessibleName"), String)
        Me.TabPage6.Anchor = CType(resources.GetObject("TabPage6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TabPage6.AutoScroll = CType(resources.GetObject("TabPage6.AutoScroll"), Boolean)
        Me.TabPage6.AutoScrollMargin = CType(resources.GetObject("TabPage6.AutoScrollMargin"), System.Drawing.Size)
        Me.TabPage6.AutoScrollMinSize = CType(resources.GetObject("TabPage6.AutoScrollMinSize"), System.Drawing.Size)
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.TabPage6.BackgroundImage = CType(resources.GetObject("TabPage6.BackgroundImage"), System.Drawing.Bitmap)
        Me.TabPage6.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button8, Me.Button6, Me.Button4, Me.Button3, Me.Button5, Me.ListBox2})
        Me.TabPage6.Dock = CType(resources.GetObject("TabPage6.Dock"), System.Windows.Forms.DockStyle)
        Me.TabPage6.Enabled = CType(resources.GetObject("TabPage6.Enabled"), Boolean)
        Me.TabPage6.Font = CType(resources.GetObject("TabPage6.Font"), System.Drawing.Font)
        Me.TabPage6.ImageIndex = CType(resources.GetObject("TabPage6.ImageIndex"), Integer)
        Me.TabPage6.ImeMode = CType(resources.GetObject("TabPage6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TabPage6.Location = CType(resources.GetObject("TabPage6.Location"), System.Drawing.Point)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.RightToLeft = CType(resources.GetObject("TabPage6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TabPage6.Size = CType(resources.GetObject("TabPage6.Size"), System.Drawing.Size)
        Me.TabPage6.TabIndex = CType(resources.GetObject("TabPage6.TabIndex"), Integer)
        Me.TabPage6.Text = resources.GetString("TabPage6.Text")
        Me.TabPage6.ToolTipText = resources.GetString("TabPage6.ToolTipText")
        Me.TabPage6.Visible = CType(resources.GetObject("TabPage6.Visible"), Boolean)
        '
        'Button8
        '
        Me.Button8.AccessibleDescription = CType(resources.GetObject("Button8.AccessibleDescription"), String)
        Me.Button8.AccessibleName = CType(resources.GetObject("Button8.AccessibleName"), String)
        Me.Button8.Anchor = CType(resources.GetObject("Button8.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.Dock = CType(resources.GetObject("Button8.Dock"), System.Windows.Forms.DockStyle)
        Me.Button8.Enabled = CType(resources.GetObject("Button8.Enabled"), Boolean)
        Me.Button8.FlatStyle = CType(resources.GetObject("Button8.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button8.Font = CType(resources.GetObject("Button8.Font"), System.Drawing.Font)
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = CType(resources.GetObject("Button8.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button8.ImageIndex = CType(resources.GetObject("Button8.ImageIndex"), Integer)
        Me.Button8.ImeMode = CType(resources.GetObject("Button8.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button8.Location = CType(resources.GetObject("Button8.Location"), System.Drawing.Point)
        Me.Button8.Name = "Button8"
        Me.Button8.RightToLeft = CType(resources.GetObject("Button8.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button8.Size = CType(resources.GetObject("Button8.Size"), System.Drawing.Size)
        Me.Button8.TabIndex = CType(resources.GetObject("Button8.TabIndex"), Integer)
        Me.Button8.Text = resources.GetString("Button8.Text")
        Me.Button8.TextAlign = CType(resources.GetObject("Button8.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button8.Visible = CType(resources.GetObject("Button8.Visible"), Boolean)
        '
        'Button6
        '
        Me.Button6.AccessibleDescription = CType(resources.GetObject("Button6.AccessibleDescription"), String)
        Me.Button6.AccessibleName = CType(resources.GetObject("Button6.AccessibleName"), String)
        Me.Button6.Anchor = CType(resources.GetObject("Button6.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Dock = CType(resources.GetObject("Button6.Dock"), System.Windows.Forms.DockStyle)
        Me.Button6.Enabled = CType(resources.GetObject("Button6.Enabled"), Boolean)
        Me.Button6.FlatStyle = CType(resources.GetObject("Button6.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button6.Font = CType(resources.GetObject("Button6.Font"), System.Drawing.Font)
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = CType(resources.GetObject("Button6.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button6.ImageIndex = CType(resources.GetObject("Button6.ImageIndex"), Integer)
        Me.Button6.ImeMode = CType(resources.GetObject("Button6.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button6.Location = CType(resources.GetObject("Button6.Location"), System.Drawing.Point)
        Me.Button6.Name = "Button6"
        Me.Button6.RightToLeft = CType(resources.GetObject("Button6.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button6.Size = CType(resources.GetObject("Button6.Size"), System.Drawing.Size)
        Me.Button6.TabIndex = CType(resources.GetObject("Button6.TabIndex"), Integer)
        Me.Button6.Text = resources.GetString("Button6.Text")
        Me.Button6.TextAlign = CType(resources.GetObject("Button6.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button6.Visible = CType(resources.GetObject("Button6.Visible"), Boolean)
        '
        'Button4
        '
        Me.Button4.AccessibleDescription = CType(resources.GetObject("Button4.AccessibleDescription"), String)
        Me.Button4.AccessibleName = CType(resources.GetObject("Button4.AccessibleName"), String)
        Me.Button4.Anchor = CType(resources.GetObject("Button4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Dock = CType(resources.GetObject("Button4.Dock"), System.Windows.Forms.DockStyle)
        Me.Button4.Enabled = CType(resources.GetObject("Button4.Enabled"), Boolean)
        Me.Button4.FlatStyle = CType(resources.GetObject("Button4.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button4.Font = CType(resources.GetObject("Button4.Font"), System.Drawing.Font)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = CType(resources.GetObject("Button4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button4.ImageIndex = CType(resources.GetObject("Button4.ImageIndex"), Integer)
        Me.Button4.ImeMode = CType(resources.GetObject("Button4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button4.Location = CType(resources.GetObject("Button4.Location"), System.Drawing.Point)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = CType(resources.GetObject("Button4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button4.Size = CType(resources.GetObject("Button4.Size"), System.Drawing.Size)
        Me.Button4.TabIndex = CType(resources.GetObject("Button4.TabIndex"), Integer)
        Me.Button4.Text = resources.GetString("Button4.Text")
        Me.Button4.TextAlign = CType(resources.GetObject("Button4.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button4.Visible = CType(resources.GetObject("Button4.Visible"), Boolean)
        '
        'Button3
        '
        Me.Button3.AccessibleDescription = CType(resources.GetObject("Button3.AccessibleDescription"), String)
        Me.Button3.AccessibleName = CType(resources.GetObject("Button3.AccessibleName"), String)
        Me.Button3.Anchor = CType(resources.GetObject("Button3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Dock = CType(resources.GetObject("Button3.Dock"), System.Windows.Forms.DockStyle)
        Me.Button3.Enabled = CType(resources.GetObject("Button3.Enabled"), Boolean)
        Me.Button3.FlatStyle = CType(resources.GetObject("Button3.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button3.Font = CType(resources.GetObject("Button3.Font"), System.Drawing.Font)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = CType(resources.GetObject("Button3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button3.ImageIndex = CType(resources.GetObject("Button3.ImageIndex"), Integer)
        Me.Button3.ImeMode = CType(resources.GetObject("Button3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button3.Location = CType(resources.GetObject("Button3.Location"), System.Drawing.Point)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = CType(resources.GetObject("Button3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button3.Size = CType(resources.GetObject("Button3.Size"), System.Drawing.Size)
        Me.Button3.TabIndex = CType(resources.GetObject("Button3.TabIndex"), Integer)
        Me.Button3.Text = resources.GetString("Button3.Text")
        Me.Button3.TextAlign = CType(resources.GetObject("Button3.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button3.Visible = CType(resources.GetObject("Button3.Visible"), Boolean)
        '
        'Button5
        '
        Me.Button5.AccessibleDescription = CType(resources.GetObject("Button5.AccessibleDescription"), String)
        Me.Button5.AccessibleName = CType(resources.GetObject("Button5.AccessibleName"), String)
        Me.Button5.Anchor = CType(resources.GetObject("Button5.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Dock = CType(resources.GetObject("Button5.Dock"), System.Windows.Forms.DockStyle)
        Me.Button5.Enabled = CType(resources.GetObject("Button5.Enabled"), Boolean)
        Me.Button5.FlatStyle = CType(resources.GetObject("Button5.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button5.Font = CType(resources.GetObject("Button5.Font"), System.Drawing.Font)
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = CType(resources.GetObject("Button5.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button5.ImageIndex = CType(resources.GetObject("Button5.ImageIndex"), Integer)
        Me.Button5.ImeMode = CType(resources.GetObject("Button5.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button5.Location = CType(resources.GetObject("Button5.Location"), System.Drawing.Point)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = CType(resources.GetObject("Button5.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button5.Size = CType(resources.GetObject("Button5.Size"), System.Drawing.Size)
        Me.Button5.TabIndex = CType(resources.GetObject("Button5.TabIndex"), Integer)
        Me.Button5.Text = resources.GetString("Button5.Text")
        Me.Button5.TextAlign = CType(resources.GetObject("Button5.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button5.Visible = CType(resources.GetObject("Button5.Visible"), Boolean)
        '
        'ListBox2
        '
        Me.ListBox2.AccessibleDescription = CType(resources.GetObject("ListBox2.AccessibleDescription"), String)
        Me.ListBox2.AccessibleName = CType(resources.GetObject("ListBox2.AccessibleName"), String)
        Me.ListBox2.Anchor = CType(resources.GetObject("ListBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.BackgroundImage = CType(resources.GetObject("ListBox2.BackgroundImage"), System.Drawing.Image)
        Me.ListBox2.ColumnWidth = CType(resources.GetObject("ListBox2.ColumnWidth"), Integer)
        Me.ListBox2.Dock = CType(resources.GetObject("ListBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.ListBox2.Enabled = CType(resources.GetObject("ListBox2.Enabled"), Boolean)
        Me.ListBox2.Font = CType(resources.GetObject("ListBox2.Font"), System.Drawing.Font)
        Me.ListBox2.HorizontalExtent = CType(resources.GetObject("ListBox2.HorizontalExtent"), Integer)
        Me.ListBox2.HorizontalScrollbar = CType(resources.GetObject("ListBox2.HorizontalScrollbar"), Boolean)
        Me.ListBox2.ImeMode = CType(resources.GetObject("ListBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListBox2.IntegralHeight = CType(resources.GetObject("ListBox2.IntegralHeight"), Boolean)
        Me.ListBox2.ItemHeight = CType(resources.GetObject("ListBox2.ItemHeight"), Integer)
        Me.ListBox2.Location = CType(resources.GetObject("ListBox2.Location"), System.Drawing.Point)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.RightToLeft = CType(resources.GetObject("ListBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListBox2.ScrollAlwaysVisible = CType(resources.GetObject("ListBox2.ScrollAlwaysVisible"), Boolean)
        Me.ListBox2.Size = CType(resources.GetObject("ListBox2.Size"), System.Drawing.Size)
        Me.ListBox2.TabIndex = CType(resources.GetObject("ListBox2.TabIndex"), Integer)
        Me.ListBox2.Visible = CType(resources.GetObject("ListBox2.Visible"), Boolean)
        '
        'DsSpO2rpt1
        '
        Me.DsSpO2rpt1.DataSetName = "dsSpO2rpt"
        Me.DsSpO2rpt1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsSpO2rpt1.Namespace = "http://www.tempuri.org/dsSpO2rpt.xsd"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = resources.GetString("OpenFileDialog1.Filter")
        Me.OpenFileDialog1.Title = resources.GetString("OpenFileDialog1.Title")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.Title = resources.GetString("SaveFileDialog1.Title")
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.FileName = "doc1"
        Me.SaveFileDialog2.Filter = resources.GetString("SaveFileDialog2.Filter")
        Me.SaveFileDialog2.Title = resources.GetString("SaveFileDialog2.Title")
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\oxistat1dot0\OxistatAccessDB.mdb;Mode=Share Deny None;Extended Properties" & _
        "="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database P" & _
        "assword="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:G" & _
        "lobal Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Data" & _
        "base Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Databa" & _
        "se=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without " & _
        "Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Address, City, Comments, CustomerID, FirstName, LastName, OrgID, PatientFa" & _
        "x, PatientID, PatientPhone, Physican, ReportsNumSaved, StartDate, State, Zip FRO" & _
        "M Patients"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Patients(Address, City, Comments, CustomerID, FirstName, LastName, Or" & _
        "gID, PatientFax, PatientPhone, Physican, ReportsNumSaved, StartDate, State, Zip)" & _
        " VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Physican", System.Data.OleDb.OleDbType.VarWChar, 50, "Physican"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportsNumSaved"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.DBDate, 0, "StartDate"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 50, "State"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 50, "Zip"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE Patients SET Address = ?, City = ?, Comments = ?, CustomerID = ?, FirstNam" & _
        "e = ?, LastName = ?, OrgID = ?, PatientFax = ?, PatientPhone = ?, Physican = ?, " & _
        "ReportsNumSaved = ?, StartDate = ?, State = ?, Zip = ? WHERE (PatientID = ?) AND" & _
        " (Address = ? OR ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND C" & _
        "ity IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS NULL) AND (CustomerI" & _
        "D = ? OR ? IS NULL AND CustomerID IS NULL) AND (FirstName = ? OR ? IS NULL AND F" & _
        "irstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (OrgI" & _
        "D = ? OR ? IS NULL AND OrgID IS NULL) AND (PatientFax = ? OR ? IS NULL AND Patie" & _
        "ntFax IS NULL) AND (PatientPhone = ? OR ? IS NULL AND PatientPhone IS NULL) AND " & _
        "(Physican = ? OR ? IS NULL AND Physican IS NULL) AND (ReportsNumSaved = ? OR ? I" & _
        "S NULL AND ReportsNumSaved IS NULL) AND (StartDate = ? OR ? IS NULL AND StartDat" & _
        "e IS NULL) AND (State = ? OR ? IS NULL AND State IS NULL) AND (Zip = ? OR ? IS N" & _
        "ULL AND Zip IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Physican", System.Data.OleDb.OleDbType.VarWChar, 50, "Physican"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportsNumSaved"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.DBDate, 0, "StartDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 50, "State"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 50, "Zip"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM Patients WHERE (PatientID = ?) AND (Address = ? OR ? IS NULL AND Addr" & _
        "ess IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Comments = ? OR ?" & _
        " IS NULL AND Comments IS NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID I" & _
        "S NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ?" & _
        " OR ? IS NULL AND LastName IS NULL) AND (OrgID = ? OR ? IS NULL AND OrgID IS NUL" & _
        "L) AND (PatientFax = ? OR ? IS NULL AND PatientFax IS NULL) AND (PatientPhone = " & _
        "? OR ? IS NULL AND PatientPhone IS NULL) AND (Physican = ? OR ? IS NULL AND Phys" & _
        "ican IS NULL) AND (ReportsNumSaved = ? OR ? IS NULL AND ReportsNumSaved IS NULL)" & _
        " AND (StartDate = ? OR ? IS NULL AND StartDate IS NULL) AND (State = ? OR ? IS N" & _
        "ULL AND State IS NULL) AND (Zip = ? OR ? IS NULL AND Zip IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'daPatients
        '
        Me.daPatients.DeleteCommand = Me.OleDbDeleteCommand2
        Me.daPatients.InsertCommand = Me.OleDbInsertCommand2
        Me.daPatients.SelectCommand = Me.OleDbSelectCommand2
        Me.daPatients.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Patients", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Physican", "Physican"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("StartDate", "StartDate"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("State", "State"), New System.Data.Common.DataColumnMapping("Zip", "Zip"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("OrgID", "OrgID"), New System.Data.Common.DataColumnMapping("PatientPhone", "PatientPhone"), New System.Data.Common.DataColumnMapping("PatientFax", "PatientFax"), New System.Data.Common.DataColumnMapping("ReportsNumSaved", "ReportsNumSaved")})})
        Me.daPatients.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsPatientsForm1.Patients
        '
        'daHRrpt
        '
        Me.daHRrpt.DeleteCommand = Me.OleDbDeleteCommand4
        Me.daHRrpt.InsertCommand = Me.OleDbInsertCommand4
        Me.daHRrpt.SelectCommand = Me.OleDbSelectCommand4
        Me.daHRrpt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CrystalReportsHRData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("HRDataKey", "HRDataKey"), New System.Data.Common.DataColumnMapping("HR", "HR"), New System.Data.Common.DataColumnMapping("SampleTime", "SampleTime")})})
        Me.daHRrpt.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM CrystalReportsHRData WHERE (HRDataKey = ?) AND (SampleTime = ? OR ? I" & _
        "S NULL AND SampleTime IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRDataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HRDataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO CrystalReportsHRData(HR, SampleTime) VALUES (?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("HR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SampleTime"))
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT HR, HRDataKey, SampleTime FROM CrystalReportsHRData"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE CrystalReportsHRData SET HR = ?, SampleTime = ? WHERE (HRDataKey = ?) AND " & _
        "(SampleTime = ? OR ? IS NULL AND SampleTime IS NULL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("HR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SampleTime"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRDataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HRDataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'daSpO2rpt
        '
        Me.daSpO2rpt.DeleteCommand = Me.OleDbDeleteCommand5
        Me.daSpO2rpt.InsertCommand = Me.OleDbInsertCommand5
        Me.daSpO2rpt.SelectCommand = Me.OleDbSelectCommand5
        Me.daSpO2rpt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CrystalReportsSpO2Data", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SpO2DataKey", "SpO2DataKey"), New System.Data.Common.DataColumnMapping("SpO2", "SpO2"), New System.Data.Common.DataColumnMapping("SampleTime", "SampleTime")})})
        Me.daSpO2rpt.UpdateCommand = Me.OleDbUpdateCommand5
        '
        'OleDbDeleteCommand5
        '
        Me.OleDbDeleteCommand5.CommandText = "DELETE FROM CrystalReportsSpO2Data WHERE (SpO2DataKey = ?) AND (SampleTime = ? OR" & _
        " ? IS NULL AND SampleTime IS NULL)"
        Me.OleDbDeleteCommand5.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SpO2DataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2DataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand5
        '
        Me.OleDbInsertCommand5.CommandText = "INSERT INTO CrystalReportsSpO2Data(SampleTime, SpO2) VALUES (?, ?)"
        Me.OleDbInsertCommand5.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SampleTime"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbSelectCommand5
        '
        Me.OleDbSelectCommand5.CommandText = "SELECT SampleTime, SpO2, SpO2DataKey FROM CrystalReportsSpO2Data"
        Me.OleDbSelectCommand5.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand5
        '
        Me.OleDbUpdateCommand5.CommandText = "UPDATE CrystalReportsSpO2Data SET SampleTime = ?, SpO2 = ? WHERE (SpO2DataKey = ?" & _
        ") AND (SampleTime = ? OR ? IS NULL AND SampleTime IS NULL)"
        Me.OleDbUpdateCommand5.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SampleTime"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SpO2DataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2DataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsHRrpt1
        '
        Me.DsHRrpt1.DataSetName = "dsHRrpt"
        Me.DsHRrpt1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsHRrpt1.Namespace = "http://www.tempuri.org/dsHRrpt.xsd"
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\oxistat1dot0\OxistatAccessDB.mdb;Mode=Share Deny None;Extended Properties" & _
        "="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database P" & _
        "assword="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:G" & _
        "lobal Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Data" & _
        "base Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Databa" & _
        "se=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without " & _
        "Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT AnalysisData, averageHR, AverageSpO2, CollectionEndDate, CollectionStartDa" & _
        "te, Comments, CustomerID, DateOfReport, DesatIncidenceIndex, DesatLessThan3minsA" & _
        "vgTime, DesatLessThen3minsAvgTimeInMin, DesatLessThen3minsAvgTimeInSec, Desatles" & _
        "sThen3minsNum, desatOver3minCount, desatOver4minCount, desatOver4minTime, desatU" & _
        "nder1minCount, desatUnder1minTime, desatUnder2minCount, desatUnder2minTime, desa" & _
        "tUnder3minCount, desatUnder3minTime, desatUnder4minCount, desatUnder4minTime, Ex" & _
        "cludedData, ExcludedEventsCount, highHR, HighSpO2, LongestDesatCustomDuration, L" & _
        "ongestDesatCustomValue, lowHR, LowSpO2, OrgAddress, OrgCity, OrgID, OrgName, Org" & _
        "OfficeFax, OrgOfficePhone, OrgState, OrgZipCode, PatientAddress, PatientCity, Pa" & _
        "tientFax, PatientFirstName, PatientID, PatientLastName, PatientPhone, PatientSta" & _
        "te, PatientZip, RecordedData, ReportID, RequestingMD, RptDataKey, SpO2custom, Ti" & _
        "meSpO260, TimeSpO260Percent, TimeSpO270, TimeSpO270Percent, TimeSpO280, TimeSpO2" & _
        "80Percent, TimeSpO290, TimeSpO290Percent, TimeSpO2custom, TimeSpO2CustomPercent " & _
        "FROM CrystalReportsRptData"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection2
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO CrystalReportsRptData(AnalysisData, averageHR, AverageSpO2, Collectio" & _
        "nEndDate, CollectionStartDate, Comments, CustomerID, DateOfReport, DesatIncidenc" & _
        "eIndex, DesatLessThan3minsAvgTime, DesatLessThen3minsAvgTimeInMin, DesatLessThen" & _
        "3minsAvgTimeInSec, DesatlessThen3minsNum, desatOver3minCount, desatOver4minCount" & _
        ", desatOver4minTime, desatUnder1minCount, desatUnder1minTime, desatUnder2minCoun" & _
        "t, desatUnder2minTime, desatUnder3minCount, desatUnder3minTime, desatUnder4minCo" & _
        "unt, desatUnder4minTime, ExcludedData, ExcludedEventsCount, highHR, HighSpO2, Lo" & _
        "ngestDesatCustomDuration, LongestDesatCustomValue, lowHR, LowSpO2, OrgAddress, O" & _
        "rgCity, OrgID, OrgName, OrgOfficeFax, OrgOfficePhone, OrgState, OrgZipCode, Pati" & _
        "entAddress, PatientCity, PatientFax, PatientFirstName, PatientID, PatientLastNam" & _
        "e, PatientPhone, PatientState, PatientZip, RecordedData, ReportID, RequestingMD," & _
        " SpO2custom, TimeSpO260, TimeSpO260Percent, TimeSpO270, TimeSpO270Percent, TimeS" & _
        "pO280, TimeSpO280Percent, TimeSpO290, TimeSpO290Percent, TimeSpO2custom, TimeSpO" & _
        "2CustomPercent) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, "AnalysisData"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("averageHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "averageHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AverageSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AverageSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionEndDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionStartDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, "DateOfReport"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatLessThan3minsAvgTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInMin", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInMin", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInSec", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInSec", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatlessThen3minsNum", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatlessThen3minsNum", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatOver4minTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder1minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder1minTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder2minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder2minTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder3minTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder4minTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, "ExcludedData"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedEventsCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ExcludedEventsCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("highHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "highHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("HighSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HighSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomDuration", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomDuration", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomValue", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomValue", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("lowHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "lowHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LowSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LowSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgAddress"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgCity"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficeFax"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficePhone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgState"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgZipCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientAddress"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientCity"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientFirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientLastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientState"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientZip"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, "RecordedData"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, "RequestingMD"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpO2custom", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2custom", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260Percent"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270Percent"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280Percent"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290Percent"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO2custom"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO2CustomPercent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO2CustomPercent"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE CrystalReportsRptData SET AnalysisData = ?, averageHR = ?, AverageSpO2 = ?" & _
        ", CollectionEndDate = ?, CollectionStartDate = ?, Comments = ?, CustomerID = ?, " & _
        "DateOfReport = ?, DesatIncidenceIndex = ?, DesatLessThan3minsAvgTime = ?, DesatL" & _
        "essThen3minsAvgTimeInMin = ?, DesatLessThen3minsAvgTimeInSec = ?, DesatlessThen3" & _
        "minsNum = ?, desatOver3minCount = ?, desatOver4minCount = ?, desatOver4minTime =" & _
        " ?, desatUnder1minCount = ?, desatUnder1minTime = ?, desatUnder2minCount = ?, de" & _
        "satUnder2minTime = ?, desatUnder3minCount = ?, desatUnder3minTime = ?, desatUnde" & _
        "r4minCount = ?, desatUnder4minTime = ?, ExcludedData = ?, ExcludedEventsCount = " & _
        "?, highHR = ?, HighSpO2 = ?, LongestDesatCustomDuration = ?, LongestDesatCustomV" & _
        "alue = ?, lowHR = ?, LowSpO2 = ?, OrgAddress = ?, OrgCity = ?, OrgID = ?, OrgNam" & _
        "e = ?, OrgOfficeFax = ?, OrgOfficePhone = ?, OrgState = ?, OrgZipCode = ?, Patie" & _
        "ntAddress = ?, PatientCity = ?, PatientFax = ?, PatientFirstName = ?, PatientID " & _
        "= ?, PatientLastName = ?, PatientPhone = ?, PatientState = ?, PatientZip = ?, Re" & _
        "cordedData = ?, ReportID = ?, RequestingMD = ?, SpO2custom = ?, TimeSpO260 = ?, " & _
        "TimeSpO260Percent = ?, TimeSpO270 = ?, TimeSpO270Percent = ?, TimeSpO280 = ?, Ti" & _
        "meSpO280Percent = ?, TimeSpO290 = ?, TimeSpO290Percent = ?, TimeSpO2custom = ?, " & _
        "TimeSpO2CustomPercent = ? WHERE (RptDataKey = ?) AND (AnalysisData = ? OR ? IS N" & _
        "ULL AND AnalysisData IS NULL) AND (CollectionEndDate = ? OR ? IS NULL AND Collec" & _
        "tionEndDate IS NULL) AND (CollectionStartDate = ? OR ? IS NULL AND CollectionSta" & _
        "rtDate IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS NULL) AND (Custom" & _
        "erID = ? OR ? IS NULL AND CustomerID IS NULL) AND (DateOfReport = ? OR ? IS NULL" & _
        " AND DateOfReport IS NULL) AND (DesatIncidenceIndex = ? OR ? IS NULL AND DesatIn" & _
        "cidenceIndex IS NULL) AND (DesatLessThan3minsAvgTime = ? OR ? IS NULL AND DesatL" & _
        "essThan3minsAvgTime IS NULL) AND (ExcludedData = ? OR ? IS NULL AND ExcludedData" & _
        " IS NULL) AND (OrgAddress = ? OR ? IS NULL AND OrgAddress IS NULL) AND (OrgCity " & _
        "= ? OR ? IS NULL AND OrgCity IS NULL) AND (OrgID = ? OR ? IS NULL AND OrgID IS N" & _
        "ULL) AND (OrgName = ? OR ? IS NULL AND OrgName IS NULL) AND (OrgOfficeFax = ? OR" & _
        " ? IS NULL AND OrgOfficeFax IS NULL) AND (OrgOfficePhone = ? OR ? IS NULL AND Or" & _
        "gOfficePhone IS NULL) AND (OrgState = ? OR ? IS NULL AND OrgState IS NULL) AND (" & _
        "OrgZipCode = ? OR ? IS NULL AND OrgZipCode IS NULL) AND (PatientAddress = ? OR ?" & _
        " IS NULL AND PatientAddress IS NULL) AND (PatientCity = ? OR ? IS NULL AND Patie" & _
        "ntCity IS NULL) AND (PatientFax = ? OR ? IS NULL AND PatientFax IS NULL) AND (Pa" & _
        "tientFirstName = ? OR ? IS NULL AND PatientFirstName IS NULL) AND (PatientID = ?" & _
        " OR ? IS NULL AND PatientID IS NULL) AND (PatientLastName = ? OR ? IS NULL AND P" & _
        "atientLastName IS NULL) AND (PatientPhone = ? OR ? IS NULL AND PatientPhone IS N" & _
        "ULL) AND (PatientState = ? OR ? IS NULL AND PatientState IS NULL) AND (PatientZi" & _
        "p = ? OR ? IS NULL AND PatientZip IS NULL) AND (RecordedData = ? OR ? IS NULL AN" & _
        "D RecordedData IS NULL) AND (ReportID = ? OR ? IS NULL AND ReportID IS NULL) AND" & _
        " (RequestingMD = ? OR ? IS NULL AND RequestingMD IS NULL) AND (TimeSpO260 = ? OR" & _
        " ? IS NULL AND TimeSpO260 IS NULL) AND (TimeSpO260Percent = ? OR ? IS NULL AND T" & _
        "imeSpO260Percent IS NULL) AND (TimeSpO270 = ? OR ? IS NULL AND TimeSpO270 IS NUL" & _
        "L) AND (TimeSpO270Percent = ? OR ? IS NULL AND TimeSpO270Percent IS NULL) AND (T" & _
        "imeSpO280 = ? OR ? IS NULL AND TimeSpO280 IS NULL) AND (TimeSpO280Percent = ? OR" & _
        " ? IS NULL AND TimeSpO280Percent IS NULL) AND (TimeSpO290 = ? OR ? IS NULL AND T" & _
        "imeSpO290 IS NULL) AND (TimeSpO290Percent = ? OR ? IS NULL AND TimeSpO290Percent" & _
        " IS NULL) AND (TimeSpO2CustomPercent = ? OR ? IS NULL AND TimeSpO2CustomPercent " & _
        "IS NULL) AND (TimeSpO2custom = ? OR ? IS NULL AND TimeSpO2custom IS NULL) AND (d" & _
        "esatOver4minTime = ? OR ? IS NULL AND desatOver4minTime IS NULL) AND (desatUnder" & _
        "1minTime = ? OR ? IS NULL AND desatUnder1minTime IS NULL) AND (desatUnder2minTim" & _
        "e = ? OR ? IS NULL AND desatUnder2minTime IS NULL) AND (desatUnder3minTime = ? O" & _
        "R ? IS NULL AND desatUnder3minTime IS NULL) AND (desatUnder4minTime = ? OR ? IS " & _
        "NULL AND desatUnder4minTime IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, "AnalysisData"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("averageHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "averageHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AverageSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AverageSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionEndDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionStartDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, "DateOfReport"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatLessThan3minsAvgTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInMin", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInMin", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInSec", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInSec", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatlessThen3minsNum", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatlessThen3minsNum", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatOver4minTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder1minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder1minTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder2minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder2minTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder3minTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder4minTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, "ExcludedData"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedEventsCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ExcludedEventsCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("highHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "highHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("HighSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HighSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomDuration", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomDuration", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomValue", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomValue", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("lowHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "lowHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LowSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LowSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgAddress"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgCity"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficeFax"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficePhone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgState"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgZipCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientAddress"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientCity"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientFirstName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientLastName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientState"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientZip"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, "RecordedData"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, "RequestingMD"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpO2custom", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2custom", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260Percent"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270Percent"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280Percent"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290Percent"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO2custom"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO2CustomPercent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO2CustomPercent"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptDataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RptDataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2601", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2701", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2801", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2901", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2CustomPercent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2CustomPercent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2CustomPercent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2CustomPercent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM CrystalReportsRptData WHERE (RptDataKey = ?) AND (AnalysisData = ? OR" & _
        " ? IS NULL AND AnalysisData IS NULL) AND (CollectionEndDate = ? OR ? IS NULL AND" & _
        " CollectionEndDate IS NULL) AND (CollectionStartDate = ? OR ? IS NULL AND Collec" & _
        "tionStartDate IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS NULL) AND " & _
        "(CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (DateOfReport = ? OR ? " & _
        "IS NULL AND DateOfReport IS NULL) AND (DesatIncidenceIndex = ? OR ? IS NULL AND " & _
        "DesatIncidenceIndex IS NULL) AND (DesatLessThan3minsAvgTime = ? OR ? IS NULL AND" & _
        " DesatLessThan3minsAvgTime IS NULL) AND (ExcludedData = ? OR ? IS NULL AND Exclu" & _
        "dedData IS NULL) AND (OrgAddress = ? OR ? IS NULL AND OrgAddress IS NULL) AND (O" & _
        "rgCity = ? OR ? IS NULL AND OrgCity IS NULL) AND (OrgID = ? OR ? IS NULL AND Org" & _
        "ID IS NULL) AND (OrgName = ? OR ? IS NULL AND OrgName IS NULL) AND (OrgOfficeFax" & _
        " = ? OR ? IS NULL AND OrgOfficeFax IS NULL) AND (OrgOfficePhone = ? OR ? IS NULL" & _
        " AND OrgOfficePhone IS NULL) AND (OrgState = ? OR ? IS NULL AND OrgState IS NULL" & _
        ") AND (OrgZipCode = ? OR ? IS NULL AND OrgZipCode IS NULL) AND (PatientAddress =" & _
        " ? OR ? IS NULL AND PatientAddress IS NULL) AND (PatientCity = ? OR ? IS NULL AN" & _
        "D PatientCity IS NULL) AND (PatientFax = ? OR ? IS NULL AND PatientFax IS NULL) " & _
        "AND (PatientFirstName = ? OR ? IS NULL AND PatientFirstName IS NULL) AND (Patien" & _
        "tID = ? OR ? IS NULL AND PatientID IS NULL) AND (PatientLastName = ? OR ? IS NUL" & _
        "L AND PatientLastName IS NULL) AND (PatientPhone = ? OR ? IS NULL AND PatientPho" & _
        "ne IS NULL) AND (PatientState = ? OR ? IS NULL AND PatientState IS NULL) AND (Pa" & _
        "tientZip = ? OR ? IS NULL AND PatientZip IS NULL) AND (RecordedData = ? OR ? IS " & _
        "NULL AND RecordedData IS NULL) AND (ReportID = ? OR ? IS NULL AND ReportID IS NU" & _
        "LL) AND (RequestingMD = ? OR ? IS NULL AND RequestingMD IS NULL) AND (TimeSpO260" & _
        " = ? OR ? IS NULL AND TimeSpO260 IS NULL) AND (TimeSpO260Percent = ? OR ? IS NUL" & _
        "L AND TimeSpO260Percent IS NULL) AND (TimeSpO270 = ? OR ? IS NULL AND TimeSpO270" & _
        " IS NULL) AND (TimeSpO270Percent = ? OR ? IS NULL AND TimeSpO270Percent IS NULL)" & _
        " AND (TimeSpO280 = ? OR ? IS NULL AND TimeSpO280 IS NULL) AND (TimeSpO280Percent" & _
        " = ? OR ? IS NULL AND TimeSpO280Percent IS NULL) AND (TimeSpO290 = ? OR ? IS NUL" & _
        "L AND TimeSpO290 IS NULL) AND (TimeSpO290Percent = ? OR ? IS NULL AND TimeSpO290" & _
        "Percent IS NULL) AND (TimeSpO2CustomPercent = ? OR ? IS NULL AND TimeSpO2CustomP" & _
        "ercent IS NULL) AND (TimeSpO2custom = ? OR ? IS NULL AND TimeSpO2custom IS NULL)" & _
        " AND (desatOver4minTime = ? OR ? IS NULL AND desatOver4minTime IS NULL) AND (des" & _
        "atUnder1minTime = ? OR ? IS NULL AND desatUnder1minTime IS NULL) AND (desatUnder" & _
        "2minTime = ? OR ? IS NULL AND desatUnder2minTime IS NULL) AND (desatUnder3minTim" & _
        "e = ? OR ? IS NULL AND desatUnder3minTime IS NULL) AND (desatUnder4minTime = ? O" & _
        "R ? IS NULL AND desatUnder4minTime IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptDataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RptDataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2601", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2701", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2801", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2901", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2CustomPercent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2CustomPercent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2CustomPercent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2CustomPercent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'daRpt
        '
        Me.daRpt.DeleteCommand = Me.OleDbDeleteCommand1
        Me.daRpt.InsertCommand = Me.OleDbInsertCommand1
        Me.daRpt.SelectCommand = Me.OleDbSelectCommand1
        Me.daRpt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CrystalReportsRptData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrgName", "OrgName"), New System.Data.Common.DataColumnMapping("OrgAddress", "OrgAddress"), New System.Data.Common.DataColumnMapping("OrgCity", "OrgCity"), New System.Data.Common.DataColumnMapping("OrgState", "OrgState"), New System.Data.Common.DataColumnMapping("OrgZipCode", "OrgZipCode"), New System.Data.Common.DataColumnMapping("OrgOfficePhone", "OrgOfficePhone"), New System.Data.Common.DataColumnMapping("OrgOfficeFax", "OrgOfficeFax"), New System.Data.Common.DataColumnMapping("DateOfReport", "DateOfReport"), New System.Data.Common.DataColumnMapping("PatientFirstName", "PatientFirstName"), New System.Data.Common.DataColumnMapping("PatientLastName", "PatientLastName"), New System.Data.Common.DataColumnMapping("PatientAddress", "PatientAddress"), New System.Data.Common.DataColumnMapping("PatientCity", "PatientCity"), New System.Data.Common.DataColumnMapping("PatientState", "PatientState"), New System.Data.Common.DataColumnMapping("PatientPhone", "PatientPhone"), New System.Data.Common.DataColumnMapping("PatientFax", "PatientFax"), New System.Data.Common.DataColumnMapping("PatientZip", "PatientZip"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("ReportID", "ReportID"), New System.Data.Common.DataColumnMapping("RecordedData", "RecordedData"), New System.Data.Common.DataColumnMapping("ExcludedData", "ExcludedData"), New System.Data.Common.DataColumnMapping("AnalysisData", "AnalysisData"), New System.Data.Common.DataColumnMapping("HighSpO2", "HighSpO2"), New System.Data.Common.DataColumnMapping("AverageSpO2", "AverageSpO2"), New System.Data.Common.DataColumnMapping("LowSpO2", "LowSpO2"), New System.Data.Common.DataColumnMapping("TimeSpO290Percent", "TimeSpO290Percent"), New System.Data.Common.DataColumnMapping("TimeSpO280Percent", "TimeSpO280Percent"), New System.Data.Common.DataColumnMapping("TimeSpO270Percent", "TimeSpO270Percent"), New System.Data.Common.DataColumnMapping("TimeSpO260Percent", "TimeSpO260Percent"), New System.Data.Common.DataColumnMapping("TimeSpO2CustomPercent", "TimeSpO2CustomPercent"), New System.Data.Common.DataColumnMapping("TimeSpO290", "TimeSpO290"), New System.Data.Common.DataColumnMapping("TimeSpO280", "TimeSpO280"), New System.Data.Common.DataColumnMapping("TimeSpO270", "TimeSpO270"), New System.Data.Common.DataColumnMapping("TimeSpO260", "TimeSpO260"), New System.Data.Common.DataColumnMapping("TimeSpO2custom", "TimeSpO2custom"), New System.Data.Common.DataColumnMapping("SpO2custom", "SpO2custom"), New System.Data.Common.DataColumnMapping("LongestDesatCustomValue", "LongestDesatCustomValue"), New System.Data.Common.DataColumnMapping("LongestDesatCustomDuration", "LongestDesatCustomDuration"), New System.Data.Common.DataColumnMapping("DesatIncidenceIndex", "DesatIncidenceIndex"), New System.Data.Common.DataColumnMapping("DesatlessThen3minsNum", "DesatlessThen3minsNum"), New System.Data.Common.DataColumnMapping("DesatLessThan3minsAvgTime", "DesatLessThan3minsAvgTime"), New System.Data.Common.DataColumnMapping("DesatLessThen3minsAvgTimeInSec", "DesatLessThen3minsAvgTimeInSec"), New System.Data.Common.DataColumnMapping("DesatLessThen3minsAvgTimeInMin", "DesatLessThen3minsAvgTimeInMin"), New System.Data.Common.DataColumnMapping("desatUnder1minCount", "desatUnder1minCount"), New System.Data.Common.DataColumnMapping("desatUnder2minCount", "desatUnder2minCount"), New System.Data.Common.DataColumnMapping("desatUnder3minCount", "desatUnder3minCount"), New System.Data.Common.DataColumnMapping("desatUnder4minCount", "desatUnder4minCount"), New System.Data.Common.DataColumnMapping("desatOver4minCount", "desatOver4minCount"), New System.Data.Common.DataColumnMapping("desatOver3minCount", "desatOver3minCount"), New System.Data.Common.DataColumnMapping("desatUnder1minTime", "desatUnder1minTime"), New System.Data.Common.DataColumnMapping("desatUnder2minTime", "desatUnder2minTime"), New System.Data.Common.DataColumnMapping("desatUnder3minTime", "desatUnder3minTime"), New System.Data.Common.DataColumnMapping("desatUnder4minTime", "desatUnder4minTime"), New System.Data.Common.DataColumnMapping("desatOver4minTime", "desatOver4minTime"), New System.Data.Common.DataColumnMapping("highHR", "highHR"), New System.Data.Common.DataColumnMapping("averageHR", "averageHR"), New System.Data.Common.DataColumnMapping("lowHR", "lowHR"), New System.Data.Common.DataColumnMapping("RptDataKey", "RptDataKey"), New System.Data.Common.DataColumnMapping("RequestingMD", "RequestingMD"), New System.Data.Common.DataColumnMapping("CollectionStartDate", "CollectionStartDate"), New System.Data.Common.DataColumnMapping("CollectionEndDate", "CollectionEndDate"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("OrgID", "OrgID"), New System.Data.Common.DataColumnMapping("ExcludedEventsCount", "ExcludedEventsCount")})})
        Me.daRpt.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'frmMain
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.mnuMain
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmMain"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPatientsForm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DsSpO2rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHRrpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Standard Menu Code "
        ' <System.Diagnostics.DebuggerStepThrough()> has been added to some procedures since they are
        ' not the focus of the demo. Remove them if you wish to debug the procedures.
        ' This code simply shows the About form.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
            ' Open the About form in Dialog Mode
            Dim frm As New frmAbout()
            frm.ShowDialog(Me)
            frm.Dispose()
        End Sub

        ' This code will close the form.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
            ' Close the current form
            Me.Close()
        End Sub
#End Region
        '======================================================================================
        '  ***********************************************
        '  *  Executive functions                        *
        '  *                                             *
        '  *  These functions try to hide implementation *
        '  *  details from the Windows Event programmer  *
        '  *  These functions try to present Oximeter    *
        '  *  Data easily to the programmer.             *
        '  *                                             *
        '  *  Functions include                          *
        '  *    gettime - Returns times in each Oximeter *
        '  *    file from the data stream                *
        '  *                                             *
        '  *    getdata - returns HR/SpO2 data in each   *
        '  *              Oximeter file from raw data    *
        '  ***********************************************

        ' **************************************************************
        ' *  Function: goodMemoryRead.                                 *
        ' *           Called after a successful memory read.           *
    ' *            Post memory read processing functions are called *
    ' *           here. Steps here are finding headers, and        *
    ' *           presenting found headers                         *
        ' *           The outputs of these functions are stored in     *
        ' *           variables and structures global to this class    *
    ' *           Main.                                            *
        ' **************************************************************

        Sub goodMemoryRead()
        getheaders()

            Dim HeaderSummaries(30) As String
            filesToTimes(HeaderSummaries)
            Dim x As Integer

        ListBox1.Items.Clear()

        If (CInt(HeaderSummaries(0)) > 0) Then
            For x = 1 To CInt(HeaderSummaries(0))
                ListBox1.Items.Add(HeaderSummaries(x))
            Next x
        End If
        Application.DoEvents()


        filesToTimes(HeaderSummaries)
        ListBox3.Items.Clear()
        ListBox3.Visible = True


        If (CInt(HeaderSummaries(0)) > 0) Then

            For x = 1 To CInt(HeaderSummaries(0))
                ListBox3.Items.Add(HeaderSummaries(x))
            Next x
        End If


        OxiDataPresent = True
        Label46.Visible = False
        Label3.Visible = True
        ListBox1.Visible = True

        Application.DoEvents()

        End Sub


    ' ====================================================================
        ' **************************************************************
        ' *  Function: generateReportData. Generates all the data      *
        ' *            needed to put onto a report. This subroutine    *
        ' *            will call subroutines for averages, SpO2 times  *
        ' *            and desaturation times and events.              *
        ' *            All of the data needed for the report will be   *
        ' *            placed in a report data structure.              *
        ' *            Report data can then be pulled out of this      *
        ' *            structure at will and included into the         *
        ' *            report of your choice. The subroutine generates *
        ' *            the raw data.                                   *
        ' *                                                            *
        ' *  Inputs:                                                   *
        ' *   Arg 1:  The file number of the data for which to generate*
        ' *            the report data.                                *
        ' *                                                            *
        ' *  Outputs:                                                  *
        ' *   Arg 2: A structure to hold all the report data           *
        ' *                                                            *
        ' **************************************************************
        Sub generateReportData(ByVal file As Integer, ByRef rd As rptData)

            'Public Structure medStats
            ' Dim HR As statsType
            ' Dim SpO2 As statsType
            ' End Structure

            Dim rptTimes As times
            Dim runningTime As Double

            Dim startTime As Date
            Dim stopTime As Date
            Dim desatTotalTime As Date
            Dim stats As medStats

            Dim RunLength As System.TimeSpan
            Dim analysisSec As Integer
            Dim analysisMin As Integer
            Dim analysisHour As Integer

        gettime(file, rptTimes)

        rd.DataCollectionStartDate = CDate("#" + Str(rptTimes.StartN.month) + "/" + Str(rptTimes.StartN.day) _
                                     + "/" + Str(rptTimes.StartN.year) + " " + Str(rptTimes.StartN.hour) _
                                     + ":" + Str(rptTimes.StartN.minute) + ":" + Str(rptTimes.StartN.second) + "#")

        rd.DataCollectionEndDate = CDate("#" + Str(rptTimes.stopN.month) + "/" + Str(rptTimes.stopN.day) _
                                     + "/" + Str(rptTimes.stopN.year) + " " + Str(rptTimes.stopN.hour) _
                                     + ":" + Str(rptTimes.stopN.minute) + ":" + Str(rptTimes.stopN.second) + "#")


        rd.DateOfReport = CDate("#" + Str(rptTimes.startFirst.month) + "/" + Str(rptTimes.startFirst.day) _
                                    + "/" + Str(rptTimes.startFirst.year) + " " + Str(rptTimes.startFirst.hour) _
                                    + ":" + Str(rptTimes.startFirst.minute) + ":" + Str(rptTimes.startFirst.second) + "#")
        ' This call is only to setup the excluded times. The data in temp is not used. This program was designed
        ' so that each data mining function is independent and no common data is shared between them.
        ' This reporting function then, is composed of smaller data mining calls to subroutines and has
        ' integation code glueing all the data together for the report.
        Dim tempdata(131070) As dataType
        getdata(file, tempdata)
        Erase tempdata

            ' Feed these times to the structure to be output. Note: Excluded data should be calculated
        ' from data points excluded by resync, or 0 or 255 values. Ask Pete if this is correct. Guessing.
        rd.RecordedData = oximeterEventLength(rptTimes)
        rd.ExcludedData = DeletedPeriodTime ' Defined as a Global and currently updated in getSpO2HRdata
            ' called by getdata()


            ' Since Datediff function is generally useless for subtracting dates, we do it the hard way.
            RunLength = rd.RecordedData.Subtract(rd.ExcludedData)
            analysisSec = RunLength.Seconds
            analysisMin = RunLength.Minutes
            analysisHour = RunLength.Hours


            rd.AnalysisData = CDate("#" + Str(analysisHour) + ":" + Str(analysisMin) + ":" + Str(analysisSec) + "#")

        ' Calc Sp02 High, Avg and Low
            SpO2HiAvgLow(file, stats) ' get high, average and low of HR and SpO2

            rd.lowHR = stats.HR.Low
            rd.averageHR = stats.HR.Average
            rd.highHR = stats.HR.High

            rd.LowSpO2 = stats.SpO2.Low
            rd.AverageSpO2 = stats.SpO2.Average
        rd.HighSpO2 = stats.SpO2.High

        ' Get time SpO2 below 90, 80, 70, 60
        timeSpO2Below(file, rd.TimeSpO290, rd.TimeSpO280, rd.TimeSpO270, rd.TimeSpO260, rd.TimeSpO2custom, 88)

        ' Get desaturation incidents

        Dim TimeExcludedDueToArtifact As Date
        desaturationIncidents(file, _
                              rd.desatUnder1minTime, rd.desatUnder1minCount, _
                              rd.desatUnder2minTime, rd.desatUnder2minCount, _
                              rd.desatUnder3minTime, rd.desatUnder3minCount, _
                              rd.desatUnder4minTime, rd.desatUnder4minCount, _
                              rd.desatOver4minTime, rd.desatOver4minCount, _
                              rd.secondsOfDesaturationEvents, _
                              TimeExcludedDueToArtifact, _
                              rd.artifactEventsCount)




        ' To calc desaturation incidence
        '1st calculate hours -minutes-seconds  into minutes                                                                                          7*60min + 36min + (57/60sec) or 456.95min
        ' divide by 60min to calculate hours   
        '456.95min/60min=7.6158333 hrs     
        'divide 2 events by hrs  
        '2evts/7.6158333=.2626107   
        'final field solution should round .2626107 to .3 and be displayed.. 
        '***with un healthy studies there are far more desaturation events than Charlie's so typically the number will be something like 45.8 per hour****




        ' Start - generate "Desaturation incident Index"
            ' startTime = CDate("#" + Str(rptTimes.StartN.hour) + ":" + Str(rptTimes.StartN.minute) + ":" + Str(rptTimes.StartN.second) + "#")
            ' stopTime = CDate("#" + Str(rptTimes.stopN.hour) + ":" + Str(rptTimes.stopN.minute) + ":" + Str(rptTimes.stopN.second) + "#")

            startTime = CDate("#" + Str(rptTimes.StartN.hour) + ":" + Str(rptTimes.StartN.minute) + ":" + Str(rptTimes.StartN.second) + "#")
            stopTime = CDate("#" + Str(rptTimes.stopN.hour) + ":" + Str(rptTimes.stopN.minute) + ":" + Str(rptTimes.stopN.second) + "#")

        runningTime = CInt(DateDiff(DateInterval.Minute, startTime, stopTime))

           

        ' The running time will be negative if it spawns over midnight. We convert it here and it becomes non-negative or zero
        If runningTime < 0 Then
            Dim temp As Double = runningTime ' 1440 is number of minutes in 24 hours
            runningTime = 1440 + temp ' as this (temp) is negative, adding a negative is subtracting.
        End If

        If runningTime = 0 Then
            rd.DesatIncidenceIndex = 0.0
        End If

        If runningTime > 0 Then
            rd.DesatIncidenceIndex = (rd.desatUnder1minCount + rd.desatUnder2minCount + rd.desatUnder3minCount) / (runningTime / 60.0)
        End If
        ' End - generate "Desaturation incident Index"


        ' Generate percent times in defined desaturation bands as needed.
        rd.TimeSpO290Percent = Format((dateToMin(rd.TimeSpO290) / runningTime) * 100, "#0.0") + "%"
        rd.TimeSpO280Percent = Format((dateToMin(rd.TimeSpO280) / runningTime) * 100, "#0.0") + "%"
        rd.TimeSpO270Percent = Format((dateToMin(rd.TimeSpO270) / runningTime) * 100, "#0.0") + "%"
        rd.TimeSpO260Percent = Format((dateToMin(rd.TimeSpO260) / runningTime) * 100, "#0.0") + "%"
        rd.TimeSpO2customPercent = Format((dateToMin(rd.TimeSpO2custom) / runningTime) * 100, "#0.0") + "%"

        rd.SpO2custom = 88

        ' Update recorded data and excluded data. Excluded data is calculated by calling getdata() and
        ' from functions called from getdata. Perhaps it needs to be calculated in the desaturation portion.
        ' Ask Pete. Many of the functions above have called getdata() so excluded time should be set. For
        ' now, excluded data is everything that was a 0 or a 255 and was converted to a 777.

        ' Feed these times to the structure to be output. Note: Excluded data should be calculated
        ' from data points excluded by resync, or 0 or 255 values. Ask Pete if this is correct. Guessing.
        rd.ExcludedData = DeletedPeriodTime ' Defined as a Global and currently updated in getSpO2HRdata
        ' called by getdata()

        ' generate stat for "desaturation under three minutes in sentence"
        rd.DesatlessThen3minsNum = rd.desatUnder1minCount + rd.desatUnder2minCount + rd.desatUnder3minCount



        ' Start - generate "average length of desaturation incidents under three minutes"
        ' Add times of all desaturation incidents under or equal to three minutes
        desatTotalTime = CDate("#00:00:00#")

        ' rd.secondsOfDesaturationEvents is the total desaturation times in seconds of all desaturations
        ' from 1sec in length to 3 minutes in length.

        ' Divide by the number of desaturation events and save this time value for display into the 
        ' structure.
        ' This first calculation is for the future and not used in a report currently. It gives
        ' the average desaturation under three minutes as a Date type of value
        If rd.DesatlessThen3minsNum > 0 Then
            rd.DesatLessThan3minsAvgTime = DateAdd(DateInterval.Second, (rd.secondsOfDesaturationEvents \ rd.DesatlessThen3minsNum), desatTotalTime)
        End If

        ' Here we break out the minutes and seconds in case the report needs these.
        ' Check if zero to avoid a divide by zero arithmetic trap
        ' Calc minutes
        If (rd.secondsOfDesaturationEvents > 0) And (rd.DesatlessThen3minsNum > 0) Then
            rd.DesatLessThen3minsAvgTimeInMin = (rd.secondsOfDesaturationEvents \ rd.DesatlessThen3minsNum) \ 60
        Else
            rd.DesatLessThen3minsAvgTimeInMin = 0
        End If
        If (rd.secondsOfDesaturationEvents > 0) And (rd.DesatlessThen3minsNum > 0) Then
            ' calc seconds which is total seconds - minutes above. Leaves a result of seconds remaining.
            rd.DesatLessThen3minsAvgTimeInSec = (rd.secondsOfDesaturationEvents \ rd.DesatlessThen3minsNum) - (rd.DesatLessThen3minsAvgTimeInMin * 60)
            ' End - generate "average length of desaturation incidents under three minutes"
        Else
            rd.DesatLessThen3minsAvgTimeInSec = 0
        End If

    End Sub


    Function dateToMin(ByVal input As Date) As Double
        Dim hours As Double
        Dim minutes As Double

        hours = Val(Format(input, "HH"))
        minutes = Val(Format(input, "mm"))

        Return ((hours * 60) + minutes)

    End Function

    ' **************************************************************
    ' *  Function: getHeaders. Calls the FindHeaders routine with  *
    ' *            the wellknown global buffers of raw data from   *
    ' *            Oximeter (binBuffersInt) and headerArray        *
    ' *            The function is simply to have the programmer   *
    ' *            not need to memorize these globals              *
    ' *            This should be called after a successful memory *
    ' *            read. All the other functions depend on the     *
    ' *            header list in headerArray. See the Data        *
    ' *            structures area.                                *
    ' **************************************************************

    Sub getheaders()
        FindHeaders(binbufferInt, headerArray)
    End Sub

    ' **************************************************************
    ' *  Function: getData. Returns HR and SpO2 data to an array   *
    ' *            built of HR and SpO2 integer pairs              *
    ' *  Inputs:                                                   *
    ' *  Arg 1: file number. Number of the file in the raw Oximete *
    ' *         data stream. Each distinct capture stored in the   *
    ' *         oximeter is considered a file                      *
    ' *  Arg 2: array - This is the array of data pairs to hold    *
    ' *         the HR, SpO2 data                                  *
    ' **************************************************************

    Sub getdata(ByVal file As Integer, ByRef data() As dataType)

        ' First, get the Start Time of the File - the StartN time.
        ' This time will be passed to the getSpO2HR function. The StartN time
        ' is the start of the data readings for the Oximeter run at file number
        ' provided. The file number is converted to the offset in the integer
        ' array of the raw data.
        '
        ' The start time (StartN) is used to store the time the data point
        ' was actually read in the form of the 'date' datatype.
        '
        ' Use 'gettime' function to get the StartN time and pass StartN time to
        ' the getSpO2HR subroutine. The StartN time will be incremented by 4 seconds
        ' for each data point - SPO2 and HR read. They are read every 4 seconds by
        ' the Oximeter when a sensor is connected and it is taking proper readings.
        '
        ' 
        Dim tempTime As times
        Dim StartN As Date
        Dim StopN As Date


        ' Get times
        If (file <= headerArray(0)) Then
            gettime(file, tempTime)
        End If

        oxitimeToVBDateTime(tempTime, StartN, StopN) 'Convert Oxitimes to type Date.


        If (file <= headerArray(0)) Then

            getSpO2HR(headerArray(file), binbufferInt, data, StartN, DeletedPeriodTime)
        End If
    End Sub


    Sub scrub777FromData(ByRef triplet() As dataType)
        Dim x As Integer
        Dim y As Integer = 1
        Dim temp(50000) As dataType
        Dim skip As Boolean = False

        For x = 1 To triplet(0).HR
            If triplet(x).HR = 777 And triplet(x).SpO2 = 777 Then
                skip = True
            End If

            If skip = True Then
                skip = False
            Else
                temp(y).SpO2 = triplet(x).SpO2
                temp(y).HR = triplet(x).HR
                temp(y).timeRecorded = triplet(x).timeRecorded
                y += 1
            End If

        Next x
        ' Bad data will cause the resulting data to be less. We now zero out the locations at the 
        ' end that held data. This probably does not matter, but if you are debugging the array
        ' of triples, it will be very confusing to find data past what the amount is in the (0) location.
        ' Remember, by convention in this program, array(0) is the length of the data in the array.

        For x = y To temp(0).SpO2
            triplet(x).HR = 0
            triplet(x).SpO2 = 0
            triplet(x).timeRecorded = CDate("#00:00:00#")
        Next x

        ' Now, copy the temp array to the output array.
        For x = 1 To y
            triplet(x).HR = temp(x).HR
            triplet(x).SpO2 = temp(x).SpO2
            triplet(x).timeRecorded = temp(x).timeRecorded
        Next x
        ' Set the length of the data in the array.
        triplet(0).HR = y
        triplet(0).SpO2 = y
    End Sub


    ' **************************************************************
    ' *  Function: getRawData. Given a file number (Oxi file), will*
    ' *            return raw data into a byte array you supply.   *
    ' *            The byte array can then be given to the database*
    ' *            to store raw Oximeter byte data.                *
    ' *            The data is then loaded back into the program   *
    ' *            for analysis again.                             *
    ' *                                                            *
    ' *  Inputs:                                                   *
    ' *  Arg 1: file number. Number of the file in the raw Oximeter*
    ' *         data stream. Each distinct capture stored in the   *
    ' *         oximeter is considered a file                      *
    ' *  Arg 2: array - This is the array of bytes      to hold    *
    ' *         the raw Oximeter data destined for storage in the  *
    ' *         OLE record of the database as a binary image       *
    ' *         In theory, the binary image can be up to 2.1 gig.  *
    ' *         This assumes the Jet 4.0 driver and Access 2000.   *
    ' **************************************************************

    Sub getRawData(ByVal file As Integer, ByRef rawData() As Byte, ByRef len As Integer)
        getOneRawDataFile(headerArray(file), binbufferInt, rawData, len)
    End Sub

    ' **************************************************************
    ' *  Function: getTime. Returns Time triplets to an array      *
    ' *            built of time triples. Each triple is           *
    ' *            broken out into distinct time integers as       *
    ' *            second, minute, hour, day, month, year          *
    ' *  Inputs:                                                   *
    ' *  Arg 1: file number. Number of the file in the raw Oximeter*
    ' *         data stream. Each distinct capture stored in the   *
    ' *         oximeter is considered a file                      *
    ' *  Arg 2: array - This is the array of data pairs to hold    *
    ' *         the HR, SpO2 data                                  *
    ' **************************************************************

    Sub gettime(ByVal file As Integer, ByRef data As times)
        gettimesHeader(headerArray(file), binbufferInt, data)
    End Sub






    '======================================================================================
    '
    '  *********************************************************
    '  *  Conversion functions                                 *
    '  *                                                       *
    '  *  These functions convert data to needed formats for   *
    '  *  supporting the mission of the application.           *
    '  *********************************************************


    Function oximeterEventLength(ByVal time As times) As Date
        Dim hours As Integer
        Dim minutes As Integer
        Dim seconds As Integer

        If (time.stopN.hour < time.StartN.hour) Then
            ' We have started a new day
            hours = (24 - time.StartN.hour) + time.stopN.hour
        Else
            ' same day
            hours = time.stopN.hour - time.StartN.hour
        End If

        minutes = time.stopN.minute - time.StartN.minute
        If minutes < 0 Then
            minutes += 60
            If hours > 0 Then
                hours -= 1
            End If
        End If
        seconds = time.stopN.second - time.StartN.second
        If seconds < 0 Then
            seconds += 60
            If minutes > 0 Then
                minutes -= 1
            End If
        End If

        Return (CDate("#" + Str(hours) + ":" + Str(minutes) + ":" + Str(seconds) + "#"))
    End Function


    ' **************************************************************
    ' *  Function: fileToXML. Builds an XML file to reflect all of *
    ' *            the unprocessed data in the file  of the raw    *
    ' *            data stream from the Oximeter. Please recall, we*
    ' *            denote a file as information between headers.   *
    ' *            This information is the three seqences of times *
    ' *            and the HR and SpO2 data pairs.                 *
    ' *  Inputs:                                                   *
    ' *  Arg 1: file     - This is number of the file wanted from  *
    ' *         the raw data stream to turn into XML               *
    ' *  Outputs:                                                  *
    ' *  Arg 2: Array of Strings. This array holds all of the      *
    ' *         generated XML data. Each index of the array holds  *
    ' *         an XML line of data                                *
    ' **************************************************************

    Sub fileToXML(ByVal file As Integer, ByRef container() As String)
        ' Local data structures to persist just for this functinon
        Dim x As Integer = 0
        Dim y As Integer

        Dim tempTime As times
        Dim tempData(30000) As dataType
        ' Get times
        gettime(file, tempTime)
        ' Get Data
        getdata(file, tempData)

        ' Construct the XML

        container(1) = "<rawdata>" ' level 1

        container(2) = "<downloadTimeStamp>Some Time</downloadTimeStamp>" ' level 2

        container(3) = "<File>" + Str(file) ' level 2     File has times and data

        container(4) = "<times>" ' Level 3    Times are StartFirst, StopN, StartN

        container(5) = "<StartFirst>" ' Level 4
        container(6) = "<month>" + Str(tempTime.startFirst.month) + "</month>" ' level 5
        container(7) = "<day>" + Str(tempTime.startFirst.day) + "</day>"
        container(8) = "<year>" + Str(tempTime.startFirst.year) + "</year>"
        container(9) = "<minute>" + Str(tempTime.startFirst.minute) + "</minute>"
        container(10) = "<second>" + Str(tempTime.startFirst.second) + "</second>"
        container(11) = "<hour>" + Str(tempTime.startFirst.hour) + "</hour>"
        container(12) = "</StartFirst>" ' level 4"

        container(13) = "<StopN>" ' Level 4
        container(14) = "<month>" + Str(tempTime.stopN.month) + "</month>" ' level 5
        container(15) = "<day>" + Str(tempTime.stopN.day) + "</day>"
        container(16) = "<year>" + Str(tempTime.stopN.year) + "</year>"
        container(17) = "<minute>" + Str(tempTime.stopN.minute) + "</minute>"
        container(18) = "<second>" + Str(tempTime.stopN.second) + "</second>"
        container(19) = "<hour>" + Str(tempTime.stopN.hour) + "</hour>"
        container(20) = "</StopN>" ' Level 4


        container(21) = "<StartN>" ' Level 4
        container(22) = "<month>" + Str(tempTime.StartN.month) + "</month>" ' level 5
        container(23) = "<day>" + Str(tempTime.StartN.day) + "</day>"
        container(24) = "<year>" + Str(tempTime.StartN.year) + "</year>"
        container(25) = "<minute>" + Str(tempTime.StartN.minute) + "</minute>"
        container(26) = "<second>" + Str(tempTime.StartN.second) + "</second>"
        container(27) = "<hour>" + Str(tempTime.StartN.hour) + "</hour>"
        container(28) = "</StartN>" ' Level 4

        container(29) = "</times>" ' Level 3

        container(30) = "<DataReadings>" ' Level 3

        y = 31 ' This points to the next free location in the array of strings.

        For x = 1 To tempData(0).HR ' The count of the data points found is kept in loc 0.
            ' Level 4 depth XML in this loop
            container(y) = "<reading>" + Str(y - 30) + "</reading>" _
                          + "<SpO2>" + Str(tempData(y - 30).SpO2) + "</SpO2>" _
                          + "<HR>" + Str(tempData(y - 30).HR) + "</HR>" _
                          + "<time>" + Format(tempData(y - 30).timeRecorded, "HH:mm:ss") + "</time>" ' Level 4
            y += 1
        Next x

        container(y) = "</DataReadings>"  ' Level 3"
        y += 1

        container(y) = "</File>" ' Level 2
        y += 1

        container(y) = "</rawdata>" ' Level 1

        container(0) = Str(y) ' number of XML strings in array
    End Sub

    ' **************************************************************
    ' *  Function: filesToTimes. Builds an XML file to reflect all *
    ' *            of the unprocessed data in the files of the raw *
    ' *            data stream from the Oximeter. Please recall, we*
    ' *            denote a file as information between headers.   *
    ' *            This information is the three seqences of times *
    ' *            and the HR and SpO2 data pairs.                 *
    ' *  Inputs:                                                   *
    ' *  Arg 1: None                                               *
    ' *  Outputs:                                                  *
    ' *  Arg 2: Array of Strings. This array holds all of the      *
    ' *         time data suitable for display in a listbox        *
    ' *         to allow the operator to pick a file of interest   *
    ' *         from the Oximeter.  The array of string is as this:*
    ' *         Dim somearray(20) as String                        *
    ' *         Note: The 0th location is used for the number of   *
    ' *         strings placed in the array.                       *
    ' **************************************************************


    Sub filesToTimes(ByRef timeStr() As String)
        Dim x As Integer
        Dim localTimes As times

        Dim StartN As Date
        Dim StopN As Date

        Dim Diff As Integer

        Dim durHours As Integer
        Dim durMinutes As Integer

        ' For x = 1 To headerArray(0) - 1
        For x = 1 To headerArray(0)

            ' Will add proper date/time methods to do data time calcs when time permits.
            ' These are already in Visual basic.
            gettime(x, localTimes)

            oxitimeToVBDateTime(localTimes, StartN, StopN)

            Diff = CInt(DateDiff(DateInterval.Minute, StartN, StopN))

            durHours = Diff \ 60 ' Get hours

            durMinutes = Diff - (durHours * 60) ' Get minutes

            If durHours > 0 Then
                timeStr(x) = "Start: " + Format(StartN, "M/d/yy  HH:mm:ss") + "    Stop: " + Format(StopN, "HH:mm:ss") + "     Duration:" + Str(durHours) + " hrs " + Str(durMinutes) + " min"
            Else
                timeStr(x) = "Start: " + Format(StartN, "M/d/yy  HH:mm:ss") + "    Stop: " + Format(StopN, "HH:mm:ss") + "     Duration:" + Str(durMinutes) + " min"
            End If

        Next x
        timeStr(0) = Str(x - 1) ' Place number of Time stamps loaded into Loc 0
    End Sub

    Sub oxitimeToVBDateTime(ByRef oxiTime As times, ByRef startN As Date, ByRef stopN As Date)



        If oxiTime.StartN.month = 0 Or oxiTime.StartN.day = 0 Or oxiTime.StartN.year = 0 Or oxiTime.stopN.day = 0 Or oxiTime.StartN.month = 0 Or oxiTime.StartN.year = 0 Then Return

        startN = CDate("#" + Str(oxiTime.StartN.month) + "/" _
                         + Str(oxiTime.StartN.day) + "/" _
                         + Str(oxiTime.StartN.year) + " " _
                         + Str(oxiTime.StartN.hour) + ":" _
                         + Str(oxiTime.StartN.minute) + ":" _
                         + Str(oxiTime.StartN.second) + "#")

        stopN = CDate("#" + Str(oxiTime.stopN.month) + "/" _
                            + Str(oxiTime.stopN.day) + "/" _
                            + Str(oxiTime.stopN.year) + " " _
                            + Str(oxiTime.stopN.hour) + ":" _
                            + Str(oxiTime.stopN.minute) + ":" _
                            + Str(oxiTime.stopN.second) + "#")

    End Sub


    ' **************************************************************
    ' *  Function: filesToXML. Builds an XML file to reflect all of*
    ' *            the unprocessed data in the files of the raw    *
    ' *            data stream from the Oximeter. Please recall, we*
    ' *            denote a file as information between headers.   *
    ' *            This information is the three seqences of times *
    ' *            and the HR and SpO2 data pairs.                 *
    ' *  Inputs:                                                   *
    ' *                                                            *
    ' *  Outputs:                                                  *
    ' *  Arg 1: Array of Strings. This array holds all of the      *
    ' *         generated XML data. Each index of the array holds  *
    ' *         an XML line of data                                *
    ' **************************************************************

    Sub filesToXML(ByRef container() As String)
        ' Local data structures to persist just for this function
        Dim x As Integer = 0
        Dim y As Integer
        Dim z As Integer
        Dim index As Integer = 1

        Dim tempTime As times
        Dim tempData(30000) As dataType

        container(index) = "<rawdata>" ' level 1
        index += 1

        container(index) = "<downloadTimeStamp>Some Time</downloadTimeStamp>" ' level 2
        index += 1

        For z = 1 To headerArray(0) - 1
            ' Get times
            gettime(z, tempTime)
            ' Get Data
            getdata(z, tempData)

            ' Construct the XML

            container(index) = "<File>" + Str(z) ' level 2     File has times and data
            index += 1
            container(index) = "<times>" ' Level 3    Times are StartFirst, StopN, StartN
            index += 1
            container(index) = "<StartFirst>" ' Level 4
            index += 1
            container(index) = "<month>" + Str(tempTime.startFirst.month) + "</month>" ' level 5
            index += 1
            container(index) = "<day>" + Str(tempTime.startFirst.day) + "</day>"
            index += 1
            container(index) = "<year>" + Str(tempTime.startFirst.year) + "</year>"
            index += 1
            container(index) = "<minute>" + Str(tempTime.startFirst.minute) + "</minute>"
            index += 1
            container(index) = "<second>" + Str(tempTime.startFirst.second) + "</second>"
            index += 1
            container(index) = "<hour>" + Str(tempTime.startFirst.hour) + "</hour>"
            index += 1
            container(index) = "</StartFirst>" ' level 4"
            index += 1

            container(index) = "<StopN>" ' Level 4
            index += 1
            container(index) = "<month>" + Str(tempTime.stopN.month) + "</month>" ' level 5
            index += 1
            container(index) = "<day>" + Str(tempTime.stopN.day) + "</day>"
            index += 1
            container(index) = "<year>" + Str(tempTime.stopN.year) + "</year>"
            index += 1
            container(index) = "<minute>" + Str(tempTime.stopN.minute) + "</minute>"
            index += 1
            container(index) = "<second>" + Str(tempTime.stopN.second) + "</second>"
            index += 1
            container(index) = "<hour>" + Str(tempTime.stopN.hour) + "</hour>"
            index += 1
            container(index) = "</StopN>" ' Level 4
            index += 1

            container(index) = "<StartN>" ' Level 4
            index += 1
            container(index) = "<month>" + Str(tempTime.StartN.month) + "</month>" ' level 5
            index += 1
            container(index) = "<day>" + Str(tempTime.StartN.day) + "</day>"
            index += 1
            container(index) = "<year>" + Str(tempTime.StartN.year) + "</year>"
            index += 1
            container(index) = "<minute>" + Str(tempTime.StartN.minute) + "</minute>"
            index += 1
            container(index) = "<second>" + Str(tempTime.StartN.second) + "</second>"
            index += 1
            container(index) = "<hour>" + Str(tempTime.StartN.hour) + "</hour>"
            index += 1
            container(index) = "</StartN>" ' Level 4
            index += 1
            container(index) = "</times>" ' Level 3
            index += 1
            container(index) = "<DataReadings>" ' Level 3

            index += 1

            y = 1

            For x = 1 To tempData(0).HR ' The count of the data points found is kept in loc 0.
                ' Level 4 depth XML in this loop
                container(index) = "<reading>" + Str(y) + "</reading>" _
                              + "<SpO2>" + Str(tempData(y).SpO2) + "</SpO2>" _
                              + "<HR>" + Str(tempData(y).HR) + "</HR>" _
                               + "<time>" + Format(tempData(y).timeRecorded, "HH:mm:ss") + "</time>" ' Level 4
                y += 1
                index += 1
            Next x

            container(index) = "</DataReadings>"  ' Level 3"
            index += 1

            container(index) = "</File>" ' Level 2
            index += 1
        Next z


        container(index) = "</rawdata>" ' Level 1
        index += 1

        container(0) = Str(index - 1) ' number of XML strings in array
    End Sub

    '======================================================================================

    '======================================================================================
    '
    '  *********************************************************
    '  *  Database functions                                   *
    '  *                                                       *
    '  *  These functions perform BLOB input and output from   *
    '  *  dataset to table in database and back.               *
    '  *  BLOB is Binary Large OBject.                         *
    '  *  The database is tricked into believing our byte      *
    '  *  stream is a .jpg image and it allocates space        *
    '  *  and stores the bytes accordingly.  We take the byte  *
    '  *  stream from the database, a single file from         *
    '  *  the original Oximeter group of files and we          *
    '  *  reprocess it as if it was raw data right from the    *
    '  *  Oximeter. The Oximeter raw data processing features  *
    '  *  do not care where the data came from, as long as     *
    '  *  it is valid and useful.                              *
    '  *********************************************************


    ' How to Read from a BLOB Column
    ' The following functions use the DataReader to retrieve the BLOB value and assign to a byte array. 
    ' Because the BLOB is already completely in memory, there is no need for chunking the data
    ' and therefore the value is assigned to a Byte array. There are two calls to the GetBytes method;
    ' the first receives the length of the BLOB in bytes and is used to dimension the Byte array. 
    ' The second call retrieves the data. The FileStream object is used to write the Byte array to disk. 

    ' NOTE: In Visual Basic, you must subtract 1 from the length of the BLOB when you declare the 
    ' Byte array because Visual Basic declares the upper bound of the array, as opposed to the length. 
    ' In other languages, such as C# or JScript, use the length value without subtracting 1. 


    '  Public Sub OlDbBlob2File(ByVal DestFilePath As String)
    '      Dim PictureCol As Integer = 0 ' the column # of the BLOB field
    '     Dim cn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; DATA SOURCE=C:\Program Files\oxistat1dot0\OxistatAccessDB.mdb")
    '  Dim cmd As New OleDbCommand("SELECT rawbytes1 FROM Patients WHERE PatientID=7", cn)
    '     cn.Open()
    '     Dim dr As OleDbDataReader = cmd.ExecuteReader()
    '    dr.Read()
    '    Dim size As Long
    '    Dim b(CInt(dr.GetBytes(CInt(PictureCol), CLng(0), Nothing, CInt(0), Integer.MaxValue) - 1)) As Byte
    '    dr.GetBytes(PictureCol, 0, b, 0, b.Length)


    '   dr.Close()
    '   cn.Close()
    '   Dim fs As New System.IO.FileStream(DestFilePath, IO.FileMode.Create, IO.FileAccess.Write)
    '   fs.Write(b, 0, b.Length)
    '   fs.Close()
    '  End Sub

    ' How to Write to a BLOB Column

    ' The following functions use the Command and Parameter objects to write data from a Byte array to a BLOB column. 
    ' The following technique reads the file completely into memory and therefore does not need to chunk the 
    ' data when writing to the server. The Byte array and the length of the array are passed to the 
    ' Parameter constructor; most of the other arguments are filler values. 

    ' NOTE: In Visual Basic, you must subtract 1 from the length of the file when you declare the Byte array 
    ' because Visual Basic declares the upper bound of the array, as opposed to the length. 
    ' In other languages, such as C# or JScript, use the length value without subtracting 1. 



    '   Sub testTransfertoJpg(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    File2OleDbBlob("C:\test.jpg")

    '    OlDbBlob2File("C:\testOutofDB.jpg")
    ' End Sub


    '  Private Sub File2OleDbBlob(ByVal SourceFilePath As String)

    '  Dim cn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; DATA SOURCE=C:\Program Files\oxistat1dot0\OxistatAccessDB.mdb")
    '  Dim cmd As New OleDbCommand("UPDATE Patients SET Rawbytes1=? WHERE PatientID=7", cn)
    '  Dim fs As New System.IO.FileStream(SourceFilePath, IO.FileMode.Open, IO.FileAccess.Read)
    '   Dim b(CInt(fs.Length() - 1)) As Byte

    '   fs.Read(b, 0, b.Length)
    '   fs.Close()
    '   Dim P As New OleDbParameter("@Picture", OleDbType.LongVarBinary, b.Length, ParameterDirection.Input, False, 0, 0, Nothing, DataRowVersion.Current, b)
    '    cmd.Parameters.Add(P)
    '   cn.Open()
    '   cmd.ExecuteNonQuery()
    '    cn.Close()
    '  End Sub

    '======================================================================================
    '======================================================================================

    '======================================================================================
    '
    '  *********************************************************
    '  *  Statistical functions                                *
    '  *                                                       *
    '  *  These functions perform math on HR and SpO2 data as  *
    '  *  indexed by file                                      *
    '  *********************************************************


    '  **************************************************************************************
    '  *                         Desaturation definition    from a popular manual           *
    '  * The onset of a desaturation event is identified when the saturation decreases by   *
    '  * the EDP - Event Definition Point or more within a two minute inteval. All          *
    '  * subsequent reading are considered to be included within the same desaturation      *
    '  * event unless the saturation rises by EDP above the lowest point recorded during    *
    '  * that event.  If three minutes of desaturation occur, the event counter terminates. *
    '  * These long events are not included in the duration times, but in a separate score  *
    '  * of the number of these three minute events is reported.  If any event contains     *
    '  * more than 8 seconds of deleted or zero data, then it is not counted as an event    *
    '  * and a total of these excluded events is reported under "excluded due to artifact"  *
    '  **************************************************************************************

    ' What does the above mean?
    '
    ' 1) A desaturation event begins when the saturation falls through the EDP. For example, say
    '    Our EDP is 90. The saturation falls through it. We then start the time counter for
    '    the EDP at 90. 
    ' 2) If in a two minute interval, the saturation rises to 90, we terminate the event and
    '    count it as an event. We should also store the time duration of the event.
    ' 3) If the event does not return to the EDP of 90, but stays below it for three minutes-
    '    meaning our timer has gone to three minutes and beyond, the event 'times out' and we
    '    don't count it, but we do count the fact that it was a three minute or longer event.
    ' 
    ' Our program operates a bit differently than the popular desaturation definition
    ' from a well known company above.
    '
    ' We look at a drop of 4 points in SpO2 which is 4%.
    ' When we drop 4 points, we start a timer.
    ' We note if the desaturation was below:
    ' 1 minute or
    ' 2 minutes or
    ' 3 minutes ..
    ' 4 minutes - do we want 4 minutes??
    '
    ' We also keep a total of the desaturation incidents over the whole recording or file
    ' to calculate the average desaturation incidents/hour.
    '
    ' We will also terminate our desaturation readings if they pass 3 minutes
    ' as other popular packages do.



    ' 12/31/2002 ----------------------------------------------------------------------
    ' We rewrite the desaturation routines as they are not providing good data
    ' against the "John E. Sick" data.
    ' We strive for these design goals as delivered by Pete:

    ' 1) 30 datasets are scanned - which is two minutes. We determine the highest
    '    SpO2 within those datasets.
    '
    ' 2) Within the 30 datasets, we set the pointer to the first dataset with the
    '    highest value within the 30 datasets in this study. 
    '
    ' 2.5) We proceed from the beginning of the highest value for the 30 datasets extablished in (2).
    '      We search for a 4 point drop. We search two minutes or 30 more datasets. If a 4 point
    '      drop is found, we activate the "desaturationEventTimer" to time how long the event is.
    '      If the datasets do not drop by a value of 4, within the extended range of 30 datasets,
    '      then the study is cancelled.  We then go to the end of the datasets tested in (2.5)
    '      and start again at (1)
    '
    ' 3) (a) From the Event Definition Point EDP, we now advance dataset by dataset for up to
    '    45 datasets, (3 minute window). We look for bad data markers, the "777". If 
    '    two bad data set markers are found, then the event is NOT counted as
    '    a desaturation event and the total period from (2) [ first highest dataset ]
    '    to the second bad dataset is added to the "Excluded Due to Artifact"
    '    portion of the report.
    '
    '
    ' 3) (b) If the event exceeds three minutes, then the event is counted under the
    '        "Desaturation Incidents Under 4 minutes" field of the report.
    '
    ' 3) (c) An event within the 3 minute window or 45 datasets is valid if the 
    '        saturation rises 4 and meets or exceeds the highest value of the 30
    '        datasets in step (1) above. In this case, the time of the desaturation
    '        event is sorted to be under 1 min, under 2 min or under 3 min. 
    '   
    '        The counter for the number of events is also incremented according 
    '        to the timeband in which the event falls: under 1 min, under 2 min, 
    '        under 3 min.
    '
    ' 4) The new datasets for the next study are selected. The beginning of
    '    the new datasets to be studied - 30 of them, will begin at either
    '    of the following points:
    '    a) One dataset after the successful termination of the desaturation event
    '       in (3)(c).
    '    b) At the 3 minute timeout window in (3)(b). This starting point for the
    '       new dataset will be (i) The point where the first dataset was representing
    '       the highest value for the set of 30 datasets under study in (2) and (ii)
    '       45 datasets past this value to be at the 3 minute limit.
    '    c) At the dataset after the second bad dataset marked with "777" in (3)(a)
    '
    ' Jeff Fall Dec 31, 2002. Best stab at getting this right..
    '
    '


    ' **************************************************************
    ' *  Function: GetHighSpO2WithinDataset. Finds the highpoint   *
    ' *            of the SpO2 within the 30 datasets.             *
    ' *  Inputs:                                                   *
    ' *    arg1: offset - beginning of 30 datasets to test         *
    ' *    arg2: medData - array of datatriples of datatype        *
    ' *                                                            *
    ' *                                                            *
    ' *  Outputs:                                                  *
    ' *  Arg 3: HighPosition - the offset of the highest Sp02      *
    ' *         value in the set of 30 datasets.                   *
    ' *                                                            *
    ' *  Function Return: Value of the highest Sp02 found in the   *
    ' *         set of 30 datasets.                                *
    ' *                                                            *
    ' **************************************************************

    Function GetHighSpO2WithinDataset(ByVal offset As Integer, ByRef medData() As dataType) As Integer
        Dim x As Integer
        Dim highSpO2 As Integer = 0
        For x = offset To offset + 29
            If medData(x).SpO2 < 255 Then
                If medData(x).SpO2 > highSpO2 Then
                    highSpO2 = medData(x).SpO2
                End If
            End If
        Next x
        ' We now start over and scan for the first location of the high value.
        ' We pass this to the byRef parameter "HighPosition".
        '    For x = offset To offset + 30
        '   If medData(x).SpO2 = highSpO2 Then
        '      HighPosition = x
        '     Exit For
        '  End If
        '   Next x
        Return (highSpO2)
    End Function


    ' **************************************************************
    ' *  Function: GetlowSpO2WithinDataset. Finds the lowpoint     *
    ' *            of the SpO2 within the 30 datasets.             *
    ' *  Inputs:                                                   *
    ' *    arg1: offset - beginning of the EDP in the datasets     *
    ' *    arg2: medData - array of datatriples of datatype        *
    ' *    arg3: datasetEnd - The end of the datasets under study  *
    ' *                                                            *
    ' *                                                            *
    ' *  Outputs:                                                  *
    ' *                                                            *
    ' *  Function Return: Value of the lowest Sp02 found in the    *
    ' *         set of 30 datasets.                                *
    ' *                                                            *
    ' **************************************************************



    Function GetLowSpO2WithinDatasetAfterDrop(ByVal datasetBegin As Integer, ByRef medData() As dataType, ByVal datasetEnd As Integer) As Integer
        Dim x As Integer
        Dim lowSpO2 As Integer = 101
        For x = datasetBegin To datasetEnd
            If medData(x).SpO2 < 255 Then
                If medData(x).SpO2 < lowSpO2 Then
                    lowSpO2 = medData(x).SpO2
                End If
            End If
        Next x
        ' We now start over and scan for the first location of the low value.
        ' We pass this to the byRef parameter "LowPosition".
        '    For x = offset To offset + 30
        '   If medData(x).SpO2 = lowSpO2 Then
        '      lowPosition = x
        '     Exit For
        '  End If
        '   Next x
        Return (lowSpO2)
    End Function

    ' **************************************************************
    ' *  Function: GetHighSpO2. Finds the highpoint of the SpO2    *
    ' *            within ALL datasets.                            *
    ' *  Inputs:                                                   *
    ' *    arg1 medData - array of datatriples of datatype         *
    ' *                                                            *
    ' *                                                            *
    ' *  Outputs:                                                  *
    ' *                                                            *
    ' *  Function Return: Value of the highest Sp02 found in the   *
    ' *         set of 30 datasets.                                *
    ' *                                                            *
    ' **************************************************************



    Function GetHighSpO2AllSamples(ByRef medData() As dataType) As Integer
        Dim x As Integer
        Dim highSpO2 As Integer = 0
        For x = 1 To medData(0).SpO2 ' Location (0) contains the number of datasets in the entire sample
            If medData(x).SpO2 < 255 Then
                If medData(x).SpO2 > highSpO2 Then
                    highSpO2 = medData(x).SpO2
                End If
            End If
        Next x
        Return (highSpO2)
    End Function

    ' **************************************************************
    ' *  Function: lookfor4pointdrop. Looks for an Event Definition*
    ' *            point within the 30 datasets.                   *
    ' *  Inputs:                                                   *
    ' *    arg1: offset - beginning of 30 datasets to test         *
    ' *          It is expected this is one after the highest      *
    ' *          value found from the getHighSpo2 function
    ' *    arg2: medData - array of datatriples of datatype        *
    ' *                                                            *
    ' *                                                            *
    ' *  Outputs:                                                  *
    ' *                                                            *
    ' *  Function Return: Offset of the 4 point drop Sp02          *
    ' *                   found in the set of 30 datasets.         *
    ' *                   If no drop found, returns -1             *
    ' *                                                            *
    ' **************************************************************


    Function lookFor4PointDrop(ByVal studyBegin As Integer, ByRef meddata() As dataType, ByVal highSpO2 As Integer) As Integer
        Dim x As Integer
        Dim EDP As Integer
        Dim EDPfound As Boolean = False

        For x = studyBegin To studyBegin + 29

            If meddata(x).SpO2 <= highSpO2 - 4 Then
                EDP = x
                EDPfound = True
                Exit For
            End If
        Next x
        If EDPfound = True Then
            Return (EDP)
        Else
            Return (-1)
        End If

    End Function



    ' **************************************************************
    ' *  Function: lookfor4pointgain. Looks for the end of a       *
    ' *            desaturation event from up to 45 dataset from   *
    ' *            the offset provided in arg1.                    *
    ' *                                                            *
    ' *            Tests each dataset for bad data. Keeps          *
    ' *            count of bad data and if two bad data sets      *
    ' *            are present, it terminates processing and       *
    ' *            returns the offset of the second bad dataset    *
    ' *            as the function return value.                   *
    ' *                                                            *
    ' *            If a 4 point gain is found, the duration        *
    ' *            of the desaturation event is returned in        *
    ' *            desaturationEventSeconds and the offset of      *
    ' *            the terminating dataset is returned as the      *
    ' *            function return value. artifactEventSeconds     *
    ' *            is set to -1 as there is not artifact present.  *
    ' *  Inputs:                                                   *
    ' *    arg1: offset - beginning of 30 datasets to test         *
    ' *          It is expected this is one after the highest      *
    ' *          value found from the getHighSpo2 function         *
    ' *    arg2: medData - array of datatriples of datatype        *
    ' *                                                            *
    ' *                                                            *
    ' *  Outputs:                                                  *
    ' *    arg3: desaturationEventSeconds - seconds of desaturation*
    ' *          event. -1 if no event found.                      *
    ' *                                                            *
    ' *    arg4: artifactEventSeconds. Seconds of the artifact     *
    ' *          event. -1 if no artifacts exist.                  *
    ' *                                                            *
    ' *  Function Return: Offset of the 4 point gain Sp02          *
    ' *                   found in the set of 45 datasets.         *
    ' *                   If no gain found, returns -1             *
    ' *                                                            *
    ' **************************************************************



    Function lookFor4PointGain(ByVal EDPplusOne As Integer, ByRef meddata() As dataType, ByVal LowestSpO2InDataset As Integer, ByRef desaturationEventSeconds As Integer, ByRef artifactEventSeconds As Integer) As Integer
        Dim x As Integer
        Dim badDataMarkerCount As Integer = 0 ' If this reaches a value of 2, we bail out due to artifacts
        Dim offsetOfdesaturationEvent As Integer
        Dim DesaturationEventfound As Boolean = False
        Dim skipThisCompare As Boolean = True
        Dim artifactDataPresent As Boolean = False
        Dim offsetOfSecondBadDataset As Integer

        desaturationEventSeconds = 0
        artifactEventSeconds = -1


        
        For x = EDPplusOne To (EDPplusOne + 44)

            If meddata(x).SpO2 = 777 Then
                badDataMarkerCount += 1
                If badDataMarkerCount >= 2 Then
                    artifactDataPresent = True
                    offsetOfSecondBadDataset = x
                    Exit For
                End If
                skipThisCompare = True
            End If

            desaturationEventSeconds += 4

            If skipThisCompare = False Then
                If meddata(x).SpO2 >= LowestSpO2InDataset + 4 Then '  The +4 is the desat. increase.
                    offsetOfdesaturationEvent = x
                    DesaturationEventfound = True
                    Exit For
                End If
            Else
                skipThisCompare = False
            End If
        Next x

        ' To limit testing, first test the most common condition - a desaturation event not found.
        ' Then test if a desaturatin event is found.
        ' Then test for artifact data present.

        If (DesaturationEventfound = False) And (artifactDataPresent = False) Then
            ' No desaturation event found and no artifact data present
            Return (-1) ' Failure - no desaturation data present, no artifacts. Main loop looks at the -1 failure.
        Else
            If (DesaturationEventfound = True) And (artifactDataPresent = False) Then
                Return (offsetOfdesaturationEvent)
            Else
                If (artifactDataPresent = True) And (DesaturationEventfound = False) Then
                    artifactEventSeconds = desaturationEventSeconds
                    desaturationEventSeconds = -1  ' signals error - artifact present. We don't want this variable to have 
                    ' valid data if an error. (to catch programming mistakes)
                    Return (offsetOfSecondBadDataset)
                End If
            End If
        End If
    End Function






    Function lookForEDP(ByVal startOffset As Integer, ByRef meddata() As dataType, ByVal highSpO2ForAllDatasets As Integer) As Integer

        Dim dropOffset As Integer
        Dim setOf30HighSpO2Value As Integer

        setOf30HighSpO2Value = GetHighSpO2WithinDataset(startOffset, meddata)
        dropOffset = lookFor4PointDrop(startOffset, meddata, setOf30HighSpO2Value) ' Test one after the highest dataset

        Return (dropOffset)
    End Function






    Function processDesaturationEvent(ByVal edpEndOffset As Integer, _
    ByVal desaturationEventSeconds As Integer, _
    ByVal artifactEventSeconds As Integer, ByRef data As desaturationData) As Integer

        If desaturationEventSeconds = -1 And artifactEventSeconds = -1 Then
            ProcessDesaturationTimeout(180, data) ' Past 45 datasets or 3 minutes, timed out.
            ' Give it 180 seconds for now.. or 3 min.
            Return (30) ' Test next 30 datasets
        End If

        If desaturationEventSeconds >= 0 And artifactEventSeconds = -1 Then
            ' Classify the desaturation Event
            classifyDesaturationEvent(desaturationEventSeconds, data)
            Return (30) ' Test next 30 datasets
        End If

        If desaturationEventSeconds = -1 And artifactEventSeconds > 0 Then
            ' process the artifact
            processArtifact(artifactEventSeconds, data)
            Return (30) ' test next 30 datasets
        End If

    End Function


    Sub ProcessDesaturationTimeout(ByVal lengthInSeconds As Integer, ByRef data As desaturationData)

    End Sub

    Sub classifyDesaturationEvent(ByVal lengthInSeconds As Integer, ByRef data As desaturationData)
        Select Case lengthInSeconds
            Case 1 To 59 ' seconds
                data.Under1MinTimer = DateAdd(DateInterval.Second, lengthInSeconds, data.Under1MinTimer)
                data.totalDesat1to3InSec += lengthInSeconds
                data.Under1MinDesatCount += 1 ' This is needed to calc average desaturation/hr
            Case 60 To 119 ' seconds
                data.Bet1and2MinTimer = DateAdd(DateInterval.Second, lengthInSeconds, data.Bet1and2MinTimer)
                data.Bet1and2MinDesatCount += 1
                data.totalDesat1to3InSec += lengthInSeconds
            Case 120 To 179 ' seconds
                data.Bet2and3MinTimer = DateAdd(DateInterval.Second, lengthInSeconds, data.Bet2and3MinTimer)
                data.Bet2and3MinDesatCount += 1
                data.totalDesat1to3InSec += lengthInSeconds
            Case 180 To 219 ' seconds
                data.Over3minTimer = DateAdd(DateInterval.Second, lengthInSeconds, data.Over3minTimer)
                data.Bet3and4MinDesatCount += lengthInSeconds
            Case Else ' more than 4 minutes
                data.over4minTimer = DateAdd(DateInterval.Second, lengthInSeconds, data.over4minTimer)
                data.over4minDesatCount += lengthInSeconds
        End Select
    End Sub

    Sub processArtifact(ByVal lengthInSeconds As Integer, ByRef data As desaturationData)
        data.TimeExcludedDueToArtifact = DateAdd(DateInterval.Second, lengthInSeconds, data.TimeExcludedDueToArtifact)
        '   data.totalDesat1to3InSec += lengthInSeconds
        data.numberOfArtifacts += 1 ' This is needed to calc average desaturation/hr
    End Sub

    ' **************************************************************
    ' *  Function: desaturationIncidents. Finds desaturation counts*
    ' *            between:                                        *
    ' *            0 - 1 min  (desatUnderOneMin)                   *
    ' *            1 - 2 min  (desatBetweenOneAndTwoMin)           *
    ' *            2 - 3 min  (desatBetweenTwoAndThreeMin)         *
    ' *            3 - 4 min  (desatBetweenThreeAndFourMin)        *
    ' *                                                            *
    ' *  Inputs:                                                   *
    ' *  Arg 1: The file number to calc the SpO2 times from        *
    ' *                                                            *
    ' *  Outputs:  ( as type Date)                                 *
    ' *  Arg 2: Cumulative Time - Desaturation under one minute    *
    ' *  Arg 3: Counts - Under one minute events                   *
    ' *  Arg 4: Cumulative Time - Desaturation between 1 and 2 min *
    ' *  Arg 5: Counts - Desaturation between 1 and 2 min          *
    ' *  Arg 6: Cumulative Time - Desaturation between 2 and 3 min *
    ' '  Arg 7: Counts - Desaturation between 2 and 3 min          *
    ' *  Arg 8: Cumulative Time - Desaturation between 3 and 4 min *
    ' *  Arg 9: Counts - Desaturation between 3 and 4 min          *
    ' *  Arg10: Cumulative Time - Desaturation greater than 4 min  *
    ' *  Arg11: Counts - Desaturation greater than 4 min           *
    ' *  Arg12: Counts in seconds of all desaturation events       *
    ' *         which are between 1 sec and 3 mins of duration     *
    ' **************************************************************
    ' jeff

    Sub desaturationIncidents(ByVal file As Integer, _
        ByRef Under1MinTimer As Date, _
        ByRef Under1MinDesatCount As Integer, _
        ByRef Bet1and2MinTimer As Date, _
        ByRef Bet1and2MinDesatCount As Integer, _
        ByRef Bet2and3MinTimer As Date, _
        ByRef Bet2and3MinDesatCount As Integer, _
        ByRef Over3minTimer As Date, _
        ByRef Bet3and4MinDesatCount As Integer, _
        ByRef over4minTimer As Date, _
        ByRef over4minDesatCount As Integer, _
        ByRef totalDesat1to3InSec As Integer, _
        ByRef TimeExcludedDueToArtifact As Date, _
        ByRef artifactEventsCount As Integer)


        ' start the time counters at 00:00:00

        Under1MinTimer = CDate("#00:00:00#")
        Bet1and2MinTimer = CDate("#00:00:00#")
        Bet2and3MinTimer = CDate("#00:00:00#")
        Over3minTimer = CDate("#00:00:00#")
        over4minTimer = CDate("#00:00:00#")
        TimeExcludedDueToArtifact = CDate("#00:00:00#")



        Under1MinDesatCount = 0
        Bet1and2MinDesatCount = 0
        Bet2and3MinDesatCount = 0
        Bet3and4MinDesatCount = 0
        over4minDesatCount = 0
        totalDesat1to3InSec = 0

        Dim medData(50000) As dataType
        Dim x As Integer = 1

        Dim lookingForEDP As Boolean = True


        Dim setOf30UnderStudy As Integer = 1
        Dim edpBeginOffset As Integer
        Dim desaturationEventSeconds As Integer = -1
        Dim artifactEventSeconds As Integer = -1
        Dim edpEndOffset As Integer
        Dim HighSpO2ForAllDatasets As Integer = 0
        Dim LowestSpO2InDatasetAfterDrop As Integer
        Dim DatasetIncrementValue As Integer
        Dim endOfStudySet As Integer

        Dim data As desaturationData ' This is the desaturation data "packet" passed to all of the subfunctions
        ' for processing. The structure of this is defined in the global data area so that sub
        ' functions can access the template too.

        data.numberOfArtifacts = 0

        '     Dim temp(50000) As dataType

        getdata(file, medData) ' We get the data to process according to desired session denoted by "file" number.

        ' this section reverses the data for testing
        '  Dim z As Integer

        '   For z = 1 To temp(0).HR
        '     medData(temp(0).HR - z) = temp(z)

        '   Next z
        '   medData(0).HR = temp(0).HR
        '   medData(0).SpO2 = temp(0).SpO2



        While lookingForEDP = True

            edpBeginOffset = lookForEDP(setOf30UnderStudy, medData, HighSpO2ForAllDatasets) ' This finds High Point and 4 point drop..
            If edpBeginOffset = -1 Then ' -1 means (failure) no EDP found.
                ' test the next 30 datasets
                setOf30UnderStudy += 1 ' We increment only one dataset according to Pete on 1/2/2003
            Else
                ' Here, we have a valid EDP (start) at edpBeginOffset. A 4 point drop happened..
                ' We now have to get the lowest SpO2 from the EDP until end of the study. For example:
                ' data sets 1 - 30 are in study. EDP happened at dataset 16.
                ' We now want to find the lowest SpO2 from dataset 17 to dataset 30..Ok then. Pete ref. 1/2/2003
                endOfStudySet = setOf30UnderStudy + 29

                LowestSpO2InDatasetAfterDrop = GetLowSpO2WithinDatasetAfterDrop(edpBeginOffset + 1, medData, endOfStudySet)
                edpEndOffset = lookFor4PointGain(edpBeginOffset + 1, medData, LowestSpO2InDatasetAfterDrop, desaturationEventSeconds, artifactEventSeconds)
                If edpEndOffset > -1 Then
                    ' success - a 4 point gain was found within 45 datasets or artifacts were found. We process and setup for next set of 30.
                    setOf30UnderStudy += processDesaturationEvent(edpEndOffset, desaturationEventSeconds, artifactEventSeconds, data)
                Else
                    ' Failure. We went to the end of the 45 datasets, 3 minutes with no drop of 4 Spo2 units
                    ' This is technically a "3 minute suspension of an event" according to Pete 

                    setOf30UnderStudy += 30
                End If
            End If
            If setOf30UnderStudy + 44 > medData(0).HR Then
                lookingForEDP = False ' shut down the while loop as we are near the end and will run into zero data
                ' or possibly off the end, but that is a much smaller probability.
            End If

        End While

        ' copy results to args of function call
        Under1MinTimer = data.Under1MinTimer
        Under1MinDesatCount = data.Under1MinDesatCount
        Bet1and2MinTimer = data.Bet1and2MinTimer
        Bet1and2MinDesatCount = data.Bet3and4MinDesatCount
        Bet2and3MinTimer = data.Bet2and3MinTimer
        Bet2and3MinDesatCount = data.Bet2and3MinDesatCount
        Over3minTimer = data.Over3minTimer
        Bet3and4MinDesatCount = data.Bet3and4MinDesatCount
        over4minTimer = data.over4minTimer
        over4minDesatCount = data.over4minDesatCount
        totalDesat1to3InSec = data.totalDesat1to3InSec
        TimeExcludedDueToArtifact = data.TimeExcludedDueToArtifact
        artifactEventsCount = data.numberOfArtifacts

    End Sub



    ' **************************************************************
    ' *  Function: timeSPO2Below. Finds SpO2 times below 90, 80,   *
    ' *            70, 60 and a custom level.                      *
    ' *                                                            *
    ' *  Inputs:                                                   *
    ' *  Arg 1: The file number to calc the SpO2 times from        *
    ' *  Arg 7: Custom level for SpO2 time calculation             *
    ' *                                                            *
    ' *  Outputs:  ( as type Date)                                 *
    ' *  Arg 2: SpO2 time in hours, mins, secs below 90            *
    ' *  Arg 3: SpO2 time in hours, mins, secs below 80            *
    ' *  Arg 4: SpO2 time in hours, mins, secs below 70            *
    ' *  Arg 5: SpO2 time in hours, mins, secs below 60            *
    ' *  Arg 6: SpO2 time in hours, mins, secs below arg 6 input   *
    ' **************************************************************


    Sub timeSpO2Below(ByVal file As Integer, _
    ByRef SpO2Below90 As Date, _
    ByRef SpO2Below80 As Date, _
    ByRef SpO2Below70 As Date, _
    ByRef SpO2Below60 As Date, _
    ByRef SpO2BelowCustom As Date, _
    ByVal custom As Integer)

        Dim medData(50000) As dataType
        Dim x As Integer = 0


        ' start the time counters at 00:00:00
        SpO2Below90 = CDate("#00:00:00#")
        SpO2Below80 = CDate("#00:00:00#")
        SpO2Below70 = CDate("#00:00:00#")
        SpO2Below60 = CDate("#00:00:00#")
        SpO2BelowCustom = CDate("#00:00:00#")

        getdata(file, medData)
        scrub777FromData(medData)

        For x = 1 To medData(0).HR ' number of data points is in HR at location 0
            ' Calc lows
            If (medData(x).SpO2 < 90) Then
                SpO2Below90 = DateAdd(DateInterval.Second, 4, SpO2Below90)
            End If
            If (medData(x).SpO2 < 80) Then
                SpO2Below80 = DateAdd(DateInterval.Second, 4, SpO2Below80)
            End If
            If (medData(x).SpO2 < 70) Then
                SpO2Below70 = DateAdd(DateInterval.Second, 4, SpO2Below70)
            End If
            If (medData(x).SpO2 < 60) Then
                SpO2Below60 = DateAdd(DateInterval.Second, 4, SpO2Below60)
            End If
            If (medData(x).SpO2 < custom) Then
                SpO2BelowCustom = DateAdd(DateInterval.Second, 4, SpO2BelowCustom)
            End If
        Next x


        ' The code below will figure out ranges in bands between 90 and 80, 80 and 70, ect.

        '    For x = 1 To medData(0).HR ' number of data points is in HR at location 0
        ' Calc lows
        'if (medData(x).SpO2 < 60) Then
        ' SpO2Below60 = DateAdd(DateInterval.Second, 4, SpO2Below60)
        '    Else
        '      If (medData(x).SpO2 < 70) Then
        '          SpO2Below70 = DateAdd(DateInterval.Second, 4, SpO2Below70)
        '      Else
        '         If (medData(x).SpO2 < 80) Then
        '             SpO2Below80 = DateAdd(DateInterval.Second, 4, SpO2Below80)
        '        Else
        '          If (medData(x).SpO2 < custom) Then ' This is usually 88
        ' SpO2BelowCustom = DateAdd(DateInterval.Second, 4, SpO2BelowCustom)
        '         Else
        '             If (medData(x).SpO2 < 90) Then
        '                 SpO2Below90 = DateAdd(DateInterval.Second, 4, SpO2Below90)
        '             End If
        '          End If
        '        End If
        '    End If
        '  End If
        '   Next x
    End Sub



    '
    '    The sample rate of the Oximeter
    '    is every 4 seconds.

    Sub SpO2HiAvgLow(ByVal file As Integer, ByRef stats As medStats)
        Dim RunningTime As Date
        Dim medData(50000) As dataType
        Dim x As Integer = 0

        Dim HighHR As Integer = 0
        Dim HighSP As Integer = 0
        Dim AverageHR As Integer = 0
        Dim AverageSP As Double = 0
        Dim LowHR As Integer = 100
        Dim LowSP As Integer = 100

        Dim SumHR As Integer = 0
        Dim SumSP As Integer = 0

        Dim skipCalc As Boolean = False
        Dim recordsProcessed As Integer = 0

        getdata(file, medData)
        scrub777FromData(medData)

        For x = 1 To medData(0).HR ' number of data points is in HR at location 0

            If (medData(x).HR = 0) Or (medData(x).HR = 255) Or (medData(x).SpO2 = 0) Or (medData(x).SpO2 = 255) Then
                skipCalc = True
            End If


            If skipCalc = False Then
                recordsProcessed += 1
                ' Calc lows
                If (medData(x).HR < LowHR) Then
                    LowHR = medData(x).HR
                End If
                If (medData(x).SpO2 < LowSP) Then
                    LowSP = medData(x).SpO2
                End If
                ' Calc highs
                If (medData(x).HR > HighHR) Then
                    HighHR = medData(x).HR
                End If
                If (medData(x).SpO2 > HighSP) Then
                    HighSP = medData(x).SpO2
                End If
                ' Get sums
                SumHR += medData(x).HR
                SumSP += medData(x).SpO2
            End If

            If skipCalc = True Then
                skipCalc = False
            End If
        Next x
        If recordsProcessed > 0 Then
            AverageHR = SumHR \ recordsProcessed
            AverageSP = SumSP / recordsProcessed
        Else
            ' Data is trashed, return 0's for all.
            AverageHR = 0
            AverageSP = 0
            HighHR = 0
            HighSP = 0
            LowHR = 0
            LowSP = 0
        End If

        ' return data to structure in Arg 2

        stats.HR.High = HighHR
        stats.SpO2.High = HighSP

        stats.HR.Low = LowHR
        stats.SpO2.Low = LowSP

        stats.HR.Average = AverageHR
        stats.SpO2.Average = AverageSP

    End Sub


    '=======================================================================================

    '
    '  **********************************************************
    '  *  RS232 Communication functions w/ Oximeter             *
    '  **********************************************************
    '


    ' **************************************************************
    ' *  Function: isPortAvailiable. Returns TRUE if is can open   *
    ' *            the COM port, FALSE otherwise                   *
    ' *  Inputs:                                                   *
    ' *  Arg 1: COM PORT - This is number of the comm port wanted  *
    ' *         to open. 1 thru 4                                  *
    ' *                                                            *
    ' **************************************************************


    Private Function IsPortAvailable(ByVal ComPort As Integer) As Boolean
        Try
            m_CommPort.Open(ComPort, 9600, 8, Rs232.DataParity.Parity_None, _
                Rs232.DataStopBit.StopBit_1, 4096)
            ' If it makes it to here, then the Comm Port is available.
            m_CommPort.Close()
            Return True
        Catch
            ' If it gets here, then the attempt to open the Comm Port
            '   was unsuccessful.
            Return False
        End Try
    End Function

    ' **************************************************************
    ' *  Function: canOpenPort. Returns TRUE if is can open        *
    ' *            the COM port, FALSE otherwise                   *
    ' *  Inputs:                                                   *
    ' *  Arg 1: COM PORT - This is number of the comm port wanted  *
    ' *         to open. 1 thru 4                                  *
    ' *                                                            *
    ' *  Used in context with the status window for status text    *
    ' *                                                            *
    ' **************************************************************


    Function canOpenPort(ByVal port As Integer) As Boolean
        Dim commOK As Boolean = False
        Try
            m_CommPort.Open(port, 9600, 8, Rs232.DataParity.Parity_None, _
                           Rs232.DataStopBit.StopBit_1, 4096)
            commOK = True
            Me.confcomm.Enabled = True
            Me.status.Text = "READY to read Oximeter"
            TextBox7.Text = "READY to read Oximeter"
            m_CommPort.Close()
        Catch
            commOK = False
            Me.confcomm.Enabled = False
            Me.status.Text = "Need COM port Config"
        End Try
        Return (commOK)
    End Function


    ' **************************************************************
    ' *  Function: testOximeterRealTime. Looks for known realtime  *
    ' *            data from the Oximeter. Used to automatically   *
    ' *            setup the COM port by verifying an actual       *
    ' *            Oximeter is transmitting data. Locks onto the   *
    ' *            HR or SpO2 unique identifiers                   *
    ' *  Inputs:                                                   *
    ' *  Arg 1: COM port to verify Oximeter connection             *
    ' *                                                            *
    ' *  Outputs: Returns TRUE if Oximeter Data detected           *
    ' *           FALSE otherwise                                  *
    ' **************************************************************

    Private Function TestForOximeterRealTime(ByVal port As Integer) As Boolean
        Dim scratch As String
        Dim oximeterPort As Boolean = False
        Dim gotSpO2 As Boolean = False
        Dim gotHR As Boolean = False

        Me.txtStatus.Visible = True

        m_CommPort.Open(port, 9600, 8, Rs232.DataParity.Parity_None, _
                Rs232.DataStopBit.StopBit_1, 4096)
        Application.DoEvents()
        Try
            Me.status.Text = "Read Data COM" + Str(port)
            m_CommPort.Read(32)      ' Read at least three repeating realtime sequences
            oximeterPort = True
        Catch
            txtStatus.AppendText("COM" + Str(port) + " No Oximeter found." + vbCrLf + vbCrLf)
            Me.status.Text = "COM" + Str(port) + " Read Timeout"
            m_CommPort.Close()
        Finally
            If (oximeterPort = True) Then ' We read 32 chars successfully.
                scratch = m_CommPort.InputStreamString
                ' Me.txtStatus.AppendText(scratch) ' For testing..
                m_CommPort.Close()
                Me.status.Text = "COM" + Str(port) + " read data"
            End If

        End Try
        ' Look for a pattern we know is common in the realtime data and 
        ' will not vary with data. These are SpO2 and HR.
        ' Search the scratch buffer
        If (oximeterPort = True) Then
            gotSpO2 = (scratch Like "Sp02*") Or (scratch Like "*SpO2") Or (scratch Like "SpO2*") ' Match line beginning with SpO2
            gotHR = (scratch Like "HR*") Or (scratch Like "*HR*") Or (scratch Like "HR*")
        End If

        If ((gotSpO2 Or gotHR) And oximeterPort) Then
            Me.status.Text = "COM" + Str(port) + " Oximeter OK"
            Return True ' Oximeter found due to presense of SpO2 or HR in scratch buffer
        Else
            Me.status.Text = "COM" + Str(port) + " No Oximeter"
            Return False ' We can't find valid Oximeter Realtime data in this device, probably a pesky modem.
        End If
    End Function


    ' **************************************************************
    ' *  Function: confcomm_Click. Event fired by configure comm   *
    ' *            button click.                                   *
    ' *            First tries to open a port stored in the        *
    ' *            Registry. If this fails, walks com ports 1 to 4.*
    ' *            If it can open one of these ports, it calls     *
    ' *            testForOximeterRealTime to see if an Oximeter   *
    ' *            is actually connected. If it finds a good       *
    ' *            Oximeter, it writes number of the comm port     *
    ' *            to the registry.                                *
    ' *                                                            *
    ' **************************************************************


    Private Sub confcomm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confcomm.Click
        Dim keeptesting As Boolean = True
        Dim oximeterFound As Boolean = False

        Me.txtStatus.Visible = True
        Me.Label1.Visible = True
        Me.status.Text = "Configuring COM Ports"
        System.Windows.Forms.MessageBox.Show(" A U T O M A T I C    C O M    P O R T    C O N F I G U R A T I O N" + vbCrLf + vbCrLf + "Attach the data cable plugged to the 920M Plus and your COM port on your laptop or PC, then turn on the Respironics 920M Plus via pressing the blue power button." + vbCrLf + vbCrLf + "Wait for the unit to display dashes in the %SpO2 and heartbeat displays" + vbCrLf + vbCrLf + "This procedure will AUTO detect realtime data from the 920M Plus on valid COM ports." + vbCrLf + vbCrLf + "This procedure is only run once when you first use the program or if you use a different computer or a different COM port on the same computer." + vbCrLf + vbCrLf + "When 920M PLUS is ready with '-' and '-' shown in display, then click on OK")
        Me.txtStatus.Clear()
        Me.txtStatus.AppendText("       --- Testing COM ports ---" + vbCrLf + vbCrLf)
        thisport = 1
        While (keeptesting And (thisport < 5))
            Application.DoEvents()
            If (IsPortAvailable(thisport)) Then
                txtStatus.AppendText("Found COM" + Str(thisport) + " port and testing for Oximeter" + vbCrLf)
                If (TestForOximeterRealTime(thisport)) Then
                    ' This port is responding. So, stop while loop
                    txtStatus.AppendText("Good news!" + vbCrLf)
                    txtStatus.AppendText("Your Oximeter is attached to COM" + Str(thisport) + vbCrLf + vbCrLf)
                    txtStatus.AppendText("COM Port configuration procedure SUCCESSFUL" + vbCrLf + vbCrLf)
                    keeptesting = False
                    oximeterFound = True
                    Me.status.Text = "READY"
                    Me.confcomm.Enabled = False
                    Me.confcomm.Visible = False
                    Me.Button1.Enabled = True
                    Me.Button1.Visible = True
                    SaveSetting("Oxiapp", "Startup", "COMPORT", Str(thisport))
                    GroupBox2.Visible = False
                    GroupBox3.Visible = True
                    Label1.Text = "Transfer information"
                    TextBox7.Text = "Ready to transfer"
                    Application.DoEvents()
                Else : thisport += 1 ' No Oximeter SpO2 string on this opened port, try to open next one.
                End If
            Else
                Me.txtStatus.AppendText("No COM" + Str(thisport) + " usable port in this PC or laptop" + vbCrLf + vbCrLf)
                thisport += 1
            End If
        End While
        If (oximeterFound = False) Then
            Me.status.Text = "NEED COM PORT!"
            Me.txtStatus.AppendText("COM PORT configuration has FAILED" + vbCrLf + vbCrLf)
            MessageBox.Show("COM PORT configuration on this laptop or PC for your Oximeter has FAILED" + vbCrLf + vbCrLf + "Try to use a different COM port connector if several are present and run the COM port configuration again." + vbCrLf + vbCrLf + "Make sure the Oximeter is turned on as instructed. It will automatically turn off in this mode after a few minutes.")
        End If
    End Sub


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Label3.Visible = False
        ListBox1.Visible = False
        Label46.Visible = True
        Label46.Text = "No Oximeter data from has been downloaded from Oximeter." + vbCrLf _
        + "Please load in data if new data is desired and assign to patient."
        '   ListBox1.Items.Add("No Oximeter data from has been downloaded from Oximeter or from stored ASCII file or")

        '   ListBox1.Items.Add("from patient database. Please load in data if new data is desired and assign to patient.")

        ListBox2.Items.Clear()
        ListBox2.Items.Add("Extra's Status Box")
        ListBox2.Items.Add("Click button for:")
        ListBox2.Items.Add("o Load Oxidata text file from disk")
        ListBox2.Items.Add("o Save Oxidata text file to disk")
        ListBox2.Items.Add("o Save loaded Oxidata data to XML file on disk")

        ' BindReport()

    End Sub
    ' If it is decided to use Crystal Reports in a push fashion, this code will be useful.
    ' Leave commented out for now.
    Sub BindReport()
        '       Dim myConnection As New SqlClient.SqlConnection()
        '      myConnection.ConnectionString = "server= (local)\NetSDK;database=pubs;Trusted_Connection=yes"
        '      Dim MyCommand As New SqlClient.SqlCommand()
        '       MyCommand.Connection = myConnection
        '       MyCommand.CommandText = "Select * from Stores"
        '       MyCommand.CommandType = CommandType.Text
        '       Dim MyDA As New SqlClient.SqlDataAdapter()
        '    MyDA.SelectCommand = MyCommand
        '  Dim myDS As New OrgDataSet1()

        'This is our DataSet created at Design Time      

        '  MyDA.Fill(myDS, "OrgTable")

        'You have to use the same name as that of your Dataset that you created during design time

        '   Dim oRpt As New CrystalReport1()

        ' This is the Crystal Report file created at Design Time

        '  oRpt.SetDataSource(OrgDataSet1)

        ' Set the SetDataSource property of the Report to the Dataset

        '     CrystalReportViewer1.ReportSource = oRpt

        ' Set the Crystal Report Viewer's property to the oRpt Report object that we created

    End Sub


    '============================================================================================

    ' *******************************************************
    ' *  This function is called from the form init         *
    ' *  function.  It is a more localized init             *
    ' *  function for the OxiApp. Put anything              *
    ' *  that needs to be initialized at program            *
    ' *  startup right here.                                *
    ' *******************************************************
    Private Sub oxiAppInit()

        Me.status.Clear()
        Me.status.Text = "Initializing"
        Me.Button1.Visible = False
        Me.txtStatus.Visible = False
        Label1.Visible = False
        Label35.Visible = False
        GroupBox3.Visible = False
        GroupBox2.Visible = True
        ' Test if a registry key exists which has a the
        ' COMM port to use.
        daRpt.Fill(DsRpt)

        commport = GetSetting("Oxiapp", "Startup", "COMPORT")

        If (canOpenPort(CInt(Val(commport)))) Then
            thisport = CInt((Val(commport)))
            validCommPort = True
            Me.confcomm.Visible = False
            Me.Button1.Visible = True
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            Application.DoEvents()
        Else
            thisport = -1
            validCommPort = False
            Me.confcomm.Visible = True
            Me.confcomm.Enabled = True
            Me.Button1.Visible = False
            GroupBox2.Visible = True
            GroupBox3.Visible = False
            Application.DoEvents()
        End If

        'This keeps getting turned off. Make sure it stays on.
        Me.CrystalReportViewer1.DisplayToolbar = True
        ' Load the patients datagrid
        daPatients.Fill(DsPatientsForm1)

        ReportSelected = False
        OxiDataPresent = False
        PatientSelected = False
        Button7.Enabled = False

        '   Dim oRpt As CrystalReport1 = New CrystalReport1()
        ' Use ADO.NET object model to set up connection information 

        '   Dim objdsHRrpt As New dsHRrpt()


        ' Connect to, fetch data and disconnect from database 
        '   daHRrpt.Fill(objDsHRrpt)
        ' Use Report Engine object model to pass populated dataset to report

        '    oRpt.SetDataSource(objdsHRrpt)


        'bind report object with data to the Web Forms Viewer
        '  CrystalReportViewer1.ReportSource = oRpt

    End Sub

    '========================================================================================


    ' **************************************************************
    ' *  Function: ButtonOneClick. If the memory read button is    *
    ' *            clicked, the function will fill an array of     *
    ' *            bytes with the data stream from the oximeter.   *
    ' *            It first raises the timeout value while waiting *
    ' *            for the data to start. After the data is started*
    ' *            the timeout value is set to a lower value in    *
    ' *            milliseconds. Bytes are read byte by byte.      *
    ' *            When the timeout fires, the routine assumes this*
    ' *            is end of data from the Oximeter. As this is    *
    ' *            essentially a polling driver, it has to poll    *
    ' *            faster than the 9600 BAUD data stream.          *
    ' *            Certain windows methods installed into this     *
    ' *            function may slow it down enough for it to miss *
    ' *            data. When this happens, it will never return   *
    ' *            the same number of data bytes even though       *
    ' *            the memory of the Oximeter is read again and    *
    ' *            again. Writing to txtStatus does not seem to    *
    ' *            affect the operation, as long as no             *
    ' *            application.doevents calls are made.            *
    ' *                                                            *
    ' *            After this routine is used, one can search      *
    ' *            for valid headers. As the Windows environment   *
    ' *            is event driven, this is done here at the end   *
    ' *            if the read is successful                       *
    ' **************************************************************

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim bytesDisplayed As Integer = 1

        Dim x As Integer
        ' Zero out the array to rid of old data. Can cause false headers to be found.
        For x = 0 To 131070
            binbufferInt(x) = 0
        Next x

        Me.Label35.Visible = False
        GroupBox3.Visible = True
        Button1.Enabled = False
        Button1.Visible = False
        Label1.Text = "Receiving Data from Oximeter"
        Me.status.Text = "Reading Memory Data"
        Me.TextBox6.Clear()
        Me.TextBox6.Visible = True
        Me.TextBox6.Text = "Raw Oximeter Data will appear here"

        TextBox7.Visible = True
        TextBox7.Text = "--> Transferring Data -->"
        GroupBox3.Visible = True
        Application.DoEvents()
        System.Threading.Thread.Sleep(1000) ' Allow display to catch up before
        ' starting the reader thread.
        transferDone = False

        ' call thread
        Dim readerThread As New System.Threading.Thread(AddressOf commReadThread)
        bytesRead = 0 ' Keep this global zero, then call the thread
        readerThread.Start()
        TextBox7.Text = "Waiting for Dataflow"
        Application.DoEvents()

        Dim oxiPixUp As Boolean = False
        Dim d3 As New Form2()

        While (transferDone = False)
            Me.TextBox7.Text = "Read" + Str(bytesRead) + " bytes"
            If (bytesDisplayed < bytesRead) Then
                Me.TextBox6.AppendText(Str(binBuffer(bytesDisplayed)))
                bytesDisplayed += 1
                If (bytesRead > 0) And (oxiPixUp = False) Then
                    d3.Show()
                    oxiPixUp = True
                End If
                Application.DoEvents()
            End If
        End While


        Button1.Enabled = True
        Button1.Visible = True

        Dim timeout As Boolean = False
        Dim HeadersFound As Boolean = False
        Dim goodData As Boolean = False
        If oxiPixUp = True Then
            d3.Close()
        End If
        Me.TextBox6.Clear()
        Me.TextBox6.Visible = False
        Label35.Visible = True


        If bytesRead = 0 Then
            timeout = True

        End If

        If timeout = False Then
            getheaders()
            If headerArray(0) > 0 Then
                HeadersFound = True
            End If
        End If

        If HeadersFound = True Then
            goodData = True
        End If

        If (timeout = False) And (goodData = False) Then
            Label35.Text = "* Some Data transferred, but is corrupt." + vbCrLf + "* No valid session were found in the data sent." + vbCrLf _
            + "* Please press the RETRIEVE DATA button as soon as the ''CLR no'' screen flashes up on the Oximeter." _
            + vbCrLf + "* Check cables, batteries in Oximeter and try again." + vbCrLf + "* If problems persist, use a known good Oximeter with good data sessions stored inside it."
        End If

        If timeout = True Then
            Label35.Text = "Error: Data transfer malfunction" + vbCrLf + vbCrLf + "* Waited for data, but data was not sent." _
                        + vbCrLf + vbCrLf + "* Please press the RETRIEVE DATA button as soon as the ''CLR no'' screen appears on the Oximeter."
        End If

        If (goodData = True) And (timeout = False) Then
            Label35.Text = vbCrLf + vbCrLf + "Data Transfer Completed successfully." + vbCrLf + vbCrLf + Str(headerArray(0) - 1) + " sessions were downloaded." _
            + vbCrLf + vbCrLf + "Oximeter Data is loaded and ready for analysis"

            Application.DoEvents()
            goodMemoryRead()
        End If
    End Sub



    Sub commReadThread()

        ' Here, we open the COM port Odd parity as this is 
        ' required for reading the memory data as outlined in the
        ' Oximeter 920M Plus user manual.

        ' Note: We capture the buffer as a byte stream into an array of Bytes.
        ' It was found doing byte arthmetic in IF statements in subsequent procedures
        Dim Data As Boolean = True
        Dim charsRead As Integer = 0

        Dim aByte(1) As Byte

        Dim msTimeOutSet As Boolean = False
        Dim x As Integer = 0

        bytesRead = 0


        m_CommPort.Open(thisport, 9600, 8, Rs232.DataParity.Pariti_Odd, _
                Rs232.DataStopBit.StopBit_1, 4096)
        m_CommPort.setReadTimeOut(20000) '20 seconds
        While (Data)
            Try
                charsRead = m_CommPort.Read(1) 'Try to read 
                bytesRead += 1
                If (msTimeOutSet = False) Then
                    m_CommPort.setReadTimeOut(200) 'TO of 20 ms
                    msTimeOutSet = True
                End If
            Catch
                ' We asked for 1 characters, but timed out.
                ' Assume oximeter is done sending
                Data = False
            Finally
                If (Data = True) Then
                    ' Get the binary data from the buffer into local buffer
                    aByte = m_CommPort.InputStream
                    binBuffer(bytesRead) = aByte(0)
                End If
            End Try
        End While
        m_CommPort.Close()
        transferDone = True

        ' Here we copy the bytes from the binary buffer into the integer buffer.
        ' This is to avoid math errors when parsing data.

        For x = 0 To bytesRead
            binbufferInt(x) = binBuffer(x)
        Next x

    End Sub

    '======================================================================================

    ' **************************************************************
    ' *  Data Structures                                           *
    ' *                                                            *
    ' *  Please define all data structures here so they are found  *
    ' *  easily. In theory, they can be anywhere in VB.NET         *
    ' **************************************************************

    Dim ReportSelected As Boolean = False
    Dim OxiDataPresent As Boolean = False
    Dim PatientSelected As Boolean = False

    Dim bytesRead As Integer = 0 ' Used in Data reading thread and to display how many
    ' bytes have been read

    Dim transferDone As Boolean  ' used to sync read thread and display portions.
    ' Main win app drops thru when this is false.


    Private recsFound As Integer = 0

    Dim DeletedPeriodTime As Date ' This is made global just to not have to worry about it
    ' Used to keep track of how much data has been lost due to corruption such as a finger sensor falling off, ect.
    ' "A deleted period is a short time period where data was not collected during the study"

    Dim ExcludedSamplingTime As Date ' It is not clear how we use excluded time in this program as we can't yet edit the data and merge or
    ' pull out chunks of it.


    Dim binBuffer(131070) As Byte ' For capture of raw bytes. ReaderThread puts them here.
    ' Must be bytes to fit char data (8 bits) into and index them properly whilst reading
    ' ASCII data from comm port.


    ' Holds raw data converted to integer in the Memory Read event sub.
    Dim binbufferInt(131070) As Integer ' Bytes are copied to here.


    ' This array holds all the valid start locations of the headers found.
    ' It is used when calling "getheaders" function.
    Dim headerArray(100) As Integer


    ' Basic data structure to hold the times as found in the header.
    ' This is the basic data structure used as a data type for a structure
    ' of triples to hold the three types of times found in the header.
    Public Structure TimeTemplate
        Dim month As Integer
        Dim day As Integer
        Dim year As Integer
        Dim minute As Integer
        Dim second As Integer
        Dim hour As Integer
    End Structure

    Public Structure desaturationData
        Dim Under1MinTimer As Date
        Dim Under1MinDesatCount As Integer
        Dim Bet1and2MinTimer As Date
        Dim Bet1and2MinDesatCount As Integer
        Dim Bet2and3MinTimer As Date
        Dim Bet2and3MinDesatCount As Integer
        Dim Over3minTimer As Date
        Dim Bet3and4MinDesatCount As Integer
        Dim over4minTimer As Date
        Dim over4minDesatCount As Integer
        Dim totalDesat1to3InSec As Integer
        Dim TimeExcludedDueToArtifact As Date
        Dim numberOfArtifacts As Integer
    End Structure


    ' These is a structure holding three time data types. See dataType structure.
    ' An array of "times" will be constucted and used to contain the medical data.
    Public Structure times
        Dim startFirst As TimeTemplate
        Dim stopN As TimeTemplate
        Dim StartN As TimeTemplate
    End Structure

    ' These pairs are used to hold the HR and SpO2 values
    Public Structure dataType
        Dim SpO2 As Integer
        Dim HR As Integer
        Dim timeRecorded As Date
    End Structure

    ' Array to hold the HR/SpO2 data pairs
    ' See "times" structure
    Dim medData(50000) As dataType

    Dim timeData As times

    Public Structure statsType
        Dim High As Integer
        Dim Average As Double
        Dim Low As Integer
    End Structure

    Public Structure medStats
        Dim HR As statsType
        Dim SpO2 As statsType
    End Structure

    Public Structure rptData
        Dim DateOfReport As Date
        Dim DataCollectionStartDate As Date
        Dim DataCollectionEndDate As Date

        Dim RecordedData As Date
        Dim ExcludedData As Date
        Dim AnalysisData As Date

        Dim artifactEventsCount As Integer

        Dim HighSpO2 As Integer
        Dim AverageSpO2 As Double
        Dim LowSpO2 As Integer

        Dim TimeSpO290 As Date
        Dim TimeSpO280 As Date
        Dim TimeSpO270 As Date
        Dim TimeSpO260 As Date
        Dim TimeSpO2custom As Date

        Dim TimeSpO290Percent As String
        Dim TimeSpO280Percent As String
        Dim TimeSpO270Percent As String
        Dim TimeSpO260Percent As String
        Dim TimeSpO2customPercent As String


        Dim SpO2custom As Integer

        Dim LongestDesatCustomValue As Integer
        Dim LongestDesatCustomDuration As Integer

        Dim DesatIncidenceIndex As Double

        Dim DesatlessThen3minsNum As Integer
        Dim DesatLessThan3minsAvgTime As Date
        Dim DesatLessThen3minsAvgTimeInSec As Integer
        Dim DesatLessThen3minsAvgTimeInMin As Integer

        Dim desatUnder1minCount As Integer
        Dim desatUnder2minCount As Integer
        Dim desatUnder3minCount As Integer
        Dim desatUnder4minCount As Integer
        Dim desatOver4minCount As Integer
        Dim desatUnder1minTime As Date
        Dim desatUnder2minTime As Date
        Dim desatUnder3minTime As Date
        Dim desatUnder4minTime As Date
        Dim desatOver4minTime As Date


        Dim highHR As Integer
        Dim averageHR As Double
        Dim lowHR As Integer

        Dim secondsOfDesaturationEvents As Integer
    End Structure
    '======================================================================================

    ' **************************************************************
    ' *  Dubugging functions. Used in program development only     *
    ' *                                                            *
    ' **************************************************************



    Public Sub debugTimes()
        '  txtStatus.Clear()
        txtStatus.Visible = True

        Me.txtStatus.AppendText(vbCrLf + "Current/Start First File" + vbCrLf)

        Me.txtStatus.AppendText("Month=" + Str(timesScratchPad.startFirst.month) + vbCrLf)
        Me.txtStatus.AppendText("Day=" + Str(timesScratchPad.startFirst.day) + vbCrLf)
        Me.txtStatus.AppendText("Year=" + Str(timesScratchPad.startFirst.year) + vbCrLf)
        Me.txtStatus.AppendText("Minute=" + Str(timesScratchPad.startFirst.minute) + vbCrLf)
        Me.txtStatus.AppendText("Second=" + Str(timesScratchPad.startFirst.second) + vbCrLf)
        Me.txtStatus.AppendText("Hour=" + Str(timesScratchPad.startFirst.hour) + vbCrLf)

        Me.txtStatus.AppendText(vbCrLf + "StopN Times" + vbCrLf)

        Me.txtStatus.AppendText("Month=" + Str(timesScratchPad.stopN.month) + vbCrLf)
        Me.txtStatus.AppendText("Day=" + Str(timesScratchPad.stopN.day) + vbCrLf)
        Me.txtStatus.AppendText("Year=" + Str(timesScratchPad.stopN.year) + vbCrLf)
        Me.txtStatus.AppendText("Minute=" + Str(timesScratchPad.stopN.minute) + vbCrLf)
        Me.txtStatus.AppendText("Second=" + Str(timesScratchPad.stopN.second) + vbCrLf)
        Me.txtStatus.AppendText("Hour=" + Str(timesScratchPad.stopN.hour) + vbCrLf)


        Me.txtStatus.AppendText(vbCrLf + "StartN" + vbCrLf)

        Me.txtStatus.AppendText("Month=" + Str(timesScratchPad.StartN.month) + vbCrLf)
        Me.txtStatus.AppendText("Day=" + Str(timesScratchPad.StartN.day) + vbCrLf)
        Me.txtStatus.AppendText("Year=" + Str(timesScratchPad.StartN.year) + vbCrLf)
        Me.txtStatus.AppendText("Minute=" + Str(timesScratchPad.StartN.minute) + vbCrLf)
        Me.txtStatus.AppendText("Second=" + Str(timesScratchPad.StartN.second) + vbCrLf)
        Me.txtStatus.AppendText("Hour=" + Str(timesScratchPad.StartN.hour) + vbCrLf)
        Application.DoEvents()
    End Sub

    '======================================================================================

    ' **************************************************************
    ' *  Raw data processing functions.                            *
    ' *                                                            *
    ' **************************************************************



    ' **************************************************************
    ' *  Function: testCheckSumData. Checks the checksums of the   *
    ' *            HR, SpO2, checksum triplets in the raw data     *
    ' *            Tries to signal bad data by puting in constant  *
    ' *            values                                          *
    ' *  Inputs:                                                   *
    ' *  Arg 1: Integer array of raw data from Oximeter            *
    ' *                                                            *
    ' *  Arg 2: array - This is the output array of headers found  *
    ' *         and start points of the headers in the raw data    *
    ' *  Outputs: Number of headers is put into arg 1 array (0)    *
    '             position. Start of headers are placed in position*
    ' *           1 to position n where n is found in position 0   *
    ' *           of the array in arg 1.                           *
    ' *                                                            *
    ' *                                                            *
    ' **************************************************************

    Public Function FindHeaders(ByRef oxidata As Integer(), ByRef results() As Integer) As Boolean
        Dim len As Integer = 0
        Dim x As Integer = 0
        Dim headersFound As Integer = 0

        len = UBound(oxidata)

        '  Me.TextBox6.Clear()
        ' Me.TextBox6.Visible = True

        While (x < (len - 2))
            If ((oxidata(x) = 254) And (oxidata(x + 1) = 254) And (oxidata(x + 2)) = 252) Then
                '    Me.txtStatus.AppendText("Header at" + Str(x) + vbCrLf)

                ' 12/21/2002 Much of the test data from Pete is very corrupt. We add
                ' integrity checking.

                Dim headerGood As Boolean = True

                If binbufferInt(x) <> 254 Or _
                 binbufferInt(x + 1) <> 254 Or _
                 binbufferInt(x + 2) <> 252 Then
                    headerGood = False
                End If

                If binbufferInt(x + 3) > 12 Or binbufferInt(x + 3) = 0 Then  '  startFirst.month
                    headerGood = False
                End If


                If binbufferInt(x + 4) > 31 Or binbufferInt(x + 4) = 0 Then ' startFirst.day
                    headerGood = False
                End If

                If ChecksumBad(x + 5) = True Then ' parity at offset +5
                    headerGood = False
                End If

                '  binbufferInt(x+6) = 2 'startFirst.year 

                If binbufferInt(x + 7) > 59 Then  ' startFirst.minute 
                    headerGood = False
                End If


                If ChecksumBad(x + 8) = True Then


                    headerGood = False
                End If

                If binbufferInt(x + 9) > 59 Then '  time.startFirst.second
                    headerGood = False
                End If

                If binbufferInt(x + 10) > 23 Then  '  time.startFirst.hour = Array(offset + 10)
                    headerGood = False
                End If

                If ChecksumBad(x + 11) = True Then
                    headerGood = False
                End If

                ' stopN

                If binbufferInt(x + 12) > 12 Or binbufferInt(x + 12) = 0 Then '  StopN.month
                    headerGood = False
                End If

                If binbufferInt(x + 13) > 31 Or binbufferInt(x + 13) = 0 Then ' StopN.day
                    headerGood = False
                End If

                If ChecksumBad(x + 14) = True Then ' parity at offset +
                    headerGood = False
                End If

                ' binbufferInt(15) = 2 'StopN.year 


                If binbufferInt(x + 16) > 59 Then   ' StopN.minute 
                    headerGood = False
                End If

                If ChecksumBad(x + 17) = True Then ' parity at offset +
                    headerGood = False
                End If

                If binbufferInt(x + 18) > 59 Then '  StopN.second
                    headerGood = False
                End If
                If binbufferInt(x + 19) > 23 Then  '  StopN.hour = Array(offset + 10)
                    headerGood = False
                End If

                If ChecksumBad(x + 20) = True Then ' parity at offset +
                    headerGood = False
                End If









                If binbufferInt(x + 21) > 12 Or binbufferInt(x + 21) = 0 Then '  StartN.month
                    headerGood = False
                End If

                If binbufferInt(x + 22) > 31 Or binbufferInt(x + 22) = 0 Then ' StartN.day
                    headerGood = False
                End If

                If ChecksumBad(x + 23) = True Then ' parity at offset +
                    headerGood = False
                End If

                ' binbufferInt(24) = 2 'StartN.year 


                If binbufferInt(x + 25) > 59 Then   ' StartN.minute 
                    headerGood = False
                End If

                If ChecksumBad(x + 26) = True Then ' parity at offset +
                    headerGood = False
                End If

                If binbufferInt(x + 27) > 59 Then '  StartnN.second
                    headerGood = False
                End If
                If binbufferInt(x + 28) > 23 Then  '  StartN.hour = Array(offset + 10)
                    headerGood = False
                End If

                If ChecksumBad(x + 29) = True Then ' parity at offset +
                    headerGood = False
                End If

                If headerGood = True Then
                    headersFound += 1
                    results(headersFound) = x
                End If
                x += 1
            Else
                x += 1
            End If
        End While
        '  results(0) = headersFound - 1
        results(0) = headersFound
        If (headersFound > 0) Then
            Return (True)
        Else
            Return (False)
        End If
    End Function

    Function ChecksumBad(ByVal checksum As Integer) As Boolean
        Dim first As Integer
        Dim second As Integer
        Dim sum As Integer
        Dim temp As Integer

        first = binbufferInt(checksum - 2)
        second = binbufferInt(checksum - 1)
        sum = binbufferInt(checksum)
        temp = first + second
        If sum = temp Then
            Return (False)
        Else
            Return (True)
        End If



    End Function



    ' **************************************************************
    ' *  Function: getSpO2HR. Returns HR and SpO2 data to an array *
    ' *            built of HR and SpO2 integer pairs              *
    ' *  Inputs:                                                   *
    ' *  Arg 1: offset - This is the offset into the raw data      *
    ' *         integer array where                                *
    ' *         the header begins                                  *
    ' *  Arg 2: array - This is the array of integers copied from  *
    ' *         the raw Oximeter array. The array of integers is   *
    ' *         raw data in integer form, (not byte), from         *
    ' *         the Oximeter memory                                *
    ' *  Arg 3: This is the address of the array of pairs to       *
    ' *         contain the HR and SpO2 data points                *
    ' *         you asked for. Arg 3 contains the output           *
    ' *         data for the function                              *
    ' *                                                            *
    ' *  Notes:                                                    *
    ' *        This function is presumed to have a valid offset    *
    ' *        as a starting point at the beginning of a header.   *
    ' *        The offset will be at the integer "254" followed by *
    ' *        "254" then "252" ...                                *
    ' *        At 20 bytes past offset is the beginning of the     *
    ' *        HR, SpO2, checksum triplets. The checksum is just   *
    ' *        HR + SpO2 values.  A value of 255 is called out to  *
    ' *        be "invalid data" in the Oximeter book.             *
    ' *                                                            *
    ' *        Starting at an offet and skipping 30 bytes, the     *
    ' *        Function first performs data validation tests:      *
    ' *        1) Header Present ?                                 *
    ' *        2) End of File present (18 zeros)                   *
    ' *          3) Valid checksum present? (if not, resync)       *
    ' *                                                            *
    ' *                                                            *
    ' *        11-15-02 - We need a concept of what time these     *
    ' *        data points were recorded. The Oximeter records     *
    ' *        then every 4 seconds.  Other machines may be        *
    ' *        different, and the variable "interval" will have to *
    ' *        be changed or passed in as an arg.                  *
    ' *        We allow the Date to be incremented by 4 seconds    *
    ' *        for each data point read from the binary raw data   *
    ' *        and we store the time in the 'timeRecorded' field   *
    ' *        of type date.                                       *
    ' *        This format should be applied to records in a data  *
    ' *        base as type date.  Programs as Crystal Reports     *
    ' *        can then generate axis on a graph from the time     *
    ' *        stored in the timeRecorded field.                   *
    ' *          Of greater importance is calculating the          *
    ' *        desaturation values. These need a time marker to    *
    ' *        allow programatic timers to be set and triggered    *
    ' *        for desaturation points                             *
    ' *        11.18.02 - We need a way for the sync routine to    *
    ' *        only try to sync as long as there is valid data     *
    ' *        for the run. The run is the number of minutes       *
    ' *        of the run * 15 for the number of samples taken.    *
    ' *        StopNTotalMinutes - StartNTotalMinutes * 15         *
    ' *        should be about the number of data points taken.    *
    ' *        This number should be used to stop looking for sync *
    ' *        when this number of records has been processed.     *
    ' *                                                            *
    ' *        12.20.02. The desaturation readings have tested     *
    ' *        wrong. The verbage from this point down will attempt*
    ' *        to fix what has been built to this point from the   *
    ' *        text and methods above.                             *
    ' *        It is critical to retain the bad data that may      *
    ' *        be skipped over. Instead of skipping records as     *
    ' *        above, we now changed the action from "skip"        *
    ' *        to "mark" The records will be marked as "artifact"  *
    ' *        with a "777" integer.                               *
    ' *        The desaturation routine, upon encountering this    *
    ' *        data will disqualify the EDP event, "excluded due   *
    ' *        to artifact"                                        *
    ' *        We also have to add "777" to the data gap caused by *
    ' *        the resync routine.                                 *
    ' **************************************************************

    Sub getSpO2HR(ByVal offset As Integer, ByRef array() As Integer, ByRef data() As dataType, ByVal StartN As Date, _
     ByRef excludedDataTime As Date)


        Dim ValidData As Boolean = True
        Dim markRecord As Boolean = False
        Dim x As Integer = 1 ' Start at offset 1. Reserve offset 0 for number of 
        ' data points.
        Dim runningTime As Date
        Dim Later As Date
        Dim recordsMarked As Integer
        Dim badChecksum As Boolean = False
        Dim resyncEvent As Boolean = False
        Dim newOffset As Integer = 0
        Dim originalOffset As Integer
        Dim interval As Double = 4.0  ' Important - This *may* have to be changed for different Oximeters

        originalOffset = offset ' Save this for the gettime function called in the canReSync function

        excludedDataTime = CDate("#00:00:00#")
        ' Set the running time.
        runningTime = StartN

        ' SpO2 and HR data begins at offset 30
        offset += 30
        While (ValidData)
            ' Check if a new header of next file
            If CheckForHeader(offset, array) = True Then
                ' We ran into the next header of the next record
                ValidData = False
            End If

            If ValidData = True Then ' Check for End of File
                If CheckForEOF(offset, array) = True Then
                    ValidData = False
                End If
            End If

            If ValidData = True Then
                If CheckForBadChecksum(offset, array) = True Then
                    ValidData = False
                    badChecksum = True
                End If
            End If

            ' Try to recover from bad checksums.
            ' keep testing bad checksum data, byte by byte and try to reSync to a 
            ' good checksum

            If (ValidData = False) And (badChecksum = True) Then
                If canResync(offset, array, newOffset, originalOffset) = True Then
                    recordsMarked = (newOffset - offset) \ 3
                    excludedDataTime = DateAdd(DateInterval.Second, 4 * recordsMarked, excludedDataTime)
                    ' Here, we have to fill in the corrupted records that were skipped in the sync routine
                    ' with "777"
                    Dim ff As Integer
                    For ff = offset To newOffset Step 3
                        data(x).HR = 777
                        data(x).SpO2 = 777
                        runningTime = DateAdd(DateInterval.Second, 4, runningTime)
                        data(x).timeRecorded = runningTime
                        x += 1
                    Next ff
                    offset = newOffset
                    ValidData = True
                    badChecksum = False
                    resyncEvent = True
                Else
                    ' If we get here, we tried to reSync on the data and could not.
                    ' The sync routine tried and tried....
                    ' We got into a runaway condition and ReSync found EOF or a new header or determined
                    ' that the data did not belong to this reading event and it gave up.
                    ' This data must be excluded.
                    ValidData = False ' Shut down processing of this errant data! "While" loop now falls through
                    ' At this point, there is nothing to flip valid data back to true. 
                    badChecksum = True
                    recordsMarked = (newOffset - offset) \ 3
                    excludedDataTime = DateAdd(DateInterval.Second, 4 * recordsMarked, excludedDataTime)
                End If
            End If


            ' Lastly, test the data for sanity. HR and SpO2 values have reasonable limits.
            If ifReasonableData(offset, array) = False Then
                ' Data is not reasonable. So, mark the record.
                markRecord = True
                excludedDataTime = DateAdd(DateInterval.Second, 4, excludedDataTime)
            End If


            ' At this point, the data is good, so mine it and copy it to the output structure.
            ' If a resync too place, we are just at the good data and there is no record to add yet.
            ' So, if just had a resync, we skip all this and just increment the counters.
            If (resyncEvent = True) Then
                ' We ignore the below if resync event happened as there is essentially no new data to add.
                ' "777"'s were added below the call of the resync event above.
                ' resync has pointed the program at good data, so offset is NOT incremented here.
                ' x is also ready to go from the resync, so leave those alone here.
                resyncEvent = False
            Else
                If (ValidData = True) Then
                    If (markRecord = False) Then
                        data(x).HR = array(offset)
                        data(x).SpO2 = array(offset + 1)
                        data(x).timeRecorded = runningTime
                        x += 1
                        ' Increment the running time by interval seconds.
                        runningTime = DateAdd(DateInterval.Second, interval, runningTime)
                    Else
                        ' This part is executed as a skipped or marked  record.
                        ' This is excluded data, so count it.
                        excludedDataTime = DateAdd(DateInterval.Second, 4, excludedDataTime)
                        ' 12.20.2002 - We now marked the skipped data with "777"
                        ' Added 12.20.2002 - 4 lines
                        data(x).HR = 777
                        data(x).SpO2 = 777
                        data(x).timeRecorded = runningTime
                        runningTime = DateAdd(DateInterval.Second, interval, runningTime)
                        x += 1
                        ' end added 4 lines 12.20.2002
                        markRecord = False

                    End If ' skip IF
                    offset += 3
                End If ' valid data IF
            End If ' resync IF
        End While

        data(0).HR = x - 1 ' Number of data pairs processed
        data(0).SpO2 = x - 1 ' ditto
    End Sub


    Function canResync(ByVal offset As Integer, ByRef array() As Integer, ByRef goodOffset As Integer, ByVal startingOffset As Integer) As Boolean
        Dim inSync As Boolean = False
        Dim recordsProcessed As Integer = 0
        Dim StartTime As Date
        Dim StopTime As Date
        Dim rptTimes As times
        Dim runningTime As Integer

        gettimesHeader(startingOffset, array, rptTimes) ' Need to get the times from the offset of interest

        StartTime = CDate("#" + Str(rptTimes.StartN.hour) + ":" + Str(rptTimes.StartN.minute) + ":" + Str(rptTimes.StartN.second) + "#")
        StopTime = CDate("#" + Str(rptTimes.stopN.hour) + ":" + Str(rptTimes.stopN.minute) + ":" + Str(rptTimes.stopN.second) + "#")

        runningTime = CInt(DateDiff(DateInterval.Minute, StartTime, StopTime))
        runningTime *= 15 ' 15 (4 second samples) per minute

        '   While (inSync = False) And (offset <= 65532) And (CheckForEOF(offset, array) = False) And (recordsProcessed <= runningTime)
        While (inSync = False) And (offset <= 65532) And (CheckForEOF(offset, array) = False) And (recordsProcessed <= 65532)
            If CheckForBadChecksum(offset, array) = True Then
                offset += 1 ' just keep testing
            Else
                inSync = True
            End If
            recordsProcessed += 1
        End While



        If (inSync = True) And (goodHRspO2data(offset, array) = True) Then
            goodOffset = offset
            Return (True) ' If we are inSync but goodHRspO2data is false, then we are syncing on time data
            ' so forget this. as we are onto the next header.
        Else
            ' return the new offset so we can exclude that data
            goodOffset = offset
            Return (False)
        End If
    End Function





    Function badDataPresent(ByVal offset As Integer, ByRef array() As Integer) As Boolean
        If ((array(offset) = 0) And (array(offset + 1) = 0) And (array(offset + 2) = 0)) Or _
           ((array(offset) = 255) And (array(offset + 1) = 255) And (array(offset + 2) = 255)) Then
            Return (True)
        Else
            Return (False)
        End If
    End Function

    Function ifReasonableData(ByVal offset As Integer, ByRef array() As Integer) As Boolean
        ' HR is at offset + 0
        ' SpO2 is at offset + 1
        Dim goodData As Boolean = False ' Assume bad data. So mean.
        ' test HR ranges
        If (array(offset) >= 40) And (array(offset) < 200) Then ' Heart rate less than 40 and over 200 BPM- dead, drugs or bad data
            goodData = True
        End If
        ' Test SpO2 ranges
        If (array(offset + 1) >= 10) And (array(offset + 1) <= 100) Then ' Sp02 can be between 100 and 0, we omit 10 or below
            goodData = True
        End If
        Return (goodData)
    End Function


    Function goodHRspO2data(ByVal offset As Integer, ByRef array() As Integer) As Boolean
        If ((array(offset) > 31) And (array(offset + 1) > 31) And (array(offset + 2) > 31)) Then
            Return (True)
        Else
            Return (False)
        End If
    End Function


    Function CheckForHeader(ByVal offset As Integer, ByRef array() As Integer) As Boolean
        If ((array(offset) = 254) And (array(offset + 1) = 254) And (array(offset + 2) = 252)) Then
            Return (True)
        Else
            Return (False)
        End If
    End Function

    Function CheckForBadChecksum(ByVal offset As Integer, ByRef array() As Integer) As Boolean
        If ((array(offset)) + (array(offset + 1)) = (array(offset + 2))) Then
            Return (False)
        Else
            Return (True)
        End If


    End Function

    Function CheckForEOF(ByVal offset As Integer, ByRef array() As Integer) As Boolean

        If ((array(offset) = 0) And (array(offset + 1) = 0) And (array(offset + 2) = 0) And (array(offset + 3) = 0) _
                        And (array(offset + 4) = 0) And (array(offset + 5) = 0) And (array(offset + 6) = 0) _
                        And (array(offset + 7) = 0) And (array(offset + 8) = 0) And (array(offset + 9) = 0) _
                        And (array(offset + 10) = 0) And (array(offset + 11) = 0) And (array(offset + 12) = 0) _
                        And (array(offset + 13) = 0) And (array(offset + 14) = 0) And (array(offset + 15) = 0) _
                        And (array(offset + 16) = 0) And (array(offset + 17) = 0)) Then
            Return (True)
        Else
            Return (False)
        End If
    End Function


    ' **************************************************************
    ' *  Function: gettimes. Returns time fields in the header     *
    ' *  Inputs:                                                   *
    ' *  Arg 1: offset - This is the offset into the array where   *
    ' *         the header begins                                  *
    ' *  Arg 2: array - This is the array of bytes from the read of*
    ' *         the Oximeter memory                                *
    ' *  Arg 3: This is the address of the structure to contain the*
    ' *         times you asked for. Arg 3 contains the output     *
    ' *         data for the function                              *
    ' **************************************************************



    Sub gettimesHeader(ByVal offset As Integer, ByRef array() As Integer, ByRef time As times)
        Dim checkSumError As Integer

        ' Offset begins at byte 254, first byte of header
        ' Offset +1 is 254, second byte of header
        ' Offset +2 is 252 Third byte of header

        ' Bump offset by one
        '    offset += 1


        time.startFirst.month = array(offset + 3)
        time.startFirst.day = array(offset + 4)
        ' parity at offset +5
        If (((array(offset + 3) + (array(offset + 4)) <> (array(offset + 5))))) Then
            checkSumError += 1
        End If

        time.startFirst.year = array(offset + 6)
        time.startFirst.minute = array(offset + 7)
        ' parity at offset +8
        If (((array(offset + 6) + (array(offset + 7)) <> (array(offset + 8))))) Then
            checkSumError += 1
        End If
        time.startFirst.second = array(offset + 9)
        time.startFirst.hour = array(offset + 10)
        ' parity at offset +11
        If (((array(offset + 9) + (array(offset + 10)) <> (array(offset + 11))))) Then
            checkSumError += 1
        End If

        time.stopN.month = array(offset + 12)
        time.stopN.day = array(offset + 13)
        ' parity at offset +14

        If (((array(offset + 12) + (array(offset + 13)) <> (array(offset + 14))))) Then
            checkSumError += 1
        End If

        time.stopN.year = array(offset + 15)
        time.stopN.minute = array(offset + 16)
        ' parity at offset +17

        If (((array(offset + 15) + (array(offset + 16)) <> (array(offset + 17))))) Then
            checkSumError += 1
        End If

        time.stopN.second = array(offset + 18)
        time.stopN.hour = array(offset + 19)
        'parity at offset +20

        If (((array(offset + 18) + (array(offset + 19)) <> (array(offset + 20))))) Then
            checkSumError += 1
        End If

        time.StartN.month = array(offset + 21)
        time.StartN.day = array(offset + 22)
        'parity at offset +23

        If (((array(offset + 21) + (array(offset + 22)) <> (array(offset + 23))))) Then
            checkSumError += 1
        End If

        time.StartN.year = array(offset + 24)
        time.StartN.minute = array(offset + 25)
        'parity at offset +26

        If (((array(offset + 24) + (array(offset + 25)) <> (array(offset + 26))))) Then
            checkSumError += 1
        End If

        time.StartN.second = array(offset + 27)
        time.StartN.hour = array(offset + 28)
        'parity at offset +29

        If (((array(offset + 27) + (array(offset + 28)) <> (array(offset + 29))))) Then
            checkSumError += 1
        End If
        If (checkSumError > 0) Then
            Me.TextBox6.AppendText("Time CheckSum Errors = " + Str(checkSumError))
        End If
        TextBox6.Visible = False
    End Sub


    ' **************************************************************
    ' *  Function: getOneRawDataFile. Returns Oxi raw integer      *
    ' *            bytes to a byte array.                          *
    ' *  Inputs:                                                   *
    ' *  Arg 1: offset - This is the offset into the raw data      *
    ' *         integer array where                                *
    ' *         the header begins.                                 *
    ' *  Arg 2: array - This is the array of integers copied from  *
    ' *         the raw Oximeter array. The array of integers is   *
    ' *         raw data in integer form, (not byte), from         *
    ' *         the Oximeter memory                                *
    ' *  Arg 3: This is the address of the array to receive        *
    ' *         the raw data stream. The destination of this       *
    ' *         raw data stream is an OLE entry in the database    *
    ' *         to save in the Patient's table under rawbytes1     *
    ' *         to rawbytes5. Rawbytes1 would be report#1,         *
    ' *         Rawbytes#2 is repor#2, ect.                        *
    ' * Arg 4:  Length of file found and data returned.            *
    ' *                                                            *
    ' *                                                            *
    ' *  Notes:                                                    *
    ' *        This function is presumed to have a valid offset    *
    ' *        as a starting point at the beginning of a header.   *
    ' *        The offset will be at the integer "254" followed by *
    ' *        "254" then "252" ...                                *
    ' *        At 30 bytes past offset is the beginning of the     *
    ' *        HR, SpO2, checksum triplets. The checksum is just   *
    ' *        HR + SpO2 values.  A value of 255 is called out to  *
    ' *        be "invalid data" in the Oximeter book.             *
    ' *                                                            *
    ' *                                                            *
    ' *        We want to keep the data intact                     *
    ' *        in raw form in the database. It can be reprocessed  *
    ' *        and errors found to then calculate the excluded     *
    ' *        time due to artifacts.                              *
    ' *                                                            *
    ' **************************************************************



    Sub getOneRawDataFile(ByVal offset As Integer, ByRef array() As Integer, ByRef data() As Byte, ByRef len As Integer)
        ' Some data may be corrupt and can cause math exceptions in this procedure.
        Dim z As Integer
        Dim ValidData As Boolean = True

        Dim x As Integer = 0 ' Start at offset 0. 
        ' data points.


        ' SpO2 and HR data begins at offset 30.
        ' However, we are interested in the whole file. We need the whole thing intact to reprocess
        ' it as raw data again.
        For z = offset To offset + 29
            data(x) = CByte(array(z))
            x += 1
        Next z

        ' SpO2 and HR data begins at offset 30
        offset += 30
        While (ValidData)
            ' Check if a new header of next file
            If CheckForHeader(offset, array) = True Then
                ' We ran into the next header of the next record
                ValidData = False
            End If

            If ValidData = True Then ' Check for End of File
                If CheckForEOF(offset, array) = True Then
                    ValidData = False
                End If
            End If

            If (ValidData = True) Then
                data(x) = CByte(array(offset))
                x += 1
                data(x) = CByte(array(offset + 1))
                x += 1
                data(x) = CByte(array(offset + 2))
                x += 1
                offset += 3
            End If
        End While
        ' Append 18 zeros for end of data marker
        For z = 1 To 18
            data(x) = 0
            x += 1
        Next z
        len = x - 1 ' Number of data pairs processed 
    End Sub



    '=====================================================================================


    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try
            Dim x As Integer
            Dim Result As DialogResult
            Dim diagRes As Boolean = False

            ' Zero out the array to rid of old data. Can cause false headers to be found.
            For x = 0 To 131070
                binbufferInt(x) = 0
            Next x


            Result = OpenFileDialog1.ShowDialog

            If Result = DialogResult.OK Then
                diagRes = True
            End If

            Dim fileName As String

            '   For Each fileName In SaveFileDialog1.FileNames()

            fileName = OpenFileDialog1.FileNames(0)
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Loaded Oxidata Text file:")
            ListBox2.Items.Add(fileName)
            ListBox2.Items.Add("into program memory. Ready to use or assign")



            Dim instream As New IO.FileStream(fileName, IO.FileMode.Open, _
              IO.FileAccess.Read)
            Dim reader As New IO.StreamReader(instream)

            For x = 1 To 131070
                binbufferInt(x) = CInt(reader.ReadLine.ToString())
                '  ListBox2.Items.Add(Str(binbufferInt(x)))
            Next x
            reader.Close()
        Catch
        End Try

        goodMemoryRead()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim x As Integer
            Dim Result As DialogResult
            Dim diagRes As Boolean = False


            Result = SaveFileDialog1.ShowDialog

            If Result = DialogResult.OK Then
                diagRes = True
            End If

            Dim fileName As String

            '   For Each fileName In SaveFileDialog1.FileNames()

            fileName = SaveFileDialog1.FileNames(0)
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Oxidata text file:")
            ListBox2.Items.Add(fileName)
            ListBox2.Items.Add("was successfully saved to disk.")

            Dim outstream As New IO.FileStream(fileName, IO.FileMode.CreateNew, _
              IO.FileAccess.Write)
            Dim writer As New IO.StreamWriter(outstream)

            For x = 1 To 131070
                writer.WriteLine(Str(binbufferInt(x)))
            Next x

            writer.Flush()
            writer.Close()

        Catch
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim x As Integer
            Dim Result As DialogResult
            Dim diagRes As Boolean = False


            Result = SaveFileDialog1.ShowDialog

            If Result = DialogResult.OK Then
                diagRes = True
            End If

            Dim fileName As String

            '   For Each fileName In SaveFileDialog1.FileNames()

            fileName = SaveFileDialog1.FileNames(0)
            ListBox2.Items.Clear()
            ListBox2.Items.Add("All Oxidata was exported to XML file:")
            ListBox2.Items.Add(fileName)
            ListBox2.Items.Add("And successfully saved to disk for you.")


            Dim xmloutstream As New IO.FileStream(fileName, IO.FileMode.CreateNew, _
              IO.FileAccess.Write)
            Dim writer As New IO.StreamWriter(xmloutstream)

            Dim Temp(50000) As String

            filesToXML(Temp)

            For x = 1 To CInt(Temp(0))
                writer.WriteLine(Temp(x))
            Next x

            writer.Flush()
            writer.Close()

        Catch
        End Try
    End Sub


    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim rd As rptData


        ' Generate data for the report. This calls the formulae engine to calculate and fills in the values to
        ' the supplied structure.
        generateReportData(ListBox1.SelectedIndex + 1, rd)

        ' Update the Summary screen on the TAB form.
        updateSummaryReportScreen(rd)

        ' Update the Crystal Reports report. This writes data to the Access DB. Crystal reports
        ' "reports from"  the database records written from this function call.
        updateCryReportsBody(rd)
        '
        ' Populate the SpO2 and HR data in the Access tables. The Crystal Reports engine will
        ' open its own connection and pull the data out. I did not design Crystal Reports, and
        ' that is how it works.
        '  updateHRandSpO2ChartData(ListBox1.SelectedIndex + 1)' This is VERY Time Consuming. We don't do this here, but YES in Data Summary.
        '  System.Threading.Thread.CurrentThread.Sleep(400)
        'Refresh the report viewer as the report has substancially changed
        CrystalReportViewer1.RefreshReport()
        ' This boolean below is one of two boolean variables that allows the "send report to patient" button to enable
        ReportSelected = True
        If (ReportSelected = True) And (OxiDataPresent = True) And (PatientSelected = True) Then
            ' enable data button
            Button7.Enabled = True
        End If
    End Sub

    Sub updateHRandSpO2ChartData(ByVal file As Integer)
        Dim x As Integer
        Dim cn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; DATA SOURCE=C:\Program Files\oxistat1dot0\OxistatAccessDB.mdb")
        Dim cmd As New OleDbCommand("DELETE * FROM CrystalReportsSpO2Data", cn)
        Dim cmd1 As New OleDbCommand("DELETE * FROM CrystalReportsHRData", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()

        getdata(file, medData) ' Pull the HR and SpO2 values from the inmemory raw data cache  
        scrub777FromData(medData)

        ' Here, fill up the tables in the Access database with the HR and SpO2 data. Crystal Reports will report
        ' off of this data.

        ' This can lock up the program as it takes so long.
        ' Limit the graph to 500 to 1000 points.
        Dim y As Integer = 1
        If medData(0).HR > 2000 Then
            y = medData(0).HR \ 1000
        End If

        For x = 1 To medData(0).HR - 1 Step y
            Dim cmd2 As New OleDbCommand()
            cmd2.Connection = cn
            cmd2.CommandText = "INSERT INTO CrystalReportsHRData (HR, SampleTime)" _
                   & " values(" & Str(medData(x).HR) & "," & "'" & Format(medData(x).timeRecorded, "MM/dd/yy HH:mm:ss") & "'" & ")"
            cmd2.ExecuteNonQuery()
        Next x

        ' 12/30/2002 - Made SpO2 lowest value possible to be 40 as per Pete's request.
        For x = 1 To medData(0).HR - 1 Step y
            Dim cmd2 As New OleDbCommand()
            cmd2.Connection = cn
            If medData(x).SpO2 < 40 Then '-start- added 12.30.2002
                medData(x).SpO2 = 40 ' ditto
            End If ' -end- added 12.30.2002
            '   If medData(x).SpO2 = 0 Then
            '   MessageBox.Show("Found a Zero")
            '  End If
            cmd2.CommandText = "INSERT INTO CrystalReportsSpO2Data (SpO2, SampleTime)" _
                       & " values(" & Str(medData(x).SpO2) & "," & "'" & Format(medData(x).timeRecorded, "MM/dd/yy HH:mm:ss") & "'" & ")"
            cmd2.ExecuteNonQuery()
        Next x

    End Sub


    Sub updateSummaryReportScreen(ByRef rd As rptData)

        ' Populate the "Data Summary" screen
        Label11.Text = "Recorded Data: " + Format(rd.RecordedData, "HH:mm.ss")
        Label12.Text = "Excluded Data: " + Format(rd.ExcludedData, "HH:mm.ss")
        Label13.Text = "Analysis Data: " + Format(rd.AnalysisData, "HH:mm.ss")

        Label14.Text = "Excluded events not included in analysis due to artifact:" + Str(rd.artifactEventsCount)

        Label16.Text = "High SpO2:" + Str(rd.HighSpO2)
        Label17.Text = "Average SpO2:" + Format(rd.AverageSpO2, "##.0")
        Label18.Text = "Low SpO2:" + Str(rd.LowSpO2)

        Label19.Text = "Time SpO2 below 90: " + Format(rd.TimeSpO290, "HH:mm:ss") + "    " + rd.TimeSpO290Percent
        Label20.Text = "Time SpO2 below 80: " + Format(rd.TimeSpO280, "HH:mm:ss") + "    " + rd.TimeSpO280Percent
        Label21.Text = "Time SpO2 below 70: " + Format(rd.TimeSpO270, "HH:mm:ss") + "    " + rd.TimeSpO270Percent
        Label22.Text = "Time SpO2 below 60: " + Format(rd.TimeSpO260, "HH:mm:ss") + "    " + rd.TimeSpO260Percent

        Label23.Text = "Time SpO2 Equal or Below 88: " + Format(rd.TimeSpO2custom, "H:mm:ss") + "    " + rd.TimeSpO2customPercent

        Label25.Text = "The desaturation incident index for the study was " + Format(rd.DesatIncidenceIndex, "#0.0") + " per hour."

        Label26.Text = "There were" + Str(rd.DesatlessThen3minsNum) + " desaturation incidents of less then three minutes" + _
        " in duration of which the average length of these incidents was" + Str(rd.DesatLessThen3minsAvgTimeInMin) + _
        " minutes and" + Str(rd.DesatLessThen3minsAvgTimeInSec) + " sec."


        Label27.Text = "Desaturation Incidents under 1 minute:   " + Str(rd.desatUnder1minCount)
        Label28.Text = "Desaturation Incidents under 2 minutes: " + Str(rd.desatUnder2minCount)
        Label29.Text = "Desaturation Incidents under 3 minutes: " + Str(rd.desatUnder3minCount)
        Label30.Text = "Desaturation Incidents under 4 minutes: " + Str(rd.desatUnder4minCount)


        Label32.Text = "High HR:" + Str(rd.highHR)
        Label33.Text = "Average HR:" + Format(rd.averageHR, "##.0")
        Label34.Text = "Low HR:" + Str(rd.lowHR)
    End Sub


    Sub updateCryReportsBody(ByRef rd As rptData)

        Dim obj1OrgDataSet1 As dsOrg = New dsOrg()
        Dim objdsRpt As dsRpt = New dsRpt()
        '   OrgDataAdapter1.Fill(obj1OrgDataSet1)

        daRpt.Fill(objdsRpt)

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("DateofReport") = Format(rd.DateOfReport, "HH:mm:ss   MM/dd/yy")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("CollectionStartDate") = Format(rd.DataCollectionStartDate, "HH:mm:ss   MM/dd/yy")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("CollectionEndDate") = Format(rd.DataCollectionEndDate, "HH:mm:ss   MM/dd/yy")

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("ExcludedEventsCount") = rd.artifactEventsCount

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("RecordedData") = Format(rd.RecordedData, "HH:mm:ss")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("ExcludedData") = Format(rd.ExcludedData, "HH:mm:ss")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("AnalysisData") = Format(rd.AnalysisData, "HH:mm:ss")

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("HighSpO2") = Str(rd.HighSpO2)

        Try
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("AverageSpO2") = Format(rd.AverageSpO2, "##.#")
        Catch
        End Try

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("LowSpO2") = Str(rd.LowSpO2)

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO290") = Format(rd.TimeSpO290, "HH:mm:ss")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO280") = Format(rd.TimeSpO280, "HH:mm:ss")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO270") = Format(rd.TimeSpO270, "HH:mm:ss")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO260") = Format(rd.TimeSpO260, "HH:mm:ss")

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO290Percent") = rd.TimeSpO290Percent
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO280Percent") = rd.TimeSpO280Percent
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO270Percent") = rd.TimeSpO270Percent
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO260Percent") = rd.TimeSpO260Percent
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO2CustomPercent") = rd.TimeSpO2customPercent

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("SpO2custom") = Format(rd.SpO2custom, "##")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("TimeSpO2custom") = Format(rd.TimeSpO2custom, "HH:mm:ss")

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("DesatIncidenceIndex") = rd.DesatIncidenceIndex

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("DesatlessThen3minsNum") = rd.DesatlessThen3minsNum
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("DesatLessThen3minsAvgTimeInMin") = rd.DesatLessThen3minsAvgTimeInMin
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("DesatLessThen3minsAvgTimeInSec") = rd.DesatLessThen3minsAvgTimeInSec


        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("desatUnder1minCount") = Str(rd.desatUnder1minCount)
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("desatUnder2minCount") = Str(rd.desatUnder2minCount)
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("desatUnder3minCount") = Str(rd.desatUnder3minCount)
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("desatUnder4minCount") = Str(rd.desatUnder4minCount)


        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("highHR") = Str(rd.highHR)
        Try
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("averageHR") = Format(rd.averageHR, "###")
        Catch
        End Try

        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("lowHR") = Str(rd.lowHR)

        daRpt.Update(objdsRpt)

    End Sub

    '  Sub UpdateCryReportsCharts()


    '     getheaders()

    '     getdata(ListBox3.SelectedIndex + 1, medData)


    '  Set the values in the SpO2 table
    '      Dim objdsSpO2rpt As dsSpO2rpt = New dsSpO2rpt()
    '      daSpO2rpt.Fill(objdsSpO2rpt)
    '      objdsSpO2rpt.Clear() ' Clear out the dataset thereby deleting all the old records.

    '      For x = 1 To medData(0).HR
    '         Dim newrow1 As dsSpO2rpt.CrystalReportsSpO2DataRow = objdsSpO2rpt.CrystalReportsSpO2Data.NewCrystalReportsSpO2DataRow
    '         newrow1.Item("SpO2") = medData(x).SpO2
    '          newrow1.Item("SampleTime") = medData(x).timeRecorded
    '          objdsSpO2rpt.CrystalReportsSpO2Data.AddCrystalReportsSpO2DataRow(newrow1)
    '       Next x
    '    daSpO2rpt.Update(objdsSpO2rpt)
    '  End Sub



    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim d1 As New DataForm1()
        d1.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim d2 As New DataForm2()
        d2.Show()
    End Sub


    ' This causes a data concurrency violation out of the patient's form screen
    '  Private Sub TabPage2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage2.Paint
    '     daRpt.Fill(DsRpt)
    ' System.Threading.Thread.CurrentThread.Sleep(400)
    'Refresh the report viewer as the report has substancially changed
    '    CrystalReportViewer1.RefreshReport()
    '  End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        daPatients.Fill(DsPatientsForm1)
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim d As New Form3()
        d.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim rawData(131070) As Byte
        Dim len As Integer

        ' Get raw Oxi data file. This is for loading into the database to save the patient raw data record.
        ' For regenerating charts and report.
        getRawData(ListBox1.SelectedIndex + 1, rawData, len)

        Dim objdsPatients As dsPatients = New dsPatients()

        objdsPatients.Clear()
        daPatients.Fill(objdsPatients)
        ' Get the patient ID to build the query on where to store the BLOB data. This is the raw data from a Oximeter session.
        Dim PatientID As String = Str(objdsPatients.Tables("Patients").Rows(DataGrid1.CurrentRowIndex).Item("PatientID"))

        Dim cn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; DATA SOURCE=C:\Program Files\oxistat1dot0\OxistatAccessDB.mdb")
        ' First, delete out any BLOB data in there.

        cn.Open()

        '   Dim cmd As New OleDbCommand("DELETE rawbytes1 FROM Patients  WHERE PatientID=" & PatientID, cn)
        '   cmd.ExecuteNonQuery()

        Dim cmd1 As New OleDbCommand("UPDATE Patients SET Rawbytes1=? WHERE PatientID=" & PatientID, cn)
        Dim b(len) As Byte
        Dim x As Integer
        For x = 0 To len
            b(x) = rawData(x)
        Next x
        Dim P As New OleDbParameter("@Picture", OleDbType.LongVarBinary, b.Length, ParameterDirection.Input, False, 0, 0, Nothing, DataRowVersion.Current, b)
        ' Dim P As New OleDbParameter("@Picture", OleDbType.LongVarBinary, len, ParameterDirection.Input, False, 0, 0, Nothing, DataRowVersion.Current, rawData)
        cmd1.Parameters.Add(P)
        cmd1.ExecuteNonQuery()
        cn.Close()
        objdsPatients.Tables("Patients").Rows(DataGrid1.CurrentRowIndex).Item("ReportsNumSaved") = "1"

        daPatients.Update(objdsPatients)
        DsPatientsForm1.Clear()
        daPatients.Fill(DsPatientsForm1)

    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        '    ListBox1.Items.Add("Data Grid1 got a single click")

        '    ListBox1.Items.Add(Str(DataGrid1.CurrentRowIndex))

        CryRptPatientUpdate() ' Send patient data from the clicked data row to Crystal Reports
        ' As the report has materially changed, update the report viewer so the data can be seen.
        '   System.Threading.Thread.CurrentThread.Sleep(400)
        CrystalReportViewer1.RefreshReport()
        PatientSelected = True
        If (ReportSelected = True) And (OxiDataPresent = True) Then
            ' enable data button
            Button7.Enabled = True
        End If
    End Sub

    Sub CryRptPatientUpdate()
        Dim row As Integer = DataGrid1.CurrentRowIndex
        Dim objdsRpt As dsRpt = New dsRpt()
        daPatients.Fill(DsPatientsForm1)
        daRpt.Fill(objdsRpt)


        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("CustomerID") = DsPatientsForm1.Tables("Patients").Rows(row).Item("CustomerID")
        Dim name As String
        ' Because there was a huge gap between first and last name in Crystal reports, the first name now
        ' carries first and last names. Only the first name field is present on Crystal Reports .rpt file.
        name = CStr(DsPatientsForm1.Tables("Patients").Rows(row).Item("FirstName")) + CStr(" ") + CStr(DsPatientsForm1.Tables("Patients").Rows(row).Item("LastName"))
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientFirstName") = name
        'objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientFirstName") = DsPatientsForm1.Tables("Patients").Rows(row).Item("FirstName")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientLastName") = DsPatientsForm1.Tables("Patients").Rows(row).Item("LastName")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("RequestingMD") = DsPatientsForm1.Tables("Patients").Rows(row).Item("Physican")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("Comments") = DsPatientsForm1.Tables("Patients").Rows(row).Item("Comments")
        ' The collection start data currently comes from the Oxi. It may be a matter of Executive decision if the below line is to
        ' be uncommented.
        '    objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("CollectionStartDate") = DsPatientsForm1.Tables("Patients").Rows(row).Item("StartDate")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientAddress") = DsPatientsForm1.Tables("Patients").Rows(row).Item("Address")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientCity") = DsPatientsForm1.Tables("Patients").Rows(row).Item("City")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientState") = DsPatientsForm1.Tables("Patients").Rows(row).Item("State")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientZip") = DsPatientsForm1.Tables("Patients").Rows(row).Item("Zip")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgID") = DsPatientsForm1.Tables("Patients").Rows(row).Item("OrgID")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientPhone") = DsPatientsForm1.Tables("Patients").Rows(row).Item("PatientPhone")
        objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("PatientFax") = DsPatientsForm1.Tables("Patients").Rows(row).Item("PatientFax")

        daRpt.Update(objdsRpt)
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        'Important - When someone has reached here, they have double clicked the DataGrid1 row header and they
        ' want to see stored report data under a Patient Record.
        ' The Oximeter data is all stored for this patient as a binary capture of the raw data stream
        ' from the original Oximeter data collected.
        ' The functions used to rerender this data are the same ones in use allowing previewing and assigning.
        ' We then have to save the current information in binBufferInt (Oxidata streams are in here) to another
        ' buffer.
        ' We then load in the single data stream and then discover it again, just as if it had been
        ' downloaded from the oximeter. There is no difference or concept of difference in this program.
        ' But, we don't want to over write any data in progress.
        ' So, we save the current data in binBufferInt, then load in the data stored in Access for this 
        ' patient. We report on this data, then we load back in the preview data and allow
        ' the preview function to dominate.

        ' ListBox1.Items.Add("Data Grid1 got a double click")
        ' Here we pull the blob data out of the database and build the report for this patient.


        Dim x As Integer
        ' Save the data from the Oximeter, if there is any to save.
        ' We check headers and if there are headers present, we save the data.
        Dim OxiPreviewData(131070) As Integer
        Dim mustRestoreOxiData As Boolean = False
        Dim objdsPatients As dsPatients = New dsPatients()

        '    If (DataGrid1.CurrentRowIndex > 0) Then ' If currentRowIndex = 0, then operator is clicking 
        ' either the very top of the data grid, or the bottom, but not a valid patient.

        objdsPatients.Clear()
        daPatients.Fill(objdsPatients)
        Dim ReportsNum As Double = Val(objdsPatients.Tables("Patients").Rows(DataGrid1.CurrentRowIndex).Item("ReportsNumSaved"))

        If (ReportsNum > 0) Then


            If headerArray(0) > 0 Then
                mustRestoreOxiData = True

                ' We copy from the Class wide global Oxidata cache binBufferInt
                For x = 0 To 131070
                    OxiPreviewData(x) = binbufferInt(x)
                Next x
            End If

            ' We now zero out binBufferInt so that false header information is not in there.
            For x = 0 To 131070
                binbufferInt(x) = 0
            Next x

            ' Now we are free to copy data extracted from the OLE DB field rawbytes1 and fill it into here.

            Dim PictureCol As Integer = 0 ' the column # of the BLOB field

            ' Get the patient ID to build the query on where to store the BLOB data. This is the raw data from a Oximeter session.
            Dim PatientID As String = Str(objdsPatients.Tables("Patients").Rows(DataGrid1.CurrentRowIndex).Item("PatientID"))

            Dim cn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; DATA SOURCE=C:\Program Files\oxistat1dot0\OxistatAccessDB.mdb")
            Dim cmd As New OleDbCommand("SELECT rawbytes1 FROM Patients WHERE PatientID=" & PatientID, cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            dr.Read()

            Dim b(CInt(dr.GetBytes(CInt(PictureCol), CLng(0), Nothing, CInt(0), Integer.MaxValue) - 1)) As Byte
            dr.GetBytes(PictureCol, 0, b, 0, b.Length)

            dr.Close()
            cn.Close()

            'At this point, we have saved the preview or assignable Oxidata and we have variable "b"
            ' above and ready with raw Oxidata from the patient database. Let's process it and then 
            ' report on it.

            ' First, get "b" into binBufferInt
            For x = 0 To b.Length - 1
                binbufferInt(x) = CInt(b(x))
            Next x

            getheaders() ' This parses the data and loads up all the globals. We are now ready to process it.


            Dim rd As rptData


            ' Generate data for the report. This calls the formulae engine to calculate and fills in the values to
            ' the supplied structure.
            ' The Oxifile pulled from the database has been loaded into binbufferInt.
            ' As it is only one file, we always address it as "file 1".
            ' Therefore, we use 1 as the file.

            Dim file As Integer = 1

            generateReportData(file, rd)

            ' Update the Summary screen on the TAB "Data Summary".
            updateSummaryReportScreen(rd)

            ' Update the Crystal Reports report. This writes data to the Access DB. Crystal reports
            ' "reports from"  the database records written from this function call.
            updateCryReportsBody(rd)
            ' Populate the SpO2 and HR data in the Access tables. The Crystal Reports engine will
            ' open its own connection and pull the data out. I did not design Crystal Reports, and
            ' that is how it works.
            updateHRandSpO2ChartData(file)

            CryRptPatientUpdate() ' Send the patent data from the double clicked row to the Crystal Report

            '  System.Threading.Thread.CurrentThread.Sleep(400)
            'Refresh the report viewer as the report has substancially changed

            CrystalReportViewer1.RefreshReport()

            ' And, that's it. We done. 12/12/2002 1:05PM PST. Jeff Fall Esq.
            ' This program took two months and 12 days.


            ' Here, we have to take the HeaderArray(0) count of valid headers back to zero.
            ' This is because we are using this as a gating mechanism to figure out if
            ' Valid Oximeter data was ever loaded.
            ' As if we came into the function and the HeaderArray(0) count was zero, so must
            ' we exit with it zero also. This function tries to clean up and return the program
            ' to be ready to always be previewing data for assignment.

            headerArray(0) = 0

            If mustRestoreOxiData = True Then
                ' Restore the preview data back so that more patients can have data assigned to them.
                For x = 0 To 131070
                    binbufferInt(x) = OxiPreviewData(x)
                Next x
                ' Goodmemoryread means we feel that valid raw Oximeter data has been loaded into
                ' binBufferInt. It can come from anywhere- The RS232 function, stored data from
                ' an array, as here, or from the BLOB record in the patient data base as above.
                ' Confusing, huh?
                goodMemoryRead() ' This will initialize properly and get the listboxes filled.
            End If
        Else
            System.Windows.Forms.MessageBox.Show("This patient has no saved reports to display.")
        End If ' ReportsNUM > 0
        '   End If ' CurrentRowIndex > 0

    End Sub





    Private Sub TabPage3_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage3.Paint
        DsPatientsForm1.Clear()
        daPatients.Fill(DsPatientsForm1)
        '   System.Threading.Thread.CurrentThread.Sleep(400)
        'Refresh the report viewer as the report has substancially changed

        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' updateHRandSpO2ChartData()
    End Sub

    Private Sub ListBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged

        Dim rd As rptData
        Dim rawData(131070) As Byte
        Dim len As Integer

        ' Generate data for the report. This calls the formulae engine to calculate and fills in the values to
        ' the supplied structure.
        generateReportData(ListBox3.SelectedIndex + 1, rd)
        ' Update the Summary screen on the TAB form.
        updateSummaryReportScreen(rd)
        ' Update the Crystal Reports report. This writes data to the Access DB. Crystal reports
        ' "reports from"  the database records written from this function call.
        updateCryReportsBody(rd)
        ' Populate the SpO2 and HR data in the Access tables. The Crystal Reports engine will
        ' open its own connection and pull the data out. I did not design Crystal Reports, and
        ' that is how it works.
        updateHRandSpO2ChartData(ListBox3.SelectedIndex + 1)
        '  System.Threading.Thread.CurrentThread.Sleep(400)
        'Refresh the report viewer as the report has substancially changed
        CrystalReportViewer1.RefreshReport()
    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ' Here, we are trying to read a ProFox data file to help test this program.
        Dim proFoxBin(131070) As Integer
        Try
            Dim x As Integer
            Dim Result As DialogResult
            Dim diagRes As Boolean = False



            ' Zero out the array to rid of old data. Can cause false headers to be found.
            For x = 0 To 131070
                binbufferInt(x) = 0
                proFoxBin(x) = 0
            Next x


            Result = OpenFileDialog1.ShowDialog

            If Result = DialogResult.OK Then
                diagRes = True
            End If

            Dim fileName As String

            '   For Each fileName In SaveFileDialog1.FileNames()

            fileName = OpenFileDialog1.FileNames(0)
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Loaded Oxidata Text file:")
            ListBox2.Items.Add(fileName)
            ListBox2.Items.Add("into program memory. Ready to use or assign")



            Dim instream As New IO.FileStream(fileName, IO.FileMode.Open, _
              IO.FileAccess.Read)
            Dim reader As New IO.BinaryReader(instream)


            For x = 1 To 131070
                proFoxBin(x) = CInt(reader.ReadByte())
                '  ListBox2.Items.Add(Str(binbufferInt(x)))
            Next x
            reader.Close()
        Catch
        End Try

        ' The profox program starts SpO2 data at offset 300 into their .dat file and it is also
        ' offset 300 in proFoxBin
        Dim y As Integer = 300
        Dim halt As Boolean = False
        Dim proFoxEnd As Integer
        While halt = False ' 10 less then max to account for look-a-head

            If proFoxBin(y) = 0 And proFoxBin(y + 1) = 0 And proFoxBin(y + 2) = 0 And proFoxBin(y + 3) = 0 And proFoxBin(y + 4) = 0 _
            And proFoxBin(y + 5) = 0 And proFoxBin(y + 6) = 0 And proFoxBin(y + 7) = 0 And proFoxBin(y + 8) = 0 And proFoxBin(y + 9) = 0 _
            And proFoxBin(y + 10) = 0 And proFoxBin(y + 11) = 0 And proFoxBin(y + 12) = 0 And proFoxBin(y + 13) = 0 And proFoxBin(y + 14) = 0 _
            And proFoxBin(y + 15) = 0 And proFoxBin(y + 16) = 0 And proFoxBin(y + 17) = 0 And proFoxBin(y + 18) = 0 And proFoxBin(y + 19) = 0 _
                And proFoxBin(y + 20) = 0 And proFoxBin(y + 21) = 0 And proFoxBin(y + 22) = 0 And proFoxBin(y + 23) = 0 And proFoxBin(y + 24) = 0 Then

                proFoxEnd = y
                halt = True
            End If
            y += 1
        End While

        ' The header in the Oxistat 920M has bytes 0 - 30 of header and times of start, startN and stopN.
        ' We just put in whatever for now. Header must start with 254, 254, 252

        ' At bytes 30 to the end, we have triples of HR, Spo2 and a checksum of HR+SP02
        ' The end of the Respronics 920M data has 18 zeros.

        ' The program only decodes 920M data for now.

        binbufferInt(0) = 254
        binbufferInt(1) = 254
        binbufferInt(2) = 252

        binbufferInt(3) = 1 '  startFirst.month
        binbufferInt(4) = 1 ' startFirst.day
        binbufferInt(5) = binbufferInt(3) + binbufferInt(4) ' parity at offset +5

        binbufferInt(6) = 2 'startFirst.year 
        binbufferInt(7) = 1 ' startFirst.minute 
        binbufferInt(8) = binBuffer(6) + binbufferInt(7) ' parity at offset +

        binbufferInt(9) = 1 '  time.startFirst.second
        binbufferInt(10) = 1 '  time.startFirst.hour = Array(offset + 10)
        binbufferInt(11) = binbufferInt(10) + binbufferInt(9) ' parity at offset +



        binbufferInt(21) = 1 '  StartN.month
        binbufferInt(22) = 1 ' StartN.day
        binbufferInt(23) = binbufferInt(21) + binbufferInt(22) ' parity at offset +

        binbufferInt(24) = 2 'StartN.year 
        binbufferInt(25) = 0 ' StartN.minute 
        binbufferInt(26) = binBuffer(24) + binbufferInt(25) ' parity at offset +

        binbufferInt(27) = 0 '  StartnN.second
        binbufferInt(28) = 0 '  StartN.hour = Array(offset + 10)
        binbufferInt(29) = binbufferInt(27) + binbufferInt(28) ' parity at offset +

        ' For whatever reason, the ProFox data has zero's embedded in it. More than 18 zero's 
        ' is the END of DATA marker in Respronics 920M parlance. This program will stop scanning
        ' data if EOF is found. Therefore, we have to scrub the data and remove all those zeros.

        Dim g As Integer
        Dim temp(131070) As Integer
        Dim h As Integer = 1

        For g = 300 To proFoxEnd
            If proFoxBin(g) <> 0 Then
                temp(h) = proFoxBin(g)
                h += 1
            End If
        Next g

        ' Now, put the fixed up data back into profoxbin array

        For g = 1 To h
            proFoxBin(g + 299) = temp(g)
        Next g

        ' Now, zero out garbage left after the data.
        For g = h To 131070 - 299
            proFoxBin(g + 299) = 0
        Next g






        Dim z As Integer = 30
        Dim SpO2End As Integer = ((proFoxEnd - 300) \ 2) + 300
        Dim HRStart As Integer = ((proFoxEnd - 300) \ 2) + 301

        Dim runTimeInSec As Double = 0

        For y = 300 To SpO2End - 2
            binbufferInt(z) = proFoxBin(HRStart)
            HRStart += 1
            binbufferInt(z + 1) = proFoxBin(y)
            binbufferInt(z + 2) = binbufferInt(z) + binbufferInt(z + 1)
            z += 3
            runTimeInSec += 1.37
        Next y

        If runTimeInSec > 28799 Then
            runTimeInSec = 28799
        End If

        Dim runTimeHour As Integer = CInt(Int(runTimeInSec)) \ 1200
        Dim runTimeMin As Integer = (CInt(Int(runTimeInSec)) - (runTimeHour * 1200)) \ 60
        Dim runTimeSec As Integer = CInt(Int(runTimeInSec)) - (((runTimeHour * 1200) + (runTimeMin * 60)))

        binbufferInt(12) = 1 '  stopN.month
        binbufferInt(13) = 1 ' StopN.day
        binbufferInt(14) = binbufferInt(12) + binbufferInt(13) ' parity at offset +

        binbufferInt(15) = 2 'StopN.year 
        binbufferInt(16) = CInt(runTimeMin) ' StopN.minute 
        binbufferInt(17) = binBuffer(16) + binbufferInt(17) ' parity at offset +

        binbufferInt(18) = CInt(runTimeSec) '  StopN.second
        binbufferInt(19) = CInt(runTimeHour) '  StopN.hour = Array(offset + 10)
        binbufferInt(20) = binbufferInt(19) + binbufferInt(20) ' parity at offset +

        goodMemoryRead()
    End Sub
End Class