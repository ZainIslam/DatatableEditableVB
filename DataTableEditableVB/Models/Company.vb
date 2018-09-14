Public Class Company
    Shared nextID As Integer = 17

    Public Sub New()
        ID = Math.Min(System.Threading.Interlocked.Increment(nextID), nextID - 1)
    End Sub

    Public Property ID As Integer
    Public Property Name As String
    Public Property Address As String
    Public Property Town As String
End Class
