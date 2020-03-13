Public Class InputClass
    Public _Banner As String
    Private _yourName As String

    Public Sub New()
        _Banner = "Enter your name"
    End Sub

    Public Property YourName As String
        Get
            Return _yourName
        End Get
        Set(value As String)
            _yourName = value
        End Set
    End Property
End Class
