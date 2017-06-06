namespace The_program_for_work_with_orders
{
    partial class Manager
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
            this.ordersDataSet = new The_program_for_work_with_orders.OrdersDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new The_program_for_work_with_orders.OrdersDataSetTableAdapters.OrdersTableAdapter();
            this.иденНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серийныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСтоимостьЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пройденаЛиПроверкаDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.наличиеТовараDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иденНомерDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.серийныйНомерDataGridViewTextBoxColumn,
            this.датаИВремяDataGridViewTextBoxColumn,
            this.общаяСтоимостьЗаказаDataGridViewTextBoxColumn,
            this.пройденаЛиПроверкаDataGridViewCheckBoxColumn,
            this.наличиеТовараDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(942, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "OrdersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // иденНомерDataGridViewTextBoxColumn
            // 
            this.иденНомерDataGridViewTextBoxColumn.DataPropertyName = "Иден номер";
            this.иденНомерDataGridViewTextBoxColumn.HeaderText = "Иден номер";
            this.иденНомерDataGridViewTextBoxColumn.Name = "иденНомерDataGridViewTextBoxColumn";
            this.иденНомерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // серийныйНомерDataGridViewTextBoxColumn
            // 
            this.серийныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.Name = "серийныйНомерDataGridViewTextBoxColumn";
            this.серийныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИВремяDataGridViewTextBoxColumn
            // 
            this.датаИВремяDataGridViewTextBoxColumn.DataPropertyName = "Дата и время";
            this.датаИВремяDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.датаИВремяDataGridViewTextBoxColumn.Name = "датаИВремяDataGridViewTextBoxColumn";
            this.датаИВремяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // общаяСтоимостьЗаказаDataGridViewTextBoxColumn
            // 
            this.общаяСтоимостьЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Общая стоимость заказа";
            this.общаяСтоимостьЗаказаDataGridViewTextBoxColumn.HeaderText = "Общая стоимость заказа";
            this.общаяСтоимостьЗаказаDataGridViewTextBoxColumn.Name = "общаяСтоимостьЗаказаDataGridViewTextBoxColumn";
            this.общаяСтоимостьЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пройденаЛиПроверкаDataGridViewCheckBoxColumn
            // 
            this.пройденаЛиПроверкаDataGridViewCheckBoxColumn.DataPropertyName = "Пройдена ли проверка";
            this.пройденаЛиПроверкаDataGridViewCheckBoxColumn.HeaderText = "Пройдена ли проверка";
            this.пройденаЛиПроверкаDataGridViewCheckBoxColumn.Name = "пройденаЛиПроверкаDataGridViewCheckBoxColumn";
            this.пройденаЛиПроверкаDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // наличиеТовараDataGridViewCheckBoxColumn
            // 
            this.наличиеТовараDataGridViewCheckBoxColumn.DataPropertyName = "Наличие товара";
            this.наличиеТовараDataGridViewCheckBoxColumn.HeaderText = "Наличие товара";
            this.наличиеТовараDataGridViewCheckBoxColumn.Name = "наличиеТовараDataGridViewCheckBoxColumn";
            this.наличиеТовараDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OrdersDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иденНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСтоимостьЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn пройденаЛиПроверкаDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеТовараDataGridViewCheckBoxColumn;
    }
}