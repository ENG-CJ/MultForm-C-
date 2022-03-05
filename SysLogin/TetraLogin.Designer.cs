namespace SysLogin
{
    partial class TetraLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TetraLogin));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.userTitle = new System.Windows.Forms.Label();
            this.userInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PassTitle = new System.Windows.Forms.Label();
            this.PassInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.forgetLabel = new System.Windows.Forms.Label();
            this.loginBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.signupBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowPasscodeImage = new System.Windows.Forms.PictureBox();
            this.HidePasscodeImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasscodeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasscodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::SysLogin.Properties.Resources.close_icon;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::SysLogin.Properties.Resources.close_icon;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::SysLogin.Properties.Resources.close_icon;
            this.kryptonPalette1.ButtonSpecs.FormClose.ToolTipTitle = "Text";
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::SysLogin.Properties.Resources.max;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::SysLogin.Properties.Resources.max;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::SysLogin.Properties.Resources.max;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::SysLogin.Properties.Resources.min;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::SysLogin.Properties.Resources.min;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::SysLogin.Properties.Resources.min;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, -1, -1, -1);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Poppins SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(36, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(463, 118);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Find Experience And\r\nGet Skill";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // userTitle
            // 
            this.userTitle.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.userTitle.Location = new System.Drawing.Point(38, 191);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(187, 41);
            this.userTitle.TabIndex = 2;
            this.userTitle.Text = "Username";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(38, 233);
            this.userInput.Name = "userInput";
            this.userInput.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.userInput.Size = new System.Drawing.Size(347, 40);
            this.userInput.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.userInput.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.userInput.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userInput.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.userInput.StateCommon.Border.Rounding = 17;
            this.userInput.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.userInput.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.userInput.TabIndex = 3;
            // 
            // PassTitle
            // 
            this.PassTitle.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PassTitle.Location = new System.Drawing.Point(38, 301);
            this.PassTitle.Name = "PassTitle";
            this.PassTitle.Size = new System.Drawing.Size(187, 41);
            this.PassTitle.TabIndex = 2;
            this.PassTitle.Text = "Password";
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(38, 343);
            this.PassInput.Name = "PassInput";
            this.PassInput.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.PassInput.PasswordChar = '*';
            this.PassInput.Size = new System.Drawing.Size(347, 40);
            this.PassInput.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.PassInput.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.PassInput.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PassInput.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PassInput.StateCommon.Border.Rounding = 17;
            this.PassInput.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.PassInput.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.PassInput.TabIndex = 3;
            this.toolTip1.SetToolTip(this.PassInput, "Text User");
            // 
            // forgetLabel
            // 
            this.forgetLabel.AutoSize = true;
            this.forgetLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetLabel.Location = new System.Drawing.Point(232, 386);
            this.forgetLabel.Name = "forgetLabel";
            this.forgetLabel.Size = new System.Drawing.Size(121, 16);
            this.forgetLabel.TabIndex = 4;
            this.forgetLabel.Text = "Forget Password?";
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Location = new System.Drawing.Point(38, 432);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.Navy;
            this.loginBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Blue;
            this.loginBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.loginBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginBtn.OverrideDefault.Border.Rounding = 20;
            this.loginBtn.OverrideDefault.Border.Width = 0;
            this.loginBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.loginBtn.Size = new System.Drawing.Size(158, 50);
            this.loginBtn.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.StateCommon.Back.ColorAngle = 45F;
            this.loginBtn.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.StateCommon.Border.ColorAngle = 45F;
            this.loginBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginBtn.StateCommon.Border.Rounding = 20;
            this.loginBtn.StateCommon.Border.Width = 0;
            this.loginBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.loginBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.loginBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.StatePressed.Back.ColorAngle = 45F;
            this.loginBtn.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.StatePressed.Border.Color2 = System.Drawing.Color.Blue;
            this.loginBtn.StatePressed.Border.ColorAngle = 45F;
            this.loginBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginBtn.StatePressed.Border.Rounding = 20;
            this.loginBtn.StatePressed.Border.Width = 0;
            this.loginBtn.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.StateTracking.Back.ColorAngle = 45F;
            this.loginBtn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginBtn.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.loginBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginBtn.StateTracking.Border.Rounding = 20;
            this.loginBtn.StateTracking.Border.Width = 0;
            this.loginBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.loginBtn, "Login As Valid User");
            this.loginBtn.Values.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.SignIn);
            // 
            // signupBtn
            // 
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Location = new System.Drawing.Point(206, 432);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.signupBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.signupBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.signupBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.Blue;
            this.signupBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Blue;
            this.signupBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signupBtn.OverrideDefault.Border.Rounding = 8;
            this.signupBtn.OverrideDefault.Border.Width = 0;
            this.signupBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Blue;
            this.signupBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Blue;
            this.signupBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.signupBtn.Size = new System.Drawing.Size(158, 50);
            this.signupBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.signupBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.signupBtn.StateCommon.Back.ColorAngle = 45F;
            this.signupBtn.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.signupBtn.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.signupBtn.StateCommon.Border.ColorAngle = 45F;
            this.signupBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signupBtn.StateCommon.Border.Rounding = 8;
            this.signupBtn.StateCommon.Border.Width = 0;
            this.signupBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Blue;
            this.signupBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Blue;
            this.signupBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.signupBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signupBtn.StatePressed.Back.ColorAngle = 45F;
            this.signupBtn.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.signupBtn.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.signupBtn.StatePressed.Border.ColorAngle = -135F;
            this.signupBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signupBtn.StatePressed.Border.Rounding = 8;
            this.signupBtn.StatePressed.Border.Width = 0;
            this.signupBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.signupBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.signupBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signupBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signupBtn.StateTracking.Back.ColorAngle = -135F;
            this.signupBtn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signupBtn.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.signupBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signupBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signupBtn.StateTracking.Border.Rounding = 8;
            this.signupBtn.StateTracking.Border.Width = 0;
            this.signupBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.signupBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.signupBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.signupBtn, "Create Your Account");
            this.signupBtn.Values.Text = "SignUp";
            this.signupBtn.Click += new System.EventHandler(this.SignUpPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysLogin.Properties.Resources.Moile_login;
            this.pictureBox1.Location = new System.Drawing.Point(552, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShowPasscodeImage
            // 
            this.ShowPasscodeImage.BackColor = System.Drawing.Color.White;
            this.ShowPasscodeImage.Image = global::SysLogin.Properties.Resources.show1;
            this.ShowPasscodeImage.InitialImage = global::SysLogin.Properties.Resources.hide1;
            this.ShowPasscodeImage.Location = new System.Drawing.Point(348, 349);
            this.ShowPasscodeImage.Name = "ShowPasscodeImage";
            this.ShowPasscodeImage.Size = new System.Drawing.Size(30, 27);
            this.ShowPasscodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPasscodeImage.TabIndex = 6;
            this.ShowPasscodeImage.TabStop = false;
            this.ShowPasscodeImage.Click += new System.EventHandler(this.ShowPass);
            // 
            // HidePasscodeImage
            // 
            this.HidePasscodeImage.BackColor = System.Drawing.Color.White;
            this.HidePasscodeImage.Image = global::SysLogin.Properties.Resources.hide1;
            this.HidePasscodeImage.Location = new System.Drawing.Point(349, 349);
            this.HidePasscodeImage.Name = "HidePasscodeImage";
            this.HidePasscodeImage.Size = new System.Drawing.Size(27, 27);
            this.HidePasscodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePasscodeImage.TabIndex = 7;
            this.HidePasscodeImage.TabStop = false;
            this.HidePasscodeImage.Click += new System.EventHandler(this.HidePass);
            // 
            // TetraLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 654);
            this.Controls.Add(this.HidePasscodeImage);
            this.Controls.Add(this.ShowPasscodeImage);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.forgetLabel);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.PassTitle);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.userTitle);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TetraLogin";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "RGG LOGIN PAGE";
            this.Load += new System.EventHandler(this.TetraLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasscodeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasscodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label userTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userInput;
        private System.Windows.Forms.Label PassTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PassInput;
        private System.Windows.Forms.Label forgetLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signupBtn;
        private System.Windows.Forms.PictureBox ShowPasscodeImage;
        private System.Windows.Forms.PictureBox HidePasscodeImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}