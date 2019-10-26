namespace toudack1
{
    partial class black_market_factory
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
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_Buyer = new System.Windows.Forms.TextBox();
            this.number_Industry_seller = new System.Windows.Forms.NumericUpDown();
            this.textBox_seller = new System.Windows.Forms.TextBox();
            this.button_black_market_factory = new System.Windows.Forms.Button();
            this.label_Services_buy = new System.Windows.Forms.Label();
            this.label_Education_buy = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label_Industry_buy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_seller = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Buyer = new System.Windows.Forms.Button();
            this.label_Weapons_buy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Weapons_seller = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Industry_seller = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Services_seller = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.number_Weapons_seller = new System.Windows.Forms.NumericUpDown();
            this.number_Services_seller = new System.Windows.Forms.NumericUpDown();
            this.number_Education_seller = new System.Windows.Forms.NumericUpDown();
            this.label_Education_seller = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.factory_button_Services = new System.Windows.Forms.Button();
            this.factory_button_Industry = new System.Windows.Forms.Button();
            this.number_Education_buy = new System.Windows.Forms.NumericUpDown();
            this.number_Services_buy = new System.Windows.Forms.NumericUpDown();
            this.number_Weapons_buy = new System.Windows.Forms.NumericUpDown();
            this.number_Industry_buy = new System.Windows.Forms.NumericUpDown();
            this.all_price = new System.Windows.Forms.Label();
            this.db_price_industry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.db_price_Education = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.db_price_Weapons = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.db_price_Services = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.number_Industry_seller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Weapons_seller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Services_seller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Education_seller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Education_buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Services_buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Weapons_buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Industry_buy)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label26.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label26.Location = new System.Drawing.Point(747, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 29);
            this.label26.TabIndex = 237;
            this.label26.Text = "فروشنده";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label27.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label27.Location = new System.Drawing.Point(145, 155);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 29);
            this.label27.TabIndex = 236;
            this.label27.Text = "خریدار";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // textBox_Buyer
            // 
            this.textBox_Buyer.BackColor = System.Drawing.Color.White;
            this.textBox_Buyer.Enabled = false;
            this.textBox_Buyer.Location = new System.Drawing.Point(104, 190);
            this.textBox_Buyer.Name = "textBox_Buyer";
            this.textBox_Buyer.Size = new System.Drawing.Size(148, 20);
            this.textBox_Buyer.TabIndex = 232;
            this.textBox_Buyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Buyer.TextChanged += new System.EventHandler(this.textBox_Buyer_TextChanged);
            this.textBox_Buyer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_seller_KeyPress);
            // 
            // number_Industry_seller
            // 
            this.number_Industry_seller.Enabled = false;
            this.number_Industry_seller.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Industry_seller.Location = new System.Drawing.Point(878, 279);
            this.number_Industry_seller.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Industry_seller.Name = "number_Industry_seller";
            this.number_Industry_seller.Size = new System.Drawing.Size(42, 20);
            this.number_Industry_seller.TabIndex = 225;
            this.number_Industry_seller.ValueChanged += new System.EventHandler(this.number_Industry_seller_ValueChanged);
            // 
            // textBox_seller
            // 
            this.textBox_seller.Enabled = false;
            this.textBox_seller.Location = new System.Drawing.Point(700, 193);
            this.textBox_seller.Name = "textBox_seller";
            this.textBox_seller.Size = new System.Drawing.Size(148, 20);
            this.textBox_seller.TabIndex = 220;
            this.textBox_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_seller.TextChanged += new System.EventHandler(this.textBox_seller_TextChanged);
            this.textBox_seller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_seller_KeyDown);
            this.textBox_seller.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_seller_KeyPress);
            this.textBox_seller.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_seller_KeyUp);
            // 
            // button_black_market_factory
            // 
            this.button_black_market_factory.Font = new System.Drawing.Font("B Titr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_black_market_factory.Location = new System.Drawing.Point(352, 307);
            this.button_black_market_factory.Name = "button_black_market_factory";
            this.button_black_market_factory.Size = new System.Drawing.Size(240, 56);
            this.button_black_market_factory.TabIndex = 219;
            this.button_black_market_factory.Text = "ثبت";
            this.button_black_market_factory.UseVisualStyleBackColor = true;
            this.button_black_market_factory.Click += new System.EventHandler(this.button_black_market_factory_Click);
            // 
            // label_Services_buy
            // 
            this.label_Services_buy.AutoSize = true;
            this.label_Services_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Services_buy.Enabled = false;
            this.label_Services_buy.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Services_buy.Location = new System.Drawing.Point(119, 301);
            this.label_Services_buy.Name = "label_Services_buy";
            this.label_Services_buy.Size = new System.Drawing.Size(29, 42);
            this.label_Services_buy.TabIndex = 217;
            this.label_Services_buy.Text = "0";
            this.label_Services_buy.Click += new System.EventHandler(this.label_Services_buy_Click);
            // 
            // label_Education_buy
            // 
            this.label_Education_buy.AutoSize = true;
            this.label_Education_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Education_buy.Enabled = false;
            this.label_Education_buy.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Education_buy.Location = new System.Drawing.Point(45, 301);
            this.label_Education_buy.Name = "label_Education_buy";
            this.label_Education_buy.Size = new System.Drawing.Size(29, 42);
            this.label_Education_buy.TabIndex = 214;
            this.label_Education_buy.Text = "0";
            this.label_Education_buy.Click += new System.EventHandler(this.label_Education_buy_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label50.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label50.Location = new System.Drawing.Point(766, 33);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(177, 42);
            this.label50.TabIndex = 208;
            this.label50.Text = "بازار سیاه صادراتی";
            this.label50.Click += new System.EventHandler(this.label50_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label51.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label51.Location = new System.Drawing.Point(32, 239);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(57, 29);
            this.label51.TabIndex = 207;
            this.label51.Text = "آموزش";
            this.label51.Click += new System.EventHandler(this.label51_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label52.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label52.Location = new System.Drawing.Point(104, 239);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 29);
            this.label52.TabIndex = 206;
            this.label52.Text = "خدمات";
            this.label52.Click += new System.EventHandler(this.label52_Click);
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label56.Location = new System.Drawing.Point(12, 75);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(931, 308);
            this.label56.TabIndex = 235;
            this.label56.Click += new System.EventHandler(this.label56_Click);
            // 
            // label_Industry_buy
            // 
            this.label_Industry_buy.AutoSize = true;
            this.label_Industry_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Industry_buy.Enabled = false;
            this.label_Industry_buy.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Industry_buy.Location = new System.Drawing.Point(270, 304);
            this.label_Industry_buy.Name = "label_Industry_buy";
            this.label_Industry_buy.Size = new System.Drawing.Size(29, 42);
            this.label_Industry_buy.TabIndex = 245;
            this.label_Industry_buy.Text = "0";
            this.label_Industry_buy.Click += new System.EventHandler(this.label_Industry_buy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(261, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 244;
            this.label2.Text = "صنعت";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 246;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_seller
            // 
            this.button_seller.Enabled = false;
            this.button_seller.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_seller.Image = global::toudack1.Properties.Resources.barcod;
            this.button_seller.Location = new System.Drawing.Point(634, 185);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(60, 31);
            this.button_seller.TabIndex = 222;
            this.button_seller.UseVisualStyleBackColor = true;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(255, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 247;
            this.label4.Text = "کد شخص";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(854, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 248;
            this.label5.Text = "کد شخص";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_Buyer
            // 
            this.button_Buyer.Enabled = false;
            this.button_Buyer.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_Buyer.Image = global::toudack1.Properties.Resources.barcod;
            this.button_Buyer.Location = new System.Drawing.Point(38, 182);
            this.button_Buyer.Name = "button_Buyer";
            this.button_Buyer.Size = new System.Drawing.Size(60, 31);
            this.button_Buyer.TabIndex = 249;
            this.button_Buyer.UseVisualStyleBackColor = true;
            this.button_Buyer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Weapons_buy
            // 
            this.label_Weapons_buy.AutoSize = true;
            this.label_Weapons_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Weapons_buy.Enabled = false;
            this.label_Weapons_buy.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Weapons_buy.Location = new System.Drawing.Point(195, 304);
            this.label_Weapons_buy.Name = "label_Weapons_buy";
            this.label_Weapons_buy.Size = new System.Drawing.Size(29, 42);
            this.label_Weapons_buy.TabIndex = 251;
            this.label_Weapons_buy.Text = "0";
            this.label_Weapons_buy.Click += new System.EventHandler(this.label_Weapons_buy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(186, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 29);
            this.label7.TabIndex = 250;
            this.label7.Text = "سلاح";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_Weapons_seller
            // 
            this.label_Weapons_seller.AutoSize = true;
            this.label_Weapons_seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Weapons_seller.Enabled = false;
            this.label_Weapons_seller.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Weapons_seller.Location = new System.Drawing.Point(800, 307);
            this.label_Weapons_seller.Name = "label_Weapons_seller";
            this.label_Weapons_seller.Size = new System.Drawing.Size(29, 42);
            this.label_Weapons_seller.TabIndex = 267;
            this.label_Weapons_seller.Text = "0";
            this.label_Weapons_seller.Click += new System.EventHandler(this.label_Weapons_seller_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(798, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 29);
            this.label9.TabIndex = 266;
            this.label9.Text = "سلاح";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label_Industry_seller
            // 
            this.label_Industry_seller.AutoSize = true;
            this.label_Industry_seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Industry_seller.Enabled = false;
            this.label_Industry_seller.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Industry_seller.Location = new System.Drawing.Point(884, 307);
            this.label_Industry_seller.Name = "label_Industry_seller";
            this.label_Industry_seller.Size = new System.Drawing.Size(29, 42);
            this.label_Industry_seller.TabIndex = 265;
            this.label_Industry_seller.Text = "0";
            this.label_Industry_seller.Click += new System.EventHandler(this.label_Industry_seller_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(873, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 29);
            this.label11.TabIndex = 264;
            this.label11.Text = "صنعت";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label_Services_seller
            // 
            this.label_Services_seller.AutoSize = true;
            this.label_Services_seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Services_seller.Enabled = false;
            this.label_Services_seller.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Services_seller.Location = new System.Drawing.Point(729, 304);
            this.label_Services_seller.Name = "label_Services_seller";
            this.label_Services_seller.Size = new System.Drawing.Size(29, 42);
            this.label_Services_seller.TabIndex = 260;
            this.label_Services_seller.Text = "0";
            this.label_Services_seller.Click += new System.EventHandler(this.label_Services_seller_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label38.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label38.Location = new System.Drawing.Point(717, 240);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 29);
            this.label38.TabIndex = 255;
            this.label38.Text = "خدمات";
            this.label38.Click += new System.EventHandler(this.label38_Click);
            // 
            // number_Weapons_seller
            // 
            this.number_Weapons_seller.Enabled = false;
            this.number_Weapons_seller.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Weapons_seller.Location = new System.Drawing.Point(799, 279);
            this.number_Weapons_seller.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Weapons_seller.Name = "number_Weapons_seller";
            this.number_Weapons_seller.Size = new System.Drawing.Size(42, 20);
            this.number_Weapons_seller.TabIndex = 268;
            this.number_Weapons_seller.ValueChanged += new System.EventHandler(this.number_Weapons_seller_ValueChanged);
            // 
            // number_Services_seller
            // 
            this.number_Services_seller.Enabled = false;
            this.number_Services_seller.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Services_seller.Location = new System.Drawing.Point(723, 281);
            this.number_Services_seller.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Services_seller.Name = "number_Services_seller";
            this.number_Services_seller.Size = new System.Drawing.Size(42, 20);
            this.number_Services_seller.TabIndex = 272;
            this.number_Services_seller.ValueChanged += new System.EventHandler(this.number_Services_seller_ValueChanged);
            // 
            // number_Education_seller
            // 
            this.number_Education_seller.Enabled = false;
            this.number_Education_seller.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Education_seller.Location = new System.Drawing.Point(642, 281);
            this.number_Education_seller.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Education_seller.Name = "number_Education_seller";
            this.number_Education_seller.Size = new System.Drawing.Size(42, 20);
            this.number_Education_seller.TabIndex = 275;
            this.number_Education_seller.ValueChanged += new System.EventHandler(this.number_Education_seller_ValueChanged);
            // 
            // label_Education_seller
            // 
            this.label_Education_seller.AutoSize = true;
            this.label_Education_seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_Education_seller.Enabled = false;
            this.label_Education_seller.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Education_seller.Location = new System.Drawing.Point(648, 304);
            this.label_Education_seller.Name = "label_Education_seller";
            this.label_Education_seller.Size = new System.Drawing.Size(29, 42);
            this.label_Education_seller.TabIndex = 274;
            this.label_Education_seller.Text = "0";
            this.label_Education_seller.Click += new System.EventHandler(this.label_Education_seller_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(636, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 29);
            this.label13.TabIndex = 273;
            this.label13.Text = "آموزش";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // factory_button_Services
            // 
            this.factory_button_Services.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.factory_button_Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factory_button_Services.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.factory_button_Services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.factory_button_Services.Location = new System.Drawing.Point(479, 101);
            this.factory_button_Services.Name = "factory_button_Services";
            this.factory_button_Services.Size = new System.Drawing.Size(75, 34);
            this.factory_button_Services.TabIndex = 277;
            this.factory_button_Services.Text = "فروشنده";
            this.factory_button_Services.UseVisualStyleBackColor = false;
            this.factory_button_Services.Click += new System.EventHandler(this.factory_button_Services_Click);
            // 
            // factory_button_Industry
            // 
            this.factory_button_Industry.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.factory_button_Industry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factory_button_Industry.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.factory_button_Industry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.factory_button_Industry.Location = new System.Drawing.Point(375, 101);
            this.factory_button_Industry.Name = "factory_button_Industry";
            this.factory_button_Industry.Size = new System.Drawing.Size(75, 34);
            this.factory_button_Industry.TabIndex = 276;
            this.factory_button_Industry.Text = "خریدار";
            this.factory_button_Industry.UseVisualStyleBackColor = false;
            this.factory_button_Industry.Click += new System.EventHandler(this.factory_button_Industry_Click);
            // 
            // number_Education_buy
            // 
            this.number_Education_buy.Enabled = false;
            this.number_Education_buy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Education_buy.Location = new System.Drawing.Point(33, 281);
            this.number_Education_buy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Education_buy.Name = "number_Education_buy";
            this.number_Education_buy.Size = new System.Drawing.Size(42, 20);
            this.number_Education_buy.TabIndex = 281;
            this.number_Education_buy.ValueChanged += new System.EventHandler(this.number_Education_buy_ValueChanged);
            // 
            // number_Services_buy
            // 
            this.number_Services_buy.Enabled = false;
            this.number_Services_buy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Services_buy.Location = new System.Drawing.Point(109, 281);
            this.number_Services_buy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Services_buy.Name = "number_Services_buy";
            this.number_Services_buy.Size = new System.Drawing.Size(42, 20);
            this.number_Services_buy.TabIndex = 280;
            this.number_Services_buy.ValueChanged += new System.EventHandler(this.number_Services_buy_ValueChanged);
            // 
            // number_Weapons_buy
            // 
            this.number_Weapons_buy.Enabled = false;
            this.number_Weapons_buy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Weapons_buy.Location = new System.Drawing.Point(188, 279);
            this.number_Weapons_buy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Weapons_buy.Name = "number_Weapons_buy";
            this.number_Weapons_buy.Size = new System.Drawing.Size(42, 20);
            this.number_Weapons_buy.TabIndex = 279;
            this.number_Weapons_buy.ValueChanged += new System.EventHandler(this.number_Weapons_buy_ValueChanged);
            // 
            // number_Industry_buy
            // 
            this.number_Industry_buy.Enabled = false;
            this.number_Industry_buy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.number_Industry_buy.Location = new System.Drawing.Point(269, 279);
            this.number_Industry_buy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_Industry_buy.Name = "number_Industry_buy";
            this.number_Industry_buy.Size = new System.Drawing.Size(42, 20);
            this.number_Industry_buy.TabIndex = 278;
            // 
            // all_price
            // 
            this.all_price.AutoSize = true;
            this.all_price.Location = new System.Drawing.Point(456, 200);
            this.all_price.Name = "all_price";
            this.all_price.Size = new System.Drawing.Size(23, 13);
            this.all_price.TabIndex = 329;
            this.all_price.Text = "****";
            this.all_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // db_price_industry
            // 
            this.db_price_industry.AutoSize = true;
            this.db_price_industry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.db_price_industry.Enabled = false;
            this.db_price_industry.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.db_price_industry.Location = new System.Drawing.Point(294, 42);
            this.db_price_industry.Name = "db_price_industry";
            this.db_price_industry.Size = new System.Drawing.Size(29, 42);
            this.db_price_industry.TabIndex = 334;
            this.db_price_industry.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(329, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 74);
            this.label6.TabIndex = 339;
            this.label6.Text = "قیمت بسته های صادراتی";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // db_price_Education
            // 
            this.db_price_Education.AutoSize = true;
            this.db_price_Education.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.db_price_Education.Enabled = false;
            this.db_price_Education.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.db_price_Education.Location = new System.Drawing.Point(37, 39);
            this.db_price_Education.Name = "db_price_Education";
            this.db_price_Education.Size = new System.Drawing.Size(29, 42);
            this.db_price_Education.TabIndex = 338;
            this.db_price_Education.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(26, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 29);
            this.label10.TabIndex = 337;
            this.label10.Text = "آموزش";
            // 
            // db_price_Weapons
            // 
            this.db_price_Weapons.AutoSize = true;
            this.db_price_Weapons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.db_price_Weapons.Enabled = false;
            this.db_price_Weapons.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.db_price_Weapons.Location = new System.Drawing.Point(205, 42);
            this.db_price_Weapons.Name = "db_price_Weapons";
            this.db_price_Weapons.Size = new System.Drawing.Size(29, 42);
            this.db_price_Weapons.TabIndex = 336;
            this.db_price_Weapons.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label24.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label24.Location = new System.Drawing.Point(204, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 29);
            this.label24.TabIndex = 335;
            this.label24.Text = "سلاح";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label25.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label25.Location = new System.Drawing.Point(284, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 29);
            this.label25.TabIndex = 333;
            this.label25.Text = "صنعت";
            // 
            // db_price_Services
            // 
            this.db_price_Services.AutoSize = true;
            this.db_price_Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.db_price_Services.Enabled = false;
            this.db_price_Services.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.db_price_Services.Location = new System.Drawing.Point(124, 39);
            this.db_price_Services.Name = "db_price_Services";
            this.db_price_Services.Size = new System.Drawing.Size(29, 42);
            this.db_price_Services.TabIndex = 332;
            this.db_price_Services.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(113, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 29);
            this.label15.TabIndex = 331;
            this.label15.Text = "خدمات";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(420, 75);
            this.label16.TabIndex = 330;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // black_market_factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 401);
            this.Controls.Add(this.db_price_industry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.db_price_Education);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.db_price_Weapons);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.db_price_Services);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.all_price);
            this.Controls.Add(this.number_Education_buy);
            this.Controls.Add(this.number_Services_buy);
            this.Controls.Add(this.number_Weapons_buy);
            this.Controls.Add(this.number_Industry_buy);
            this.Controls.Add(this.factory_button_Services);
            this.Controls.Add(this.factory_button_Industry);
            this.Controls.Add(this.number_Education_seller);
            this.Controls.Add(this.label_Education_seller);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.number_Services_seller);
            this.Controls.Add(this.number_Weapons_seller);
            this.Controls.Add(this.label_Weapons_seller);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_Industry_seller);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_Services_seller);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label_Weapons_buy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Buyer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Industry_buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox_Buyer);
            this.Controls.Add(this.number_Industry_seller);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.textBox_seller);
            this.Controls.Add(this.button_black_market_factory);
            this.Controls.Add(this.label_Services_buy);
            this.Controls.Add(this.label_Education_buy);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label56);
            this.Name = "black_market_factory";
            this.Text = "black_market";
            ((System.ComponentModel.ISupportInitialize)(this.number_Industry_seller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Weapons_seller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Services_seller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Education_seller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Education_buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Services_buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Weapons_buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Industry_buy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_Buyer;
        private System.Windows.Forms.NumericUpDown number_Industry_seller;
        private System.Windows.Forms.TextBox textBox_seller;
        private System.Windows.Forms.Button button_black_market_factory;
        private System.Windows.Forms.Label label_Services_buy;
        private System.Windows.Forms.Label label_Education_buy;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label_Industry_buy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Buyer;
        private System.Windows.Forms.Label label_Weapons_buy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Weapons_seller;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Industry_seller;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Services_seller;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown number_Weapons_seller;
        private System.Windows.Forms.NumericUpDown number_Services_seller;
        private System.Windows.Forms.NumericUpDown number_Education_seller;
        private System.Windows.Forms.Label label_Education_seller;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button factory_button_Services;
        private System.Windows.Forms.Button factory_button_Industry;
        private System.Windows.Forms.NumericUpDown number_Education_buy;
        private System.Windows.Forms.NumericUpDown number_Services_buy;
        private System.Windows.Forms.NumericUpDown number_Weapons_buy;
        private System.Windows.Forms.NumericUpDown number_Industry_buy;
        private System.Windows.Forms.Label all_price;
        private System.Windows.Forms.Label db_price_industry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label db_price_Education;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label db_price_Weapons;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label db_price_Services;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
    }
}