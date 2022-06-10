namespace Cookie_Patcher
{
    partial class Cookie_Patcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cookie_Patcher));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_revert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.button_apply = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pakchunk = new Bunifu.UI.WinForms.BunifuTextBox();
            this.button_select_pakchunk = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.dragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label_version = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 3;
            this.panel.BorderThickness = 1;
            this.panel.Controls.Add(this.label_version);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.button_exit);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShowBorders = true;
            this.panel.Size = new System.Drawing.Size(341, 28);
            this.panel.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cookie Patcher";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.BackgroundImage = global::Cookie_Patcher.Properties.Resources.close;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_exit.Location = new System.Drawing.Point(308, 3);
            this.button_exit.Margin = new System.Windows.Forms.Padding(1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(10);
            this.button_exit.Size = new System.Drawing.Size(23, 21);
            this.button_exit.TabIndex = 12;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Cookie_Patcher.Properties.Resources.cookie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_revert);
            this.panel1.Controls.Add(this.button_apply);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.pakchunk);
            this.panel1.Controls.Add(this.button_select_pakchunk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 196);
            this.panel1.TabIndex = 27;
            // 
            // button_revert
            // 
            this.button_revert.AllowAnimations = true;
            this.button_revert.AllowMouseEffects = true;
            this.button_revert.AllowToggling = false;
            this.button_revert.AnimationSpeed = 200;
            this.button_revert.AutoGenerateColors = false;
            this.button_revert.AutoRoundBorders = false;
            this.button_revert.AutoSizeLeftIcon = true;
            this.button_revert.AutoSizeRightIcon = true;
            this.button_revert.BackColor = System.Drawing.Color.Transparent;
            this.button_revert.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button_revert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_revert.BackgroundImage")));
            this.button_revert.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_revert.ButtonText = "Remove Patch";
            this.button_revert.ButtonTextMarginLeft = 0;
            this.button_revert.ColorContrastOnClick = 45;
            this.button_revert.ColorContrastOnHover = 45;
            this.button_revert.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_revert.CustomizableEdges = borderEdges1;
            this.button_revert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_revert.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_revert.DisabledFillColor = System.Drawing.Color.Empty;
            this.button_revert.DisabledForecolor = System.Drawing.Color.Empty;
            this.button_revert.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_revert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_revert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_revert.IconLeft = null;
            this.button_revert.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_revert.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_revert.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_revert.IconMarginLeft = 11;
            this.button_revert.IconPadding = 10;
            this.button_revert.IconRight = null;
            this.button_revert.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_revert.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_revert.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_revert.IconSize = 25;
            this.button_revert.IdleBorderColor = System.Drawing.Color.Empty;
            this.button_revert.IdleBorderRadius = 0;
            this.button_revert.IdleBorderThickness = 0;
            this.button_revert.IdleFillColor = System.Drawing.Color.Empty;
            this.button_revert.IdleIconLeftImage = null;
            this.button_revert.IdleIconRightImage = null;
            this.button_revert.IndicateFocus = false;
            this.button_revert.Location = new System.Drawing.Point(92, 145);
            this.button_revert.Name = "button_revert";
            this.button_revert.OnDisabledState.BorderColor = System.Drawing.Color.Gray;
            this.button_revert.OnDisabledState.BorderRadius = 10;
            this.button_revert.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_revert.OnDisabledState.BorderThickness = 1;
            this.button_revert.OnDisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.button_revert.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_revert.OnDisabledState.IconLeftImage = null;
            this.button_revert.OnDisabledState.IconRightImage = null;
            this.button_revert.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.button_revert.onHoverState.BorderRadius = 10;
            this.button_revert.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_revert.onHoverState.BorderThickness = 1;
            this.button_revert.onHoverState.FillColor = System.Drawing.SystemColors.Control;
            this.button_revert.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_revert.onHoverState.IconLeftImage = null;
            this.button_revert.onHoverState.IconRightImage = null;
            this.button_revert.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.button_revert.OnIdleState.BorderRadius = 10;
            this.button_revert.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_revert.OnIdleState.BorderThickness = 1;
            this.button_revert.OnIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.button_revert.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_revert.OnIdleState.IconLeftImage = null;
            this.button_revert.OnIdleState.IconRightImage = null;
            this.button_revert.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.button_revert.OnPressedState.BorderRadius = 10;
            this.button_revert.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_revert.OnPressedState.BorderThickness = 1;
            this.button_revert.OnPressedState.FillColor = System.Drawing.SystemColors.Control;
            this.button_revert.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_revert.OnPressedState.IconLeftImage = null;
            this.button_revert.OnPressedState.IconRightImage = null;
            this.button_revert.Size = new System.Drawing.Size(153, 23);
            this.button_revert.TabIndex = 40;
            this.button_revert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_revert.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_revert.TextMarginLeft = 0;
            this.button_revert.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_revert.UseDefaultRadiusAndThickness = true;
            this.button_revert.Click += new System.EventHandler(this.button_revert_Click);
            // 
            // button_apply
            // 
            this.button_apply.AllowAnimations = true;
            this.button_apply.AllowMouseEffects = true;
            this.button_apply.AllowToggling = false;
            this.button_apply.AnimationSpeed = 200;
            this.button_apply.AutoGenerateColors = false;
            this.button_apply.AutoRoundBorders = false;
            this.button_apply.AutoSizeLeftIcon = true;
            this.button_apply.AutoSizeRightIcon = true;
            this.button_apply.BackColor = System.Drawing.Color.Transparent;
            this.button_apply.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button_apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_apply.BackgroundImage")));
            this.button_apply.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_apply.ButtonText = "Patch";
            this.button_apply.ButtonTextMarginLeft = 0;
            this.button_apply.ColorContrastOnClick = 45;
            this.button_apply.ColorContrastOnHover = 45;
            this.button_apply.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.button_apply.CustomizableEdges = borderEdges2;
            this.button_apply.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_apply.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_apply.DisabledFillColor = System.Drawing.Color.Empty;
            this.button_apply.DisabledForecolor = System.Drawing.Color.Empty;
            this.button_apply.Enabled = false;
            this.button_apply.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_apply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_apply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_apply.IconLeft = null;
            this.button_apply.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_apply.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_apply.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_apply.IconMarginLeft = 11;
            this.button_apply.IconPadding = 10;
            this.button_apply.IconRight = null;
            this.button_apply.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_apply.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_apply.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_apply.IconSize = 25;
            this.button_apply.IdleBorderColor = System.Drawing.Color.Empty;
            this.button_apply.IdleBorderRadius = 0;
            this.button_apply.IdleBorderThickness = 0;
            this.button_apply.IdleFillColor = System.Drawing.Color.Empty;
            this.button_apply.IdleIconLeftImage = null;
            this.button_apply.IdleIconRightImage = null;
            this.button_apply.IndicateFocus = false;
            this.button_apply.Location = new System.Drawing.Point(92, 116);
            this.button_apply.Name = "button_apply";
            this.button_apply.OnDisabledState.BorderColor = System.Drawing.Color.Gray;
            this.button_apply.OnDisabledState.BorderRadius = 10;
            this.button_apply.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_apply.OnDisabledState.BorderThickness = 1;
            this.button_apply.OnDisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.button_apply.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_apply.OnDisabledState.IconLeftImage = null;
            this.button_apply.OnDisabledState.IconRightImage = null;
            this.button_apply.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.button_apply.onHoverState.BorderRadius = 10;
            this.button_apply.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_apply.onHoverState.BorderThickness = 1;
            this.button_apply.onHoverState.FillColor = System.Drawing.SystemColors.Control;
            this.button_apply.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_apply.onHoverState.IconLeftImage = null;
            this.button_apply.onHoverState.IconRightImage = null;
            this.button_apply.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.button_apply.OnIdleState.BorderRadius = 10;
            this.button_apply.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_apply.OnIdleState.BorderThickness = 1;
            this.button_apply.OnIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.button_apply.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_apply.OnIdleState.IconLeftImage = null;
            this.button_apply.OnIdleState.IconRightImage = null;
            this.button_apply.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.button_apply.OnPressedState.BorderRadius = 10;
            this.button_apply.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_apply.OnPressedState.BorderThickness = 1;
            this.button_apply.OnPressedState.FillColor = System.Drawing.SystemColors.Control;
            this.button_apply.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_apply.OnPressedState.IconLeftImage = null;
            this.button_apply.OnPressedState.IconRightImage = null;
            this.button_apply.Size = new System.Drawing.Size(153, 23);
            this.button_apply.TabIndex = 39;
            this.button_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_apply.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_apply.TextMarginLeft = 0;
            this.button_apply.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_apply.UseDefaultRadiusAndThickness = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(259, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Author: Neo";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(29, 82);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(283, 1);
            this.bunifuSeparator1.TabIndex = 37;
            // 
            // pakchunk
            // 
            this.pakchunk.AcceptsReturn = false;
            this.pakchunk.AcceptsTab = false;
            this.pakchunk.AnimationSpeed = 200;
            this.pakchunk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pakchunk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pakchunk.AutoSizeHeight = true;
            this.pakchunk.BackColor = System.Drawing.Color.Transparent;
            this.pakchunk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pakchunk.BackgroundImage")));
            this.pakchunk.BorderColorActive = System.Drawing.SystemColors.ControlLight;
            this.pakchunk.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.pakchunk.BorderColorHover = System.Drawing.SystemColors.ControlLight;
            this.pakchunk.BorderColorIdle = System.Drawing.SystemColors.ControlLight;
            this.pakchunk.BorderRadius = 1;
            this.pakchunk.BorderThickness = 1;
            this.pakchunk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pakchunk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pakchunk.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.pakchunk.DefaultText = "";
            this.pakchunk.FillColor = System.Drawing.SystemColors.ControlLight;
            this.pakchunk.HideSelection = true;
            this.pakchunk.IconLeft = null;
            this.pakchunk.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.pakchunk.IconPadding = 10;
            this.pakchunk.IconRight = null;
            this.pakchunk.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.pakchunk.Lines = new string[0];
            this.pakchunk.Location = new System.Drawing.Point(92, 57);
            this.pakchunk.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.pakchunk.MaxLength = 32767;
            this.pakchunk.MinimumSize = new System.Drawing.Size(1, 1);
            this.pakchunk.Modified = false;
            this.pakchunk.Multiline = false;
            this.pakchunk.Name = "pakchunk";
            stateProperties1.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pakchunk.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.pakchunk.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pakchunk.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties4.FillColor = System.Drawing.SystemColors.ControlLight;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pakchunk.OnIdleState = stateProperties4;
            this.pakchunk.Padding = new System.Windows.Forms.Padding(3);
            this.pakchunk.PasswordChar = '\0';
            this.pakchunk.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.pakchunk.PlaceholderText = "Select pakchunk";
            this.pakchunk.ReadOnly = false;
            this.pakchunk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pakchunk.SelectedText = "";
            this.pakchunk.SelectionLength = 0;
            this.pakchunk.SelectionStart = 0;
            this.pakchunk.ShortcutsEnabled = true;
            this.pakchunk.Size = new System.Drawing.Size(209, 23);
            this.pakchunk.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.pakchunk.TabIndex = 36;
            this.pakchunk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pakchunk.TextMarginBottom = 0;
            this.pakchunk.TextMarginLeft = 3;
            this.pakchunk.TextMarginTop = 1;
            this.pakchunk.TextPlaceholder = "Select pakchunk";
            this.pakchunk.UseSystemPasswordChar = false;
            this.pakchunk.WordWrap = true;
            this.pakchunk.TextChanged += new System.EventHandler(this.pakchunk_TextChanged);
            // 
            // button_select_pakchunk
            // 
            this.button_select_pakchunk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_select_pakchunk.BackgroundImage = global::Cookie_Patcher.Properties.Resources.folder;
            this.button_select_pakchunk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_select_pakchunk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button_select_pakchunk.FlatAppearance.BorderSize = 0;
            this.button_select_pakchunk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.button_select_pakchunk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_select_pakchunk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_pakchunk.ForeColor = System.Drawing.SystemColors.Control;
            this.button_select_pakchunk.Location = new System.Drawing.Point(57, 57);
            this.button_select_pakchunk.Margin = new System.Windows.Forms.Padding(1);
            this.button_select_pakchunk.Name = "button_select_pakchunk";
            this.button_select_pakchunk.Padding = new System.Windows.Forms.Padding(10);
            this.button_select_pakchunk.Size = new System.Drawing.Size(23, 21);
            this.button_select_pakchunk.TabIndex = 13;
            this.button_select_pakchunk.UseVisualStyleBackColor = false;
            this.button_select_pakchunk.Click += new System.EventHandler(this.button_select_pakchunk_Click);
            // 
            // open_file
            // 
            this.open_file.Filter = "pakchunk | *.pak";
            // 
            // dragger
            // 
            this.dragger.Fixed = true;
            this.dragger.Horizontal = true;
            this.dragger.TargetControl = this.panel;
            this.dragger.Vertical = true;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.BackColor = System.Drawing.SystemColors.Control;
            this.label_version.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label_version.Location = new System.Drawing.Point(119, 8);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(18, 13);
            this.label_version.TabIndex = 41;
            this.label_version.Text = "v0";
            // 
            // Cookie_Patcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(341, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cookie_Patcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Cookie_Patcher_Shown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_select_pakchunk;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox pakchunk;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_apply;
        private System.Windows.Forms.OpenFileDialog open_file;
        private Bunifu.Framework.UI.BunifuDragControl dragger;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_revert;
        private System.Windows.Forms.Label label_version;
    }
}

