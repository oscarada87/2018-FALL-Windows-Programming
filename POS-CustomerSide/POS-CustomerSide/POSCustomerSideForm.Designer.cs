namespace POSCustomerSide
{
    partial class POSCustomerSideForm
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
            this._mealButton1 = new System.Windows.Forms.Button();
            this._mealButton2 = new System.Windows.Forms.Button();
            this._mealButton3 = new System.Windows.Forms.Button();
            this._mealButton4 = new System.Windows.Forms.Button();
            this._mealButton5 = new System.Windows.Forms.Button();
            this._mealButton6 = new System.Windows.Forms.Button();
            this._mealButton7 = new System.Windows.Forms.Button();
            this._mealButton8 = new System.Windows.Forms.Button();
            this._mealButton9 = new System.Windows.Forms.Button();
            this._mealButton10 = new System.Windows.Forms.Button();
            this._mealButton11 = new System.Windows.Forms.Button();
            this._mealButton12 = new System.Windows.Forms.Button();
            this._mealButton13 = new System.Windows.Forms.Button();
            this._mealButton14 = new System.Windows.Forms.Button();
            this._mealButton15 = new System.Windows.Forms.Button();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._pageLabel1 = new System.Windows.Forms.Label();
            this._previousPageButton = new System.Windows.Forms.Button();
            this._mealGridView = new System.Windows.Forms.DataGridView();
            this._mealsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._addButton.Location = new System.Drawing.Point(386, 571);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(150, 31);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _mealsGroupBox
            // 
            this._mealsGroupBox.Controls.Add(this._mealButton1);
            this._mealsGroupBox.Controls.Add(this._mealButton2);
            this._mealsGroupBox.Controls.Add(this._mealButton3);
            this._mealsGroupBox.Controls.Add(this._mealButton4);
            this._mealsGroupBox.Controls.Add(this._mealButton5);
            this._mealsGroupBox.Controls.Add(this._mealButton6);
            this._mealsGroupBox.Controls.Add(this._mealButton7);
            this._mealsGroupBox.Controls.Add(this._mealButton8);
            this._mealsGroupBox.Controls.Add(this._mealButton9);
            this._mealsGroupBox.Controls.Add(this._mealButton10);
            this._mealsGroupBox.Controls.Add(this._mealButton11);
            this._mealsGroupBox.Controls.Add(this._mealButton12);
            this._mealsGroupBox.Controls.Add(this._mealButton13);
            this._mealsGroupBox.Controls.Add(this._mealButton14);
            this._mealsGroupBox.Controls.Add(this._mealButton15);
            this._mealsGroupBox.Controls.Add(this._nextPageButton);
            this._mealsGroupBox.Controls.Add(this._addButton);
            this._mealsGroupBox.Controls.Add(this._pageLabel1);
            this._mealsGroupBox.Controls.Add(this._previousPageButton);
            this._mealsGroupBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mealsGroupBox.Location = new System.Drawing.Point(13, 12);
            this._mealsGroupBox.Name = "_mealsGroupBox";
            this._mealsGroupBox.Size = new System.Drawing.Size(572, 651);
            this._mealsGroupBox.TabIndex = 7;
            this._mealsGroupBox.TabStop = false;
            this._mealsGroupBox.Text = "Meals";
            // 
            // _mealButton1
            // 
            this._mealButton1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton1.Location = new System.Drawing.Point(20, 41);
            this._mealButton1.Name = "_mealButton1";
            this._mealButton1.Size = new System.Drawing.Size(160, 150);
            this._mealButton1.TabIndex = 7;
            this._mealButton1.Text = "大麥克\r\n$ 69元";
            this._mealButton1.UseVisualStyleBackColor = true;
            this._mealButton1.Click += new System.EventHandler(this.MealButton1Click);
            // 
            // _mealButton2
            // 
            this._mealButton2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton2.Location = new System.Drawing.Point(202, 41);
            this._mealButton2.Name = "_mealButton2";
            this._mealButton2.Size = new System.Drawing.Size(160, 150);
            this._mealButton2.TabIndex = 8;
            this._mealButton2.Text = "雙層牛肉吉事堡\r\n$ 59元";
            this._mealButton2.UseVisualStyleBackColor = true;
            this._mealButton2.Click += new System.EventHandler(this.MealButton2Click);
            // 
            // _mealButton3
            // 
            this._mealButton3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton3.Location = new System.Drawing.Point(386, 41);
            this._mealButton3.Name = "_mealButton3";
            this._mealButton3.Size = new System.Drawing.Size(160, 150);
            this._mealButton3.TabIndex = 9;
            this._mealButton3.Text = "安格斯黑牛堡\r\n$ 99元";
            this._mealButton3.UseVisualStyleBackColor = true;
            this._mealButton3.Click += new System.EventHandler(this.MealButton3Click);
            // 
            // _mealButton4
            // 
            this._mealButton4.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton4.Location = new System.Drawing.Point(20, 205);
            this._mealButton4.Name = "_mealButton4";
            this._mealButton4.Size = new System.Drawing.Size(160, 150);
            this._mealButton4.TabIndex = 10;
            this._mealButton4.Text = "嫩煎雞腿堡\r\n$ 79元";
            this._mealButton4.UseVisualStyleBackColor = true;
            this._mealButton4.Click += new System.EventHandler(this.MealButton4Click);
            // 
            // _mealButton5
            // 
            this._mealButton5.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton5.Location = new System.Drawing.Point(202, 205);
            this._mealButton5.Name = "_mealButton5";
            this._mealButton5.Size = new System.Drawing.Size(160, 150);
            this._mealButton5.TabIndex = 11;
            this._mealButton5.Text = "麥香雞\r\n$ 49元";
            this._mealButton5.UseVisualStyleBackColor = true;
            this._mealButton5.Click += new System.EventHandler(this.MealButton5Click);
            // 
            // _mealButton6
            // 
            this._mealButton6.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton6.Location = new System.Drawing.Point(386, 205);
            this._mealButton6.Name = "_mealButton6";
            this._mealButton6.Size = new System.Drawing.Size(160, 150);
            this._mealButton6.TabIndex = 12;
            this._mealButton6.Text = "麥克雞塊 （6塊）\r\n$ 59元";
            this._mealButton6.UseVisualStyleBackColor = true;
            this._mealButton6.Click += new System.EventHandler(this.MealButton6Click);
            // 
            // _mealButton7
            // 
            this._mealButton7.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton7.Location = new System.Drawing.Point(20, 367);
            this._mealButton7.Name = "_mealButton7";
            this._mealButton7.Size = new System.Drawing.Size(160, 150);
            this._mealButton7.TabIndex = 13;
            this._mealButton7.Text = "麥克雞塊（9塊）\r\n$ 89元";
            this._mealButton7.UseVisualStyleBackColor = true;
            this._mealButton7.Click += new System.EventHandler(this.MealButton7Click);
            // 
            // _mealButton8
            // 
            this._mealButton8.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton8.Location = new System.Drawing.Point(202, 367);
            this._mealButton8.Name = "_mealButton8";
            this._mealButton8.Size = new System.Drawing.Size(160, 150);
            this._mealButton8.TabIndex = 14;
            this._mealButton8.Text = "勁辣雞腿堡\r\n$ 69元";
            this._mealButton8.UseVisualStyleBackColor = true;
            this._mealButton8.Click += new System.EventHandler(this.MealButton8Click);
            // 
            // _mealButton9
            // 
            this._mealButton9.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton9.Location = new System.Drawing.Point(386, 367);
            this._mealButton9.Name = "_mealButton9";
            this._mealButton9.Size = new System.Drawing.Size(160, 150);
            this._mealButton9.TabIndex = 15;
            this._mealButton9.Text = "麥脆雞 （2塊）\r\n$ 104元";
            this._mealButton9.UseVisualStyleBackColor = true;
            this._mealButton9.Click += new System.EventHandler(this.MealButton9Click);
            // 
            // _mealButton10
            // 
            this._mealButton10.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton10.Location = new System.Drawing.Point(20, 41);
            this._mealButton10.Name = "_mealButton10";
            this._mealButton10.Size = new System.Drawing.Size(160, 150);
            this._mealButton10.TabIndex = 16;
            this._mealButton10.Text = "麥脆雞（3塊）\r\n$ 156元";
            this._mealButton10.UseVisualStyleBackColor = true;
            this._mealButton10.Visible = false;
            this._mealButton10.Click += new System.EventHandler(this.MealButton10Click);
            // 
            // _mealButton11
            // 
            this._mealButton11.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton11.Location = new System.Drawing.Point(202, 41);
            this._mealButton11.Name = "_mealButton11";
            this._mealButton11.Size = new System.Drawing.Size(160, 150);
            this._mealButton11.TabIndex = 17;
            this._mealButton11.Text = "黃金起司豬排堡\r\n$ 49元";
            this._mealButton11.UseVisualStyleBackColor = true;
            this._mealButton11.Visible = false;
            this._mealButton11.Click += new System.EventHandler(this.MealButton11Click);
            // 
            // _mealButton12
            // 
            this._mealButton12.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton12.Location = new System.Drawing.Point(386, 41);
            this._mealButton12.Name = "_mealButton12";
            this._mealButton12.Size = new System.Drawing.Size(160, 150);
            this._mealButton12.TabIndex = 18;
            this._mealButton12.Text = "麥香魚\r\n$ 49元";
            this._mealButton12.UseVisualStyleBackColor = true;
            this._mealButton12.Visible = false;
            this._mealButton12.Click += new System.EventHandler(this.MealButton12Click);
            // 
            // _mealButton13
            // 
            this._mealButton13.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton13.Location = new System.Drawing.Point(20, 205);
            this._mealButton13.Name = "_mealButton13";
            this._mealButton13.Size = new System.Drawing.Size(160, 150);
            this._mealButton13.TabIndex = 19;
            this._mealButton13.Text = "千島黃金蝦堡\r\n$ 69元";
            this._mealButton13.UseVisualStyleBackColor = true;
            this._mealButton13.Visible = false;
            this._mealButton13.Click += new System.EventHandler(this.MealButton13Click);
            // 
            // _mealButton14
            // 
            this._mealButton14.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton14.Location = new System.Drawing.Point(202, 205);
            this._mealButton14.Name = "_mealButton14";
            this._mealButton14.Size = new System.Drawing.Size(160, 150);
            this._mealButton14.TabIndex = 20;
            this._mealButton14.Text = "BLT 安格斯黑牛堡\r\n$ 109元";
            this._mealButton14.UseVisualStyleBackColor = true;
            this._mealButton14.Visible = false;
            this._mealButton14.Click += new System.EventHandler(this.MealButton14Click);
            // 
            // _mealButton15
            // 
            this._mealButton15.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton15.Location = new System.Drawing.Point(386, 205);
            this._mealButton15.Name = "_mealButton15";
            this._mealButton15.Size = new System.Drawing.Size(160, 150);
            this._mealButton15.TabIndex = 21;
            this._mealButton15.Text = "BLT 辣脆雞腿堡\r\n$ 109元";
            this._mealButton15.UseVisualStyleBackColor = true;
            this._mealButton15.Visible = false;
            this._mealButton15.Click += new System.EventHandler(this.MealButton15Click);
            // 
            // _nextPageButton
            // 
            this._nextPageButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._nextPageButton.Location = new System.Drawing.Point(386, 608);
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
            this._pageLabel1.Location = new System.Drawing.Point(22, 610);
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
            this._previousPageButton.Location = new System.Drawing.Point(230, 608);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._mealGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._mealGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mealGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._mealsName,
            this._mealsPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this._mealGridView.Size = new System.Drawing.Size(646, 572);
            this._mealGridView.TabIndex = 8;
            // 
            // _mealsName
            // 
            this._mealsName.HeaderText = "Name";
            this._mealsName.Name = "_mealsName";
            // 
            // _mealsPrice
            // 
            this._mealsPrice.HeaderText = "Unit Price";
            this._mealsPrice.Name = "_mealsPrice";
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this._totalLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this._totalLabel.Location = new System.Drawing.Point(1113, 612);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(150, 38);
            this._totalLabel.TabIndex = 7;
            this._totalLabel.Text = "Total: 0元";
            // 
            // POSCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 680);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._mealGridView);
            this.Controls.Add(this._mealsGroupBox);
            this.Name = "POSCustomerSideForm";
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
        private System.Windows.Forms.Button _mealButton9;
        private System.Windows.Forms.Button _mealButton8;
        private System.Windows.Forms.Button _mealButton7;
        private System.Windows.Forms.Button _mealButton6;
        private System.Windows.Forms.Button _mealButton5;
        private System.Windows.Forms.Button _mealButton4;
        private System.Windows.Forms.Button _mealButton3;
        private System.Windows.Forms.Button _mealButton2;
        private System.Windows.Forms.Button _mealButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealsPrice;
        private System.Windows.Forms.Button _mealButton15;
        private System.Windows.Forms.Button _mealButton14;
        private System.Windows.Forms.Button _mealButton13;
        private System.Windows.Forms.Button _mealButton12;
        private System.Windows.Forms.Button _mealButton11;
        private System.Windows.Forms.Button _mealButton10;
    }

}

