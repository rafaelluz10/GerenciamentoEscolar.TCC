
namespace Cantina
{
    partial class frmAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            this.ggbDadosCadastro = new System.Windows.Forms.GroupBox();
            this.btn_addFoto = new System.Windows.Forms.Button();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ggbDadosCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // ggbDadosCadastro
            // 
            this.ggbDadosCadastro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ggbDadosCadastro.Controls.Add(this.btn_addFoto);
            this.ggbDadosCadastro.Controls.Add(this.pb_Foto);
            this.ggbDadosCadastro.Controls.Add(this.lblEstado);
            this.ggbDadosCadastro.Controls.Add(this.cbbEstado);
            this.ggbDadosCadastro.Controls.Add(this.lblCidade);
            this.ggbDadosCadastro.Controls.Add(this.txtCidade);
            this.ggbDadosCadastro.Controls.Add(this.lblBairro);
            this.ggbDadosCadastro.Controls.Add(this.txtBairro);
            this.ggbDadosCadastro.Controls.Add(this.lblNumero);
            this.ggbDadosCadastro.Controls.Add(this.txtNumero);
            this.ggbDadosCadastro.Controls.Add(this.label1);
            this.ggbDadosCadastro.Controls.Add(this.txtEndereco);
            this.ggbDadosCadastro.Controls.Add(this.lblCEP);
            this.ggbDadosCadastro.Controls.Add(this.mskCEP);
            this.ggbDadosCadastro.Controls.Add(this.lblTelefone);
            this.ggbDadosCadastro.Controls.Add(this.mskTelefone);
            this.ggbDadosCadastro.Controls.Add(this.mskCPF);
            this.ggbDadosCadastro.Controls.Add(this.lblCPF);
            this.ggbDadosCadastro.Controls.Add(this.txtEmail);
            this.ggbDadosCadastro.Controls.Add(this.lblEmail);
            this.ggbDadosCadastro.Controls.Add(this.lblNome);
            this.ggbDadosCadastro.Controls.Add(this.txtNome);
            this.ggbDadosCadastro.Controls.Add(this.lblCodigo);
            this.ggbDadosCadastro.Controls.Add(this.txtCodigo);
            this.ggbDadosCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbDadosCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.ggbDadosCadastro.Location = new System.Drawing.Point(12, 12);
            this.ggbDadosCadastro.Name = "ggbDadosCadastro";
            this.ggbDadosCadastro.Size = new System.Drawing.Size(1252, 480);
            this.ggbDadosCadastro.TabIndex = 0;
            this.ggbDadosCadastro.TabStop = false;
            this.ggbDadosCadastro.Text = "Dados de Cadastro";
            // 
            // btn_addFoto
            // 
            this.btn_addFoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addFoto.Location = new System.Drawing.Point(991, 55);
            this.btn_addFoto.Name = "btn_addFoto";
            this.btn_addFoto.Size = new System.Drawing.Size(143, 35);
            this.btn_addFoto.TabIndex = 29;
            this.btn_addFoto.Text = "Adicionar Foto";
            this.btn_addFoto.UseVisualStyleBackColor = true;
            // 
            // pb_Foto
            // 
            this.pb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Foto.Location = new System.Drawing.Point(923, 104);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(278, 293);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Foto.TabIndex = 28;
            this.pb_Foto.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(366, 399);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.ItemHeight = 20;
            this.cbbEstado.Location = new System.Drawing.Point(367, 422);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(172, 28);
            this.cbbEstado.TabIndex = 26;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(17, 401);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(21, 424);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(275, 26);
            this.txtCidade.TabIndex = 24;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(631, 326);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(635, 349);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(211, 26);
            this.txtBairro.TabIndex = 22;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(486, 326);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(490, 349);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(86, 26);
            this.txtNumero.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(21, 349);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(385, 26);
            this.txtEndereco.TabIndex = 17;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(385, 236);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "CEP";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(389, 259);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(96, 26);
            this.mskCEP.TabIndex = 15;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(207, 236);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(211, 259);
            this.mskTelefone.Mask = "99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(97, 26);
            this.mskTelefone.TabIndex = 13;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(21, 259);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(119, 26);
            this.mskCPF.TabIndex = 12;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(17, 236);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 11;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(490, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(486, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(385, 26);
            this.txtNome.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(21, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 509);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(1244, 101);
            this.pnlCRUD.TabIndex = 21;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1060, 30);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 45);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(861, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 47);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(683, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(135, 48);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(525, 29);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 47);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(370, 30);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(118, 45);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(202, 30);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(131, 45);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(21, 30);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(139, 45);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1270, 618);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.ggbDadosCadastro);
            this.Name = "frmAlunos";
            this.Text = "frmAlunos";
            this.ggbDadosCadastro.ResumeLayout(false);
            this.ggbDadosCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ggbDadosCadastro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox pb_Foto;
        private System.Windows.Forms.Button btn_addFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
    }
}