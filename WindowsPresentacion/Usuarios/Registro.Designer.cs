﻿namespace WindowsPresentacion.Usuarios
{
    partial class Registro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.valido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nueva contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nuevo nombre de usuario";
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(140, 127);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(133, 20);
            this.password1.TabIndex = 6;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(140, 78);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(133, 20);
            this.userName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Repetir Contraseña";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(140, 184);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(133, 20);
            this.password2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nuevo Usuario";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(171, 227);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(102, 23);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.Text = "Confirmar Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.Confirmar);
            // 
            // valido
            // 
            this.valido.AutoSize = true;
            this.valido.Location = new System.Drawing.Point(140, 211);
            this.valido.Name = "valido";
            this.valido.Size = new System.Drawing.Size(0, 13);
            this.valido.TabIndex = 13;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(352, 281);
            this.Controls.Add(this.valido);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.userName);
            this.Name = "Registro";
            this.Text = "Registro";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label valido;
    }
}