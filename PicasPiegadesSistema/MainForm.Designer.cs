namespace PicasPiegadesSistema
{
    partial class MainForm
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
            selectBtn = new Button();
            pizzaList = new ComboBox();
            cartGrid = new DataGridView();
            label1 = new Label();
            submitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            SuspendLayout();
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(279, 37);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(75, 23);
            selectBtn.TabIndex = 9;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // pizzaList
            // 
            pizzaList.FormattingEnabled = true;
            pizzaList.Location = new Point(12, 37);
            pizzaList.Name = "pizzaList";
            pizzaList.Size = new Size(261, 23);
            pizzaList.TabIndex = 8;
            // 
            // cartGrid
            // 
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Location = new Point(12, 100);
            cartGrid.Name = "cartGrid";
            cartGrid.Size = new Size(342, 220);
            cartGrid.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 11;
            label1.Text = "Pasūtījuma grozs";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(209, 326);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(145, 23);
            submitBtn.TabIndex = 12;
            submitBtn.Text = "Noformēt pasūtījumu";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 373);
            Controls.Add(submitBtn);
            Controls.Add(label1);
            Controls.Add(cartGrid);
            Controls.Add(selectBtn);
            Controls.Add(pizzaList);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectBtn;
        private ComboBox pizzaList;
        private DataGridView basketGrid;
        private Label label1;
        private Button submitBtn;
        private DataGridView cartGrid;
    }
}