﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.4952
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("Ds_Balance"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class Ds_Balance
    Inherits Global.System.Data.DataSet
    
    Private tableDTBALANCE As DTBALANCEDataTable
    
    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("DTBALANCE")) Is Nothing) Then
                MyBase.Tables.Add(New DTBALANCEDataTable(ds.Tables("DTBALANCE")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property DTBALANCE() As DTBALANCEDataTable
        Get
            Return Me.tableDTBALANCE
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.BrowsableAttribute(true),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As Ds_Balance = CType(MyBase.Clone,Ds_Balance)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("DTBALANCE")) Is Nothing) Then
                MyBase.Tables.Add(New DTBALANCEDataTable(ds.Tables("DTBALANCE")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableDTBALANCE = CType(MyBase.Tables("DTBALANCE"),DTBALANCEDataTable)
        If (initTable = true) Then
            If (Not (Me.tableDTBALANCE) Is Nothing) Then
                Me.tableDTBALANCE.InitVars
            End If
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "Ds_Balance"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/Ds_Balance.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableDTBALANCE = New DTBALANCEDataTable
        MyBase.Tables.Add(Me.tableDTBALANCE)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeDTBALANCE() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As Ds_Balance = New Ds_Balance
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Try 
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0
                        
                        Do While ((s1.Position <> s1.Length)  _
                                    AndAlso (s1.ReadByte = s2.ReadByte))
                            
                            
                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If
                    
                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function
    
    Public Delegate Sub DTBALANCERowChangeEventHandler(ByVal sender As Object, ByVal e As DTBALANCERowChangeEvent)
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class DTBALANCEDataTable
        Inherits Global.System.Data.TypedTableBase(Of DTBALANCERow)
        
        Private columnCODCTA As Global.System.Data.DataColumn
        
        Private columnDESCRIPCION As Global.System.Data.DataColumn
        
        Private columnMONTO As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "DTBALANCE"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
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
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property CODCTAColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCODCTA
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property DESCRIPCIONColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnDESCRIPCION
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property MONTOColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnMONTO
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As DTBALANCERow
            Get
                Return CType(Me.Rows(index),DTBALANCERow)
            End Get
        End Property
        
        Public Event DTBALANCERowChanging As DTBALANCERowChangeEventHandler
        
        Public Event DTBALANCERowChanged As DTBALANCERowChangeEventHandler
        
        Public Event DTBALANCERowDeleting As DTBALANCERowChangeEventHandler
        
        Public Event DTBALANCERowDeleted As DTBALANCERowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddDTBALANCERow(ByVal row As DTBALANCERow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddDTBALANCERow(ByVal CODCTA As String, ByVal DESCRIPCION As String, ByVal MONTO As Decimal) As DTBALANCERow
            Dim rowDTBALANCERow As DTBALANCERow = CType(Me.NewRow,DTBALANCERow)
            Dim columnValuesArray() As Object = New Object() {CODCTA, DESCRIPCION, MONTO}
            rowDTBALANCERow.ItemArray = columnValuesArray
            Me.Rows.Add(rowDTBALANCERow)
            Return rowDTBALANCERow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As DTBALANCEDataTable = CType(MyBase.Clone,DTBALANCEDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New DTBALANCEDataTable
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnCODCTA = MyBase.Columns("CODCTA")
            Me.columnDESCRIPCION = MyBase.Columns("DESCRIPCION")
            Me.columnMONTO = MyBase.Columns("MONTO")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnCODCTA = New Global.System.Data.DataColumn("CODCTA", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCODCTA)
            Me.columnDESCRIPCION = New Global.System.Data.DataColumn("DESCRIPCION", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnDESCRIPCION)
            Me.columnMONTO = New Global.System.Data.DataColumn("MONTO", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnMONTO)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewDTBALANCERow() As DTBALANCERow
            Return CType(Me.NewRow,DTBALANCERow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New DTBALANCERow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(DTBALANCERow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.DTBALANCERowChangedEvent) Is Nothing) Then
                RaiseEvent DTBALANCERowChanged(Me, New DTBALANCERowChangeEvent(CType(e.Row,DTBALANCERow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.DTBALANCERowChangingEvent) Is Nothing) Then
                RaiseEvent DTBALANCERowChanging(Me, New DTBALANCERowChangeEvent(CType(e.Row,DTBALANCERow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.DTBALANCERowDeletedEvent) Is Nothing) Then
                RaiseEvent DTBALANCERowDeleted(Me, New DTBALANCERowChangeEvent(CType(e.Row,DTBALANCERow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.DTBALANCERowDeletingEvent) Is Nothing) Then
                RaiseEvent DTBALANCERowDeleting(Me, New DTBALANCERowChangeEvent(CType(e.Row,DTBALANCERow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveDTBALANCERow(ByVal row As DTBALANCERow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
            Dim ds As Ds_Balance = New Ds_Balance
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "DTBALANCEDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class DTBALANCERow
        Inherits Global.System.Data.DataRow
        
        Private tableDTBALANCE As DTBALANCEDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableDTBALANCE = CType(Me.Table,DTBALANCEDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property CODCTA() As String
            Get
                Try 
                    Return CType(Me(Me.tableDTBALANCE.CODCTAColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'CODCTA' de la tabla 'DTBALANCE' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDTBALANCE.CODCTAColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property DESCRIPCION() As String
            Get
                Try 
                    Return CType(Me(Me.tableDTBALANCE.DESCRIPCIONColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'DESCRIPCION' de la tabla 'DTBALANCE' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDTBALANCE.DESCRIPCIONColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property MONTO() As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableDTBALANCE.MONTOColumn),Decimal)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'MONTO' de la tabla 'DTBALANCE' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDTBALANCE.MONTOColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsCODCTANull() As Boolean
            Return Me.IsNull(Me.tableDTBALANCE.CODCTAColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetCODCTANull()
            Me(Me.tableDTBALANCE.CODCTAColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsDESCRIPCIONNull() As Boolean
            Return Me.IsNull(Me.tableDTBALANCE.DESCRIPCIONColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetDESCRIPCIONNull()
            Me(Me.tableDTBALANCE.DESCRIPCIONColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsMONTONull() As Boolean
            Return Me.IsNull(Me.tableDTBALANCE.MONTOColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetMONTONull()
            Me(Me.tableDTBALANCE.MONTOColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class DTBALANCERowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As DTBALANCERow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As DTBALANCERow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As DTBALANCERow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
