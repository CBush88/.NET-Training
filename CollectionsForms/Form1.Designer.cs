namespace CollectionsForms
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
            this.btn_arraylist = new System.Windows.Forms.Button();
            this.btn_stack = new System.Windows.Forms.Button();
            this.btn_queue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_arraylist
            // 
            this.btn_arraylist.Location = new System.Drawing.Point(21, 37);
            this.btn_arraylist.Name = "btn_arraylist";
            this.btn_arraylist.Size = new System.Drawing.Size(75, 23);
            this.btn_arraylist.TabIndex = 0;
            this.btn_arraylist.Text = "ArrayList";
            this.btn_arraylist.UseVisualStyleBackColor = true;
            this.btn_arraylist.Click += new System.EventHandler(this.btn_arraylist_Click);
            // 
            // btn_stack
            // 
            this.btn_stack.Location = new System.Drawing.Point(113, 37);
            this.btn_stack.Name = "btn_stack";
            this.btn_stack.Size = new System.Drawing.Size(75, 23);
            this.btn_stack.TabIndex = 1;
            this.btn_stack.Text = "Stack";
            this.btn_stack.UseVisualStyleBackColor = true;
            this.btn_stack.Click += new System.EventHandler(this.btn_stack_Click);
            // 
            // btn_queue
            // 
            this.btn_queue.Location = new System.Drawing.Point(205, 37);
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.Size = new System.Drawing.Size(75, 23);
            this.btn_queue.TabIndex = 2;
            this.btn_queue.Text = "Queue";
            this.btn_queue.UseVisualStyleBackColor = true;
            this.btn_queue.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 141);
            this.Controls.Add(this.btn_queue);
            this.Controls.Add(this.btn_stack);
            this.Controls.Add(this.btn_arraylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_arraylist;
        private System.Windows.Forms.Button btn_stack;
        private System.Windows.Forms.Button btn_queue;
    }
}

