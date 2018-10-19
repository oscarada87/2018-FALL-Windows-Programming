namespace POSCustomerSide
{
    partial class CustomerSideForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._addButton = new System.Windows.Forms.Button();
            this._mealsGroupBox = new System.Windows.Forms.GroupBox();
            this._tabControlButton = new System.Windows.Forms.TabControl();
            this._mealDescriptionBox = new System.Windows.Forms.RichTextBox();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._pageLabel1 = new System.Windows.Forms.Label();
            this._previousPageButton = new System.Windows.Forms.Button();
            this._mealGridView = new System.Windows.Forms.DataGridView();
            this._totalLabel = new System.Windows.Forms.Label();
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._mealsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsQuantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._mealSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.Enabled = false;
            this._addButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._addButton.Location = new System.Drawing.Point(396, 660);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(150, 31);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _mealsGroupBox
            // 
            this._mealsGroupBox.Controls.Add(this._tabControlButton);
            this._mealsGroupBox.Controls.Add(this._mealDescriptionBox);
            this._mealsGroupBox.Controls.Add(this._nextPageButton);
            this._mealsGroupBox.Controls.Add(this._addButton);
            this._mealsGroupBox.Controls.Add(this._pageLabel1);
            this._mealsGroupBox.Controls.Add(this._previousPageButton);
            this._mealsGroupBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mealsGroupBox.Location = new System.Drawing.Point(13, 12);
            this._mealsGroupBox.Name = "_mealsGroupBox";
            this._mealsGroupBox.Size = new System.Drawing.Size(572, 735);
            this._mealsGroupBox.TabIndex = 7;
            this._mealsGroupBox.TabStop = false;
            this._mealsGroupBox.Text = "Meals";
            // 
            // _tabControlButton
            // 
            this._tabControlButton.Location = new System.Drawing.Point(20, 32);
            this._tabControlButton.Name = "_tabControlButton";
            this._tabControlButton.SelectedIndex = 0;
            this._tabControlButton.Size = new System.Drawing.Size(526, 506);
            this._tabControlButton.TabIndex = 23;
            // 
            // _mealDescriptionBox
            // 
            this._mealDescriptionBox.BackColor = System.Drawing.SystemColors.Window;
            this._mealDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._mealDescriptionBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._mealDescriptionBox.Location = new System.Drawing.Point(20, 544);
            this._mealDescriptionBox.Name = "_mealDescriptionBox";
            this._mealDescriptionBox.ReadOnly = true;
            this._mealDescriptionBox.Size = new System.Drawing.Size(526, 96);
            this._mealDescriptionBox.TabIndex = 22;
            this._mealDescriptionBox.Text = "";
            // 
            // _nextPageButton
            // 
            this._nextPageButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._nextPageButton.Location = new System.Drawing.Point(396, 697);
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(150, 31);
            this._nextPageButton.TabIndex = 4;
            this._nextPageButton.Text = "Next Page";
            this._nextPageButton.UseVisualStyleBackColor = true;
            this._nextPageButton.Click += new System.EventHandler(this.ClickNextPage);
            // 
            // _pageLabel1
            // 
            this._pageLabel1.AutoSize = true;
            this._pageLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this._pageLabel1.Location = new System.Drawing.Point(16, 699);
            this._pageLabel1.Name = "_pageLabel1";
            this._pageLabel1.Size = new System.Drawing.Size(93, 24);
            this._pageLabel1.TabIndex = 6;
            this._pageLabel1.Text = "Page: 1/2";
            // 
            // _previousPageButton
            // 
            this._previousPageButton.Cursor = System.Windows.Forms.Cursors.Default;
            this._previousPageButton.Enabled = false;
            this._previousPageButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._previousPageButton.Location = new System.Drawing.Point(240, 697);
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(150, 31);
            this._previousPageButton.TabIndex = 5;
            this._previousPageButton.Text = "Previos Page";
            this._previousPageButton.UseVisualStyleBackColor = true;
            this._previousPageButton.Click += new System.EventHandler(this.ClickPreviousPage);
            // 
            // _mealGridView
            // 
            this._mealGridView.AllowUserToAddRows = false;
            this._mealGridView.AllowUserToDeleteRows = false;
            this._mealGridView.AllowUserToResizeColumns = false;
            this._mealGridView.AllowUserToResizeRows = false;
            this._mealGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._mealGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._mealGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mealGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._mealsName,
            this._mealsCategory,
            this._mealsPrice,
            this._mealsQuantity,
            this._mealSubtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._mealGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._mealGridView.Location = new System.Drawing.Point(613, 24);
            this._mealGridView.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this._mealGridView.Name = "_mealGridView";
            this._mealGridView.RowHeadersVisible = false;
            this._mealGridView.RowTemplate.Height = 24;
            this._mealGridView.Size = new System.Drawing.Size(646, 682);
            this._mealGridView.TabIndex = 8;
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this._totalLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this._totalLabel.Location = new System.Drawing.Point(1109, 709);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(150, 38);
            this._totalLabel.TabIndex = 7;
            this._totalLabel.Text = "Total: 0元";
            // 
            // _deleteColumn
            // 
            this._deleteColumn.HeaderText = "Delete";
            this._deleteColumn.Name = "_deleteColumn";
            this._deleteColumn.ReadOnly = true;
            // 
            // _mealsName
            // 
            this._mealsName.HeaderText = "Name";
            this._mealsName.Name = "_mealsName";
            this._mealsName.ReadOnly = true;
            // 
            // _mealsCategory
            // 
            this._mealsCategory.HeaderText = "Category";
            this._mealsCategory.Name = "_mealsCategory";
            this._mealsCategory.ReadOnly = true;
            // 
            // _mealsPrice
            // 
            this._mealsPrice.HeaderText = "Unit Price";
            this._mealsPrice.Name = "_mealsPrice";
            this._mealsPrice.ReadOnly = true;
            // 
            // _mealsQuantity
            // 
            this._mealsQuantity.HeaderText = "Qty";
            this._mealsQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._mealsQuantity.Name = "_mealsQuantity";
            // 
            // _mealSubtotal
            // 
            this._mealSubtotal.HeaderText = "Subtotal";
            this._mealSubtotal.Name = "_mealSubtotal";
            this._mealSubtotal.ReadOnly = true;
            // 
            // CustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 759);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._mealGridView);
            this.Controls.Add(this._mealsGroupBox);
            this.Name = "CustomerSideForm";
            this.Text = "POS-Customer Side";
            this._mealsGroupBox.ResumeLayout(false);
            this._mealsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.GroupBox _mealsGroupBox;
        private System.Windows.Forms.Button _previousPageButton;
        private System.Windows.Forms.Button _nextPageButton;
        private System.Windows.Forms.Label _pageLabel1;
        private System.Windows.Forms.DataGridView _mealGridView;
        private System.Windows.Forms.Label _totalLabel;
        private System.Windows.Forms.RichTextBox _mealDescriptionBox;
        private System.Windows.Forms.TabControl _tabControlButton;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealsCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealsPrice;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _mealsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealSubtotal;
    }

}

