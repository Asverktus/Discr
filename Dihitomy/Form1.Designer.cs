namespace Dihitomy
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
      menuStrip1 = new MenuStrip();
      файлToolStripMenuItem = new ToolStripMenuItem();
      выходToolStripMenuItem = new ToolStripMenuItem();
      действияToolStripMenuItem = new ToolStripMenuItem();
      рассчитатьToolStripMenuItem = new ToolStripMenuItem();
      очиститьToolStripMenuItem = new ToolStripMenuItem();
      справкаToolStripMenuItem = new ToolStripMenuItem();
      оПрограммеToolStripMenuItem = new ToolStripMenuItem();
      lblFunction = new Label();
      lblResult = new Label();
      txtFunction = new TextBox();
      txtResult = new TextBox();
      rbDichotomy = new RadioButton();
      rbGolden = new RadioButton();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, действияToolStripMenuItem, справкаToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Padding = new Padding(7, 3, 0, 3);
      menuStrip1.Size = new Size(1125, 30);
      menuStrip1.TabIndex = 1;
      menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
      файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      файлToolStripMenuItem.Size = new Size(59, 24);
      файлToolStripMenuItem.Text = "Файл";
      // 
      // выходToolStripMenuItem
      // 
      выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      выходToolStripMenuItem.Size = new Size(136, 26);
      выходToolStripMenuItem.Text = "Выход";
      выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
      // 
      // действияToolStripMenuItem
      // 
      действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { рассчитатьToolStripMenuItem, очиститьToolStripMenuItem });
      действияToolStripMenuItem.Name = "действияToolStripMenuItem";
      действияToolStripMenuItem.Size = new Size(88, 24);
      действияToolStripMenuItem.Text = "Действия";
      // 
      // рассчитатьToolStripMenuItem
      // 
      рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      рассчитатьToolStripMenuItem.Size = new Size(167, 26);
      рассчитатьToolStripMenuItem.Text = "Рассчитать";
      рассчитатьToolStripMenuItem.Click += рассчитатьToolStripMenuItem_Click;
      // 
      // очиститьToolStripMenuItem
      // 
      очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      очиститьToolStripMenuItem.Size = new Size(167, 26);
      очиститьToolStripMenuItem.Text = "Очистить";
      очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
      // 
      // справкаToolStripMenuItem
      // 
      справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
      справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
      справкаToolStripMenuItem.Size = new Size(81, 24);
      справкаToolStripMenuItem.Text = "Справка";
      // 
      // оПрограммеToolStripMenuItem
      // 
      оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      оПрограммеToolStripMenuItem.Size = new Size(187, 26);
      оПрограммеToolStripMenuItem.Text = "О программе";
      оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
      // 
      // lblFunction
      // 
      lblFunction.AutoSize = true;
      lblFunction.Location = new Point(67, 186);
      lblFunction.Name = "lblFunction";
      lblFunction.Size = new Size(45, 20);
      lblFunction.TabIndex = 5;
      lblFunction.Text = "f(x) =";
      // 
      // lblResult
      // 
      lblResult.AutoSize = true;
      lblResult.Location = new Point(67, 395);
      lblResult.Name = "lblResult";
      lblResult.Size = new Size(78, 20);
      lblResult.TabIndex = 6;
      lblResult.Text = "Результат:";
      // 
      // txtFunction
      // 
      txtFunction.Location = new Point(118, 183);
      txtFunction.Margin = new Padding(3, 4, 3, 4);
      txtFunction.Name = "txtFunction";
      txtFunction.Size = new Size(228, 27);
      txtFunction.TabIndex = 10;
      // 
      // txtResult
      // 
      txtResult.Location = new Point(67, 440);
      txtResult.Margin = new Padding(3, 4, 3, 4);
      txtResult.Multiline = true;
      txtResult.Name = "txtResult";
      txtResult.ReadOnly = true;
      txtResult.Size = new Size(799, 199);
      txtResult.TabIndex = 11;
      // 
      // rbDichotomy
      // 
      rbDichotomy.AutoSize = true;
      rbDichotomy.Checked = true;
      rbDichotomy.Location = new Point(67, 115);
      rbDichotomy.Margin = new Padding(3, 4, 3, 4);
      rbDichotomy.Name = "rbDichotomy";
      rbDichotomy.Size = new Size(133, 24);
      rbDichotomy.TabIndex = 12;
      rbDichotomy.TabStop = true;
      rbDichotomy.Text = "Дискриминант";
      rbDichotomy.UseVisualStyleBackColor = true;
      // 
      // rbGolden
      // 
      rbGolden.AutoSize = true;
      rbGolden.Location = new Point(302, 115);
      rbGolden.Margin = new Padding(3, 4, 3, 4);
      rbGolden.Name = "rbGolden";
      rbGolden.Size = new Size(70, 24);
      rbGolden.TabIndex = 13;
      rbGolden.Text = "Виета";
      rbGolden.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1125, 653);
      Controls.Add(rbGolden);
      Controls.Add(rbDichotomy);
      Controls.Add(txtResult);
      Controls.Add(txtFunction);
      Controls.Add(lblResult);
      Controls.Add(lblFunction);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Margin = new Padding(3, 4, 3, 4);
      Name = "Form1";
      Text = "Расчитать дискриминант";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private MenuStrip menuStrip1;
    private ToolStripMenuItem файлToolStripMenuItem;
    private ToolStripMenuItem действияToolStripMenuItem;
    private ToolStripMenuItem справкаToolStripMenuItem;
    private ToolStripMenuItem рассчитатьToolStripMenuItem;
    private ToolStripMenuItem очиститьToolStripMenuItem;
    private ToolStripMenuItem оПрограммеToolStripMenuItem;
    private Label lblFunction;
    private Label lblResult;
    private TextBox txtFunction;
    private TextBox txtResult;
    private ToolStripMenuItem выходToolStripMenuItem;
    private RadioButton rbDichotomy;
    private RadioButton rbGolden;
  }
}
