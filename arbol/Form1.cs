namespace arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXBresul.Enabled = false;
        }

        private void BTNcal_Click(object sender, EventArgs e)
        {
            int n, m, tt;
            try
            {
                n = Convert.ToInt32(MSKn1.Text);
                m = Convert.ToInt32(MSKn2.Text);

                if (treeView1.SelectedNode.Text.Equals("Suma"))
                {
                    tt = n + m;
                    TXBresul.Text = tt.ToString();
                }
                if (treeView1.SelectedNode.Text.Equals("Resta"))
                {
                    tt = n - m;
                    TXBresul.Text = tt.ToString();
                }
                if (treeView1.SelectedNode.Text.Equals("Division"))
                {
                    tt = n / m;
                    TXBresul.Text = tt.ToString();
                }
                if (treeView1.SelectedNode.Text.Equals("Multiplicacion"))
                {
                    tt = n * m;
                    TXBresul.Text = tt.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede estar en blanco");
            }
        }

        private void BTNlimp_Click(object sender, EventArgs e)
        {
            TXBresul.Text = "";
            MSKn1.Text = "";
            MSKn2.Text = "";
            label4.Text = "Ninguno"; 
        }

        private void BTNsal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Suma"))
            {
                label4.Text = "Suma";
            }
            if (treeView1.SelectedNode.Text.Equals("Resta"))
            {
                label4.Text = "Resta";
            }
            if (treeView1.SelectedNode.Text.Equals("Division"))
            {
                label4.Text = "Division";
            }
            if (treeView1.SelectedNode.Text.Equals("Multiplicacion"))
            {
                label4.Text = "Multiplicacion";
            }
        }
    }
}
