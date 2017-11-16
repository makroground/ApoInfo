Module Module1

    Dim rdm As Random = New Random()
    Dim nochmal As Boolean = True


    Sub Main()
        While (nochmal)

            Console.WriteLine("Willkommen in meiner eigenen Konsolenanwendung.")
            Dim str As String = Console.ReadLine()
            Console.WriteLine("Deine Eingabe lautete: " + str)


            Console.WriteLine(vbNewLine + "Hier sind ein paar zufällige Zahlen für dich:")

            '' Array deklarieren/definieren
            Dim arr(999 - 1) As Integer

            '' Zufaellige Zahlen in das Array schreiben
            For i As Integer = 0 To arr.Length - 1
                arr(i) = rdm.Next(1, 100)
            Next

            '' Ausgabe der Zahlen in dem Array
            Dim cnt As Integer = 1
            For Each zahl As Integer In arr

                Dim placeHolder As String = ""

                If cnt < 10 Then
                    placeHolder = ".     "
                ElseIf cnt >= 10 And cnt < 100 Then
                    placeHolder = ".    "
                ElseIf cnt >= 100 And cnt < 1000 Then
                    placeHolder = ".   "
                ElseIf cnt >= 1000 And cnt < 10000 Then
                    placeHolder = ".  "
                ElseIf cnt >= 10000 And cnt < 100000 Then
                    placeHolder = ". "
                End If


                Console.WriteLine(CStr(cnt) + placeHolder + CStr(zahl))

                cnt += 1
            Next


            Dim verstanden As Boolean = False

            While (Not verstanden)
                Console.Write("Möchtest du noch mehr Zahlen? (ja/nein): ")
                Dim frageNochmal As String = Console.ReadLine()

                If (frageNochmal.Equals("ja")) Then
                    nochmal = True
                    verstanden = True
                ElseIf (frageNochmal.Equals("nein")) Then
                    nochmal = False
                    verstanden = True
                Else
                    Console.WriteLine("Ich konnte dich nicht verstehen :(")
                End If
            End While


            Console.WriteLine(vbNewLine + vbNewLine + vbNewLine)




        End While

    End Sub



End Module
