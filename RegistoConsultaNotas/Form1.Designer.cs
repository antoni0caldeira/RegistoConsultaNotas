namespace RegistoConsultaNotas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 438);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Registo de Avaliação";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtn3;
        private System.Windows.Forms.ToolStripButton toolStripBtn1;
        private System.Windows.Forms.ToolStripButton toolStripBtn2;
    }
}

