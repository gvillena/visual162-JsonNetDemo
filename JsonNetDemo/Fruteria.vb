Public Class Fruteria

    Private _Frutas As List(Of Fruta)
    Private _Verduras As List(Of Verdura)

    Public Property Frutas() As List(Of Fruta)
        Get
            If _Frutas Is Nothing Then
                _Frutas = New List(Of Fruta)
            End If
            Return _Frutas
        End Get
        Set(ByVal value As List(Of Fruta))
            _Frutas = value
        End Set
    End Property

    Public Property Verduras() As List(Of Verdura)
        Get
            If _Verduras Is Nothing Then
                _Verduras = New List(Of Verdura)
            End If
            Return _Verduras
        End Get
        Set(ByVal value As List(Of Verdura))
            _Verduras = value
        End Set
    End Property

End Class
