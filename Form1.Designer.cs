namespace calculadora_teste
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
            this.Caixa_resposta = new System.Windows.Forms.TextBox();
            this.igual = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.botao_3 = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.botao_2 = new System.Windows.Forms.Button();
            this.botao_6 = new System.Windows.Forms.Button();
            this.Multiplicalcao = new System.Windows.Forms.Button();
            this.botao_9 = new System.Windows.Forms.Button();
            this.botao_5 = new System.Windows.Forms.Button();
            this.botao_8 = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.Porcentagem = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.botao_0 = new System.Windows.Forms.Button();
            this.botao_1 = new System.Windows.Forms.Button();
            this.botao_4 = new System.Windows.Forms.Button();
            this.botao_7 = new System.Windows.Forms.Button();
            this.limpar_tudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Caixa_resposta
            // 
            this.Caixa_resposta.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa_resposta.Location = new System.Drawing.Point(329, 151);
            this.Caixa_resposta.Multiline = true;
            this.Caixa_resposta.Name = "Caixa_resposta";
            this.Caixa_resposta.Size = new System.Drawing.Size(230, 49);
            this.Caixa_resposta.TabIndex = 1;
            this.Caixa_resposta.TextChanged += new System.EventHandler(this.Caixa_resposta_TextChanged);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.igual.Location = new System.Drawing.Point(506, 425);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(53, 44);
            this.igual.TabIndex = 2;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            // 
            // adicao
            // 
            this.adicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.adicao.Location = new System.Drawing.Point(506, 375);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(53, 44);
            this.adicao.TabIndex = 3;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = false;
            this.adicao.Click += new System.EventHandler(this.button3_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.subtracao.Location = new System.Drawing.Point(506, 325);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(53, 44);
            this.subtracao.TabIndex = 4;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.button4_Click);
            // 
            // botao_3
            // 
            this.botao_3.BackColor = System.Drawing.Color.Gray;
            this.botao_3.Location = new System.Drawing.Point(447, 375);
            this.botao_3.Name = "botao_3";
            this.botao_3.Size = new System.Drawing.Size(53, 44);
            this.botao_3.TabIndex = 6;
            this.botao_3.Text = "3";
            this.botao_3.UseVisualStyleBackColor = false;
            this.botao_3.Click += new System.EventHandler(this.button6_Click);
            // 
            // virgula
            // 
            this.virgula.Location = new System.Drawing.Point(447, 425);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(53, 44);
            this.virgula.TabIndex = 7;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.button7_Click);
            // 
            // botao_2
            // 
            this.botao_2.BackColor = System.Drawing.Color.Gray;
            this.botao_2.Location = new System.Drawing.Point(388, 375);
            this.botao_2.Name = "botao_2";
            this.botao_2.Size = new System.Drawing.Size(53, 44);
            this.botao_2.TabIndex = 8;
            this.botao_2.Text = "2";
            this.botao_2.UseVisualStyleBackColor = false;
            this.botao_2.Click += new System.EventHandler(this.button8_Click);
            // 
            // botao_6
            // 
            this.botao_6.BackColor = System.Drawing.Color.Gray;
            this.botao_6.Location = new System.Drawing.Point(447, 325);
            this.botao_6.Name = "botao_6";
            this.botao_6.Size = new System.Drawing.Size(53, 44);
            this.botao_6.TabIndex = 9;
            this.botao_6.Text = "6";
            this.botao_6.UseVisualStyleBackColor = false;
            this.botao_6.Click += new System.EventHandler(this.button9_Click);
            // 
            // Multiplicalcao
            // 
            this.Multiplicalcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Multiplicalcao.Location = new System.Drawing.Point(506, 275);
            this.Multiplicalcao.Name = "Multiplicalcao";
            this.Multiplicalcao.Size = new System.Drawing.Size(53, 44);
            this.Multiplicalcao.TabIndex = 11;
            this.Multiplicalcao.Text = "x";
            this.Multiplicalcao.UseVisualStyleBackColor = false;
            this.Multiplicalcao.Click += new System.EventHandler(this.button11_Click);
            // 
            // botao_9
            // 
            this.botao_9.BackColor = System.Drawing.Color.Gray;
            this.botao_9.Location = new System.Drawing.Point(447, 275);
            this.botao_9.Name = "botao_9";
            this.botao_9.Size = new System.Drawing.Size(53, 44);
            this.botao_9.TabIndex = 12;
            this.botao_9.Text = "9";
            this.botao_9.UseVisualStyleBackColor = false;
            this.botao_9.Click += new System.EventHandler(this.button12_Click);
            // 
            // botao_5
            // 
            this.botao_5.BackColor = System.Drawing.Color.Gray;
            this.botao_5.Location = new System.Drawing.Point(388, 325);
            this.botao_5.Name = "botao_5";
            this.botao_5.Size = new System.Drawing.Size(53, 44);
            this.botao_5.TabIndex = 13;
            this.botao_5.Text = "5";
            this.botao_5.UseVisualStyleBackColor = false;
            this.botao_5.Click += new System.EventHandler(this.button13_Click);
            // 
            // botao_8
            // 
            this.botao_8.BackColor = System.Drawing.Color.Gray;
            this.botao_8.Location = new System.Drawing.Point(388, 275);
            this.botao_8.Name = "botao_8";
            this.botao_8.Size = new System.Drawing.Size(53, 44);
            this.botao_8.TabIndex = 14;
            this.botao_8.Text = "8";
            this.botao_8.UseVisualStyleBackColor = false;
            this.botao_8.Click += new System.EventHandler(this.button14_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.divisao.Location = new System.Drawing.Point(506, 225);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(53, 44);
            this.divisao.TabIndex = 16;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.button16_Click);
            // 
            // Porcentagem
            // 
            this.Porcentagem.Location = new System.Drawing.Point(447, 225);
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(53, 44);
            this.Porcentagem.TabIndex = 17;
            this.Porcentagem.Text = "%";
            this.Porcentagem.UseVisualStyleBackColor = true;
            this.Porcentagem.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(388, 225);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(53, 44);
            this.button18.TabIndex = 18;
            this.button18.Text = "+/-";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // botao_0
            // 
            this.botao_0.BackColor = System.Drawing.Color.Gray;
            this.botao_0.Location = new System.Drawing.Point(329, 425);
            this.botao_0.Name = "botao_0";
            this.botao_0.Size = new System.Drawing.Size(112, 44);
            this.botao_0.TabIndex = 19;
            this.botao_0.Text = "0";
            this.botao_0.UseVisualStyleBackColor = false;
            this.botao_0.Click += new System.EventHandler(this.button19_Click);
            // 
            // botao_1
            // 
            this.botao_1.BackColor = System.Drawing.Color.Gray;
            this.botao_1.Location = new System.Drawing.Point(329, 375);
            this.botao_1.Name = "botao_1";
            this.botao_1.Size = new System.Drawing.Size(53, 44);
            this.botao_1.TabIndex = 20;
            this.botao_1.Text = "1";
            this.botao_1.UseVisualStyleBackColor = false;
            this.botao_1.Click += new System.EventHandler(this.button20_Click);
            // 
            // botao_4
            // 
            this.botao_4.BackColor = System.Drawing.Color.Gray;
            this.botao_4.Location = new System.Drawing.Point(329, 325);
            this.botao_4.Name = "botao_4";
            this.botao_4.Size = new System.Drawing.Size(53, 44);
            this.botao_4.TabIndex = 21;
            this.botao_4.Text = "4";
            this.botao_4.UseVisualStyleBackColor = false;
            this.botao_4.Click += new System.EventHandler(this.button21_Click);
            // 
            // botao_7
            // 
            this.botao_7.BackColor = System.Drawing.Color.Gray;
            this.botao_7.Location = new System.Drawing.Point(329, 275);
            this.botao_7.Name = "botao_7";
            this.botao_7.Size = new System.Drawing.Size(53, 44);
            this.botao_7.TabIndex = 22;
            this.botao_7.Text = "7";
            this.botao_7.UseVisualStyleBackColor = false;
            this.botao_7.Click += new System.EventHandler(this.button22_Click);
            // 
            // limpar_tudo
            // 
            this.limpar_tudo.Location = new System.Drawing.Point(329, 225);
            this.limpar_tudo.Name = "limpar_tudo";
            this.limpar_tudo.Size = new System.Drawing.Size(53, 44);
            this.limpar_tudo.TabIndex = 23;
            this.limpar_tudo.Text = "AC";
            this.limpar_tudo.UseVisualStyleBackColor = true;
            this.limpar_tudo.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.limpar_tudo);
            this.Controls.Add(this.botao_7);
            this.Controls.Add(this.botao_4);
            this.Controls.Add(this.botao_1);
            this.Controls.Add(this.botao_0);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Porcentagem);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.botao_8);
            this.Controls.Add(this.botao_5);
            this.Controls.Add(this.botao_9);
            this.Controls.Add(this.Multiplicalcao);
            this.Controls.Add(this.botao_6);
            this.Controls.Add(this.botao_2);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.botao_3);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.Caixa_resposta);
            this.Name = "Form1";
            this.Text = "FUNDO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Caixa_resposta;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button botao_3;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button botao_2;
        private System.Windows.Forms.Button botao_6;
        private System.Windows.Forms.Button Multiplicalcao;
        private System.Windows.Forms.Button botao_9;
        private System.Windows.Forms.Button botao_5;
        private System.Windows.Forms.Button botao_8;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button Porcentagem;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button botao_0;
        private System.Windows.Forms.Button botao_1;
        private System.Windows.Forms.Button botao_4;
        private System.Windows.Forms.Button botao_7;
        private System.Windows.Forms.Button limpar_tudo;
    }
}

