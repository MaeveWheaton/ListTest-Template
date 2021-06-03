namespace ListTest
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reverseOutput = new System.Windows.Forms.Label();
            this.sortOutput = new System.Windows.Forms.Label();
            this.originalOutput = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-8, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1107, 124);
            this.titleLabel.TabIndex = 34;
            this.titleLabel.Text = "List Examples";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Black;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(768, 284);
            this.removeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(232, 74);
            this.removeButton.TabIndex = 33;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(507, 284);
            this.addButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(232, 74);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(400, 191);
            this.inputBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(593, 44);
            this.inputBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter a Name:";
            // 
            // reverseOutput
            // 
            this.reverseOutput.BackColor = System.Drawing.Color.White;
            this.reverseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseOutput.Location = new System.Drawing.Point(725, 515);
            this.reverseOutput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.reverseOutput.Name = "reverseOutput";
            this.reverseOutput.Size = new System.Drawing.Size(275, 348);
            this.reverseOutput.TabIndex = 29;
            // 
            // sortOutput
            // 
            this.sortOutput.BackColor = System.Drawing.Color.White;
            this.sortOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOutput.Location = new System.Drawing.Point(408, 515);
            this.sortOutput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.sortOutput.Name = "sortOutput";
            this.sortOutput.Size = new System.Drawing.Size(275, 348);
            this.sortOutput.TabIndex = 28;
            // 
            // originalOutput
            // 
            this.originalOutput.BackColor = System.Drawing.Color.White;
            this.originalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalOutput.Location = new System.Drawing.Point(88, 515);
            this.originalOutput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.originalOutput.Name = "originalOutput";
            this.originalOutput.Size = new System.Drawing.Size(275, 348);
            this.originalOutput.TabIndex = 27;
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.ForeColor = System.Drawing.Color.White;
            this.displayButton.Location = new System.Drawing.Point(85, 405);
            this.displayButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(915, 76);
            this.displayButton.TabIndex = 26;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1096, 920);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reverseOutput);
            this.Controls.Add(this.sortOutput);
            this.Controls.Add(this.originalOutput);
            this.Controls.Add(this.displayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reverseOutput;
        private System.Windows.Forms.Label sortOutput;
        private System.Windows.Forms.Label originalOutput;
        private System.Windows.Forms.Button displayButton;
    }
}

