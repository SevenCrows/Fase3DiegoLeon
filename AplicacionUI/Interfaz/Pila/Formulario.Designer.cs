
namespace AplicacionUI.Interfaz.Pila
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardar_pila = new System.Windows.Forms.Button();
            this.lb_estrato = new System.Windows.Forms.Label();
            this.lb_canal = new System.Windows.Forms.Label();
            this.lb_ubicacion = new System.Windows.Forms.Label();
            this.cb_canal = new System.Windows.Forms.ComboBox();
            this.cb_ubicacion = new System.Windows.Forms.ComboBox();
            this.cb_estrato = new System.Windows.Forms.ComboBox();
            this.lb_formulario = new System.Windows.Forms.Label();
            this.lb_identificacion = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Label();
            this.btn_iniciar_pila = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_registros_actuales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ep_identificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_estrato = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_ubicacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_canal = new System.Windows.Forms.ErrorProvider(this.components);
            this.grid_view_pila = new System.Windows.Forms.DataGridView();
            this.pilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_identificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_estrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_canal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_pila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_guardar_pila);
            this.panel1.Controls.Add(this.lb_estrato);
            this.panel1.Controls.Add(this.lb_canal);
            this.panel1.Controls.Add(this.lb_ubicacion);
            this.panel1.Controls.Add(this.cb_canal);
            this.panel1.Controls.Add(this.cb_ubicacion);
            this.panel1.Controls.Add(this.cb_estrato);
            this.panel1.Controls.Add(this.lb_formulario);
            this.panel1.Controls.Add(this.lb_identificacion);
            this.panel1.Controls.Add(this.txt_identificacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 592);
            this.panel1.TabIndex = 0;
            // 
            // btn_guardar_pila
            // 
            this.btn_guardar_pila.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guardar_pila.FlatAppearance.BorderSize = 0;
            this.btn_guardar_pila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.btn_guardar_pila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(3)))), ((int)(((byte)(10)))));
            this.btn_guardar_pila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_pila.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pila.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_pila.Location = new System.Drawing.Point(0, 524);
            this.btn_guardar_pila.Name = "btn_guardar_pila";
            this.btn_guardar_pila.Size = new System.Drawing.Size(307, 68);
            this.btn_guardar_pila.TabIndex = 33;
            this.btn_guardar_pila.Text = "Guardar";
            this.btn_guardar_pila.UseVisualStyleBackColor = true;
            this.btn_guardar_pila.Click += new System.EventHandler(this.btn_guardar_pila_Click);
            // 
            // lb_estrato
            // 
            this.lb_estrato.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estrato.ForeColor = System.Drawing.Color.White;
            this.lb_estrato.Location = new System.Drawing.Point(48, 190);
            this.lb_estrato.Name = "lb_estrato";
            this.lb_estrato.Size = new System.Drawing.Size(223, 21);
            this.lb_estrato.TabIndex = 32;
            this.lb_estrato.Text = "* Estrato\r\n";
            this.lb_estrato.UseCompatibleTextRendering = true;
            // 
            // lb_canal
            // 
            this.lb_canal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_canal.ForeColor = System.Drawing.Color.White;
            this.lb_canal.Location = new System.Drawing.Point(48, 366);
            this.lb_canal.Name = "lb_canal";
            this.lb_canal.Size = new System.Drawing.Size(223, 22);
            this.lb_canal.TabIndex = 31;
            this.lb_canal.Text = "* Canal\r\n";
            this.lb_canal.UseCompatibleTextRendering = true;
            // 
            // lb_ubicacion
            // 
            this.lb_ubicacion.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ubicacion.ForeColor = System.Drawing.Color.White;
            this.lb_ubicacion.Location = new System.Drawing.Point(48, 276);
            this.lb_ubicacion.Name = "lb_ubicacion";
            this.lb_ubicacion.Size = new System.Drawing.Size(223, 22);
            this.lb_ubicacion.TabIndex = 30;
            this.lb_ubicacion.Text = "* Ubicación\r\n";
            this.lb_ubicacion.UseCompatibleTextRendering = true;
            // 
            // cb_canal
            // 
            this.cb_canal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_canal.FormattingEnabled = true;
            this.cb_canal.Items.AddRange(new object[] {
            "Canal 1",
            "Canal Institucional",
            "Caracol",
            "RCN"});
            this.cb_canal.Location = new System.Drawing.Point(48, 391);
            this.cb_canal.Name = "cb_canal";
            this.cb_canal.Size = new System.Drawing.Size(223, 27);
            this.cb_canal.TabIndex = 29;
            this.cb_canal.Text = "Seleccione un canal";
            this.cb_canal.SelectedIndexChanged += new System.EventHandler(this.cb_canal_SelectedIndexChanged);
            // 
            // cb_ubicacion
            // 
            this.cb_ubicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ubicacion.FormattingEnabled = true;
            this.cb_ubicacion.Items.AddRange(new object[] {
            "Rural",
            "Urbano"});
            this.cb_ubicacion.Location = new System.Drawing.Point(48, 301);
            this.cb_ubicacion.Name = "cb_ubicacion";
            this.cb_ubicacion.Size = new System.Drawing.Size(223, 27);
            this.cb_ubicacion.TabIndex = 28;
            this.cb_ubicacion.Text = "Seleccione una ubicación";
            this.cb_ubicacion.SelectedIndexChanged += new System.EventHandler(this.cb_ubicacion_SelectedIndexChanged);
            // 
            // cb_estrato
            // 
            this.cb_estrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estrato.FormattingEnabled = true;
            this.cb_estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_estrato.Location = new System.Drawing.Point(48, 214);
            this.cb_estrato.Name = "cb_estrato";
            this.cb_estrato.Size = new System.Drawing.Size(223, 27);
            this.cb_estrato.TabIndex = 27;
            this.cb_estrato.Text = "Seleccione su estrato";
            this.cb_estrato.SelectedIndexChanged += new System.EventHandler(this.cb_estrato_SelectedIndexChanged);
            // 
            // lb_formulario
            // 
            this.lb_formulario.AutoSize = true;
            this.lb_formulario.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_formulario.ForeColor = System.Drawing.Color.White;
            this.lb_formulario.Location = new System.Drawing.Point(80, 29);
            this.lb_formulario.Name = "lb_formulario";
            this.lb_formulario.Size = new System.Drawing.Size(162, 36);
            this.lb_formulario.TabIndex = 22;
            this.lb_formulario.Text = "Formulario";
            // 
            // lb_identificacion
            // 
            this.lb_identificacion.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_identificacion.ForeColor = System.Drawing.Color.White;
            this.lb_identificacion.Location = new System.Drawing.Point(48, 104);
            this.lb_identificacion.Name = "lb_identificacion";
            this.lb_identificacion.Size = new System.Drawing.Size(223, 24);
            this.lb_identificacion.TabIndex = 21;
            this.lb_identificacion.Text = "* Identificación";
            this.lb_identificacion.UseCompatibleTextRendering = true;
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.Location = new System.Drawing.Point(48, 131);
            this.txt_identificacion.MaxLength = 14;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(223, 27);
            this.txt_identificacion.TabIndex = 20;
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(3)))), ((int)(((byte)(10)))));
            this.btn_salir.Location = new System.Drawing.Point(500, 524);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(61, 30);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_iniciar_pila
            // 
            this.btn_iniciar_pila.AutoSize = true;
            this.btn_iniciar_pila.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_pila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(3)))), ((int)(((byte)(10)))));
            this.btn_iniciar_pila.Location = new System.Drawing.Point(36, 524);
            this.btn_iniciar_pila.Name = "btn_iniciar_pila";
            this.btn_iniciar_pila.Size = new System.Drawing.Size(217, 30);
            this.btn_iniciar_pila.TabIndex = 30;
            this.btn_iniciar_pila.Text = "Iniciar aplicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fase 3 Práctica Estructuras lineales";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_view_pila);
            this.panel3.Controls.Add(this.lb_registros_actuales);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_iniciar_pila);
            this.panel3.Controls.Add(this.btn_salir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 592);
            this.panel3.TabIndex = 2;
            // 
            // lb_registros_actuales
            // 
            this.lb_registros_actuales.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registros_actuales.ForeColor = System.Drawing.Color.Black;
            this.lb_registros_actuales.Location = new System.Drawing.Point(207, 104);
            this.lb_registros_actuales.Name = "lb_registros_actuales";
            this.lb_registros_actuales.Size = new System.Drawing.Size(46, 24);
            this.lb_registros_actuales.TabIndex = 32;
            this.lb_registros_actuales.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Registros actuales:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(3)))), ((int)(((byte)(10)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(625, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 592);
            this.panel2.TabIndex = 1;
            // 
            // ep_identificacion
            // 
            this.ep_identificacion.ContainerControl = this;
            // 
            // ep_estrato
            // 
            this.ep_estrato.ContainerControl = this;
            // 
            // ep_ubicacion
            // 
            this.ep_ubicacion.ContainerControl = this;
            // 
            // ep_canal
            // 
            this.ep_canal.ContainerControl = this;
            // 
            // grid_view_pila
            // 
            this.grid_view_pila.AllowUserToAddRows = false;
            this.grid_view_pila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_pila.Location = new System.Drawing.Point(54, 166);
            this.grid_view_pila.Name = "grid_view_pila";
            this.grid_view_pila.ReadOnly = true;
            this.grid_view_pila.Size = new System.Drawing.Size(527, 275);
            this.grid_view_pila.TabIndex = 33;
            // 
            // pilaBindingSource
            // 
            this.pilaBindingSource.DataSource = typeof(AplicacionUI.Modelos.Pila.Pila);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioReserva";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_identificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_estrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_canal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_pila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_salir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_iniciar_pila;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_identificacion;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label lb_formulario;
        private System.Windows.Forms.Label lb_estrato;
        private System.Windows.Forms.Label lb_canal;
        private System.Windows.Forms.Label lb_ubicacion;
        private System.Windows.Forms.ComboBox cb_canal;
        private System.Windows.Forms.ComboBox cb_ubicacion;
        private System.Windows.Forms.ComboBox cb_estrato;
        private System.Windows.Forms.ErrorProvider ep_identificacion;
        private System.Windows.Forms.ErrorProvider ep_estrato;
        private System.Windows.Forms.ErrorProvider ep_ubicacion;
        private System.Windows.Forms.ErrorProvider ep_canal;
        private System.Windows.Forms.Button btn_guardar_pila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_registros_actuales;
        private System.Windows.Forms.DataGridView grid_view_pila;
        private System.Windows.Forms.BindingSource pilaBindingSource;
    }
}