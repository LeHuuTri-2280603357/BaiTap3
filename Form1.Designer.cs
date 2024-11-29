namespace BaiTap3
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
            Them = new Button();
            Xoa = new Button();
            Sua = new Button();
            listView1 = new ListView();
            Ten = new ColumnHeader();
            MSSV = new ColumnHeader();
            Lớp = new ColumnHeader();
            txt_Ten = new TextBox();
            txt_Lop = new TextBox();
            txt_MSSV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Them
            // 
            Them.Location = new Point(323, 259);
            Them.Name = "Them";
            Them.Size = new Size(94, 29);
            Them.TabIndex = 0;
            Them.Text = "Thêm";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(433, 259);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(94, 29);
            Xoa.TabIndex = 1;
            Xoa.Text = "Xoá";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Sua
            // 
            Sua.Location = new Point(547, 259);
            Sua.Name = "Sua";
            Sua.Size = new Size(94, 29);
            Sua.TabIndex = 2;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            Sua.Click += Sua_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Ten, MSSV, Lớp });
            listView1.Location = new Point(110, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(182, 248);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Ten
            // 
            Ten.Text = "Tên";
            // 
            // MSSV
            // 
            MSSV.Text = "MSSV";
            // 
            // Lớp
            // 
            Lớp.Text = "Lop";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(477, 83);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(125, 27);
            txt_Ten.TabIndex = 4;
            txt_Ten.TextChanged += txt_Ten_TextChanged;
            // 
            // txt_Lop
            // 
            txt_Lop.Location = new Point(477, 201);
            txt_Lop.Name = "txt_Lop";
            txt_Lop.Size = new Size(125, 27);
            txt_Lop.TabIndex = 5;
            txt_Lop.TextChanged += txt_Lop_TextChanged;
            // 
            // txt_MSSV
            // 
            txt_MSSV.Location = new Point(477, 141);
            txt_MSSV.Name = "txt_MSSV";
            txt_MSSV.Size = new Size(125, 27);
            txt_MSSV.TabIndex = 6;
            txt_MSSV.TextChanged += txt_MSSV_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 86);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 201);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 8;
            label2.Text = "Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 9;
            label3.Text = "MSSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_MSSV);
            Controls.Add(txt_Lop);
            Controls.Add(txt_Ten);
            Controls.Add(listView1);
            Controls.Add(Sua);
            Controls.Add(Xoa);
            Controls.Add(Them);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Them;
        private Button Xoa;
        private Button Sua;
        private ListView listView1;
        public ColumnHeader Ten;
        public ColumnHeader MSSV;
        public ColumnHeader Lớp;
        private TextBox txt_Ten;
        private TextBox txt_Lop;
        private TextBox txt_MSSV;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
