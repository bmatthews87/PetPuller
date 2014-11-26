namespace Pet_Puller
{
    partial class Form1
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
            this.PullDataBtn = new System.Windows.Forms.Button();
            this.CharacterTextBox = new System.Windows.Forms.TextBox();
            this.RealmTextBox = new System.Windows.Forms.TextBox();
            this.CharacterLbl = new System.Windows.Forms.Label();
            this.RealmLbl = new System.Windows.Forms.Label();
            this.PetListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PullDataBtn
            // 
            this.PullDataBtn.Location = new System.Drawing.Point(97, 83);
            this.PullDataBtn.Name = "PullDataBtn";
            this.PullDataBtn.Size = new System.Drawing.Size(100, 23);
            this.PullDataBtn.TabIndex = 0;
            this.PullDataBtn.Text = "Pull Data";
            this.PullDataBtn.UseVisualStyleBackColor = true;
            this.PullDataBtn.Click += new System.EventHandler(this.PullDataBtn_Click);
            // 
            // CharacterTextBox
            // 
            this.CharacterTextBox.Location = new System.Drawing.Point(97, 13);
            this.CharacterTextBox.Name = "CharacterTextBox";
            this.CharacterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CharacterTextBox.TabIndex = 1;
            // 
            // RealmTextBox
            // 
            this.RealmTextBox.Location = new System.Drawing.Point(97, 39);
            this.RealmTextBox.Name = "RealmTextBox";
            this.RealmTextBox.Size = new System.Drawing.Size(100, 20);
            this.RealmTextBox.TabIndex = 2;
            // 
            // CharacterLbl
            // 
            this.CharacterLbl.AutoSize = true;
            this.CharacterLbl.Location = new System.Drawing.Point(13, 19);
            this.CharacterLbl.Name = "CharacterLbl";
            this.CharacterLbl.Size = new System.Drawing.Size(53, 13);
            this.CharacterLbl.TabIndex = 3;
            this.CharacterLbl.Text = "Character";
            // 
            // RealmLbl
            // 
            this.RealmLbl.AutoSize = true;
            this.RealmLbl.Location = new System.Drawing.Point(13, 46);
            this.RealmLbl.Name = "RealmLbl";
            this.RealmLbl.Size = new System.Drawing.Size(37, 13);
            this.RealmLbl.TabIndex = 4;
            this.RealmLbl.Text = "Realm";
            // 
            // PetListBox
            // 
            this.PetListBox.FormattingEnabled = true;
            this.PetListBox.Location = new System.Drawing.Point(286, 8);
            this.PetListBox.Name = "PetListBox";
            this.PetListBox.Size = new System.Drawing.Size(258, 238);
            this.PetListBox.TabIndex = 5;
            this.PetListBox.SelectedIndexChanged += new System.EventHandler(this.PetListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.PetListBox);
            this.Controls.Add(this.RealmLbl);
            this.Controls.Add(this.CharacterLbl);
            this.Controls.Add(this.RealmTextBox);
            this.Controls.Add(this.CharacterTextBox);
            this.Controls.Add(this.PullDataBtn);
            this.Name = "Form1";
            this.Text = "Pet Puller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PullDataBtn;
        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.TextBox RealmTextBox;
        private System.Windows.Forms.Label CharacterLbl;
        private System.Windows.Forms.Label RealmLbl;
        private System.Windows.Forms.ListBox PetListBox;
    }
}

