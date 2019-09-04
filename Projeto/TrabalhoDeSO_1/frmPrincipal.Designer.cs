namespace TrabalhoDeSO_1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.gridVetor_E = new System.Windows.Forms.DataGridView();
            this.gridVetor_D = new System.Windows.Forms.DataGridView();
            this.gridMatriz_R = new System.Windows.Forms.DataGridView();
            this.gridMatriz_C = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnProximoPasso = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLinhaColuna = new System.Windows.Forms.Button();
            this.btnGerarVetorDAutomaticamente = new System.Windows.Forms.Button();
            this.checkBoxLentamente = new System.Windows.Forms.CheckBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarConfiguraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verDocumentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridVetor_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVetor_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMatriz_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMatriz_C)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETECÇÃO DO DEADLOCK COM VÁRIOS RECURSOS DE CADA TIPO ";
            // 
            // gridVetor_E
            // 
            this.gridVetor_E.AllowUserToAddRows = false;
            this.gridVetor_E.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridVetor_E.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVetor_E.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridVetor_E.Location = new System.Drawing.Point(72, 68);
            this.gridVetor_E.Name = "gridVetor_E";
            this.gridVetor_E.Size = new System.Drawing.Size(702, 46);
            this.gridVetor_E.TabIndex = 1;
            // 
            // gridVetor_D
            // 
            this.gridVetor_D.AllowUserToAddRows = false;
            this.gridVetor_D.AllowUserToDeleteRows = false;
            this.gridVetor_D.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridVetor_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVetor_D.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridVetor_D.Location = new System.Drawing.Point(72, 142);
            this.gridVetor_D.Name = "gridVetor_D";
            this.gridVetor_D.Size = new System.Drawing.Size(702, 46);
            this.gridVetor_D.TabIndex = 2;
            // 
            // gridMatriz_R
            // 
            this.gridMatriz_R.AllowUserToAddRows = false;
            this.gridMatriz_R.AllowUserToDeleteRows = false;
            this.gridMatriz_R.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMatriz_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMatriz_R.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMatriz_R.Location = new System.Drawing.Point(72, 351);
            this.gridMatriz_R.Name = "gridMatriz_R";
            this.gridMatriz_R.Size = new System.Drawing.Size(702, 101);
            this.gridMatriz_R.TabIndex = 4;
            // 
            // gridMatriz_C
            // 
            this.gridMatriz_C.AllowUserToAddRows = false;
            this.gridMatriz_C.AllowUserToDeleteRows = false;
            this.gridMatriz_C.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMatriz_C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMatriz_C.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMatriz_C.Location = new System.Drawing.Point(72, 220);
            this.gridMatriz_C.Name = "gridMatriz_C";
            this.gridMatriz_C.Size = new System.Drawing.Size(702, 108);
            this.gridMatriz_C.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vetor E - Recursos Existentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vetor D - Recursos Disponiveis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matriz C - Alocação Corrente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matriz R - Requisições";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Location = new System.Drawing.Point(72, 464);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Visible = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnProximoPasso
            // 
            this.btnProximoPasso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximoPasso.Location = new System.Drawing.Point(290, 458);
            this.btnProximoPasso.Name = "btnProximoPasso";
            this.btnProximoPasso.Size = new System.Drawing.Size(285, 34);
            this.btnProximoPasso.TabIndex = 11;
            this.btnProximoPasso.Text = "Proximo Passo";
            this.btnProximoPasso.UseVisualStyleBackColor = true;
            this.btnProximoPasso.Visible = false;
            this.btnProximoPasso.Click += new System.EventHandler(this.BtnProximoPasso_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(153, 464);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnLinhaColuna
            // 
            this.btnLinhaColuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinhaColuna.Location = new System.Drawing.Point(617, 458);
            this.btnLinhaColuna.Name = "btnLinhaColuna";
            this.btnLinhaColuna.Size = new System.Drawing.Size(157, 34);
            this.btnLinhaColuna.TabIndex = 13;
            this.btnLinhaColuna.Text = "Inserir Processo/Recurso";
            this.btnLinhaColuna.UseVisualStyleBackColor = true;
            this.btnLinhaColuna.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // btnGerarVetorDAutomaticamente
            // 
            this.btnGerarVetorDAutomaticamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarVetorDAutomaticamente.Location = new System.Drawing.Point(573, 194);
            this.btnGerarVetorDAutomaticamente.Name = "btnGerarVetorDAutomaticamente";
            this.btnGerarVetorDAutomaticamente.Size = new System.Drawing.Size(201, 23);
            this.btnGerarVetorDAutomaticamente.TabIndex = 14;
            this.btnGerarVetorDAutomaticamente.Text = "Gerar Vetor D Automaticamente";
            this.btnGerarVetorDAutomaticamente.UseVisualStyleBackColor = true;
            this.btnGerarVetorDAutomaticamente.Visible = false;
            this.btnGerarVetorDAutomaticamente.Click += new System.EventHandler(this.BtnGerarVetorDAutomaticamente_Click);
            // 
            // checkBoxLentamente
            // 
            this.checkBoxLentamente.AutoSize = true;
            this.checkBoxLentamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLentamente.Location = new System.Drawing.Point(602, 48);
            this.checkBoxLentamente.Name = "checkBoxLentamente";
            this.checkBoxLentamente.Size = new System.Drawing.Size(172, 17);
            this.checkBoxLentamente.TabIndex = 15;
            this.checkBoxLentamente.Text = "Ver Procesamento Lentamente";
            this.checkBoxLentamente.UseVisualStyleBackColor = true;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(271, 47);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(69, 17);
            this.labelDescricao.TabIndex = 16;
            this.labelDescricao.Text = "descricao";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.verDocumentaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarConfiguraçõesToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::TrabalhoDeSO_1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Document;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // buscarConfiguraçõesToolStripMenuItem
            // 
            this.buscarConfiguraçõesToolStripMenuItem.Image = global::TrabalhoDeSO_1.Properties.Resources.Double_J_Design_Ravenna_3d_Tools;
            this.buscarConfiguraçõesToolStripMenuItem.Name = "buscarConfiguraçõesToolStripMenuItem";
            this.buscarConfiguraçõesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.buscarConfiguraçõesToolStripMenuItem.Text = "Buscar Configurações";
            this.buscarConfiguraçõesToolStripMenuItem.Click += new System.EventHandler(this.BuscarConfiguraçõesToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Image = global::TrabalhoDeSO_1.Properties.Resources.Aha_Soft_Standard_Portfolio_About;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Image = global::TrabalhoDeSO_1.Properties.Resources.Aha_Soft_Standard_Portfolio_About;
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.SobreToolStripMenuItem1_Click);
            // 
            // verDocumentaçãoToolStripMenuItem
            // 
            this.verDocumentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioToolStripMenuItem});
            this.verDocumentaçãoToolStripMenuItem.Image = global::TrabalhoDeSO_1.Properties.Resources.Treetog_Junior_Folder_documents;
            this.verDocumentaçãoToolStripMenuItem.Name = "verDocumentaçãoToolStripMenuItem";
            this.verDocumentaçãoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.verDocumentaçãoToolStripMenuItem.Text = "Documentação";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.RelatorioToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(835, 504);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.checkBoxLentamente);
            this.Controls.Add(this.btnGerarVetorDAutomaticamente);
            this.Controls.Add(this.btnLinhaColuna);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnProximoPasso);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridMatriz_C);
            this.Controls.Add(this.gridMatriz_R);
            this.Controls.Add(this.gridVetor_D);
            this.Controls.Add(this.gridVetor_E);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeadLock - Sistemas Operacionais";
            ((System.ComponentModel.ISupportInitialize)(this.gridVetor_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVetor_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMatriz_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMatriz_C)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridVetor_E;
        private System.Windows.Forms.DataGridView gridVetor_D;
        private System.Windows.Forms.DataGridView gridMatriz_R;
        private System.Windows.Forms.DataGridView gridMatriz_C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnProximoPasso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLinhaColuna;
        private System.Windows.Forms.Button btnGerarVetorDAutomaticamente;
        private System.Windows.Forms.CheckBox checkBoxLentamente;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarConfiguraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verDocumentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
    }
}

