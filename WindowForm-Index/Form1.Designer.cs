
namespace WindowForm_Index
{
  partial class Index
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
      this.lblTitle = new System.Windows.Forms.Label();
      this.gridCostumers = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridCostumers)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Location = new System.Drawing.Point(64, 26);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(103, 13);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "I\'m programing in C#";
      // 
      // gridCostumers
      // 
      this.gridCostumers.AllowUserToAddRows = false;
      this.gridCostumers.AllowUserToDeleteRows = false;
      this.gridCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridCostumers.Location = new System.Drawing.Point(91, 104);
      this.gridCostumers.Name = "gridCostumers";
      this.gridCostumers.ReadOnly = true;
      this.gridCostumers.Size = new System.Drawing.Size(569, 197);
      this.gridCostumers.TabIndex = 2;
      // 
      // Index
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gridCostumers);
      this.Controls.Add(this.lblTitle);
      this.Name = "Index";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.gridCostumers)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.DataGridView gridCostumers;
  }
}

