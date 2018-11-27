Public Class Persona
    Private _nombre As String
    Private _dni As UInteger
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length < 30 Then
                _nombre = value
            Else
                Throw New Exception("El nombre es muy largo!")
            End If
        End Set
    End Property
    Public Property Dni As UInteger
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Sub New(nombre As String, dni As UInteger)
        Me.Nombre = nombre
        Me.Dni = dni
    End Sub
End Class
