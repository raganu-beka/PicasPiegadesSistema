namespace PicasPiegadesSistema
{
    partial class UserForm
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
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // unameTxt
            // 
            unameTxt.Location = new Point(45, 58);
            unameTxt.Name = "unameTxt";
            unameTxt.Size = new Size(296, 23);
            unameTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(45, 113);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(296, 23);
            passTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 40);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Lietotājvārds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Parole";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(44, 154);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Pieslēgties!";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 220);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passTxt);
            Controls.Add(unameTxt);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unameTxt;
        private TextBox passTxt;
        private Label label1;
        private Label label2;
        private Button loginBtn;
    }
}