namespace Database
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.peopleDataSet = new Database.peopleDataSet();
            this.peopleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Database.peopleDataSetTableAdapters.bookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(12, 12);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(109, 29);
            this.bntAdd.TabIndex = 1;
            this.bntAdd.Text = "Добавить";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Location = new System.Drawing.Point(127, 12);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(109, 29);
            this.bntEdit.TabIndex = 2;
            this.bntEdit.Text = "Изменить";
            this.bntEdit.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(242, 12);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(109, 29);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Удалить";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // peopleDataSet
            // 
            this.peopleDataSet.DataSetName = "peopleDataSet";
            this.peopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleDataSetBindingSource
            // 
            this.peopleDataSetBindingSource.DataSource = this.peopleDataSet;
            this.peopleDataSetBindingSource.Position = 0;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.peopleDataSetBindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.BindingSource peopleDataSetBindingSource;
        private peopleDataSet peopleDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private peopleDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

