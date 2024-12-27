namespace GDiK
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDecimalInput = new System.Windows.Forms.TextBox();
            this.txtBinaryResult = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.chkAutoCalculate = new System.Windows.Forms.CheckBox();
            this.chkSaveToFile = new System.Windows.Forms.CheckBox();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDecimalInput
            // 
            this.txtDecimalInput.Location = new System.Drawing.Point(12, 12);
            this.txtDecimalInput.Name = "txtDecimalInput";
            this.txtDecimalInput.Size = new System.Drawing.Size(260, 20);
            this.txtDecimalInput.TabIndex = 0;
            this.txtDecimalInput.TextChanged += new System.EventHandler(this.txtDecimalInput_TextChanged);
            // 
            // txtBinaryResult
            // 
            this.txtBinaryResult.Location = new System.Drawing.Point(12, 38);
            this.txtBinaryResult.Name = "txtBinaryResult";
            this.txtBinaryResult.ReadOnly = true;
            this.txtBinaryResult.Size = new System.Drawing.Size(260, 20);
            this.txtBinaryResult.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 61);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(278, 10);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(278, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(12, 84);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(341, 121);
            this.lstHistory.TabIndex = 5;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(278, 211);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btnClearHistory.TabIndex = 6;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // chkAutoCalculate
            // 
            this.chkAutoCalculate.AutoSize = true;
            this.chkAutoCalculate.Location = new System.Drawing.Point(12, 211);
            this.chkAutoCalculate.Name = "chkAutoCalculate";
            this.chkAutoCalculate.Size = new System.Drawing.Size(101, 17);
            this.chkAutoCalculate.TabIndex = 7;
            this.chkAutoCalculate.Text = "Auto Calculate";
            this.chkAutoCalculate.UseVisualStyleBackColor = true;
            // 
            // chkSaveToFile
            // 
            this.chkSaveToFile.AutoSize = true;
            this.chkSaveToFile.Location = new System.Drawing.Point(12, 234);
            this.chkSaveToFile.Name = "chkSaveToFile";
            this.chkSaveToFile.Size = new System.Drawing.Size(84, 17);
            this.chkSaveToFile.TabIndex = 8;
            this.chkSaveToFile.Text = "Save to File";
            this.chkSaveToFile.UseVisualStyleBackColor = true;
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Location = new System.Drawing.Point(102, 234);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(77, 17);
            this.chkAutoSave.TabIndex = 9;
            this.chkAutoSave.Text = "Auto Save";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(365, 261);

            this.Controls.Add(this.chkAutoSave);
            this.Controls.Add(this.chkSaveToFile);
            this.Controls.Add(this.chkAutoCalculate);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBinaryResult);
            this.Controls.Add(this.txtDecimalInput);
            this.Name = "MainForm";
            this.Text = "GDiK - Decimal to Binary Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDecimalInput;
        private System.Windows.Forms.TextBox txtBinaryResult;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.CheckBox chkAutoCalculate;
        private System.Windows.Forms.CheckBox chkSaveToFile;
        private System.Windows.Forms.CheckBox chkAutoSave;
    }
}
