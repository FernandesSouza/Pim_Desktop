using SagitarioRH.Models;
using SagitarioRHDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagitarioRHDesktop.Infraestrutura.Interfaces
{
    internal interface ICalculoINSS
    {

        public void CalculoInSS(FuncionarioModel funcionarioModel, ImpostoINSSModel iNSSModel,EventosModel eventosModel);
    }
}
