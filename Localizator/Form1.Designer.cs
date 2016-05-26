namespace Localizator
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
            this.itemsList = new System.Windows.Forms.ListBox();
            this.selectJSON = new System.Windows.Forms.Button();
            this.translationBox = new System.Windows.Forms.RichTextBox();
            this.langSelector = new System.Windows.Forms.ComboBox();
            this.addTranslation_button = new System.Windows.Forms.Button();
            this.saveChanges_button = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.RichTextBox();
            this.Original = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addItem_button = new System.Windows.Forms.Button();
            this.deleteItem_button = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsList
            // 
            this.itemsList.AccessibleName = "String items";
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(12, 58);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(255, 472);
            this.itemsList.TabIndex = 0;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // selectJSON
            // 
            this.selectJSON.AccessibleDescription = "selectJSON";
            this.selectJSON.AccessibleName = "selectJSON";
            this.selectJSON.Location = new System.Drawing.Point(12, 596);
            this.selectJSON.Name = "selectJSON";
            this.selectJSON.Size = new System.Drawing.Size(100, 30);
            this.selectJSON.TabIndex = 1;
            this.selectJSON.Text = "Select JSON File";
            this.selectJSON.UseVisualStyleBackColor = true;
            this.selectJSON.Click += new System.EventHandler(this.selectJSON_click);
            // 
            // translationBox
            // 
            this.translationBox.Location = new System.Drawing.Point(379, 318);
            this.translationBox.Name = "translationBox";
            this.translationBox.Size = new System.Drawing.Size(409, 212);
            this.translationBox.TabIndex = 2;
            this.translationBox.Text = "";
            // 
            // langSelector
            // 
            this.langSelector.FormattingEnabled = true;
            this.langSelector.Location = new System.Drawing.Point(273, 32);
            this.langSelector.Name = "langSelector";
            this.langSelector.Size = new System.Drawing.Size(100, 21);
            this.langSelector.TabIndex = 3;
            this.langSelector.SelectedIndexChanged += new System.EventHandler(this.lanSelector_SelectedIndexChanged);
            // 
            // addTranslation_button
            // 
            this.addTranslation_button.Location = new System.Drawing.Point(273, 59);
            this.addTranslation_button.Name = "addTranslation_button";
            this.addTranslation_button.Size = new System.Drawing.Size(100, 30);
            this.addTranslation_button.TabIndex = 4;
            this.addTranslation_button.Text = "Add Translation";
            this.addTranslation_button.UseVisualStyleBackColor = true;
            this.addTranslation_button.Click += new System.EventHandler(this.addTranslation_click);
            // 
            // saveChanges_button
            // 
            this.saveChanges_button.Location = new System.Drawing.Point(688, 596);
            this.saveChanges_button.Name = "saveChanges_button";
            this.saveChanges_button.Size = new System.Drawing.Size(100, 30);
            this.saveChanges_button.TabIndex = 5;
            this.saveChanges_button.Text = "Save Changes";
            this.saveChanges_button.UseVisualStyleBackColor = true;
            this.saveChanges_button.Click += new System.EventHandler(this.saveChanges_click);
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(379, 32);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(409, 240);
            this.originalTextBox.TabIndex = 6;
            this.originalTextBox.Text = "";
            this.originalTextBox.TextChanged += new System.EventHandler(this.originalTextBox_TextChanged);
            // 
            // Original
            // 
            this.Original.AutoSize = true;
            this.Original.Location = new System.Drawing.Point(376, 9);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(42, 13);
            this.Original.TabIndex = 7;
            this.Original.Text = "Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Translation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Items";
            // 
            // addItem_button
            // 
            this.addItem_button.Location = new System.Drawing.Point(13, 548);
            this.addItem_button.Name = "addItem_button";
            this.addItem_button.Size = new System.Drawing.Size(100, 30);
            this.addItem_button.TabIndex = 11;
            this.addItem_button.Text = "Add Item";
            this.addItem_button.UseVisualStyleBackColor = true;
            this.addItem_button.Click += new System.EventHandler(this.addItem_click);
            // 
            // deleteItem_button
            // 
            this.deleteItem_button.Location = new System.Drawing.Point(167, 548);
            this.deleteItem_button.Name = "deleteItem_button";
            this.deleteItem_button.Size = new System.Drawing.Size(100, 30);
            this.deleteItem_button.TabIndex = 12;
            this.deleteItem_button.Text = "Delete Item";
            this.deleteItem_button.UseVisualStyleBackColor = true;
            this.deleteItem_button.Click += new System.EventHandler(this.deleteItem_button_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(69, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(198, 20);
            this.searchBox.TabIndex = 13;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.deleteItem_button);
            this.Controls.Add(this.addItem_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.saveChanges_button);
            this.Controls.Add(this.addTranslation_button);
            this.Controls.Add(this.langSelector);
            this.Controls.Add(this.translationBox);
            this.Controls.Add(this.selectJSON);
            this.Controls.Add(this.itemsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Button selectJSON;
        private System.Windows.Forms.RichTextBox translationBox;
        private System.Windows.Forms.ComboBox langSelector;
        private System.Windows.Forms.Button addTranslation_button;
        private System.Windows.Forms.Button saveChanges_button;
        private System.Windows.Forms.Label Original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox originalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addItem_button;
        private System.Windows.Forms.Button deleteItem_button;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label4;
    }
}

