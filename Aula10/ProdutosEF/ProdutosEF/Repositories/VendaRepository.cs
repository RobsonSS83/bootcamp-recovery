﻿using ProdutosEF.Dtos;
using ProdutosEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosEF.Repositories
{
    interface VendaRepository
    {
        void Salvar(Venda venda);
        void Atualizar(Venda venda);
        List<VendaPorUsuarioDto> ObterVendasPorUsuario();
    }
}
