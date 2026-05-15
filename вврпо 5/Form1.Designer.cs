namespace вврпо_5
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
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTable
            // 
            this.gameTable.ColumnCount = 3;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTable.Controls.Add(this.button22, 2, 2);
            this.gameTable.Controls.Add(this.button21, 1, 2);
            this.gameTable.Controls.Add(this.button20, 0, 2);
            this.gameTable.Controls.Add(this.button12, 2, 1);
            this.gameTable.Controls.Add(this.button11, 1, 1);
            this.gameTable.Controls.Add(this.button10, 0, 1);
            this.gameTable.Controls.Add(this.button02, 2, 0);
            this.gameTable.Controls.Add(this.button01, 1, 0);
            this.gameTable.Controls.Add(this.button00, 0, 0);
            this.gameTable.Location = new System.Drawing.Point(39, 12);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 3;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTable.Size = new System.Drawing.Size(300, 296);
            this.gameTable.TabIndex = 0;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(201, 199);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(94, 92);
            this.button22.TabIndex = 9;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.CellClick);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(102, 199);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(93, 92);
            this.button21.TabIndex = 8;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.CellClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(3, 199);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(93, 92);
            this.button20.TabIndex = 7;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.CellClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(201, 101);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 92);
            this.button12.TabIndex = 6;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.CellClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(102, 101);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 92);
            this.button11.TabIndex = 5;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CellClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(3, 101);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 92);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.CellClick);
            // 
            // button02
            // 
            this.button02.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button02.Location = new System.Drawing.Point(201, 3);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(94, 92);
            this.button02.TabIndex = 3;
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.CellClick);
            // 
            // button01
            // 
            this.button01.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button01.Location = new System.Drawing.Point(102, 3);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(93, 92);
            this.button01.TabIndex = 2;
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.CellClick);
            // 
            // button00
            // 
            this.button00.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button00.Location = new System.Drawing.Point(3, 3);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(93, 92);
            this.button00.TabIndex = 1;
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.CellClick);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.statusLabel.Location = new System.Drawing.Point(42, 323);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(292, 20);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Нажмите \"Начать игру\"";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(141, 356);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 46);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(76, 408);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 46);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить игру";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(204, 408);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(94, 46);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Загрузить игру";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(76, 474);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(94, 46);
            this.newGameButton.TabIndex = 5;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(204, 474);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 46);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(382, 655);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.gameTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.CellClick);
            this.gameTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

