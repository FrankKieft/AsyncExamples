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
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.AsyncButton = new System.Windows.Forms.Button();
            this.AsyncWithTaskButton = new System.Windows.Forms.Button();
            this.ParallelButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyncButton
            // 
            this.SyncButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncButton.Location = new System.Drawing.Point(37, 49);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(193, 34);
            this.SyncButton.TabIndex = 0;
            this.SyncButton.Text = "Synchronous";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextbox.Location = new System.Drawing.Point(37, 89);
            this.ResultTextbox.Multiline = true;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextbox.Size = new System.Drawing.Size(1193, 282);
            this.ResultTextbox.TabIndex = 1;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(84, 12);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(63, 20);
            this.NumberTextBox.TabIndex = 2;
            this.NumberTextBox.Text = "424";
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
            // AsyncButton
            // 
            this.AsyncButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsyncButton.Location = new System.Drawing.Point(236, 49);
            this.AsyncButton.Name = "AsyncButton";
            this.AsyncButton.Size = new System.Drawing.Size(193, 34);
            this.AsyncButton.TabIndex = 4;
            this.AsyncButton.Text = "Async, no tasks";
            this.AsyncButton.UseVisualStyleBackColor = true;
            this.AsyncButton.Click += new System.EventHandler(this.ASyncButton_Click);
            // 
            // AsyncWithTaskButton
            // 
            this.AsyncWithTaskButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsyncWithTaskButton.Location = new System.Drawing.Point(435, 49);
            this.AsyncWithTaskButton.Name = "AsyncWithTaskButton";
            this.AsyncWithTaskButton.Size = new System.Drawing.Size(193, 34);
            this.AsyncWithTaskButton.TabIndex = 6;
            this.AsyncWithTaskButton.Text = "Async with tasks";
            this.AsyncWithTaskButton.UseVisualStyleBackColor = true;
            this.AsyncWithTaskButton.Click += new System.EventHandler(this.AsyncWithTaskButton_Click);
            // 
            // ParallelButton
            // 
            this.ParallelButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParallelButton.Location = new System.Drawing.Point(634, 49);
            this.ParallelButton.Name = "ParallelButton";
            this.ParallelButton.Size = new System.Drawing.Size(193, 34);
            this.ParallelButton.TabIndex = 7;
            this.ParallelButton.Text = "Parallel";
            this.ParallelButton.UseVisualStyleBackColor = true;
            this.ParallelButton.Click += new System.EventHandler(this.ParallelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(1161, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(69, 71);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 406);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ParallelButton);
            this.Controls.Add(this.AsyncWithTaskButton);
            this.Controls.Add(this.AsyncButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.SyncButton);
            this.Name = "ExamplesForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button AsyncButton;
        private System.Windows.Forms.Button AsyncWithTaskButton;
        private System.Windows.Forms.Button ParallelButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

