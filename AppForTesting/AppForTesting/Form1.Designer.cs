namespace AppForTesting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.TextBoxLen1 = new System.Windows.Forms.TextBox();
            this.TextBoxLen2 = new System.Windows.Forms.TextBox();
            this.TextBoxLen3 = new System.Windows.Forms.TextBox();
            this.LabelEnter = new System.Windows.Forms.Label();
            this.LabelLen1 = new System.Windows.Forms.Label();
            this.LabelLen2 = new System.Windows.Forms.Label();
            this.LabelLen3 = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCheck.Location = new System.Drawing.Point(296, 463);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(287, 113);
            this.ButtonCheck.TabIndex = 0;
            this.ButtonCheck.Text = "Проверить";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // TextBoxLen1
            // 
            this.TextBoxLen1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxLen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLen1.Location = new System.Drawing.Point(3, 348);
            this.TextBoxLen1.Name = "TextBoxLen1";
            this.TextBoxLen1.Size = new System.Drawing.Size(287, 30);
            this.TextBoxLen1.TabIndex = 1;
            this.TextBoxLen1.Text = "0";
            this.TextBoxLen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxLen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLen_KeyPress);
            // 
            // TextBoxLen2
            // 
            this.TextBoxLen2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxLen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLen2.Location = new System.Drawing.Point(296, 348);
            this.TextBoxLen2.Name = "TextBoxLen2";
            this.TextBoxLen2.Size = new System.Drawing.Size(287, 30);
            this.TextBoxLen2.TabIndex = 2;
            this.TextBoxLen2.Text = "0";
            this.TextBoxLen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxLen2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLen_KeyPress);
            // 
            // TextBoxLen3
            // 
            this.TextBoxLen3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxLen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLen3.Location = new System.Drawing.Point(589, 348);
            this.TextBoxLen3.Name = "TextBoxLen3";
            this.TextBoxLen3.Size = new System.Drawing.Size(288, 30);
            this.TextBoxLen3.TabIndex = 3;
            this.TextBoxLen3.Text = "0";
            this.TextBoxLen3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxLen3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLen_KeyPress);
            // 
            // LabelEnter
            // 
            this.LabelEnter.AutoSize = true;
            this.LabelEnter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEnter.Location = new System.Drawing.Point(296, 166);
            this.LabelEnter.Name = "LabelEnter";
            this.LabelEnter.Size = new System.Drawing.Size(287, 64);
            this.LabelEnter.TabIndex = 4;
            this.LabelEnter.Text = "Введите стороны треугольника:";
            this.LabelEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLen1
            // 
            this.LabelLen1.AutoSize = true;
            this.LabelLen1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelLen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLen1.Location = new System.Drawing.Point(3, 320);
            this.LabelLen1.Name = "LabelLen1";
            this.LabelLen1.Size = new System.Drawing.Size(287, 25);
            this.LabelLen1.TabIndex = 5;
            this.LabelLen1.Text = "Сторона 1";
            this.LabelLen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLen2
            // 
            this.LabelLen2.AutoSize = true;
            this.LabelLen2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelLen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLen2.Location = new System.Drawing.Point(296, 320);
            this.LabelLen2.Name = "LabelLen2";
            this.LabelLen2.Size = new System.Drawing.Size(287, 25);
            this.LabelLen2.TabIndex = 6;
            this.LabelLen2.Text = "Сторона 2";
            this.LabelLen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLen3
            // 
            this.LabelLen3.AutoSize = true;
            this.LabelLen3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelLen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLen3.Location = new System.Drawing.Point(589, 320);
            this.LabelLen3.Name = "LabelLen3";
            this.LabelLen3.Size = new System.Drawing.Size(288, 25);
            this.LabelLen3.TabIndex = 7;
            this.LabelLen3.Text = "Сторона 3";
            this.LabelLen3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LabelTitle, 3);
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(3, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(874, 115);
            this.LabelTitle.TabIndex = 8;
            this.LabelTitle.Text = "Калькулятор типов треугольников";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonCheck, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LabelLen1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxLen1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxLen2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxLen3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelLen2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelLen3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelEnter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 579);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "Form1";
            this.Text = "Типы треугольников";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.TextBox TextBoxLen1;
        private System.Windows.Forms.TextBox TextBoxLen2;
        private System.Windows.Forms.TextBox TextBoxLen3;
        private System.Windows.Forms.Label LabelEnter;
        private System.Windows.Forms.Label LabelLen1;
        private System.Windows.Forms.Label LabelLen2;
        private System.Windows.Forms.Label LabelLen3;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

