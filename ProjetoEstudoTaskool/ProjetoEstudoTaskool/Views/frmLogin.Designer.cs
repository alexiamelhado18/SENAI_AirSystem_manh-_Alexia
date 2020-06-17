namespace ProjetoEstudoTaskool
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgSitu = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.inputUser = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNUsuario = new System.Windows.Forms.Button();
            this.btnPortugues = new System.Windows.Forms.Button();
            this.btnIngles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSitu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSitu
            // 
            this.imgSitu.Location = new System.Drawing.Point(34, 49);
            this.imgSitu.Name = "imgSitu";
            this.imgSitu.Size = new System.Drawing.Size(321, 329);
            this.imgSitu.TabIndex = 0;
            this.imgSitu.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(413, 49);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(225, 99);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(420, 178);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 18);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuário";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(603, 23);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(35, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "label2";
            this.lblHorario.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputUser
            // 
            this.inputUser.Location = new System.Drawing.Point(423, 199);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(215, 20);
            this.inputUser.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSenha.Location = new System.Drawing.Point(420, 232);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(423, 253);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(215, 20);
            this.inputSenha.TabIndex = 6;
            this.inputSenha.TextChanged += new System.EventHandler(this.inputSenha_TextChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdioma.Location = new System.Drawing.Point(420, 293);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(52, 18);
            this.lblIdioma.TabIndex = 7;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(423, 373);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(60, 29);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(489, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 29);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnNUsuario
            // 
            this.btnNUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNUsuario.Location = new System.Drawing.Point(545, 373);
            this.btnNUsuario.Name = "btnNUsuario";
            this.btnNUsuario.Size = new System.Drawing.Size(93, 29);
            this.btnNUsuario.TabIndex = 11;
            this.btnNUsuario.Text = "Novo usuário";
            this.btnNUsuario.UseVisualStyleBackColor = true;
            this.btnNUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPortugues
            // 
            this.btnPortugues.Location = new System.Drawing.Point(422, 322);
            this.btnPortugues.Name = "btnPortugues";
            this.btnPortugues.Size = new System.Drawing.Size(75, 23);
            this.btnPortugues.TabIndex = 12;
            this.btnPortugues.Text = "Português";
            this.btnPortugues.UseVisualStyleBackColor = true;
            this.btnPortugues.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngles
            // 
            this.btnIngles.Location = new System.Drawing.Point(503, 322);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(75, 23);
            this.btnIngles.TabIndex = 13;
            this.btnIngles.Text = "Inglês";
            this.btnIngles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.btnPortugues);
            this.Controls.Add(this.btnNUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.imgSitu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSitu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSitu;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNUsuario;
        private System.Windows.Forms.Button btnPortugues;
        private System.Windows.Forms.Button btnIngles;
    }
}

