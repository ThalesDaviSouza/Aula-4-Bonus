using System;
using App.Conta;

namespace App{
    class Progam {
      static void Main(string[] args) {
        Banco b1 = new Banco(206156155, "Thales", "Deluxe", 10000000, 25000);
        Banco b2 = new Banco(231651465, "Bongo", "Deluxe", 10000000, 25000);
        Console.WriteLine(b1);
        Console.WriteLine(b2);
        
        if(b1.transfer(b2, 5000)){
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }else{
            Console.WriteLine("Algo deu ruim!");
        }
        
      }
    }
}
