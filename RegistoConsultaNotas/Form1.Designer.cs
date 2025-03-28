namespace RegistoConsultaNotas
{
    partial class frmRegisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn3 = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nudPortugues = new System.Windows.Forms.NumericUpDown();
            this.nudMatematica = new System.Windows.Forms.NumericUpDown();
            this.nudTIC = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortugues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTIC)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn1,
            this.toolStripBtn2,
            this.toolStripBtn3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 83);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtn1
            // 
            this.toolStripBtn1.AutoSize = false;
            this.toolStripBtn1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn1.Image")));
            this.toolStripBtn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn1.Name = "toolStripBtn1";
            this.toolStripBtn1.Size = new System.Drawing.Size(80, 80);
            this.toolStripBtn1.Text = "Inserir";
            this.toolStripBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtn1.Click += new System.EventHandler(this.toolStripBtn1_Click);
            // 
            // toolStripBtn2
            // 
            this.toolStripBtn2.AutoSize = false;
            this.toolStripBtn2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn2.Image")));
            this.toolStripBtn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn2.Name = "toolStripBtn2";
            this.toolStripBtn2.Size = new System.Drawing.Size(80, 80);
            this.toolStripBtn2.Text = "Limpar";
            this.toolStripBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtn2.Click += new System.EventHandler(this.toolStripBtn2_Click);
            // 
            // toolStripBtn3
            // 
            this.toolStripBtn3.AutoSize = false;
            this.toolStripBtn3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn3.Image")));
            this.toolStripBtn3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn3.Name = "toolStripBtn3";
            this.toolStripBtn3.Size = new System.Drawing.Size(80, 80);
            this.toolStripBtn3.Text = "Consultar";
            this.toolStripBtn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtn3.Click += new System.EventHandler(this.toolStripBtn3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 146);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // nudPortugues
            // 
            this.nudPortugues.Location = new System.Drawing.Point(111, 231);
            this.nudPortugues.Name = "nudPortugues";
            this.nudPortugues.Size = new System.Drawing.Size(120, 20);
            this.nudPortugues.TabIndex = 2;
            // 
            // nudMatematica
            // 
            this.nudMatematica.Location = new System.Drawing.Point(111, 267);
            this.nudMatematica.Name = "nudMatematica";
            this.nudMatematica.Size = new System.Drawing.Size(120, 20);
            this.nudMatematica.TabIndex = 3;
            // 
            // nudTIC
            // 
            this.nudTIC.Location = new System.Drawing.Point(111, 305);
            this.nudTIC.Name = "nudTIC";
            this.nudTIC.Size = new System.Drawing.Size(120, 20);
            this.nudTIC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Português";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matemática";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TIC";
            // 
            // frmRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 438);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTIC);
            this.Controls.Add(this.nudMatematica);
            this.Controls.Add(this.nudPortugues);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRegisto";
            this.Text = "Registo de Avaliação";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortugues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtn3;
        private System.Windows.Forms.ToolStripButton toolStripBtn1;
        private System.Windows.Forms.ToolStripButton toolStripBtn2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nudPortugues;
        private System.Windows.Forms.NumericUpDown nudMatematica;
        private System.Windows.Forms.NumericUpDown nudTIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

