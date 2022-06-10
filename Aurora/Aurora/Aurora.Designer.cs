namespace Aurora
{
    partial class Aurora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aurora));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_build_cookpass = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.button_folder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pakchunk = new Bunifu.UI.WinForms.BunifuTextBox();
            this.button_apply = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.open_packchunk = new System.Windows.Forms.OpenFileDialog();
            this.folder_data = new System.Windows.Forms.FolderBrowserDialog();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.main.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this.panel;
            this.drag.Vertical = true;
            // 
            // panel
            // 
            this.panel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 3;
            this.panel.BorderThickness = 1;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.button_exit);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShowBorders = true;
            this.panel.Size = new System.Drawing.Size(358, 28);
            this.panel.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Aurora";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.BackgroundImage = global::Aurora.Properties.Resources.close;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_exit.Location = new System.Drawing.Point(325, 4);
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
            this.pictureBox1.BackgroundImage = global::Aurora.Properties.Resources.windows;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.main.AutoScroll = true;
            this.main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.main.Controls.Add(this.label3);
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.button_build_cookpass);
            this.main.Controls.Add(this.bunifuGroupBox2);
            this.main.Controls.Add(this.button_folder);
            this.main.Controls.Add(this.label6);
            this.main.Controls.Add(this.bunifuSeparator1);
            this.main.Controls.Add(this.pakchunk);
            this.main.Controls.Add(this.button_apply);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 28);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(358, 422);
            this.main.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(70, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Allows player to get the cookie only";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Build Cookpass";
            // 
            // button_build_cookpass
            // 
            this.button_build_cookpass.BackColor = System.Drawing.Color.Transparent;
            this.button_build_cookpass.Checked = false;
            this.button_build_cookpass.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.button_build_cookpass.CheckedSwitchColor = System.Drawing.SystemColors.Control;
            this.button_build_cookpass.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.button_build_cookpass.Location = new System.Drawing.Point(30, 124);
            this.button_build_cookpass.Name = "button_build_cookpass";
            this.button_build_cookpass.OutlineThickness = 2;
            this.button_build_cookpass.Size = new System.Drawing.Size(34, 19);
            this.button_build_cookpass.TabIndex = 39;
            this.button_build_cookpass.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.button_build_cookpass.UncheckedSwitchColor = System.Drawing.Color.White;
            this.button_build_cookpass.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.button_build_cookpass.CheckedChanged += new System.EventHandler(this.button_remove_ppk_CheckedChanged);
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuGroupBox2.BorderRadius = 20;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.logs);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(12, 184);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(334, 146);
            this.bunifuGroupBox2.TabIndex = 38;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = " Logs ";
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logs.ForeColor = System.Drawing.Color.DimGray;
            this.logs.Location = new System.Drawing.Point(18, 22);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(302, 118);
            this.logs.TabIndex = 36;
            this.logs.Text = "";
            // 
            // button_folder
            // 
            this.button_folder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_folder.BackgroundImage = global::Aurora.Properties.Resources.folder;
            this.button_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_folder.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button_folder.FlatAppearance.BorderSize = 0;
            this.button_folder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.button_folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_folder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_folder.Location = new System.Drawing.Point(48, 69);
            this.button_folder.Margin = new System.Windows.Forms.Padding(1);
            this.button_folder.Name = "button_folder";
            this.button_folder.Padding = new System.Windows.Forms.Padding(10);
            this.button_folder.Size = new System.Drawing.Size(23, 21);
            this.button_folder.TabIndex = 18;
            this.button_folder.UseVisualStyleBackColor = false;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(278, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 35;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(32, 93);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(300, 1);
            this.bunifuSeparator1.TabIndex = 32;
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
            this.pakchunk.Location = new System.Drawing.Point(75, 67);
            this.pakchunk.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.pakchunk.MaxLength = 32767;
            this.pakchunk.MinimumSize = new System.Drawing.Size(1, 1);
            this.pakchunk.Modified = false;
            this.pakchunk.Multiline = false;
            this.pakchunk.Name = "pakchunk";
            stateProperties5.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pakchunk.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.pakchunk.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pakchunk.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.SystemColors.ControlLight;
            stateProperties8.FillColor = System.Drawing.SystemColors.ControlLight;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pakchunk.OnIdleState = stateProperties8;
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
            this.pakchunk.Size = new System.Drawing.Size(257, 23);
            this.pakchunk.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.pakchunk.TabIndex = 27;
            this.pakchunk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pakchunk.TextMarginBottom = 0;
            this.pakchunk.TextMarginLeft = 3;
            this.pakchunk.TextMarginTop = 1;
            this.pakchunk.TextPlaceholder = "Select pakchunk";
            this.pakchunk.UseSystemPasswordChar = false;
            this.pakchunk.WordWrap = true;
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
            this.button_apply.ButtonText = "Build";
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
            this.button_apply.Location = new System.Drawing.Point(140, 387);
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
            this.button_apply.Size = new System.Drawing.Size(77, 23);
            this.button_apply.TabIndex = 25;
            this.button_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_apply.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_apply.TextMarginLeft = 0;
            this.button_apply.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_apply.UseDefaultRadiusAndThickness = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // open_packchunk
            // 
            this.open_packchunk.Filter = "Pakchunk file | *.pak";
            // 
            // Aurora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aurora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl drag;
        private Bunifu.UI.WinForms.BunifuPanel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel main;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox pakchunk;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_apply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog open_packchunk;
        private System.Windows.Forms.Button button_folder;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.FolderBrowserDialog folder_data;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 button_build_cookpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

