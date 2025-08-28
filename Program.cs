
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LanchonetePro
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaLanchonete sistema = new SistemaLanchonete();
            sistema.MenuPrincipal();
        }
    }
}
