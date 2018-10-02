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
            this._OkButton = new System.Windows.Forms.Button();
            this._notification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _OkButton
            // 
            this._OkButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._OkButton.Location = new System.Drawing.Point(280, 180);
            this._OkButton.Name = "_OkButton";
            this._OkButton.Size = new System.Drawing.Size(101, 27);
            this._OkButton.TabIndex = 0;
            this._OkButton.Text = "OK";
            this._OkButton.UseVisualStyleBackColor = true;
            // 
            // _notification
            // 
            this._notification.AutoSize = true;
            this._notification.Font = new System.Drawing.Font("標楷體", 50F, System.Drawing.FontStyle.Bold);
            this._notification.Location = new System.Drawing.Point(92, 65);
            this._notification.Name = "_notification";
            this._notification.Size = new System.Drawing.Size(484, 67);
            this._notification.TabIndex = 1;
            this._notification.Text = "Comming Soon!";
            // 
            // RestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 268);
            this.Controls.Add(this._notification);
            this.Controls.Add(this._OkButton);
            this.Name = "RestaurantSideForm";
            this.Text = "POS-Restaurant Side";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _OkButton;
        private System.Windows.Forms.Label _notification;
    }
}