namespace w4_inclass3
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
            this.lblAnimals = new System.Windows.Forms.Label();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblAnimals
            // 
            this.lblAnimals.AutoSize = true;
            this.lblAnimals.Location = new System.Drawing.Point(28, 31);
            this.lblAnimals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(57, 17);
            this.lblAnimals.TabIndex = 0;
            this.lblAnimals.Text = "Animals";
            // 
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.ItemHeight = 16;
            this.lstAnimals.Location = new System.Drawing.Point(31, 73);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(180, 228);
            this.lstAnimals.TabIndex = 1;
            this.lstAnimals.SelectedIndexChanged += new System.EventHandler(this.lstAnimals_SelectedIndexChanged);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(255, 73);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(35, 17);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "New";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(258, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(258, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 33);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(258, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(296, 70);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(100, 23);
            this.txtNew.TabIndex = 3;
            this.txtNew.TextChanged += new System.EventHandler(this.txtNew_TextChanged);
            this.txtNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterTextBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 337);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lstAnimals);
            this.Controls.Add(this.lblAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ListBox Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimals;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox txtNew;
    }
}

