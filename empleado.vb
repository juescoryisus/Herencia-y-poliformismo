Public Class empleado

    Inherits persona

    'Atributos 
    Private _tipocontarto As String
    Private _sueldo As String

    Public Property TipoContrato
        Get
            Return _tipocontarto
        End Get
        Set(value)
            _tipocontarto = value
        End Set
    End Property

    Public Property Sueldo As String
        Get
            Return _sueldo
        End Get
        Set(value As String)
            _sueldo = value
        End Set
    End Property

    'Vamos a agreegar las operaciones que tienen nuestra clase empleado 
    'Pondremos "Public sub " ya que es un procedimiento simple que se llamara 
    '"calcularsueldo()" y este procedimiento va a esperar una variable la cual 
    'llamaremos "sueldobase" y sera de tipo de dato double.

    Public Sub calcularsueldo(sueldobase As Double)
        If (Me.TipoContrato = "C") Then
            Me._sueldo = sueldobase + 350
        ElseIf (Me.TipoContrato = "N") Then
            Me.Sueldo = sueldobase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub


End Class
