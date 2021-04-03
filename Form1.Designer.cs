
namespace MorseCourse
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTranslateToMorse = new System.Windows.Forms.Button();
            this.textBoxOutputMorse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonClearCurent = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonTranslateToText = new System.Windows.Forms.Button();
            this.textBoxOutputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInputMorse = new System.Windows.Forms.TextBox();
            this.buttonClearTextTr = new System.Windows.Forms.Button();
            this.buttonClearMorseTr = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClearMorseTr);
            this.tabPage1.Controls.Add(this.buttonClearTextTr);
            this.tabPage1.Controls.Add(this.buttonTranslateToText);
            this.tabPage1.Controls.Add(this.textBoxOutputText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxInputMorse);
            this.tabPage1.Controls.Add(this.buttonTranslateToMorse);
            this.tabPage1.Controls.Add(this.textBoxOutputMorse);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxInputText);
            this.tabPage1.Controls.Add(this.buttonTest);
            this.tabPage1.Controls.Add(this.buttonClearCurent);
            this.tabPage1.Controls.Add(this.button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateToMorse
            // 
            this.buttonTranslateToMorse.Location = new System.Drawing.Point(687, 7);
            this.buttonTranslateToMorse.Name = "buttonTranslateToMorse";
            this.buttonTranslateToMorse.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslateToMorse.TabIndex = 7;
            this.buttonTranslateToMorse.Text = "Translate";
            this.buttonTranslateToMorse.UseVisualStyleBackColor = true;
            this.buttonTranslateToMorse.Click += new System.EventHandler(this.buttonTranslateToMorse_Click);
            // 
            // textBoxOutputMorse
            // 
            this.textBoxOutputMorse.Location = new System.Drawing.Point(56, 40);
            this.textBoxOutputMorse.Name = "textBoxOutputMorse";
            this.textBoxOutputMorse.ReadOnly = true;
            this.textBoxOutputMorse.Size = new System.Drawing.Size(625, 20);
            this.textBoxOutputMorse.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Location = new System.Drawing.Point(56, 9);
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.Size = new System.Drawing.Size(625, 20);
            this.textBoxInputText.TabIndex = 3;
            this.textBoxInputText.Text = "Hello";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(606, 319);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonClearCurent
            // 
            this.buttonClearCurent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearCurent.Location = new System.Drawing.Point(687, 319);
            this.buttonClearCurent.Name = "buttonClearCurent";
            this.buttonClearCurent.Size = new System.Drawing.Size(75, 23);
            this.buttonClearCurent.TabIndex = 1;
            this.buttonClearCurent.Text = "Clear";
            this.buttonClearCurent.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(6, 348);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(756, 46);
            this.button.TabIndex = 0;
            this.button.Text = "Space";
            this.button.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Online";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tutorial";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateToText
            // 
            this.buttonTranslateToText.Location = new System.Drawing.Point(687, 73);
            this.buttonTranslateToText.Name = "buttonTranslateToText";
            this.buttonTranslateToText.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslateToText.TabIndex = 12;
            this.buttonTranslateToText.Text = "Translate";
            this.buttonTranslateToText.UseVisualStyleBackColor = true;
            this.buttonTranslateToText.Click += new System.EventHandler(this.buttonTranslateToText_Click);
            // 
            // textBoxOutputText
            // 
            this.textBoxOutputText.Location = new System.Drawing.Point(56, 106);
            this.textBoxOutputText.Name = "textBoxOutputText";
            this.textBoxOutputText.ReadOnly = true;
            this.textBoxOutputText.Size = new System.Drawing.Size(625, 20);
            this.textBoxOutputText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Morse";
            // 
            // textBoxInputMorse
            // 
            this.textBoxInputMorse.Location = new System.Drawing.Point(56, 75);
            this.textBoxInputMorse.Name = "textBoxInputMorse";
            this.textBoxInputMorse.Size = new System.Drawing.Size(625, 20);
            this.textBoxInputMorse.TabIndex = 8;
            // 
            // buttonClearTextTr
            // 
            this.buttonClearTextTr.Location = new System.Drawing.Point(687, 38);
            this.buttonClearTextTr.Name = "buttonClearTextTr";
            this.buttonClearTextTr.Size = new System.Drawing.Size(75, 23);
            this.buttonClearTextTr.TabIndex = 13;
            this.buttonClearTextTr.Text = "Clear";
            this.buttonClearTextTr.UseVisualStyleBackColor = true;
            this.buttonClearTextTr.Click += new System.EventHandler(this.buttonClearTextTr_Click);
            // 
            // buttonClearMorseTr
            // 
            this.buttonClearMorseTr.Location = new System.Drawing.Point(687, 104);
            this.buttonClearMorseTr.Name = "buttonClearMorseTr";
            this.buttonClearMorseTr.Size = new System.Drawing.Size(75, 23);
            this.buttonClearMorseTr.TabIndex = 14;
            this.buttonClearMorseTr.Text = "Clear";
            this.buttonClearMorseTr.UseVisualStyleBackColor = true;
            this.buttonClearMorseTr.Click += new System.EventHandler(this.buttonClearMorseTr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Morse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClearCurent;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonTranslateToMorse;
        private System.Windows.Forms.TextBox textBoxOutputMorse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonTranslateToText;
        private System.Windows.Forms.TextBox textBoxOutputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInputMorse;
        private System.Windows.Forms.Button buttonClearMorseTr;
        private System.Windows.Forms.Button buttonClearTextTr;
    }
}

