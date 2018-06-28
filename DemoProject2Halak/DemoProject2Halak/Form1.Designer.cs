namespace DemoProject2Halak
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
            this.txt_ShowData = new System.Windows.Forms.TextBox();
            this.btn_SortQuantity = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.CodeDescendingList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ShowData
            // 
            this.txt_ShowData.Location = new System.Drawing.Point(58, 59);
            this.txt_ShowData.Multiline = true;
            this.txt_ShowData.Name = "txt_ShowData";
            this.txt_ShowData.Size = new System.Drawing.Size(514, 272);
            this.txt_ShowData.TabIndex = 0;
            // 
            // btn_SortQuantity
            // 
            this.btn_SortQuantity.Location = new System.Drawing.Point(629, 59);
            this.btn_SortQuantity.Name = "btn_SortQuantity";
            this.btn_SortQuantity.Size = new System.Drawing.Size(106, 42);
            this.btn_SortQuantity.TabIndex = 1;
            this.btn_SortQuantity.Text = "Sort Meat products";
            this.btn_SortQuantity.UseVisualStyleBackColor = true;
            this.btn_SortQuantity.Click += new System.EventHandler(this.btn_SortQuantity_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(629, 168);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(105, 41);
            this.btn_Sort.TabIndex = 2;
            this.btn_Sort.Text = "Sort Milk products";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // CodeDescendingList
            // 
            this.CodeDescendingList.Location = new System.Drawing.Point(631, 294);
            this.CodeDescendingList.Name = "CodeDescendingList";
            this.CodeDescendingList.Size = new System.Drawing.Size(103, 37);
            this.CodeDescendingList.TabIndex = 3;
            this.CodeDescendingList.Text = "Sort All products by ID";
            this.CodeDescendingList.UseVisualStyleBackColor = true;
            this.CodeDescendingList.Click += new System.EventHandler(this.CodeDescendingList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeDescendingList);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_SortQuantity);
            this.Controls.Add(this.txt_ShowData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ShowData;
        private System.Windows.Forms.Button btn_SortQuantity;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button CodeDescendingList;
        private System.Windows.Forms.Label label1;
    }
}

