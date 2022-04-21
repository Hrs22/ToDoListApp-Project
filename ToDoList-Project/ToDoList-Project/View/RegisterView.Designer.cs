namespace ToDoList_Project.View
{
    partial class RegisterView
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.registerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerDBDataSet = new ToDoList_Project.RegisterDBDataSet();
            this.registerTableTableAdapter = new ToDoList_Project.RegisterDBDataSetTableAdapters.RegisterTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(157, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 47);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Register";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 104);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(205, 30);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter your username";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(249, 104);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(200, 20);
            this.txtbox1.TabIndex = 2;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(249, 190);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.PasswordChar = '*';
            this.txtbox2.Size = new System.Drawing.Size(200, 20);
            this.txtbox2.TabIndex = 4;
            this.txtbox2.TextChanged += new System.EventHandler(this.txtbox2_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(12, 180);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(201, 30);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Enter your password";
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(249, 275);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(200, 20);
            this.txtbox3.TabIndex = 6;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(12, 275);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(164, 30);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Enter your email";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(17, 356);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(140, 52);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "Register now!";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(239, 350);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(210, 64);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "Have account? Login now!";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // registerTableBindingSource
            // 
            this.registerTableBindingSource.DataMember = "RegisterTable";
            this.registerTableBindingSource.DataSource = this.registerDBDataSet;
            // 
            // registerDBDataSet
            // 
            this.registerDBDataSet.DataSetName = "RegisterDBDataSet";
            this.registerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerTableTableAdapter
            // 
            this.registerTableTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 464);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private RegisterDBDataSet registerDBDataSet;
        private System.Windows.Forms.BindingSource registerTableBindingSource;
        private RegisterDBDataSetTableAdapters.RegisterTableTableAdapter registerTableTableAdapter;
    }
}