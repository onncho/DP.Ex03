﻿namespace FacebookApplication
{
    public partial class AnalysisProgressBar
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
            this.progressBarForLikeAnalysis = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBarForLikeAnalysis
            // 
            this.progressBarForLikeAnalysis.Location = new System.Drawing.Point(26, 35);
            this.progressBarForLikeAnalysis.Name = "progressBarForLikeAnalysis";
            this.progressBarForLikeAnalysis.Size = new System.Drawing.Size(370, 23);
            this.progressBarForLikeAnalysis.TabIndex = 0;
            // 
            // AnalysisProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 91);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarForLikeAnalysis);
            this.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalysisProgressBar";
            this.Text = "Analysis Progress";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarForLikeAnalysis;
    }
}