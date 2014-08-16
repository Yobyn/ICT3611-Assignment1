Module StudentNumber
    Public Function generateNewStudentNumber(ByVal oldStudentNr As String) As String

        Dim studentNumber As String

        studentNumber = Date.Today.Year.ToString.Substring(2, 2)

        Dim sum As Integer

        If (oldStudentNr.Length > 0) Then

            If (Date.Today.Year.ToString.Substring(2, 2) = oldStudentNr.ToString.Substring(0, 2)) Then
                sum = Integer.Parse(oldStudentNr.Substring(2, 1)) + Integer.Parse(oldStudentNr.Substring(3, 1)) + Integer.Parse(oldStudentNr.Substring(4, 1)) + Integer.Parse(oldStudentNr.Substring(5, 1))
                sum = sum + 1
            Else
                sum = 1
            End If
        Else
            sum = 1
        End If

        studentNumber = studentNumber + Format(sum, "0000")

        generateNewStudentNumber = studentNumber + calcSeventhDigit(studentNumber)

    End Function

    Public Function calcSeventhDigit(ByVal studentNumber As String) As String

        Dim sum As Integer

        sum = Integer.Parse(studentNumber.Substring(0, 1)) + Integer.Parse(studentNumber.Substring(1, 1)) + Integer.Parse(studentNumber.Substring(2, 1)) + Integer.Parse(studentNumber.Substring(3, 1)) + Integer.Parse(studentNumber.Substring(4, 1)) + Integer.Parse(studentNumber.Substring(5, 1))

        Dim remainder As Integer

        remainder = sum Mod 10

        Dim checkDigit As String

        If (remainder > 0) Then
            checkDigit = (10 - remainder).ToString
        Else
            checkDigit = "0"
        End If

        calcSeventhDigit = checkDigit

    End Function
End Module
