// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="Formulario.Designer.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace AplicacionUI.Interfaz.Lista
{
    /// <summary>
    /// Class Formulario.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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
            this.dtp_fechaviaje = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_guardar_lista = new System.Windows.Forms.Button();
            this.lb_estrato = new System.Windows.Forms.Label();
            this.lb_destino = new System.Windows.Forms.Label();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.lb_formulario = new System.Windows.Forms.Label();
            this.lb_reserva = new System.Windows.Forms.Label();
            this.txt_codigo_reserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar_lista = new System.Windows.Forms.Button();
            this.lb_regresar = new System.Windows.Forms.Label();
            this.grid_view_lista = new System.Windows.Forms.DataGridView();
            this.lb_registros_actuales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaViajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTiqueteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_codigo_reserva = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_destino = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_fecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_valor = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_codigo_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_destino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dtp_fechaviaje);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_valor);
            this.panel1.Controls.Add(this.btn_guardar_lista);
            this.panel1.Controls.Add(this.lb_estrato);
            this.panel1.Controls.Add(this.lb_destino);
            this.panel1.Controls.Add(this.cb_destino);
            this.panel1.Controls.Add(this.lb_formulario);
            this.panel1.Controls.Add(this.lb_reserva);
            this.panel1.Controls.Add(this.txt_codigo_reserva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 592);
            this.panel1.TabIndex = 0;
            // 
            // dtp_fechaviaje
            // 
            this.dtp_fechaviaje.Location = new System.Drawing.Point(48, 279);
            this.dtp_fechaviaje.Name = "dtp_fechaviaje";
            this.dtp_fechaviaje.Size = new System.Drawing.Size(223, 20);
            this.dtp_fechaviaje.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "* Fecha de viaje";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(48, 352);
            this.txt_valor.MaxLength = 14;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(223, 27);
            this.txt_valor.TabIndex = 34;
            // 
            // btn_guardar_lista
            // 
            this.btn_guardar_lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guardar_lista.FlatAppearance.BorderSize = 0;
            this.btn_guardar_lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(219)))), ((int)(((byte)(93)))));
            this.btn_guardar_lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(44)))));
            this.btn_guardar_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_lista.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_lista.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_lista.Location = new System.Drawing.Point(0, 524);
            this.btn_guardar_lista.Name = "btn_guardar_lista";
            this.btn_guardar_lista.Size = new System.Drawing.Size(307, 68);
            this.btn_guardar_lista.TabIndex = 33;
            this.btn_guardar_lista.Text = "Guardar";
            this.btn_guardar_lista.UseVisualStyleBackColor = true;
            this.btn_guardar_lista.Click += new System.EventHandler(this.btn_guardar_lista_Click);
            // 
            // lb_estrato
            // 
            this.lb_estrato.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estrato.ForeColor = System.Drawing.Color.White;
            this.lb_estrato.Location = new System.Drawing.Point(48, 328);
            this.lb_estrato.Name = "lb_estrato";
            this.lb_estrato.Size = new System.Drawing.Size(223, 21);
            this.lb_estrato.TabIndex = 32;
            this.lb_estrato.Text = "* Valor tiquete";
            this.lb_estrato.UseCompatibleTextRendering = true;
            // 
            // lb_destino
            // 
            this.lb_destino.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_destino.ForeColor = System.Drawing.Color.White;
            this.lb_destino.Location = new System.Drawing.Point(48, 177);
            this.lb_destino.Name = "lb_destino";
            this.lb_destino.Size = new System.Drawing.Size(223, 22);
            this.lb_destino.TabIndex = 30;
            this.lb_destino.Text = "* Destino";
            this.lb_destino.UseCompatibleTextRendering = true;
            // 
            // cb_destino
            // 
            this.cb_destino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Cali",
            "Barranquilla"});
            this.cb_destino.Location = new System.Drawing.Point(48, 202);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(223, 27);
            this.cb_destino.TabIndex = 28;
            this.cb_destino.Text = "Seleccione un destino";
            this.cb_destino.SelectedIndexChanged += new System.EventHandler(this.cb_destino_SelectedIndexChanged);
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
            // lb_reserva
            // 
            this.lb_reserva.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reserva.ForeColor = System.Drawing.Color.White;
            this.lb_reserva.Location = new System.Drawing.Point(48, 104);
            this.lb_reserva.Name = "lb_reserva";
            this.lb_reserva.Size = new System.Drawing.Size(223, 24);
            this.lb_reserva.TabIndex = 21;
            this.lb_reserva.Text = "* Código de reserva";
            this.lb_reserva.UseCompatibleTextRendering = true;
            // 
            // txt_codigo_reserva
            // 
            this.txt_codigo_reserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_reserva.Location = new System.Drawing.Point(48, 131);
            this.txt_codigo_reserva.MaxLength = 14;
            this.txt_codigo_reserva.Name = "txt_codigo_reserva";
            this.txt_codigo_reserva.Size = new System.Drawing.Size(223, 27);
            this.txt_codigo_reserva.TabIndex = 20;
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
            this.panel3.Controls.Add(this.btn_eliminar_lista);
            this.panel3.Controls.Add(this.lb_regresar);
            this.panel3.Controls.Add(this.grid_view_lista);
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
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(219)))), ((int)(((byte)(93)))));
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(44)))));
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
            // btn_eliminar_lista
            // 
            this.btn_eliminar_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.btn_eliminar_lista.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(219)))), ((int)(((byte)(93)))));
            this.btn_eliminar_lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(44)))));
            this.btn_eliminar_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_lista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_lista.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_lista.Location = new System.Drawing.Point(66, 457);
            this.btn_eliminar_lista.Name = "btn_eliminar_lista";
            this.btn_eliminar_lista.Size = new System.Drawing.Size(105, 33);
            this.btn_eliminar_lista.TabIndex = 36;
            this.btn_eliminar_lista.Text = "Eliminar";
            this.btn_eliminar_lista.UseVisualStyleBackColor = false;
            this.btn_eliminar_lista.Click += new System.EventHandler(this.btn_eliminar_lista_Click);
            // 
            // lb_regresar
            // 
            this.lb_regresar.AutoSize = true;
            this.lb_regresar.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.lb_regresar.Location = new System.Drawing.Point(12, 9);
            this.lb_regresar.Name = "lb_regresar";
            this.lb_regresar.Size = new System.Drawing.Size(128, 25);
            this.lb_regresar.TabIndex = 34;
            this.lb_regresar.Text = "◄ Regresar";
            this.lb_regresar.Click += new System.EventHandler(this.lb_regresar_Click);
            // 
            // grid_view_lista
            // 
            this.grid_view_lista.AutoGenerateColumns = false;
            this.grid_view_lista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_view_lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_view_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoReservaDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.fechaViajeDataGridViewTextBoxColumn,
            this.valorTiqueteDataGridViewTextBoxColumn});
            this.grid_view_lista.DataSource = this.listaBindingSource;
            this.grid_view_lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.grid_view_lista.Location = new System.Drawing.Point(93, 170);
            this.grid_view_lista.Name = "grid_view_lista";
            this.grid_view_lista.Size = new System.Drawing.Size(456, 281);
            this.grid_view_lista.TabIndex = 33;
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(44)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(625, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 592);
            this.panel2.TabIndex = 1;
            // 
            // listaBindingSource
            // 
            this.listaBindingSource.DataSource = typeof(AplicacionUI.Modelos.Lista.Lista);
            // 
            // codigoReservaDataGridViewTextBoxColumn
            // 
            this.codigoReservaDataGridViewTextBoxColumn.DataPropertyName = "CodigoReserva";
            this.codigoReservaDataGridViewTextBoxColumn.HeaderText = "CodigoReserva";
            this.codigoReservaDataGridViewTextBoxColumn.Name = "codigoReservaDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // fechaViajeDataGridViewTextBoxColumn
            // 
            this.fechaViajeDataGridViewTextBoxColumn.DataPropertyName = "FechaViaje";
            this.fechaViajeDataGridViewTextBoxColumn.HeaderText = "FechaViaje";
            this.fechaViajeDataGridViewTextBoxColumn.Name = "fechaViajeDataGridViewTextBoxColumn";
            // 
            // valorTiqueteDataGridViewTextBoxColumn
            // 
            this.valorTiqueteDataGridViewTextBoxColumn.DataPropertyName = "ValorTiquete";
            this.valorTiqueteDataGridViewTextBoxColumn.HeaderText = "ValorTiquete";
            this.valorTiqueteDataGridViewTextBoxColumn.Name = "valorTiqueteDataGridViewTextBoxColumn";
            // 
            // ep_codigo_reserva
            // 
            this.ep_codigo_reserva.ContainerControl = this;
            // 
            // ep_destino
            // 
            this.ep_destino.ContainerControl = this;
            // 
            // ep_fecha
            // 
            this.ep_fecha.ContainerControl = this;
            // 
            // ep_valor
            // 
            this.ep_valor.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_codigo_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_destino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_valor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The panel3
        /// </summary>
        private System.Windows.Forms.Panel panel3;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The panel2
        /// </summary>
        private System.Windows.Forms.Panel panel2;
        /// <summary>
        /// The lb reserva
        /// </summary>
        private System.Windows.Forms.Label lb_reserva;
        /// <summary>
        /// The text codigo reserva
        /// </summary>
        private System.Windows.Forms.TextBox txt_codigo_reserva;
        /// <summary>
        /// The lb formulario
        /// </summary>
        private System.Windows.Forms.Label lb_formulario;
        /// <summary>
        /// The lb estrato
        /// </summary>
        private System.Windows.Forms.Label lb_estrato;
        /// <summary>
        /// The lb destino
        /// </summary>
        private System.Windows.Forms.Label lb_destino;
        /// <summary>
        /// The cb destino
        /// </summary>
        private System.Windows.Forms.ComboBox cb_destino;
        /// <summary>
        /// The BTN guardar lista
        /// </summary>
        private System.Windows.Forms.Button btn_guardar_lista;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The lb registros actuales
        /// </summary>
        private System.Windows.Forms.Label lb_registros_actuales;
        /// <summary>
        /// The grid view lista
        /// </summary>
        private System.Windows.Forms.DataGridView grid_view_lista;
        /// <summary>
        /// The lb regresar
        /// </summary>
        private System.Windows.Forms.Label lb_regresar;
        /// <summary>
        /// The BTN salir
        /// </summary>
        private System.Windows.Forms.Button btn_salir;
        /// <summary>
        /// The BTN eliminar lista
        /// </summary>
        private System.Windows.Forms.Button btn_eliminar_lista;
        /// <summary>
        /// The DTP fechaviaje
        /// </summary>
        private System.Windows.Forms.DateTimePicker dtp_fechaviaje;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The text valor
        /// </summary>
        private System.Windows.Forms.TextBox txt_valor;
        /// <summary>
        /// The lista binding source
        /// </summary>
        private System.Windows.Forms.BindingSource listaBindingSource;
        /// <summary>
        /// The codigo reserva data grid view text box column
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoReservaDataGridViewTextBoxColumn;
        /// <summary>
        /// The destino data grid view text box column
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        /// <summary>
        /// The fecha viaje data grid view text box column
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaViajeDataGridViewTextBoxColumn;
        /// <summary>
        /// The valor tiquete data grid view text box column
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTiqueteDataGridViewTextBoxColumn;
        /// <summary>
        /// The ep codigo reserva
        /// </summary>
        private System.Windows.Forms.ErrorProvider ep_codigo_reserva;
        /// <summary>
        /// The ep destino
        /// </summary>
        private System.Windows.Forms.ErrorProvider ep_destino;
        /// <summary>
        /// The ep fecha
        /// </summary>
        private System.Windows.Forms.ErrorProvider ep_fecha;
        /// <summary>
        /// The ep valor
        /// </summary>
        private System.Windows.Forms.ErrorProvider ep_valor;
    }
}