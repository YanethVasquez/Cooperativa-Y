using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cooperativa
{
    public class DepositosBL
    {
        public BindingList<Deposito> ListaDepositos { get; set; }

        public DepositosBL()
        {
            ListaDepositos = new BindingList<Deposito>();

            var deposito1 = new Deposito();
            deposito1.Id = 1;
            deposito1.Nombre = "Juancho";
            deposito1.Cantidad = 5000;
            deposito1.Ncuenta = 1503;
            deposito1.Tcuenta = true;

            ListaDepositos.Add(deposito1);

            var deposito2 = new Deposito();
            deposito2.Id = 2;
            deposito2.Nombre = "Pedrito";
            deposito2.Cantidad = 60000;
            deposito2.Ncuenta = 0511;
            deposito2.Tcuenta = true;

            ListaDepositos.Add(deposito2);

            var deposito3 = new Deposito();
            deposito3.Id = 3;
            deposito3.Nombre = "Juanita";
            deposito3.Cantidad = 350;
            deposito3.Ncuenta = 0102;
            deposito3.Tcuenta = true;

            ListaDepositos.Add(deposito3);
        }
        
        public BindingList<Deposito> ObtenerDepositos()
        {
            return ListaDepositos; 
        }
    }

    public class Deposito
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public int Ncuenta { get; set; }
        public bool Tcuenta { get; set; }
    }
}
