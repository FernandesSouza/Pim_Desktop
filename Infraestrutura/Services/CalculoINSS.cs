using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SagitarioRH.Models;
using SagitarioRHDesktop.Data;
using SagitarioRHDesktop.Infraestrutura.Interfaces;
using SagitarioRHDesktop.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagitarioRHDesktop.Infraestrutura.Services
{
    internal class CalculoINSS : ICalculoINSS
    {


        public void CalculoInSS(FuncionarioModel funcionarioModel)
        {

            decimal aliquota1 = 0.08m;
            decimal aliquota2 = 0.09m;
            decimal aliquota3 = 0.12m;
            decimal aliquota4 = 0.14m;
            decimal valor1 = 1320.00m;
            decimal valor2 = 2571.29m;
            decimal valor3 = 3856.94m;
            decimal SalarioINSS;
           
           

            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com ;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");

            using (var context = new BancoContext(optionsBuilder.Options))
            {
               

                DateTime today = DateTime.Today;
                DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                
                var query = context.funcionarios
                    .Where(e => !context.folhaPgto.Any(f => f.datapgto >= firstDayOfMonth && f.matfuncionario == e.matricula))
                    .ToList();


                foreach (var item in query)
                {
                    if (item != null)
                    {
                        FolhaPgtoModel folhaPagamento = new FolhaPgtoModel();

                        if (item.salario <= valor1)
                        {
                            SalarioINSS = item.salario * aliquota1;
                        }
                        else if (item.salario <= valor2)
                        {
                            SalarioINSS = item.salario * aliquota2;
                        }
                        else if (item.salario <= valor3 )
                        {
                            SalarioINSS = item.salario * aliquota3;
                        }
                        else
                        {
                            SalarioINSS = item.salario * aliquota4;
                        }

                        folhaPagamento.nome = item.nome;
                        folhaPagamento.funcao = item.funcao;
                        folhaPagamento.valor = item.salario - SalarioINSS;
                        folhaPagamento.matfuncionario = item.matricula;
                        folhaPagamento.idempresa = item.idempresa;
                        folhaPagamento.cpf = item.cpf;
                        folhaPagamento.datapgto = DateTime.Now;
                        folhaPagamento.setor = item.setor;
                        context.folhaPgto.Add(folhaPagamento);

                    }
                }
                
                context.SaveChanges();




            }
        }
    }
}
