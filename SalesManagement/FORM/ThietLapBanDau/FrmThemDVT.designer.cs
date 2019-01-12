namespace SalesManagement.FORM.ThietLapBanDau
{
    partial class FrmThemDVT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemDVT));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuDong = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuThem = new DevComponents.DotNetBar.ButtonX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.label34 = new System.Windows.Forms.Label();
            this.txtGiaBan1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label33 = new System.Windows.Forms.Label();
            this.txtGiaNhap1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 87);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(397, 37);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnThoat);
            this.panelEx2.Controls.Add(this.btnLuuDong);
            this.panelEx2.Controls.Add(this.btnLuuThem);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(40, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(357, 37);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(260, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 29);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Esc - Thoát";
            this.btnThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnLuuDong
            // 
            this.btnLuuDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDong.Image")));
            this.btnLuuDong.Location = new System.Drawing.Point(133, 4);
            this.btnLuuDong.Name = "btnLuuDong";
            this.btnLuuDong.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.btnLuuDong.Size = new System.Drawing.Size(121, 29);
            this.btnLuuDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuDong.TabIndex = 7;
            this.btnLuuDong.Text = "F3 - Lưu và đóng";
            this.btnLuuDong.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThem.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThem.Image")));
            this.btnLuuThem.Location = new System.Drawing.Point(3, 4);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnLuuThem.Size = new System.Drawing.Size(124, 29);
            this.btnLuuThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuThem.TabIndex = 6;
            this.btnLuuThem.Text = "F2 - Lưu và thêm";
            this.btnLuuThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.label1);
            this.panelEx3.Controls.Add(this.label34);
            this.panelEx3.Controls.Add(this.txtGiaBan1);
            this.panelEx3.Controls.Add(this.label33);
            this.panelEx3.Controls.Add(this.txtGiaNhap1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(397, 87);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(12, 48);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 15);
            this.label34.TabIndex = 19;
            this.label34.Text = "Tên đơn vị:";
            // 
            // txtGiaBan1
            // 
            this.txtGiaBan1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGiaBan1.Border.Class = "TextBoxBorder";
            this.txtGiaBan1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaBan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan1.Location = new System.Drawing.Point(80, 46);
            this.txtGiaBan1.Name = "txtGiaBan1";
            this.txtGiaBan1.Size = new System.Drawing.Size(204, 22);
            this.txtGiaBan1.TabIndex = 20;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(15, 20);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 15);
            this.label33.TabIndex = 17;
            this.label33.Text = "Mã đơn vị:";
            // 
            // txtGiaNhap1
            // 
            this.txtGiaNhap1.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.txtGiaNhap1.Border.Class = "TextBoxBorder";
            this.txtGiaNhap1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaNhap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap1.Location = new System.Drawing.Point(81, 18);
            this.txtGiaNhap1.Name = "txtGiaNhap1";
            this.txtGiaNhap1.Size = new System.Drawing.Size(109, 22);
            this.txtGiaNhap1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(290, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "(Chiếc, chai, lọ,...)";
            // 
            // FrmThemDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(397, 124);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemDVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đơn vị tính";
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLuuDong;
        private DevComponents.DotNetBar.ButtonX btnLuuThem;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label34;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaBan1;
        private System.Windows.Forms.Label label33;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaNhap1;
    }
}