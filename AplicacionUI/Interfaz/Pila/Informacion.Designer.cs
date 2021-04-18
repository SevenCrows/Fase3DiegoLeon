
namespace AplicacionUI.Interfaz.Pila
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Label();
            this.ep_identificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_nombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_destino = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_cantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_iniciar_pila = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_parrafo_1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_identificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_destino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_cantidad)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 592);
            this.panel1.TabIndex = 0;
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
            // ep_identificacion
            // 
            this.ep_identificacion.ContainerControl = this;
            // 
            // ep_nombre
            // 
            this.ep_nombre.ContainerControl = this;
            // 
            // ep_destino
            // 
            this.ep_destino.ContainerControl = this;
            // 
            // ep_cantidad
            // 
            this.ep_cantidad.ContainerControl = this;
            // 
            // btn_iniciar_pila
            // 
            this.btn_iniciar_pila.AutoSize = true;
            this.btn_iniciar_pila.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_pila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(3)))), ((int)(((byte)(10)))));
            this.btn_iniciar_pila.Location = new System.Drawing.Point(422, 516);
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
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fase 3 Práctica Estructuras lineales";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_parrafo_1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_iniciar_pila);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(256, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 592);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 592);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 68);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pilas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 68);
            this.button2.TabIndex = 16;
            this.button2.Text = "Colas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(70)))), ((int)(((byte)(43)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 68);
            this.button3.TabIndex = 17;
            this.button3.Text = "Listas";
            this.button3.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ep_identificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_destino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_cantidad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_salir;
        private System.Windows.Forms.ErrorProvider ep_identificacion;
        private System.Windows.Forms.ErrorProvider ep_nombre;
        private System.Windows.Forms.ErrorProvider ep_destino;
        private System.Windows.Forms.ErrorProvider ep_cantidad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_iniciar_pila;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_parrafo_1;
    }
}