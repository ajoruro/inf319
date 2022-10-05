// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

module matematica=
    let suma a b =a+b
    let resta a b =a-b
    let multi a b =a*b
    
    let divide x y = x/y
       
         

[<EntryPoint>]
let main argv = 
    
    Console.WriteLine("introduzca dos numeros")
    let a=Convert.ToInt32(Console.ReadLine())
    let b=Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("la suma de ambos numeros es igual a:  "+(matematica.suma a b ).ToString())
    Console.WriteLine("la resta e ambos numeros es igual a:  "+(matematica.resta a b ).ToString())
    Console.WriteLine("la multiplicacion de ambos numeros es igual a:  "+(matematica.multi a b ).ToString())
    if b=0 then Console.WriteLine("no hay division entre 0") else Console.WriteLine("la division es igual a:  "+(matematica.divide a b ).ToString())

        
    
    let tecla=Console.ReadKey()
    0 // devolver un código de salida entero