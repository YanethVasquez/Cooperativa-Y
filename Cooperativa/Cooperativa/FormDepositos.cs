using BL.Cooperativa;
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
    public partial class FormDepositos : Form
    {
        DepositosBL _depositos;

        public FormDepositos()
        {
            InitializeComponent();

            _depositos = new DepositosBL();
            listaDepositosBindingSource.DataSource = _depositos.ObtenerDepositos();
        }

        private void FormDepositos_Load(object sender, EventArgs e)
        {

        }
    }
}
