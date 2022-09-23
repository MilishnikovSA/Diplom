
namespace АИС_отдела_редких_книг.Forms
{
    partial class КНИГА
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.authorDataGridView = new System.Windows.Forms.DataGridView();
            this.idknigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idizdatelstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtypeizdaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaglavieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarniinumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolstrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbkindexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubkindexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalichieDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.knigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new АИС_отдела_редких_книг.DataSet();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.knigaTableAdapter = new АИС_отдела_редких_книг.DataSetTableAdapters.KnigaTableAdapter();
            this.tableAdapterManager = new АИС_отдела_редких_книг.DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(18, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 205);
            this.panel1.TabIndex = 39;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 110);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(137, 17);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ПО НОМЕРУ АВТОРА\r\n";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "СОРТИРОВКА:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 30);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ПО НОМЕРУ\r\nИЗДАТЕЛЬСТВА\r\n";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ПО НОМЕРУ ВЫДАЧИ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ПО ЗАГЛАВИЮ\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // authorDataGridView
            // 
            this.authorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorDataGridView.AutoGenerateColumns = false;
            this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idknigiDataGridViewTextBoxColumn,
            this.idizdatelstvaDataGridViewTextBoxColumn,
            this.idtypeizdaniaDataGridViewTextBoxColumn,
            this.idauthorDataGridViewTextBoxColumn,
            this.zaglavieDataGridViewTextBoxColumn,
            this.inventarniinumberDataGridViewTextBoxColumn,
            this.kolstrDataGridViewTextBoxColumn,
            this.bbkindexDataGridViewTextBoxColumn,
            this.ubkindexDataGridViewTextBoxColumn,
            this.nalichieDataGridViewCheckBoxColumn});
            this.authorDataGridView.DataSource = this.knigaBindingSource;
            this.authorDataGridView.Location = new System.Drawing.Point(194, 12);
            this.authorDataGridView.Name = "authorDataGridView";
            this.authorDataGridView.Size = new System.Drawing.Size(594, 379);
            this.authorDataGridView.TabIndex = 38;
            // 
            // idknigiDataGridViewTextBoxColumn
            // 
            this.idknigiDataGridViewTextBoxColumn.DataPropertyName = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.HeaderText = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.Name = "idknigiDataGridViewTextBoxColumn";
            this.idknigiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idizdatelstvaDataGridViewTextBoxColumn
            // 
            this.idizdatelstvaDataGridViewTextBoxColumn.DataPropertyName = "id_izdatelstva";
            this.idizdatelstvaDataGridViewTextBoxColumn.HeaderText = "id_izdatelstva";
            this.idizdatelstvaDataGridViewTextBoxColumn.Name = "idizdatelstvaDataGridViewTextBoxColumn";
            // 
            // idtypeizdaniaDataGridViewTextBoxColumn
            // 
            this.idtypeizdaniaDataGridViewTextBoxColumn.DataPropertyName = "id_type_izdania";
            this.idtypeizdaniaDataGridViewTextBoxColumn.HeaderText = "id_type_izdania";
            this.idtypeizdaniaDataGridViewTextBoxColumn.Name = "idtypeizdaniaDataGridViewTextBoxColumn";
            // 
            // idauthorDataGridViewTextBoxColumn
            // 
            this.idauthorDataGridViewTextBoxColumn.DataPropertyName = "id_author";
            this.idauthorDataGridViewTextBoxColumn.HeaderText = "id_author";
            this.idauthorDataGridViewTextBoxColumn.Name = "idauthorDataGridViewTextBoxColumn";
            // 
            // zaglavieDataGridViewTextBoxColumn
            // 
            this.zaglavieDataGridViewTextBoxColumn.DataPropertyName = "zaglavie";
            this.zaglavieDataGridViewTextBoxColumn.HeaderText = "zaglavie";
            this.zaglavieDataGridViewTextBoxColumn.Name = "zaglavieDataGridViewTextBoxColumn";
            // 
            // inventarniinumberDataGridViewTextBoxColumn
            // 
            this.inventarniinumberDataGridViewTextBoxColumn.DataPropertyName = "inventarnii_number";
            this.inventarniinumberDataGridViewTextBoxColumn.HeaderText = "inventarnii_number";
            this.inventarniinumberDataGridViewTextBoxColumn.Name = "inventarniinumberDataGridViewTextBoxColumn";
            // 
            // kolstrDataGridViewTextBoxColumn
            // 
            this.kolstrDataGridViewTextBoxColumn.DataPropertyName = "kol_str";
            this.kolstrDataGridViewTextBoxColumn.HeaderText = "kol_str";
            this.kolstrDataGridViewTextBoxColumn.Name = "kolstrDataGridViewTextBoxColumn";
            // 
            // bbkindexDataGridViewTextBoxColumn
            // 
            this.bbkindexDataGridViewTextBoxColumn.DataPropertyName = "bbk_index";
            this.bbkindexDataGridViewTextBoxColumn.HeaderText = "bbk_index";
            this.bbkindexDataGridViewTextBoxColumn.Name = "bbkindexDataGridViewTextBoxColumn";
            // 
            // ubkindexDataGridViewTextBoxColumn
            // 
            this.ubkindexDataGridViewTextBoxColumn.DataPropertyName = "ubk_index";
            this.ubkindexDataGridViewTextBoxColumn.HeaderText = "ubk_index";
            this.ubkindexDataGridViewTextBoxColumn.Name = "ubkindexDataGridViewTextBoxColumn";
            // 
            // nalichieDataGridViewCheckBoxColumn
            // 
            this.nalichieDataGridViewCheckBoxColumn.DataPropertyName = "nalichie";
            this.nalichieDataGridViewCheckBoxColumn.HeaderText = "nalichie";
            this.nalichieDataGridViewCheckBoxColumn.Name = "nalichieDataGridViewCheckBoxColumn";
            // 
            // knigaBindingSource
            // 
            this.knigaBindingSource.DataMember = "Kniga";
            this.knigaBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button4.Location = new System.Drawing.Point(644, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 49);
            this.button4.TabIndex = 36;
            this.button4.Text = "УДАЛИТЬ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button3.Location = new System.Drawing.Point(494, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 35;
            this.button3.Text = "ИЗМЕНИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button2.Location = new System.Drawing.Point(344, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 49);
            this.button2.TabIndex = 34;
            this.button2.Text = "ДОБАВИТЬ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button1.Location = new System.Drawing.Point(194, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 33;
            this.button1.Text = "ОБНОВИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // knigaTableAdapter
            // 
            this.knigaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BibliotekarTableAdapter = null;
            this.tableAdapterManager.ChitatelTableAdapter = null;
            this.tableAdapterManager.FormularTableAdapter = null;
            this.tableAdapterManager.IzdatelstvoTableAdapter = null;
            this.tableAdapterManager.KnigaTableAdapter = this.knigaTableAdapter;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.Type_izdaniaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = АИС_отдела_редких_книг.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VidachaTableAdapter = null;
            this.tableAdapterManager.VozvratTableAdapter = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "ПОИСК:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 40;
            // 
            // КНИГА
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.authorDataGridView);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "КНИГА";
            this.Text = "КНИГА";
            this.Load += new System.EventHandler(this.КНИГА_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView authorDataGridView;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource knigaBindingSource;
        private DataSetTableAdapters.KnigaTableAdapter knigaTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idknigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idizdatelstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypeizdaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaglavieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarniinumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolstrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbkindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubkindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nalichieDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}