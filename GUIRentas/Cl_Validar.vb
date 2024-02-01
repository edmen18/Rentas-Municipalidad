Public Class Cl_Validar
    Public Function NumerosDecimales(ByVal kcode As Int16) As Boolean
        If (kcode >= 48 And kcode <= 57) Or kcode = 8 Or kcode = 46 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function NumerosEnteros(ByVal kcode As Int16) As Boolean
        If (kcode >= 48 And kcode <= 57) Or kcode = 8 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function SoloLetras(ByVal kcode As Int16) As Boolean
        If (kcode >= 65 And kcode <= 90) Or (kcode >= 97 And kcode <= 122) Or kcode = 8 Or kcode = 32 Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
