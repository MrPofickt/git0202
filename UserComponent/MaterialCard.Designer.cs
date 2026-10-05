namespace up02.UserComponent
{
    partial class MaterialCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelShortage = new System.Windows.Forms.Label();
            this.labelHiddenId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = false;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(174, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(570, 34);
            this.labelName.TabIndex = 1;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = false;
            this.labelDetails.Location = new System.Drawing.Point(174, 55);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(590, 96);
            this.labelDetails.TabIndex = 2;
            // Наследует шрифт от родительского UserControl (Comic Sans MS, 10F)
            // 
            // labelShortage
            // 
            this.labelShortage.AutoSize = false;
            this.labelShortage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.labelShortage.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.labelShortage.ForeColor = System.Drawing.Color.White;
            this.labelShortage.Location = new System.Drawing.Point(770, 14);
            this.labelShortage.Name = "labelShortage";
            this.labelShortage.Size = new System.Drawing.Size(220, 70);
            this.labelShortage.TabIndex = 3;
            this.labelShortage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHiddenId
            // 
            this.labelHiddenId.AutoSize = true;
            this.labelHiddenId.Location = new System.Drawing.Point(14, 160);
            this.labelHiddenId.Name = "labelHiddenId";
            this.labelHiddenId.Size = new System.Drawing.Size(0, 19);
            this.labelHiddenId.TabIndex = 4;
            this.labelHiddenId.Visible = false;
            // 
            // MaterialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.labelHiddenId);
            this.Controls.Add(this.labelShortage);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxImage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.Name = "MaterialCard";
            this.Size = new System.Drawing.Size(1010, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelShortage;
        private System.Windows.Forms.Label labelHiddenId;
    }
}