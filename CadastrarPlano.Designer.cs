namespace Academia
{
    partial class CadastrarPlano
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
            btnCadastrar = new Button();
            txtCodPlano = new TextBox();
            txtValorPlano = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtDescricaoPlano = new TextBox();
            label4 = new Label();
            txtPlano = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCadastrar);
            groupBox2.Controls.Add(txtCodPlano);
            groupBox2.Controls.Add(txtValorPlano);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtDescricaoPlano);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPlano);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(67, 106);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(557, 169);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(421, 50);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(101, 70);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCodPlano
            // 
            txtCodPlano.Location = new Point(190, 26);
            txtCodPlano.Margin = new Padding(3, 2, 3, 2);
            txtCodPlano.Name = "txtCodPlano";
            txtCodPlano.Size = new Size(155, 23);
            txtCodPlano.TabIndex = 3;
            // 
            // txtValorPlano
            // 
            txtValorPlano.Location = new Point(190, 123);
            txtValorPlano.Margin = new Padding(3, 2, 3, 2);
            txtValorPlano.Name = "txtValorPlano";
            txtValorPlano.Size = new Size(155, 23);
            txtValorPlano.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 124);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 7;
            label6.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 29);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 0;
            label2.Text = "Codigo do Plano";
            // 
            // txtDescricaoPlano
            // 
            txtDescricaoPlano.Location = new Point(190, 91);
            txtDescricaoPlano.Margin = new Padding(3, 2, 3, 2);
            txtDescricaoPlano.Name = "txtDescricaoPlano";
            txtDescricaoPlano.Size = new Size(155, 23);
            txtDescricaoPlano.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 92);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 4;
            label4.Text = "Descrição";
            // 
            // txtPlano
            // 
            txtPlano.Location = new Point(190, 58);
            txtPlano.Margin = new Padding(3, 2, 3, 2);
            txtPlano.Name = "txtPlano";
            txtPlano.Size = new Size(155, 23);
            txtPlano.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 61);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 0;
            label3.Text = "Plano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 35);
            label1.Name = "label1";
            label1.Size = new Size(280, 47);
            label1.TabIndex = 10;
            label1.Text = "Academia Fenix";
            // 
            // CadastrarPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 334);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastrarPlano";
            Text = "CadastrarPlano";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnCadastrar;
        private TextBox txtCodPlano;
        private TextBox txtValorPlano;
        private Label label6;
        private Label label2;
        private TextBox txtDescricaoPlano;
        private Label label4;
        private TextBox txtPlano;
        private Label label3;
        private Label label1;
    }
}