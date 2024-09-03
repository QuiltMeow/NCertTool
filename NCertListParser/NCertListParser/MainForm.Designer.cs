namespace NCertListParser
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbNormalFunction = new System.Windows.Forms.GroupBox();
            this.btnCrawlDetailData = new System.Windows.Forms.Button();
            this.btnCrawlId = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnOutputForm = new System.Windows.Forms.Button();
            this.gbBatchFunction = new System.Windows.Forms.GroupBox();
            this.btnCrawlAllDetailData = new System.Windows.Forms.Button();
            this.btnCrawlAllId = new System.Windows.Forms.Button();
            this.btnWebForm = new System.Windows.Forms.Button();
            this.btnCustomCode = new System.Windows.Forms.Button();
            this.btnProgressForm = new System.Windows.Forms.Button();
            this.gbOutputFunction = new System.Windows.Forms.GroupBox();
            this.gbInteractFunction = new System.Windows.Forms.GroupBox();
            this.timerInit = new System.Windows.Forms.Timer(this.components);
            this.gbNormalFunction.SuspendLayout();
            this.gbBatchFunction.SuspendLayout();
            this.gbOutputFunction.SuspendLayout();
            this.gbInteractFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNormalFunction
            // 
            this.gbNormalFunction.Controls.Add(this.btnCrawlDetailData);
            this.gbNormalFunction.Controls.Add(this.btnCrawlId);
            this.gbNormalFunction.Controls.Add(this.btnHomePage);
            this.gbNormalFunction.Location = new System.Drawing.Point(15, 15);
            this.gbNormalFunction.Name = "gbNormalFunction";
            this.gbNormalFunction.Size = new System.Drawing.Size(320, 60);
            this.gbNormalFunction.TabIndex = 0;
            this.gbNormalFunction.TabStop = false;
            this.gbNormalFunction.Text = "一般功能";
            // 
            // btnCrawlDetailData
            // 
            this.btnCrawlDetailData.Location = new System.Drawing.Point(202, 25);
            this.btnCrawlDetailData.Name = "btnCrawlDetailData";
            this.btnCrawlDetailData.Size = new System.Drawing.Size(100, 23);
            this.btnCrawlDetailData.TabIndex = 2;
            this.btnCrawlDetailData.Text = "採集詳細資料";
            this.btnCrawlDetailData.UseVisualStyleBackColor = true;
            this.btnCrawlDetailData.Click += new System.EventHandler(this.btnCrawlDetailData_Click);
            // 
            // btnCrawlId
            // 
            this.btnCrawlId.Location = new System.Drawing.Point(96, 25);
            this.btnCrawlId.Name = "btnCrawlId";
            this.btnCrawlId.Size = new System.Drawing.Size(100, 23);
            this.btnCrawlId.TabIndex = 1;
            this.btnCrawlId.Text = "採集本頁編號";
            this.btnCrawlId.UseVisualStyleBackColor = true;
            this.btnCrawlId.Click += new System.EventHandler(this.btnCrawlId_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(15, 25);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(75, 23);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "返回首頁";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnOutputForm
            // 
            this.btnOutputForm.Location = new System.Drawing.Point(15, 25);
            this.btnOutputForm.Name = "btnOutputForm";
            this.btnOutputForm.Size = new System.Drawing.Size(75, 23);
            this.btnOutputForm.TabIndex = 0;
            this.btnOutputForm.Text = "輸出視窗";
            this.btnOutputForm.UseVisualStyleBackColor = true;
            this.btnOutputForm.Click += new System.EventHandler(this.btnOutputForm_Click);
            // 
            // gbBatchFunction
            // 
            this.gbBatchFunction.Controls.Add(this.btnCrawlAllDetailData);
            this.gbBatchFunction.Controls.Add(this.btnCrawlAllId);
            this.gbBatchFunction.Location = new System.Drawing.Point(345, 15);
            this.gbBatchFunction.Name = "gbBatchFunction";
            this.gbBatchFunction.Size = new System.Drawing.Size(255, 60);
            this.gbBatchFunction.TabIndex = 1;
            this.gbBatchFunction.TabStop = false;
            this.gbBatchFunction.Text = "批量功能";
            // 
            // btnCrawlAllDetailData
            // 
            this.btnCrawlAllDetailData.Location = new System.Drawing.Point(121, 25);
            this.btnCrawlAllDetailData.Name = "btnCrawlAllDetailData";
            this.btnCrawlAllDetailData.Size = new System.Drawing.Size(120, 23);
            this.btnCrawlAllDetailData.TabIndex = 1;
            this.btnCrawlAllDetailData.Text = "採集所有詳細資料";
            this.btnCrawlAllDetailData.UseVisualStyleBackColor = true;
            this.btnCrawlAllDetailData.Click += new System.EventHandler(this.btnCrawlAllDetailData_Click);
            // 
            // btnCrawlAllId
            // 
            this.btnCrawlAllId.Location = new System.Drawing.Point(15, 25);
            this.btnCrawlAllId.Name = "btnCrawlAllId";
            this.btnCrawlAllId.Size = new System.Drawing.Size(100, 23);
            this.btnCrawlAllId.TabIndex = 0;
            this.btnCrawlAllId.Text = "採集所有編號";
            this.btnCrawlAllId.UseVisualStyleBackColor = true;
            this.btnCrawlAllId.Click += new System.EventHandler(this.btnCrawlAllId_Click);
            // 
            // btnWebForm
            // 
            this.btnWebForm.Location = new System.Drawing.Point(15, 25);
            this.btnWebForm.Name = "btnWebForm";
            this.btnWebForm.Size = new System.Drawing.Size(75, 23);
            this.btnWebForm.TabIndex = 0;
            this.btnWebForm.Text = "網頁視窗";
            this.btnWebForm.UseVisualStyleBackColor = true;
            this.btnWebForm.Click += new System.EventHandler(this.btnWebForm_Click);
            // 
            // btnCustomCode
            // 
            this.btnCustomCode.Location = new System.Drawing.Point(96, 25);
            this.btnCustomCode.Name = "btnCustomCode";
            this.btnCustomCode.Size = new System.Drawing.Size(140, 23);
            this.btnCustomCode.TabIndex = 1;
            this.btnCustomCode.Text = "自訂程式碼注入工具";
            this.btnCustomCode.UseVisualStyleBackColor = true;
            this.btnCustomCode.Click += new System.EventHandler(this.btnCustomCode_Click);
            // 
            // btnProgressForm
            // 
            this.btnProgressForm.Location = new System.Drawing.Point(96, 25);
            this.btnProgressForm.Name = "btnProgressForm";
            this.btnProgressForm.Size = new System.Drawing.Size(75, 23);
            this.btnProgressForm.TabIndex = 1;
            this.btnProgressForm.Text = "進度視窗";
            this.btnProgressForm.UseVisualStyleBackColor = true;
            this.btnProgressForm.Click += new System.EventHandler(this.btnProgressForm_Click);
            // 
            // gbOutputFunction
            // 
            this.gbOutputFunction.Controls.Add(this.btnOutputForm);
            this.gbOutputFunction.Controls.Add(this.btnProgressForm);
            this.gbOutputFunction.Location = new System.Drawing.Point(15, 85);
            this.gbOutputFunction.Name = "gbOutputFunction";
            this.gbOutputFunction.Size = new System.Drawing.Size(320, 60);
            this.gbOutputFunction.TabIndex = 2;
            this.gbOutputFunction.TabStop = false;
            this.gbOutputFunction.Text = "輸出功能";
            // 
            // gbInteractFunction
            // 
            this.gbInteractFunction.Controls.Add(this.btnWebForm);
            this.gbInteractFunction.Controls.Add(this.btnCustomCode);
            this.gbInteractFunction.Location = new System.Drawing.Point(345, 85);
            this.gbInteractFunction.Name = "gbInteractFunction";
            this.gbInteractFunction.Size = new System.Drawing.Size(255, 60);
            this.gbInteractFunction.TabIndex = 3;
            this.gbInteractFunction.TabStop = false;
            this.gbInteractFunction.Text = "交互功能";
            // 
            // timerInit
            // 
            this.timerInit.Enabled = true;
            this.timerInit.Interval = 1;
            this.timerInit.Tick += new System.EventHandler(this.timerInit_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 166);
            this.Controls.Add(this.gbInteractFunction);
            this.Controls.Add(this.gbOutputFunction);
            this.Controls.Add(this.gbBatchFunction);
            this.Controls.Add(this.gbNormalFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "資安訊息警訊採集工具";
            this.gbNormalFunction.ResumeLayout(false);
            this.gbBatchFunction.ResumeLayout(false);
            this.gbOutputFunction.ResumeLayout(false);
            this.gbInteractFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNormalFunction;
        private System.Windows.Forms.Button btnCrawlDetailData;
        private System.Windows.Forms.Button btnCrawlId;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.GroupBox gbBatchFunction;
        private System.Windows.Forms.Button btnCrawlAllDetailData;
        private System.Windows.Forms.Button btnCrawlAllId;
        private System.Windows.Forms.Button btnWebForm;
        private System.Windows.Forms.Button btnCustomCode;
        private System.Windows.Forms.Button btnOutputForm;
        private System.Windows.Forms.Button btnProgressForm;
        private System.Windows.Forms.GroupBox gbOutputFunction;
        private System.Windows.Forms.GroupBox gbInteractFunction;
        private System.Windows.Forms.Timer timerInit;
    }
}

