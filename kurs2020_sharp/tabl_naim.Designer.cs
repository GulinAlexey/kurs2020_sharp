﻿namespace kurs2020_sharp
{
    partial class tabl_naim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabl_naim));
            this.label3 = new System.Windows.Forms.Label();
            this.naim_box = new System.Windows.Forms.GroupBox();
            this.num_krest_pole = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.naim_butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.spisok = new System.Windows.Forms.DataGridView();
            this.number_tabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_tabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizv_tabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prozhorl_tabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rashod_tabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naim_money_tabl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naim_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spisok)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Примечание: информация выводится с учётом текущей Скорости жизни";
            // 
            // naim_box
            // 
            this.naim_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.naim_box.Controls.Add(this.num_krest_pole);
            this.naim_box.Controls.Add(this.label1);
            this.naim_box.Controls.Add(this.naim_butt);
            this.naim_box.Location = new System.Drawing.Point(423, 12);
            this.naim_box.Name = "naim_box";
            this.naim_box.Size = new System.Drawing.Size(428, 87);
            this.naim_box.TabIndex = 20;
            this.naim_box.TabStop = false;
            // 
            // num_krest_pole
            // 
            this.num_krest_pole.Location = new System.Drawing.Point(22, 39);
            this.num_krest_pole.Mask = "000000000000000000000000000000000000000000000";
            this.num_krest_pole.Name = "num_krest_pole";
            this.num_krest_pole.PromptChar = ' ';
            this.num_krest_pole.Size = new System.Drawing.Size(283, 20);
            this.num_krest_pole.TabIndex = 16;
            this.num_krest_pole.TabStop = false;
            this.num_krest_pole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите номер крестьянина, которого хотите нанять:";
            // 
            // naim_butt
            // 
            this.naim_butt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.naim_butt.Enabled = false;
            this.naim_butt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naim_butt.Location = new System.Drawing.Point(311, 34);
            this.naim_butt.Name = "naim_butt";
            this.naim_butt.Size = new System.Drawing.Size(103, 28);
            this.naim_butt.TabIndex = 10;
            this.naim_butt.TabStop = false;
            this.naim_butt.Text = "Нанять";
            this.naim_butt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Доступные для найма крестьяне:";
            // 
            // spisok
            // 
            this.spisok.AllowUserToAddRows = false;
            this.spisok.AllowUserToDeleteRows = false;
            this.spisok.AllowUserToResizeColumns = false;
            this.spisok.AllowUserToResizeRows = false;
            this.spisok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.spisok.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.spisok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spisok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_tabl,
            this.name_tabl,
            this.proizv_tabl,
            this.prozhorl_tabl,
            this.rashod_tabl,
            this.naim_money_tabl});
            this.spisok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.spisok.Location = new System.Drawing.Point(12, 117);
            this.spisok.MultiSelect = false;
            this.spisok.Name = "spisok";
            this.spisok.ReadOnly = true;
            this.spisok.RowHeadersVisible = false;
            this.spisok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.spisok.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.spisok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.spisok.ShowEditingIcon = false;
            this.spisok.Size = new System.Drawing.Size(850, 242);
            this.spisok.TabIndex = 22;
            this.spisok.TabStop = false;
            // 
            // number_tabl
            // 
            this.number_tabl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.number_tabl.Frozen = true;
            this.number_tabl.HeaderText = "№";
            this.number_tabl.Name = "number_tabl";
            this.number_tabl.ReadOnly = true;
            this.number_tabl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.number_tabl.Width = 40;
            // 
            // name_tabl
            // 
            this.name_tabl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name_tabl.Frozen = true;
            this.name_tabl.HeaderText = "Имя и фамилия";
            this.name_tabl.Name = "name_tabl";
            this.name_tabl.ReadOnly = true;
            this.name_tabl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.name_tabl.Width = 180;
            // 
            // proizv_tabl
            // 
            this.proizv_tabl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proizv_tabl.Frozen = true;
            this.proizv_tabl.HeaderText = "Производительность за один Час Процветания (хлеб/скот)";
            this.proizv_tabl.Name = "proizv_tabl";
            this.proizv_tabl.ReadOnly = true;
            this.proizv_tabl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.proizv_tabl.Width = 180;
            // 
            // prozhorl_tabl
            // 
            this.prozhorl_tabl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prozhorl_tabl.Frozen = true;
            this.prozhorl_tabl.HeaderText = "Прожорливость за один Час Процветания (хлеб/скот)";
            this.prozhorl_tabl.Name = "prozhorl_tabl";
            this.prozhorl_tabl.ReadOnly = true;
            this.prozhorl_tabl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.prozhorl_tabl.Width = 177;
            // 
            // rashod_tabl
            // 
            this.rashod_tabl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rashod_tabl.Frozen = true;
            this.rashod_tabl.HeaderText = "Денежные расходы за один Час Процветания (руб.)";
            this.rashod_tabl.Name = "rashod_tabl";
            this.rashod_tabl.ReadOnly = true;
            this.rashod_tabl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rashod_tabl.Width = 177;
            // 
            // naim_money_tabl
            // 
            this.naim_money_tabl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.naim_money_tabl.Frozen = true;
            this.naim_money_tabl.HeaderText = "Стоимость найма (руб.)";
            this.naim_money_tabl.Name = "naim_money_tabl";
            this.naim_money_tabl.ReadOnly = true;
            this.naim_money_tabl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.naim_money_tabl.Width = 91;
            // 
            // tabl_naim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 371);
            this.Controls.Add(this.spisok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naim_box);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(890, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(890, 410);
            this.Name = "tabl_naim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Биржа труда";
            this.naim_box.ResumeLayout(false);
            this.naim_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spisok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox naim_box;
        private System.Windows.Forms.MaskedTextBox num_krest_pole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button naim_butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView spisok;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_tabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_tabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizv_tabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn prozhorl_tabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn rashod_tabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn naim_money_tabl;
    }
}