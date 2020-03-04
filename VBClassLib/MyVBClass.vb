Imports Newtonsoft.Json

Public Class MyVBClass

    Private Multiplier As Integer

    Function AddTwo(A As Integer, B As Integer) As Integer
        Return A + B
    End Function

    Sub SetMultiplier(NewMultiplier As Integer)
        Multiplier = NewMultiplier
    End Sub

    Function MultiplyByMultiplier(NumToMultiply As Integer) As Integer
        Return NumToMultiply * Multiplier
    End Function

End Class