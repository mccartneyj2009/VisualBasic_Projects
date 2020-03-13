Public Class part2Class
    Private _num1
    Private _num2


    Public Property Num1 As Integer
        Get
            Return _num1
        End Get
        Set(value As Integer)
            _num1 = value
        End Set
    End Property

    Public Property Num2 As Integer
        Get
            Return _num2
        End Get
        Set(value As Integer)
            _num2 = value
        End Set
    End Property
    Public Overridable Function calculate(ByVal Num1 As Integer, ByVal Num2 As Integer) As Integer
        Return (Num1 + Num2)
    End Function


End Class
