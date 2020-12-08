using System;
using ENCAPSULAMENTO.Classes;

namespace ENCAPSULAMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Marcos Vinicius Silva De Jesus";
            m.Numero = "10112003";
            m.Bandeira = "Visa";

            Console.WriteLine($" o Titular {m.NomeTitular} - Tem o Token: {m.Token} - e sua bandeira é : {m.Bandeira}");
        }
    }
}
