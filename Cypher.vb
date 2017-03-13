
Public Class Cypher
	Public Shared p As Char() = {"a"C, "b"C, "c"C, "d"C, "e"C, "f"C, _
		"g"C, "h"C, "i"C, "j"C, "k"C, "l"C, _
		"m"C, "n"C, "o"C, "p"C, "q"C, "r"C, _
		"s"C, "t"C, "u"C, "v"C, "w"C, "x"C, _
		"y"C, "z"C}
	Public Shared ch As Char() = {"Q"C, "W"C, "E"C, "R"C, "T"C, "Y"C, _
		"U"C, "I"C, "O"C, "P"C, "A"C, "S"C, _
		"D"C, "F"C, "G"C, "H"C, "J"C, "K"C, _
		"L"C, "Z"C, "X"C, "C"C, "V"C, "B"C, _
		"N"C, "M"C}
	Public Shared regex As New Regex("[-+.^@_:,]")

	Public Shared Function doEncryption(s As String) As String
		'try to remove some special characters from the string as this cypher is not equipped for symbols
		s = regex.Replace(s, "")
		Dim c As Char() = New Char(s.Length - 1) {}
		For i As Integer = 0 To s.Length - 1
			For j As Integer = 0 To 25
				If p(j) = Char.ToLower(s.ElementAt(i)) Then
					c(i) = ch(j)
					Exit For
				End If
			Next
		Next
		Return (New String(c))
	End Function

	Public Shared Function doDecryption(s As String) As String
		Dim p1 As Char() = New Char(s.Length - 1) {}
		For i As Integer = 0 To s.Length - 1
			For j As Integer = 0 To 25
				If ch(j) = s.ElementAt(i) Then
					p1(i) = p(j)
					Exit For
				End If
			Next
		Next
		Return (New String(p1))
	End Function
End Class