﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntendendoOO.Models
{
    // Produto Alimento, 25.80, 31/12/2021, Carne de Acem, Acem
    // Produto Higiene, 7.35, 31/12/2022, Creme dental gel, creme dental
    class Produto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Validade { get; private set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string tipo, decimal valor, DateTime validade, string descricao, string nome)
        {
            Id = id;
            Tipo = tipo;
            Valor = valor;
            Validade = validade;
            Descricao = descricao;
            Nome = nome;
        }

        public bool IsProdutoValido()
        {
            return Validade > DateTime.Now;
        }

        public void AtualizarDataValidade(DateTime novaData)
        {
            Validade = novaData;
        }
    }
}
