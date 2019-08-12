namespace DOT.NET_Version
{
  partial class MainForm
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
      this.lblMessage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblMessage
      // 
      this.lblMessage.BackColor = System.Drawing.Color.Yellow;
      this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
      this.lblMessage.Location = new System.Drawing.Point(0, 0);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(664, 154);
      this.lblMessage.TabIndex = 0;
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(664, 154);
      this.Controls.Add(this.lblMessage);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Installed .NET Version >= 4.5";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblMessage;
  }
}

