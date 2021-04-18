
namespace AplicacionUI.Interfaz.Seguridad
{
    partial class Seguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguridad));
            this.txt_password = new System.Windows.Forms.TextBox();
            this.ep_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Label();
            this.lb_parrafo_1 = new System.Windows.Forms.Label();
            this.lb_informacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ep_password)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(654, 310);
            this.txt_password.MaxLength = 5;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(220, 33);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ep_password
            // 
            this.ep_password.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.lb_parrafo_1);
            this.panel1.Controls.Add(this.lb_informacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 450);
            this.panel1.TabIndex = 2;
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(172)))));
            this.btn_salir.Location = new System.Drawing.Point(525, 405);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(61, 30);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lb_parrafo_1
            // 
            this.lb_parrafo_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parrafo_1.Location = new System.Drawing.Point(42, 143);
            this.lb_parrafo_1.Name = "lb_parrafo_1";
            this.lb_parrafo_1.Size = new System.Drawing.Size(544, 189);
            this.lb_parrafo_1.TabIndex = 5;
            this.lb_parrafo_1.Text = resources.GetString("lb_parrafo_1.Text");
            this.lb_parrafo_1.UseCompatibleTextRendering = true;
            // 
            // lb_informacion
            // 
            this.lb_informacion.AutoSize = true;
            this.lb_informacion.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_informacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_informacion.Location = new System.Drawing.Point(54, 74);
            this.lb_informacion.Name = "lb_informacion";
            this.lb_informacion.Size = new System.Drawing.Size(502, 36);
            this.lb_informacion.TabIndex = 4;
            this.lb_informacion.Text = "Fase 3 Práctica Estructuras lineales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(617, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 450);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(642, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre estudiante: ";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(642, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "Grupo: 301305_14\r\n";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(644, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 60);
            this.label10.TabIndex = 16;
            this.label10.Text = "Programa: \r\nESTRUCTURA DE DATOS\r\n";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(642, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 61);
            this.label11.TabIndex = 17;
            this.label11.Text = "DIEGO ALEXANDER LEON TORRES\r\n";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(126)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.ep_password.SetIconAlignment(this.btn_ingresar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btn_ingresar.Location = new System.Drawing.Point(621, 393);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ingresar.Size = new System.Drawing.Size(278, 57);
            this.btn_ingresar.TabIndex = 18;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transervimos - Seguridad";
            ((System.ComponentModel.ISupportInitialize)(this.ep_password)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ErrorProvider ep_password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_informacion;
        private System.Windows.Forms.Label lb_parrafo_1;
        private System.Windows.Forms.Label btn_salir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ingresar;
    }

}