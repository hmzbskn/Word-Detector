namespace Word_Detector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_iknow = new Button();
            lbl_english = new Label();
            btn_idontknow = new Button();
            groupBox1 = new GroupBox();
            lbl_turkish = new Label();
            English = new GroupBox();
            btn_questionmark = new Button();
            btn_close = new Button();
            btn_quiz = new Button();
            groupBox1.SuspendLayout();
            English.SuspendLayout();
            SuspendLayout();
            // 
            // btn_iknow
            // 
            btn_iknow.Location = new Point(6, 390);
            btn_iknow.Name = "btn_iknow";
            btn_iknow.Size = new Size(154, 53);
            btn_iknow.TabIndex = 0;
            btn_iknow.Text = "I KNOW";
            btn_iknow.UseVisualStyleBackColor = true;
            btn_iknow.Click += btn_iknow_Click;
            // 
            // lbl_english
            // 
            lbl_english.AutoSize = true;
            lbl_english.Font = new Font("SimSun", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_english.Location = new Point(182, 198);
            lbl_english.Name = "lbl_english";
            lbl_english.Size = new Size(120, 47);
            lbl_english.TabIndex = 3;
            lbl_english.Text = "Word";
            // 
            // btn_idontknow
            // 
            btn_idontknow.Location = new Point(325, 390);
            btn_idontknow.Name = "btn_idontknow";
            btn_idontknow.Size = new Size(154, 53);
            btn_idontknow.TabIndex = 1;
            btn_idontknow.Text = "I DON'T KNOW";
            btn_idontknow.UseVisualStyleBackColor = true;
            btn_idontknow.Click += btn_idontknow_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_turkish);
            groupBox1.Location = new Point(503, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 471);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Turkish";
            // 
            // lbl_turkish
            // 
            lbl_turkish.AutoSize = true;
            lbl_turkish.Font = new Font("SimSun", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_turkish.Location = new Point(152, 198);
            lbl_turkish.Name = "lbl_turkish";
            lbl_turkish.Size = new Size(195, 47);
            lbl_turkish.TabIndex = 3;
            lbl_turkish.Text = "Meaning";
            // 
            // English
            // 
            English.Controls.Add(btn_questionmark);
            English.Controls.Add(btn_iknow);
            English.Controls.Add(lbl_english);
            English.Controls.Add(btn_idontknow);
            English.Location = new Point(12, 12);
            English.Name = "English";
            English.Size = new Size(485, 471);
            English.TabIndex = 6;
            English.TabStop = false;
            English.Text = "English";
            // 
            // btn_questionmark
            // 
            btn_questionmark.Location = new Point(166, 390);
            btn_questionmark.Name = "btn_questionmark";
            btn_questionmark.Size = new Size(154, 53);
            btn_questionmark.TabIndex = 2;
            btn_questionmark.Text = "SHOW WORD";
            btn_questionmark.UseVisualStyleBackColor = true;
            btn_questionmark.Click += btn_questionmark_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(910, 548);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(154, 53);
            btn_close.TabIndex = 8;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_quiz
            // 
            btn_quiz.Location = new Point(750, 548);
            btn_quiz.Name = "btn_quiz";
            btn_quiz.Size = new Size(154, 53);
            btn_quiz.TabIndex = 9;
            btn_quiz.Text = "Quiz";
            btn_quiz.UseVisualStyleBackColor = true;
            btn_quiz.Click += btn_quiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 613);
            Controls.Add(btn_quiz);
            Controls.Add(btn_close);
            Controls.Add(groupBox1);
            Controls.Add(English);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            English.ResumeLayout(false);
            English.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_iknow;
        private Label lbl_english;
        private Button btn_idontknow;
        private GroupBox groupBox1;
        private Label lbl_turkish;
        private GroupBox English;
        private Button btn_close;
        private Button btn_quiz;
        private Button btn_questionmark;
    }
}
