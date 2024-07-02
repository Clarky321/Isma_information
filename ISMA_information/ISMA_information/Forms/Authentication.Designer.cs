namespace ISMA_information.Forms
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.TextBox_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ComboBox_log_in = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_log_in)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // TextBox_password
            // 
            this.TextBox_password.Location = new System.Drawing.Point(12, 346);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.Size = new System.Drawing.Size(487, 47);
            this.TextBox_password.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TextBox_password.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.TextBox_password.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.TextBox_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBox_password.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TextBox_password.StateCommon.Border.Rounding = 20;
            this.TextBox_password.StateCommon.Border.Width = 1;
            this.TextBox_password.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.TextBox_password.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TextBox_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(248, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(388, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(92, 425);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEnter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEnter.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEnter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEnter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEnter.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEnter.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEnter.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEnter.OverrideDefault.Border.Rounding = 20;
            this.btnEnter.OverrideDefault.Border.Width = 1;
            this.btnEnter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEnter.Size = new System.Drawing.Size(324, 67);
            this.btnEnter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEnter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEnter.StateCommon.Back.ColorAngle = 45F;
            this.btnEnter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEnter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEnter.StateCommon.Border.ColorAngle = 45F;
            this.btnEnter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEnter.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEnter.StateCommon.Border.Rounding = 20;
            this.btnEnter.StateCommon.Border.Width = 1;
            this.btnEnter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEnter.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEnter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEnter.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEnter.StatePressed.Back.ColorAngle = 135F;
            this.btnEnter.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEnter.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEnter.StatePressed.Border.ColorAngle = 135F;
            this.btnEnter.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEnter.StatePressed.Border.Rounding = 20;
            this.btnEnter.StatePressed.Border.Width = 1;
            this.btnEnter.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEnter.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEnter.StateTracking.Back.ColorAngle = 45F;
            this.btnEnter.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEnter.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEnter.StateTracking.Border.ColorAngle = 45F;
            this.btnEnter.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEnter.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEnter.StateTracking.Border.Rounding = 20;
            this.btnEnter.StateTracking.Border.Width = 1;
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Values.Text = "Войти в систему";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // ComboBox_log_in
            // 
            this.ComboBox_log_in.DropDownWidth = 381;
            this.ComboBox_log_in.Location = new System.Drawing.Point(12, 233);
            this.ComboBox_log_in.Name = "ComboBox_log_in";
            this.ComboBox_log_in.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ComboBox_log_in.Size = new System.Drawing.Size(487, 50);
            this.ComboBox_log_in.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.ComboBox_log_in.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.ComboBox_log_in.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.ComboBox_log_in.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBox_log_in.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ComboBox_log_in.StateCommon.ComboBox.Border.Rounding = 20;
            this.ComboBox_log_in.StateCommon.ComboBox.Border.Width = 1;
            this.ComboBox_log_in.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComboBox_log_in.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_log_in.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ComboBox_log_in.TabIndex = 7;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 549);
            this.Controls.Add(this.ComboBox_log_in);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authentication";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISMA";
            this.Load += new System.EventHandler(this.Authentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_log_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEnter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBox_log_in;
    }
}