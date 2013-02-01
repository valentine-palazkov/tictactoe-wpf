using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TicTakToe.WinForms.ServiceBus.Messages;

namespace TicTakToe.WinForms
{
    partial class TicTakToeView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Location = new Point(0, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Size = new Size(390, 348);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// TicTakToeView
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.HotTrack;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "TicTakToeView";
			this.Size = new Size(390, 351);
			this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    }
}
