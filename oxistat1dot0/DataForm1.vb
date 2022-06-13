Public Class DataForm1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        LoadDataSet()


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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents objdsOrgForm1 As oxistat1dot0.dsOrgForm1
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblFax_Number As System.Windows.Forms.Label
    Friend WithEvents lblOrganization As System.Windows.Forms.Label
    Friend WithEvents editAddress As System.Windows.Forms.TextBox
    Friend WithEvents editFax_Number As System.Windows.Forms.TextBox
    Friend WithEvents editOrganization As System.Windows.Forms.TextBox
    Friend WithEvents lblOrgID As System.Windows.Forms.Label
    Friend WithEvents lblPhone_Number As System.Windows.Forms.Label
    Friend WithEvents editOrgID As System.Windows.Forms.TextBox
    Friend WithEvents editPhone_Number As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daRpt As System.Data.OleDb.OleDbDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.objdsOrgForm1 = New oxistat1dot0.dsOrgForm1()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblFax_Number = New System.Windows.Forms.Label()
        Me.lblOrganization = New System.Windows.Forms.Label()
        Me.editAddress = New System.Windows.Forms.TextBox()
        Me.editFax_Number = New System.Windows.Forms.TextBox()
        Me.editOrganization = New System.Windows.Forms.TextBox()
        Me.lblOrgID = New System.Windows.Forms.Label()
        Me.lblPhone_Number = New System.Windows.Forms.Label()
        Me.editOrgID = New System.Windows.Forms.TextBox()
        Me.editPhone_Number = New System.Windows.Forms.TextBox()
        Me.btnNavFirst = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.lblNavLocation = New System.Windows.Forms.Label()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.daRpt = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.objdsOrgForm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Address, [Fax Number], Organization, OrgID, OrgKey, [Phone Number], select" & _
        "ed FROM OrgTable"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program" & _
        " Files\oxistat1dot0\OxistatAccessDB.mdb;Mode=Share Deny None;Extended Properties" & _
        "="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database P" & _
        "assword="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:G" & _
        "lobal Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Data" & _
        "base Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Databa" & _
        "se=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without " & _
        "Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO OrgTable(Address, [Fax Number], Organization, OrgID, [Phone Number], " & _
        "selected) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fax_Number", System.Data.OleDb.OleDbType.VarWChar, 50, "Fax Number"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Organization", System.Data.OleDb.OleDbType.VarWChar, 0, "Organization"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone_Number", System.Data.OleDb.OleDbType.VarWChar, 0, "Phone Number"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("selected", System.Data.OleDb.OleDbType.VarWChar, 50, "selected"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE OrgTable SET Address = ?, [Fax Number] = ?, Organization = ?, OrgID = ?, [" & _
        "Phone Number] = ?, selected = ? WHERE (OrgKey = ?) AND (Address = ? OR ? IS NULL" & _
        " AND Address IS NULL) AND ([Fax Number] = ? OR ? IS NULL AND [Fax Number] IS NUL" & _
        "L) AND (OrgID = ? OR ? IS NULL AND OrgID IS NULL) AND (Organization = ? OR ? IS " & _
        "NULL AND Organization IS NULL) AND ([Phone Number] = ? OR ? IS NULL AND [Phone N" & _
        "umber] IS NULL) AND (selected = ? OR ? IS NULL AND selected IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fax_Number", System.Data.OleDb.OleDbType.VarWChar, 50, "Fax Number"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Organization", System.Data.OleDb.OleDbType.VarWChar, 0, "Organization"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone_Number", System.Data.OleDb.OleDbType.VarWChar, 0, "Phone Number"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("selected", System.Data.OleDb.OleDbType.VarWChar, 50, "selected"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrgKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax_Number", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax_Number1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Organization", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Organization", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Organization1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Organization", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone_Number", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone_Number1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_selected", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "selected", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_selected1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "selected", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM OrgTable WHERE (OrgKey = ?) AND (Address = ? OR ? IS NULL AND Address" & _
        " IS NULL) AND ([Fax Number] = ? OR ? IS NULL AND [Fax Number] IS NULL) AND (OrgI" & _
        "D = ? OR ? IS NULL AND OrgID IS NULL) AND (Organization = ? OR ? IS NULL AND Org" & _
        "anization IS NULL) AND ([Phone Number] = ? OR ? IS NULL AND [Phone Number] IS NU" & _
        "LL) AND (selected = ? OR ? IS NULL AND selected IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrgKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax_Number", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax_Number1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Organization", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Organization", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Organization1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Organization", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone_Number", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone_Number1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone Number", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_selected", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "selected", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_selected1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "selected", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdsOrgForm1
        '
        Me.objdsOrgForm1.DataSetName = "dsOrgForm1"
        Me.objdsOrgForm1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objdsOrgForm1.Namespace = "http://www.tempuri.org/dsOrgForm1.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OrgTable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrgID", "OrgID"), New System.Data.Common.DataColumnMapping("Organization", "Organization"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("Phone Number", "Phone Number"), New System.Data.Common.DataColumnMapping("Fax Number", "Fax Number"), New System.Data.Common.DataColumnMapping("selected", "selected"), New System.Data.Common.DataColumnMapping("OrgKey", "OrgKey")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(240, 280)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(104, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load saved Orgs"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(352, 32)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Save Changes"
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(16, 112)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblFax_Number
        '
        Me.lblFax_Number.Location = New System.Drawing.Point(240, 160)
        Me.lblFax_Number.Name = "lblFax_Number"
        Me.lblFax_Number.TabIndex = 3
        Me.lblFax_Number.Text = "Fax Number"
        '
        'lblOrganization
        '
        Me.lblOrganization.Location = New System.Drawing.Point(8, 80)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.TabIndex = 4
        Me.lblOrganization.Text = "Organization"
        '
        'editAddress
        '
        Me.editAddress.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.editAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsOrgForm1, "OrgTable.Address"))
        Me.editAddress.Location = New System.Drawing.Point(128, 120)
        Me.editAddress.Name = "editAddress"
        Me.editAddress.Size = New System.Drawing.Size(328, 20)
        Me.editAddress.TabIndex = 5
        Me.editAddress.Text = ""
        '
        'editFax_Number
        '
        Me.editFax_Number.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.editFax_Number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsOrgForm1, "OrgTable.Fax Number"))
        Me.editFax_Number.Location = New System.Drawing.Point(352, 152)
        Me.editFax_Number.Name = "editFax_Number"
        Me.editFax_Number.TabIndex = 6
        Me.editFax_Number.Text = ""
        '
        'editOrganization
        '
        Me.editOrganization.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.editOrganization.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsOrgForm1, "OrgTable.Organization"))
        Me.editOrganization.Location = New System.Drawing.Point(128, 80)
        Me.editOrganization.Name = "editOrganization"
        Me.editOrganization.Size = New System.Drawing.Size(112, 20)
        Me.editOrganization.TabIndex = 7
        Me.editOrganization.Text = ""
        '
        'lblOrgID
        '
        Me.lblOrgID.Location = New System.Drawing.Point(248, 80)
        Me.lblOrgID.Name = "lblOrgID"
        Me.lblOrgID.Size = New System.Drawing.Size(88, 23)
        Me.lblOrgID.TabIndex = 8
        Me.lblOrgID.Text = "OrgID"
        '
        'lblPhone_Number
        '
        Me.lblPhone_Number.Location = New System.Drawing.Point(8, 144)
        Me.lblPhone_Number.Name = "lblPhone_Number"
        Me.lblPhone_Number.TabIndex = 9
        Me.lblPhone_Number.Text = "Phone Number"
        '
        'editOrgID
        '
        Me.editOrgID.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.editOrgID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsOrgForm1, "OrgTable.OrgID"))
        Me.editOrgID.Location = New System.Drawing.Point(352, 80)
        Me.editOrgID.Name = "editOrgID"
        Me.editOrgID.TabIndex = 10
        Me.editOrgID.Text = ""
        '
        'editPhone_Number
        '
        Me.editPhone_Number.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.editPhone_Number.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsOrgForm1, "OrgTable.Phone Number"))
        Me.editPhone_Number.Location = New System.Drawing.Point(128, 152)
        Me.editPhone_Number.Name = "editPhone_Number"
        Me.editPhone_Number.TabIndex = 11
        Me.editPhone_Number.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.btnNavFirst.Location = New System.Drawing.Point(128, 216)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 12
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnNavPrev.Location = New System.Drawing.Point(184, 216)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 13
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(240, 224)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 16)
        Me.lblNavLocation.TabIndex = 14
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnNavNext.Location = New System.Drawing.Point(360, 216)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 15
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.btnLast.Location = New System.Drawing.Point(408, 216)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 16
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(128, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "&Add new Org info"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(264, 344)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(240, 248)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "&Cancel"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(64, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Step 1 ->"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(184, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Step 2 - Type in new Org information:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(288, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Step 3 ->"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(192, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Step 4 - Pick organization for Report:"
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT AnalysisData, averageHR, AverageSpO2, CollectionEndDate, CollectionStartDa" & _
        "te, Comments, CustomerID, DateOfReport, DesatIncidenceIndex, DesatLessThan3minsA" & _
        "vgTime, DesatLessThen3minsAvgTimeInMin, DesatLessThen3minsAvgTimeInSec, Desatles" & _
        "sThen3minsNum, desatOver3minCount, desatOver4minCount, desatOver4minTime, desatU" & _
        "nder1minCount, desatUnder1minTime, desatUnder2minCount, desatUnder2minTime, desa" & _
        "tUnder3minCount, desatUnder3minTime, desatUnder4minCount, desatUnder4minTime, Ex" & _
        "cludedData, highHR, HighSpO2, LongestDesatCustomDuration, LongestDesatCustomValu" & _
        "e, lowHR, LowSpO2, OrgAddress, OrgCity, OrgID, OrgName, OrgOfficeFax, OrgOfficeP" & _
        "hone, OrgState, OrgZipCode, PatientAddress, PatientCity, PatientFax, PatientFirs" & _
        "tName, PatientID, PatientLastName, PatientPhone, PatientState, PatientZip, Recor" & _
        "dedData, ReportID, RequestingMD, RptDataKey, SpO2custom, TimeSpO260, TimeSpO260P" & _
        "ercent, TimeSpO270, TimeSpO270Percent, TimeSpO280, TimeSpO280Percent, TimeSpO290" & _
        ", TimeSpO290Percent, TimeSpO2custom FROM CrystalReportsRptData"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO CrystalReportsRptData(AnalysisData, averageHR, AverageSpO2, Collectio" & _
        "nEndDate, CollectionStartDate, Comments, CustomerID, DateOfReport, DesatIncidenc" & _
        "eIndex, DesatLessThan3minsAvgTime, DesatLessThen3minsAvgTimeInMin, DesatLessThen" & _
        "3minsAvgTimeInSec, DesatlessThen3minsNum, desatOver3minCount, desatOver4minCount" & _
        ", desatOver4minTime, desatUnder1minCount, desatUnder1minTime, desatUnder2minCoun" & _
        "t, desatUnder2minTime, desatUnder3minCount, desatUnder3minTime, desatUnder4minCo" & _
        "unt, desatUnder4minTime, ExcludedData, highHR, HighSpO2, LongestDesatCustomDurat" & _
        "ion, LongestDesatCustomValue, lowHR, LowSpO2, OrgAddress, OrgCity, OrgID, OrgNam" & _
        "e, OrgOfficeFax, OrgOfficePhone, OrgState, OrgZipCode, PatientAddress, PatientCi" & _
        "ty, PatientFax, PatientFirstName, PatientID, PatientLastName, PatientPhone, Pati" & _
        "entState, PatientZip, RecordedData, ReportID, RequestingMD, SpO2custom, TimeSpO2" & _
        "60, TimeSpO260Percent, TimeSpO270, TimeSpO270Percent, TimeSpO280, TimeSpO280Perc" & _
        "ent, TimeSpO290, TimeSpO290Percent, TimeSpO2custom) VALUES (?, ?, ?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, "AnalysisData"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("averageHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "averageHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AverageSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AverageSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionEndDate"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionStartDate"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, "DateOfReport"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatLessThan3minsAvgTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInMin", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInMin", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInSec", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInSec", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatlessThen3minsNum", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatlessThen3minsNum", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatOver4minTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder1minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder1minTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder2minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder2minTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder3minTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder4minTime"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, "ExcludedData"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("highHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "highHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("HighSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HighSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomDuration", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomDuration", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomValue", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomValue", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("lowHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "lowHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LowSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LowSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgAddress"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgCity"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficeFax"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficePhone"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgState"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgZipCode"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientAddress"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientCity"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientFirstName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientLastName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientState"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientZip"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, "RecordedData"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, "RequestingMD"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpO2custom", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2custom", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260Percent"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270Percent"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280Percent"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290Percent"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO2custom"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE CrystalReportsRptData SET AnalysisData = ?, averageHR = ?, AverageSpO2 = ?" & _
        ", CollectionEndDate = ?, CollectionStartDate = ?, Comments = ?, CustomerID = ?, " & _
        "DateOfReport = ?, DesatIncidenceIndex = ?, DesatLessThan3minsAvgTime = ?, DesatL" & _
        "essThen3minsAvgTimeInMin = ?, DesatLessThen3minsAvgTimeInSec = ?, DesatlessThen3" & _
        "minsNum = ?, desatOver3minCount = ?, desatOver4minCount = ?, desatOver4minTime =" & _
        " ?, desatUnder1minCount = ?, desatUnder1minTime = ?, desatUnder2minCount = ?, de" & _
        "satUnder2minTime = ?, desatUnder3minCount = ?, desatUnder3minTime = ?, desatUnde" & _
        "r4minCount = ?, desatUnder4minTime = ?, ExcludedData = ?, highHR = ?, HighSpO2 =" & _
        " ?, LongestDesatCustomDuration = ?, LongestDesatCustomValue = ?, lowHR = ?, LowS" & _
        "pO2 = ?, OrgAddress = ?, OrgCity = ?, OrgID = ?, OrgName = ?, OrgOfficeFax = ?, " & _
        "OrgOfficePhone = ?, OrgState = ?, OrgZipCode = ?, PatientAddress = ?, PatientCit" & _
        "y = ?, PatientFax = ?, PatientFirstName = ?, PatientID = ?, PatientLastName = ?," & _
        " PatientPhone = ?, PatientState = ?, PatientZip = ?, RecordedData = ?, ReportID " & _
        "= ?, RequestingMD = ?, SpO2custom = ?, TimeSpO260 = ?, TimeSpO260Percent = ?, Ti" & _
        "meSpO270 = ?, TimeSpO270Percent = ?, TimeSpO280 = ?, TimeSpO280Percent = ?, Time" & _
        "SpO290 = ?, TimeSpO290Percent = ?, TimeSpO2custom = ? WHERE (RptDataKey = ?) AND" & _
        " (AnalysisData = ? OR ? IS NULL AND AnalysisData IS NULL) AND (CollectionEndDate" & _
        " = ? OR ? IS NULL AND CollectionEndDate IS NULL) AND (CollectionStartDate = ? OR" & _
        " ? IS NULL AND CollectionStartDate IS NULL) AND (Comments = ? OR ? IS NULL AND C" & _
        "omments IS NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (D" & _
        "ateOfReport = ? OR ? IS NULL AND DateOfReport IS NULL) AND (DesatIncidenceIndex " & _
        "= ? OR ? IS NULL AND DesatIncidenceIndex IS NULL) AND (DesatLessThan3minsAvgTime" & _
        " = ? OR ? IS NULL AND DesatLessThan3minsAvgTime IS NULL) AND (ExcludedData = ? O" & _
        "R ? IS NULL AND ExcludedData IS NULL) AND (OrgAddress = ? OR ? IS NULL AND OrgAd" & _
        "dress IS NULL) AND (OrgCity = ? OR ? IS NULL AND OrgCity IS NULL) AND (OrgID = ?" & _
        " OR ? IS NULL AND OrgID IS NULL) AND (OrgName = ? OR ? IS NULL AND OrgName IS NU" & _
        "LL) AND (OrgOfficeFax = ? OR ? IS NULL AND OrgOfficeFax IS NULL) AND (OrgOfficeP" & _
        "hone = ? OR ? IS NULL AND OrgOfficePhone IS NULL) AND (OrgState = ? OR ? IS NULL" & _
        " AND OrgState IS NULL) AND (OrgZipCode = ? OR ? IS NULL AND OrgZipCode IS NULL) " & _
        "AND (PatientAddress = ? OR ? IS NULL AND PatientAddress IS NULL) AND (PatientCit" & _
        "y = ? OR ? IS NULL AND PatientCity IS NULL) AND (PatientFax = ? OR ? IS NULL AND" & _
        " PatientFax IS NULL) AND (PatientFirstName = ? OR ? IS NULL AND PatientFirstName" & _
        " IS NULL) AND (PatientID = ? OR ? IS NULL AND PatientID IS NULL) AND (PatientLas" & _
        "tName = ? OR ? IS NULL AND PatientLastName IS NULL) AND (PatientPhone = ? OR ? I" & _
        "S NULL AND PatientPhone IS NULL) AND (PatientState = ? OR ? IS NULL AND PatientS" & _
        "tate IS NULL) AND (PatientZip = ? OR ? IS NULL AND PatientZip IS NULL) AND (Reco" & _
        "rdedData = ? OR ? IS NULL AND RecordedData IS NULL) AND (ReportID = ? OR ? IS NU" & _
        "LL AND ReportID IS NULL) AND (RequestingMD = ? OR ? IS NULL AND RequestingMD IS " & _
        "NULL) AND (TimeSpO260 = ? OR ? IS NULL AND TimeSpO260 IS NULL) AND (TimeSpO260Pe" & _
        "rcent = ? OR ? IS NULL AND TimeSpO260Percent IS NULL) AND (TimeSpO270 = ? OR ? I" & _
        "S NULL AND TimeSpO270 IS NULL) AND (TimeSpO270Percent = ? OR ? IS NULL AND TimeS" & _
        "pO270Percent IS NULL) AND (TimeSpO280 = ? OR ? IS NULL AND TimeSpO280 IS NULL) A" & _
        "ND (TimeSpO280Percent = ? OR ? IS NULL AND TimeSpO280Percent IS NULL) AND (TimeS" & _
        "pO290 = ? OR ? IS NULL AND TimeSpO290 IS NULL) AND (TimeSpO290Percent = ? OR ? I" & _
        "S NULL AND TimeSpO290Percent IS NULL) AND (TimeSpO2custom = ? OR ? IS NULL AND T" & _
        "imeSpO2custom IS NULL) AND (desatOver4minTime = ? OR ? IS NULL AND desatOver4min" & _
        "Time IS NULL) AND (desatUnder1minTime = ? OR ? IS NULL AND desatUnder1minTime IS" & _
        " NULL) AND (desatUnder2minTime = ? OR ? IS NULL AND desatUnder2minTime IS NULL) " & _
        "AND (desatUnder3minTime = ? OR ? IS NULL AND desatUnder3minTime IS NULL) AND (de" & _
        "satUnder4minTime = ? OR ? IS NULL AND desatUnder4minTime IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, "AnalysisData"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("averageHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "averageHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AverageSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "AverageSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionEndDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, "CollectionStartDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, "DateOfReport"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatLessThan3minsAvgTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInMin", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInMin", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatLessThen3minsAvgTimeInSec", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatLessThen3minsAvgTimeInSec", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatlessThen3minsNum", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DesatlessThen3minsNum", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatOver4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatOver4minTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder1minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder1minTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder2minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder2minTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder3minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder3minTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minCount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "desatUnder4minCount", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, "desatUnder4minTime"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, "ExcludedData"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("highHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "highHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("HighSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "HighSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomDuration", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomDuration", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LongestDesatCustomValue", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LongestDesatCustomValue", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("lowHR", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "lowHR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LowSpO2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "LowSpO2", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgAddress"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgCity"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, "OrgName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficeFax"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgOfficePhone"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgState"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgZipCode"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientAddress"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientCity"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientFirstName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, "PatientLastName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientState"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientZip"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, "RecordedData"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, "RequestingMD"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpO2custom", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SpO2custom", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO260Percent"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO270Percent"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO280Percent"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO290Percent"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, "TimeSpO2custom"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptDataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RptDataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2601", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2701", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2801", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2901", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM CrystalReportsRptData WHERE (RptDataKey = ?) AND (AnalysisData = ? OR" & _
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
        "Percent IS NULL) AND (TimeSpO2custom = ? OR ? IS NULL AND TimeSpO2custom IS NULL" & _
        ") AND (desatOver4minTime = ? OR ? IS NULL AND desatOver4minTime IS NULL) AND (de" & _
        "satUnder1minTime = ? OR ? IS NULL AND desatUnder1minTime IS NULL) AND (desatUnde" & _
        "r2minTime = ? OR ? IS NULL AND desatUnder2minTime IS NULL) AND (desatUnder3minTi" & _
        "me = ? OR ? IS NULL AND desatUnder3minTime IS NULL) AND (desatUnder4minTime = ? " & _
        "OR ? IS NULL AND desatUnder4minTime IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptDataKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RptDataKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionEndDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionEndDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CollectionStartDate1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CollectionStartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateOfReport1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfReport", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatLessThan3minsAvgTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatLessThan3minsAvgTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficeFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficeFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgOfficePhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgOfficePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgZipCode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgZipCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientAddress1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientAddress", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientCity1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFirstName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientLastName1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientLastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientZip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RequestingMD1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequestingMD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2601", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO260Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO260Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2701", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO270Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO270Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2801", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO280Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO280Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2901", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO290Percent1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO290Percent", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TimeSpO2custom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TimeSpO2custom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatOver4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatOver4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder1minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder1minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder2minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder2minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder3minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder3minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_desatUnder4minTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desatUnder4minTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'daRpt
        '
        Me.daRpt.DeleteCommand = Me.OleDbDeleteCommand2
        Me.daRpt.InsertCommand = Me.OleDbInsertCommand2
        Me.daRpt.SelectCommand = Me.OleDbSelectCommand2
        Me.daRpt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CrystalReportsRptData", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrgName", "OrgName"), New System.Data.Common.DataColumnMapping("OrgAddress", "OrgAddress"), New System.Data.Common.DataColumnMapping("OrgCity", "OrgCity"), New System.Data.Common.DataColumnMapping("OrgState", "OrgState"), New System.Data.Common.DataColumnMapping("OrgZipCode", "OrgZipCode"), New System.Data.Common.DataColumnMapping("OrgOfficePhone", "OrgOfficePhone"), New System.Data.Common.DataColumnMapping("OrgOfficeFax", "OrgOfficeFax"), New System.Data.Common.DataColumnMapping("DateOfReport", "DateOfReport"), New System.Data.Common.DataColumnMapping("PatientFirstName", "PatientFirstName"), New System.Data.Common.DataColumnMapping("PatientLastName", "PatientLastName"), New System.Data.Common.DataColumnMapping("PatientAddress", "PatientAddress"), New System.Data.Common.DataColumnMapping("PatientCity", "PatientCity"), New System.Data.Common.DataColumnMapping("PatientState", "PatientState"), New System.Data.Common.DataColumnMapping("PatientPhone", "PatientPhone"), New System.Data.Common.DataColumnMapping("PatientFax", "PatientFax"), New System.Data.Common.DataColumnMapping("PatientZip", "PatientZip"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("ReportID", "ReportID"), New System.Data.Common.DataColumnMapping("RecordedData", "RecordedData"), New System.Data.Common.DataColumnMapping("ExcludedData", "ExcludedData"), New System.Data.Common.DataColumnMapping("AnalysisData", "AnalysisData"), New System.Data.Common.DataColumnMapping("HighSpO2", "HighSpO2"), New System.Data.Common.DataColumnMapping("AverageSpO2", "AverageSpO2"), New System.Data.Common.DataColumnMapping("LowSpO2", "LowSpO2"), New System.Data.Common.DataColumnMapping("TimeSpO290Percent", "TimeSpO290Percent"), New System.Data.Common.DataColumnMapping("TimeSpO280Percent", "TimeSpO280Percent"), New System.Data.Common.DataColumnMapping("TimeSpO270Percent", "TimeSpO270Percent"), New System.Data.Common.DataColumnMapping("TimeSpO260Percent", "TimeSpO260Percent"), New System.Data.Common.DataColumnMapping("TimeSpO290", "TimeSpO290"), New System.Data.Common.DataColumnMapping("TimeSpO280", "TimeSpO280"), New System.Data.Common.DataColumnMapping("TimeSpO270", "TimeSpO270"), New System.Data.Common.DataColumnMapping("TimeSpO260", "TimeSpO260"), New System.Data.Common.DataColumnMapping("TimeSpO2custom", "TimeSpO2custom"), New System.Data.Common.DataColumnMapping("SpO2custom", "SpO2custom"), New System.Data.Common.DataColumnMapping("LongestDesatCustomValue", "LongestDesatCustomValue"), New System.Data.Common.DataColumnMapping("LongestDesatCustomDuration", "LongestDesatCustomDuration"), New System.Data.Common.DataColumnMapping("DesatIncidenceIndex", "DesatIncidenceIndex"), New System.Data.Common.DataColumnMapping("DesatlessThen3minsNum", "DesatlessThen3minsNum"), New System.Data.Common.DataColumnMapping("DesatLessThan3minsAvgTime", "DesatLessThan3minsAvgTime"), New System.Data.Common.DataColumnMapping("DesatLessThen3minsAvgTimeInSec", "DesatLessThen3minsAvgTimeInSec"), New System.Data.Common.DataColumnMapping("DesatLessThen3minsAvgTimeInMin", "DesatLessThen3minsAvgTimeInMin"), New System.Data.Common.DataColumnMapping("desatUnder1minCount", "desatUnder1minCount"), New System.Data.Common.DataColumnMapping("desatUnder2minCount", "desatUnder2minCount"), New System.Data.Common.DataColumnMapping("desatUnder3minCount", "desatUnder3minCount"), New System.Data.Common.DataColumnMapping("desatUnder4minCount", "desatUnder4minCount"), New System.Data.Common.DataColumnMapping("desatOver4minCount", "desatOver4minCount"), New System.Data.Common.DataColumnMapping("desatOver3minCount", "desatOver3minCount"), New System.Data.Common.DataColumnMapping("desatUnder1minTime", "desatUnder1minTime"), New System.Data.Common.DataColumnMapping("desatUnder2minTime", "desatUnder2minTime"), New System.Data.Common.DataColumnMapping("desatUnder3minTime", "desatUnder3minTime"), New System.Data.Common.DataColumnMapping("desatUnder4minTime", "desatUnder4minTime"), New System.Data.Common.DataColumnMapping("desatOver4minTime", "desatOver4minTime"), New System.Data.Common.DataColumnMapping("highHR", "highHR"), New System.Data.Common.DataColumnMapping("averageHR", "averageHR"), New System.Data.Common.DataColumnMapping("lowHR", "lowHR"), New System.Data.Common.DataColumnMapping("RptDataKey", "RptDataKey"), New System.Data.Common.DataColumnMapping("RequestingMD", "RequestingMD"), New System.Data.Common.DataColumnMapping("CollectionStartDate", "CollectionStartDate"), New System.Data.Common.DataColumnMapping("CollectionEndDate", "CollectionEndDate"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("OrgID", "OrgID")})})
        Me.daRpt.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DataForm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(568, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btnLoad, Me.btnUpdate, Me.lblAddress, Me.lblFax_Number, Me.lblOrganization, Me.editAddress, Me.editFax_Number, Me.editOrganization, Me.lblOrgID, Me.lblPhone_Number, Me.editOrgID, Me.editPhone_Number, Me.btnNavFirst, Me.btnNavPrev, Me.lblNavLocation, Me.btnNavNext, Me.btnLast, Me.btnAdd, Me.btnDelete, Me.btnCancel})
        Me.Name = "DataForm1"
        Me.Text = "DataForm1"
        CType(Me.objdsOrgForm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdsOrgForm1, "OrgTable").CancelCurrentEdit()
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdsOrgForm1, "OrgTable").Count > 0) Then
            Me.BindingContext(objdsOrgForm1, "OrgTable").RemoveAt(Me.BindingContext(objdsOrgForm1, "OrgTable").Position)
            Me.objdsOrgForm1_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdsOrgForm1, "OrgTable").EndCurrentEdit()
            Me.BindingContext(objdsOrgForm1, "OrgTable").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdsOrgForm1, "OrgTable").Position = 0
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdsOrgForm1, "OrgTable").Position = (Me.objdsOrgForm1.Tables("OrgTable").Rows.Count - 1)
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdsOrgForm1, "OrgTable").Position = (Me.BindingContext(objdsOrgForm1, "OrgTable").Position - 1)
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdsOrgForm1, "OrgTable").Position = (Me.BindingContext(objdsOrgForm1, "OrgTable").Position + 1)
        Me.objdsOrgForm1_PositionChanged()

    End Sub
    Private Sub objdsOrgForm1_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdsOrgForm1, "OrgTable").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdsOrgForm1, "OrgTable").Count.ToString)

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As oxistat1dot0.dsOrgForm1 = New oxistat1dot0.dsOrgForm1()
        'Stop any current edits.
        Me.BindingContext(objdsOrgForm1, "OrgTable").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdsOrgForm1.GetChanges, oxistat1dot0.dsOrgForm1)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdsOrgForm1.Merge(objDataSetChanges)
                objdsOrgForm1.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As oxistat1dot0.dsOrgForm1
        objDataSetTemp = New oxistat1dot0.dsOrgForm1()
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdsOrgForm1.Clear()
            'Merge the records into the main dataset.
            objdsOrgForm1.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As oxistat1dot0.dsOrgForm1)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As oxistat1dot0.dsOrgForm1)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
        Catch fillException As System.Exception
            'Add your error handling code here.
            Throw fillException
        Finally
            'Turn constraint checking back on.
            dataSet.EnforceConstraints = True
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub DataForm1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim objdsOrg As dsOrgForm1 = New dsOrgForm1()
        Dim objdsRpt As dsRpt = New dsRpt()
        '   OrgDataAdapter1.Fill(obj1OrgDataSet1)
        daRpt.Fill(objdsRpt)

        Dim pos As Integer
        pos = Me.BindingContext(objdsOrgForm1, "OrgTable").Position
        If pos > -1 Then
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgName") = objdsOrgForm1.Tables("OrgTable").Rows(pos).Item("Organization")
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgAddress") = objdsOrgForm1.Tables("OrgTable").Rows(pos).Item("Address")
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgOfficeFax") = objdsOrgForm1.Tables("OrgTable").Rows(pos).Item("Fax Number")
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgOfficePhone") = objdsOrgForm1.Tables("OrgTable").Rows(pos).Item("Phone Number")
        Else

            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgName") = "No Org. Name - Empty Database"
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgAddress") = "No Org Address - Empty Database"
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgOfficeFax") = "Empty"
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgOfficePhone") = "Empty"
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgCity") = " "
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgState") = "  "
            objdsRpt.Tables("CrystalReportsRptData").Rows(0).Item("OrgZipCode") = "  "
        End If

        daRpt.Update(objdsRpt)

        ' frmMain.CrystalReportViewer1.RefreshReport()


    End Sub
End Class
