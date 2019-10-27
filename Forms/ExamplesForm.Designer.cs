namespace AsyncExamples.Forms
{
    partial class ExamplesForm
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
            this.SyncButton = new System.Windows.Forms.Button();
            this.SyncTextbox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.AsyncTextBox = new System.Windows.Forms.TextBox();
            this.AsyncButton = new System.Windows.Forms.Button();
            this.AsyncWithTaskTextBox = new System.Windows.Forms.TextBox();
            this.AsyncWithTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyncButton
            // 
            this.SyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SyncButton.Location = new System.Drawing.Point(37, 49);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(1124, 34);
            this.SyncButton.TabIndex = 0;
            this.SyncButton.Text = "Synchronous";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // SyncTextbox
            // 
            this.SyncTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SyncTextbox.Location = new System.Drawing.Point(37, 89);
            this.SyncTextbox.Multiline = true;
            this.SyncTextbox.Name = "SyncTextbox";
            this.SyncTextbox.Size = new System.Drawing.Size(1124, 200);
            this.SyncTextbox.TabIndex = 1;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(84, 12);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(63, 20);
            this.NumberTextBox.TabIndex = 2;
            this.NumberTextBox.Text = "24";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(34, 15);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(44, 13);
            this.Label.TabIndex = 3;
            this.Label.Text = "Number";
            // 
            // AsyncTextBox
            // 
            this.AsyncTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncTextBox.Location = new System.Drawing.Point(37, 335);
            this.AsyncTextBox.Multiline = true;
            this.AsyncTextBox.Name = "AsyncTextBox";
            this.AsyncTextBox.Size = new System.Drawing.Size(1124, 200);
            this.AsyncTextBox.TabIndex = 5;
            // 
            // AsyncButton
            // 
            this.AsyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncButton.Location = new System.Drawing.Point(37, 295);
            this.AsyncButton.Name = "AsyncButton";
            this.AsyncButton.Size = new System.Drawing.Size(1124, 34);
            this.AsyncButton.TabIndex = 4;
            this.AsyncButton.Text = "Async (Works synchronous without tasks)";
            this.AsyncButton.UseVisualStyleBackColor = true;
            this.AsyncButton.Click += new System.EventHandler(this.ASyncButton_Click);
            // 
            // AsyncWithTaskTextBox
            // 
            this.AsyncWithTaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncWithTaskTextBox.Location = new System.Drawing.Point(37, 581);
            this.AsyncWithTaskTextBox.Multiline = true;
            this.AsyncWithTaskTextBox.Name = "AsyncWithTaskTextBox";
            this.AsyncWithTaskTextBox.Size = new System.Drawing.Size(1124, 200);
            this.AsyncWithTaskTextBox.TabIndex = 7;
            // 
            // AsyncWithTaskButton
            // 
            this.AsyncWithTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncWithTaskButton.Location = new System.Drawing.Point(37, 541);
            this.AsyncWithTaskButton.Name = "AsyncWithTaskButton";
            this.AsyncWithTaskButton.Size = new System.Drawing.Size(1124, 34);
            this.AsyncWithTaskButton.TabIndex = 6;
            this.AsyncWithTaskButton.Text = "Async with tasks created";
            this.AsyncWithTaskButton.UseVisualStyleBackColor = true;
            this.AsyncWithTaskButton.Click += new System.EventHandler(this.AsyncWithTaskButton_Click);
            // 
            // ExamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 789);
            this.Controls.Add(this.AsyncWithTaskTextBox);
            this.Controls.Add(this.AsyncWithTaskButton);
            this.Controls.Add(this.AsyncTextBox);
            this.Controls.Add(this.AsyncButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.SyncTextbox);
            this.Controls.Add(this.SyncButton);
            this.Name = "ExamplesForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.TextBox SyncTextbox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox AsyncTextBox;
        private System.Windows.Forms.Button AsyncButton;
        private System.Windows.Forms.TextBox AsyncWithTaskTextBox;
        private System.Windows.Forms.Button AsyncWithTaskButton;
    }
}

