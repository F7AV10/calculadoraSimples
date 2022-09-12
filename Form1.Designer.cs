
namespace calculadoraSimples
{
    partial class calculadoraSimples
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
            this.screenFundo = new System.Windows.Forms.PictureBox();
            this.botaoCE = new System.Windows.Forms.Button();
            this.botaoC = new System.Windows.Forms.Button();
            this.botaoPorc = new System.Windows.Forms.Button();
            this.botaoDiv = new System.Windows.Forms.Button();
            this.botaoMult = new System.Windows.Forms.Button();
            this.botaoSoma = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botaoSub = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.botaoIgual = new System.Windows.Forms.Button();
            this.botaoVirgula = new System.Windows.Forms.Button();
            this.botao0 = new System.Windows.Forms.Button();
            this.detail1 = new System.Windows.Forms.PictureBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screenFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1)).BeginInit();
            this.SuspendLayout();
            // 
            // screenFundo
            // 
            this.screenFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.screenFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenFundo.Location = new System.Drawing.Point(12, 39);
            this.screenFundo.Name = "screenFundo";
            this.screenFundo.Size = new System.Drawing.Size(260, 96);
            this.screenFundo.TabIndex = 0;
            this.screenFundo.TabStop = false;
            // 
            // botaoCE
            // 
            this.botaoCE.Location = new System.Drawing.Point(13, 144);
            this.botaoCE.Name = "botaoCE";
            this.botaoCE.Size = new System.Drawing.Size(126, 44);
            this.botaoCE.TabIndex = 1;
            this.botaoCE.Text = "CE";
            this.botaoCE.UseVisualStyleBackColor = true;
            this.botaoCE.Click += new System.EventHandler(this.botaoCE_Click);
            // 
            // botaoC
            // 
            this.botaoC.Location = new System.Drawing.Point(145, 144);
            this.botaoC.Name = "botaoC";
            this.botaoC.Size = new System.Drawing.Size(126, 44);
            this.botaoC.TabIndex = 3;
            this.botaoC.Text = "C";
            this.botaoC.UseVisualStyleBackColor = true;
            this.botaoC.Click += new System.EventHandler(this.botaoC_Click);
            // 
            // botaoPorc
            // 
            this.botaoPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoPorc.Location = new System.Drawing.Point(13, 194);
            this.botaoPorc.Name = "botaoPorc";
            this.botaoPorc.Size = new System.Drawing.Size(60, 44);
            this.botaoPorc.TabIndex = 8;
            this.botaoPorc.Text = "%";
            this.botaoPorc.UseVisualStyleBackColor = true;
            this.botaoPorc.Click += new System.EventHandler(this.botaoPorc_Click);
            // 
            // botaoDiv
            // 
            this.botaoDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoDiv.Location = new System.Drawing.Point(145, 194);
            this.botaoDiv.Name = "botaoDiv";
            this.botaoDiv.Size = new System.Drawing.Size(60, 44);
            this.botaoDiv.TabIndex = 7;
            this.botaoDiv.Text = "/";
            this.botaoDiv.UseVisualStyleBackColor = true;
            this.botaoDiv.Click += new System.EventHandler(this.botaoDiv_Click);
            // 
            // botaoMult
            // 
            this.botaoMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoMult.Location = new System.Drawing.Point(79, 194);
            this.botaoMult.Name = "botaoMult";
            this.botaoMult.Size = new System.Drawing.Size(60, 44);
            this.botaoMult.TabIndex = 6;
            this.botaoMult.Text = "*";
            this.botaoMult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoMult.UseVisualStyleBackColor = true;
            this.botaoMult.Click += new System.EventHandler(this.botaoMult_Click);
            // 
            // botaoSoma
            // 
            this.botaoSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoSoma.Location = new System.Drawing.Point(212, 244);
            this.botaoSoma.Name = "botaoSoma";
            this.botaoSoma.Size = new System.Drawing.Size(60, 44);
            this.botaoSoma.TabIndex = 16;
            this.botaoSoma.Text = "+";
            this.botaoSoma.UseVisualStyleBackColor = true;
            this.botaoSoma.Click += new System.EventHandler(this.botaoSoma_Click);
            // 
            // botao6
            // 
            this.botao6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao6.Location = new System.Drawing.Point(145, 294);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(60, 44);
            this.botao6.TabIndex = 15;
            this.botao6.Text = "6";
            this.botao6.UseVisualStyleBackColor = true;
            this.botao6.Click += new System.EventHandler(this.botao6_Click);
            // 
            // botao5
            // 
            this.botao5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao5.Location = new System.Drawing.Point(79, 294);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(60, 44);
            this.botao5.TabIndex = 14;
            this.botao5.Text = "5";
            this.botao5.UseVisualStyleBackColor = true;
            this.botao5.Click += new System.EventHandler(this.botao5_Click);
            // 
            // botao4
            // 
            this.botao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao4.Location = new System.Drawing.Point(13, 294);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(60, 44);
            this.botao4.TabIndex = 13;
            this.botao4.Text = "4";
            this.botao4.UseVisualStyleBackColor = true;
            this.botao4.Click += new System.EventHandler(this.botao4_Click);
            // 
            // botaoSub
            // 
            this.botaoSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoSub.Location = new System.Drawing.Point(211, 194);
            this.botaoSub.Name = "botaoSub";
            this.botaoSub.Size = new System.Drawing.Size(60, 44);
            this.botaoSub.TabIndex = 12;
            this.botaoSub.Text = "-";
            this.botaoSub.UseVisualStyleBackColor = true;
            this.botaoSub.Click += new System.EventHandler(this.botaoSub_Click);
            // 
            // botao9
            // 
            this.botao9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao9.Location = new System.Drawing.Point(145, 244);
            this.botao9.Name = "botao9";
            this.botao9.Size = new System.Drawing.Size(60, 44);
            this.botao9.TabIndex = 11;
            this.botao9.Text = "9";
            this.botao9.UseVisualStyleBackColor = true;
            this.botao9.Click += new System.EventHandler(this.botao9_Click);
            // 
            // botao8
            // 
            this.botao8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao8.Location = new System.Drawing.Point(79, 244);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(60, 44);
            this.botao8.TabIndex = 10;
            this.botao8.Text = "8";
            this.botao8.UseVisualStyleBackColor = true;
            this.botao8.Click += new System.EventHandler(this.botao8_Click);
            // 
            // botao7
            // 
            this.botao7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao7.Location = new System.Drawing.Point(13, 244);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(60, 44);
            this.botao7.TabIndex = 9;
            this.botao7.Text = "7";
            this.botao7.UseVisualStyleBackColor = true;
            this.botao7.Click += new System.EventHandler(this.botao7_Click);
            // 
            // botao3
            // 
            this.botao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao3.Location = new System.Drawing.Point(145, 344);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(60, 44);
            this.botao3.TabIndex = 19;
            this.botao3.Text = "3";
            this.botao3.UseVisualStyleBackColor = true;
            this.botao3.Click += new System.EventHandler(this.botao3_Click);
            // 
            // botao2
            // 
            this.botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao2.Location = new System.Drawing.Point(79, 344);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(60, 44);
            this.botao2.TabIndex = 18;
            this.botao2.Text = "2";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botao1.Location = new System.Drawing.Point(13, 344);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(60, 44);
            this.botao1.TabIndex = 17;
            this.botao1.Text = "1";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botaoIgual
            // 
            this.botaoIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoIgual.Location = new System.Drawing.Point(211, 294);
            this.botaoIgual.Name = "botaoIgual";
            this.botaoIgual.Size = new System.Drawing.Size(60, 144);
            this.botaoIgual.TabIndex = 24;
            this.botaoIgual.Text = "=";
            this.botaoIgual.UseVisualStyleBackColor = true;
            this.botaoIgual.Click += new System.EventHandler(this.botaoIgual_Click);
            // 
            // botaoVirgula
            // 
            this.botaoVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.botaoVirgula.Location = new System.Drawing.Point(145, 394);
            this.botaoVirgula.Name = "botaoVirgula";
            this.botaoVirgula.Size = new System.Drawing.Size(60, 44);
            this.botaoVirgula.TabIndex = 23;
            this.botaoVirgula.Text = ",";
            this.botaoVirgula.UseVisualStyleBackColor = true;
            this.botaoVirgula.Click += new System.EventHandler(this.botaoVirgula_Click);
            // 
            // botao0
            // 
            this.botao0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao0.Location = new System.Drawing.Point(13, 394);
            this.botao0.Name = "botao0";
            this.botao0.Size = new System.Drawing.Size(126, 44);
            this.botao0.TabIndex = 21;
            this.botao0.Text = "0";
            this.botao0.UseVisualStyleBackColor = true;
            this.botao0.Click += new System.EventHandler(this.botao0_Click);
            // 
            // detail1
            // 
            this.detail1.BackColor = System.Drawing.Color.Black;
            this.detail1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detail1.Location = new System.Drawing.Point(203, 7);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(69, 26);
            this.detail1.TabIndex = 25;
            this.detail1.TabStop = false;
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textResultado.Location = new System.Drawing.Point(20, 96);
            this.textResultado.MaxLength = 16;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(244, 28);
            this.textResultado.TabIndex = 28;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelOperacao.Location = new System.Drawing.Point(21, 98);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(0, 24);
            this.labelOperacao.TabIndex = 29;
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelValor1.ForeColor = System.Drawing.Color.Green;
            this.labelValor1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelValor1.Location = new System.Drawing.Point(25, 67);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValor1.Size = new System.Drawing.Size(0, 26);
            this.labelValor1.TabIndex = 30;
            this.labelValor1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = " 51M973";
            // 
            // calculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.detail1);
            this.Controls.Add(this.botaoIgual);
            this.Controls.Add(this.botaoVirgula);
            this.Controls.Add(this.botao0);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botaoSoma);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.botaoSub);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.botaoPorc);
            this.Controls.Add(this.botaoDiv);
            this.Controls.Add(this.botaoMult);
            this.Controls.Add(this.botaoC);
            this.Controls.Add(this.botaoCE);
            this.Controls.Add(this.screenFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(300, 488);
            this.MinimumSize = new System.Drawing.Size(300, 488);
            this.Name = "calculadoraSimples";
            this.Text = "CALCULADORA";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screenFundo;
        private System.Windows.Forms.Button botaoCE;
        private System.Windows.Forms.Button botaoC;
        private System.Windows.Forms.Button botaoPorc;
        private System.Windows.Forms.Button botaoDiv;
        private System.Windows.Forms.Button botaoMult;
        private System.Windows.Forms.Button botaoSoma;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botaoSub;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botaoIgual;
        private System.Windows.Forms.Button botaoVirgula;
        private System.Windows.Forms.Button botao0;
        private System.Windows.Forms.PictureBox detail1;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.Label label1;
    }
}

