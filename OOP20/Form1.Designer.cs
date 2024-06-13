namespace OOP20
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
            buttonANS = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            lbl_name = new Label();
            label_ans = new Label();
            SuspendLayout();
            // 
            // buttonANS
            // 
            buttonANS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonANS.Location = new Point(34, 216);
            buttonANS.Name = "buttonANS";
            buttonANS.Size = new Size(502, 40);
            buttonANS.TabIndex = 17;
            buttonANS.Text = "Обчислити";
            buttonANS.UseVisualStyleBackColor = true;
            buttonANS.Click += buttonANS_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(34, 176);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 16;
            label5.Text = "Зворотнє число = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(34, 126);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 14;
            label3.Text = "Введіть y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 78);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 13;
            label2.Text = "Введіть x:";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(144, 126);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(48, 23);
            textBoxY.TabIndex = 12;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(144, 78);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(48, 23);
            textBoxX.TabIndex = 11;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_name.Location = new Point(34, 27);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(502, 24);
            lbl_name.TabIndex = 9;
            lbl_name.Text = "Обчислення нечіткого числа, зворотнього заданому";
            // 
            // label_ans
            // 
            label_ans.AutoSize = true;
            label_ans.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_ans.Location = new Point(215, 177);
            label_ans.Name = "label_ans";
            label_ans.Size = new Size(20, 25);
            label_ans.TabIndex = 18;
            label_ans.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(568, 289);
            Controls.Add(label_ans);
            Controls.Add(buttonANS);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(lbl_name);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP20 варінт 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonANS;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Label lbl_name;
        private Label label_ans;
    }
}
