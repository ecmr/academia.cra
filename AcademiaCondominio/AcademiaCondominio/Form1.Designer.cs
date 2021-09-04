
namespace AcademiaCondominio
{
    partial class FrmControleAcesso
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
            this.lblIpServidor = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtIpServidor = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVPacotesDisponiveis = new System.Windows.Forms.ListView();
            this.rdbEnviarDados = new System.Windows.Forms.RadioButton();
            this.rdbReceberDados = new System.Windows.Forms.RadioButton();
            this.lblDescricaoPacote = new System.Windows.Forms.Label();
            this.lsvDescricaoPacote = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPacoteAEnviar = new System.Windows.Forms.Label();
            this.txtPacoteAEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviarPacote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstvBytesEnviados = new System.Windows.Forms.ListView();
            this.lstvBytesRecebidos = new System.Windows.Forms.ListBox();
            this.lstvStringEnviados = new System.Windows.Forms.ListView();
            this.lstvStringRecebidos = new System.Windows.Forms.ListView();
            this.btnLimparEnviados = new System.Windows.Forms.Button();
            this.btnLimparRecebidos = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIpServidor
            // 
            this.lblIpServidor.AutoSize = true;
            this.lblIpServidor.Location = new System.Drawing.Point(15, 35);
            this.lblIpServidor.Name = "lblIpServidor";
            this.lblIpServidor.Size = new System.Drawing.Size(62, 13);
            this.lblIpServidor.TabIndex = 0;
            this.lblIpServidor.Text = "IP Servidor:";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(15, 69);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 13);
            this.lblPorta.TabIndex = 1;
            this.lblPorta.Text = "Porta:";
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Location = new System.Drawing.Point(94, 32);
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.Size = new System.Drawing.Size(166, 20);
            this.txtIpServidor.TabIndex = 2;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(94, 64);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(58, 20);
            this.txtPorta.TabIndex = 3;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(158, 64);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(100, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pacotes disponíveis:";
            // 
            // lstVPacotesDisponiveis
            // 
            this.lstVPacotesDisponiveis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstVPacotesDisponiveis.GridLines = true;
            this.lstVPacotesDisponiveis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstVPacotesDisponiveis.HideSelection = false;
            this.lstVPacotesDisponiveis.Location = new System.Drawing.Point(277, 32);
            this.lstVPacotesDisponiveis.Name = "lstVPacotesDisponiveis";
            this.lstVPacotesDisponiveis.Size = new System.Drawing.Size(195, 118);
            this.lstVPacotesDisponiveis.TabIndex = 6;
            this.lstVPacotesDisponiveis.UseCompatibleStateImageBehavior = false;
            this.lstVPacotesDisponiveis.View = System.Windows.Forms.View.Details;
            // 
            // rdbEnviarDados
            // 
            this.rdbEnviarDados.AutoSize = true;
            this.rdbEnviarDados.Location = new System.Drawing.Point(277, 156);
            this.rdbEnviarDados.Name = "rdbEnviarDados";
            this.rdbEnviarDados.Size = new System.Drawing.Size(89, 17);
            this.rdbEnviarDados.TabIndex = 7;
            this.rdbEnviarDados.TabStop = true;
            this.rdbEnviarDados.Text = "Enviar Dados";
            this.rdbEnviarDados.UseVisualStyleBackColor = true;
            // 
            // rdbReceberDados
            // 
            this.rdbReceberDados.AutoSize = true;
            this.rdbReceberDados.Location = new System.Drawing.Point(372, 156);
            this.rdbReceberDados.Name = "rdbReceberDados";
            this.rdbReceberDados.Size = new System.Drawing.Size(100, 17);
            this.rdbReceberDados.TabIndex = 8;
            this.rdbReceberDados.TabStop = true;
            this.rdbReceberDados.Text = "Receber Dados";
            this.rdbReceberDados.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoPacote
            // 
            this.lblDescricaoPacote.AutoSize = true;
            this.lblDescricaoPacote.Location = new System.Drawing.Point(506, 15);
            this.lblDescricaoPacote.Name = "lblDescricaoPacote";
            this.lblDescricaoPacote.Size = new System.Drawing.Size(110, 13);
            this.lblDescricaoPacote.TabIndex = 9;
            this.lblDescricaoPacote.Text = "Descrição do Pacote:";
            // 
            // lsvDescricaoPacote
            // 
            this.lsvDescricaoPacote.HideSelection = false;
            this.lsvDescricaoPacote.Location = new System.Drawing.Point(509, 35);
            this.lsvDescricaoPacote.Name = "lsvDescricaoPacote";
            this.lsvDescricaoPacote.Size = new System.Drawing.Size(264, 115);
            this.lsvDescricaoPacote.TabIndex = 10;
            this.lsvDescricaoPacote.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnEnviarPacote);
            this.groupBox1.Controls.Add(this.txtPacoteAEnviar);
            this.groupBox1.Controls.Add(this.lblPacoteAEnviar);
            this.groupBox1.Location = new System.Drawing.Point(18, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblPacoteAEnviar
            // 
            this.lblPacoteAEnviar.AutoSize = true;
            this.lblPacoteAEnviar.Location = new System.Drawing.Point(7, 19);
            this.lblPacoteAEnviar.Name = "lblPacoteAEnviar";
            this.lblPacoteAEnviar.Size = new System.Drawing.Size(111, 13);
            this.lblPacoteAEnviar.TabIndex = 0;
            this.lblPacoteAEnviar.Text = "Pacote a ser enviado:";
            // 
            // txtPacoteAEnviar
            // 
            this.txtPacoteAEnviar.Location = new System.Drawing.Point(124, 16);
            this.txtPacoteAEnviar.Name = "txtPacoteAEnviar";
            this.txtPacoteAEnviar.Size = new System.Drawing.Size(407, 20);
            this.txtPacoteAEnviar.TabIndex = 1;
            // 
            // btnEnviarPacote
            // 
            this.btnEnviarPacote.Location = new System.Drawing.Point(554, 16);
            this.btnEnviarPacote.Name = "btnEnviarPacote";
            this.btnEnviarPacote.Size = new System.Drawing.Size(93, 23);
            this.btnEnviarPacote.TabIndex = 2;
            this.btnEnviarPacote.Text = "Enviar Pacote";
            this.btnEnviarPacote.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "bytes enviados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "bytes recebidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "string enviada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "string recebidos:";
            // 
            // lstvBytesEnviados
            // 
            this.lstvBytesEnviados.HideSelection = false;
            this.lstvBytesEnviados.Location = new System.Drawing.Point(15, 252);
            this.lstvBytesEnviados.Name = "lstvBytesEnviados";
            this.lstvBytesEnviados.Size = new System.Drawing.Size(311, 148);
            this.lstvBytesEnviados.TabIndex = 16;
            this.lstvBytesEnviados.UseCompatibleStateImageBehavior = false;
            // 
            // lstvBytesRecebidos
            // 
            this.lstvBytesRecebidos.FormattingEnabled = true;
            this.lstvBytesRecebidos.Location = new System.Drawing.Point(433, 250);
            this.lstvBytesRecebidos.Name = "lstvBytesRecebidos";
            this.lstvBytesRecebidos.Size = new System.Drawing.Size(311, 147);
            this.lstvBytesRecebidos.TabIndex = 17;
            // 
            // lstvStringEnviados
            // 
            this.lstvStringEnviados.HideSelection = false;
            this.lstvStringEnviados.Location = new System.Drawing.Point(18, 420);
            this.lstvStringEnviados.Name = "lstvStringEnviados";
            this.lstvStringEnviados.Size = new System.Drawing.Size(311, 148);
            this.lstvStringEnviados.TabIndex = 18;
            this.lstvStringEnviados.UseCompatibleStateImageBehavior = false;
            // 
            // lstvStringRecebidos
            // 
            this.lstvStringRecebidos.HideSelection = false;
            this.lstvStringRecebidos.Location = new System.Drawing.Point(433, 420);
            this.lstvStringRecebidos.Name = "lstvStringRecebidos";
            this.lstvStringRecebidos.Size = new System.Drawing.Size(311, 148);
            this.lstvStringRecebidos.TabIndex = 19;
            this.lstvStringRecebidos.UseCompatibleStateImageBehavior = false;
            // 
            // btnLimparEnviados
            // 
            this.btnLimparEnviados.Location = new System.Drawing.Point(254, 574);
            this.btnLimparEnviados.Name = "btnLimparEnviados";
            this.btnLimparEnviados.Size = new System.Drawing.Size(75, 23);
            this.btnLimparEnviados.TabIndex = 20;
            this.btnLimparEnviados.Text = "Limpar";
            this.btnLimparEnviados.UseVisualStyleBackColor = true;
            // 
            // btnLimparRecebidos
            // 
            this.btnLimparRecebidos.Location = new System.Drawing.Point(669, 574);
            this.btnLimparRecebidos.Name = "btnLimparRecebidos";
            this.btnLimparRecebidos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparRecebidos.TabIndex = 21;
            this.btnLimparRecebidos.Text = "Limpar";
            this.btnLimparRecebidos.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 170;
            // 
            // FrmControleAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btnLimparRecebidos);
            this.Controls.Add(this.btnLimparEnviados);
            this.Controls.Add(this.lstvStringRecebidos);
            this.Controls.Add(this.lstvStringEnviados);
            this.Controls.Add(this.lstvBytesRecebidos);
            this.Controls.Add(this.lstvBytesEnviados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvDescricaoPacote);
            this.Controls.Add(this.lblDescricaoPacote);
            this.Controls.Add(this.rdbReceberDados);
            this.Controls.Add(this.rdbEnviarDados);
            this.Controls.Add(this.lstVPacotesDisponiveis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIpServidor);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblIpServidor);
            this.Name = "FrmControleAcesso";
            this.Text = "Residência Aricanduva - Academia - Controle de Acesso";
            this.Load += new System.EventHandler(this.FrmControleAcesso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIpServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtIpServidor;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstVPacotesDisponiveis;
        private System.Windows.Forms.RadioButton rdbEnviarDados;
        private System.Windows.Forms.RadioButton rdbReceberDados;
        private System.Windows.Forms.Label lblDescricaoPacote;
        private System.Windows.Forms.ListView lsvDescricaoPacote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviarPacote;
        private System.Windows.Forms.TextBox txtPacoteAEnviar;
        private System.Windows.Forms.Label lblPacoteAEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstvBytesEnviados;
        private System.Windows.Forms.ListBox lstvBytesRecebidos;
        private System.Windows.Forms.ListView lstvStringEnviados;
        private System.Windows.Forms.ListView lstvStringRecebidos;
        private System.Windows.Forms.Button btnLimparEnviados;
        private System.Windows.Forms.Button btnLimparRecebidos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

