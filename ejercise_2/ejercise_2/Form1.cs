using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void resultadobutton_Click(object sender, EventArgs e) 
        {
            

            decimal num1 = Convert.ToDecimal(nota1textBox.Text);
            decimal num2 = Convert.ToDecimal(Nota2textBox.Text);
            decimal num3 = Convert.ToDecimal(Nota3textBox.Text);
            decimal num4 = Convert.ToDecimal(nota4textBox.Text);

            decimal resultado = await totalAsync(num1, num2, num3, num4);
           
            decimal promedio;
            promedio = (num1 + num2 + num3 + num4) / 4;
            PromediotextBox.Text = promedio.ToString();
           
        }

        private async Task<decimal> totalAsync(decimal nt1, decimal nt2, decimal nt3, decimal nt4)
        {
            decimal total = await Task.Run(() =>
                {
                return (nt1 + nt2 + nt3 + nt4)/4;
            });
            return total;
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void limpiarcontroles()
        {
            nota1textBox.Clear();
            Nota2textBox.Clear();
            nota4textBox.Clear();
            Nota3textBox.Clear();
            PromediotextBox.Clear();
            MateriatextBox.Clear();


        }
    }
}
