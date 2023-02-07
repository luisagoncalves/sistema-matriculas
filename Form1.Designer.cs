namespace SistemaMatricula
{
    partial class Matricula
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
            this.bt_matricular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lista_matriculados = new System.Windows.Forms.ListView();
            this.colunaNome = new System.Windows.Forms.ColumnHeader();
            this.colunaMatricula = new System.Windows.Forms.ColumnHeader();
            this.colunaDisciplina = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_disciplina = new System.Windows.Forms.TextBox();
            this.input_matricula = new System.Windows.Forms.TextBox();
            this.input_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_matricular
            // 
            this.bt_matricular.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_matricular.Location = new System.Drawing.Point(61, 275);
            this.bt_matricular.Name = "bt_matricular";
            this.bt_matricular.Size = new System.Drawing.Size(154, 27);
            this.bt_matricular.TabIndex = 0;
            this.bt_matricular.Text = "Matricular";
            this.bt_matricular.UseVisualStyleBackColor = true;
            this.bt_matricular.Click += new System.EventHandler(this.bt_matricular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número da matrícula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disciplina";
            // 
            // lista_matriculados
            // 
            this.lista_matriculados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaNome,
            this.colunaMatricula,
            this.colunaDisciplina});
            this.lista_matriculados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lista_matriculados.Location = new System.Drawing.Point(371, 73);
            this.lista_matriculados.Name = "lista_matriculados";
            this.lista_matriculados.Size = new System.Drawing.Size(378, 334);
            this.lista_matriculados.TabIndex = 4;
            this.lista_matriculados.UseCompatibleStateImageBehavior = false;
            this.lista_matriculados.View = System.Windows.Forms.View.Details;
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome";
            this.colunaNome.Width = 130;
            // 
            // colunaMatricula
            // 
            this.colunaMatricula.Text = "Nº Matrícula";
            this.colunaMatricula.Width = 90;
            // 
            // colunaDisciplina
            // 
            this.colunaDisciplina.Text = "Disciplina";
            this.colunaDisciplina.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_disciplina);
            this.groupBox1.Controls.Add(this.input_matricula);
            this.groupBox1.Controls.Add(this.input_nome);
            this.groupBox1.Controls.Add(this.bt_matricular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(44, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 334);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrícula";
            // 
            // input_disciplina
            // 
            this.input_disciplina.Location = new System.Drawing.Point(22, 204);
            this.input_disciplina.Name = "input_disciplina";
            this.input_disciplina.Size = new System.Drawing.Size(232, 27);
            this.input_disciplina.TabIndex = 6;
            // 
            // input_matricula
            // 
            this.input_matricula.Location = new System.Drawing.Point(22, 137);
            this.input_matricula.Name = "input_matricula";
            this.input_matricula.Size = new System.Drawing.Size(232, 27);
            this.input_matricula.TabIndex = 5;
            // 
            // input_nome
            // 
            this.input_nome.Location = new System.Drawing.Point(22, 70);
            this.input_nome.Name = "input_nome";
            this.input_nome.Size = new System.Drawing.Size(232, 27);
            this.input_nome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(295, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sistema de Matrículas";
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lista_matriculados);
            this.Name = "Matricula";
            this.Text = "Sistema de Matrículas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_matricular;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lista_matriculados;
        private GroupBox groupBox1;
        private TextBox input_disciplina;
        private TextBox input_matricula;
        private TextBox input_nome;
        private ColumnHeader colunaNome;
        private ColumnHeader colunaMatricula;
        private ColumnHeader colunaDisciplina;
        private Label label4;
    }
}