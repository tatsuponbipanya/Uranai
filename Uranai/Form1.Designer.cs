﻿namespace Uranai
{
    partial class FormUranai
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUranaiStart = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.dateTimeUranai = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日の日付";
            // 
            // buttonUranaiStart
            // 
            this.buttonUranaiStart.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUranaiStart.Location = new System.Drawing.Point(46, 74);
            this.buttonUranaiStart.Name = "buttonUranaiStart";
            this.buttonUranaiStart.Size = new System.Drawing.Size(710, 63);
            this.buttonUranaiStart.TabIndex = 1;
            this.buttonUranaiStart.Text = "占う";
            this.buttonUranaiStart.UseVisualStyleBackColor = true;
            this.buttonUranaiStart.Click += new System.EventHandler(this.ButtonUranaiStart_Click);
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(46, 390);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(710, 48);
            this.textResult.TabIndex = 2;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResult.Image = global::Uranai.Properties.Resources.Title;
            this.pictureBoxResult.Location = new System.Drawing.Point(46, 172);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(710, 183);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 3;
            this.pictureBoxResult.TabStop = false;
            // 
            // dateTimeUranai
            // 
            this.dateTimeUranai.Location = new System.Drawing.Point(160, 27);
            this.dateTimeUranai.Name = "dateTimeUranai";
            this.dateTimeUranai.Size = new System.Drawing.Size(596, 22);
            this.dateTimeUranai.TabIndex = 4;
            // 
            // FormUranai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeUranai);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttonUranaiStart);
            this.Controls.Add(this.label1);
            this.Name = "FormUranai";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "占いアプリ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUranaiStart;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.DateTimePicker dateTimeUranai;
    }
}

