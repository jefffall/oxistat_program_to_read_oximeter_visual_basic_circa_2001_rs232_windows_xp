Public Class DataForm3
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents objds2PatientsReports As oxistat1dot0.ds2PatientsReports
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapter4 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents grdPatients As System.Windows.Forms.DataGrid
    Friend WithEvents objTableStylegrdPatientsPatients As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents objColumnStylegrdPatientsAddress As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsCity As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsComments As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsCustomerID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsFirstName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsLastName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsOrgID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsPatientFax As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsPatientPhone As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsPhysican As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsReportsNumSaved As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsStartDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsState As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdPatientsZip As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grdReportsPointer As System.Windows.Forms.DataGrid
    Friend WithEvents objTableStylegrdReportsPointerReportsPointer As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents objColumnStylegrdReportsPointerReport As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents objColumnStylegrdReportsPointerReportID As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.objds2PatientsReports = New oxistat1dot0.ds2PatientsReports()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDataAdapter4 = New System.Data.OleDb.OleDbDataAdapter()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelAll = New System.Windows.Forms.Button()
        Me.grdPatients = New System.Windows.Forms.DataGrid()
        Me.objTableStylegrdPatientsPatients = New System.Windows.Forms.DataGridTableStyle()
        Me.objColumnStylegrdPatientsAddress = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsCity = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsComments = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsCustomerID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsFirstName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsLastName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsOrgID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsPatientFax = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsPatientPhone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsPhysican = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsReportsNumSaved = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsStartDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsState = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdPatientsZip = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grdReportsPointer = New System.Windows.Forms.DataGrid()
        Me.objTableStylegrdReportsPointerReportsPointer = New System.Windows.Forms.DataGridTableStyle()
        Me.objColumnStylegrdReportsPointerReport = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.objColumnStylegrdReportsPointerReportID = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.objds2PatientsReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdReportsPointer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Address, City, Comments, CustomerID, FirstName, LastName, OrgID, PatientFa" & _
        "x, PatientID, PatientPhone, Physican, ReportsNumSaved, StartDate, State, Zip FRO" & _
        "M Patients"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
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
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerID"))
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
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
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
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT PatientID, Report, ReportID FROM ReportsPointer"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO ReportsPointer(PatientID, ReportID) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE ReportsPointer SET PatientID = ?, ReportID = ? WHERE (Report = ?)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ReportID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Report", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Report", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM ReportsPointer WHERE (Report = ?)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Report", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Report", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT AnalysisData, AverageSPO2, Comments, DesatBelowCustom, DesatIncidenceIndex" & _
        ", DesatOver3, DesatUnder1, DesatUnder2, DesatUnder3, ExcludedData, HighSPO2, HRA" & _
        "verage, HRHigh, HRLow, LowSPO2, RawDataID, RecordedData, Report, ReportDate, Rep" & _
        "ortKey, RptEndTime, RptStartTime, SPO2Below60, SPO2Below70, SPO2Below80, SPO2Bel" & _
        "ow90, SPO2BelowCustom FROM reports"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO reports(AnalysisData, AverageSPO2, Comments, DesatBelowCustom, DesatI" & _
        "ncidenceIndex, DesatOver3, DesatUnder1, DesatUnder2, DesatUnder3, ExcludedData, " & _
        "HighSPO2, HRAverage, HRHigh, HRLow, LowSPO2, RecordedData, Report, ReportDate, R" & _
        "eportKey, RptEndTime, RptStartTime, SPO2Below60, SPO2Below70, SPO2Below80, SPO2B" & _
        "elow90, SPO2BelowCustom) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnalysisData", System.Data.OleDb.OleDbType.DBDate, 0, "AnalysisData"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AverageSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "AverageSPO2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatBelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatBelowCustom"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatIncidenceIndex", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatIncidenceIndex"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatOver3", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatOver3"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatUnder1", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatUnder1"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatUnder2", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatUnder2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatUnder3", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatUnder3"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedData", System.Data.OleDb.OleDbType.DBDate, 0, "ExcludedData"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HighSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "HighSPO2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HRAverage", System.Data.OleDb.OleDbType.VarWChar, 50, "HRAverage"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HRHigh", System.Data.OleDb.OleDbType.VarWChar, 50, "HRHigh"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HRLow", System.Data.OleDb.OleDbType.VarWChar, 50, "HRLow"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LowSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "LowSPO2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("RecordedData", System.Data.OleDb.OleDbType.DBDate, 0, "RecordedData"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Report", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Report", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportDate", System.Data.OleDb.OleDbType.DBDate, 0, "ReportDate"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ReportKey", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("RptEndTime", System.Data.OleDb.OleDbType.DBDate, 0, "RptEndTime"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("RptStartTime", System.Data.OleDb.OleDbType.DBDate, 0, "RptStartTime"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below60", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below60"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below70", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below70"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below80", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below80"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below90", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below90"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2BelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2BelowCustom"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE reports SET AnalysisData = ?, AverageSPO2 = ?, Comments = ?, DesatBelowCus" & _
        "tom = ?, DesatIncidenceIndex = ?, DesatOver3 = ?, DesatUnder1 = ?, DesatUnder2 =" & _
        " ?, DesatUnder3 = ?, ExcludedData = ?, HighSPO2 = ?, HRAverage = ?, HRHigh = ?, " & _
        "HRLow = ?, LowSPO2 = ?, RecordedData = ?, Report = ?, ReportDate = ?, ReportKey " & _
        "= ?, RptEndTime = ?, RptStartTime = ?, SPO2Below60 = ?, SPO2Below70 = ?, SPO2Bel" & _
        "ow80 = ?, SPO2Below90 = ?, SPO2BelowCustom = ? WHERE (RawDataID = ?) AND (Analys" & _
        "isData = ? OR ? IS NULL AND AnalysisData IS NULL) AND (AverageSPO2 = ? OR ? IS N" & _
        "ULL AND AverageSPO2 IS NULL) AND (Comments = ? OR ? IS NULL AND Comments IS NULL" & _
        ") AND (DesatBelowCustom = ? OR ? IS NULL AND DesatBelowCustom IS NULL) AND (Desa" & _
        "tIncidenceIndex = ? OR ? IS NULL AND DesatIncidenceIndex IS NULL) AND (DesatOver" & _
        "3 = ? OR ? IS NULL AND DesatOver3 IS NULL) AND (DesatUnder1 = ? OR ? IS NULL AND" & _
        " DesatUnder1 IS NULL) AND (DesatUnder2 = ? OR ? IS NULL AND DesatUnder2 IS NULL)" & _
        " AND (DesatUnder3 = ? OR ? IS NULL AND DesatUnder3 IS NULL) AND (ExcludedData = " & _
        "? OR ? IS NULL AND ExcludedData IS NULL) AND (HRAverage = ? OR ? IS NULL AND HRA" & _
        "verage IS NULL) AND (HRHigh = ? OR ? IS NULL AND HRHigh IS NULL) AND (HRLow = ? " & _
        "OR ? IS NULL AND HRLow IS NULL) AND (HighSPO2 = ? OR ? IS NULL AND HighSPO2 IS N" & _
        "ULL) AND (LowSPO2 = ? OR ? IS NULL AND LowSPO2 IS NULL) AND (RecordedData = ? OR" & _
        " ? IS NULL AND RecordedData IS NULL) AND (ReportDate = ? OR ? IS NULL AND Report" & _
        "Date IS NULL) AND (RptEndTime = ? OR ? IS NULL AND RptEndTime IS NULL) AND (RptS" & _
        "tartTime = ? OR ? IS NULL AND RptStartTime IS NULL) AND (SPO2Below60 = ? OR ? IS" & _
        " NULL AND SPO2Below60 IS NULL) AND (SPO2Below70 = ? OR ? IS NULL AND SPO2Below70" & _
        " IS NULL) AND (SPO2Below80 = ? OR ? IS NULL AND SPO2Below80 IS NULL) AND (SPO2Be" & _
        "low90 = ? OR ? IS NULL AND SPO2Below90 IS NULL) AND (SPO2BelowCustom = ? OR ? IS" & _
        " NULL AND SPO2BelowCustom IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AnalysisData", System.Data.OleDb.OleDbType.DBDate, 0, "AnalysisData"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AverageSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "AverageSPO2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Comments", System.Data.OleDb.OleDbType.VarWChar, 0, "Comments"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatBelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatBelowCustom"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatIncidenceIndex", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatIncidenceIndex"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatOver3", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatOver3"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatUnder1", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatUnder1"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatUnder2", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatUnder2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DesatUnder3", System.Data.OleDb.OleDbType.VarWChar, 50, "DesatUnder3"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ExcludedData", System.Data.OleDb.OleDbType.DBDate, 0, "ExcludedData"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HighSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "HighSPO2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HRAverage", System.Data.OleDb.OleDbType.VarWChar, 50, "HRAverage"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HRHigh", System.Data.OleDb.OleDbType.VarWChar, 50, "HRHigh"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("HRLow", System.Data.OleDb.OleDbType.VarWChar, 50, "HRLow"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LowSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "LowSPO2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("RecordedData", System.Data.OleDb.OleDbType.DBDate, 0, "RecordedData"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Report", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "Report", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportDate", System.Data.OleDb.OleDbType.DBDate, 0, "ReportDate"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReportKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ReportKey", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("RptEndTime", System.Data.OleDb.OleDbType.DBDate, 0, "RptEndTime"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("RptStartTime", System.Data.OleDb.OleDbType.DBDate, 0, "RptStartTime"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below60", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below60"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below70", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below70"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below80", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below80"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2Below90", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2Below90"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2BelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2BelowCustom"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RawDataID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RawDataID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AverageSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AverageSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AverageSPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AverageSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatBelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatBelowCustom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatBelowCustom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatBelowCustom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatOver3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatOver3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatOver31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatOver3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRAverage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRAverage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRAverage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRAverage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRHigh", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRHigh", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRHigh1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRHigh", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRLow", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRLow", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRLow1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRLow", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HighSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HighSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HighSPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HighSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LowSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LowSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LowSPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LowSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptEndTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptEndTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptEndTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptEndTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptStartTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptStartTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptStartTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptStartTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below60", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below60", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below601", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below60", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below70", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below70", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below701", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below70", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below80", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below80", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below801", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below80", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below90", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below90", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below901", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below90", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2BelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2BelowCustom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2BelowCustom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2BelowCustom", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM reports WHERE (RawDataID = ?) AND (AnalysisData = ? OR ? IS NULL AND " & _
        "AnalysisData IS NULL) AND (AverageSPO2 = ? OR ? IS NULL AND AverageSPO2 IS NULL)" & _
        " AND (Comments = ? OR ? IS NULL AND Comments IS NULL) AND (DesatBelowCustom = ? " & _
        "OR ? IS NULL AND DesatBelowCustom IS NULL) AND (DesatIncidenceIndex = ? OR ? IS " & _
        "NULL AND DesatIncidenceIndex IS NULL) AND (DesatOver3 = ? OR ? IS NULL AND Desat" & _
        "Over3 IS NULL) AND (DesatUnder1 = ? OR ? IS NULL AND DesatUnder1 IS NULL) AND (D" & _
        "esatUnder2 = ? OR ? IS NULL AND DesatUnder2 IS NULL) AND (DesatUnder3 = ? OR ? I" & _
        "S NULL AND DesatUnder3 IS NULL) AND (ExcludedData = ? OR ? IS NULL AND ExcludedD" & _
        "ata IS NULL) AND (HRAverage = ? OR ? IS NULL AND HRAverage IS NULL) AND (HRHigh " & _
        "= ? OR ? IS NULL AND HRHigh IS NULL) AND (HRLow = ? OR ? IS NULL AND HRLow IS NU" & _
        "LL) AND (HighSPO2 = ? OR ? IS NULL AND HighSPO2 IS NULL) AND (LowSPO2 = ? OR ? I" & _
        "S NULL AND LowSPO2 IS NULL) AND (RecordedData = ? OR ? IS NULL AND RecordedData " & _
        "IS NULL) AND (ReportDate = ? OR ? IS NULL AND ReportDate IS NULL) AND (RptEndTim" & _
        "e = ? OR ? IS NULL AND RptEndTime IS NULL) AND (RptStartTime = ? OR ? IS NULL AN" & _
        "D RptStartTime IS NULL) AND (SPO2Below60 = ? OR ? IS NULL AND SPO2Below60 IS NUL" & _
        "L) AND (SPO2Below70 = ? OR ? IS NULL AND SPO2Below70 IS NULL) AND (SPO2Below80 =" & _
        " ? OR ? IS NULL AND SPO2Below80 IS NULL) AND (SPO2Below90 = ? OR ? IS NULL AND S" & _
        "PO2Below90 IS NULL) AND (SPO2BelowCustom = ? OR ? IS NULL AND SPO2BelowCustom IS" & _
        " NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RawDataID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RawDataID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AnalysisData1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnalysisData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AverageSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AverageSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AverageSPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AverageSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Comments1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatBelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatBelowCustom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatBelowCustom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatBelowCustom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatIncidenceIndex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatIncidenceIndex", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatOver3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatOver3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatOver31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatOver3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DesatUnder31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DesatUnder3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ExcludedData1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExcludedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRAverage", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRAverage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRAverage1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRAverage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRHigh", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRHigh", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRHigh1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRHigh", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRLow", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRLow", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HRLow1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HRLow", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HighSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HighSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HighSPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HighSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LowSPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LowSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LowSPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LowSPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RecordedData1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordedData", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReportDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReportDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptEndTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptEndTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptEndTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptEndTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptStartTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptStartTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RptStartTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RptStartTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below60", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below60", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below601", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below60", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below70", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below70", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below701", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below70", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below80", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below80", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below801", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below80", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below90", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below90", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2Below901", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2Below90", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2BelowCustom", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2BelowCustom", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2BelowCustom1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2BelowCustom", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT DataID, HR, RawDataID, SampleTime, SPO2 FROM rawdata"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO rawdata(HR, RawDataID, SampleTime, SPO2) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("HR", System.Data.OleDb.OleDbType.VarWChar, 50, "HR"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("RawDataID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RawDataID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SampleTime"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2"))
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE rawdata SET HR = ?, RawDataID = ?, SampleTime = ?, SPO2 = ? WHERE (DataID " & _
        "= ?) AND (HR = ? OR ? IS NULL AND HR IS NULL) AND (SPO2 = ? OR ? IS NULL AND SPO" & _
        "2 IS NULL) AND (SampleTime = ? OR ? IS NULL AND SampleTime IS NULL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("HR", System.Data.OleDb.OleDbType.VarWChar, 50, "HR"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("RawDataID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "RawDataID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, "SampleTime"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SPO2", System.Data.OleDb.OleDbType.VarWChar, 50, "SPO2"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DataID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DataID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HR", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HR1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM rawdata WHERE (DataID = ?) AND (HR = ? OR ? IS NULL AND HR IS NULL) A" & _
        "ND (SPO2 = ? OR ? IS NULL AND SPO2 IS NULL) AND (SampleTime = ? OR ? IS NULL AND" & _
        " SampleTime IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DataID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "DataID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HR", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HR1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SPO21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SPO2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SampleTime1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SampleTime", System.Data.DataRowVersion.Original, Nothing))
        '
        'objds2PatientsReports
        '
        Me.objds2PatientsReports.DataSetName = "ds2PatientsReports"
        Me.objds2PatientsReports.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objds2PatientsReports.Namespace = "http://www.tempuri.org/ds2PatientsReports.xsd"
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
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Patients", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Physican", "Physican"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("StartDate", "StartDate"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("State", "State"), New System.Data.Common.DataColumnMapping("Zip", "Zip"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("OrgID", "OrgID"), New System.Data.Common.DataColumnMapping("PatientPhone", "PatientPhone"), New System.Data.Common.DataColumnMapping("PatientFax", "PatientFax"), New System.Data.Common.DataColumnMapping("ReportsNumSaved", "ReportsNumSaved")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ReportsPointer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("ReportID", "ReportID"), New System.Data.Common.DataColumnMapping("Report", "Report")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "reports", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Report", "Report"), New System.Data.Common.DataColumnMapping("ReportDate", "ReportDate"), New System.Data.Common.DataColumnMapping("RptStartTime", "RptStartTime"), New System.Data.Common.DataColumnMapping("RptEndTime", "RptEndTime"), New System.Data.Common.DataColumnMapping("Comments", "Comments"), New System.Data.Common.DataColumnMapping("RecordedData", "RecordedData"), New System.Data.Common.DataColumnMapping("ExcludedData", "ExcludedData"), New System.Data.Common.DataColumnMapping("AnalysisData", "AnalysisData"), New System.Data.Common.DataColumnMapping("HighSPO2", "HighSPO2"), New System.Data.Common.DataColumnMapping("AverageSPO2", "AverageSPO2"), New System.Data.Common.DataColumnMapping("LowSPO2", "LowSPO2"), New System.Data.Common.DataColumnMapping("SPO2Below90", "SPO2Below90"), New System.Data.Common.DataColumnMapping("SPO2Below80", "SPO2Below80"), New System.Data.Common.DataColumnMapping("SPO2Below70", "SPO2Below70"), New System.Data.Common.DataColumnMapping("SPO2Below60", "SPO2Below60"), New System.Data.Common.DataColumnMapping("SPO2BelowCustom", "SPO2BelowCustom"), New System.Data.Common.DataColumnMapping("DesatBelowCustom", "DesatBelowCustom"), New System.Data.Common.DataColumnMapping("DesatUnder3", "DesatUnder3"), New System.Data.Common.DataColumnMapping("DesatUnder2", "DesatUnder2"), New System.Data.Common.DataColumnMapping("DesatUnder1", "DesatUnder1"), New System.Data.Common.DataColumnMapping("DesatOver3", "DesatOver3"), New System.Data.Common.DataColumnMapping("DesatIncidenceIndex", "DesatIncidenceIndex"), New System.Data.Common.DataColumnMapping("HRHigh", "HRHigh"), New System.Data.Common.DataColumnMapping("HRAverage", "HRAverage"), New System.Data.Common.DataColumnMapping("HRLow", "HRLow"), New System.Data.Common.DataColumnMapping("ReportKey", "ReportKey"), New System.Data.Common.DataColumnMapping("RawDataID", "RawDataID")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDataAdapter4
        '
        Me.OleDbDataAdapter4.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDbDataAdapter4.InsertCommand = Me.OleDbInsertCommand4
        Me.OleDbDataAdapter4.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDbDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "rawdata", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DataID", "DataID"), New System.Data.Common.DataColumnMapping("SPO2", "SPO2"), New System.Data.Common.DataColumnMapping("HR", "HR"), New System.Data.Common.DataColumnMapping("SampleTime", "SampleTime"), New System.Data.Common.DataColumnMapping("RawDataID", "RawDataID")})})
        Me.OleDbDataAdapter4.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(315, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(315, 43)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        '
        'grdPatients
        '
        Me.grdPatients.AllowNavigation = False
        Me.grdPatients.DataMember = "Patients"
        Me.grdPatients.DataSource = Me.objds2PatientsReports
        Me.grdPatients.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPatients.Location = New System.Drawing.Point(10, 76)
        Me.grdPatients.Name = "grdPatients"
        Me.grdPatients.Size = New System.Drawing.Size(380, 250)
        Me.grdPatients.TabIndex = 3
        Me.grdPatients.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.objTableStylegrdPatientsPatients})
        '
        'objTableStylegrdPatientsPatients
        '
        Me.objTableStylegrdPatientsPatients.DataGrid = Me.grdPatients
        Me.objTableStylegrdPatientsPatients.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.objColumnStylegrdPatientsAddress, Me.objColumnStylegrdPatientsCity, Me.objColumnStylegrdPatientsComments, Me.objColumnStylegrdPatientsCustomerID, Me.objColumnStylegrdPatientsFirstName, Me.objColumnStylegrdPatientsLastName, Me.objColumnStylegrdPatientsOrgID, Me.objColumnStylegrdPatientsPatientFax, Me.objColumnStylegrdPatientsPatientPhone, Me.objColumnStylegrdPatientsPhysican, Me.objColumnStylegrdPatientsReportsNumSaved, Me.objColumnStylegrdPatientsStartDate, Me.objColumnStylegrdPatientsState, Me.objColumnStylegrdPatientsZip})
        Me.objTableStylegrdPatientsPatients.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.objTableStylegrdPatientsPatients.MappingName = "Patients"
        '
        'objColumnStylegrdPatientsAddress
        '
        Me.objColumnStylegrdPatientsAddress.Format = ""
        Me.objColumnStylegrdPatientsAddress.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsAddress.HeaderText = "Address"
        Me.objColumnStylegrdPatientsAddress.MappingName = "Address"
        Me.objColumnStylegrdPatientsAddress.Width = 75
        '
        'objColumnStylegrdPatientsCity
        '
        Me.objColumnStylegrdPatientsCity.Format = ""
        Me.objColumnStylegrdPatientsCity.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsCity.HeaderText = "City"
        Me.objColumnStylegrdPatientsCity.MappingName = "City"
        Me.objColumnStylegrdPatientsCity.Width = 75
        '
        'objColumnStylegrdPatientsComments
        '
        Me.objColumnStylegrdPatientsComments.Format = ""
        Me.objColumnStylegrdPatientsComments.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsComments.HeaderText = "Comments"
        Me.objColumnStylegrdPatientsComments.MappingName = "Comments"
        Me.objColumnStylegrdPatientsComments.Width = 75
        '
        'objColumnStylegrdPatientsCustomerID
        '
        Me.objColumnStylegrdPatientsCustomerID.Format = ""
        Me.objColumnStylegrdPatientsCustomerID.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsCustomerID.HeaderText = "CustomerID"
        Me.objColumnStylegrdPatientsCustomerID.MappingName = "CustomerID"
        Me.objColumnStylegrdPatientsCustomerID.Width = 75
        '
        'objColumnStylegrdPatientsFirstName
        '
        Me.objColumnStylegrdPatientsFirstName.Format = ""
        Me.objColumnStylegrdPatientsFirstName.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsFirstName.HeaderText = "FirstName"
        Me.objColumnStylegrdPatientsFirstName.MappingName = "FirstName"
        Me.objColumnStylegrdPatientsFirstName.Width = 75
        '
        'objColumnStylegrdPatientsLastName
        '
        Me.objColumnStylegrdPatientsLastName.Format = ""
        Me.objColumnStylegrdPatientsLastName.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsLastName.HeaderText = "LastName"
        Me.objColumnStylegrdPatientsLastName.MappingName = "LastName"
        Me.objColumnStylegrdPatientsLastName.Width = 75
        '
        'objColumnStylegrdPatientsOrgID
        '
        Me.objColumnStylegrdPatientsOrgID.Format = ""
        Me.objColumnStylegrdPatientsOrgID.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsOrgID.HeaderText = "OrgID"
        Me.objColumnStylegrdPatientsOrgID.MappingName = "OrgID"
        Me.objColumnStylegrdPatientsOrgID.Width = 75
        '
        'objColumnStylegrdPatientsPatientFax
        '
        Me.objColumnStylegrdPatientsPatientFax.Format = ""
        Me.objColumnStylegrdPatientsPatientFax.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsPatientFax.HeaderText = "PatientFax"
        Me.objColumnStylegrdPatientsPatientFax.MappingName = "PatientFax"
        Me.objColumnStylegrdPatientsPatientFax.Width = 75
        '
        'objColumnStylegrdPatientsPatientPhone
        '
        Me.objColumnStylegrdPatientsPatientPhone.Format = ""
        Me.objColumnStylegrdPatientsPatientPhone.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsPatientPhone.HeaderText = "PatientPhone"
        Me.objColumnStylegrdPatientsPatientPhone.MappingName = "PatientPhone"
        Me.objColumnStylegrdPatientsPatientPhone.Width = 75
        '
        'objColumnStylegrdPatientsPhysican
        '
        Me.objColumnStylegrdPatientsPhysican.Format = ""
        Me.objColumnStylegrdPatientsPhysican.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsPhysican.HeaderText = "Physican"
        Me.objColumnStylegrdPatientsPhysican.MappingName = "Physican"
        Me.objColumnStylegrdPatientsPhysican.Width = 75
        '
        'objColumnStylegrdPatientsReportsNumSaved
        '
        Me.objColumnStylegrdPatientsReportsNumSaved.Format = ""
        Me.objColumnStylegrdPatientsReportsNumSaved.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsReportsNumSaved.HeaderText = "ReportsNumSaved"
        Me.objColumnStylegrdPatientsReportsNumSaved.MappingName = "ReportsNumSaved"
        Me.objColumnStylegrdPatientsReportsNumSaved.Width = 75
        '
        'objColumnStylegrdPatientsStartDate
        '
        Me.objColumnStylegrdPatientsStartDate.Format = ""
        Me.objColumnStylegrdPatientsStartDate.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsStartDate.HeaderText = "StartDate"
        Me.objColumnStylegrdPatientsStartDate.MappingName = "StartDate"
        Me.objColumnStylegrdPatientsStartDate.Width = 75
        '
        'objColumnStylegrdPatientsState
        '
        Me.objColumnStylegrdPatientsState.Format = ""
        Me.objColumnStylegrdPatientsState.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsState.HeaderText = "State"
        Me.objColumnStylegrdPatientsState.MappingName = "State"
        Me.objColumnStylegrdPatientsState.Width = 75
        '
        'objColumnStylegrdPatientsZip
        '
        Me.objColumnStylegrdPatientsZip.Format = ""
        Me.objColumnStylegrdPatientsZip.FormatInfo = Nothing
        Me.objColumnStylegrdPatientsZip.HeaderText = "Zip"
        Me.objColumnStylegrdPatientsZip.MappingName = "Zip"
        Me.objColumnStylegrdPatientsZip.Width = 75
        '
        'grdReportsPointer
        '
        Me.grdReportsPointer.AllowNavigation = False
        Me.grdReportsPointer.DataMember = "Patients.PatientToReports"
        Me.grdReportsPointer.DataSource = Me.objds2PatientsReports
        Me.grdReportsPointer.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdReportsPointer.Location = New System.Drawing.Point(10, 336)
        Me.grdReportsPointer.Name = "grdReportsPointer"
        Me.grdReportsPointer.Size = New System.Drawing.Size(380, 292)
        Me.grdReportsPointer.TabIndex = 4
        Me.grdReportsPointer.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.objTableStylegrdReportsPointerReportsPointer})
        '
        'objTableStylegrdReportsPointerReportsPointer
        '
        Me.objTableStylegrdReportsPointerReportsPointer.DataGrid = Me.grdReportsPointer
        Me.objTableStylegrdReportsPointerReportsPointer.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.objColumnStylegrdReportsPointerReport, Me.objColumnStylegrdReportsPointerReportID})
        Me.objTableStylegrdReportsPointerReportsPointer.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.objTableStylegrdReportsPointerReportsPointer.MappingName = "ReportsPointer"
        '
        'objColumnStylegrdReportsPointerReport
        '
        Me.objColumnStylegrdReportsPointerReport.Format = ""
        Me.objColumnStylegrdReportsPointerReport.FormatInfo = Nothing
        Me.objColumnStylegrdReportsPointerReport.HeaderText = "Report"
        Me.objColumnStylegrdReportsPointerReport.MappingName = "Report"
        Me.objColumnStylegrdReportsPointerReport.Width = 75
        '
        'objColumnStylegrdReportsPointerReportID
        '
        Me.objColumnStylegrdReportsPointerReportID.Format = ""
        Me.objColumnStylegrdReportsPointerReportID.FormatInfo = Nothing
        Me.objColumnStylegrdReportsPointerReportID.HeaderText = "ReportID"
        Me.objColumnStylegrdReportsPointerReportID.MappingName = "ReportID"
        Me.objColumnStylegrdReportsPointerReportID.Width = 75
        '
        'DataForm3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 604)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnLoad, Me.btnUpdate, Me.btnCancelAll, Me.grdPatients, Me.grdReportsPointer})
        Me.Name = "DataForm3"
        Me.Text = "DataForm3"
        CType(Me.objds2PatientsReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdReportsPointer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try

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

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objds2PatientsReports.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As oxistat1dot0.ds2PatientsReports = New oxistat1dot0.ds2PatientsReports()
        'Stop any current edits.
        Me.BindingContext(objds2PatientsReports, "Patients").EndCurrentEdit()
        Me.BindingContext(objds2PatientsReports, "ReportsPointer").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objds2PatientsReports.GetChanges, oxistat1dot0.ds2PatientsReports)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objds2PatientsReports.Merge(objDataSetChanges)
                objds2PatientsReports.AcceptChanges()
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
        Dim objDataSetTemp As oxistat1dot0.ds2PatientsReports
        objDataSetTemp = New oxistat1dot0.ds2PatientsReports()
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objds2PatientsReports.Clear()
            'Merge the records into the main dataset.
            objds2PatientsReports.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As oxistat1dot0.ds2PatientsReports)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
                OleDbDataAdapter2.Update(ChangedRows)
                OleDbDataAdapter3.Update(ChangedRows)
                OleDbDataAdapter4.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As oxistat1dot0.ds2PatientsReports)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
            Me.OleDbDataAdapter2.Fill(dataSet)
            Me.OleDbDataAdapter3.Fill(dataSet)
            Me.OleDbDataAdapter4.Fill(dataSet)
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
End Class
