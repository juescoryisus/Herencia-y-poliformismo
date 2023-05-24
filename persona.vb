Public Class persona

    'Atributos 
    'Declararemos los atributos de nuestra clase 

    Private _nombre As String
    Private _apellido As String
    Private _documento As String
    Private _tipo As String

    'Despues de declararlos vamos a encapsularlos y para ello vamos a utilizar las propiedades 
    'y estas propiedades van a tener metodos llamados (GET)para establecer valores y (SET) para obtener
    'el valor que esta contenido en este atributo

    'Propiedades
    Public Property Apellidos As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Nombres As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Documentos As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

End Class
