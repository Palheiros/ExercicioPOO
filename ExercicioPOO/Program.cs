using ExercicioPOO.Helper;
using ExercicioPOO.Interfaces;
using ExercicioPOO.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Irineu";
            pessoa.Idade = 50;
            pessoa.Apresentar();

            Console.WriteLine();

            Aluno a1 = new Aluno();
            a1.Nome = "Bob";
            a1.Idade = 20;
            a1.Nota = 8;
            a1.Apresentar();

            Console.WriteLine();

            Professor p1 = new Professor();
            p1.Nome = "Ricardo";
            p1.Idade = 45;
            p1.Salario = 3500;
            p1.Apresentar();

            Console.WriteLine();

            Corrente corrente = new Corrente();
            corrente.Creditar(1000);
            corrente.ExibirSaldo();

            Console.WriteLine();

            Icalculadora calc = new Calculadora();
            Console.WriteLine($"Somando 10 + 10 = {calc.Somar(10,10)}");
            Console.WriteLine($"Subtraindo 10 de 10 = {calc.Subtrair(10,10)}");
            Console.WriteLine($"Multiplicando 10 por 10 = {calc.Multiplicar(10,10)}");
            Console.WriteLine($"Dividindo 10 por 10 = {calc.Dividir(10,10)}");
            Console.WriteLine($"Somando 10 + 10 + 10 (método implementado na Interface com 3 parâmetros) = {calc.Soma3(10,10,10)}");

            Console.WriteLine();

            Console.WriteLine("Diretórios:");
            string caminho = "C:\\Users\\Ricardo\\Desktop\\Projetos Visual Studio\\ExercicioPOO\\TrabalhandoComArquivos";
            string caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "Subpasta Teste 3");
            string caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            
            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);
            Console.WriteLine();

            Console.WriteLine("Arquivos:");
            helper.ListarArquivosDiretorios(caminho);
            Console.WriteLine();

            Console.WriteLine("Criando Diretórios:");
            helper.CriarDiretorio(caminhoPathCombine);
            Console.WriteLine();

            // Console.WriteLine("Apagando os Diretórios");
            // helper.ApagarDiretorio(caminhoPathCombine, true);

            Console.WriteLine("Criando arquivo com texto de apresentação...");
            helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo \n");
            Console.WriteLine();

            Console.WriteLine("Adicionando mais texto sem sobrescrever...");
            helper.AdicionarTexto(caminhoArquivo, "Adicionando mais texto\n");
            Console.WriteLine();

            Console.WriteLine("Lendo o arquivo por stream...");
            helper.LerArquivoStream(caminhoArquivo);
        }
    }
}
