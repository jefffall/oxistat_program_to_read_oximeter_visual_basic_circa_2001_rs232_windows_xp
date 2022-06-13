Public Class DataForm2
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Me.LoadDataSet()
        Me.objdsPatients_PositionChanged()

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
    Friend WithEvents objdsPatients As oxistat1dot0.dsPatients
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblOrgID As System.Windows.Forms.Label
    Friend WithEvents editAddress As System.Windows.Forms.TextBox
    Friend WithEvents editCity As System.Windows.Forms.TextBox
    Friend WithEvents editComments As System.Windows.Forms.TextBox
    Friend WithEvents editCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents editFirstName As System.Windows.Forms.TextBox
    Friend WithEvents editLastName As System.Windows.Forms.TextBox
    Friend WithEvents editOrgID As System.Windows.Forms.TextBox
    Friend WithEvents lblPatientFax As System.Windows.Forms.Label
    Friend WithEvents lblPatientPhone As System.Windows.Forms.Label
    Friend WithEvents lblPhysican As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents editPatientFax As System.Windows.Forms.TextBox
    Friend WithEvents editPatientPhone As System.Windows.Forms.TextBox
    Friend WithEvents editPhysican As System.Windows.Forms.TextBox
    Friend WithEvents editStartDate As System.Windows.Forms.TextBox
    Friend WithEvents editState As System.Windows.Forms.TextBox
    Friend WithEvents editZip As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.objdsPatients = New oxistat1dot0.dsPatients()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelAll = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblOrgID = New System.Windows.Forms.Label()
        Me.editAddress = New System.Windows.Forms.TextBox()
        Me.editCity = New System.Windows.Forms.TextBox()
        Me.editComments = New System.Windows.Forms.TextBox()
        Me.editCustomerID = New System.Windows.Forms.TextBox()
        Me.editFirstName = New System.Windows.Forms.TextBox()
        Me.editLastName = New System.Windows.Forms.TextBox()
        Me.editOrgID = New System.Windows.Forms.TextBox()
        Me.lblPatientFax = New System.Windows.Forms.Label()
        Me.lblPatientPhone = New System.Windows.Forms.Label()
        Me.lblPhysican = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.editPatientFax = New System.Windows.Forms.TextBox()
        Me.editPatientPhone = New System.Windows.Forms.TextBox()
        Me.editPhysican = New System.Windows.Forms.TextBox()
        Me.editStartDate = New System.Windows.Forms.TextBox()
        Me.editState = New System.Windows.Forms.TextBox()
        Me.editZip = New System.Windows.Forms.TextBox()
        Me.btnNavFirst = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.lblNavLocation = New System.Windows.Forms.Label()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.objdsPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Address, City, Comments, CustomerID, FirstName, LastName, OrgID, PatientFa" & _
        "x, PatientID, PatientPhone, Physican, ReportsNumSaved, StartDate, State, Zip FRO" & _
        "M Patients"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Patients(Address, City, Comments, CustomerID, FirstName, LastName, Or" & _
        "gID, PatientFax, PatientPhone, Physican, ReportsNumSaved, StartDate, State, Zip)" & _
        " VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 50, "CustomerID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Physican", System.Data.OleDb.OleDbType.VarWChar, 50, "Physican"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportsNumSaved"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.DBDate, 0, "StartDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 50, "State"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 50, "Zip"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Patients SET Address = ?, City = ?, Comments = ?, CustomerID = ?, FirstNam" & _
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
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 50, "CustomerID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, "OrgID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientFax"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, "PatientPhone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Physican", System.Data.OleDb.OleDbType.VarWChar, 50, "Physican"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, "ReportsNumSaved"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.DBDate, 0, "StartDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 50, "State"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 50, "Zip"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.Integer, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Patients WHERE (PatientID = ?) AND (Address = ? OR ? IS NULL AND Addr" & _
        "ess IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Comments = ? OR ?" & _
        " IS NULL AND Comments IS NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID I" & _
        "S NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ?" & _
        " OR ? IS NULL AND LastName IS NULL) AND (OrgID = ? OR ? IS NULL AND OrgID IS NUL" & _
        "L) AND (PatientFax = ? OR ? IS NULL AND PatientFax IS NULL) AND (PatientPhone = " & _
        "? OR ? IS NULL AND PatientPhone IS NULL) AND (Physican = ? OR ? IS NULL AND Phys" & _
        "ican IS NULL) AND (ReportsNumSaved = ? OR ? IS NULL AND ReportsNumSaved IS NULL)" & _
        " AND (StartDate = ? OR ? IS NULL AND StartDate IS NULL) AND (State = ? OR ? IS N" & _
        "ULL AND State IS NULL) AND (Zip = ? OR ? IS NULL AND Zip IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.Integer, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrgID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrgID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientFax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientFax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Physican1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Physican", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportsNumSaved1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportsNumSaved", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_StartDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StartDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdsPatients
        '
        Me.objdsPatients.DataSetName = "dsPatients"
        Me.objdsPatients.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objdsPatients.Namespace = "http://www.tempuri.org/dsPatients.xsd"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Patients", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Physican", "Physican"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("StartDate", "StartDate"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("State", "State"), New System.Data.Common.DataColumnMapping("Zip", "Zip"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("OrgID", "OrgID"), New System.Data.Common.DataColumnMapping("PatientPhone", "PatientPhone"), New System.Data.Common.DataColumnMapping("PatientFax", "PatientFax"), New System.Data.Common.DataColumnMapping("ReportsNumSaved", "ReportsNumSaved")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(24, 296)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(102, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load Patients"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(464, 296)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Save Changes"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(240, 256)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Size = New System.Drawing.Size(120, 23)
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All Changes"
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(8, 112)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(8, 144)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City"
        '
        'lblComments
        '
        Me.lblComments.Location = New System.Drawing.Point(8, 208)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.TabIndex = 5
        Me.lblComments.Text = "Comments"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(456, 80)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(72, 23)
        Me.lblCustomerID.TabIndex = 6
        Me.lblCustomerID.Text = "CustomerID"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(8, 80)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(232, 80)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "LastName"
        '
        'lblOrgID
        '
        Me.lblOrgID.Location = New System.Drawing.Point(520, 48)
        Me.lblOrgID.Name = "lblOrgID"
        Me.lblOrgID.Size = New System.Drawing.Size(40, 23)
        Me.lblOrgID.TabIndex = 9
        Me.lblOrgID.Text = "OrgID"
        '
        'editAddress
        '
        Me.editAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.Address"))
        Me.editAddress.Location = New System.Drawing.Point(120, 112)
        Me.editAddress.Name = "editAddress"
        Me.editAddress.Size = New System.Drawing.Size(320, 20)
        Me.editAddress.TabIndex = 10
        Me.editAddress.Text = ""
        '
        'editCity
        '
        Me.editCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.City"))
        Me.editCity.Location = New System.Drawing.Point(120, 144)
        Me.editCity.Name = "editCity"
        Me.editCity.TabIndex = 11
        Me.editCity.Text = ""
        '
        'editComments
        '
        Me.editComments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.Comments"))
        Me.editComments.Location = New System.Drawing.Point(120, 208)
        Me.editComments.Name = "editComments"
        Me.editComments.Size = New System.Drawing.Size(560, 20)
        Me.editComments.TabIndex = 12
        Me.editComments.Text = ""
        '
        'editCustomerID
        '
        Me.editCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.CustomerID"))
        Me.editCustomerID.Location = New System.Drawing.Point(568, 80)
        Me.editCustomerID.Name = "editCustomerID"
        Me.editCustomerID.TabIndex = 13
        Me.editCustomerID.Text = ""
        '
        'editFirstName
        '
        Me.editFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.FirstName"))
        Me.editFirstName.Location = New System.Drawing.Point(120, 80)
        Me.editFirstName.Name = "editFirstName"
        Me.editFirstName.TabIndex = 14
        Me.editFirstName.Text = ""
        '
        'editLastName
        '
        Me.editLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.LastName"))
        Me.editLastName.Location = New System.Drawing.Point(336, 80)
        Me.editLastName.Name = "editLastName"
        Me.editLastName.TabIndex = 15
        Me.editLastName.Text = ""
        '
        'editOrgID
        '
        Me.editOrgID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.OrgID"))
        Me.editOrgID.Location = New System.Drawing.Point(568, 48)
        Me.editOrgID.Name = "editOrgID"
        Me.editOrgID.TabIndex = 16
        Me.editOrgID.Text = ""
        '
        'lblPatientFax
        '
        Me.lblPatientFax.Location = New System.Drawing.Point(232, 176)
        Me.lblPatientFax.Name = "lblPatientFax"
        Me.lblPatientFax.TabIndex = 17
        Me.lblPatientFax.Text = "PatientFax"
        '
        'lblPatientPhone
        '
        Me.lblPatientPhone.Location = New System.Drawing.Point(8, 176)
        Me.lblPatientPhone.Name = "lblPatientPhone"
        Me.lblPatientPhone.TabIndex = 18
        Me.lblPatientPhone.Text = "PatientPhone"
        '
        'lblPhysican
        '
        Me.lblPhysican.Location = New System.Drawing.Point(8, 48)
        Me.lblPhysican.Name = "lblPhysican"
        Me.lblPhysican.TabIndex = 19
        Me.lblPhysican.Text = "Physican"
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(336, 48)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(64, 23)
        Me.lblStartDate.TabIndex = 21
        Me.lblStartDate.Text = "StartDate"
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(232, 144)
        Me.lblState.Name = "lblState"
        Me.lblState.TabIndex = 22
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.Location = New System.Drawing.Point(400, 144)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(24, 23)
        Me.lblZip.TabIndex = 23
        Me.lblZip.Text = "Zip"
        '
        'editPatientFax
        '
        Me.editPatientFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.PatientFax"))
        Me.editPatientFax.Location = New System.Drawing.Point(336, 176)
        Me.editPatientFax.Name = "editPatientFax"
        Me.editPatientFax.TabIndex = 24
        Me.editPatientFax.Text = ""
        '
        'editPatientPhone
        '
        Me.editPatientPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.PatientPhone"))
        Me.editPatientPhone.Location = New System.Drawing.Point(120, 176)
        Me.editPatientPhone.Name = "editPatientPhone"
        Me.editPatientPhone.TabIndex = 25
        Me.editPatientPhone.Text = ""
        '
        'editPhysican
        '
        Me.editPhysican.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.Physican"))
        Me.editPhysican.Location = New System.Drawing.Point(120, 48)
        Me.editPhysican.Name = "editPhysican"
        Me.editPhysican.Size = New System.Drawing.Size(192, 20)
        Me.editPhysican.TabIndex = 26
        Me.editPhysican.Text = ""
        '
        'editStartDate
        '
        Me.editStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.StartDate"))
        Me.editStartDate.Location = New System.Drawing.Point(400, 48)
        Me.editStartDate.Name = "editStartDate"
        Me.editStartDate.Size = New System.Drawing.Size(104, 20)
        Me.editStartDate.TabIndex = 28
        Me.editStartDate.Text = ""
        '
        'editState
        '
        Me.editState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.State"))
        Me.editState.Location = New System.Drawing.Point(336, 144)
        Me.editState.Name = "editState"
        Me.editState.Size = New System.Drawing.Size(40, 20)
        Me.editState.TabIndex = 29
        Me.editState.Text = ""
        '
        'editZip
        '
        Me.editZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPatients, "Patients.Zip"))
        Me.editZip.Location = New System.Drawing.Point(440, 144)
        Me.editZip.Name = "editZip"
        Me.editZip.Size = New System.Drawing.Size(88, 20)
        Me.editZip.TabIndex = 30
        Me.editZip.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(168, 296)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 31
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(208, 296)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 32
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(240, 296)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(112, 23)
        Me.lblNavLocation.TabIndex = 33
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(352, 296)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 34
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(384, 296)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 35
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(168, 336)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "&Add Patient"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(256, 336)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 23)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "&Delete Patient"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(352, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "&Cancel"
        '
        'DataForm2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(704, 381)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnLoad, Me.btnUpdate, Me.btnCancelAll, Me.lblAddress, Me.lblCity, Me.lblComments, Me.lblCustomerID, Me.lblFirstName, Me.lblLastName, Me.lblOrgID, Me.editAddress, Me.editCity, Me.editComments, Me.editCustomerID, Me.editFirstName, Me.editLastName, Me.editOrgID, Me.lblPatientFax, Me.lblPatientPhone, Me.lblPhysican, Me.lblStartDate, Me.lblState, Me.lblZip, Me.editPatientFax, Me.editPatientPhone, Me.editPhysican, Me.editStartDate, Me.editState, Me.editZip, Me.btnNavFirst, Me.btnNavPrev, Me.lblNavLocation, Me.btnNavNext, Me.btnLast, Me.btnAdd, Me.btnDelete, Me.btnCancel})
        Me.Name = "DataForm2"
        Me.Text = "DataForm2"
        CType(Me.objdsPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdsPatients, "Patients").CancelCurrentEdit()
        Me.objdsPatients_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdsPatients, "Patients").Count > 0) Then
            Me.BindingContext(objdsPatients, "Patients").RemoveAt(Me.BindingContext(objdsPatients, "Patients").Position)
            Me.objdsPatients_PositionChanged()
        End If
       
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdsPatients, "Patients").EndCurrentEdit()
            Me.BindingContext(objdsPatients, "Patients").AddNew()

        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdsPatients_PositionChanged()



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
        Me.objdsPatients_PositionChanged()

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
        Me.objdsPatients_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdsPatients, "Patients").Position = 0
        Me.objdsPatients_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdsPatients, "Patients").Position = (Me.objdsPatients.Tables("Patients").Rows.Count - 1)
        Me.objdsPatients_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdsPatients, "Patients").Position = (Me.BindingContext(objdsPatients, "Patients").Position - 1)
        Me.objdsPatients_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdsPatients, "Patients").Position = (Me.BindingContext(objdsPatients, "Patients").Position + 1)
        Me.objdsPatients_PositionChanged()

    End Sub
    Private Sub objdsPatients_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdsPatients, "Patients").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdsPatients, "Patients").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdsPatients.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As oxistat1dot0.dsPatients = New oxistat1dot0.dsPatients()
        'Stop any current edits.
        Me.BindingContext(objdsPatients, "Patients").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdsPatients.GetChanges, oxistat1dot0.dsPatients)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdsPatients.Merge(objDataSetChanges)
                objdsPatients.AcceptChanges()
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
        Dim objDataSetTemp As oxistat1dot0.dsPatients
        objDataSetTemp = New oxistat1dot0.dsPatients()
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdsPatients.Clear()
            'Merge the records into the main dataset.
            objdsPatients.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As oxistat1dot0.dsPatients)
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
    Public Sub FillDataSet(ByVal dataSet As oxistat1dot0.dsPatients)
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

    Private Sub editStartDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editStartDate.TextChanged

    End Sub


    Private Sub DataForm2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.UpdateDataSet() ' Always update in case the operator makes changes and forgets. If 
        ' the "save patients" button is not pressed and new patient is entered, the latter FILL or UPDATE may
        ' incur a "concurrency" exception.
        Me.objdsPatients_PositionChanged()


        System.Threading.Thread.CurrentThread.Sleep(200)

        Dim rowsNum As Integer
        rowsNum = OleDbDataAdapter1.Fill(objdsPatients)
        ' The add method always adds the new record to the end of the dataset.
        ' Here, we want to test if the number of reports is system.dbnull. If it is, we 
        ' set it to "0" to allow incrementing as dbnull will fail a conversion to type integer.

        If IsDBNull(objdsPatients.Tables("Patients").Rows(rowsNum - 1).Item("ReportsNumSaved")) Then
            objdsPatients.Tables("Patients").Rows(rowsNum - 1).Item("ReportsNumSaved") = "0"
        End If

        OleDbDataAdapter1.Update(objdsPatients)

        '  Me.UpdateDataSet()
        '  ChangedRows.Tables("Patients").Rows(Me.BindingContext(ChangedRows, "Patients").Position()).Item("ReportsNumSaved") = "&"
        '    Dim objfrmMain As frmMain = New frmMain()
        '   Dim objdsPatientsForm1 As dsPatientsForm1 = New dsPatientsForm1()
        '   objfrmMain.daPatients.Fill(objdsPatientsForm1)
        System.Threading.Thread.CurrentThread.Sleep(200)
    End Sub
End Class
