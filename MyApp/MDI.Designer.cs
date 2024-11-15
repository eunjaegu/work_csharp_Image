namespace MyApp
{
    partial class MDI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ctrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다시실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화소점ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.동일이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightness = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.반ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selection = new System.Windows.Forms.ToolStripMenuItem();
            this.이진화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.채도변ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기하학처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영역처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엠보싱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.샤프닝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.미디언필터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모폴로지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스토그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스트로그램그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스트레칭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.평활화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엔드인탐색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.화소점ToolStripMenuItem,
            this.기하학처리ToolStripMenuItem,
            this.영역처리ToolStripMenuItem,
            this.모폴로지ToolStripMenuItem,
            this.히스토그램ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ctrlOToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.종료ToolStripMenuItem,
            this.실행취소ToolStripMenuItem,
            this.다시실행ToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 열기ctrlOToolStripMenuItem
            // 
            this.열기ctrlOToolStripMenuItem.Name = "열기ctrlOToolStripMenuItem";
            this.열기ctrlOToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.열기ctrlOToolStripMenuItem.Text = "열기(ctrl+o)";
            this.열기ctrlOToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.실행취소ToolStripMenuItem.Text = "실행 취소";
            // 
            // 다시실행ToolStripMenuItem
            // 
            this.다시실행ToolStripMenuItem.Name = "다시실행ToolStripMenuItem";
            this.다시실행ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.다시실행ToolStripMenuItem.Text = "다시 실행";
            // 
            // 화소점ToolStripMenuItem
            // 
            this.화소점ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동일이미지ToolStripMenuItem,
            this.brightness,
            this.grayScale,
            this.반ToolStripMenuItem,
            this.selection,
            this.이진화ToolStripMenuItem,
            this.채도변ToolStripMenuItem});
            this.화소점ToolStripMenuItem.Name = "화소점ToolStripMenuItem";
            this.화소점ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.화소점ToolStripMenuItem.Text = "화소점";
            // 
            // 동일이미지ToolStripMenuItem
            // 
            this.동일이미지ToolStripMenuItem.Name = "동일이미지ToolStripMenuItem";
            this.동일이미지ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.동일이미지ToolStripMenuItem.Text = "동일 이미지";
            // 
            // brightness
            // 
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(224, 26);
            this.brightness.Text = "밝게/어둡게";
            this.brightness.Click += new System.EventHandler(this.BrightnessToolStripMenuItem_Click);
            // 
            // grayScale
            // 
            this.grayScale.Name = "grayScale";
            this.grayScale.Size = new System.Drawing.Size(224, 26);
            this.grayScale.Text = "그레이 스케일";
            // 
            // 반ToolStripMenuItem
            // 
            this.반ToolStripMenuItem.Name = "반ToolStripMenuItem";
            this.반ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.반ToolStripMenuItem.Text = "반전 이미지";
            this.반ToolStripMenuItem.Click += new System.EventHandler(this.invertColorsToolStripMenuItem_Click);
            // 
            // selection
            // 
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(224, 26);
            this.selection.Text = "반전 선택";
            // 
            // 이진화ToolStripMenuItem
            // 
            this.이진화ToolStripMenuItem.Name = "이진화ToolStripMenuItem";
            this.이진화ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.이진화ToolStripMenuItem.Text = "이진화";
            // 
            // 채도변ToolStripMenuItem
            // 
            this.채도변ToolStripMenuItem.Name = "채도변ToolStripMenuItem";
            this.채도변ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.채도변ToolStripMenuItem.Text = "채도 변";
            // 
            // 기하학처리ToolStripMenuItem
            // 
            this.기하학처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대ToolStripMenuItem,
            this.축소ToolStripMenuItem,
            this.회전ToolStripMenuItem});
            this.기하학처리ToolStripMenuItem.Name = "기하학처리ToolStripMenuItem";
            this.기하학처리ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.기하학처리ToolStripMenuItem.Text = "기하학 처리";
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            this.확대ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.확대ToolStripMenuItem.Text = "확대";
            // 
            // 축소ToolStripMenuItem
            // 
            this.축소ToolStripMenuItem.Name = "축소ToolStripMenuItem";
            this.축소ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.축소ToolStripMenuItem.Text = "축소";
            // 
            // 회전ToolStripMenuItem
            // 
            this.회전ToolStripMenuItem.Name = "회전ToolStripMenuItem";
            this.회전ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.회전ToolStripMenuItem.Text = "회전";
            // 
            // 영역처리ToolStripMenuItem
            // 
            this.영역처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.엠보싱ToolStripMenuItem,
            this.블러링ToolStripMenuItem,
            this.샤프닝ToolStripMenuItem,
            this.미디언필터ToolStripMenuItem});
            this.영역처리ToolStripMenuItem.Name = "영역처리ToolStripMenuItem";
            this.영역처리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.영역처리ToolStripMenuItem.Text = "영역 처리";
            // 
            // 엠보싱ToolStripMenuItem
            // 
            this.엠보싱ToolStripMenuItem.Name = "엠보싱ToolStripMenuItem";
            this.엠보싱ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.엠보싱ToolStripMenuItem.Text = "엠보싱";
            // 
            // 블러링ToolStripMenuItem
            // 
            this.블러링ToolStripMenuItem.Name = "블러링ToolStripMenuItem";
            this.블러링ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.블러링ToolStripMenuItem.Text = "블러링";
            // 
            // 샤프닝ToolStripMenuItem
            // 
            this.샤프닝ToolStripMenuItem.Name = "샤프닝ToolStripMenuItem";
            this.샤프닝ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.샤프닝ToolStripMenuItem.Text = "샤프닝";
            // 
            // 미디언필터ToolStripMenuItem
            // 
            this.미디언필터ToolStripMenuItem.Name = "미디언필터ToolStripMenuItem";
            this.미디언필터ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.미디언필터ToolStripMenuItem.Text = "미디언 필터";
            // 
            // 모폴로지ToolStripMenuItem
            // 
            this.모폴로지ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem});
            this.모폴로지ToolStripMenuItem.Name = "모폴로지ToolStripMenuItem";
            this.모폴로지ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.모폴로지ToolStripMenuItem.Text = "모폴로지";
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.dilationToolStripMenuItem.Text = "Dilation";
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            // 
            // 히스토그램ToolStripMenuItem
            // 
            this.히스토그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.히스트로그램그리기ToolStripMenuItem,
            this.스트레칭ToolStripMenuItem,
            this.평활화ToolStripMenuItem,
            this.엔드인탐색ToolStripMenuItem});
            this.히스토그램ToolStripMenuItem.Name = "히스토그램ToolStripMenuItem";
            this.히스토그램ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.히스토그램ToolStripMenuItem.Text = "히스토그램";
            // 
            // 히스트로그램그리기ToolStripMenuItem
            // 
            this.히스트로그램그리기ToolStripMenuItem.Name = "히스트로그램그리기ToolStripMenuItem";
            this.히스트로그램그리기ToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.히스트로그램그리기ToolStripMenuItem.Text = "히스트로그램 그리기";
            // 
            // 스트레칭ToolStripMenuItem
            // 
            this.스트레칭ToolStripMenuItem.Name = "스트레칭ToolStripMenuItem";
            this.스트레칭ToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.스트레칭ToolStripMenuItem.Text = "스트레칭";
            // 
            // 평활화ToolStripMenuItem
            // 
            this.평활화ToolStripMenuItem.Name = "평활화ToolStripMenuItem";
            this.평활화ToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.평활화ToolStripMenuItem.Text = "평활화";
            // 
            // 엔드인탐색ToolStripMenuItem
            // 
            this.엔드인탐색ToolStripMenuItem.Name = "엔드인탐색ToolStripMenuItem";
            this.엔드인탐색ToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.엔드인탐색ToolStripMenuItem.Text = "엔드-인 탐색";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 407);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MainForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ctrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다시실행ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화소점ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 동일이미지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightness;
        private System.Windows.Forms.ToolStripMenuItem grayScale;
        private System.Windows.Forms.ToolStripMenuItem 기하학처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영역처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모폴로지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스토그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 반ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selection;
        private System.Windows.Forms.ToolStripMenuItem 이진화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 채도변ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엠보싱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 샤프닝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 미디언필터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스트로그램그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스트레칭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 평활화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엔드인탐색ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

