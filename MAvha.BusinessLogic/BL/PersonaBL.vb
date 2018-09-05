Imports MAvha.BusinessLogic

Public Class PersonaBL

    Public Sub Save(ByVal x As PersonaApp)
        Dim isFemale As Boolean

        If x.Sexo.ToUpper = "FEMENINO" Then
            isFemale = True
        Else
            isFemale = False
        End If

        If x.ID = 0 Then
            Dim newPersona As New Persona With {
                .Nombre = x.Nombre,
                .Nacimiento = x.Nacimiento.Date,
                .Femenino = isFemale,
                .Activo = True
            }
            Create(newPersona)
        Else
            Dim updPersona As New Persona With {
                .ID = x.ID,
                .Nombre = x.Nombre,
                .Nacimiento = x.Nacimiento.Date,
                .Activo = True,
                .Femenino = isFemale
            }
            Update(updPersona)
        End If
    End Sub

    Public Sub DeleteLogic(ByVal ID As Integer)

        If ID = 0 Then
            Return
        End If

        Dim x = LoadDB(ID)

        If Not IsNothing(x) Then
            x.Activo = False
            Update(x)
        End If
    End Sub

    Public Function LoadDB(ByVal ID As Integer) As Persona
        Dim query As IQueryable(Of Persona)

        Using db As New MAvhaEntities
            query = From x In db.Persona
                    Where x.ID = ID
                    Select x

            Return query.FirstOrDefault()
        End Using
    End Function

    Public Function Load(ByVal ID As Integer) As PersonaApp
        Dim query As IQueryable(Of Persona)
        Dim objPersonaDB As New Persona
        Dim objPersonaApp As New PersonaApp

        Using db As New MAvhaEntities
            query = From x In db.Persona
                    Where x.ID = ID
                    Select x

            objPersonaDB = query.FirstOrDefault()
            If Not IsNothing(objPersonaDB) Then

                objPersonaApp.ID = objPersonaDB.ID
                objPersonaApp.Nombre = objPersonaDB.Nombre
                objPersonaApp.Nacimiento = objPersonaDB.Nacimiento.Date
                objPersonaApp.Sexo = GetSexStr(objPersonaDB.Femenino)
                objPersonaApp.Edad = GetAge(objPersonaDB.Nacimiento)

                Return objPersonaApp
            Else
                Return New PersonaApp
            End If
        End Using
    End Function

    Public Function LoadActives() As List(Of PersonaApp)
        Dim query As IQueryable(Of Persona)

        Using db As New MAvhaEntities
            query = From x In db.Persona
                    Where x.Activo
                    Select x

            Return MapToModel(query.ToList())
        End Using
    End Function

    Public Function LoadDeleted() As List(Of PersonaApp)

        Dim query As IQueryable(Of Persona)

        Using db As New MAvhaEntities
            query = From x In db.Persona
                    Where Not x.Activo
                    Select x

            Return MapToModel(query.ToList())
        End Using
    End Function

    Public Function LoadAll() As List(Of PersonaApp)

        Dim query As IQueryable(Of Persona)

        Using db As New MAvhaEntities
            query = From x In db.Persona
                    Select x

            Return MapToModel(query.ToList())
        End Using
    End Function

    Public Sub Create(ByVal person As Persona)
        Using db As New MAvhaEntities
            db.AddToPersona(person)
            db.SaveChanges()
        End Using
    End Sub

    Public Sub Update(ByVal person As Persona)
        Using db As New MAvhaEntities

            Dim PDB As Persona
            PDB = db.Persona.FirstOrDefault(Function(x) x.ID = person.ID)

            If IsNothing(PDB) Then
                Create(person)
            Else
                PDB.Nombre = person.Nombre
                PDB.Nacimiento = person.Nacimiento.Date
                PDB.Femenino = person.Femenino
                PDB.Activo = person.Activo

                db.SaveChanges()
            End If
        End Using
    End Sub

    Private Function GetAge(nacimiento As Date) As Integer
        Dim age As Integer
        age = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Function GetSexStr(femenino As Boolean) As String
        If femenino Then
            Return "Femenino"
        Else
            Return "Masculino"
        End If
    End Function

    Private Function GetSexBool(sex As String) As Boolean
        If sex = "FEMENINO" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function MapToModel(list As List(Of Persona)) As List(Of PersonaApp)
        Dim finalList As New List(Of PersonaApp)
        For Each persona In list
            Dim personItem As New PersonaApp With {
                .ID = persona.ID,
                .Nombre = persona.Nombre,
                .Nacimiento = persona.Nacimiento.Date,
                .Sexo = GetSexStr(persona.Femenino),
                .Edad = GetAge(persona.Nacimiento)
            }

            finalList.Add(personItem)
        Next

        Return finalList
    End Function
End Class