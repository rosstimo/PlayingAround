Imports System.Drawing
Imports System.Windows.Forms
Module PlayingAround

    Sub Main()

        'DisplayArray(LoadArray())
        'Math.PI
        'TestLists()
        'SplitToArray()
        test()
        Console.Read()
    End Sub

    Function LoadArray() As Integer(,)
        Dim count As Integer
        Dim values(4, 19) As Integer

        For row = 0 To 19
            For column = 0 To 4
                'Console.Write($"({row},{column})")
                values(column, row) = count
                count += 1
            Next
            'Console.WriteLine() '$" Row is {row}")
        Next

        LoadArray = values
    End Function

    Sub DisplayArray(ByRef values(,) As Integer)

        'For row = 0 To 19
        '    For column = 0 To 4
        '        Console.Write(CStr(values(column, row)).PadLeft(4))
        '    Next
        '    Console.WriteLine()
        'Next

        'For Each value In values
        Dim width%
        Try
            For i = 0 To 20
                width = i
                values.GetLength(i)
            Next
        Catch
        End Try
        Console.WriteLine(width)
        Console.WriteLine(UBound(values))
        'Next
    End Sub

    Sub TestLists()

        Dim names As New List(Of String)

        names.Add("Joe")
        names.Add("Tim")
        names.Add("Frank")
        names.Add("Mary")
        names.Add("Sally")

        Console.WriteLine(names.Count)
        names.Insert(3, "Bill")
        Console.WriteLine(names.Item(3))
        Console.WriteLine(names.Contains("Jimmy"))

        For Each name In names
            Console.WriteLine(name)
            Console.WriteLine(names.IndexOf(name))
        Next

    End Sub

    Sub SplitToArray()
        Dim textArray() As String
        Dim userInput As String = "Hello, World"
        Dim userInfo As String = "Bob,Moore,123 Blueberry Ln.,Pocatello,ID,83204"
        'textArray = Split(userInput, ", ")
        textArray = Split(userInfo, ",")
        'Console.WriteLine("First Name: ".PadLeft(15) & textArray(0) & vbNewLine &
        '                  "Last Name: ".PadLeft(15) & textArray(1) & vbNewLine &
        '                  "Street Number: ".PadLeft(15) & textArray(2) & vbNewLine &
        '                  "City: ".PadLeft(15) & textArray(3) & vbNewLine &
        '                  "State: ".PadLeft(15) & textArray(4) & vbNewLine &
        '                  "Zip: ".PadLeft(15) & textArray(5) & vbNewLine)

        For Each letter As Char In userInput
            Console.WriteLine(letter)
        Next

        For Each record As String In textArray
            Console.WriteLine(record)
        Next

        Console.Read()

    End Sub


    Function ResistancParralell(ByVal branchOne As Double, ByVal branchTwo As Double) As Double
        Return (branchOne ^ -1 + branchTwo ^ -1) ^ -1
    End Function

    Function ResistancParralell(ByVal branches As List(Of Double)) As Double
        Dim temp As Double
        temp = branches.Item(0)
        For branch = 1 To branches.Count - 1
            temp = ResistancParralell(temp, branches.Item(branch))
        Next
        Return temp
    End Function

    Sub test()
        Dim branches As New List(Of Double)


        'For i = 1 To 100
        branches.Add(2)
        branches.Add(1000000)
        branches.Add(5.1 * 10 ^ 3)
        branches.Add(37000)
        branches.Add(500000)
        branches.Add(50000)



        'Next


        'Console.WriteLine(ResistancParralell(1000, 1000))
        Console.WriteLine(ResistancParralell(branches))
        'Dim branchArray = branches.ToArray()
        'Dim temp As Double
        ''temp = branch
        'temp = branches.Item(0)

        'For branch = 1 To branches.Count - 1
        '    temp = ResistancParralell(temp, branches.Item(branch))
        '    'Console.WriteLine(temp)
        'Next

        'Console.WriteLine(temp)

    End Sub

End Module
