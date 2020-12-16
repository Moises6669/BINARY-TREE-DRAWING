using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_Moises_Masis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCantClientes.Focus();
            CamposInavilitados();
        }
        // Declaración de variables a utilizar
        double Dato = 0;
        int descontador = 0;
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); // Creación del objeto Árbol
        Graphics g; // Definición del objeto gráfico
        int cantidad;
        int i;

        //Cracion de metodo de Estrucutra para Almacenar Datos requeridos
        public struct Factura
        {
            public string cliente { get; set; }
            public double total { get; set; }
            public double comida { get; set; }
            public double bebida { get; set; }
            public double postre { get; set; }
            public double propina { get; set; }
        }

        Factura[] registro;

        public void Cantidad()
        {
            try
            {
                cantidad = Convert.ToInt32(txtCantClientes.Text);

                if (cantidad < 0)
                {
                    MessageBox.Show("Cantidad ingresada no valida");
                }
                else
                {
                    registro = new Factura[cantidad];
                    descontador = cantidad;
                    MessageBox.Show("Ingrese los preciosos de cada pructo");
                    groupBoxDatos.Enabled = true;
                    groupBox1.Enabled = false;
                    txtCliente.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor ingrese una cantidad","Importante",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //--**Funcion que Permite que El Arbol se Dibuje**--
        private void Form1_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint =
            System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black,
            Brushes.White);
        }

        void LimpiaCampos()
        {
            txtBebida.Clear();
            txtCliente.Clear();
            txtComida.Clear();
            txtPostre.Clear();
            txtPropina.Clear();
        }

        void CamposInavilitados()
        {
            groupBoxElimar.Enabled = false;
            groupBoxDatos.Enabled = false;
            dataGridView1.Enabled = false;
            groupBox2.Enabled = false;
        }
        private void btnCantidad_Click_1(object sender, EventArgs e)
        {
            Cantidad();
        }

        private void btnGuardaDatos_Click_1(object sender, EventArgs e)
        {
            //Vriables para sacar el total + IVA
            double PORCENTAJE_IVA = 16;
            double precio_total;
            double aumento;

            if (i == cantidad)
            {
                MessageBox.Show("Ya no puede ingresar mas elementos");
            }
            else
            {
                registro[i].cliente = txtCliente.Text;
                registro[i].comida = double.Parse(txtComida.Text);
                registro[i].bebida = double.Parse(txtBebida.Text);
                registro[i].postre = double.Parse(txtPostre.Text);

                //Formulas para Sacar el Total + Iva
                precio_total = (registro[i].comida + registro[i].bebida + registro[i].postre + registro[i].propina);
                aumento = precio_total * (PORCENTAJE_IVA / 100);
                registro[i].total = (precio_total + aumento);

                dataGridView1.Rows.Add(registro[i].cliente, registro[i].total);
                mi_Arbol.Insertar(registro[i].total);
                Refresh();
                LimpiaCampos();
                txtCliente.Focus();

                i++;
            }

            descontador--;


            if (descontador == 0)
            {
                groupBox2.Enabled = true;
                MessageBox.Show("Si desea eliminar un Dato por favor utilice  Coma (,) en lugar de Punto (.)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBoxElimar.Enabled = true;
                dataGridView1.Enabled = true;
                txtEliminar.Focus();
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtEliminar.Text == String.Empty)
                {
                    MessageBox.Show("ingresar un Valor Por favor");
                }
                else
                {
                    Dato = double.Parse(txtEliminar.Text);
                    int index;

                    for (int i = 0; i < registro.Length; i++)
                    {
                        if (registro[i].total == Dato)
                        {
                            /*Nos permite saber el indice de la fila
                             en el DataGridView y asi poder eliminar
                            y actualizar la Tabla desde cualquier posicion
                            en que se encuentre*/
                            index = dataGridView1.CurrentRow.Index;
                            dataGridView1.Rows.RemoveAt(index);
                            Refresh();
                        }

                    }

                    mi_Arbol.Eliminar(Dato);
                    txtEliminar.Clear();
                    Refresh();
                    MessageBox.Show($"Dato : {Dato} eliminado Correctamente ");

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            groupBox1.Enabled = true;
            txtCantClientes.Clear();
            txtCantClientes.Focus();
            CamposInavilitados();
            cantidad = 0;
            i = 0;
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            mi_Arbol.reccorridoPre();
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            mi_Arbol.reccorridoIn();
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            mi_Arbol.reccorridoPos();
        }
    }
}
