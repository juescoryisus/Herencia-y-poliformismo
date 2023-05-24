Public Class cliente
    'Para darle a entender que esta heredando de la clase persona 
    Inherits persona

    'Atributos propios de esta clase los cuales serian los siguientes 

    Private _categoria As String
    Private _codigo As String

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    'Podemos agregar algunas operaciones si asi queremos 
    'por ejemplo 
    'Agregar una unica operacion que va hacer un procedimiento simple
    'que se va a llamar (generar codigo) y lo unico que hara este metodo 
    'es ,llama a la propiedad (codigo) que estamos encapsulando en la variable
    'codigo y ovbiamente vamos a llamar al metodo SET y le pediremos que establesca
    'el siguiente codigo ,que inicialmente establesca una "C" despues concatenar 
    'esa "C" con "&" los "Apellidos pero obtendremos una subcadena de estos apellidos 
    'que iniciara desde la ubicacion 0 y va a tener un largo de 3 caracteres  y 
    'finalmente concatenar con "16".
    'De esta manera ya tenemos nuestro codigo generado 

    Public Sub generarcodigo()
        Me.Codigo = "C" & Me.Apellidos.Substring(0, 3) & "16"
    End Sub

End Class
