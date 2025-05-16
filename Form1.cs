namespace TestApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "Yes";
            btn.Left = 10;
            this.Controls.Add(btn);
            btn.Top = 10;
            btn.Click += OnButtonClick;
            btn.MouseEnter += Btn_MouseEnter;
        }

        private void Btn_MouseEnter(object? sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void OnButtonClick(object? sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void test()
        {
            MessageBox.Show("你好呀");
        }
    }
}
