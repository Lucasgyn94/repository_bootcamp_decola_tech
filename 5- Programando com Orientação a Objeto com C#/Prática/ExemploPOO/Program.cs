using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {   
            var caminho = "c:/Users/Admin/Desktop/DigitalOne/2- Bootcamp_Decola_Tech/5- Programando com Orientação a Objeto com C#/TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            
            // helper.LerArquivosStream(caminhoArquivo);
            
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            
            // helper.CriarArquivoTexto(caminhoArquivo, "Ola, teste criando arquivo!");
           
            // helper.ApagarDiretorio(caminhoPathCombine, true);

            // helper.CriarDiretorio(caminhoPathCombine);

            // helper.ListarArquivosDiretorios(caminho);

            // helper.ListarDiretorios(caminho);

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(5, 10));
            
            // Computador comp = new Computador();
            // Console.WriteLine(comp.ToString());


            /* ToString(); = Retorna uma cadeia de caracteres 
            que representa o objeto atual
            */
            // Corrente c = new Corrente();
            // c.Creditar(50000);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(5, 5));
            // System.Console.WriteLine(calc.Somar(5, 20, 30));
            
            // Aluno a1 = new Aluno();
            // a1.Nome = "Lucas";
            // a1.Nota = 10;
            // System.Console.WriteLine();
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "Lucas Ferreira";
            // p1.Salario = 15000;
            // System.Console.WriteLine();
            // p1.Apresentar();

            // // Valores Validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // // Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Area: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "lucas";
            // p1.Idade = 27;

            // p1.Apresentar();

        }
    }
}
