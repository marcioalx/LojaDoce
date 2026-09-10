namespace LojaDocinhos
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
            lblNomeDoce = new Label();
            txtNomeDoce = new TextBox();
            btnCalcular = new Button();
            lblPrecoUnitario = new Label();
            lblQuantidade = new Label();
            lblIdadeCliente = new Label();
            txtIdadeCliente = new TextBox();
            txtQuantidade = new TextBox();
            txtPrecoUnitario = new TextBox();
            lblNome = new Label();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblParcela = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.Location = new Point(198, 52);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(70, 15);
            lblNomeDoce.TabIndex = 0;
            lblNomeDoce.Text = "Nome Doce";
            // 
            // txtNomeDoce
            // 
            txtNomeDoce.Location = new Point(274, 49);
            txtNomeDoce.Name = "txtNomeDoce";
            txtNomeDoce.Size = new Size(230, 23);
            txtNomeDoce.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(342, 392);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(186, 100);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(82, 15);
            lblPrecoUnitario.TabIndex = 3;
            lblPrecoUnitario.Text = "Preço Unitário";
            lblPrecoUnitario.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(198, 138);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(191, 182);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(76, 15);
            lblIdadeCliente.TabIndex = 5;
            lblIdadeCliente.Text = "Idade Cliente";
            // 
            // txtIdadeCliente
            // 
            txtIdadeCliente.Location = new Point(274, 179);
            txtIdadeCliente.Name = "txtIdadeCliente";
            txtIdadeCliente.Size = new Size(230, 23);
            txtIdadeCliente.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(274, 135);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(230, 23);
            txtQuantidade.TabIndex = 7;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(274, 92);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(230, 23);
            txtPrecoUnitario.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(198, 242);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(198, 267);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 10;
            lblDesconto.Text = "Desconto";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(198, 293);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(61, 15);
            lblValorFinal.TabIndex = 11;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(198, 323);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(45, 15);
            lblParcela.TabIndex = 12;
            lblParcela.Text = "Parcela";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(198, 351);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblParcela);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(lblNome);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(txtQuantidade);
            Controls.Add(txtIdadeCliente);
            Controls.Add(lblIdadeCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(btnCalcular);
            Controls.Add(txtNomeDoce);
            Controls.Add(lblNomeDoce);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoce;
        private TextBox txtNomeDoce;
        private Button btnCalcular;
        private Label lblPrecoUnitario;
        private Label lblQuantidade;
        private Label lblIdadeCliente;
        private TextBox txtIdadeCliente;
        private TextBox txtQuantidade;
        private TextBox txtPrecoUnitario;
        private Label lblNome;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblParcela;
        private Label lblStatus;
    }
}
