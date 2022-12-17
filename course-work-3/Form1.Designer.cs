namespace course_work_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCPU = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btMemory = new System.Windows.Forms.Button();
            this.btGPU = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lCPU = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lClock = new System.Windows.Forms.Label();
            this.lAmount = new System.Windows.Forms.Label();
            this.lCache = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCPU
            // 
            this.btCPU.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCPU.Location = new System.Drawing.Point(3, 3);
            this.btCPU.Name = "btCPU";
            this.btCPU.Size = new System.Drawing.Size(113, 67);
            this.btCPU.TabIndex = 5;
            this.btCPU.Text = "CPU";
            this.btCPU.UseVisualStyleBackColor = true;
            this.btCPU.Click += new System.EventHandler(this.btCPU_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btCPU);
            this.flowLayoutPanel1.Controls.Add(this.btMemory);
            this.flowLayoutPanel1.Controls.Add(this.btGPU);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(151, 296);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btMemory
            // 
            this.btMemory.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMemory.Location = new System.Drawing.Point(3, 76);
            this.btMemory.Name = "btMemory";
            this.btMemory.Size = new System.Drawing.Size(113, 67);
            this.btMemory.TabIndex = 7;
            this.btMemory.Text = "Memory";
            this.btMemory.UseVisualStyleBackColor = true;
            this.btMemory.Click += new System.EventHandler(this.btMemory_Click);
            // 
            // btGPU
            // 
            this.btGPU.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGPU.Location = new System.Drawing.Point(3, 149);
            this.btGPU.Name = "btGPU";
            this.btGPU.Size = new System.Drawing.Size(113, 67);
            this.btGPU.TabIndex = 8;
            this.btGPU.Text = "GPU";
            this.btGPU.UseVisualStyleBackColor = true;
            this.btGPU.Click += new System.EventHandler(this.btGPU_Click);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(195, 37);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(396, 30);
            this.pbar.TabIndex = 7;
            // 
            // lCPU
            // 
            this.lCPU.AutoSize = true;
            this.lCPU.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCPU.Location = new System.Drawing.Point(608, 34);
            this.lCPU.Name = "lCPU";
            this.lCPU.Size = new System.Drawing.Size(0, 43);
            this.lCPU.TabIndex = 8;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(192, 86);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(64, 43);
            this.lName.TabIndex = 9;
            this.lName.Text = "label1";
            // 
            // lClock
            // 
            this.lClock.AutoSize = true;
            this.lClock.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClock.Location = new System.Drawing.Point(192, 129);
            this.lClock.Name = "lClock";
            this.lClock.Size = new System.Drawing.Size(64, 43);
            this.lClock.TabIndex = 10;
            this.lClock.Text = "label1";
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmount.Location = new System.Drawing.Point(192, 172);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(64, 43);
            this.lAmount.TabIndex = 11;
            this.lAmount.Text = "label1";
            // 
            // lCache
            // 
            this.lCache.AutoSize = true;
            this.lCache.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCache.Location = new System.Drawing.Point(556, 86);
            this.lCache.Name = "lCache";
            this.lCache.Size = new System.Drawing.Size(64, 43);
            this.lCache.TabIndex = 12;
            this.lCache.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.lCache);
            this.Controls.Add(this.lAmount);
            this.Controls.Add(this.lClock);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lCPU);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Resource monitor";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCPU;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btMemory;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label lCPU;
        private System.Windows.Forms.Button btGPU;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lClock;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label lCache;
    }
}

