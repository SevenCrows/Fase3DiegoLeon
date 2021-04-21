// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="Informacion.Designer.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace AplicacionUI.Interfaz.Cola
{
    /// <summary>
    /// Class Informacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_listas = new System.Windows.Forms.Button();
            this.btn_colas = new System.Windows.Forms.Button();
            this.btn_pila = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_iniciar_cola = new System.Windows.Forms.Button();
            this.lb_parrafo_1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_listas);
            this.panel1.Controls.Add(this.btn_colas);
            this.panel1.Controls.Add(this.btn_pila);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 592);
            this.panel1.TabIndex = 0;
            // 
            // btn_listas
            // 
            this.btn_listas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_listas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_listas.FlatAppearance.BorderSize = 0;
            this.btn_listas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(63)))));
            this.btn_listas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_listas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listas.ForeColor = System.Drawing.Color.White;
            this.btn_listas.Location = new System.Drawing.Point(0, 136);
            this.btn_listas.Name = "btn_listas";
            this.btn_listas.Size = new System.Drawing.Size(252, 68);
            this.btn_listas.TabIndex = 17;
            this.btn_listas.Text = "Listas";
            this.btn_listas.UseVisualStyleBackColor = false;
            this.btn_listas.Click += new System.EventHandler(this.btn_listas_Click);
            // 
            // btn_colas
            // 
            this.btn_colas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_colas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_colas.FlatAppearance.BorderSize = 0;
            this.btn_colas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_colas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_colas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colas.ForeColor = System.Drawing.Color.White;
            this.btn_colas.Location = new System.Drawing.Point(0, 68);
            this.btn_colas.Name = "btn_colas";
            this.btn_colas.Size = new System.Drawing.Size(252, 68);
            this.btn_colas.TabIndex = 16;
            this.btn_colas.Text = "Colas";
            this.btn_colas.UseVisualStyleBackColor = false;
            // 
            // btn_pila
            // 
            this.btn_pila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_pila.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pila.FlatAppearance.BorderSize = 0;
            this.btn_pila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(63)))));
            this.btn_pila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_pila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pila.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pila.ForeColor = System.Drawing.Color.White;
            this.btn_pila.Location = new System.Drawing.Point(0, 0);
            this.btn_pila.Name = "btn_pila";
            this.btn_pila.Size = new System.Drawing.Size(252, 68);
            this.btn_pila.TabIndex = 15;
            this.btn_pila.Text = "Pilas";
            this.btn_pila.UseVisualStyleBackColor = false;
            this.btn_pila.Click += new System.EventHandler(this.btn_pila_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(185, 553);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(61, 30);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fase 3 Práctica Estructuras lineales";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_iniciar_cola);
            this.panel3.Controls.Add(this.lb_parrafo_1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(256, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 592);
            this.panel3.TabIndex = 2;
            // 
            // btn_iniciar_cola
            // 
            this.btn_iniciar_cola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_iniciar_cola.FlatAppearance.BorderSize = 0;
            this.btn_iniciar_cola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(63)))));
            this.btn_iniciar_cola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btn_iniciar_cola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_cola.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_cola.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar_cola.Location = new System.Drawing.Point(415, 517);
            this.btn_iniciar_cola.Name = "btn_iniciar_cola";
            this.btn_iniciar_cola.Size = new System.Drawing.Size(224, 43);
            this.btn_iniciar_cola.TabIndex = 32;
            this.btn_iniciar_cola.Text = "Iniciar aplicación";
            this.btn_iniciar_cola.UseVisualStyleBackColor = false;
            this.btn_iniciar_cola.Click += new System.EventHandler(this.btn_iniciar_cola_Click);
            // 
            // lb_parrafo_1
            // 
            this.lb_parrafo_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parrafo_1.Location = new System.Drawing.Point(45, 124);
            this.lb_parrafo_1.Name = "lb_parrafo_1";
            this.lb_parrafo_1.Size = new System.Drawing.Size(594, 355);
            this.lb_parrafo_1.TabIndex = 31;
            this.lb_parrafo_1.Text = resources.GetString("lb_parrafo_1.Text");
            this.lb_parrafo_1.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 592);
            this.panel2.TabIndex = 1;
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioReserva";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The BTN salir
        /// </summary>
        private System.Windows.Forms.Label btn_salir;
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
        /// The BTN pila
        /// </summary>
        private System.Windows.Forms.Button btn_pila;
        /// <summary>
        /// The BTN listas
        /// </summary>
        private System.Windows.Forms.Button btn_listas;
        /// <summary>
        /// The BTN colas
        /// </summary>
        private System.Windows.Forms.Button btn_colas;
        /// <summary>
        /// The lb parrafo 1
        /// </summary>
        private System.Windows.Forms.Label lb_parrafo_1;
        /// <summary>
        /// The BTN iniciar cola
        /// </summary>
        private System.Windows.Forms.Button btn_iniciar_cola;
    }
}