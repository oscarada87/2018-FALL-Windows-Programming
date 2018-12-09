namespace hw2
{
    partial class Form1
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
            this._daimondButton = new System.Windows.Forms.Button();
            this._lineButton = new System.Windows.Forms.Button();
            this._clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _daimondButton
            // 
            this._daimondButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._daimondButton.Location = new System.Drawing.Point(12, 12);
            this._daimondButton.Name = "_daimondButton";
            this._daimondButton.Size = new System.Drawing.Size(249, 33);
            this._daimondButton.TabIndex = 0;
            this._daimondButton.Text = "Daimond";
            this._daimondButton.UseVisualStyleBackColor = true;
            // 
            // _lineButton
            // 
            this._lineButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._lineButton.Location = new System.Drawing.Point(277, 12);
            this._lineButton.Name = "_lineButton";
            this._lineButton.Size = new System.Drawing.Size(249, 33);
            this._lineButton.TabIndex = 3;
            this._lineButton.Text = "Line";
            this._lineButton.UseVisualStyleBackColor = true;
            // 
            // _clearButton
            // 
            this._clearButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._clearButton.Location = new System.Drawing.Point(539, 12);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(249, 33);
            this._clearButton.TabIndex = 4;
            this._clearButton.Text = "Clear";
            this._clearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._clearButton);
            this.Controls.Add(this._lineButton);
            this.Controls.Add(this._daimondButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _daimondButton;
        private System.Windows.Forms.Button _lineButton;
        private System.Windows.Forms.Button _clearButton;
    }
}

