namespace Academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExibirAlunos = new Button();
            btnCadastrarAlunos = new Button();
            btnExcluirAlunos = new Button();
            btnAlterarAlunos = new Button();
            btnAlterarPlan = new Button();
            BtnExcluirPlan = new Button();
            btnCadastrarPlan = new Button();
            btnExibirPlan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 44);
            label1.Name = "label1";
            label1.Size = new Size(280, 47);
            label1.TabIndex = 0;
            label1.Text = "Academia Fenix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 123);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 1;
            label2.Text = "Alunos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 123);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 2;
            label3.Text = "Planos";
            // 
            // btnExibirAlunos
            // 
            btnExibirAlunos.Location = new Point(79, 200);
            btnExibirAlunos.Margin = new Padding(3, 2, 3, 2);
            btnExibirAlunos.Name = "btnExibirAlunos";
            btnExibirAlunos.Size = new Size(145, 27);
            btnExibirAlunos.TabIndex = 3;
            btnExibirAlunos.Text = "Exibir";
            btnExibirAlunos.UseVisualStyleBackColor = true;
            btnExibirAlunos.Click += button1_Click;
            // 
            // btnCadastrarAlunos
            // 
            btnCadastrarAlunos.Location = new Point(79, 232);
            btnCadastrarAlunos.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarAlunos.Name = "btnCadastrarAlunos";
            btnCadastrarAlunos.Size = new Size(145, 27);
            btnCadastrarAlunos.TabIndex = 4;
            btnCadastrarAlunos.Text = "Cadastrar";
            btnCadastrarAlunos.UseVisualStyleBackColor = true;
            btnCadastrarAlunos.Click += btnCadastrarAlunos_Click;
            // 
            // btnExcluirAlunos
            // 
            btnExcluirAlunos.Location = new Point(79, 263);
            btnExcluirAlunos.Margin = new Padding(3, 2, 3, 2);
            btnExcluirAlunos.Name = "btnExcluirAlunos";
            btnExcluirAlunos.Size = new Size(145, 26);
            btnExcluirAlunos.TabIndex = 5;
            btnExcluirAlunos.Text = "Excluir";
            btnExcluirAlunos.UseVisualStyleBackColor = true;
            btnExcluirAlunos.Click += btnExcluirAlunos_Click;
            // 
            // btnAlterarAlunos
            // 
            btnAlterarAlunos.Location = new Point(79, 169);
            btnAlterarAlunos.Margin = new Padding(3, 2, 3, 2);
            btnAlterarAlunos.Name = "btnAlterarAlunos";
            btnAlterarAlunos.Size = new Size(145, 27);
            btnAlterarAlunos.TabIndex = 7;
            btnAlterarAlunos.Text = "Alterar";
            btnAlterarAlunos.UseVisualStyleBackColor = true;
            btnAlterarAlunos.Click += btnAlterarAlunos_Click;
            // 
            // btnAlterarPlan
            // 
            btnAlterarPlan.Location = new Point(356, 169);
            btnAlterarPlan.Margin = new Padding(3, 2, 3, 2);
            btnAlterarPlan.Name = "btnAlterarPlan";
            btnAlterarPlan.Size = new Size(145, 27);
            btnAlterarPlan.TabIndex = 11;
            btnAlterarPlan.Text = "Alterar";
            btnAlterarPlan.UseVisualStyleBackColor = true;
            btnAlterarPlan.Click += btnAlterarPlan_Click;
            // 
            // BtnExcluirPlan
            // 
            BtnExcluirPlan.Location = new Point(356, 263);
            BtnExcluirPlan.Margin = new Padding(3, 2, 3, 2);
            BtnExcluirPlan.Name = "BtnExcluirPlan";
            BtnExcluirPlan.Size = new Size(145, 26);
            BtnExcluirPlan.TabIndex = 10;
            BtnExcluirPlan.Text = "Excluir";
            BtnExcluirPlan.UseVisualStyleBackColor = true;
            BtnExcluirPlan.Click += BtnExcluirPlan_Click;
            // 
            // btnCadastrarPlan
            // 
            btnCadastrarPlan.Location = new Point(356, 232);
            btnCadastrarPlan.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarPlan.Name = "btnCadastrarPlan";
            btnCadastrarPlan.Size = new Size(145, 27);
            btnCadastrarPlan.TabIndex = 9;
            btnCadastrarPlan.Text = "Cadastrar";
            btnCadastrarPlan.UseVisualStyleBackColor = true;
            btnCadastrarPlan.Click += btnCadastrarPlan_Click;
            // 
            // btnExibirPlan
            // 
            btnExibirPlan.Location = new Point(356, 200);
            btnExibirPlan.Margin = new Padding(3, 2, 3, 2);
            btnExibirPlan.Name = "btnExibirPlan";
            btnExibirPlan.Size = new Size(145, 27);
            btnExibirPlan.TabIndex = 8;
            btnExibirPlan.Text = "Exibir";
            btnExibirPlan.UseVisualStyleBackColor = true;
            btnExibirPlan.Click += btnExibirPlan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 345);
            Controls.Add(btnAlterarPlan);
            Controls.Add(BtnExcluirPlan);
            Controls.Add(btnCadastrarPlan);
            Controls.Add(btnExibirPlan);
            Controls.Add(btnAlterarAlunos);
            Controls.Add(btnExcluirAlunos);
            Controls.Add(btnCadastrarAlunos);
            Controls.Add(btnExibirAlunos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Início";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExibirAlunos;
        private Button btnCadastrarAlunos;
        private Button btnExcluirAlunos;
        private Button btnAlterarAlunos;
        private Button btnAlterarPlan;
        private Button BtnExcluirPlan;
        private Button btnCadastrarPlan;
        private Button btnExibirPlan;
    }
}
