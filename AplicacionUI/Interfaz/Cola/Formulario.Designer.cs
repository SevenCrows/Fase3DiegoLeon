
namespace AplicacionUI.Interfaz.Cola
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
            this.btn_guardar_cola = new System.Windows.Forms.Button();
            this.lb_estrato = new System.Windows.Forms.Label();
            this.lb_canal = new System.Windows.Forms.Label();
            this.lb_ubicacion = new System.Windows.Forms.Label();
            this.cb_pais = new System.Windows.Forms.ComboBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.lb_formulario = new System.Windows.Forms.Label();
            this.lb_identificacion = new System.Windows.Forms.Label();
            this.txt_pasaporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar_cola = new System.Windows.Forms.Button();
            this.lb_regresar = new System.Windows.Forms.Label();
            this.grid_view_cola = new System.Windows.Forms.DataGridView();
            this.lb_registros_actuales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_registro = new System.Windows.Forms.DateTimePicker();
            this.ep_pasaporte = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_nombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_genero = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_residencia = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_fecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.numeroPasaporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisResidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_cola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_pasaporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_genero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_residencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dtp_registro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nombres);
            this.panel1.Controls.Add(this.btn_guardar_cola);
            this.panel1.Controls.Add(this.lb_estrato);
            this.panel1.Controls.Add(this.lb_canal);
            this.panel1.Controls.Add(this.lb_ubicacion);
            this.panel1.Controls.Add(this.cb_pais);
            this.panel1.Controls.Add(this.cb_genero);
            this.panel1.Controls.Add(this.lb_formulario);
            this.panel1.Controls.Add(this.lb_identificacion);
            this.panel1.Controls.Add(this.txt_pasaporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 592);
            this.panel1.TabIndex = 0;
            // 
            // btn_guardar_cola
            // 
            this.btn_guardar_cola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guardar_cola.FlatAppearance.BorderSize = 0;
            this.btn_guardar_cola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(63)))));
            this.btn_guardar_cola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_guardar_cola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_cola.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_cola.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_cola.Location = new System.Drawing.Point(0, 524);
            this.btn_guardar_cola.Name = "btn_guardar_cola";
            this.btn_guardar_cola.Size = new System.Drawing.Size(307, 68);
            this.btn_guardar_cola.TabIndex = 33;
            this.btn_guardar_cola.Text = "Guardar";
            this.btn_guardar_cola.UseVisualStyleBackColor = true;
            this.btn_guardar_cola.Click += new System.EventHandler(this.btn_guardar_cola_Click);
            // 
            // lb_estrato
            // 
            this.lb_estrato.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estrato.ForeColor = System.Drawing.Color.White;
            this.lb_estrato.Location = new System.Drawing.Point(48, 180);
            this.lb_estrato.Name = "lb_estrato";
            this.lb_estrato.Size = new System.Drawing.Size(223, 21);
            this.lb_estrato.TabIndex = 32;
            this.lb_estrato.Text = "* Nombre completo";
            this.lb_estrato.UseCompatibleTextRendering = true;
            // 
            // lb_canal
            // 
            this.lb_canal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_canal.ForeColor = System.Drawing.Color.White;
            this.lb_canal.Location = new System.Drawing.Point(48, 340);
            this.lb_canal.Name = "lb_canal";
            this.lb_canal.Size = new System.Drawing.Size(223, 22);
            this.lb_canal.TabIndex = 31;
            this.lb_canal.Text = "* País de residencia";
            this.lb_canal.UseCompatibleTextRendering = true;
            // 
            // lb_ubicacion
            // 
            this.lb_ubicacion.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ubicacion.ForeColor = System.Drawing.Color.White;
            this.lb_ubicacion.Location = new System.Drawing.Point(48, 259);
            this.lb_ubicacion.Name = "lb_ubicacion";
            this.lb_ubicacion.Size = new System.Drawing.Size(223, 22);
            this.lb_ubicacion.TabIndex = 30;
            this.lb_ubicacion.Text = "* Genero";
            this.lb_ubicacion.UseCompatibleTextRendering = true;
            // 
            // cb_pais
            // 
            this.cb_pais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Items.AddRange(new object[] {
            "Colombia",
            "España",
            "Rusia",
            "Estados Unidos",
            "Holanda"});
            this.cb_pais.Location = new System.Drawing.Point(48, 365);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(223, 27);
            this.cb_pais.TabIndex = 29;
            this.cb_pais.Text = "Seleccione un país";
            this.cb_pais.SelectedIndexChanged += new System.EventHandler(this.cb_pais_SelectedIndexChanged);
            // 
            // cb_genero
            // 
            this.cb_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_genero.Location = new System.Drawing.Point(48, 284);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(223, 27);
            this.cb_genero.TabIndex = 28;
            this.cb_genero.Text = "Seleccione un genero";
            this.cb_genero.SelectedIndexChanged += new System.EventHandler(this.cb_genero_SelectedIndexChanged);
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
            this.lb_identificacion.Text = "* Número del pasaporte";
            this.lb_identificacion.UseCompatibleTextRendering = true;
            // 
            // txt_pasaporte
            // 
            this.txt_pasaporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pasaporte.Location = new System.Drawing.Point(48, 131);
            this.txt_pasaporte.MaxLength = 14;
            this.txt_pasaporte.Name = "txt_pasaporte";
            this.txt_pasaporte.Size = new System.Drawing.Size(223, 27);
            this.txt_pasaporte.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(60, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fase 3 Práctica Estructuras lineales";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_salir);
            this.panel3.Controls.Add(this.btn_eliminar_cola);
            this.panel3.Controls.Add(this.lb_regresar);
            this.panel3.Controls.Add(this.grid_view_cola);
            this.panel3.Controls.Add(this.lb_registros_actuales);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 592);
            this.panel3.TabIndex = 2;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(63)))));
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(480, 541);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(124, 36);
            this.btn_salir.TabIndex = 37;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar_cola
            // 
            this.btn_eliminar_cola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_eliminar_cola.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_cola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(63)))));
            this.btn_eliminar_cola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_eliminar_cola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_cola.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_cola.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_cola.Location = new System.Drawing.Point(35, 457);
            this.btn_eliminar_cola.Name = "btn_eliminar_cola";
            this.btn_eliminar_cola.Size = new System.Drawing.Size(105, 33);
            this.btn_eliminar_cola.TabIndex = 36;
            this.btn_eliminar_cola.Text = "Eliminar";
            this.btn_eliminar_cola.UseVisualStyleBackColor = false;
            this.btn_eliminar_cola.Click += new System.EventHandler(this.btn_eliminar_cola_Click);
            // 
            // lb_regresar
            // 
            this.lb_regresar.AutoSize = true;
            this.lb_regresar.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.lb_regresar.Location = new System.Drawing.Point(12, 9);
            this.lb_regresar.Name = "lb_regresar";
            this.lb_regresar.Size = new System.Drawing.Size(128, 25);
            this.lb_regresar.TabIndex = 34;
            this.lb_regresar.Text = "◄ Regresar";
            this.lb_regresar.Click += new System.EventHandler(this.lb_regresar_Click);
            // 
            // grid_view_cola
            // 
            this.grid_view_cola.AutoGenerateColumns = false;
            this.grid_view_cola.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_view_cola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_view_cola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_cola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroPasaporteDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.paisResidenciaDataGridViewTextBoxColumn,
            this.fechaRegistraDataGridViewTextBoxColumn});
            this.grid_view_cola.DataSource = this.colaBindingSource;
            this.grid_view_cola.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.grid_view_cola.Location = new System.Drawing.Point(35, 170);
            this.grid_view_cola.Name = "grid_view_cola";
            this.grid_view_cola.Size = new System.Drawing.Size(559, 281);
            this.grid_view_cola.TabIndex = 33;
            // 
            // lb_registros_actuales
            // 
            this.lb_registros_actuales.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registros_actuales.ForeColor = System.Drawing.Color.Black;
            this.lb_registros_actuales.Location = new System.Drawing.Point(195, 126);
            this.lb_registros_actuales.Name = "lb_registros_actuales";
            this.lb_registros_actuales.Size = new System.Drawing.Size(46, 24);
            this.lb_registros_actuales.TabIndex = 32;
            this.lb_registros_actuales.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Registros actuales:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(625, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 592);
            this.panel2.TabIndex = 1;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.Location = new System.Drawing.Point(48, 204);
            this.txt_nombres.MaxLength = 14;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(223, 27);
            this.txt_nombres.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "* Fecha del registro";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // dtp_registro
            // 
            this.dtp_registro.Location = new System.Drawing.Point(48, 457);
            this.dtp_registro.Name = "dtp_registro";
            this.dtp_registro.Size = new System.Drawing.Size(223, 20);
            this.dtp_registro.TabIndex = 37;
            // 
            // ep_pasaporte
            // 
            this.ep_pasaporte.ContainerControl = this;
            // 
            // ep_nombre
            // 
            this.ep_nombre.ContainerControl = this;
            // 
            // ep_genero
            // 
            this.ep_genero.ContainerControl = this;
            // 
            // ep_residencia
            // 
            this.ep_residencia.ContainerControl = this;
            // 
            // ep_fecha
            // 
            this.ep_fecha.ContainerControl = this;
            // 
            // numeroPasaporteDataGridViewTextBoxColumn
            // 
            this.numeroPasaporteDataGridViewTextBoxColumn.DataPropertyName = "NumeroPasaporte";
            this.numeroPasaporteDataGridViewTextBoxColumn.HeaderText = "NumeroPasaporte";
            this.numeroPasaporteDataGridViewTextBoxColumn.Name = "numeroPasaporteDataGridViewTextBoxColumn";
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // paisResidenciaDataGridViewTextBoxColumn
            // 
            this.paisResidenciaDataGridViewTextBoxColumn.DataPropertyName = "PaisResidencia";
            this.paisResidenciaDataGridViewTextBoxColumn.HeaderText = "PaisResidencia";
            this.paisResidenciaDataGridViewTextBoxColumn.Name = "paisResidenciaDataGridViewTextBoxColumn";
            // 
            // fechaRegistraDataGridViewTextBoxColumn
            // 
            this.fechaRegistraDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistra";
            this.fechaRegistraDataGridViewTextBoxColumn.HeaderText = "FechaRegistra";
            this.fechaRegistraDataGridViewTextBoxColumn.Name = "fechaRegistraDataGridViewTextBoxColumn";
            // 
            // colaBindingSource
            // 
            this.colaBindingSource.DataSource = typeof(AplicacionUI.Modelos.Cola.Cola);
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_cola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_pasaporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_genero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_residencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_identificacion;
        private System.Windows.Forms.TextBox txt_pasaporte;
        private System.Windows.Forms.Label lb_formulario;
        private System.Windows.Forms.Label lb_estrato;
        private System.Windows.Forms.Label lb_canal;
        private System.Windows.Forms.Label lb_ubicacion;
        private System.Windows.Forms.ComboBox cb_pais;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Button btn_guardar_cola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_registros_actuales;
        private System.Windows.Forms.DataGridView grid_view_cola;
        private System.Windows.Forms.Label lb_regresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar_cola;
        private System.Windows.Forms.BindingSource colaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPasaporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisResidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtp_registro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.ErrorProvider ep_pasaporte;
        private System.Windows.Forms.ErrorProvider ep_nombre;
        private System.Windows.Forms.ErrorProvider ep_genero;
        private System.Windows.Forms.ErrorProvider ep_residencia;
        private System.Windows.Forms.ErrorProvider ep_fecha;
    }
}