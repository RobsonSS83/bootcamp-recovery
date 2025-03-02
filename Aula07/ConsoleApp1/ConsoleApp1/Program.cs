﻿using ConsoleApp1.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static string conexao;

        static void Main(string[] args)
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
                var configuration = builder.Build();
                conexao = configuration["ConnectionStrings:DefaultConnection"];

                if (string.IsNullOrEmpty(conexao) || string.IsNullOrWhiteSpace(conexao))
                {
                    Console.WriteLine("Arquivo de configuracao (appSettings) nao foi encontrado na pasta de binario");
                    return;
                }

                Console.WriteLine("Informe qual operacao voce quer realizar no banco: (1 - select, 2 - create, 3 - update e 4 - delete)");
                var opcaoStr = Console.ReadLine();
                var opcao = int.Parse(opcaoStr);

                var service = new DapperService(conexao);

                switch (opcao)
                {
                    case 1:
                        service.ConsultarLinhas();
                        break;
                    case 2:
                        service.CriarAluno();
                        break;
                    case 3:
                        service.AtualizarAluno();
                        break;
                    case 4:
                        service.RemoverAluno();
                        break;
                    default:
                        Console.WriteLine("Opcao informada nao e valida, tente novamente!");
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Voce informou um numero invalido, tente novamente!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Voce informou um numero invalido, tente novamente!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu erro ao processar dados via Dapper: " + e.Message);
            }
            
            
        }
    }
}
