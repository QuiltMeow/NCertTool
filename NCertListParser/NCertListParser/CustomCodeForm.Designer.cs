namespace NCertListParser
{
    partial class CustomCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCodeForm));
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtCode = new ScintillaNET.Scintilla();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(19, 515);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(775, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "執行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(19, 335);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(775, 165);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "";
            // 
            // txtCode
            // 
            this.txtCode.AutoCMaxHeight = 9;
            this.txtCode.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.txtCode.BorderStyle = ScintillaNET.BorderStyle.FixedSingle;
            this.txtCode.CaretLineBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtCode.CaretLineVisible = true;
            this.txtCode.LexerName = null;
            this.txtCode.Location = new System.Drawing.Point(19, 45);
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollWidth = 49;
            this.txtCode.Size = new System.Drawing.Size(775, 240);
            this.txtCode.TabIndents = true;
            this.txtCode.TabIndex = 1;
            this.txtCode.UseRightToLeftReadingLayout = false;
            this.txtCode.WrapMode = ScintillaNET.WrapMode.None;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCode.Location = new System.Drawing.Point(15, 15);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(105, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "程式碼編輯區";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelResult.Location = new System.Drawing.Point(15, 305);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(73, 20);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "執行結果";
            // 
            // CustomCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "CustomCodeForm";
            this.Text = "自訂程式碼編輯器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomCodeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox txtResult;
        private ScintillaNET.Scintilla txtCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelResult;
    }
}