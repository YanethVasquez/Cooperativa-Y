using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooperativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNoCuenta = new FormNoCuenta();
            formNoCuenta.MdiParent = this;
            formNoCuenta.Show();  
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formlogin = new Login();
            formlogin.ShowDialog();   
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSaldoDisp = new FormSaldoDisp();
            formSaldoDisp.MdiParent = this;
            formSaldoDisp.Show();   
              
        }

        private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDepositos = new FormDepositos();
            formDepositos.MdiParent = this;
            formDepositos.Show();   
        }

        private void retirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRetiros = new FormRetiros();
            formRetiros.MdiParent = this;
            formRetiros.Show();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var formLogin = new Login();
            formLogin.ShowDialog();     
        }
    }
}
