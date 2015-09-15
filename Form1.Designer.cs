namespace game_git_GL
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.game_okno = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // game_okno
            // 
            this.game_okno.AccumBits = ((byte)(0));
            this.game_okno.AutoCheckErrors = false;
            this.game_okno.AutoFinish = false;
            this.game_okno.AutoMakeCurrent = true;
            this.game_okno.AutoSwapBuffers = true;
            this.game_okno.BackColor = System.Drawing.Color.Black;
            this.game_okno.ColorBits = ((byte)(32));
            this.game_okno.DepthBits = ((byte)(16));
            this.game_okno.Location = new System.Drawing.Point(13, 13);
            this.game_okno.Name = "game_okno";
            this.game_okno.Size = new System.Drawing.Size(50, 50);
            this.game_okno.StencilBits = ((byte)(0));
            this.game_okno.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.game_okno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl game_okno;
    }
}

