namespace BaiTap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Tên", 150);
            listView1.Columns.Add("MSSV", 100);
            listView1.Columns.Add("Lớp", 100);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Ten.Text) && !string.IsNullOrEmpty(txt_MSSV.Text) && !string.IsNullOrEmpty(txt_Lop.Text))
            {
                ListViewItem item = new ListViewItem(txt_Ten.Text);
                item.SubItems.Add(txt_MSSV.Text);
                item.SubItems.Add(txt_Lop.Text);
                listView1.Items.Add(item);

                txt_Ten.Clear();
                txt_MSSV.Clear();
                txt_Lop.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                item.Text = txt_Ten.Text;
                item.SubItems[1].Text = txt_MSSV.Text;
                item.SubItems[2].Text = txt_Lop.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txt_Ten.Text = item.Text;
                txt_MSSV.Text = item.SubItems[1].Text;
                txt_Lop.Text = item.SubItems[2].Text;
            }
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_MSSV_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_Lop_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
