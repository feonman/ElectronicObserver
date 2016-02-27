namespace ElectronicObserver.Window {
	partial class FormBattle {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TableBottom = new System.Windows.Forms.TableLayoutPanel();
            this.ToolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.BaseLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TableTop = new System.Windows.Forms.TableLayoutPanel();
            this.FormationFriend = new ElectronicObserver.Window.Control.ImageLabel();
            this.Formation = new ElectronicObserver.Window.Control.ImageLabel();
            this.FormationEnemy = new ElectronicObserver.Window.Control.ImageLabel();
            this.AirStage2Friend = new ElectronicObserver.Window.Control.ImageLabel();
            this.AACutin = new ElectronicObserver.Window.Control.ImageLabel();
            this.AirStage2Enemy = new ElectronicObserver.Window.Control.ImageLabel();
            this.AirStage1Enemy = new ElectronicObserver.Window.Control.ImageLabel();
            this.SearchingFriend = new ElectronicObserver.Window.Control.ImageLabel();
            this.Searching = new ElectronicObserver.Window.Control.ImageLabel();
            this.AirStage1Friend = new ElectronicObserver.Window.Control.ImageLabel();
            this.SearchingEnemy = new ElectronicObserver.Window.Control.ImageLabel();
            this.AirSuperiority = new ElectronicObserver.Window.Control.ImageLabel();
            this.FleetFriend = new ElectronicObserver.Window.Control.ImageLabel();
            this.DamageFriend = new ElectronicObserver.Window.Control.ImageLabel();
            this.WinRank = new ElectronicObserver.Window.Control.ImageLabel();
            this.DamageEnemy = new ElectronicObserver.Window.Control.ImageLabel();
            this.FleetCombined = new ElectronicObserver.Window.Control.ImageLabel();
            this.FleetEnemy = new ElectronicObserver.Window.Control.ImageLabel();
            this.TableBottom.SuspendLayout();
            this.BaseLayoutPanel.SuspendLayout();
            this.TableTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableBottom
            // 
            this.TableBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableBottom.AutoSize = true;
            this.TableBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableBottom.ColumnCount = 3;
            this.TableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableBottom.Controls.Add(this.FleetFriend, 0, 0);
            this.TableBottom.Controls.Add(this.DamageFriend, 0, 7);
            this.TableBottom.Controls.Add(this.WinRank, 1, 7);
            this.TableBottom.Controls.Add(this.DamageEnemy, 2, 7);
            this.TableBottom.Controls.Add(this.FleetCombined, 1, 0);
            this.TableBottom.Controls.Add(this.FleetEnemy, 2, 0);
            this.TableBottom.Location = new System.Drawing.Point(3, 94);
            this.TableBottom.Name = "TableBottom";
            this.TableBottom.RowCount = 8;
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableBottom.Size = new System.Drawing.Size(222, 176);
            this.TableBottom.TabIndex = 1;
            this.TableBottom.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableBottom_CellPaint);
            // 
            // ToolTipInfo
            // 
            this.ToolTipInfo.AutoPopDelay = 30000;
            this.ToolTipInfo.InitialDelay = 500;
            this.ToolTipInfo.ReshowDelay = 100;
            this.ToolTipInfo.ShowAlways = true;
            // 
            // BaseLayoutPanel
            // 
            this.BaseLayoutPanel.Controls.Add(this.TableTop);
            this.BaseLayoutPanel.Controls.Add(this.TableBottom);
            this.BaseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BaseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BaseLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BaseLayoutPanel.Name = "BaseLayoutPanel";
            this.BaseLayoutPanel.Size = new System.Drawing.Size(300, 300);
            this.BaseLayoutPanel.TabIndex = 2;
            // 
            // TableTop
            // 
            this.TableTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableTop.AutoSize = true;
            this.TableTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableTop.ColumnCount = 3;
            this.TableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableTop.Controls.Add(this.FormationFriend, 0, 0);
            this.TableTop.Controls.Add(this.Formation, 1, 0);
            this.TableTop.Controls.Add(this.FormationEnemy, 2, 0);
            this.TableTop.Controls.Add(this.AirStage2Friend, 0, 3);
            this.TableTop.Controls.Add(this.AACutin, 1, 3);
            this.TableTop.Controls.Add(this.AirStage2Enemy, 2, 3);
            this.TableTop.Controls.Add(this.AirStage1Enemy, 2, 2);
            this.TableTop.Controls.Add(this.SearchingFriend, 0, 1);
            this.TableTop.Controls.Add(this.Searching, 1, 1);
            this.TableTop.Controls.Add(this.AirStage1Friend, 0, 2);
            this.TableTop.Controls.Add(this.SearchingEnemy, 2, 1);
            this.TableTop.Controls.Add(this.AirSuperiority, 1, 2);
            this.TableTop.Location = new System.Drawing.Point(3, 3);
            this.TableTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TableTop.Name = "TableTop";
            this.TableTop.RowCount = 4;
            this.TableTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableTop.Size = new System.Drawing.Size(222, 88);
            this.TableTop.TabIndex = 18;
            this.TableTop.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableTop_CellPaint);
            // 
            // FormationFriend
            // 
            this.FormationFriend.BackColor = System.Drawing.Color.Transparent;
            this.FormationFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormationFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormationFriend.Location = new System.Drawing.Point(3, 3);
            this.FormationFriend.Name = "FormationFriend";
            this.FormationFriend.Size = new System.Drawing.Size(67, 16);
            this.FormationFriend.TabIndex = 0;
            this.FormationFriend.Text = "味方陣形";
            this.FormationFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Formation
            // 
            this.Formation.BackColor = System.Drawing.Color.Transparent;
            this.Formation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formation.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Formation.Location = new System.Drawing.Point(76, 3);
            this.Formation.Name = "Formation";
            this.Formation.Size = new System.Drawing.Size(67, 16);
            this.Formation.TabIndex = 2;
            this.Formation.Text = "交戦形態";
            this.Formation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormationEnemy
            // 
            this.FormationEnemy.BackColor = System.Drawing.Color.Transparent;
            this.FormationEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormationEnemy.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormationEnemy.Location = new System.Drawing.Point(149, 3);
            this.FormationEnemy.Name = "FormationEnemy";
            this.FormationEnemy.Size = new System.Drawing.Size(70, 16);
            this.FormationEnemy.TabIndex = 2;
            this.FormationEnemy.Text = "敵陣形";
            this.FormationEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirStage2Friend
            // 
            this.AirStage2Friend.BackColor = System.Drawing.Color.Transparent;
            this.AirStage2Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStage2Friend.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirStage2Friend.Location = new System.Drawing.Point(3, 69);
            this.AirStage2Friend.Name = "AirStage2Friend";
            this.AirStage2Friend.Size = new System.Drawing.Size(67, 16);
            this.AirStage2Friend.TabIndex = 5;
            this.AirStage2Friend.Text = "撃墜";
            this.AirStage2Friend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AACutin
            // 
            this.AACutin.BackColor = System.Drawing.Color.Transparent;
            this.AACutin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AACutin.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AACutin.Location = new System.Drawing.Point(76, 69);
            this.AACutin.Name = "AACutin";
            this.AACutin.Size = new System.Drawing.Size(67, 16);
            this.AACutin.TabIndex = 4;
            this.AACutin.Text = "対空";
            this.AACutin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirStage2Enemy
            // 
            this.AirStage2Enemy.BackColor = System.Drawing.Color.Transparent;
            this.AirStage2Enemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStage2Enemy.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirStage2Enemy.Location = new System.Drawing.Point(149, 69);
            this.AirStage2Enemy.Name = "AirStage2Enemy";
            this.AirStage2Enemy.Size = new System.Drawing.Size(70, 16);
            this.AirStage2Enemy.TabIndex = 6;
            this.AirStage2Enemy.Text = "撃墜";
            this.AirStage2Enemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirStage1Enemy
            // 
            this.AirStage1Enemy.BackColor = System.Drawing.Color.Transparent;
            this.AirStage1Enemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStage1Enemy.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirStage1Enemy.Location = new System.Drawing.Point(149, 47);
            this.AirStage1Enemy.Name = "AirStage1Enemy";
            this.AirStage1Enemy.Size = new System.Drawing.Size(70, 16);
            this.AirStage1Enemy.TabIndex = 5;
            this.AirStage1Enemy.Text = "撃墜";
            this.AirStage1Enemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchingFriend
            // 
            this.SearchingFriend.BackColor = System.Drawing.Color.Transparent;
            this.SearchingFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchingFriend.Location = new System.Drawing.Point(3, 24);
            this.SearchingFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchingFriend.Name = "SearchingFriend";
            this.SearchingFriend.Size = new System.Drawing.Size(67, 18);
            this.SearchingFriend.TabIndex = 2;
            this.SearchingFriend.Text = "味方索敵";
            // 
            // Searching
            // 
            this.Searching.BackColor = System.Drawing.Color.Transparent;
            this.Searching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Searching.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Searching.Location = new System.Drawing.Point(76, 25);
            this.Searching.Name = "Searching";
            this.Searching.Size = new System.Drawing.Size(67, 16);
            this.Searching.TabIndex = 2;
            this.Searching.Text = "索敵";
            this.Searching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirStage1Friend
            // 
            this.AirStage1Friend.BackColor = System.Drawing.Color.Transparent;
            this.AirStage1Friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStage1Friend.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirStage1Friend.Location = new System.Drawing.Point(3, 47);
            this.AirStage1Friend.Name = "AirStage1Friend";
            this.AirStage1Friend.Size = new System.Drawing.Size(67, 16);
            this.AirStage1Friend.TabIndex = 4;
            this.AirStage1Friend.Text = "撃墜";
            this.AirStage1Friend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchingEnemy
            // 
            this.SearchingEnemy.BackColor = System.Drawing.Color.Transparent;
            this.SearchingEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchingEnemy.Location = new System.Drawing.Point(149, 24);
            this.SearchingEnemy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchingEnemy.Name = "SearchingEnemy";
            this.SearchingEnemy.Size = new System.Drawing.Size(70, 18);
            this.SearchingEnemy.TabIndex = 2;
            this.SearchingEnemy.Text = "敵索敵";
            // 
            // AirSuperiority
            // 
            this.AirSuperiority.BackColor = System.Drawing.Color.Transparent;
            this.AirSuperiority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirSuperiority.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirSuperiority.Location = new System.Drawing.Point(76, 47);
            this.AirSuperiority.Name = "AirSuperiority";
            this.AirSuperiority.Size = new System.Drawing.Size(67, 16);
            this.AirSuperiority.TabIndex = 4;
            this.AirSuperiority.Text = "制空権";
            this.AirSuperiority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FleetFriend
            // 
            this.FleetFriend.BackColor = System.Drawing.Color.Transparent;
            this.FleetFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FleetFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FleetFriend.Location = new System.Drawing.Point(3, 3);
            this.FleetFriend.Name = "FleetFriend";
            this.FleetFriend.Size = new System.Drawing.Size(67, 16);
            this.FleetFriend.TabIndex = 5;
            this.FleetFriend.Text = "自軍艦隊";
            this.FleetFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DamageFriend
            // 
            this.DamageFriend.BackColor = System.Drawing.Color.Transparent;
            this.DamageFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DamageFriend.Location = new System.Drawing.Point(3, 157);
            this.DamageFriend.Name = "DamageFriend";
            this.DamageFriend.Size = new System.Drawing.Size(67, 16);
            this.DamageFriend.TabIndex = 5;
            this.DamageFriend.Text = "損害率";
            this.DamageFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinRank
            // 
            this.WinRank.BackColor = System.Drawing.Color.Transparent;
            this.WinRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinRank.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinRank.Location = new System.Drawing.Point(76, 157);
            this.WinRank.Name = "WinRank";
            this.WinRank.Size = new System.Drawing.Size(67, 16);
            this.WinRank.TabIndex = 14;
            this.WinRank.Text = "戦績判定";
            this.WinRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DamageEnemy
            // 
            this.DamageEnemy.BackColor = System.Drawing.Color.Transparent;
            this.DamageEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageEnemy.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DamageEnemy.Location = new System.Drawing.Point(149, 157);
            this.DamageEnemy.Name = "DamageEnemy";
            this.DamageEnemy.Size = new System.Drawing.Size(70, 16);
            this.DamageEnemy.TabIndex = 15;
            this.DamageEnemy.Text = "損害率";
            this.DamageEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FleetCombined
            // 
            this.FleetCombined.BackColor = System.Drawing.Color.Transparent;
            this.FleetCombined.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FleetCombined.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FleetCombined.Location = new System.Drawing.Point(76, 3);
            this.FleetCombined.Name = "FleetCombined";
            this.FleetCombined.Size = new System.Drawing.Size(67, 16);
            this.FleetCombined.TabIndex = 16;
            this.FleetCombined.Text = "随伴艦隊";
            this.FleetCombined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FleetEnemy
            // 
            this.FleetEnemy.BackColor = System.Drawing.Color.Transparent;
            this.FleetEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FleetEnemy.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FleetEnemy.Location = new System.Drawing.Point(149, 3);
            this.FleetEnemy.Name = "FleetEnemy";
            this.FleetEnemy.Size = new System.Drawing.Size(70, 16);
            this.FleetEnemy.TabIndex = 17;
            this.FleetEnemy.Text = "敵軍艦隊";
            this.FleetEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBattle
            // 
            this.AutoHidePortion = 150D;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.BaseLayoutPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HideOnClose = true;
            this.Name = "FormBattle";
            this.Text = "戦闘";
            this.Load += new System.EventHandler(this.FormBattle_Load);
            this.TableBottom.ResumeLayout(false);
            this.TableBottom.PerformLayout();
            this.BaseLayoutPanel.ResumeLayout(false);
            this.BaseLayoutPanel.PerformLayout();
            this.TableTop.ResumeLayout(false);
            this.TableTop.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableBottom;
		private Control.ImageLabel AirStage1Enemy;
		private Control.ImageLabel AirStage2Friend;
		private Control.ImageLabel AirStage1Friend;
		private Control.ImageLabel AirSuperiority;
		private Control.ImageLabel AACutin;
		private Control.ImageLabel SearchingEnemy;
		private Control.ImageLabel Searching;
		private Control.ImageLabel SearchingFriend;
		private Control.ImageLabel FormationEnemy;
		private Control.ImageLabel FormationFriend;
		private Control.ImageLabel Formation;
		private Control.ImageLabel AirStage2Enemy;
		private Control.ImageLabel FleetFriend;
		private Control.ImageLabel DamageFriend;
		private Control.ImageLabel WinRank;
		private Control.ImageLabel DamageEnemy;
		private Control.ImageLabel FleetCombined;
		private Control.ImageLabel FleetEnemy;
		private System.Windows.Forms.ToolTip ToolTipInfo;
		private System.Windows.Forms.FlowLayoutPanel BaseLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel TableTop;
	}
}