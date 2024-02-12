namespace arbol
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
            TreeNode treeNode1 = new TreeNode("Suma");
            TreeNode treeNode2 = new TreeNode("Resta");
            TreeNode treeNode3 = new TreeNode("Division");
            TreeNode treeNode4 = new TreeNode("Multiplicacion");
            TreeNode treeNode5 = new TreeNode("Operacion", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            treeView1 = new TreeView();
            MSKn1 = new MaskedTextBox();
            MSKn2 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            BTNcal = new Button();
            BTNsal = new Button();
            BTNlimp = new Button();
            label3 = new Label();
            TXBresul = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.Silver;
            treeView1.Location = new Point(36, 38);
            treeView1.Name = "treeView1";
            treeNode1.BackColor = Color.FromArgb(192, 255, 255);
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Suma";
            treeNode2.BackColor = Color.FromArgb(255, 255, 192);
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Resta";
            treeNode3.BackColor = Color.MediumAquamarine;
            treeNode3.Name = "Nodo3";
            treeNode3.Text = "Division";
            treeNode4.BackColor = Color.FromArgb(255, 192, 255);
            treeNode4.Name = "Nodo4";
            treeNode4.Text = "Multiplicacion";
            treeNode5.BackColor = Color.FromArgb(255, 224, 192);
            treeNode5.ForeColor = Color.Black;
            treeNode5.Name = "Nodo0";
            treeNode5.Text = "Operacion";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode5 });
            treeView1.Size = new Size(173, 121);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // MSKn1
            // 
            MSKn1.BackColor = Color.Gainsboro;
            MSKn1.Location = new Point(272, 132);
            MSKn1.Mask = "99";
            MSKn1.Name = "MSKn1";
            MSKn1.Size = new Size(125, 27);
            MSKn1.TabIndex = 1;
            MSKn1.ValidatingType = typeof(int);
            // 
            // MSKn2
            // 
            MSKn2.BackColor = Color.Gainsboro;
            MSKn2.Location = new Point(272, 243);
            MSKn2.Mask = "99";
            MSKn2.Name = "MSKn2";
            MSKn2.Size = new Size(125, 27);
            MSKn2.TabIndex = 2;
            MSKn2.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 65);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 176);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Nota 2";
            // 
            // BTNcal
            // 
            BTNcal.BackColor = Color.Bisque;
            BTNcal.Location = new Point(460, 243);
            BTNcal.Name = "BTNcal";
            BTNcal.Size = new Size(94, 29);
            BTNcal.TabIndex = 5;
            BTNcal.Text = "Calcular";
            BTNcal.UseVisualStyleBackColor = false;
            BTNcal.Click += BTNcal_Click;
            // 
            // BTNsal
            // 
            BTNsal.BackColor = Color.Bisque;
            BTNsal.Location = new Point(621, 243);
            BTNsal.Name = "BTNsal";
            BTNsal.Size = new Size(94, 29);
            BTNsal.TabIndex = 7;
            BTNsal.Text = "Salir";
            BTNsal.UseVisualStyleBackColor = false;
            BTNsal.Click += BTNsal_Click;
            // 
            // BTNlimp
            // 
            BTNlimp.BackColor = Color.Bisque;
            BTNlimp.Location = new Point(535, 176);
            BTNlimp.Name = "BTNlimp";
            BTNlimp.Size = new Size(94, 29);
            BTNlimp.TabIndex = 8;
            BTNlimp.Text = "Limpiar";
            BTNlimp.UseVisualStyleBackColor = false;
            BTNlimp.Click += BTNlimp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 70);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 9;
            label3.Text = "Resultado";
            // 
            // TXBresul
            // 
            TXBresul.BackColor = Color.LightGray;
            TXBresul.Location = new Point(518, 132);
            TXBresul.Name = "TXBresul";
            TXBresul.Size = new Size(125, 27);
            TXBresul.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(36, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 94);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(45, 45);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 0;
            label4.Text = "Ninguno";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 296);
            Controls.Add(groupBox1);
            Controls.Add(TXBresul);
            Controls.Add(label3);
            Controls.Add(BTNlimp);
            Controls.Add(BTNsal);
            Controls.Add(BTNcal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MSKn2);
            Controls.Add(MSKn1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private MaskedTextBox MSKn1;
        private MaskedTextBox MSKn2;
        private Label label1;
        private Label label2;
        private Button BTNcal;
        private Button BTNsal;
        private Button BTNlimp;
        private Label label3;
        private TextBox TXBresul;
        private GroupBox groupBox1;
        private Label label4;
    }
}
