
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
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonPlayMorseSound1 = new System.Windows.Forms.Button();
            this.buttonClearMorseTr = new System.Windows.Forms.Button();
            this.buttonClearTextTr = new System.Windows.Forms.Button();
            this.buttonTranslateToText = new System.Windows.Forms.Button();
            this.textBoxOutputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInputMorse = new System.Windows.Forms.TextBox();
            this.buttonTranslateToMorse = new System.Windows.Forms.Button();
            this.textBoxOutputMorse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_nrEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_AnswersRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_AnswersWrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownExercises = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExercises)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.buttonReport);
            this.tabPage1.Controls.Add(this.buttonPlayMorseSound1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1060, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.Location = new System.Drawing.Point(948, 487);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(100, 28);
            this.buttonReport.TabIndex = 20;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonPlayMorseSound1
            // 
            this.buttonPlayMorseSound1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayMorseSound1.Location = new System.Drawing.Point(899, 97);
            this.buttonPlayMorseSound1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlayMorseSound1.Name = "buttonPlayMorseSound1";
            this.buttonPlayMorseSound1.Size = new System.Drawing.Size(116, 28);
            this.buttonPlayMorseSound1.TabIndex = 15;
            this.buttonPlayMorseSound1.Text = "Play";
            this.buttonPlayMorseSound1.UseVisualStyleBackColor = true;
            this.buttonPlayMorseSound1.Click += new System.EventHandler(this.buttonPlayMorseSound1_Click);
            // 
            // buttonClearMorseTr
            // 
            this.buttonClearMorseTr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearMorseTr.Location = new System.Drawing.Point(899, 290);
            this.buttonClearMorseTr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearMorseTr.Name = "buttonClearMorseTr";
            this.buttonClearMorseTr.Size = new System.Drawing.Size(116, 28);
            this.buttonClearMorseTr.TabIndex = 14;
            this.buttonClearMorseTr.Text = "Clear";
            this.buttonClearMorseTr.UseVisualStyleBackColor = true;
            this.buttonClearMorseTr.Click += new System.EventHandler(this.buttonClearMorseTr_Click);
            // 
            // buttonClearTextTr
            // 
            this.buttonClearTextTr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearTextTr.Location = new System.Drawing.Point(899, 133);
            this.buttonClearTextTr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearTextTr.Name = "buttonClearTextTr";
            this.buttonClearTextTr.Size = new System.Drawing.Size(116, 28);
            this.buttonClearTextTr.TabIndex = 13;
            this.buttonClearTextTr.Text = "Clear";
            this.buttonClearTextTr.UseVisualStyleBackColor = true;
            this.buttonClearTextTr.Click += new System.EventHandler(this.buttonClearTextTr_Click);
            // 
            // buttonTranslateToText
            // 
            this.buttonTranslateToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslateToText.Location = new System.Drawing.Point(899, 218);
            this.buttonTranslateToText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTranslateToText.Name = "buttonTranslateToText";
            this.buttonTranslateToText.Size = new System.Drawing.Size(116, 65);
            this.buttonTranslateToText.TabIndex = 12;
            this.buttonTranslateToText.Text = "Translate";
            this.buttonTranslateToText.UseVisualStyleBackColor = true;
            this.buttonTranslateToText.Click += new System.EventHandler(this.buttonTranslateToText_Click);
            // 
            // textBoxOutputText
            // 
            this.textBoxOutputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputText.Location = new System.Drawing.Point(74, 290);
            this.textBoxOutputText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutputText.Name = "textBoxOutputText";
            this.textBoxOutputText.ReadOnly = true;
            this.textBoxOutputText.Size = new System.Drawing.Size(816, 22);
            this.textBoxOutputText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Morse";
            // 
            // textBoxInputMorse
            // 
            this.textBoxInputMorse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputMorse.Font = new System.Drawing.Font("Sitka Small", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputMorse.Location = new System.Drawing.Point(74, 220);
            this.textBoxInputMorse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputMorse.Name = "textBoxInputMorse";
            this.textBoxInputMorse.Size = new System.Drawing.Size(816, 62);
            this.textBoxInputMorse.TabIndex = 8;
            // 
            // buttonTranslateToMorse
            // 
            this.buttonTranslateToMorse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslateToMorse.Location = new System.Drawing.Point(899, 58);
            this.buttonTranslateToMorse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTranslateToMorse.Name = "buttonTranslateToMorse";
            this.buttonTranslateToMorse.Size = new System.Drawing.Size(116, 28);
            this.buttonTranslateToMorse.TabIndex = 7;
            this.buttonTranslateToMorse.Text = "Translate";
            this.buttonTranslateToMorse.UseVisualStyleBackColor = true;
            this.buttonTranslateToMorse.Click += new System.EventHandler(this.buttonTranslateToMorse_Click);
            // 
            // textBoxOutputMorse
            // 
            this.textBoxOutputMorse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputMorse.Font = new System.Drawing.Font("Sitka Small", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputMorse.Location = new System.Drawing.Point(74, 98);
            this.textBoxOutputMorse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutputMorse.Name = "textBoxOutputMorse";
            this.textBoxOutputMorse.ReadOnly = true;
            this.textBoxOutputMorse.Size = new System.Drawing.Size(816, 62);
            this.textBoxOutputMorse.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputText.Location = new System.Drawing.Point(74, 60);
            this.textBoxInputText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.Size = new System.Drawing.Size(816, 22);
            this.textBoxInputText.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1060, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(528, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "This program don\'t includespecial characters beside numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(319, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Warning :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(319, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(697, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.buttonStartTest);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.numericUpDownExercises);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1060, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_ID,
            this.grid_nrEx,
            this.grid_AnswersRight,
            this.grid_AnswersWrong,
            this.grid_Skipped,
            this.resultColum});
            this.dataGridView1.Location = new System.Drawing.Point(323, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(725, 507);
            this.dataGridView1.TabIndex = 20;
            // 
            // grid_ID
            // 
            this.grid_ID.HeaderText = "ID";
            this.grid_ID.MinimumWidth = 6;
            this.grid_ID.Name = "grid_ID";
            this.grid_ID.ReadOnly = true;
            // 
            // grid_nrEx
            // 
            this.grid_nrEx.HeaderText = "NR Exercises";
            this.grid_nrEx.MinimumWidth = 6;
            this.grid_nrEx.Name = "grid_nrEx";
            this.grid_nrEx.ReadOnly = true;
            // 
            // grid_AnswersRight
            // 
            this.grid_AnswersRight.HeaderText = "Correct";
            this.grid_AnswersRight.MinimumWidth = 6;
            this.grid_AnswersRight.Name = "grid_AnswersRight";
            this.grid_AnswersRight.ReadOnly = true;
            // 
            // grid_AnswersWrong
            // 
            this.grid_AnswersWrong.HeaderText = "Wrong";
            this.grid_AnswersWrong.MinimumWidth = 6;
            this.grid_AnswersWrong.Name = "grid_AnswersWrong";
            this.grid_AnswersWrong.ReadOnly = true;
            // 
            // grid_Skipped
            // 
            this.grid_Skipped.HeaderText = "Skipped";
            this.grid_Skipped.MinimumWidth = 6;
            this.grid_Skipped.Name = "grid_Skipped";
            this.grid_Skipped.ReadOnly = true;
            // 
            // resultColum
            // 
            this.resultColum.HeaderText = "Result";
            this.resultColum.MinimumWidth = 6;
            this.resultColum.Name = "resultColum";
            this.resultColum.ReadOnly = true;
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(13, 58);
            this.buttonStartTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(100, 28);
            this.buttonStartTest.TabIndex = 7;
            this.buttonStartTest.Text = "Start";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = ": number of exercises";
            // 
            // numericUpDownExercises
            // 
            this.numericUpDownExercises.Location = new System.Drawing.Point(13, 26);
            this.numericUpDownExercises.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownExercises.Name = "numericUpDownExercises";
            this.numericUpDownExercises.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownExercises.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(58, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(883, 91);
            this.label8.TabIndex = 21;
            this.label8.Text = "Aplicarea codului Morse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(66, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 46);
            this.label9.TabIndex = 22;
            this.label9.Text = "Decriptare";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(77, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 46);
            this.label10.TabIndex = 23;
            this.label10.Text = "Criptare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Morse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExercises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTranslateToMorse;
        private System.Windows.Forms.TextBox textBoxOutputMorse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.Button buttonTranslateToText;
        private System.Windows.Forms.TextBox textBoxOutputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInputMorse;
        private System.Windows.Forms.Button buttonClearMorseTr;
        private System.Windows.Forms.Button buttonClearTextTr;
        private System.Windows.Forms.Button buttonPlayMorseSound1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownExercises;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_nrEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_AnswersRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_AnswersWrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Skipped;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultColum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

