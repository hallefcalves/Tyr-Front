namespace ServicosRedeN2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCont = new System.Windows.Forms.TabPage();
            this.tabImg = new System.Windows.Forms.TabPage();
            this.txtDados = new System.Windows.Forms.RichTextBox();
            this.btnListaCont = new System.Windows.Forms.Button();
            this.btnDeleta1Cont = new System.Windows.Forms.Button();
            this.btnCriaCont = new System.Windows.Forms.Button();
            this.txtNomeCont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxImg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortaCont = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeContDel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeletaCont = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeletaImg = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnListaImgs = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDeleta1Img = new System.Windows.Forms.Button();
            this.txtNomeDelImg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPullImg = new System.Windows.Forms.Button();
            this.txtNomeImg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTagImg = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCont.SuspendLayout();
            this.tabImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaCont)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImg);
            this.tabControl1.Controls.Add(this.tabCont);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 287);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCont
            // 
            this.tabCont.BackColor = System.Drawing.SystemColors.Control;
            this.tabCont.Controls.Add(this.panel4);
            this.tabCont.Controls.Add(this.panel3);
            this.tabCont.Controls.Add(this.panel2);
            this.tabCont.Controls.Add(this.panel1);
            this.tabCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCont.Location = new System.Drawing.Point(4, 33);
            this.tabCont.Name = "tabCont";
            this.tabCont.Padding = new System.Windows.Forms.Padding(3);
            this.tabCont.Size = new System.Drawing.Size(311, 250);
            this.tabCont.TabIndex = 0;
            this.tabCont.Text = "Containers";
            this.tabCont.Click += new System.EventHandler(this.tabCont_Click);
            // 
            // tabImg
            // 
            this.tabImg.BackColor = System.Drawing.SystemColors.Control;
            this.tabImg.Controls.Add(this.panel5);
            this.tabImg.Controls.Add(this.panel6);
            this.tabImg.Controls.Add(this.panel7);
            this.tabImg.Controls.Add(this.panel8);
            this.tabImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabImg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabImg.Location = new System.Drawing.Point(4, 33);
            this.tabImg.Name = "tabImg";
            this.tabImg.Padding = new System.Windows.Forms.Padding(3);
            this.tabImg.Size = new System.Drawing.Size(311, 250);
            this.tabImg.TabIndex = 1;
            this.tabImg.Text = "Images";
            // 
            // txtDados
            // 
            this.txtDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDados.Location = new System.Drawing.Point(337, 12);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(383, 343);
            this.txtDados.TabIndex = 12;
            this.txtDados.Text = "";
            // 
            // btnListaCont
            // 
            this.btnListaCont.Location = new System.Drawing.Point(7, 4);
            this.btnListaCont.Name = "btnListaCont";
            this.btnListaCont.Size = new System.Drawing.Size(135, 42);
            this.btnListaCont.TabIndex = 1;
            this.btnListaCont.Text = "Listar todos";
            this.btnListaCont.UseVisualStyleBackColor = true;
            this.btnListaCont.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleta1Cont
            // 
            this.btnDeleta1Cont.Location = new System.Drawing.Point(7, 57);
            this.btnDeleta1Cont.Name = "btnDeleta1Cont";
            this.btnDeleta1Cont.Size = new System.Drawing.Size(135, 42);
            this.btnDeleta1Cont.TabIndex = 13;
            this.btnDeleta1Cont.Text = "Deletar por nome";
            this.btnDeleta1Cont.UseVisualStyleBackColor = true;
            this.btnDeleta1Cont.Click += new System.EventHandler(this.btnDeleta1Cont_Click);
            // 
            // btnCriaCont
            // 
            this.btnCriaCont.Location = new System.Drawing.Point(4, 183);
            this.btnCriaCont.Name = "btnCriaCont";
            this.btnCriaCont.Size = new System.Drawing.Size(135, 42);
            this.btnCriaCont.TabIndex = 14;
            this.btnCriaCont.Text = "Criar Container";
            this.btnCriaCont.UseVisualStyleBackColor = true;
            this.btnCriaCont.Click += new System.EventHandler(this.btnCriaCont_Click);
            // 
            // txtNomeCont
            // 
            this.txtNomeCont.Location = new System.Drawing.Point(6, 24);
            this.txtNomeCont.Name = "txtNomeCont";
            this.txtNomeCont.Size = new System.Drawing.Size(100, 24);
            this.txtNomeCont.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Imagem";
            // 
            // cbxImg
            // 
            this.cbxImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxImg.FormattingEnabled = true;
            this.cbxImg.Location = new System.Drawing.Point(6, 83);
            this.cbxImg.Name = "cbxImg";
            this.cbxImg.Size = new System.Drawing.Size(121, 26);
            this.cbxImg.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Porta";
            // 
            // txtPortaCont
            // 
            this.txtPortaCont.Location = new System.Drawing.Point(6, 144);
            this.txtPortaCont.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtPortaCont.Name = "txtPortaCont";
            this.txtPortaCont.Size = new System.Drawing.Size(120, 24);
            this.txtPortaCont.TabIndex = 22;
            this.txtPortaCont.Value = new decimal(new int[] {
            3001,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nome";
            // 
            // txtNomeContDel
            // 
            this.txtNomeContDel.Location = new System.Drawing.Point(7, 27);
            this.txtNomeContDel.Name = "txtNomeContDel";
            this.txtNomeContDel.Size = new System.Drawing.Size(100, 24);
            this.txtNomeContDel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Endereço base";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(16, 329);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(210, 26);
            this.txtUrl.TabIndex = 25;
            this.txtUrl.Text = "http://54.232.160.198:3001";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCriaCont);
            this.panel1.Controls.Add(this.txtNomeCont);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPortaCont);
            this.panel1.Controls.Add(this.cbxImg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 230);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleta1Cont);
            this.panel2.Controls.Add(this.txtNomeContDel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(155, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 114);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnListaCont);
            this.panel3.Location = new System.Drawing.Point(156, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 52);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDeletaCont);
            this.panel4.Location = new System.Drawing.Point(155, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 52);
            this.panel4.TabIndex = 30;
            // 
            // btnDeletaCont
            // 
            this.btnDeletaCont.Location = new System.Drawing.Point(7, 3);
            this.btnDeletaCont.Name = "btnDeletaCont";
            this.btnDeletaCont.Size = new System.Drawing.Size(135, 42);
            this.btnDeletaCont.TabIndex = 1;
            this.btnDeletaCont.Text = "Deletar todos";
            this.btnDeletaCont.UseVisualStyleBackColor = true;
            this.btnDeletaCont.Click += new System.EventHandler(this.btnDeletaCont_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnDeletaImg);
            this.panel5.Location = new System.Drawing.Point(155, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 52);
            this.panel5.TabIndex = 34;
            // 
            // btnDeletaImg
            // 
            this.btnDeletaImg.Location = new System.Drawing.Point(7, 3);
            this.btnDeletaImg.Name = "btnDeletaImg";
            this.btnDeletaImg.Size = new System.Drawing.Size(135, 42);
            this.btnDeletaImg.TabIndex = 1;
            this.btnDeletaImg.Text = "Deletar todas";
            this.btnDeletaImg.UseVisualStyleBackColor = true;
            this.btnDeletaImg.Click += new System.EventHandler(this.btnDeletaImg_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnListaImgs);
            this.panel6.Location = new System.Drawing.Point(82, 190);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 52);
            this.panel6.TabIndex = 33;
            // 
            // btnListaImgs
            // 
            this.btnListaImgs.Location = new System.Drawing.Point(7, 4);
            this.btnListaImgs.Name = "btnListaImgs";
            this.btnListaImgs.Size = new System.Drawing.Size(135, 42);
            this.btnListaImgs.TabIndex = 1;
            this.btnListaImgs.Text = "Listar todas";
            this.btnListaImgs.UseVisualStyleBackColor = true;
            this.btnListaImgs.Click += new System.EventHandler(this.btnListaImgs_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnDeleta1Img);
            this.panel7.Controls.Add(this.txtNomeDelImg);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(155, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(148, 114);
            this.panel7.TabIndex = 32;
            // 
            // btnDeleta1Img
            // 
            this.btnDeleta1Img.Location = new System.Drawing.Point(7, 57);
            this.btnDeleta1Img.Name = "btnDeleta1Img";
            this.btnDeleta1Img.Size = new System.Drawing.Size(135, 42);
            this.btnDeleta1Img.TabIndex = 13;
            this.btnDeleta1Img.Text = "Deletar por nome";
            this.btnDeleta1Img.UseVisualStyleBackColor = true;
            this.btnDeleta1Img.Click += new System.EventHandler(this.btnDeleta1Img_Click);
            // 
            // txtNomeDelImg
            // 
            this.txtNomeDelImg.Location = new System.Drawing.Point(7, 27);
            this.txtNomeDelImg.Name = "txtNomeDelImg";
            this.txtNomeDelImg.Size = new System.Drawing.Size(100, 24);
            this.txtNomeDelImg.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nome";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtTagImg);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnPullImg);
            this.panel8.Controls.Add(this.txtNomeImg);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(7, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(142, 172);
            this.panel8.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome";
            // 
            // btnPullImg
            // 
            this.btnPullImg.Location = new System.Drawing.Point(2, 115);
            this.btnPullImg.Name = "btnPullImg";
            this.btnPullImg.Size = new System.Drawing.Size(135, 42);
            this.btnPullImg.TabIndex = 14;
            this.btnPullImg.Text = "Pull Imagem";
            this.btnPullImg.UseVisualStyleBackColor = true;
            this.btnPullImg.Click += new System.EventHandler(this.btnPullImg_Click);
            // 
            // txtNomeImg
            // 
            this.txtNomeImg.Location = new System.Drawing.Point(6, 24);
            this.txtNomeImg.Name = "txtNomeImg";
            this.txtNomeImg.Size = new System.Drawing.Size(100, 24);
            this.txtNomeImg.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tag";
            // 
            // txtTagImg
            // 
            this.txtTagImg.Location = new System.Drawing.Point(7, 75);
            this.txtTagImg.Name = "txtTagImg";
            this.txtTagImg.Size = new System.Drawing.Size(100, 24);
            this.txtTagImg.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 365);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Orquestrador de Serviços";
            this.tabControl1.ResumeLayout(false);
            this.tabCont.ResumeLayout(false);
            this.tabImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaCont)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCont;
        private System.Windows.Forms.TabPage tabImg;
        private System.Windows.Forms.RichTextBox txtDados;
        private System.Windows.Forms.Button btnListaCont;
        private System.Windows.Forms.ComboBox cbxImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCont;
        private System.Windows.Forms.Button btnCriaCont;
        private System.Windows.Forms.Button btnDeleta1Cont;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeletaCont;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNomeContDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtPortaCont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeletaImg;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnListaImgs;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDeleta1Img;
        private System.Windows.Forms.TextBox txtNomeDelImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTagImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPullImg;
        private System.Windows.Forms.TextBox txtNomeImg;
        private System.Windows.Forms.Label label9;
    }
}

