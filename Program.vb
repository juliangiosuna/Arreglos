Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Console.WriteLine("Ingrese un numero del 1 - 10 para mirar los ejercicios")
        opcion = Console.ReadLine

        Select Case opcion
            Case 1
                Primero()
            Case 2
                Segundo()
            Case 3
                Tercero()
            Case 4
                Cuarto()
            Case 5
                Quinto()
            Case 6
                Sexto()
            Case 7
                Septimo()
            Case 8
                Octavo()
            Case 9
                Noveno()
            Case 10
                Decimo()


        End Select
    End Sub
    Sub Primero()
        Dim arreglo As Integer

        Do
            Console.WriteLine("ingrese el tamaño del array")
            Console.WriteLine("El tamaño del array unidimensional debe ser mayor a 2")
            arreglo = Console.ReadLine()
            If (arreglo <= 2) Then
                Console.WriteLine("ingrese un numero mayor a 2")
            End If

        Loop Until arreglo > 2

        Dim cont As Integer

        Dim myArray(arreglo) As Double

        For i = 0 To myArray.GetUpperBound(0) - 1 Step 1
            myArray(i) += cont + 2
            cont += 2

        Next

        For i = 0 To myArray.GetUpperBound(0) - 1 Step 1
            Console.WriteLine(myArray(i))
        Next

    End Sub
    Sub Segundo()
        Dim arreglo As Integer

        Do
            Console.WriteLine("ingrese el tamaño del array")
            Console.WriteLine("El tamaño del array unidimensional debe ser mayor a 2")
            arreglo = Console.ReadLine()
            If (arreglo <= 2) Then
                Console.WriteLine("ingrese un numero mayor a 2")
            End If

        Loop Until arreglo > 2

        Dim multiplicador As Integer
        Console.WriteLine("Ingrese el numero multiplicador")
        multiplicador = Console.ReadLine()

        Dim myArray(arreglo) As Double

        For i = 0 To myArray.GetUpperBound(0) - 1
            myArray(i) += multiplicador * (i + 1)

        Next

        For i = 0 To myArray.GetUpperBound(0) - 1 Step 1
            Console.WriteLine(myArray(i))
        Next
    End Sub
    Sub Tercero()
        Dim arreglo As Integer

        Do
            Console.WriteLine("ingrese el tamaño del array")
            Console.WriteLine("El tamaño del array unidimensional debe ser mayor a 2")
            arreglo = Console.ReadLine()
            If (arreglo <= 2) Then
                Console.WriteLine("ingrese un numero mayor a 2")
            End If

        Loop Until arreglo > 2
        Dim matriz(arreglo, arreglo) As Integer
        Dim cont As Integer
        cont = 1
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = cont
                cont += 2
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub Cuarto()
        Dim arreglo As Integer

        Do
            Console.WriteLine("ingrese el tamaño del array")
            Console.WriteLine("El tamaño del array unidimensional debe ser mayor a 2")
            arreglo = Console.ReadLine()
            If (arreglo <= 2) Then
                Console.WriteLine("ingrese un numero mayor a 2")
            End If

        Loop Until arreglo > 2

        Dim multiplicador As Integer
        Console.WriteLine("Ingrese el numero multiplicador")
        multiplicador = Console.ReadLine()
        Dim matriz(arreglo, arreglo) As String
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                matriz(i, j) = multiplicador * i & "," & multiplicador * j
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub Quinto()

        Dim matriz(4, 4) As String
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                If (i = j) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub Sexto()

        Dim matriz(4, 4) As String
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                If (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub Septimo()
        Dim matriz(4, 4) As String
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                If (i = j) Then
                    matriz(i, j) = 0
                ElseIf (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = 0
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub Octavo()

        Dim matriz(4, 4) As String
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1) And (j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub Noveno()

        Dim matriz(4, 4) As String
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1 Or j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = " "
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1
            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub Decimo()
        Console.Write(" Profe lo siento no lo logre hacer :( ")
    End Sub
End Module
