﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("6c42aa0e-a04b-4a40-b2ba-5b68d3a47f52")> 

'Original file name:
'Generation date: 04/09/2018 15:30:32
'''<summary>
'''There are no comments for MAvhaEntities in the schema.
'''</summary>
Partial Public Class MAvhaEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new MAvhaEntities object using the connection string found in the 'MAvhaEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=MAvhaEntities", "MAvhaEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new MAvhaEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "MAvhaEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new MAvhaEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "MAvhaEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for Persona in the schema.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public ReadOnly Property Persona() As Global.System.Data.Objects.ObjectQuery(Of Persona)
        Get
            If (Me._Persona Is Nothing) Then
                Me._Persona = MyBase.CreateQuery(Of Persona)("[Persona]")
            End If
            Return Me._Persona
        End Get
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Persona As Global.System.Data.Objects.ObjectQuery(Of Persona)
    '''<summary>
    '''There are no comments for Persona in the schema.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Sub AddToPersona(ByVal persona As Persona)
        MyBase.AddObject("Persona", persona)
    End Sub
End Class
'''<summary>
'''There are no comments for MAvhaModel.Persona in the schema.
'''</summary>
'''<KeyProperties>
'''ID
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="MAvhaModel", Name:="Persona"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Persona
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Persona object.
    '''</summary>
    '''<param name="id">Initial value of ID.</param>
    '''<param name="nombre">Initial value of Nombre.</param>
    '''<param name="nacimiento">Initial value of Nacimiento.</param>
    '''<param name="femenino">Initial value of Femenino.</param>
    '''<param name="activo">Initial value of Activo.</param>
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Shared Function CreatePersona(ByVal id As Integer, ByVal nombre As String, ByVal nacimiento As Date, ByVal femenino As Boolean, ByVal activo As Boolean) As Persona
        Dim persona As Persona = New Persona()
        persona.ID = id
        persona.Nombre = nombre
        persona.Nacimiento = nacimiento
        persona.Femenino = femenino
        persona.Activo = activo
        Return persona
    End Function
    '''<summary>
    '''There are no comments for property ID in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property ID() As Integer
        Get
            Return Me._ID
        End Get
        Set
            Me.OnIDChanging(value)
            Me.ReportPropertyChanging("ID")
            Me._ID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("ID")
            Me.OnIDChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _ID As Integer
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnIDChanging(ByVal value As Integer)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnIDChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Nombre in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Nombre() As String
        Get
            Return Me._Nombre
        End Get
        Set
            Me.OnNombreChanging(value)
            Me.ReportPropertyChanging("Nombre")
            Me._Nombre = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Nombre")
            Me.OnNombreChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Nombre As String
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnNombreChanging(ByVal value As String)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnNombreChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Nacimiento in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Nacimiento() As Date
        Get
            Return Me._Nacimiento
        End Get
        Set
            Me.OnNacimientoChanging(value)
            Me.ReportPropertyChanging("Nacimiento")
            Me._Nacimiento = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Nacimiento")
            Me.OnNacimientoChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Nacimiento As Date
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnNacimientoChanging(ByVal value As Date)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnNacimientoChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Femenino in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Femenino() As Boolean
        Get
            Return Me._Femenino
        End Get
        Set
            Me.OnFemeninoChanging(value)
            Me.ReportPropertyChanging("Femenino")
            Me._Femenino = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Femenino")
            Me.OnFemeninoChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Femenino As Boolean
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnFemeninoChanging(ByVal value As Boolean)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnFemeninoChanged()
        End Sub
    '''<summary>
    '''There are no comments for property Activo in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Public Property Activo() As Boolean
        Get
            Return Me._Activo
        End Get
        Set
            Me.OnActivoChanging(value)
            Me.ReportPropertyChanging("Activo")
            Me._Activo = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Activo")
            Me.OnActivoChanged
        End Set
    End Property
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Private _Activo As Boolean
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnActivoChanging(ByVal value As Boolean)
        End Sub
    <Global.System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")>  _
    Partial Private Sub OnActivoChanged()
        End Sub
End Class
