namespace v0625
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Esc
            // 
            this.Esc.BackColor = System.Drawing.Color.Magenta;
            this.Esc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Esc.Location = new System.Drawing.Point(46, 36);
            this.Esc.Name = "Esc";
            this.Esc.Size = new System.Drawing.Size(194, 185);
            this.Esc.TabIndex = 0;
            this.Esc.Text = "button1";
            this.Esc.UseVisualStyleBackColor = false;
            this.Esc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Esc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Esc;
    }
}

