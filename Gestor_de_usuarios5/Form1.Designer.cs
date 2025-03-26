namespace Gestor_de_usuarios5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.TxtBx_Telefono = new System.Windows.Forms.TextBox();
            this.TxtBx_Nombre = new System.Windows.Forms.TextBox();
            this.TxtBx_Edad = new System.Windows.Forms.TextBox();
            this.TxtBx_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.gb_Listar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Ver = new System.Windows.Forms.Button();
            this.gb_Datos.SuspendLayout();
            this.gb_Listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Codigo.Location = new System.Drawing.Point(24, 39);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(76, 24);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Codigo:";
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.Black;
            this.gb_Datos.Controls.Add(this.TxtBx_Telefono);
            this.gb_Datos.Controls.Add(this.TxtBx_Nombre);
            this.gb_Datos.Controls.Add(this.TxtBx_Edad);
            this.gb_Datos.Controls.Add(this.TxtBx_Codigo);
            this.gb_Datos.Controls.Add(this.lbl_Telefono);
            this.gb_Datos.Controls.Add(this.lbl_Nombre);
            this.gb_Datos.Controls.Add(this.lbl_Edad);
            this.gb_Datos.Controls.Add(this.lbl_Codigo);
            this.gb_Datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_Datos.ForeColor = System.Drawing.Color.LightPink;
            this.gb_Datos.Location = new System.Drawing.Point(12, 61);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(576, 139);
            this.gb_Datos.TabIndex = 1;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos";
            // 
            // TxtBx_Telefono
            // 
            this.TxtBx_Telefono.BackColor = System.Drawing.Color.Pink;
            this.TxtBx_Telefono.Location = new System.Drawing.Point(357, 89);
            this.TxtBx_Telefono.Name = "TxtBx_Telefono";
            this.TxtBx_Telefono.Size = new System.Drawing.Size(197, 30);
            this.TxtBx_Telefono.TabIndex = 7;
            // 
            // TxtBx_Nombre
            // 
            this.TxtBx_Nombre.BackColor = System.Drawing.Color.Pink;
            this.TxtBx_Nombre.Location = new System.Drawing.Point(357, 36);
            this.TxtBx_Nombre.Name = "TxtBx_Nombre";
            this.TxtBx_Nombre.Size = new System.Drawing.Size(197, 30);
            this.TxtBx_Nombre.TabIndex = 6;
            // 
            // TxtBx_Edad
            // 
            this.TxtBx_Edad.BackColor = System.Drawing.Color.Pink;
            this.TxtBx_Edad.Location = new System.Drawing.Point(96, 86);
            this.TxtBx_Edad.Name = "TxtBx_Edad";
            this.TxtBx_Edad.Size = new System.Drawing.Size(100, 30);
            this.TxtBx_Edad.TabIndex = 5;
            // 
            // TxtBx_Codigo
            // 
            this.TxtBx_Codigo.BackColor = System.Drawing.Color.LightPink;
            this.TxtBx_Codigo.Location = new System.Drawing.Point(96, 36);
            this.TxtBx_Codigo.Name = "TxtBx_Codigo";
            this.TxtBx_Codigo.Size = new System.Drawing.Size(100, 30);
            this.TxtBx_Codigo.TabIndex = 4;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Telefono.Location = new System.Drawing.Point(262, 95);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(90, 24);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Nombre.Location = new System.Drawing.Point(267, 42);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(84, 24);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre:";
            this.lbl_Nombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Edad.Location = new System.Drawing.Point(24, 92);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(60, 24);
            this.lbl_Edad.TabIndex = 1;
            this.lbl_Edad.Text = "Edad:";
            this.lbl_Edad.Click += new System.EventHandler(this.label2_Click);
            // 
            // gb_Listar
            // 
            this.gb_Listar.BackColor = System.Drawing.Color.Pink;
            this.gb_Listar.Controls.Add(this.dataGridView1);
            this.gb_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_Listar.Location = new System.Drawing.Point(12, 206);
            this.gb_Listar.Name = "gb_Listar";
            this.gb_Listar.Size = new System.Drawing.Size(582, 305);
            this.gb_Listar.TabIndex = 2;
            this.gb_Listar.TabStop = false;
            this.gb_Listar.Text = "Listar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Pink;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.Pink;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(13, 13);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 42);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Pink;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Guardar.Location = new System.Drawing.Point(94, 13);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(82, 43);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Pink;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Modificar.Location = new System.Drawing.Point(182, 13);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(95, 43);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Pink;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Eliminar.Location = new System.Drawing.Point(283, 12);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(91, 43);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Btn_Ver
            // 
            this.Btn_Ver.BackColor = System.Drawing.Color.Pink;
            this.Btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_Ver.Location = new System.Drawing.Point(380, 12);
            this.Btn_Ver.Name = "Btn_Ver";
            this.Btn_Ver.Size = new System.Drawing.Size(94, 44);
            this.Btn_Ver.TabIndex = 7;
            this.Btn_Ver.Text = "Ver";
            this.Btn_Ver.UseVisualStyleBackColor = false;
            this.Btn_Ver.Click += new System.EventHandler(this.Btn_Ver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(606, 523);
            this.Controls.Add(this.Btn_Ver);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.gb_Listar);
            this.Controls.Add(this.gb_Datos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Gestor de Usuarios";
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.gb_Listar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.GroupBox gb_Listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtBx_Codigo;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox TxtBx_Telefono;
        private System.Windows.Forms.TextBox TxtBx_Nombre;
        private System.Windows.Forms.TextBox TxtBx_Edad;
        private System.Windows.Forms.Button Btn_Ver;
    }
}

