namespace to_do_list
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_completed = new System.Windows.Forms.Button();
            this.btn_all_tasks = new System.Windows.Forms.Button();
            this.input_add = new System.Windows.Forms.TextBox();
            this.btn_add_validate = new System.Windows.Forms.Button();
            this.gp_add_task = new System.Windows.Forms.GroupBox();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.checkedList2 = new System.Windows.Forms.CheckedListBox();
            this.gp_add_task.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("American Typewriter", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(227, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Management ";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 119);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(196, 42);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Task";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_completed
            // 
            this.btn_completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_completed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_completed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_completed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_completed.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_completed.ForeColor = System.Drawing.Color.White;
            this.btn_completed.Location = new System.Drawing.Point(12, 283);
            this.btn_completed.Name = "btn_completed";
            this.btn_completed.Size = new System.Drawing.Size(196, 42);
            this.btn_completed.TabIndex = 3;
            this.btn_completed.Text = "Completed Tasks";
            this.btn_completed.UseVisualStyleBackColor = false;
            this.btn_completed.Click += new System.EventHandler(this.btn_completed_Click);
            // 
            // btn_all_tasks
            // 
            this.btn_all_tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_all_tasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_all_tasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_all_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all_tasks.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_all_tasks.ForeColor = System.Drawing.Color.White;
            this.btn_all_tasks.Location = new System.Drawing.Point(12, 201);
            this.btn_all_tasks.Name = "btn_all_tasks";
            this.btn_all_tasks.Size = new System.Drawing.Size(196, 42);
            this.btn_all_tasks.TabIndex = 4;
            this.btn_all_tasks.Text = "Show all tasks";
            this.btn_all_tasks.UseVisualStyleBackColor = false;
            this.btn_all_tasks.Click += new System.EventHandler(this.btn_all_tasks_Click);
            // 
            // input_add
            // 
            this.input_add.Font = new System.Drawing.Font("American Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.input_add.Location = new System.Drawing.Point(9, 31);
            this.input_add.Multiline = true;
            this.input_add.Name = "input_add";
            this.input_add.Size = new System.Drawing.Size(415, 42);
            this.input_add.TabIndex = 5;
            // 
            // btn_add_validate
            // 
            this.btn_add_validate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_validate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_add_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_validate.Font = new System.Drawing.Font("American Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_add_validate.ForeColor = System.Drawing.Color.White;
            this.btn_add_validate.Location = new System.Drawing.Point(431, 31);
            this.btn_add_validate.Name = "btn_add_validate";
            this.btn_add_validate.Size = new System.Drawing.Size(143, 42);
            this.btn_add_validate.TabIndex = 6;
            this.btn_add_validate.Text = "Add ";
            this.btn_add_validate.UseVisualStyleBackColor = false;
            this.btn_add_validate.Click += new System.EventHandler(this.btn_add_validate_Click);
            // 
            // gp_add_task
            // 
            this.gp_add_task.Controls.Add(this.btn_add_validate);
            this.gp_add_task.Controls.Add(this.input_add);
            this.gp_add_task.Font = new System.Drawing.Font("American Typewriter", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gp_add_task.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gp_add_task.Location = new System.Drawing.Point(214, 119);
            this.gp_add_task.Name = "gp_add_task";
            this.gp_add_task.Size = new System.Drawing.Size(583, 294);
            this.gp_add_task.TabIndex = 7;
            this.gp_add_task.TabStop = false;
            this.gp_add_task.Text = "Add Tasks";
            // 
            // checkedList
            // 
            this.checkedList.Font = new System.Drawing.Font("American Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkedList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(250, 94);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(538, 340);
            this.checkedList.TabIndex = 7;
            this.checkedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // checkedList2
            // 
            this.checkedList2.Font = new System.Drawing.Font("American Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkedList2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedList2.FormattingEnabled = true;
            this.checkedList2.Location = new System.Drawing.Point(251, 94);
            this.checkedList2.Name = "checkedList2";
            this.checkedList2.Size = new System.Drawing.Size(538, 340);
            this.checkedList2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedList2);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.gp_add_task);
            this.Controls.Add(this.btn_all_tasks);
            this.Controls.Add(this.btn_completed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp_add_task.ResumeLayout(false);
            this.gp_add_task.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_completed;
        private System.Windows.Forms.Button btn_all_tasks;
        private System.Windows.Forms.TextBox input_add;
        private System.Windows.Forms.Button btn_add_validate;
        private System.Windows.Forms.GroupBox gp_add_task;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.CheckedListBox checkedList2;
    }
}

