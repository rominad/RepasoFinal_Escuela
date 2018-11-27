Public Class Asignatura
    Private _nombre As String
    Private _horasSemanales As Byte
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
    Public Property HorasSemanales As Byte
        Get
            Return _horasSemanales
        End Get
        Set(value As Byte)
            _horasSemanales = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
End Class
