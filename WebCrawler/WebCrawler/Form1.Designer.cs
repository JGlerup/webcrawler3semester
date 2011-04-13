namespace WebCrawler
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
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(12, 12);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(326, 22);
            this.tbxUrl.TabIndex = 0;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(344, 15);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(26, 17);
            this.lbUrl.TabIndex = 1;
            this.lbUrl.Text = "Url";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(376, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(1071, 40);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(301, 579);
            this.treeView.TabIndex = 3;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 40);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1053, 579);
            this.webBrowser.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(457, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 631);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.tbxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnClear;
    }
}

