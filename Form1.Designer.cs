
namespace Kwiaciarnia
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
            this.lblFlowerName = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.cbRequirement = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbSpecie = new System.Windows.Forms.ComboBox();
            this.lblRequirement = new System.Windows.Forms.Label();
            this.cbTrait = new System.Windows.Forms.ComboBox();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.txtFlowerName = new System.Windows.Forms.TextBox();
            this.lblTrait = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFlowerName
            // 
            this.lblFlowerName.AutoSize = true;
            this.lblFlowerName.Location = new System.Drawing.Point(14, 15);
            this.lblFlowerName.Name = "lblFlowerName";
            this.lblFlowerName.Size = new System.Drawing.Size(108, 20);
            this.lblFlowerName.TabIndex = 0;
            this.lblFlowerName.Text = "Nazwa kwiatka";
            // 
            // cbPlace
            // 
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(125, 46);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(151, 28);
            this.cbPlace.TabIndex = 1;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(125, 80);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(151, 28);
            this.cbSort.TabIndex = 3;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(14, 49);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(83, 20);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Stanowiska";
            // 
            // cbRequirement
            // 
            this.cbRequirement.FormattingEnabled = true;
            this.cbRequirement.Location = new System.Drawing.Point(125, 114);
            this.cbRequirement.Name = "cbRequirement";
            this.cbRequirement.Size = new System.Drawing.Size(151, 28);
            this.cbRequirement.TabIndex = 5;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(14, 83);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(58, 20);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Pokroju";
            // 
            // cbSpecie
            // 
            this.cbSpecie.FormattingEnabled = true;
            this.cbSpecie.Location = new System.Drawing.Point(125, 148);
            this.cbSpecie.Name = "cbSpecie";
            this.cbSpecie.Size = new System.Drawing.Size(151, 28);
            this.cbSpecie.TabIndex = 7;
            // 
            // lblRequirement
            // 
            this.lblRequirement.AutoSize = true;
            this.lblRequirement.Location = new System.Drawing.Point(14, 117);
            this.lblRequirement.Name = "lblRequirement";
            this.lblRequirement.Size = new System.Drawing.Size(88, 20);
            this.lblRequirement.TabIndex = 6;
            this.lblRequirement.Text = "Wymagania";
            // 
            // cbTrait
            // 
            this.cbTrait.FormattingEnabled = true;
            this.cbTrait.Location = new System.Drawing.Point(125, 182);
            this.cbTrait.Name = "cbTrait";
            this.cbTrait.Size = new System.Drawing.Size(151, 28);
            this.cbTrait.TabIndex = 9;
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(14, 151);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(59, 20);
            this.lblSpecie.TabIndex = 8;
            this.lblSpecie.Text = "Gatunki";
            // 
            // txtFlowerName
            // 
            this.txtFlowerName.Location = new System.Drawing.Point(125, 12);
            this.txtFlowerName.Name = "txtFlowerName";
            this.txtFlowerName.Size = new System.Drawing.Size(151, 27);
            this.txtFlowerName.TabIndex = 10;
            // 
            // lblTrait
            // 
            this.lblTrait.AutoSize = true;
            this.lblTrait.Location = new System.Drawing.Point(14, 185);
            this.lblTrait.Name = "lblTrait";
            this.lblTrait.Size = new System.Drawing.Size(48, 20);
            this.lblTrait.TabIndex = 11;
            this.lblTrait.Text = "Cechy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTrait);
            this.Controls.Add(this.txtFlowerName);
            this.Controls.Add(this.cbTrait);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.cbSpecie);
            this.Controls.Add(this.lblRequirement);
            this.Controls.Add(this.cbRequirement);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.lblFlowerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlowerName;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox cbRequirement;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbSpecie;
        private System.Windows.Forms.Label lblRequirement;
        private System.Windows.Forms.ComboBox cbTrait;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.TextBox txtFlowerName;
        private System.Windows.Forms.Label lblTrait;
        private System.Windows.Forms.Button button1;
    }
}

