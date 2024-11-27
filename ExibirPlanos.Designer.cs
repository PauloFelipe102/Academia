namespace Academia
{
    partial class ExibirPlanos
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
            groupBox2 = new GroupBox();
            txtValorPlano = new TextBox();
            label6 = new Label();
            txtDescricaoPlano = new TextBox();
            label4 = new Label();
            txtPlano = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            txtCodPlano = new TextBox();
            BtnPesquisar = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtValorPlano);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDescricaoPlano);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPlano);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(72, 151);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(557, 142);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // txtValorPlano
            // 
            txtValorPlano.Location = new Point(190, 95);
            txtValorPlano.Margin = new Padding(3, 2, 3, 2);
            txtValorPlano.Name = "txtValorPlano";
            txtValorPlano.Size = new Size(155, 23);
            txtValorPlano.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 96);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 7;
            label6.Text = "Valor";
            // 
            // txtDescricaoPlano
            // 
            txtDescricaoPlano.Location = new Point(190, 63);
            txtDescricaoPlano.Margin = new Padding(3, 2, 3, 2);
            txtDescricaoPlano.Name = "txtDescricaoPlano";
            txtDescricaoPlano.Size = new Size(155, 23);
            txtDescricaoPlano.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 64);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 4;
            label4.Text = "Descrição";
            // 
            // txtPlano
            // 
            txtPlano.Location = new Point(190, 30);
            txtPlano.Margin = new Padding(3, 2, 3, 2);
            txtPlano.Name = "txtPlano";
            txtPlano.Size = new Size(155, 23);
            txtPlano.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 33);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 0;
            label3.Text = "Plano";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(txtCodPlano);
            groupBox1.Controls.Add(BtnPesquisar);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(72, 74);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(557, 73);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(456, 29);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(82, 22);
            btnLimpar.TabIndex = 19;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtCodPlano
            // 
            txtCodPlano.Location = new Point(190, 30);
            txtCodPlano.Margin = new Padding(3, 2, 3, 2);
            txtCodPlano.Name = "txtCodPlano";
            txtCodPlano.Size = new Size(155, 23);
            txtCodPlano.TabIndex = 3;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(350, 29);
            BtnPesquisar.Margin = new Padding(3, 2, 3, 2);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(101, 22);
            BtnPesquisar.TabIndex = 1;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 33);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 0;
            label2.Text = "Codigo do Plano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 26);
            label1.Name = "label1";
            label1.Size = new Size(280, 47);
            label1.TabIndex = 4;
            label1.Text = "Academia Fenix";
            // 
            // ExibirPlanos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 345);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExibirPlanos";
            Text = "ExibirPlanos";
            Load += ExibirPlanos_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtValorPlano;
        private Label label6;
        private TextBox txtDescricaoPlano;
        private Label label4;
        private TextBox txtPlano;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnLimpar;
        private TextBox txtCodPlano;
        private Button BtnPesquisar;
        private Label label2;
        private Label label1;
    }
}