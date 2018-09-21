namespace hw1
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
            this._addButton1 = new System.Windows.Forms.Button();
            this._mealsGroupbox1 = new System.Windows.Forms.GroupBox();
            this._nextPageButton1 = new System.Windows.Forms.Button();
            this._mealButton9 = new System.Windows.Forms.Button();
            this._mealButton8 = new System.Windows.Forms.Button();
            this._mealButton7 = new System.Windows.Forms.Button();
            this._mealButton6 = new System.Windows.Forms.Button();
            this._mealButton5 = new System.Windows.Forms.Button();
            this._mealButton4 = new System.Windows.Forms.Button();
            this._mealButton3 = new System.Windows.Forms.Button();
            this._mealButton2 = new System.Windows.Forms.Button();
            this._mealButton1 = new System.Windows.Forms.Button();
            this._pageLabel1 = new System.Windows.Forms.Label();
            this._previousPageButton1 = new System.Windows.Forms.Button();
            this._mealGridView = new System.Windows.Forms.DataGridView();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealsGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _addButton1
            // 
            this._addButton1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._addButton1.Location = new System.Drawing.Point(483, 714);
            this._addButton1.Margin = new System.Windows.Forms.Padding(4);
            this._addButton1.Name = "_addButton1";
            this._addButton1.Size = new System.Drawing.Size(188, 39);
            this._addButton1.TabIndex = 3;
            this._addButton1.Text = "Add";
            this._addButton1.UseVisualStyleBackColor = true;
            this._addButton1.Click += new System.EventHandler(this.AddButton1Click);
            // 
            // _mealsGroupbox1
            // 
            this._mealsGroupbox1.Controls.Add(this._nextPageButton1);
            this._mealsGroupbox1.Controls.Add(this._addButton1);
            this._mealsGroupbox1.Controls.Add(this._mealButton9);
            this._mealsGroupbox1.Controls.Add(this._mealButton8);
            this._mealsGroupbox1.Controls.Add(this._mealButton7);
            this._mealsGroupbox1.Controls.Add(this._mealButton6);
            this._mealsGroupbox1.Controls.Add(this._mealButton5);
            this._mealsGroupbox1.Controls.Add(this._mealButton4);
            this._mealsGroupbox1.Controls.Add(this._mealButton3);
            this._mealsGroupbox1.Controls.Add(this._mealButton2);
            this._mealsGroupbox1.Controls.Add(this._mealButton1);
            this._mealsGroupbox1.Controls.Add(this._pageLabel1);
            this._mealsGroupbox1.Controls.Add(this._previousPageButton1);
            this._mealsGroupbox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mealsGroupbox1.Location = new System.Drawing.Point(16, 15);
            this._mealsGroupbox1.Margin = new System.Windows.Forms.Padding(4);
            this._mealsGroupbox1.Name = "_mealsGroupbox1";
            this._mealsGroupbox1.Padding = new System.Windows.Forms.Padding(4);
            this._mealsGroupbox1.Size = new System.Drawing.Size(715, 814);
            this._mealsGroupbox1.TabIndex = 7;
            this._mealsGroupbox1.TabStop = false;
            this._mealsGroupbox1.Text = "Meals";
            // 
            // _nextPageButton1
            // 
            this._nextPageButton1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._nextPageButton1.Location = new System.Drawing.Point(483, 760);
            this._nextPageButton1.Margin = new System.Windows.Forms.Padding(4);
            this._nextPageButton1.Name = "_nextPageButton1";
            this._nextPageButton1.Size = new System.Drawing.Size(188, 39);
            this._nextPageButton1.TabIndex = 4;
            this._nextPageButton1.Text = "Next Page";
            this._nextPageButton1.UseVisualStyleBackColor = true;
            // 
            // _mealButton9
            // 
            this._mealButton9.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton9.Location = new System.Drawing.Point(483, 459);
            this._mealButton9.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton9.Name = "_mealButton9";
            this._mealButton9.Size = new System.Drawing.Size(200, 188);
            this._mealButton9.TabIndex = 15;
            this._mealButton9.Text = "麥脆雞 （2塊）\r\n$ 104元";
            this._mealButton9.UseVisualStyleBackColor = true;
            this._mealButton9.Click += new System.EventHandler(this.MealButton9Click);
            // 
            // _mealButton8
            // 
            this._mealButton8.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton8.Location = new System.Drawing.Point(253, 459);
            this._mealButton8.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton8.Name = "_mealButton8";
            this._mealButton8.Size = new System.Drawing.Size(200, 188);
            this._mealButton8.TabIndex = 14;
            this._mealButton8.Text = "勁辣雞腿堡\r\n$ 69元";
            this._mealButton8.UseVisualStyleBackColor = true;
            this._mealButton8.Click += new System.EventHandler(this.MealButton8Click);
            // 
            // _mealButton7
            // 
            this._mealButton7.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton7.Location = new System.Drawing.Point(25, 459);
            this._mealButton7.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton7.Name = "_mealButton7";
            this._mealButton7.Size = new System.Drawing.Size(200, 188);
            this._mealButton7.TabIndex = 13;
            this._mealButton7.Text = "麥克雞塊（9塊）\r\n$ 89元";
            this._mealButton7.UseVisualStyleBackColor = true;
            this._mealButton7.Click += new System.EventHandler(this.MealButton7Click);
            // 
            // _mealButton6
            // 
            this._mealButton6.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton6.Location = new System.Drawing.Point(483, 256);
            this._mealButton6.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton6.Name = "_mealButton6";
            this._mealButton6.Size = new System.Drawing.Size(200, 188);
            this._mealButton6.TabIndex = 12;
            this._mealButton6.Text = "麥克雞塊 （6塊）\r\n$ 59元";
            this._mealButton6.UseVisualStyleBackColor = true;
            this._mealButton6.Click += new System.EventHandler(this.MealButton6Click);
            // 
            // _mealButton5
            // 
            this._mealButton5.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton5.Location = new System.Drawing.Point(253, 256);
            this._mealButton5.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton5.Name = "_mealButton5";
            this._mealButton5.Size = new System.Drawing.Size(200, 188);
            this._mealButton5.TabIndex = 11;
            this._mealButton5.Text = "麥香雞\r\n$ 49元";
            this._mealButton5.UseVisualStyleBackColor = true;
            this._mealButton5.Click += new System.EventHandler(this.MealButton5Click);
            // 
            // _mealButton4
            // 
            this._mealButton4.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton4.Location = new System.Drawing.Point(25, 256);
            this._mealButton4.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton4.Name = "_mealButton4";
            this._mealButton4.Size = new System.Drawing.Size(200, 188);
            this._mealButton4.TabIndex = 10;
            this._mealButton4.Text = "嫩煎雞腿堡\r\n$ 79元";
            this._mealButton4.UseVisualStyleBackColor = true;
            this._mealButton4.Click += new System.EventHandler(this.MealButton4Click);
            // 
            // _mealButton3
            // 
            this._mealButton3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton3.Location = new System.Drawing.Point(483, 51);
            this._mealButton3.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton3.Name = "_mealButton3";
            this._mealButton3.Size = new System.Drawing.Size(200, 188);
            this._mealButton3.TabIndex = 9;
            this._mealButton3.Text = "安格斯黑牛堡\r\n$ 99元";
            this._mealButton3.UseVisualStyleBackColor = true;
            this._mealButton3.Click += new System.EventHandler(this.MealButton3Click);
            // 
            // _mealButton2
            // 
            this._mealButton2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton2.Location = new System.Drawing.Point(253, 51);
            this._mealButton2.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton2.Name = "_mealButton2";
            this._mealButton2.Size = new System.Drawing.Size(200, 188);
            this._mealButton2.TabIndex = 8;
            this._mealButton2.Text = "雙層牛肉吉事堡\r\n$ 59元";
            this._mealButton2.UseVisualStyleBackColor = true;
            this._mealButton2.Click += new System.EventHandler(this.MealButton2Click);
            // 
            // _mealButton1
            // 
            this._mealButton1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._mealButton1.Location = new System.Drawing.Point(25, 51);
            this._mealButton1.Margin = new System.Windows.Forms.Padding(4);
            this._mealButton1.Name = "_mealButton1";
            this._mealButton1.Size = new System.Drawing.Size(200, 188);
            this._mealButton1.TabIndex = 7;
            this._mealButton1.Text = "大麥克\r\n$ 69元";
            this._mealButton1.UseVisualStyleBackColor = true;
            this._mealButton1.Click += new System.EventHandler(this.MealButton1Click);
            // 
            // _pageLabel1
            // 
            this._pageLabel1.AutoSize = true;
            this._pageLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this._pageLabel1.Location = new System.Drawing.Point(27, 762);
            this._pageLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._pageLabel1.Name = "_pageLabel1";
            this._pageLabel1.Size = new System.Drawing.Size(119, 30);
            this._pageLabel1.TabIndex = 6;
            this._pageLabel1.Text = "Page: 1/2";
            // 
            // _previousPageButton1
            // 
            this._previousPageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this._previousPageButton1.Enabled = false;
            this._previousPageButton1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._previousPageButton1.Location = new System.Drawing.Point(287, 760);
            this._previousPageButton1.Margin = new System.Windows.Forms.Padding(4);
            this._previousPageButton1.Name = "_previousPageButton1";
            this._previousPageButton1.Size = new System.Drawing.Size(188, 39);
            this._previousPageButton1.TabIndex = 5;
            this._previousPageButton1.Text = "Previos Page";
            this._previousPageButton1.UseVisualStyleBackColor = true;
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
            this._mealGridView.Location = new System.Drawing.Point(766, 30);
            this._mealGridView.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this._mealGridView.Name = "_mealGridView";
            this._mealGridView.RowHeadersVisible = false;
            this._mealGridView.RowTemplate.Height = 24;
            this._mealGridView.Size = new System.Drawing.Size(808, 715);
            this._mealGridView.TabIndex = 8;
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this._totalLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this._totalLabel.Location = new System.Drawing.Point(1391, 765);
            this._totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(183, 47);
            this._totalLabel.TabIndex = 7;
            this._totalLabel.Text = "Total: 0元";
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
            // POSCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1615, 850);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._mealGridView);
            this.Controls.Add(this._mealsGroupbox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POSCustomerSideForm";
            this.Text = "Form1";
            this._mealsGroupbox1.ResumeLayout(false);
            this._mealsGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addButton1;
        private System.Windows.Forms.GroupBox _mealsGroupbox1;
        private System.Windows.Forms.Button _previousPageButton1;
        private System.Windows.Forms.Button _nextPageButton1;
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
    }

}

