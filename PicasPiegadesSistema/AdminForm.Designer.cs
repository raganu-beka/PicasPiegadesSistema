namespace PicasPiegadesSistema
{
    partial class AdminForm
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
            descTxt = new TextBox();
            sizeTxt = new TextBox();
            priceTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pizzaList = new ComboBox();
            selectBtn = new Button();
            addBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // descTxt
            // 
            descTxt.Location = new Point(100, 115);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(284, 23);
            descTxt.TabIndex = 0;
            // 
            // sizeTxt
            // 
            sizeTxt.Location = new Point(100, 144);
            sizeTxt.Name = "sizeTxt";
            sizeTxt.Size = new Size(284, 23);
            sizeTxt.TabIndex = 1;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(100, 173);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(284, 23);
            priceTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 123);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Apraksts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 152);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Izmērs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 181);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Cena";
            // 
            // pizzaList
            // 
            pizzaList.FormattingEnabled = true;
            pizzaList.Location = new Point(42, 63);
            pizzaList.Name = "pizzaList";
            pizzaList.Size = new Size(261, 23);
            pizzaList.TabIndex = 6;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(309, 63);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(75, 23);
            selectBtn.TabIndex = 7;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(42, 213);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 8;
            addBtn.Text = "Pievienot";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(123, 213);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Dzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 321);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(selectBtn);
            Controls.Add(pizzaList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceTxt);
            Controls.Add(sizeTxt);
            Controls.Add(descTxt);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descTxt;
        private TextBox sizeTxt;
        private TextBox priceTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox pizzaList;
        private Button selectBtn;
        private Button addBtn;
        private Button deleteBtn;
    }
}