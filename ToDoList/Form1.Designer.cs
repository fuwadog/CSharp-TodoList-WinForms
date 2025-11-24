namespace ToDoList
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTask = new TextBox();
            label1 = new Label();
            add = new Button();
            listBox1 = new ListBox();
            delete = new Button();
            complete = new Button();
            save = new Button();
            clear = new Button();
            LoadL = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.BorderStyle = BorderStyle.FixedSingle;
            txtTask.Font = new Font("Yu Gothic", 12F);
            txtTask.Location = new Point(52, 62);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(269, 33);
            txtTask.TabIndex = 0;
            txtTask.TextChanged += txtTask_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 40);
            label1.TabIndex = 1;
            label1.Text = "To-Do List";
            // 
            // add
            // 
            add.BackColor = SystemColors.ButtonFace;
            add.FlatAppearance.BorderColor = Color.Gray;
            add.FlatAppearance.BorderSize = 2;
            add.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold);
            add.Location = new Point(327, 62);
            add.Name = "add";
            add.Size = new Size(78, 28);
            add.TabIndex = 2;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Yu Gothic", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(52, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(353, 191);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.ButtonFace;
            delete.FlatAppearance.BorderColor = Color.Gray;
            delete.FlatAppearance.BorderSize = 2;
            delete.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold);
            delete.Location = new Point(52, 314);
            delete.Name = "delete";
            delete.Size = new Size(78, 28);
            delete.TabIndex = 4;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // complete
            // 
            complete.BackColor = SystemColors.ButtonFace;
            complete.FlatAppearance.BorderColor = Color.Gray;
            complete.FlatAppearance.BorderSize = 2;
            complete.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold);
            complete.Location = new Point(136, 314);
            complete.Name = "complete";
            complete.Size = new Size(78, 28);
            complete.TabIndex = 5;
            complete.Text = "Complete";
            complete.UseVisualStyleBackColor = false;
            complete.Click += complete_Click;
            // 
            // save
            // 
            save.BackColor = SystemColors.ButtonFace;
            save.FlatAppearance.BorderColor = Color.Gray;
            save.FlatAppearance.BorderSize = 2;
            save.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold);
            save.Location = new Point(243, 314);
            save.Name = "save";
            save.Size = new Size(78, 28);
            save.TabIndex = 6;
            save.Text = "Save List";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ButtonFace;
            clear.FlatAppearance.BorderColor = Color.Gray;
            clear.FlatAppearance.BorderSize = 2;
            clear.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold);
            clear.Location = new Point(327, 314);
            clear.Name = "clear";
            clear.Size = new Size(78, 28);
            clear.TabIndex = 7;
            clear.Text = "Clear All";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // LoadL
            // 
            LoadL.BackColor = SystemColors.ButtonFace;
            LoadL.FlatAppearance.BorderColor = Color.Gray;
            LoadL.FlatAppearance.BorderSize = 2;
            LoadL.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold);
            LoadL.Location = new Point(243, 348);
            LoadL.Name = "LoadL";
            LoadL.Size = new Size(78, 28);
            LoadL.TabIndex = 8;
            LoadL.Text = "Load List";
            LoadL.UseVisualStyleBackColor = false;
            LoadL.Click += LoadL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(466, 400);
            Controls.Add(LoadL);
            Controls.Add(clear);
            Controls.Add(save);
            Controls.Add(complete);
            Controls.Add(delete);
            Controls.Add(listBox1);
            Controls.Add(add);
            Controls.Add(label1);
            Controls.Add(txtTask);
            Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Label label1;
        private Button add;
        private ListBox listBox1;
        private Button delete;
        private Button complete;
        private Button save;
        private Button clear;
        private Button LoadL;
    }
}
