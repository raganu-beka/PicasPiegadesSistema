namespace PicasPiegadesSistema
{
    partial class RegistrationForm
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
            unameTxt = new TextBox();
            passTxt = new TextBox();
            pass2Txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // unameTxt
            // 
            unameTxt.Location = new Point(21, 48);
            unameTxt.Name = "unameTxt";
            unameTxt.Size = new Size(296, 23);
            unameTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(21, 108);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(296, 23);
            passTxt.TabIndex = 1;
            // 
            // pass2Txt
            // 
            pass2Txt.Location = new Point(21, 164);
            pass2Txt.Name = "pass2Txt";
            pass2Txt.Size = new Size(296, 23);
            pass2Txt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Lietotājvārds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Parole";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 146);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Ievadīt paroli atkārtoti";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pass2Txt);
            Controls.Add(passTxt);
            Controls.Add(unameTxt);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unameTxt;
        private TextBox passTxt;
        private TextBox pass2Txt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}