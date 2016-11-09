namespace _01_ErrorProvider
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
            this.components = new System.ComponentModel.Container();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.numHeihgt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numHeihgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInn
            // 
            this.txtInn.Location = new System.Drawing.Point(94, 41);
            this.txtInn.Name = "txtInn";
            this.txtInn.Size = new System.Drawing.Size(120, 20);
            this.txtInn.TabIndex = 0;
            this.txtInn.Validated += new System.EventHandler(this.txtInn_Validated);
            // 
            // numHeihgt
            // 
            this.numHeihgt.Location = new System.Drawing.Point(94, 95);
            this.numHeihgt.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.numHeihgt.Minimum = new decimal(new int[] {
            145,
            0,
            0,
            0});
            this.numHeihgt.Name = "numHeihgt";
            this.numHeihgt.Size = new System.Drawing.Size(120, 20);
            this.numHeihgt.TabIndex = 1;
            this.numHeihgt.Value = new decimal(new int[] {
            165,
            0,
            0,
            0});
            this.numHeihgt.Validated += new System.EventHandler(this.numHeihgt_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heihgt";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHeihgt);
            this.Controls.Add(this.txtInn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHeihgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInn;
        private System.Windows.Forms.NumericUpDown numHeihgt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

