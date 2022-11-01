namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diffViewer1 = new DiffPlex.WindowsForms.Controls.DiffViewer();
            this.SuspendLayout();
            // 
            // diffViewer1
            // 
            this.diffViewer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diffViewer1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.diffViewer1.ChangeTypeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.diffViewer1.CollapseUnchangedSectionsToggleTitle = "_Collapse unchanged sections";
            this.diffViewer1.ContextLinesMenuItemsTitle = "_Lines for context";
            this.diffViewer1.DeletedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(216)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.diffViewer1.DeletedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diffViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffViewer1.FontFamilyNames = "Segoe UI";
            this.diffViewer1.FontSize = 12D;
            this.diffViewer1.FontStretch = System.Windows.FontStretch.FromOpenTypeStretch(5);
            this.diffViewer1.FontWeight = 400;
            this.diffViewer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diffViewer1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.diffViewer1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.diffViewer1.HeaderHeight = 20D;
            this.diffViewer1.IgnoreCase = false;
            this.diffViewer1.IgnoreUnchanged = false;
            this.diffViewer1.IgnoreWhiteSpace = true;
            this.diffViewer1.ImaginaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.diffViewer1.InlineModeToggleTitle = "_Unified view";
            this.diffViewer1.InsertedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diffViewer1.InsertedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diffViewer1.IsFontItalic = false;
            this.diffViewer1.IsSideBySide = true;
            this.diffViewer1.LineNumberForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(160)))));
            this.diffViewer1.LineNumberWidth = 60;
            this.diffViewer1.LinesContext = 1;
            this.diffViewer1.Location = new System.Drawing.Point(0, 0);
            this.diffViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diffViewer1.Name = "diffViewer1";
            this.diffViewer1.NewText = "";
            this.diffViewer1.NewTextHeader = null;
            this.diffViewer1.OldText = "";
            this.diffViewer1.OldTextHeader = "";
            this.diffViewer1.SideBySideModeToggleTitle = "_Split view";
            this.diffViewer1.Size = new System.Drawing.Size(560, 270);
            this.diffViewer1.SplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.diffViewer1.SplitterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.diffViewer1.SplitterBorderWidth = new System.Windows.Forms.Padding(0);
            this.diffViewer1.SplitterWidth = 5D;
            this.diffViewer1.TabIndex = 0;
            this.diffViewer1.UnchangedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diffViewer1.UnchangedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.diffViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DiffPlex.WindowsForms.Controls.DiffViewer diffViewer1;
    }
}