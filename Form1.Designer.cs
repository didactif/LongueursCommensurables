namespace LongueursCommensurables
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLargeLabel;
        private System.Windows.Forms.TextBox textBoxSmallLabel;
        private System.Windows.Forms.TextBox textBoxDivisions;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelLargeLabel;
        private System.Windows.Forms.Label labelSmallLabel;
        private System.Windows.Forms.Label labelDivisions;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxRandomLength;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLargeLabel = new System.Windows.Forms.TextBox();
            this.textBoxSmallLabel = new System.Windows.Forms.TextBox();
            this.textBoxDivisions = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelLargeLabel = new System.Windows.Forms.Label();
            this.labelSmallLabel = new System.Windows.Forms.Label();
            this.labelDivisions = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxRandomLength = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 338);
            this.panel1.TabIndex = 0;
            //
            // textBoxLargeLabel
            //
            this.textBoxLargeLabel.Location = new System.Drawing.Point(226, 27);
            this.textBoxLargeLabel.Name = "textBoxLargeLabel";
            this.textBoxLargeLabel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLargeLabel.TabIndex = 1;
            //
            // textBoxSmallLabel
            //
            this.textBoxSmallLabel.Location = new System.Drawing.Point(226, 53);
            this.textBoxSmallLabel.Name = "textBoxSmallLabel";
            this.textBoxSmallLabel.Size = new System.Drawing.Size(100, 20);
            this.textBoxSmallLabel.TabIndex = 2;
            //
            // textBoxDivisions
            //
            this.textBoxDivisions.Location = new System.Drawing.Point(226, 79);
            this.textBoxDivisions.Name = "textBoxDivisions";
            this.textBoxDivisions.Size = new System.Drawing.Size(100, 20);
            this.textBoxDivisions.TabIndex = 3;
            //
            // buttonConfirm
            //
            this.buttonConfirm.Location = new System.Drawing.Point(226, 105);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 27);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirmer";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            //
            // labelLargeLabel
            //
            this.labelLargeLabel.AutoSize = true;
            this.labelLargeLabel.Location = new System.Drawing.Point(12, 30);
            this.labelLargeLabel.Name = "labelLargeLabel";
            this.labelLargeLabel.Size = new System.Drawing.Size(132, 13);
            this.labelLargeLabel.TabIndex = 5;
            this.labelLargeLabel.Text = "Label pour la grande bande :";
            //
            // labelSmallLabel
            //
            this.labelSmallLabel.AutoSize = true;
            this.labelSmallLabel.Location = new System.Drawing.Point(12, 56);
            this.labelSmallLabel.Name = "labelSmallLabel";
            this.labelSmallLabel.Size = new System.Drawing.Size(125, 13);
            this.labelSmallLabel.TabIndex = 6;
            this.labelSmallLabel.Text = "Label pour la petite bande :";
            //
            // labelDivisions
            //
            this.labelDivisions.AutoSize = true;
            this.labelDivisions.Location = new System.Drawing.Point(12, 82);
            this.labelDivisions.Name = "labelDivisions";
            this.labelDivisions.Size = new System.Drawing.Size(131, 13);
            this.labelDivisions.TabIndex = 7;
            this.labelDivisions.Text = "Nombre de divisions (parts) :";
            //
            // buttonClear
            //
            this.buttonClear.Location = new System.Drawing.Point(688, 431);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 27);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Effacer";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            //
            // fichierToolStripMenuItem
            //
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            //
            // optionsToolStripMenuItem
            //
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            //
            // aideToolStripMenuItem
            //
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            //
            // àProposToolStripMenuItem
            //
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            //
            // checkBoxRandomLength
            //
            this.checkBoxRandomLength.AutoSize = true;
            this.checkBoxRandomLength.Location = new System.Drawing.Point(332, 30);
            this.checkBoxRandomLength.Name = "checkBoxRandomLength";
            this.checkBoxRandomLength.Size = new System.Drawing.Size(117, 17);
            this.checkBoxRandomLength.TabIndex = 10;
            this.checkBoxRandomLength.Text = "Longueur aléatoire";
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.checkBoxRandomLength);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelDivisions);
            this.Controls.Add(this.labelSmallLabel);
            this.Controls.Add(this.labelLargeLabel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxDivisions);
            this.Controls.Add(this.textBoxSmallLabel);
            this.Controls.Add(this.textBoxLargeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rectangle Divider";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
