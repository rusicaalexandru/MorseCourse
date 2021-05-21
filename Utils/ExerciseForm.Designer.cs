
namespace MorseCourse.Utils
{
    partial class ExerciseForm
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
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.richTextBoxTest = new System.Windows.Forms.RichTextBox();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Location = new System.Drawing.Point(28, 288);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(1090, 135);
            this.textBoxAnswer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Answer";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswer.Location = new System.Drawing.Point(28, 485);
            this.buttonAnswer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(817, 51);
            this.buttonAnswer.TabIndex = 2;
            this.buttonAnswer.Text = "Answer";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // richTextBoxTest
            // 
            this.richTextBoxTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxTest.Location = new System.Drawing.Point(28, 27);
            this.richTextBoxTest.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.richTextBoxTest.Name = "richTextBoxTest";
            this.richTextBoxTest.ReadOnly = true;
            this.richTextBoxTest.Size = new System.Drawing.Size(1090, 133);
            this.richTextBoxTest.TabIndex = 3;
            this.richTextBoxTest.Text = "text to be translated";
            // 
            // buttonSkip
            // 
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkip.Location = new System.Drawing.Point(859, 485);
            this.buttonSkip.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(264, 51);
            this.buttonSkip.TabIndex = 4;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 563);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.richTextBoxTest);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnswer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ExerciseForm";
            this.Text = "ExerciseForm";
            this.Load += new System.EventHandler(this.ExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxTest;
        private System.Windows.Forms.Button buttonSkip;
    }
}