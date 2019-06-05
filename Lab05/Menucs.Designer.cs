namespace Lab05
{
    partial class Menucs
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
            this.quizmathBtn = new System.Windows.Forms.Button();
            this.matchgamebtn = new System.Windows.Forms.Button();
            this.spinegameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quizmathBtn
            // 
            this.quizmathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizmathBtn.Location = new System.Drawing.Point(63, 149);
            this.quizmathBtn.Name = "quizmathBtn";
            this.quizmathBtn.Size = new System.Drawing.Size(283, 75);
            this.quizmathBtn.TabIndex = 0;
            this.quizmathBtn.Text = "Math Quiz Gane";
            this.quizmathBtn.UseVisualStyleBackColor = true;
            this.quizmathBtn.Click += new System.EventHandler(this.quizmathBtn_Click);
            // 
            // matchgamebtn
            // 
            this.matchgamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchgamebtn.Location = new System.Drawing.Point(192, 68);
            this.matchgamebtn.Name = "matchgamebtn";
            this.matchgamebtn.Size = new System.Drawing.Size(154, 75);
            this.matchgamebtn.TabIndex = 1;
            this.matchgamebtn.Text = "Match Game";
            this.matchgamebtn.UseVisualStyleBackColor = true;
            this.matchgamebtn.Click += new System.EventHandler(this.matchgamebtn_Click);
            // 
            // spinegameBtn
            // 
            this.spinegameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinegameBtn.Location = new System.Drawing.Point(63, 68);
            this.spinegameBtn.Name = "spinegameBtn";
            this.spinegameBtn.Size = new System.Drawing.Size(111, 75);
            this.spinegameBtn.TabIndex = 2;
            this.spinegameBtn.Text = "Spine Game";
            this.spinegameBtn.UseVisualStyleBackColor = true;
            this.spinegameBtn.Click += new System.EventHandler(this.spinegameBtn_Click);
            // 
            // Menucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 273);
            this.Controls.Add(this.spinegameBtn);
            this.Controls.Add(this.matchgamebtn);
            this.Controls.Add(this.quizmathBtn);
            this.Name = "Menucs";
            this.Text = "Menucs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quizmathBtn;
        private System.Windows.Forms.Button matchgamebtn;
        private System.Windows.Forms.Button spinegameBtn;
    }
}