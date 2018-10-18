namespace POSCustomerSide
{
    partial class RestaurantSideForm
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
            this._mainTabControl = new System.Windows.Forms.TabControl();
            this._mealManageTabPage = new System.Windows.Forms.TabPage();
            this._mealGroupBox1 = new System.Windows.Forms.GroupBox();
            this._saveButton1 = new System.Windows.Forms.Button();
            this._mealDescriptionTextBox = new System.Windows.Forms.TextBox();
            this._mealDescriptionLabel = new System.Windows.Forms.Label();
            this._mealImageTextBox = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._mealImageLabel = new System.Windows.Forms.Label();
            this._mealCategoryComboBox = new System.Windows.Forms.ComboBox();
            this._mealCategoryLabel = new System.Windows.Forms.Label();
            this._Dollarlabel = new System.Windows.Forms.Label();
            this._mealPriceLabel = new System.Windows.Forms.Label();
            this._mealPriceTextBox = new System.Windows.Forms.TextBox();
            this._mealNameLabel = new System.Windows.Forms.Label();
            this._mealNameTextBox = new System.Windows.Forms.TextBox();
            this._deleteMealButton = new System.Windows.Forms.Button();
            this._addMealButton = new System.Windows.Forms.Button();
            this._mealListBox = new System.Windows.Forms.ListBox();
            this._categoryManageTabPage = new System.Windows.Forms.TabPage();
            this._categoryGroupBox = new System.Windows.Forms.GroupBox();
            this._categoryUsingListBox = new System.Windows.Forms.ListBox();
            this._saveButton2 = new System.Windows.Forms.Button();
            this._categoryUsingLabel = new System.Windows.Forms.Label();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._categoryNameTextBox = new System.Windows.Forms.TextBox();
            this._deleteCategoryButton = new System.Windows.Forms.Button();
            this._addCategoryButton = new System.Windows.Forms.Button();
            this._categoryListBox = new System.Windows.Forms.ListBox();
            this._mainTabControl.SuspendLayout();
            this._mealManageTabPage.SuspendLayout();
            this._mealGroupBox1.SuspendLayout();
            this._categoryManageTabPage.SuspendLayout();
            this._categoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainTabControl
            // 
            this._mainTabControl.Controls.Add(this._mealManageTabPage);
            this._mainTabControl.Controls.Add(this._categoryManageTabPage);
            this._mainTabControl.Location = new System.Drawing.Point(12, 12);
            this._mainTabControl.Margin = new System.Windows.Forms.Padding(10);
            this._mainTabControl.Name = "_mainTabControl";
            this._mainTabControl.SelectedIndex = 0;
            this._mainTabControl.Size = new System.Drawing.Size(974, 643);
            this._mainTabControl.TabIndex = 0;
            // 
            // _mealManageTabPage
            // 
            this._mealManageTabPage.Controls.Add(this._mealGroupBox1);
            this._mealManageTabPage.Controls.Add(this._deleteMealButton);
            this._mealManageTabPage.Controls.Add(this._addMealButton);
            this._mealManageTabPage.Controls.Add(this._mealListBox);
            this._mealManageTabPage.Font = new System.Drawing.Font("標楷體", 12F);
            this._mealManageTabPage.Location = new System.Drawing.Point(4, 22);
            this._mealManageTabPage.Name = "_mealManageTabPage";
            this._mealManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._mealManageTabPage.Size = new System.Drawing.Size(966, 617);
            this._mealManageTabPage.TabIndex = 2;
            this._mealManageTabPage.Text = "Meal Manager";
            this._mealManageTabPage.UseVisualStyleBackColor = true;
            // 
            // _mealGroupBox1
            // 
            this._mealGroupBox1.Controls.Add(this._saveButton1);
            this._mealGroupBox1.Controls.Add(this._mealDescriptionTextBox);
            this._mealGroupBox1.Controls.Add(this._mealDescriptionLabel);
            this._mealGroupBox1.Controls.Add(this._mealImageTextBox);
            this._mealGroupBox1.Controls.Add(this._browseButton);
            this._mealGroupBox1.Controls.Add(this._mealImageLabel);
            this._mealGroupBox1.Controls.Add(this._mealCategoryComboBox);
            this._mealGroupBox1.Controls.Add(this._mealCategoryLabel);
            this._mealGroupBox1.Controls.Add(this._Dollarlabel);
            this._mealGroupBox1.Controls.Add(this._mealPriceLabel);
            this._mealGroupBox1.Controls.Add(this._mealPriceTextBox);
            this._mealGroupBox1.Controls.Add(this._mealNameLabel);
            this._mealGroupBox1.Controls.Add(this._mealNameTextBox);
            this._mealGroupBox1.Location = new System.Drawing.Point(406, 6);
            this._mealGroupBox1.Name = "_mealGroupBox1";
            this._mealGroupBox1.Size = new System.Drawing.Size(554, 601);
            this._mealGroupBox1.TabIndex = 3;
            this._mealGroupBox1.TabStop = false;
            this._mealGroupBox1.Text = "Edit Meal";
            // 
            // _saveButton1
            // 
            this._saveButton1.Enabled = false;
            this._saveButton1.Location = new System.Drawing.Point(449, 567);
            this._saveButton1.Name = "_saveButton1";
            this._saveButton1.Size = new System.Drawing.Size(89, 27);
            this._saveButton1.TabIndex = 12;
            this._saveButton1.Text = "Save";
            this._saveButton1.UseVisualStyleBackColor = true;
            // 
            // _mealDescriptionTextBox
            // 
            this._mealDescriptionTextBox.Location = new System.Drawing.Point(16, 236);
            this._mealDescriptionTextBox.Multiline = true;
            this._mealDescriptionTextBox.Name = "_mealDescriptionTextBox";
            this._mealDescriptionTextBox.Size = new System.Drawing.Size(523, 328);
            this._mealDescriptionTextBox.TabIndex = 11;
            // 
            // _mealDescriptionLabel
            // 
            this._mealDescriptionLabel.AutoSize = true;
            this._mealDescriptionLabel.Location = new System.Drawing.Point(13, 206);
            this._mealDescriptionLabel.Name = "_mealDescriptionLabel";
            this._mealDescriptionLabel.Size = new System.Drawing.Size(136, 16);
            this._mealDescriptionLabel.TabIndex = 10;
            this._mealDescriptionLabel.Text = "Meal Description";
            // 
            // _mealImageTextBox
            // 
            this._mealImageTextBox.Location = new System.Drawing.Point(251, 153);
            this._mealImageTextBox.Name = "_mealImageTextBox";
            this._mealImageTextBox.Size = new System.Drawing.Size(193, 27);
            this._mealImageTextBox.TabIndex = 9;
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(450, 153);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(89, 27);
            this._browseButton.TabIndex = 8;
            this._browseButton.Text = "Browse";
            this._browseButton.UseVisualStyleBackColor = true;
            // 
            // _mealImageLabel
            // 
            this._mealImageLabel.AutoSize = true;
            this._mealImageLabel.Location = new System.Drawing.Point(13, 157);
            this._mealImageLabel.Name = "_mealImageLabel";
            this._mealImageLabel.Size = new System.Drawing.Size(232, 16);
            this._mealImageLabel.TabIndex = 7;
            this._mealImageLabel.Text = "Meal Image Relative Path (*)";
            // 
            // _mealCategoryComboBox
            // 
            this._mealCategoryComboBox.FormattingEnabled = true;
            this._mealCategoryComboBox.Location = new System.Drawing.Point(418, 94);
            this._mealCategoryComboBox.Name = "_mealCategoryComboBox";
            this._mealCategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this._mealCategoryComboBox.TabIndex = 6;
            // 
            // _mealCategoryLabel
            // 
            this._mealCategoryLabel.AutoSize = true;
            this._mealCategoryLabel.Location = new System.Drawing.Point(268, 98);
            this._mealCategoryLabel.Name = "_mealCategoryLabel";
            this._mealCategoryLabel.Size = new System.Drawing.Size(144, 16);
            this._mealCategoryLabel.TabIndex = 5;
            this._mealCategoryLabel.Text = "Meal Category (*)";
            // 
            // _Dollarlabel
            // 
            this._Dollarlabel.AutoSize = true;
            this._Dollarlabel.Location = new System.Drawing.Point(230, 98);
            this._Dollarlabel.Name = "_Dollarlabel";
            this._Dollarlabel.Size = new System.Drawing.Size(32, 16);
            this._Dollarlabel.TabIndex = 4;
            this._Dollarlabel.Text = "NTD";
            // 
            // _mealPriceLabel
            // 
            this._mealPriceLabel.AutoSize = true;
            this._mealPriceLabel.Location = new System.Drawing.Point(13, 99);
            this._mealPriceLabel.Name = "_mealPriceLabel";
            this._mealPriceLabel.Size = new System.Drawing.Size(120, 16);
            this._mealPriceLabel.TabIndex = 3;
            this._mealPriceLabel.Text = "Meal Price (*)";
            // 
            // _mealPriceTextBox
            // 
            this._mealPriceTextBox.Location = new System.Drawing.Point(137, 93);
            this._mealPriceTextBox.Name = "_mealPriceTextBox";
            this._mealPriceTextBox.Size = new System.Drawing.Size(86, 27);
            this._mealPriceTextBox.TabIndex = 2;
            // 
            // _mealNameLabel
            // 
            this._mealNameLabel.AutoSize = true;
            this._mealNameLabel.Location = new System.Drawing.Point(13, 40);
            this._mealNameLabel.Name = "_mealNameLabel";
            this._mealNameLabel.Size = new System.Drawing.Size(112, 16);
            this._mealNameLabel.TabIndex = 1;
            this._mealNameLabel.Text = "Meal Name (*)";
            // 
            // _mealNameTextBox
            // 
            this._mealNameTextBox.Location = new System.Drawing.Point(137, 35);
            this._mealNameTextBox.Name = "_mealNameTextBox";
            this._mealNameTextBox.Size = new System.Drawing.Size(402, 27);
            this._mealNameTextBox.TabIndex = 0;
            // 
            // _deleteMealButton
            // 
            this._deleteMealButton.Font = new System.Drawing.Font("標楷體", 10F);
            this._deleteMealButton.Location = new System.Drawing.Point(245, 578);
            this._deleteMealButton.Name = "_deleteMealButton";
            this._deleteMealButton.Size = new System.Drawing.Size(155, 29);
            this._deleteMealButton.TabIndex = 2;
            this._deleteMealButton.Text = "Delete Selected Meal";
            this._deleteMealButton.UseVisualStyleBackColor = true;
            // 
            // _addMealButton
            // 
            this._addMealButton.Font = new System.Drawing.Font("標楷體", 10F);
            this._addMealButton.Location = new System.Drawing.Point(5, 578);
            this._addMealButton.Name = "_addMealButton";
            this._addMealButton.Size = new System.Drawing.Size(155, 29);
            this._addMealButton.TabIndex = 1;
            this._addMealButton.Text = "Add New Meal";
            this._addMealButton.UseVisualStyleBackColor = true;
            // 
            // _mealListBox
            // 
            this._mealListBox.FormattingEnabled = true;
            this._mealListBox.ItemHeight = 16;
            this._mealListBox.Location = new System.Drawing.Point(6, 6);
            this._mealListBox.Name = "_mealListBox";
            this._mealListBox.Size = new System.Drawing.Size(394, 564);
            this._mealListBox.TabIndex = 0;
            // 
            // _categoryManageTabPage
            // 
            this._categoryManageTabPage.Controls.Add(this._categoryGroupBox);
            this._categoryManageTabPage.Controls.Add(this._deleteCategoryButton);
            this._categoryManageTabPage.Controls.Add(this._addCategoryButton);
            this._categoryManageTabPage.Controls.Add(this._categoryListBox);
            this._categoryManageTabPage.Font = new System.Drawing.Font("標楷體", 12F);
            this._categoryManageTabPage.Location = new System.Drawing.Point(4, 22);
            this._categoryManageTabPage.Name = "_categoryManageTabPage";
            this._categoryManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._categoryManageTabPage.Size = new System.Drawing.Size(966, 617);
            this._categoryManageTabPage.TabIndex = 3;
            this._categoryManageTabPage.Text = "Category Manager";
            this._categoryManageTabPage.UseVisualStyleBackColor = true;
            // 
            // _categoryGroupBox
            // 
            this._categoryGroupBox.Controls.Add(this._categoryUsingListBox);
            this._categoryGroupBox.Controls.Add(this._saveButton2);
            this._categoryGroupBox.Controls.Add(this._categoryUsingLabel);
            this._categoryGroupBox.Controls.Add(this._categoryNameLabel);
            this._categoryGroupBox.Controls.Add(this._categoryNameTextBox);
            this._categoryGroupBox.Location = new System.Drawing.Point(406, 6);
            this._categoryGroupBox.Name = "_categoryGroupBox";
            this._categoryGroupBox.Size = new System.Drawing.Size(554, 601);
            this._categoryGroupBox.TabIndex = 6;
            this._categoryGroupBox.TabStop = false;
            this._categoryGroupBox.Text = "Edit Category";
            // 
            // _categoryUsingListBox
            // 
            this._categoryUsingListBox.FormattingEnabled = true;
            this._categoryUsingListBox.ItemHeight = 16;
            this._categoryUsingListBox.Location = new System.Drawing.Point(16, 123);
            this._categoryUsingListBox.Name = "_categoryUsingListBox";
            this._categoryUsingListBox.Size = new System.Drawing.Size(522, 436);
            this._categoryUsingListBox.TabIndex = 13;
            // 
            // _saveButton2
            // 
            this._saveButton2.Enabled = false;
            this._saveButton2.Location = new System.Drawing.Point(449, 567);
            this._saveButton2.Name = "_saveButton2";
            this._saveButton2.Size = new System.Drawing.Size(89, 27);
            this._saveButton2.TabIndex = 12;
            this._saveButton2.Text = "Save";
            this._saveButton2.UseVisualStyleBackColor = true;
            // 
            // _categoryUsingLabel
            // 
            this._categoryUsingLabel.AutoSize = true;
            this._categoryUsingLabel.Location = new System.Drawing.Point(13, 88);
            this._categoryUsingLabel.Name = "_categoryUsingLabel";
            this._categoryUsingLabel.Size = new System.Drawing.Size(232, 16);
            this._categoryUsingLabel.TabIndex = 10;
            this._categoryUsingLabel.Text = "Meal(s) Using this Category:";
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.AutoSize = true;
            this._categoryNameLabel.Location = new System.Drawing.Point(13, 40);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(144, 16);
            this._categoryNameLabel.TabIndex = 1;
            this._categoryNameLabel.Text = "Category Name (*)";
            // 
            // _categoryNameTextBox
            // 
            this._categoryNameTextBox.Location = new System.Drawing.Point(163, 35);
            this._categoryNameTextBox.Name = "_categoryNameTextBox";
            this._categoryNameTextBox.Size = new System.Drawing.Size(376, 27);
            this._categoryNameTextBox.TabIndex = 0;
            // 
            // _deleteCategoryButton
            // 
            this._deleteCategoryButton.Font = new System.Drawing.Font("標楷體", 10F);
            this._deleteCategoryButton.Location = new System.Drawing.Point(212, 578);
            this._deleteCategoryButton.Name = "_deleteCategoryButton";
            this._deleteCategoryButton.Size = new System.Drawing.Size(188, 29);
            this._deleteCategoryButton.TabIndex = 5;
            this._deleteCategoryButton.Text = "Delete Selected Category";
            this._deleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // _addCategoryButton
            // 
            this._addCategoryButton.Font = new System.Drawing.Font("標楷體", 10F);
            this._addCategoryButton.Location = new System.Drawing.Point(5, 578);
            this._addCategoryButton.Name = "_addCategoryButton";
            this._addCategoryButton.Size = new System.Drawing.Size(155, 29);
            this._addCategoryButton.TabIndex = 4;
            this._addCategoryButton.Text = "Add Category";
            this._addCategoryButton.UseVisualStyleBackColor = true;
            // 
            // _categoryListBox
            // 
            this._categoryListBox.FormattingEnabled = true;
            this._categoryListBox.ItemHeight = 16;
            this._categoryListBox.Location = new System.Drawing.Point(6, 6);
            this._categoryListBox.Name = "_categoryListBox";
            this._categoryListBox.Size = new System.Drawing.Size(394, 564);
            this._categoryListBox.TabIndex = 3;
            // 
            // RestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 667);
            this.Controls.Add(this._mainTabControl);
            this.Name = "RestaurantSideForm";
            this.Text = "POS-Restaurant Side";
            this._mainTabControl.ResumeLayout(false);
            this._mealManageTabPage.ResumeLayout(false);
            this._mealGroupBox1.ResumeLayout(false);
            this._mealGroupBox1.PerformLayout();
            this._categoryManageTabPage.ResumeLayout(false);
            this._categoryGroupBox.ResumeLayout(false);
            this._categoryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _mainTabControl;
        private System.Windows.Forms.TabPage _mealManageTabPage;
        private System.Windows.Forms.TabPage _categoryManageTabPage;
        private System.Windows.Forms.ListBox _mealListBox;
        private System.Windows.Forms.Button _deleteMealButton;
        private System.Windows.Forms.Button _addMealButton;
        private System.Windows.Forms.GroupBox _mealGroupBox1;
        private System.Windows.Forms.Button _saveButton1;
        private System.Windows.Forms.TextBox _mealDescriptionTextBox;
        private System.Windows.Forms.Label _mealDescriptionLabel;
        private System.Windows.Forms.TextBox _mealImageTextBox;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Label _mealImageLabel;
        private System.Windows.Forms.ComboBox _mealCategoryComboBox;
        private System.Windows.Forms.Label _mealCategoryLabel;
        private System.Windows.Forms.Label _Dollarlabel;
        private System.Windows.Forms.Label _mealPriceLabel;
        private System.Windows.Forms.TextBox _mealPriceTextBox;
        private System.Windows.Forms.Label _mealNameLabel;
        private System.Windows.Forms.TextBox _mealNameTextBox;
        private System.Windows.Forms.GroupBox _categoryGroupBox;
        private System.Windows.Forms.Button _saveButton2;
        private System.Windows.Forms.Label _categoryUsingLabel;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.TextBox _categoryNameTextBox;
        private System.Windows.Forms.Button _deleteCategoryButton;
        private System.Windows.Forms.Button _addCategoryButton;
        private System.Windows.Forms.ListBox _categoryListBox;
        private System.Windows.Forms.ListBox _categoryUsingListBox;
    }
}