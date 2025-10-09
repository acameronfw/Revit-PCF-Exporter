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
            darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
            darkTreeView1 = new DarkUI.Controls.DarkTreeView();
            darkListView1 = new DarkUI.Controls.DarkListView();
            darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            SuspendLayout();
            // 
            // darkContextMenu1
            // 
            darkContextMenu1.BackColor = Color.FromArgb(60, 63, 65);
            darkContextMenu1.ForeColor = Color.FromArgb(220, 220, 220);
            darkContextMenu1.Name = "darkContextMenu1";
            darkContextMenu1.Size = new Size(61, 4);
            // 
            // darkTreeView1
            // 
            darkTreeView1.Location = new Point(137, 155);
            darkTreeView1.MaxDragChange = 20;
            darkTreeView1.Name = "darkTreeView1";
            darkTreeView1.Size = new Size(75, 23);
            darkTreeView1.TabIndex = 1;
            darkTreeView1.Text = "darkTreeView1";
            // 
            // darkListView1
            // 
            darkListView1.Location = new Point(248, 164);
            darkListView1.Name = "darkListView1";
            darkListView1.Size = new Size(75, 23);
            darkListView1.TabIndex = 2;
            darkListView1.Text = "darkListView1";
            // 
            // darkGroupBox1
            // 
            darkGroupBox1.BorderColor = Color.FromArgb(51, 51, 51);
            darkGroupBox1.Location = new Point(397, 133);
            darkGroupBox1.Name = "darkGroupBox1";
            darkGroupBox1.Size = new Size(200, 100);
            darkGroupBox1.TabIndex = 3;
            darkGroupBox1.TabStop = false;
            darkGroupBox1.Text = "darkGroupBox1";
            darkGroupBox1.Enter += darkGroupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(darkGroupBox1);
            Controls.Add(darkListView1);
            Controls.Add(darkTreeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DarkUI.Controls.DarkContextMenu darkContextMenu1;
        private DarkUI.Controls.DarkTreeView darkTreeView1;
        private DarkUI.Controls.DarkListView darkListView1;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
    }
}
