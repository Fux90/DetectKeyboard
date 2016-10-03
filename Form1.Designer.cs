namespace DetectKeyboard
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtConsole2 = new System.Windows.Forms.TextBox();
            this.btnToggleInit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(63, 186);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(330, 178);
            this.txtConsole.TabIndex = 1;
            this.txtConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsole_KeyDown);
            // 
            // txtConsole2
            // 
            this.txtConsole2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole2.Location = new System.Drawing.Point(399, 186);
            this.txtConsole2.Multiline = true;
            this.txtConsole2.Name = "txtConsole2";
            this.txtConsole2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole2.Size = new System.Drawing.Size(330, 178);
            this.txtConsole2.TabIndex = 2;
            this.txtConsole2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsole_KeyDown);
            // 
            // btnToggleInit
            // 
            this.btnToggleInit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleInit.Location = new System.Drawing.Point(3, 80);
            this.btnToggleInit.Name = "btnToggleInit";
            this.btnToggleInit.Size = new System.Drawing.Size(54, 23);
            this.btnToggleInit.TabIndex = 3;
            this.btnToggleInit.Text = "Initialize";
            this.btnToggleInit.UseVisualStyleBackColor = true;
            this.btnToggleInit.Click += new System.EventHandler(this.btnToggleInit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnToggleInit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtConsole2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConsole, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInstruction, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 367);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(210, 85);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(35, 13);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Multiple Keyboards Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TextBox txtConsole2;
        private System.Windows.Forms.Button btnToggleInit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInstruction;
    }
}

