namespace ResizeImage
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
            if(disposing && (components != null))
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
            this.btnResize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResizeFile = new System.Windows.Forms.Button();
            this.txtW1 = new System.Windows.Forms.TextBox();
            this.txtH1 = new System.Windows.Forms.TextBox();
            this.txtH2 = new System.Windows.Forms.TextBox();
            this.txtW2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.Location = new System.Drawing.Point(546, 62);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(107, 25);
            this.btnResize.TabIndex = 1;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Folder";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(92, 10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(561, 20);
            this.txtSource.TabIndex = 3;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(92, 36);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(561, 20);
            this.txtDest.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dest Folder";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(669, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(93, 93);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(560, 20);
            this.txtSourceFile.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Source File";
            // 
            // txtDestFile
            // 
            this.txtDestFile.Location = new System.Drawing.Point(93, 119);
            this.txtDestFile.Name = "txtDestFile";
            this.txtDestFile.Size = new System.Drawing.Size(561, 20);
            this.txtDestFile.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dest File";
            // 
            // btnResizeFile
            // 
            this.btnResizeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResizeFile.Location = new System.Drawing.Point(546, 145);
            this.btnResizeFile.Name = "btnResizeFile";
            this.btnResizeFile.Size = new System.Drawing.Size(107, 25);
            this.btnResizeFile.TabIndex = 13;
            this.btnResizeFile.Text = "Resize";
            this.btnResizeFile.UseVisualStyleBackColor = true;
            this.btnResizeFile.Click += new System.EventHandler(this.btnResizeFile_Click);
            // 
            // txtW1
            // 
            this.txtW1.Location = new System.Drawing.Point(414, 66);
            this.txtW1.Name = "txtW1";
            this.txtW1.Size = new System.Drawing.Size(57, 20);
            this.txtW1.TabIndex = 14;
            this.txtW1.Text = "300";
            this.txtW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtH1
            // 
            this.txtH1.Location = new System.Drawing.Point(483, 65);
            this.txtH1.Name = "txtH1";
            this.txtH1.Size = new System.Drawing.Size(57, 20);
            this.txtH1.TabIndex = 15;
            this.txtH1.Text = "300";
            this.txtH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtH2
            // 
            this.txtH2.Location = new System.Drawing.Point(483, 148);
            this.txtH2.Name = "txtH2";
            this.txtH2.Size = new System.Drawing.Size(57, 20);
            this.txtH2.TabIndex = 17;
            this.txtH2.Text = "300";
            this.txtH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtW2
            // 
            this.txtW2.Location = new System.Drawing.Point(414, 149);
            this.txtW2.Name = "txtW2";
            this.txtW2.Size = new System.Drawing.Size(57, 20);
            this.txtW2.TabIndex = 16;
            this.txtW2.Text = "300";
            this.txtW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 206);
            this.Controls.Add(this.txtH2);
            this.Controls.Add(this.txtW2);
            this.Controls.Add(this.txtH1);
            this.Controls.Add(this.txtW1);
            this.Controls.Add(this.btnResizeFile);
            this.Controls.Add(this.txtDestFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResize);
            this.Name = "Form1";
            this.Text = "Resize Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResizeFile;
        private System.Windows.Forms.TextBox txtW1;
        private System.Windows.Forms.TextBox txtH1;
        private System.Windows.Forms.TextBox txtH2;
        private System.Windows.Forms.TextBox txtW2;

    }
}

