﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.288
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsPatients
    Inherits DataSet
    
    Private tablePatients As PatientsDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Patients")) Is Nothing) Then
                Me.Tables.Add(New PatientsDataTable(ds.Tables("Patients")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Patients As PatientsDataTable
        Get
            Return Me.tablePatients
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsPatients = CType(MyBase.Clone,dsPatients)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Patients")) Is Nothing) Then
            Me.Tables.Add(New PatientsDataTable(ds.Tables("Patients")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tablePatients = CType(Me.Tables("Patients"),PatientsDataTable)
        If (Not (Me.tablePatients) Is Nothing) Then
            Me.tablePatients.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsPatients"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsPatients.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablePatients = New PatientsDataTable
        Me.Tables.Add(Me.tablePatients)
    End Sub
    
    Private Function ShouldSerializePatients() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub PatientsRowChangeEventHandler(ByVal sender As Object, ByVal e As PatientsRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PatientsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private columnComments As DataColumn
        
        Private columnCustomerID As DataColumn
        
        Private columnFirstName As DataColumn
        
        Private columnLastName As DataColumn
        
        Private columnOrgID As DataColumn
        
        Private columnPatientFax As DataColumn
        
        Private columnPatientID As DataColumn
        
        Private columnPatientPhone As DataColumn
        
        Private columnPhysican As DataColumn
        
        Private columnReportsNumSaved As DataColumn
        
        Private columnStartDate As DataColumn
        
        Private columnState As DataColumn
        
        Private columnZip As DataColumn
        
        Friend Sub New()
            MyBase.New("Patients")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property AddressColumn As DataColumn
            Get
                Return Me.columnAddress
            End Get
        End Property
        
        Friend ReadOnly Property CityColumn As DataColumn
            Get
                Return Me.columnCity
            End Get
        End Property
        
        Friend ReadOnly Property CommentsColumn As DataColumn
            Get
                Return Me.columnComments
            End Get
        End Property
        
        Friend ReadOnly Property CustomerIDColumn As DataColumn
            Get
                Return Me.columnCustomerID
            End Get
        End Property
        
        Friend ReadOnly Property FirstNameColumn As DataColumn
            Get
                Return Me.columnFirstName
            End Get
        End Property
        
        Friend ReadOnly Property LastNameColumn As DataColumn
            Get
                Return Me.columnLastName
            End Get
        End Property
        
        Friend ReadOnly Property OrgIDColumn As DataColumn
            Get
                Return Me.columnOrgID
            End Get
        End Property
        
        Friend ReadOnly Property PatientFaxColumn As DataColumn
            Get
                Return Me.columnPatientFax
            End Get
        End Property
        
        Friend ReadOnly Property PatientIDColumn As DataColumn
            Get
                Return Me.columnPatientID
            End Get
        End Property
        
        Friend ReadOnly Property PatientPhoneColumn As DataColumn
            Get
                Return Me.columnPatientPhone
            End Get
        End Property
        
        Friend ReadOnly Property PhysicanColumn As DataColumn
            Get
                Return Me.columnPhysican
            End Get
        End Property
        
        Friend ReadOnly Property ReportsNumSavedColumn As DataColumn
            Get
                Return Me.columnReportsNumSaved
            End Get
        End Property
        
        Friend ReadOnly Property StartDateColumn As DataColumn
            Get
                Return Me.columnStartDate
            End Get
        End Property
        
        Friend ReadOnly Property StateColumn As DataColumn
            Get
                Return Me.columnState
            End Get
        End Property
        
        Friend ReadOnly Property ZipColumn As DataColumn
            Get
                Return Me.columnZip
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As PatientsRow
            Get
                Return CType(Me.Rows(index),PatientsRow)
            End Get
        End Property
        
        Public Event PatientsRowChanged As PatientsRowChangeEventHandler
        
        Public Event PatientsRowChanging As PatientsRowChangeEventHandler
        
        Public Event PatientsRowDeleted As PatientsRowChangeEventHandler
        
        Public Event PatientsRowDeleting As PatientsRowChangeEventHandler
        
        Public Overloads Sub AddPatientsRow(ByVal row As PatientsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddPatientsRow(ByVal Address As String, ByVal City As String, ByVal Comments As String, ByVal CustomerID As String, ByVal FirstName As String, ByVal LastName As String, ByVal OrgID As String, ByVal PatientFax As String, ByVal PatientPhone As String, ByVal Physican As String, ByVal ReportsNumSaved As String, ByVal StartDate As Date, ByVal State As String, ByVal Zip As String) As PatientsRow
            Dim rowPatientsRow As PatientsRow = CType(Me.NewRow,PatientsRow)
            rowPatientsRow.ItemArray = New Object() {Address, City, Comments, CustomerID, FirstName, LastName, OrgID, PatientFax, Nothing, PatientPhone, Physican, ReportsNumSaved, StartDate, State, Zip}
            Me.Rows.Add(rowPatientsRow)
            Return rowPatientsRow
        End Function
        
        Public Function FindByPatientID(ByVal PatientID As Integer) As PatientsRow
            Return CType(Me.Rows.Find(New Object() {PatientID}),PatientsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As PatientsDataTable = CType(MyBase.Clone,PatientsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New PatientsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.columnComments = Me.Columns("Comments")
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnFirstName = Me.Columns("FirstName")
            Me.columnLastName = Me.Columns("LastName")
            Me.columnOrgID = Me.Columns("OrgID")
            Me.columnPatientFax = Me.Columns("PatientFax")
            Me.columnPatientID = Me.Columns("PatientID")
            Me.columnPatientPhone = Me.Columns("PatientPhone")
            Me.columnPhysican = Me.Columns("Physican")
            Me.columnReportsNumSaved = Me.Columns("ReportsNumSaved")
            Me.columnStartDate = Me.Columns("StartDate")
            Me.columnState = Me.Columns("State")
            Me.columnZip = Me.Columns("Zip")
        End Sub
        
        Private Sub InitClass()
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.columnComments = New DataColumn("Comments", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnComments)
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnFirstName = New DataColumn("FirstName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFirstName)
            Me.columnLastName = New DataColumn("LastName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnLastName)
            Me.columnOrgID = New DataColumn("OrgID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrgID)
            Me.columnPatientFax = New DataColumn("PatientFax", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPatientFax)
            Me.columnPatientID = New DataColumn("PatientID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPatientID)
            Me.columnPatientPhone = New DataColumn("PatientPhone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPatientPhone)
            Me.columnPhysican = New DataColumn("Physican", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhysican)
            Me.columnReportsNumSaved = New DataColumn("ReportsNumSaved", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnReportsNumSaved)
            Me.columnStartDate = New DataColumn("StartDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnStartDate)
            Me.columnState = New DataColumn("State", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnState)
            Me.columnZip = New DataColumn("Zip", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnZip)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnPatientID}, true))
            Me.columnPatientID.AutoIncrement = true
            Me.columnPatientID.AllowDBNull = false
            Me.columnPatientID.Unique = true
        End Sub
        
        Public Function NewPatientsRow() As PatientsRow
            Return CType(Me.NewRow,PatientsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New PatientsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(PatientsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PatientsRowChangedEvent) Is Nothing) Then
                RaiseEvent PatientsRowChanged(Me, New PatientsRowChangeEvent(CType(e.Row,PatientsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PatientsRowChangingEvent) Is Nothing) Then
                RaiseEvent PatientsRowChanging(Me, New PatientsRowChangeEvent(CType(e.Row,PatientsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PatientsRowDeletedEvent) Is Nothing) Then
                RaiseEvent PatientsRowDeleted(Me, New PatientsRowChangeEvent(CType(e.Row,PatientsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PatientsRowDeletingEvent) Is Nothing) Then
                RaiseEvent PatientsRowDeleting(Me, New PatientsRowChangeEvent(CType(e.Row,PatientsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovePatientsRow(ByVal row As PatientsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PatientsRow
        Inherits DataRow
        
        Private tablePatients As PatientsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablePatients = CType(Me.Table,PatientsDataTable)
        End Sub
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.AddressColumn) = value
            End Set
        End Property
        
        Public Property City As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.CityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.CityColumn) = value
            End Set
        End Property
        
        Public Property Comments As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.CommentsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.CommentsColumn) = value
            End Set
        End Property
        
        Public Property CustomerID As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.CustomerIDColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.CustomerIDColumn) = value
            End Set
        End Property
        
        Public Property FirstName As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.FirstNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.FirstNameColumn) = value
            End Set
        End Property
        
        Public Property LastName As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.LastNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.LastNameColumn) = value
            End Set
        End Property
        
        Public Property OrgID As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.OrgIDColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.OrgIDColumn) = value
            End Set
        End Property
        
        Public Property PatientFax As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.PatientFaxColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.PatientFaxColumn) = value
            End Set
        End Property
        
        Public Property PatientID As Integer
            Get
                Return CType(Me(Me.tablePatients.PatientIDColumn),Integer)
            End Get
            Set
                Me(Me.tablePatients.PatientIDColumn) = value
            End Set
        End Property
        
        Public Property PatientPhone As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.PatientPhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.PatientPhoneColumn) = value
            End Set
        End Property
        
        Public Property Physican As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.PhysicanColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.PhysicanColumn) = value
            End Set
        End Property
        
        Public Property ReportsNumSaved As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.ReportsNumSavedColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.ReportsNumSavedColumn) = value
            End Set
        End Property
        
        Public Property StartDate As Date
            Get
                Try 
                    Return CType(Me(Me.tablePatients.StartDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.StartDateColumn) = value
            End Set
        End Property
        
        Public Property State As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.StateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.StateColumn) = value
            End Set
        End Property
        
        Public Property Zip As String
            Get
                Try 
                    Return CType(Me(Me.tablePatients.ZipColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePatients.ZipColumn) = value
            End Set
        End Property
        
        Public Function IsAddressNull() As Boolean
            Return Me.IsNull(Me.tablePatients.AddressColumn)
        End Function
        
        Public Sub SetAddressNull()
            Me(Me.tablePatients.AddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCityNull() As Boolean
            Return Me.IsNull(Me.tablePatients.CityColumn)
        End Function
        
        Public Sub SetCityNull()
            Me(Me.tablePatients.CityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCommentsNull() As Boolean
            Return Me.IsNull(Me.tablePatients.CommentsColumn)
        End Function
        
        Public Sub SetCommentsNull()
            Me(Me.tablePatients.CommentsColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCustomerIDNull() As Boolean
            Return Me.IsNull(Me.tablePatients.CustomerIDColumn)
        End Function
        
        Public Sub SetCustomerIDNull()
            Me(Me.tablePatients.CustomerIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFirstNameNull() As Boolean
            Return Me.IsNull(Me.tablePatients.FirstNameColumn)
        End Function
        
        Public Sub SetFirstNameNull()
            Me(Me.tablePatients.FirstNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsLastNameNull() As Boolean
            Return Me.IsNull(Me.tablePatients.LastNameColumn)
        End Function
        
        Public Sub SetLastNameNull()
            Me(Me.tablePatients.LastNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrgIDNull() As Boolean
            Return Me.IsNull(Me.tablePatients.OrgIDColumn)
        End Function
        
        Public Sub SetOrgIDNull()
            Me(Me.tablePatients.OrgIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPatientFaxNull() As Boolean
            Return Me.IsNull(Me.tablePatients.PatientFaxColumn)
        End Function
        
        Public Sub SetPatientFaxNull()
            Me(Me.tablePatients.PatientFaxColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPatientPhoneNull() As Boolean
            Return Me.IsNull(Me.tablePatients.PatientPhoneColumn)
        End Function
        
        Public Sub SetPatientPhoneNull()
            Me(Me.tablePatients.PatientPhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhysicanNull() As Boolean
            Return Me.IsNull(Me.tablePatients.PhysicanColumn)
        End Function
        
        Public Sub SetPhysicanNull()
            Me(Me.tablePatients.PhysicanColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsReportsNumSavedNull() As Boolean
            Return Me.IsNull(Me.tablePatients.ReportsNumSavedColumn)
        End Function
        
        Public Sub SetReportsNumSavedNull()
            Me(Me.tablePatients.ReportsNumSavedColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStartDateNull() As Boolean
            Return Me.IsNull(Me.tablePatients.StartDateColumn)
        End Function
        
        Public Sub SetStartDateNull()
            Me(Me.tablePatients.StartDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsStateNull() As Boolean
            Return Me.IsNull(Me.tablePatients.StateColumn)
        End Function
        
        Public Sub SetStateNull()
            Me(Me.tablePatients.StateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsZipNull() As Boolean
            Return Me.IsNull(Me.tablePatients.ZipColumn)
        End Function
        
        Public Sub SetZipNull()
            Me(Me.tablePatients.ZipColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PatientsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As PatientsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As PatientsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As PatientsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class