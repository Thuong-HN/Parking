namespace DVES_DEMO
{
    partial class truyxuat
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
            this.txtbienso = new System.Windows.Forms.TextBox();
            this.txtngaygui = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.picvao = new System.Windows.Forms.PictureBox();
            this.picra = new System.Windows.Forms.PictureBox();
            this.lbvao = new System.Windows.Forms.Label();
            this.lbra = new System.Windows.Forms.Label();
            this.picsearch = new System.Windows.Forms.PictureBox();
            this.thoigianvao = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbienso
            // 
            this.txtbienso.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbienso.Location = new System.Drawing.Point(217, 48);
            this.txtbienso.Margin = new System.Windows.Forms.Padding(5);
            this.txtbienso.Name = "txtbienso";
            this.txtbienso.Size = new System.Drawing.Size(164, 29);
            this.txtbienso.TabIndex = 10;
            this.txtbienso.Text = "Biển số";
            this.txtbienso.Enter += new System.EventHandler(this.Txtbienso_Enter);
            this.txtbienso.Leave += new System.EventHandler(this.Txtbienso_Leave);
            // 
            // txtngaygui
            // 
            this.txtngaygui.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtngaygui.Location = new System.Drawing.Point(636, 48);
            this.txtngaygui.Margin = new System.Windows.Forms.Padding(5);
            this.txtngaygui.Name = "txtngaygui";
            this.txtngaygui.ReadOnly = true;
            this.txtngaygui.Size = new System.Drawing.Size(164, 29);
            this.txtngaygui.TabIndex = 1;
            this.txtngaygui.Text = "Ngày gửi";
            this.txtngaygui.Enter += new System.EventHandler(this.Txtngaygui_Enter);
            this.txtngaygui.Leave += new System.EventHandler(this.Txtngaygui_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVES_DEMO.Properties.Resources.logocty;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(440, 484);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(120, 61);
            this.btnxacnhan.TabIndex = 0;
            this.btnxacnhan.Text = "Xác Nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.Btnxacnhan_Click);
            // 
            // picvao
            // 
            this.picvao.Image = global::DVES_DEMO.Properties.Resources.xe_may_2;
            this.picvao.Location = new System.Drawing.Point(130, 224);
            this.picvao.Name = "picvao";
            this.picvao.Size = new System.Drawing.Size(381, 219);
            this.picvao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picvao.TabIndex = 6;
            this.picvao.TabStop = false;
            // 
            // picra
            // 
            this.picra.Image = global::DVES_DEMO.Properties.Resources.xe_may_3;
            this.picra.Location = new System.Drawing.Point(540, 224);
            this.picra.Name = "picra";
            this.picra.Size = new System.Drawing.Size(356, 219);
            this.picra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picra.TabIndex = 7;
            this.picra.TabStop = false;
            // 
            // lbvao
            // 
            this.lbvao.AutoSize = true;
            this.lbvao.Location = new System.Drawing.Point(273, 198);
            this.lbvao.Name = "lbvao";
            this.lbvao.Size = new System.Drawing.Size(110, 21);
            this.lbvao.TabIndex = 8;
            this.lbvao.Text = "Hình ảnh vào";
            // 
            // lbra
            // 
            this.lbra.AutoSize = true;
            this.lbra.Location = new System.Drawing.Point(679, 198);
            this.lbra.Name = "lbra";
            this.lbra.Size = new System.Drawing.Size(97, 21);
            this.lbra.TabIndex = 9;
            this.lbra.Text = "Hình ảnh ra";
            // 
            // picsearch
            // 
            this.picsearch.Image = global::DVES_DEMO.Properties.Resources.search__v1;
            this.picsearch.Location = new System.Drawing.Point(845, 37);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(100, 50);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsearch.TabIndex = 10;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.Picsearch_Click);
            // 
            // thoigianvao
            // 
            this.thoigianvao.Location = new System.Drawing.Point(395, 18);
            this.thoigianvao.MaxSelectionCount = 1;
            this.thoigianvao.Name = "thoigianvao";
            this.thoigianvao.ShowTodayCircle = false;
            this.thoigianvao.TabIndex = 11;
            this.thoigianvao.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Thoigianvao_DateChanged);
            this.thoigianvao.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Thoigianvao_DateChanged);
            // 
            // truyxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 557);
            this.Controls.Add(this.thoigianvao);
            this.Controls.Add(this.picsearch);
            this.Controls.Add(this.lbra);
            this.Controls.Add(this.lbvao);
            this.Controls.Add(this.picra);
            this.Controls.Add(this.picvao);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtngaygui);
            this.Controls.Add(this.txtbienso);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "truyxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truy xuất xe";
            this.Load += new System.EventHandler(this.Truyxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbienso;
        private System.Windows.Forms.TextBox txtngaygui;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.PictureBox picvao;
        private System.Windows.Forms.PictureBox picra;
        private System.Windows.Forms.Label lbvao;
        private System.Windows.Forms.Label lbra;
        private System.Windows.Forms.PictureBox picsearch;
        private System.Windows.Forms.MonthCalendar thoigianvao;
    }
}