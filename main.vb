' 
' Welcome to GDB Online.
' GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
' C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
' Code, Compile, Run and Debug online from anywhere in world.
' 
' 
Module VBModule
    Sub Main()
        Dim MostrarDatos As New MostrarDatos(502)
        MostrarDatos.Mostrar()
        MostrarDatos.Comidas("Arroz", "Habichuelas", 4)
        
        MostrarDatos.m1 = 90.63855
        Console.WriteLine(MostrarDatos.m1)
        
        Dim Alimentos As New Alimentos
        
        Alimentos.m1 = 120
        
        Alimentos.Mostrar()
        
         Console.WriteLine(Alimentos.R)
         
         Console.WriteLine(Calc.A)
    End Sub
    
    
End Module


Public Class MostrarDatos 
    
    Private _m1 As Double
    
    Public Property m1() As Double
    Get 
        Return _m1
    End Get
    
    Set (value As Double)
    _m1 = value
    End Set
    
    End Property
    
    Dim _m3 As Integer
    Public Sub New (m3 As Integer)
        _m3 = m3
    End Sub
    
    Sub Mostrar()
    Console.WriteLine("Mostrrado" & _m3)
    End Sub
    
    Function Comidas(Arroz As String, Habi As String, Carne As Integer)
        If Arroz = "Arroz" And Habi = "Habichuelas" And Carne = 5 Then
            Console.WriteLine("Bandera Dominicana")
        Else
            Console.WriteLine("Comida Tailandesa")
        End If
    End Function
End Class


Public Class Alimentos
    Inherits MostrarDatos
    
    Public Shared R As Integer = 5066
    
    Public Sub New ()
        
    End Sub
    
    Public Overloads Sub Mostrar()
        MyBase.Mostrar()
        Console.WriteLine("Muestra Todos los alimentos disponibles")
    End Sub
    
End Class

Module Calc
 Public Dim A As String = 54
End Module




