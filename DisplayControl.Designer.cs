namespace AWFAWS
{
    partial class DisplayControl
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
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.lblDataDateTime = new System.Windows.Forms.Label();
            this.cbDataCategorySelect = new System.Windows.Forms.ComboBox();
            this.pnlDataModeSelect = new System.Windows.Forms.Panel();
            this.rbForecastDataSelect = new System.Windows.Forms.RadioButton();
            this.rbObservedDataSelect = new System.Windows.Forms.RadioButton();
            this.btnLockToLatest = new System.Windows.Forms.Button();
            this.btnGoToOldest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlDataModeSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevData
            // 
            this.btnPrevData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnPrevData.BackgroundImage = global::AWFAWS.Properties.Resources.Previous;
            this.btnPrevData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevData.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevData.Location = new System.Drawing.Point(54, 57);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(36, 36);
            this.btnPrevData.TabIndex = 0;
            this.btnPrevData.UseVisualStyleBackColor = false;
            // 
            // btnNextData
            // 
            this.btnNextData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnNextData.BackgroundImage = global::AWFAWS.Properties.Resources.Next;
            this.btnNextData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextData.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextData.Location = new System.Drawing.Point(365, 57);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(36, 36);
            this.btnNextData.TabIndex = 1;
            this.btnNextData.UseVisualStyleBackColor = false;
            // 
            // lblDataDateTime
            // 
            this.lblDataDateTime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDateTime.Location = new System.Drawing.Point(96, 61);
            this.lblDataDateTime.Name = "lblDataDateTime";
            this.lblDataDateTime.Size = new System.Drawing.Size(263, 30);
            this.lblDataDateTime.TabIndex = 2;
            this.lblDataDateTime.Text = "12/30/2022   09:16:40 PM";
            this.lblDataDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDataCategorySelect
            // 
            this.cbDataCategorySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cbDataCategorySelect.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.cbDataCategorySelect.ForeColor = System.Drawing.Color.White;
            this.cbDataCategorySelect.FormattingEnabled = true;
            this.cbDataCategorySelect.Items.AddRange(new object[] {
            "test",
            "test 2",
            "test 3",
            "pesokg"});
            this.cbDataCategorySelect.Location = new System.Drawing.Point(184, 8);
            this.cbDataCategorySelect.Name = "cbDataCategorySelect";
            this.cbDataCategorySelect.Size = new System.Drawing.Size(244, 24);
            this.cbDataCategorySelect.TabIndex = 3;
            // 
            // pnlDataModeSelect
            // 
            this.pnlDataModeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlDataModeSelect.Controls.Add(this.rbForecastDataSelect);
            this.pnlDataModeSelect.Controls.Add(this.cbDataCategorySelect);
            this.pnlDataModeSelect.Controls.Add(this.rbObservedDataSelect);
            this.pnlDataModeSelect.Location = new System.Drawing.Point(12, 12);
            this.pnlDataModeSelect.Name = "pnlDataModeSelect";
            this.pnlDataModeSelect.Size = new System.Drawing.Size(431, 39);
            this.pnlDataModeSelect.TabIndex = 4;
            // 
            // rbForecastDataSelect
            // 
            this.rbForecastDataSelect.AutoSize = true;
            this.rbForecastDataSelect.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForecastDataSelect.Location = new System.Drawing.Point(90, 6);
            this.rbForecastDataSelect.Name = "rbForecastDataSelect";
            this.rbForecastDataSelect.Size = new System.Drawing.Size(88, 24);
            this.rbForecastDataSelect.TabIndex = 6;
            this.rbForecastDataSelect.TabStop = true;
            this.rbForecastDataSelect.Text = "Forecasted";
            this.rbForecastDataSelect.UseVisualStyleBackColor = true;
            // 
            // rbObservedDataSelect
            // 
            this.rbObservedDataSelect.AutoSize = true;
            this.rbObservedDataSelect.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObservedDataSelect.Location = new System.Drawing.Point(6, 6);
            this.rbObservedDataSelect.Name = "rbObservedDataSelect";
            this.rbObservedDataSelect.Size = new System.Drawing.Size(78, 24);
            this.rbObservedDataSelect.TabIndex = 5;
            this.rbObservedDataSelect.TabStop = true;
            this.rbObservedDataSelect.Text = "Observed";
            this.rbObservedDataSelect.UseVisualStyleBackColor = true;
            // 
            // btnLockToLatest
            // 
            this.btnLockToLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnLockToLatest.BackgroundImage = global::AWFAWS.Properties.Resources.Latest;
            this.btnLockToLatest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLockToLatest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockToLatest.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockToLatest.Location = new System.Drawing.Point(407, 57);
            this.btnLockToLatest.Name = "btnLockToLatest";
            this.btnLockToLatest.Size = new System.Drawing.Size(36, 36);
            this.btnLockToLatest.TabIndex = 5;
            this.btnLockToLatest.UseVisualStyleBackColor = false;
            // 
            // btnGoToOldest
            // 
            this.btnGoToOldest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnGoToOldest.BackgroundImage = global::AWFAWS.Properties.Resources.Oldest;
            this.btnGoToOldest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoToOldest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToOldest.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToOldest.Location = new System.Drawing.Point(12, 57);
            this.btnGoToOldest.Name = "btnGoToOldest";
            this.btnGoToOldest.Size = new System.Drawing.Size(36, 36);
            this.btnGoToOldest.TabIndex = 6;
            this.btnGoToOldest.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "<<<<";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(365, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = ">>>>";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 71);
            this.label2.TabIndex = 10;
            this.label2.Text = "This is where the help text will be. As you hover your mouse over the interface, " +
    "help will appear on how to use the part you\'re hovered over.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(96, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Select date/time";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(231, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "Animate";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // DisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(455, 217);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGoToOldest);
            this.Controls.Add(this.btnLockToLatest);
            this.Controls.Add(this.pnlDataModeSelect);
            this.Controls.Add(this.lblDataDateTime);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DisplayControl";
            this.Text = "Display Control";
            this.pnlDataModeSelect.ResumeLayout(false);
            this.pnlDataModeSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
        private System.Windows.Forms.Label lblDataDateTime;
        private System.Windows.Forms.ComboBox cbDataCategorySelect;
        private System.Windows.Forms.Panel pnlDataModeSelect;
        private System.Windows.Forms.RadioButton rbForecastDataSelect;
        private System.Windows.Forms.RadioButton rbObservedDataSelect;
        private System.Windows.Forms.Button btnLockToLatest;
        private System.Windows.Forms.Button btnGoToOldest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

