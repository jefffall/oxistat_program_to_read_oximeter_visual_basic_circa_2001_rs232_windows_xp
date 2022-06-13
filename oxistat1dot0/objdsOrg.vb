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
Public Class objdsOrg
    Inherits DataSet
    
    Private tableOrgTable As OrgTableDataTable
    
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
            If (Not (ds.Tables("OrgTable")) Is Nothing) Then
                Me.Tables.Add(New OrgTableDataTable(ds.Tables("OrgTable")))
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
    Public ReadOnly Property OrgTable As OrgTableDataTable
        Get
            Return Me.tableOrgTable
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As objdsOrg = CType(MyBase.Clone,objdsOrg)
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
        If (Not (ds.Tables("OrgTable")) Is Nothing) Then
            Me.Tables.Add(New OrgTableDataTable(ds.Tables("OrgTable")))
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
        Me.tableOrgTable = CType(Me.Tables("OrgTable"),OrgTableDataTable)
        If (Not (Me.tableOrgTable) Is Nothing) Then
            Me.tableOrgTable.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "objdsOrg"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/objdsOrg.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableOrgTable = New OrgTableDataTable
        Me.Tables.Add(Me.tableOrgTable)
    End Sub
    
    Private Function ShouldSerializeOrgTable() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub OrgTableRowChangeEventHandler(ByVal sender As Object, ByVal e As OrgTableRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class OrgTableDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnAddress As DataColumn
        
        Private columnFax_Number As DataColumn
        
        Private columnOrganization As DataColumn
        
        Private columnOrgID As DataColumn
        
        Private columnOrgKey As DataColumn
        
        Private columnPhone_Number As DataColumn
        
        Private columnselected As DataColumn
        
        Friend Sub New()
            MyBase.New("OrgTable")
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
        
        Friend ReadOnly Property Fax_NumberColumn As DataColumn
            Get
                Return Me.columnFax_Number
            End Get
        End Property
        
        Friend ReadOnly Property OrganizationColumn As DataColumn
            Get
                Return Me.columnOrganization
            End Get
        End Property
        
        Friend ReadOnly Property OrgIDColumn As DataColumn
            Get
                Return Me.columnOrgID
            End Get
        End Property
        
        Friend ReadOnly Property OrgKeyColumn As DataColumn
            Get
                Return Me.columnOrgKey
            End Get
        End Property
        
        Friend ReadOnly Property Phone_NumberColumn As DataColumn
            Get
                Return Me.columnPhone_Number
            End Get
        End Property
        
        Friend ReadOnly Property selectedColumn As DataColumn
            Get
                Return Me.columnselected
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As OrgTableRow
            Get
                Return CType(Me.Rows(index),OrgTableRow)
            End Get
        End Property
        
        Public Event OrgTableRowChanged As OrgTableRowChangeEventHandler
        
        Public Event OrgTableRowChanging As OrgTableRowChangeEventHandler
        
        Public Event OrgTableRowDeleted As OrgTableRowChangeEventHandler
        
        Public Event OrgTableRowDeleting As OrgTableRowChangeEventHandler
        
        Public Overloads Sub AddOrgTableRow(ByVal row As OrgTableRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddOrgTableRow(ByVal Address As String, ByVal Fax_Number As String, ByVal Organization As String, ByVal OrgID As String, ByVal Phone_Number As String, ByVal selected As String) As OrgTableRow
            Dim rowOrgTableRow As OrgTableRow = CType(Me.NewRow,OrgTableRow)
            rowOrgTableRow.ItemArray = New Object() {Address, Fax_Number, Organization, OrgID, Nothing, Phone_Number, selected}
            Me.Rows.Add(rowOrgTableRow)
            Return rowOrgTableRow
        End Function
        
        Public Function FindByOrgKey(ByVal OrgKey As Integer) As OrgTableRow
            Return CType(Me.Rows.Find(New Object() {OrgKey}),OrgTableRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As OrgTableDataTable = CType(MyBase.Clone,OrgTableDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New OrgTableDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnAddress = Me.Columns("Address")
            Me.columnFax_Number = Me.Columns("Fax Number")
            Me.columnOrganization = Me.Columns("Organization")
            Me.columnOrgID = Me.Columns("OrgID")
            Me.columnOrgKey = Me.Columns("OrgKey")
            Me.columnPhone_Number = Me.Columns("Phone Number")
            Me.columnselected = Me.Columns("selected")
        End Sub
        
        Private Sub InitClass()
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnFax_Number = New DataColumn("Fax Number", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFax_Number)
            Me.columnOrganization = New DataColumn("Organization", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrganization)
            Me.columnOrgID = New DataColumn("OrgID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrgID)
            Me.columnOrgKey = New DataColumn("OrgKey", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrgKey)
            Me.columnPhone_Number = New DataColumn("Phone Number", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone_Number)
            Me.columnselected = New DataColumn("selected", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnselected)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnOrgKey}, true))
            Me.columnOrgKey.AutoIncrement = true
            Me.columnOrgKey.AllowDBNull = false
            Me.columnOrgKey.Unique = true
        End Sub
        
        Public Function NewOrgTableRow() As OrgTableRow
            Return CType(Me.NewRow,OrgTableRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New OrgTableRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(OrgTableRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.OrgTableRowChangedEvent) Is Nothing) Then
                RaiseEvent OrgTableRowChanged(Me, New OrgTableRowChangeEvent(CType(e.Row,OrgTableRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.OrgTableRowChangingEvent) Is Nothing) Then
                RaiseEvent OrgTableRowChanging(Me, New OrgTableRowChangeEvent(CType(e.Row,OrgTableRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.OrgTableRowDeletedEvent) Is Nothing) Then
                RaiseEvent OrgTableRowDeleted(Me, New OrgTableRowChangeEvent(CType(e.Row,OrgTableRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.OrgTableRowDeletingEvent) Is Nothing) Then
                RaiseEvent OrgTableRowDeleting(Me, New OrgTableRowChangeEvent(CType(e.Row,OrgTableRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveOrgTableRow(ByVal row As OrgTableRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class OrgTableRow
        Inherits DataRow
        
        Private tableOrgTable As OrgTableDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableOrgTable = CType(Me.Table,OrgTableDataTable)
        End Sub
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tableOrgTable.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrgTable.AddressColumn) = value
            End Set
        End Property
        
        Public Property Fax_Number As String
            Get
                Try 
                    Return CType(Me(Me.tableOrgTable.Fax_NumberColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrgTable.Fax_NumberColumn) = value
            End Set
        End Property
        
        Public Property Organization As String
            Get
                Try 
                    Return CType(Me(Me.tableOrgTable.OrganizationColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrgTable.OrganizationColumn) = value
            End Set
        End Property
        
        Public Property OrgID As String
            Get
                Try 
                    Return CType(Me(Me.tableOrgTable.OrgIDColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrgTable.OrgIDColumn) = value
            End Set
        End Property
        
        Public Property OrgKey As Integer
            Get
                Return CType(Me(Me.tableOrgTable.OrgKeyColumn),Integer)
            End Get
            Set
                Me(Me.tableOrgTable.OrgKeyColumn) = value
            End Set
        End Property
        
        Public Property Phone_Number As String
            Get
                Try 
                    Return CType(Me(Me.tableOrgTable.Phone_NumberColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrgTable.Phone_NumberColumn) = value
            End Set
        End Property
        
        Public Property selected As String
            Get
                Try 
                    Return CType(Me(Me.tableOrgTable.selectedColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrgTable.selectedColumn) = value
            End Set
        End Property
        
        Public Function IsAddressNull() As Boolean
            Return Me.IsNull(Me.tableOrgTable.AddressColumn)
        End Function
        
        Public Sub SetAddressNull()
            Me(Me.tableOrgTable.AddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFax_NumberNull() As Boolean
            Return Me.IsNull(Me.tableOrgTable.Fax_NumberColumn)
        End Function
        
        Public Sub SetFax_NumberNull()
            Me(Me.tableOrgTable.Fax_NumberColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrganizationNull() As Boolean
            Return Me.IsNull(Me.tableOrgTable.OrganizationColumn)
        End Function
        
        Public Sub SetOrganizationNull()
            Me(Me.tableOrgTable.OrganizationColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrgIDNull() As Boolean
            Return Me.IsNull(Me.tableOrgTable.OrgIDColumn)
        End Function
        
        Public Sub SetOrgIDNull()
            Me(Me.tableOrgTable.OrgIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhone_NumberNull() As Boolean
            Return Me.IsNull(Me.tableOrgTable.Phone_NumberColumn)
        End Function
        
        Public Sub SetPhone_NumberNull()
            Me(Me.tableOrgTable.Phone_NumberColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsselectedNull() As Boolean
            Return Me.IsNull(Me.tableOrgTable.selectedColumn)
        End Function
        
        Public Sub SetselectedNull()
            Me(Me.tableOrgTable.selectedColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class OrgTableRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As OrgTableRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As OrgTableRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As OrgTableRow
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
