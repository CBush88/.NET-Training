namespace CollectionsForms2
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
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_dictionary = new System.Windows.Forms.Button();
            this.btn_hashset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(12, 37);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 0;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_dictionary
            // 
            this.btn_dictionary.Location = new System.Drawing.Point(93, 37);
            this.btn_dictionary.Name = "btn_dictionary";
            this.btn_dictionary.Size = new System.Drawing.Size(75, 23);
            this.btn_dictionary.TabIndex = 1;
            this.btn_dictionary.Text = "Dictionary";
            this.btn_dictionary.UseVisualStyleBackColor = true;
            this.btn_dictionary.Click += new System.EventHandler(this.btn_dictionary_Click);
            // 
            // btn_hashset
            // 
            this.btn_hashset.Location = new System.Drawing.Point(174, 37);
            this.btn_hashset.Name = "btn_hashset";
            this.btn_hashset.Size = new System.Drawing.Size(75, 23);
            this.btn_hashset.TabIndex = 2;
            this.btn_hashset.Text = "Hash Set";
            this.btn_hashset.UseVisualStyleBackColor = true;
            this.btn_hashset.Click += new System.EventHandler(this.btn_hashset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 78);
            this.Controls.Add(this.btn_hashset);
            this.Controls.Add(this.btn_dictionary);
            this.Controls.Add(this.btn_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_dictionary;
        private System.Windows.Forms.Button btn_hashset;
    }
}

