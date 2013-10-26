namespace PLSSequence
{
    partial class Input
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
            this.InputSequence = new System.Windows.Forms.TextBox();
            this.SequenceAddress = new System.Windows.Forms.TextBox();
            this.ActivityAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.HighlightSeq = new System.Windows.Forms.Button();
            this.HighlightAct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InputSequence
            // 
            this.InputSequence.Location = new System.Drawing.Point(154, 33);
            this.InputSequence.Name = "InputSequence";
            this.InputSequence.Size = new System.Drawing.Size(368, 20);
            this.InputSequence.TabIndex = 0;
            // 
            // SequenceAddress
            // 
            this.SequenceAddress.Location = new System.Drawing.Point(154, 59);
            this.SequenceAddress.Name = "SequenceAddress";
            this.SequenceAddress.Size = new System.Drawing.Size(368, 20);
            this.SequenceAddress.TabIndex = 1;
            this.SequenceAddress.TextChanged += new System.EventHandler(this.SequenceAddress_TextChanged);
            // 
            // ActivityAddress
            // 
            this.ActivityAddress.Location = new System.Drawing.Point(154, 85);
            this.ActivityAddress.Name = "ActivityAddress";
            this.ActivityAddress.Size = new System.Drawing.Size(368, 20);
            this.ActivityAddress.TabIndex = 2;
            this.ActivityAddress.TextChanged += new System.EventHandler(this.ActivityAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Sequence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Mutant Sequences";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Activities";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(205, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Use Amino Acid Families";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // HighlightSeq
            // 
            this.HighlightSeq.Location = new System.Drawing.Point(500, 59);
            this.HighlightSeq.Name = "HighlightSeq";
            this.HighlightSeq.Size = new System.Drawing.Size(22, 20);
            this.HighlightSeq.TabIndex = 7;
            this.HighlightSeq.Text = "..";
            this.HighlightSeq.UseVisualStyleBackColor = true;
            this.HighlightSeq.Click += new System.EventHandler(this.HighlightSeq_Click);
            // 
            // HighlightAct
            // 
            this.HighlightAct.Location = new System.Drawing.Point(500, 84);
            this.HighlightAct.Name = "HighlightAct";
            this.HighlightAct.Size = new System.Drawing.Size(22, 20);
            this.HighlightAct.TabIndex = 8;
            this.HighlightAct.Text = "..";
            this.HighlightAct.UseVisualStyleBackColor = true;
            this.HighlightAct.Click += new System.EventHandler(this.HighlightAct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(135, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "is pIC50";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 153);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HighlightAct);
            this.Controls.Add(this.HighlightSeq);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActivityAddress);
            this.Controls.Add(this.SequenceAddress);
            this.Controls.Add(this.InputSequence);
            this.Name = "Input";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox InputSequence;
        private System.Windows.Forms.TextBox SequenceAddress;
        private System.Windows.Forms.TextBox ActivityAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button HighlightSeq;
        private System.Windows.Forms.Button HighlightAct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox checkBox2;
    }
}