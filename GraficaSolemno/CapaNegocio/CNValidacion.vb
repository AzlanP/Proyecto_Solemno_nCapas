Public Class CNValidacion
    Public Function ValidarSoloLetras(ByVal palabra As String) As Boolean
        Dim letra As String
        For i = palabra.Length - 1 To 0 Step -1

            letra = palabra.Chars(i)
            letra = CInt(letra)
            If (letra >= 97) And (letra <= 122) Or letra = 27 Then
                If i = 0 Then
                    Return True
                End If
            Else
                Return False
               
            End If
        Next
    End Function
    Public Function ValidarSoloNumeros(ByVal numero As String) As Boolean
        If IsNumeric(numero) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ValidarCampoVacio(ByVal texto As String) As Boolean
        If texto.Equals("") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
