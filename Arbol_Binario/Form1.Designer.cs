namespace Arbol_Binario_Moises_Masis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.txtCantClientes = new System.Windows.Forms.TextBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtPropina = new System.Windows.Forms.TextBox();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardaDatos = new System.Windows.Forms.Button();
            this.txtBebida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxElimar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPreorden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxElimar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(114, 45);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 2;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(47, 71);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clie,
            this.to});
            this.dataGridView1.Location = new System.Drawing.Point(661, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 361);
            this.dataGridView1.TabIndex = 4;
            // 
            // clie
            // 
            this.clie.HeaderText = "Cliente";
            this.clie.Name = "clie";
            // 
            // to
            // 
            this.to.HeaderText = "Total a Pagar";
            this.to.Name = "to";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCantidad);
            this.groupBox1.Controls.Add(this.txtCantClientes);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(49, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code Light", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de CLientes";
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidad.ForeColor = System.Drawing.Color.White;
            this.btnCantidad.Location = new System.Drawing.Point(55, 68);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(75, 23);
            this.btnCantidad.TabIndex = 6;
            this.btnCantidad.Text = "AGREGAR";
            this.btnCantidad.UseVisualStyleBackColor = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click_1);
            // 
            // txtCantClientes
            // 
            this.txtCantClientes.Location = new System.Drawing.Point(46, 42);
            this.txtCantClientes.Name = "txtCantClientes";
            this.txtCantClientes.Size = new System.Drawing.Size(100, 20);
            this.txtCantClientes.TabIndex = 6;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtPropina);
            this.groupBoxDatos.Controls.Add(this.txtPostre);
            this.groupBoxDatos.Controls.Add(this.label7);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.btnGuardaDatos);
            this.groupBoxDatos.Controls.Add(this.txtBebida);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.txtComida);
            this.groupBoxDatos.Controls.Add(this.txtCliente);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Location = new System.Drawing.Point(45, 466);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(245, 291);
            this.groupBoxDatos.TabIndex = 6;
            this.groupBoxDatos.TabStop = false;
            // 
            // txtPropina
            // 
            this.txtPropina.Location = new System.Drawing.Point(87, 185);
            this.txtPropina.Name = "txtPropina";
            this.txtPropina.Size = new System.Drawing.Size(135, 20);
            this.txtPropina.TabIndex = 12;
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(88, 144);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.Size = new System.Drawing.Size(135, 20);
            this.txtPostre.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fira Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Propina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Postre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bebida:";
            // 
            // btnGuardaDatos
            // 
            this.btnGuardaDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnGuardaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaDatos.ForeColor = System.Drawing.Color.White;
            this.btnGuardaDatos.Location = new System.Drawing.Point(19, 237);
            this.btnGuardaDatos.Name = "btnGuardaDatos";
            this.btnGuardaDatos.Size = new System.Drawing.Size(185, 30);
            this.btnGuardaDatos.TabIndex = 3;
            this.btnGuardaDatos.Text = "Guardar";
            this.btnGuardaDatos.UseVisualStyleBackColor = false;
            this.btnGuardaDatos.Click += new System.EventHandler(this.btnGuardaDatos_Click_1);
            // 
            // txtBebida
            // 
            this.txtBebida.Location = new System.Drawing.Point(88, 103);
            this.txtBebida.Name = "txtBebida";
            this.txtBebida.Size = new System.Drawing.Size(135, 20);
            this.txtBebida.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comida:";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(88, 65);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(135, 20);
            this.txtComida.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(87, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(136, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // groupBoxElimar
            // 
            this.groupBoxElimar.Controls.Add(this.button1);
            this.groupBoxElimar.Controls.Add(this.label3);
            this.groupBoxElimar.Controls.Add(this.txtEliminar);
            this.groupBoxElimar.Controls.Add(this.btneliminar);
            this.groupBoxElimar.ForeColor = System.Drawing.Color.White;
            this.groupBoxElimar.Location = new System.Drawing.Point(308, 495);
            this.groupBoxElimar.Name = "groupBoxElimar";
            this.groupBoxElimar.Size = new System.Drawing.Size(328, 105);
            this.groupBoxElimar.TabIndex = 8;
            this.groupBoxElimar.TabStop = false;
            this.groupBoxElimar.Text = "Recorrido y Eliminacion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(191, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar Todo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code Light", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inserte precio a Eliminar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPostOrden);
            this.groupBox2.Controls.Add(this.btnInOrden);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnPreorden);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(335, 614);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnPostOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostOrden.ForeColor = System.Drawing.Color.White;
            this.btnPostOrden.Location = new System.Drawing.Point(195, 46);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrden.TabIndex = 9;
            this.btnPostOrden.Text = "PosOrden";
            this.btnPostOrden.UseVisualStyleBackColor = false;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnInOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOrden.ForeColor = System.Drawing.Color.White;
            this.btnInOrden.Location = new System.Drawing.Point(109, 46);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(75, 23);
            this.btnInOrden.TabIndex = 8;
            this.btnInOrden.Text = "INorden";
            this.btnInOrden.UseVisualStyleBackColor = false;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fira Code Light", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Recorridos";
            // 
            // btnPreorden
            // 
            this.btnPreorden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnPreorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreorden.ForeColor = System.Drawing.Color.White;
            this.btnPreorden.Location = new System.Drawing.Point(20, 46);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(75, 23);
            this.btnPreorden.TabIndex = 6;
            this.btnPreorden.Text = "PreOrden";
            this.btnPreorden.UseVisualStyleBackColor = false;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(948, 783);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxElimar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxElimar.ResumeLayout(false);
            this.groupBoxElimar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clie;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.TextBox txtCantClientes;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button btnGuardaDatos;
        private System.Windows.Forms.TextBox txtBebida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPropina;
        private System.Windows.Forms.TextBox txtPostre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxElimar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPreorden;
    }
}

