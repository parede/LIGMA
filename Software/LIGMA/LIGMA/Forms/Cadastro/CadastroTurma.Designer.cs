﻿namespace LIGMA.Forms.Cadastro
{
    partial class CadastroTurma
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
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cmbEstagio = new System.Windows.Forms.ComboBox();
            this.lblEstagio = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlFormBorder.Controls.Add(this.btnMinimizar);
            this.pnlFormBorder.Controls.Add(this.btnFechar);
            this.pnlFormBorder.Controls.Add(this.lblLIGMA);
            this.pnlFormBorder.Controls.Add(this.pcbIcone);
            this.pnlFormBorder.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(428, 36);
            this.pnlFormBorder.TabIndex = 101;
            // 
            // lblLIGMA
            // 
            this.lblLIGMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLIGMA.AutoSize = true;
            this.lblLIGMA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIGMA.ForeColor = System.Drawing.Color.White;
            this.lblLIGMA.Location = new System.Drawing.Point(40, 6);
            this.lblLIGMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLIGMA.Name = "lblLIGMA";
            this.lblLIGMA.Size = new System.Drawing.Size(63, 23);
            this.lblLIGMA.TabIndex = 11;
            this.lblLIGMA.Text = "LIGMA";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Font = new System.Drawing.Font("Calibri", 11F);
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cmbPeriodo.Location = new System.Drawing.Point(16, 223);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(179, 30);
            this.cmbPeriodo.TabIndex = 105;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPeriodo.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodo.Location = new System.Drawing.Point(11, 194);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(70, 23);
            this.lblPeriodo.TabIndex = 104;
            this.lblPeriodo.Text = "Período";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.Font = new System.Drawing.Font("Calibri", 11F);
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cmbProfessor.Location = new System.Drawing.Point(232, 150);
            this.cmbProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(179, 30);
            this.cmbProfessor.TabIndex = 107;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblProfessor.ForeColor = System.Drawing.Color.Black;
            this.lblProfessor.Location = new System.Drawing.Point(227, 123);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(85, 23);
            this.lblProfessor.TabIndex = 106;
            this.lblProfessor.Text = "Professor";
            // 
            // cmbEstagio
            // 
            this.cmbEstagio.Font = new System.Drawing.Font("Calibri", 11F);
            this.cmbEstagio.FormattingEnabled = true;
            this.cmbEstagio.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cmbEstagio.Location = new System.Drawing.Point(232, 223);
            this.cmbEstagio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstagio.Name = "cmbEstagio";
            this.cmbEstagio.Size = new System.Drawing.Size(179, 30);
            this.cmbEstagio.TabIndex = 109;
            // 
            // lblEstagio
            // 
            this.lblEstagio.AutoSize = true;
            this.lblEstagio.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblEstagio.ForeColor = System.Drawing.Color.Black;
            this.lblEstagio.Location = new System.Drawing.Point(227, 194);
            this.lblEstagio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstagio.Name = "lblEstagio";
            this.lblEstagio.Size = new System.Drawing.Size(65, 23);
            this.lblEstagio.TabIndex = 108;
            this.lblEstagio.Text = "Estágio";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Font = new System.Drawing.Font("Calibri", 11F);
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cmbCurso.Location = new System.Drawing.Point(16, 150);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(179, 30);
            this.cmbCurso.TabIndex = 111;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(11, 123);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(55, 23);
            this.lblCurso.TabIndex = 110;
            this.lblCurso.Text = "Curso";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(103, 52);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 33);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Cadastro da Turma";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.Location = new System.Drawing.Point(212, 295);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 34);
            this.btnCancelar.TabIndex = 114;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnEnviar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.Location = new System.Drawing.Point(323, 295);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(89, 34);
            this.btnEnviar.TabIndex = 113;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::LIGMA.Properties.Resources.MinimizarJanela;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(347, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Size = new System.Drawing.Size(33, 32);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::LIGMA.Properties.Resources.FecharJanela;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(392, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 32);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pcbIcone
            // 
            this.pcbIcone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcone.ErrorImage = global::LIGMA.Properties.Resources.logo;
            this.pcbIcone.Image = global::LIGMA.Properties.Resources._12133tongue_109560;
            this.pcbIcone.InitialImage = global::LIGMA.Properties.Resources.logo;
            this.pcbIcone.Location = new System.Drawing.Point(4, 5);
            this.pcbIcone.Margin = new System.Windows.Forms.Padding(4);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(28, 27);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcone.TabIndex = 10;
            this.pcbIcone.TabStop = false;
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(428, 373);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cmbEstagio);
            this.Controls.Add(this.lblEstagio);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroTurma";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CadastroTurma_Load);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cmbEstagio;
        private System.Windows.Forms.Label lblEstagio;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
    }
}