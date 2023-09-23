using Microsoft.EntityFrameworkCore;
using SagitarioRH.Models;
using SagitarioRHDesktop.Data;
using SagitarioRHDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SagitarioRHDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
           

            MenuPrincipal menuPrincipal = new MenuPrincipal();
           


            AdministradorModel administradorModel = new AdministradorModel();
            administradorModel.usuario = txtUsuario.Text;
            administradorModel.senha = txtSenha.Text;








            var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
            optionsBuilder.UseNpgsql("Host=berry.db.elephantsql.com ;Database=cclcbiwm;Username=cclcbiwm;Password=EP_X_koFmXeUspco84FYTUILWgPptiJ_;");




                using (var context = new BancoContext(optionsBuilder.Options))
            {
              
                var administrador = await context.administradores.FirstOrDefaultAsync(a => a.usuario == administradorModel.usuario && a.senha == administradorModel.senha);
                 
                if (administrador != null)
                {

                   
                    
                    menuPrincipal.Show();
                    this.Hide();

                }
                else
                {
                   
                    MessageBox.Show("Nome de usuário ou senha incorretos.");
                }
            }
        }
    }
}
