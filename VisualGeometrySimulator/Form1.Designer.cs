namespace VisualGeometrySimulator
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
            btnClickThis = new Button();
            lblText = new Label();
            ResultBox = new Label();
            AnswerBox = new TextBox();
            CorrectOrIncorrectButton = new Label();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(100, 55);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(191, 29);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Начать тест";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += button1_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.BackColor = SystemColors.ButtonFace;
            lblText.Location = new Point(313, 209);
            lblText.Name = "lblText";
            lblText.Size = new Size(0, 20);
            lblText.TabIndex = 1;
            lblText.Click += label1_Click;
            // 
            // ResultBox
            // 
            ResultBox.AutoSize = true;
            ResultBox.Location = new Point(289, 401);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(0, 20);
            ResultBox.TabIndex = 2;
            ResultBox.Click += label1_Click_1;
            // 
            // AnswerBox
            // 
            AnswerBox.Location = new Point(754, 87);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(125, 27);
            AnswerBox.TabIndex = 3;
            // 
            // CorrectOrIncorrectButton
            // 
            CorrectOrIncorrectButton.AutoSize = true;
            CorrectOrIncorrectButton.Location = new Point(994, 235);
            CorrectOrIncorrectButton.Name = "CorrectOrIncorrectButton";
            CorrectOrIncorrectButton.Size = new Size(0, 20);
            CorrectOrIncorrectButton.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1295, 462);
            Controls.Add(CorrectOrIncorrectButton);
            Controls.Add(AnswerBox);
            Controls.Add(ResultBox);
            Controls.Add(lblText);
            Controls.Add(btnClickThis);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label lblText;
        private Label ResultBox;
        private TextBox answerBox;
        private Label CorrectOrIncorrectButton;
        private TextBox AnswerBox;
    }
}