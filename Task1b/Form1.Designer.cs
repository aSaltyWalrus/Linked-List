namespace Task1b
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
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.authorTextbox = new System.Windows.Forms.TextBox();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.isbnTextbox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(128, 79);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(164, 20);
            this.titleTextbox.TabIndex = 0;
            // 
            // authorTextbox
            // 
            this.authorTextbox.Location = new System.Drawing.Point(128, 114);
            this.authorTextbox.Name = "authorTextbox";
            this.authorTextbox.Size = new System.Drawing.Size(164, 20);
            this.authorTextbox.TabIndex = 1;
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.Location = new System.Drawing.Point(128, 150);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(164, 20);
            this.isbnTextbox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(332, 150);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(73, 261);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 7;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(332, 208);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 24);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(517, 79);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(116, 59);
            this.displayButton.TabIndex = 9;
            this.displayButton.Text = "Display List";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(517, 169);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(116, 59);
            this.sortButton.TabIndex = 10;
            this.sortButton.Text = "Sort List";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // isbnTextbox2
            // 
            this.isbnTextbox2.Location = new System.Drawing.Point(128, 212);
            this.isbnTextbox2.Name = "isbnTextbox2";
            this.isbnTextbox2.Size = new System.Drawing.Size(164, 20);
            this.isbnTextbox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ISBN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isbnTextbox2);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.isbnTextbox);
            this.Controls.Add(this.authorTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox authorTextbox;
        private System.Windows.Forms.TextBox isbnTextbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox isbnTextbox2;
        private System.Windows.Forms.Label label4;
    }
}

