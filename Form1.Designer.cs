namespace OpenCVSharp_demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnFlipOpenImage = new System.Windows.Forms.Button();
            this.rbFlipXy = new System.Windows.Forms.RadioButton();
            this.rbFlipY = new System.Windows.Forms.RadioButton();
            this.rbFlipX = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColorSpaceOpenImage = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbColorSpaceFloat = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceSigned = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceUnsigned = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbColorSpaceBit64 = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceBit32 = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceBit16 = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceBit8 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbColorSpaceChangeBGR2Luv = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2Lab = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2HSV = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2YCrCb = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2XYZ = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2BGR565 = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeGRAY2RGB = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2GRAY = new System.Windows.Forms.RadioButton();
            this.rbColorSpaceChangeBGR2BGRA = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSpaceColorChannel4 = new System.Windows.Forms.RadioButton();
            this.rbSpaceColorChannel3 = new System.Windows.Forms.RadioButton();
            this.rbSpaceColorChannel2 = new System.Windows.Forms.RadioButton();
            this.rbSpaceColorChannel1 = new System.Windows.Forms.RadioButton();
            this.btnAvFileOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIgnoreOrientation = new System.Windows.Forms.RadioButton();
            this.rbReducedColor8 = new System.Windows.Forms.RadioButton();
            this.rbReducedGrayscale8 = new System.Windows.Forms.RadioButton();
            this.rbReducedColor4 = new System.Windows.Forms.RadioButton();
            this.rbReducedGrayscale4 = new System.Windows.Forms.RadioButton();
            this.rbReducedColor2 = new System.Windows.Forms.RadioButton();
            this.rbReducedGrayscale2 = new System.Windows.Forms.RadioButton();
            this.rbLoadGdal = new System.Windows.Forms.RadioButton();
            this.rbAnyColor = new System.Windows.Forms.RadioButton();
            this.rbAnyDepth = new System.Windows.Forms.RadioButton();
            this.rbColor = new System.Windows.Forms.RadioButton();
            this.rbGrayscale = new System.Windows.Forms.RadioButton();
            this.rbUnchanged = new System.Windows.Forms.RadioButton();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnZoomWithOption = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbZoomHeight = new System.Windows.Forms.TextBox();
            this.tbZoomWidth = new System.Windows.Forms.TextBox();
            this.rbIsolated = new System.Windows.Forms.RadioButton();
            this.rbTransparent = new System.Windows.Forms.RadioButton();
            this.rbReflect101 = new System.Windows.Forms.RadioButton();
            this.rbWrap = new System.Windows.Forms.RadioButton();
            this.rbReflect = new System.Windows.Forms.RadioButton();
            this.rbReplicate = new System.Windows.Forms.RadioButton();
            this.rbConstant = new System.Windows.Forms.RadioButton();
            this.btnZoom = new System.Windows.Forms.Button();
            this.rbZoomOut = new System.Windows.Forms.RadioButton();
            this.rbZoomIn = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnResizeOpenImage = new System.Windows.Forms.Button();
            this.tbResizeWidth = new System.Windows.Forms.TextBox();
            this.tbResizeHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbResizeAbsolute = new System.Windows.Forms.RadioButton();
            this.rbResizeRelative = new System.Windows.Forms.RadioButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.rbResizeFlagNearest = new System.Windows.Forms.RadioButton();
            this.rbResizeFlagLinear = new System.Windows.Forms.RadioButton();
            this.rbResizeFlagArea = new System.Windows.Forms.RadioButton();
            this.rbResizeFlagCubic = new System.Windows.Forms.RadioButton();
            this.rbResizeFlagLanczos4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(868, 525);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 423);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnAvFileOpen);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnOpenCamera);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnFlipOpenImage);
            this.groupBox7.Controls.Add(this.rbFlipXy);
            this.groupBox7.Controls.Add(this.rbFlipY);
            this.groupBox7.Controls.Add(this.rbFlipX);
            this.groupBox7.Location = new System.Drawing.Point(589, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(132, 129);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Flip Mode";
            // 
            // btnFlipOpenImage
            // 
            this.btnFlipOpenImage.Location = new System.Drawing.Point(6, 93);
            this.btnFlipOpenImage.Name = "btnFlipOpenImage";
            this.btnFlipOpenImage.Size = new System.Drawing.Size(105, 23);
            this.btnFlipOpenImage.TabIndex = 1;
            this.btnFlipOpenImage.Text = "Open Image";
            this.btnFlipOpenImage.UseVisualStyleBackColor = true;
            this.btnFlipOpenImage.Click += new System.EventHandler(this.btnFlipOpenImage_Click);
            // 
            // rbFlipXy
            // 
            this.rbFlipXy.AutoSize = true;
            this.rbFlipXy.Location = new System.Drawing.Point(6, 66);
            this.rbFlipXy.Name = "rbFlipXy";
            this.rbFlipXy.Size = new System.Drawing.Size(39, 16);
            this.rbFlipXy.TabIndex = 0;
            this.rbFlipXy.Text = "XY";
            this.rbFlipXy.UseVisualStyleBackColor = true;
            // 
            // rbFlipY
            // 
            this.rbFlipY.AutoSize = true;
            this.rbFlipY.Location = new System.Drawing.Point(6, 44);
            this.rbFlipY.Name = "rbFlipY";
            this.rbFlipY.Size = new System.Drawing.Size(31, 16);
            this.rbFlipY.TabIndex = 0;
            this.rbFlipY.Text = "Y";
            this.rbFlipY.UseVisualStyleBackColor = true;
            // 
            // rbFlipX
            // 
            this.rbFlipX.AutoSize = true;
            this.rbFlipX.Checked = true;
            this.rbFlipX.Location = new System.Drawing.Point(6, 22);
            this.rbFlipX.Name = "rbFlipX";
            this.rbFlipX.Size = new System.Drawing.Size(31, 16);
            this.rbFlipX.TabIndex = 0;
            this.rbFlipX.TabStop = true;
            this.rbFlipX.Text = "X";
            this.rbFlipX.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColorSpaceOpenImage);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(322, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 384);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Space Change(색공간변환)";
            // 
            // btnColorSpaceOpenImage
            // 
            this.btnColorSpaceOpenImage.Location = new System.Drawing.Point(13, 291);
            this.btnColorSpaceOpenImage.Name = "btnColorSpaceOpenImage";
            this.btnColorSpaceOpenImage.Size = new System.Drawing.Size(122, 23);
            this.btnColorSpaceOpenImage.TabIndex = 3;
            this.btnColorSpaceOpenImage.Text = "Open Image";
            this.btnColorSpaceOpenImage.UseVisualStyleBackColor = true;
            this.btnColorSpaceOpenImage.Click += new System.EventHandler(this.btnColorSpaceOpenImage_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbColorSpaceFloat);
            this.groupBox6.Controls.Add(this.rbColorSpaceSigned);
            this.groupBox6.Controls.Add(this.rbColorSpaceUnsigned);
            this.groupBox6.Location = new System.Drawing.Point(6, 157);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(96, 128);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "U/S/F";
            // 
            // rbColorSpaceFloat
            // 
            this.rbColorSpaceFloat.AutoSize = true;
            this.rbColorSpaceFloat.Location = new System.Drawing.Point(7, 65);
            this.rbColorSpaceFloat.Name = "rbColorSpaceFloat";
            this.rbColorSpaceFloat.Size = new System.Drawing.Size(50, 16);
            this.rbColorSpaceFloat.TabIndex = 0;
            this.rbColorSpaceFloat.Text = "Float";
            this.rbColorSpaceFloat.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceSigned
            // 
            this.rbColorSpaceSigned.AutoSize = true;
            this.rbColorSpaceSigned.Location = new System.Drawing.Point(7, 43);
            this.rbColorSpaceSigned.Name = "rbColorSpaceSigned";
            this.rbColorSpaceSigned.Size = new System.Drawing.Size(62, 16);
            this.rbColorSpaceSigned.TabIndex = 0;
            this.rbColorSpaceSigned.Text = "Signed";
            this.rbColorSpaceSigned.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceUnsigned
            // 
            this.rbColorSpaceUnsigned.AutoSize = true;
            this.rbColorSpaceUnsigned.Checked = true;
            this.rbColorSpaceUnsigned.Location = new System.Drawing.Point(7, 21);
            this.rbColorSpaceUnsigned.Name = "rbColorSpaceUnsigned";
            this.rbColorSpaceUnsigned.Size = new System.Drawing.Size(76, 16);
            this.rbColorSpaceUnsigned.TabIndex = 0;
            this.rbColorSpaceUnsigned.TabStop = true;
            this.rbColorSpaceUnsigned.Text = "Unsigned";
            this.rbColorSpaceUnsigned.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbColorSpaceBit64);
            this.groupBox5.Controls.Add(this.rbColorSpaceBit32);
            this.groupBox5.Controls.Add(this.rbColorSpaceBit16);
            this.groupBox5.Controls.Add(this.rbColorSpaceBit8);
            this.groupBox5.Location = new System.Drawing.Point(6, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(67, 124);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Color Bit";
            // 
            // rbColorSpaceBit64
            // 
            this.rbColorSpaceBit64.AutoSize = true;
            this.rbColorSpaceBit64.Location = new System.Drawing.Point(7, 86);
            this.rbColorSpaceBit64.Name = "rbColorSpaceBit64";
            this.rbColorSpaceBit64.Size = new System.Drawing.Size(52, 16);
            this.rbColorSpaceBit64.TabIndex = 0;
            this.rbColorSpaceBit64.Text = "64 bit";
            this.rbColorSpaceBit64.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceBit32
            // 
            this.rbColorSpaceBit32.AutoSize = true;
            this.rbColorSpaceBit32.Location = new System.Drawing.Point(7, 64);
            this.rbColorSpaceBit32.Name = "rbColorSpaceBit32";
            this.rbColorSpaceBit32.Size = new System.Drawing.Size(52, 16);
            this.rbColorSpaceBit32.TabIndex = 0;
            this.rbColorSpaceBit32.Text = "32 bit";
            this.rbColorSpaceBit32.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceBit16
            // 
            this.rbColorSpaceBit16.AutoSize = true;
            this.rbColorSpaceBit16.Location = new System.Drawing.Point(7, 42);
            this.rbColorSpaceBit16.Name = "rbColorSpaceBit16";
            this.rbColorSpaceBit16.Size = new System.Drawing.Size(52, 16);
            this.rbColorSpaceBit16.TabIndex = 0;
            this.rbColorSpaceBit16.Text = "16 bit";
            this.rbColorSpaceBit16.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceBit8
            // 
            this.rbColorSpaceBit8.AutoSize = true;
            this.rbColorSpaceBit8.Checked = true;
            this.rbColorSpaceBit8.Location = new System.Drawing.Point(7, 22);
            this.rbColorSpaceBit8.Name = "rbColorSpaceBit8";
            this.rbColorSpaceBit8.Size = new System.Drawing.Size(46, 16);
            this.rbColorSpaceBit8.TabIndex = 0;
            this.rbColorSpaceBit8.TabStop = true;
            this.rbColorSpaceBit8.Text = "8 bit";
            this.rbColorSpaceBit8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2Luv);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2Lab);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2HSV);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2YCrCb);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2XYZ);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2BGR565);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeGRAY2RGB);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2GRAY);
            this.groupBox4.Controls.Add(this.rbColorSpaceChangeBGR2BGRA);
            this.groupBox4.Location = new System.Drawing.Point(153, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 258);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Space";
            // 
            // rbColorSpaceChangeBGR2Luv
            // 
            this.rbColorSpaceChangeBGR2Luv.AutoSize = true;
            this.rbColorSpaceChangeBGR2Luv.Location = new System.Drawing.Point(6, 195);
            this.rbColorSpaceChangeBGR2Luv.Name = "rbColorSpaceChangeBGR2Luv";
            this.rbColorSpaceChangeBGR2Luv.Size = new System.Drawing.Size(63, 16);
            this.rbColorSpaceChangeBGR2Luv.TabIndex = 0;
            this.rbColorSpaceChangeBGR2Luv.Text = "CIELuv";
            this.rbColorSpaceChangeBGR2Luv.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2Lab
            // 
            this.rbColorSpaceChangeBGR2Lab.AutoSize = true;
            this.rbColorSpaceChangeBGR2Lab.Location = new System.Drawing.Point(6, 173);
            this.rbColorSpaceChangeBGR2Lab.Name = "rbColorSpaceChangeBGR2Lab";
            this.rbColorSpaceChangeBGR2Lab.Size = new System.Drawing.Size(64, 16);
            this.rbColorSpaceChangeBGR2Lab.TabIndex = 0;
            this.rbColorSpaceChangeBGR2Lab.Text = "CIELab";
            this.rbColorSpaceChangeBGR2Lab.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2HSV
            // 
            this.rbColorSpaceChangeBGR2HSV.AutoSize = true;
            this.rbColorSpaceChangeBGR2HSV.Location = new System.Drawing.Point(6, 151);
            this.rbColorSpaceChangeBGR2HSV.Name = "rbColorSpaceChangeBGR2HSV";
            this.rbColorSpaceChangeBGR2HSV.Size = new System.Drawing.Size(78, 16);
            this.rbColorSpaceChangeBGR2HSV.TabIndex = 0;
            this.rbColorSpaceChangeBGR2HSV.Text = "BGR2HSV";
            this.rbColorSpaceChangeBGR2HSV.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2YCrCb
            // 
            this.rbColorSpaceChangeBGR2YCrCb.AutoSize = true;
            this.rbColorSpaceChangeBGR2YCrCb.Location = new System.Drawing.Point(6, 130);
            this.rbColorSpaceChangeBGR2YCrCb.Name = "rbColorSpaceChangeBGR2YCrCb";
            this.rbColorSpaceChangeBGR2YCrCb.Size = new System.Drawing.Size(91, 16);
            this.rbColorSpaceChangeBGR2YCrCb.TabIndex = 0;
            this.rbColorSpaceChangeBGR2YCrCb.Text = "BGR2YCrCb";
            this.rbColorSpaceChangeBGR2YCrCb.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2XYZ
            // 
            this.rbColorSpaceChangeBGR2XYZ.AutoSize = true;
            this.rbColorSpaceChangeBGR2XYZ.Location = new System.Drawing.Point(6, 108);
            this.rbColorSpaceChangeBGR2XYZ.Name = "rbColorSpaceChangeBGR2XYZ";
            this.rbColorSpaceChangeBGR2XYZ.Size = new System.Drawing.Size(78, 16);
            this.rbColorSpaceChangeBGR2XYZ.TabIndex = 0;
            this.rbColorSpaceChangeBGR2XYZ.Text = "BGR2XYZ";
            this.toolTip1.SetToolTip(this.rbColorSpaceChangeBGR2XYZ, "CIE(국제 조명위원회)에서 규정한 색공간입니다. 균일한 색공간 좌표로서 인간의 눈이 인지할 수 있는 색차를 거의 그대로 수치로 표현합니다.");
            this.rbColorSpaceChangeBGR2XYZ.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2BGR565
            // 
            this.rbColorSpaceChangeBGR2BGR565.AutoSize = true;
            this.rbColorSpaceChangeBGR2BGR565.Location = new System.Drawing.Point(6, 86);
            this.rbColorSpaceChangeBGR2BGR565.Name = "rbColorSpaceChangeBGR2BGR565";
            this.rbColorSpaceChangeBGR2BGR565.Size = new System.Drawing.Size(97, 16);
            this.rbColorSpaceChangeBGR2BGR565.TabIndex = 0;
            this.rbColorSpaceChangeBGR2BGR565.Text = "BGR2BGR565";
            this.rbColorSpaceChangeBGR2BGR565.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeGRAY2RGB
            // 
            this.rbColorSpaceChangeGRAY2RGB.AutoSize = true;
            this.rbColorSpaceChangeGRAY2RGB.Location = new System.Drawing.Point(6, 64);
            this.rbColorSpaceChangeGRAY2RGB.Name = "rbColorSpaceChangeGRAY2RGB";
            this.rbColorSpaceChangeGRAY2RGB.Size = new System.Drawing.Size(87, 16);
            this.rbColorSpaceChangeGRAY2RGB.TabIndex = 0;
            this.rbColorSpaceChangeGRAY2RGB.Text = "GRAY2RGB";
            this.toolTip1.SetToolTip(this.rbColorSpaceChangeGRAY2RGB, "HSV 색 공간은 색상, 명도, 채도를 기준으로 색을 구성하는 방식으로 위 그림처럼 원뿔형태로 표현할 수 있습니다.");
            this.rbColorSpaceChangeGRAY2RGB.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2GRAY
            // 
            this.rbColorSpaceChangeBGR2GRAY.AutoSize = true;
            this.rbColorSpaceChangeBGR2GRAY.Location = new System.Drawing.Point(6, 42);
            this.rbColorSpaceChangeBGR2GRAY.Name = "rbColorSpaceChangeBGR2GRAY";
            this.rbColorSpaceChangeBGR2GRAY.Size = new System.Drawing.Size(87, 16);
            this.rbColorSpaceChangeBGR2GRAY.TabIndex = 0;
            this.rbColorSpaceChangeBGR2GRAY.Text = "BGR2GRAY";
            this.rbColorSpaceChangeBGR2GRAY.UseVisualStyleBackColor = true;
            // 
            // rbColorSpaceChangeBGR2BGRA
            // 
            this.rbColorSpaceChangeBGR2BGRA.AutoSize = true;
            this.rbColorSpaceChangeBGR2BGRA.Checked = true;
            this.rbColorSpaceChangeBGR2BGRA.Location = new System.Drawing.Point(6, 20);
            this.rbColorSpaceChangeBGR2BGRA.Name = "rbColorSpaceChangeBGR2BGRA";
            this.rbColorSpaceChangeBGR2BGRA.Size = new System.Drawing.Size(87, 16);
            this.rbColorSpaceChangeBGR2BGRA.TabIndex = 0;
            this.rbColorSpaceChangeBGR2BGRA.TabStop = true;
            this.rbColorSpaceChangeBGR2BGRA.Text = "BGR2BGRA";
            this.toolTip1.SetToolTip(this.rbColorSpaceChangeBGR2BGRA, "RGB 색 공간은 색을 혼합하면 명도가 올라가는 가산 혼합 방식으로 색을 표현합니다.");
            this.rbColorSpaceChangeBGR2BGRA.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSpaceColorChannel4);
            this.groupBox3.Controls.Add(this.rbSpaceColorChannel3);
            this.groupBox3.Controls.Add(this.rbSpaceColorChannel2);
            this.groupBox3.Controls.Add(this.rbSpaceColorChannel1);
            this.groupBox3.Location = new System.Drawing.Point(79, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(68, 126);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Channel";
            // 
            // rbSpaceColorChannel4
            // 
            this.rbSpaceColorChannel4.AutoSize = true;
            this.rbSpaceColorChannel4.Location = new System.Drawing.Point(6, 88);
            this.rbSpaceColorChannel4.Name = "rbSpaceColorChannel4";
            this.rbSpaceColorChannel4.Size = new System.Drawing.Size(50, 16);
            this.rbSpaceColorChannel4.TabIndex = 0;
            this.rbSpaceColorChannel4.Text = "4 CH";
            this.rbSpaceColorChannel4.UseVisualStyleBackColor = true;
            // 
            // rbSpaceColorChannel3
            // 
            this.rbSpaceColorChannel3.AutoSize = true;
            this.rbSpaceColorChannel3.Location = new System.Drawing.Point(6, 66);
            this.rbSpaceColorChannel3.Name = "rbSpaceColorChannel3";
            this.rbSpaceColorChannel3.Size = new System.Drawing.Size(50, 16);
            this.rbSpaceColorChannel3.TabIndex = 0;
            this.rbSpaceColorChannel3.Text = "3 CH";
            this.rbSpaceColorChannel3.UseVisualStyleBackColor = true;
            // 
            // rbSpaceColorChannel2
            // 
            this.rbSpaceColorChannel2.AutoSize = true;
            this.rbSpaceColorChannel2.Location = new System.Drawing.Point(6, 42);
            this.rbSpaceColorChannel2.Name = "rbSpaceColorChannel2";
            this.rbSpaceColorChannel2.Size = new System.Drawing.Size(50, 16);
            this.rbSpaceColorChannel2.TabIndex = 0;
            this.rbSpaceColorChannel2.Text = "2 CH";
            this.rbSpaceColorChannel2.UseVisualStyleBackColor = true;
            // 
            // rbSpaceColorChannel1
            // 
            this.rbSpaceColorChannel1.AutoSize = true;
            this.rbSpaceColorChannel1.Checked = true;
            this.rbSpaceColorChannel1.Location = new System.Drawing.Point(6, 20);
            this.rbSpaceColorChannel1.Name = "rbSpaceColorChannel1";
            this.rbSpaceColorChannel1.Size = new System.Drawing.Size(50, 16);
            this.rbSpaceColorChannel1.TabIndex = 0;
            this.rbSpaceColorChannel1.TabStop = true;
            this.rbSpaceColorChannel1.Text = "1 CH";
            this.rbSpaceColorChannel1.UseVisualStyleBackColor = true;
            // 
            // btnAvFileOpen
            // 
            this.btnAvFileOpen.Location = new System.Drawing.Point(205, 78);
            this.btnAvFileOpen.Name = "btnAvFileOpen";
            this.btnAvFileOpen.Size = new System.Drawing.Size(110, 23);
            this.btnAvFileOpen.TabIndex = 3;
            this.btnAvFileOpen.Text = "AV File Open";
            this.btnAvFileOpen.UseVisualStyleBackColor = true;
            this.btnAvFileOpen.Click += new System.EventHandler(this.btnAvFileOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIgnoreOrientation);
            this.groupBox1.Controls.Add(this.rbReducedColor8);
            this.groupBox1.Controls.Add(this.rbReducedGrayscale8);
            this.groupBox1.Controls.Add(this.rbReducedColor4);
            this.groupBox1.Controls.Add(this.rbReducedGrayscale4);
            this.groupBox1.Controls.Add(this.rbReducedColor2);
            this.groupBox1.Controls.Add(this.rbReducedGrayscale2);
            this.groupBox1.Controls.Add(this.rbLoadGdal);
            this.groupBox1.Controls.Add(this.rbAnyColor);
            this.groupBox1.Controls.Add(this.rbAnyDepth);
            this.groupBox1.Controls.Add(this.rbColor);
            this.groupBox1.Controls.Add(this.rbGrayscale);
            this.groupBox1.Controls.Add(this.rbUnchanged);
            this.groupBox1.Controls.Add(this.btnOpenImg);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Open";
            // 
            // rbIgnoreOrientation
            // 
            this.rbIgnoreOrientation.AutoSize = true;
            this.rbIgnoreOrientation.Location = new System.Drawing.Point(7, 314);
            this.rbIgnoreOrientation.Name = "rbIgnoreOrientation";
            this.rbIgnoreOrientation.Size = new System.Drawing.Size(118, 16);
            this.rbIgnoreOrientation.TabIndex = 1;
            this.rbIgnoreOrientation.Text = "IgnoreOrientation";
            this.toolTip1.SetToolTip(this.rbIgnoreOrientation, "EXIF의 방향 플래그에 따라 이미지를 회전하지 않음");
            this.rbIgnoreOrientation.UseVisualStyleBackColor = true;
            // 
            // rbReducedColor8
            // 
            this.rbReducedColor8.AutoSize = true;
            this.rbReducedColor8.Location = new System.Drawing.Point(7, 292);
            this.rbReducedColor8.Name = "rbReducedColor8";
            this.rbReducedColor8.Size = new System.Drawing.Size(109, 16);
            this.rbReducedColor8.TabIndex = 1;
            this.rbReducedColor8.Text = "ReducedColor8";
            this.toolTip1.SetToolTip(this.rbReducedColor8, "3 채널, 1/8 크기, BGR 이미지 사용");
            this.rbReducedColor8.UseVisualStyleBackColor = true;
            // 
            // rbReducedGrayscale8
            // 
            this.rbReducedGrayscale8.AutoSize = true;
            this.rbReducedGrayscale8.Location = new System.Drawing.Point(7, 270);
            this.rbReducedGrayscale8.Name = "rbReducedGrayscale8";
            this.rbReducedGrayscale8.Size = new System.Drawing.Size(137, 16);
            this.rbReducedGrayscale8.TabIndex = 1;
            this.rbReducedGrayscale8.Text = "ReducedGrayscale8";
            this.toolTip1.SetToolTip(this.rbReducedGrayscale8, "1 채널, 1/8 크기, 그레이스케일 적용");
            this.rbReducedGrayscale8.UseVisualStyleBackColor = true;
            // 
            // rbReducedColor4
            // 
            this.rbReducedColor4.AutoSize = true;
            this.rbReducedColor4.Location = new System.Drawing.Point(7, 248);
            this.rbReducedColor4.Name = "rbReducedColor4";
            this.rbReducedColor4.Size = new System.Drawing.Size(109, 16);
            this.rbReducedColor4.TabIndex = 1;
            this.rbReducedColor4.Text = "ReducedColor4";
            this.toolTip1.SetToolTip(this.rbReducedColor4, "3 채널, 1/4 크기, BGR 이미지 사용");
            this.rbReducedColor4.UseVisualStyleBackColor = true;
            // 
            // rbReducedGrayscale4
            // 
            this.rbReducedGrayscale4.AutoSize = true;
            this.rbReducedGrayscale4.Location = new System.Drawing.Point(7, 226);
            this.rbReducedGrayscale4.Name = "rbReducedGrayscale4";
            this.rbReducedGrayscale4.Size = new System.Drawing.Size(137, 16);
            this.rbReducedGrayscale4.TabIndex = 1;
            this.rbReducedGrayscale4.Text = "ReducedGrayscale4";
            this.toolTip1.SetToolTip(this.rbReducedGrayscale4, "1 채널, 1/4 크기, 그레이스케일 적용");
            this.rbReducedGrayscale4.UseVisualStyleBackColor = true;
            // 
            // rbReducedColor2
            // 
            this.rbReducedColor2.AutoSize = true;
            this.rbReducedColor2.Location = new System.Drawing.Point(7, 204);
            this.rbReducedColor2.Name = "rbReducedColor2";
            this.rbReducedColor2.Size = new System.Drawing.Size(109, 16);
            this.rbReducedColor2.TabIndex = 1;
            this.rbReducedColor2.Text = "ReducedColor2";
            this.toolTip1.SetToolTip(this.rbReducedColor2, "3 채널, 1/2 크기, BGR 이미지 사용");
            this.rbReducedColor2.UseVisualStyleBackColor = true;
            // 
            // rbReducedGrayscale2
            // 
            this.rbReducedGrayscale2.AutoSize = true;
            this.rbReducedGrayscale2.Location = new System.Drawing.Point(7, 182);
            this.rbReducedGrayscale2.Name = "rbReducedGrayscale2";
            this.rbReducedGrayscale2.Size = new System.Drawing.Size(137, 16);
            this.rbReducedGrayscale2.TabIndex = 1;
            this.rbReducedGrayscale2.Text = "ReducedGrayscale2";
            this.toolTip1.SetToolTip(this.rbReducedGrayscale2, "1 채널, 1/2 크기, 그레이스케일 적용");
            this.rbReducedGrayscale2.UseVisualStyleBackColor = true;
            // 
            // rbLoadGdal
            // 
            this.rbLoadGdal.AutoSize = true;
            this.rbLoadGdal.Location = new System.Drawing.Point(7, 160);
            this.rbLoadGdal.Name = "rbLoadGdal";
            this.rbLoadGdal.Size = new System.Drawing.Size(77, 16);
            this.rbLoadGdal.TabIndex = 1;
            this.rbLoadGdal.Text = "LoadGdal";
            this.toolTip1.SetToolTip(this.rbLoadGdal, "GDAL에서 지원하는 지리공간 데이터 이미지로 사용");
            this.rbLoadGdal.UseVisualStyleBackColor = true;
            // 
            // rbAnyColor
            // 
            this.rbAnyColor.AutoSize = true;
            this.rbAnyColor.Location = new System.Drawing.Point(7, 138);
            this.rbAnyColor.Name = "rbAnyColor";
            this.rbAnyColor.Size = new System.Drawing.Size(75, 16);
            this.rbAnyColor.TabIndex = 1;
            this.rbAnyColor.Text = "AnyColor";
            this.toolTip1.SetToolTip(this.rbAnyColor, "가능한 3 채널, 색상 이미지로 사용");
            this.rbAnyColor.UseVisualStyleBackColor = true;
            // 
            // rbAnyDepth
            // 
            this.rbAnyDepth.AutoSize = true;
            this.rbAnyDepth.Location = new System.Drawing.Point(7, 116);
            this.rbAnyDepth.Name = "rbAnyDepth";
            this.rbAnyDepth.Size = new System.Drawing.Size(77, 16);
            this.rbAnyDepth.TabIndex = 1;
            this.rbAnyDepth.Text = "AnyDepth";
            this.toolTip1.SetToolTip(this.rbAnyDepth, "이미지에 따라 정밀도를 16/32비트 또는 8비트로 사용");
            this.rbAnyDepth.UseVisualStyleBackColor = true;
            // 
            // rbColor
            // 
            this.rbColor.AutoSize = true;
            this.rbColor.Location = new System.Drawing.Point(7, 94);
            this.rbColor.Name = "rbColor";
            this.rbColor.Size = new System.Drawing.Size(53, 16);
            this.rbColor.TabIndex = 1;
            this.rbColor.Text = "Color";
            this.toolTip1.SetToolTip(this.rbColor, "3 채널, BGR 이미지 사용");
            this.rbColor.UseVisualStyleBackColor = true;
            // 
            // rbGrayscale
            // 
            this.rbGrayscale.AutoSize = true;
            this.rbGrayscale.Location = new System.Drawing.Point(7, 72);
            this.rbGrayscale.Name = "rbGrayscale";
            this.rbGrayscale.Size = new System.Drawing.Size(81, 16);
            this.rbGrayscale.TabIndex = 1;
            this.rbGrayscale.Text = "Grayscale";
            this.toolTip1.SetToolTip(this.rbGrayscale, "1채널, 그레이스케일 적용");
            this.rbGrayscale.UseVisualStyleBackColor = true;
            // 
            // rbUnchanged
            // 
            this.rbUnchanged.AutoSize = true;
            this.rbUnchanged.Checked = true;
            this.rbUnchanged.Location = new System.Drawing.Point(7, 50);
            this.rbUnchanged.Name = "rbUnchanged";
            this.rbUnchanged.Size = new System.Drawing.Size(87, 16);
            this.rbUnchanged.TabIndex = 1;
            this.rbUnchanged.TabStop = true;
            this.rbUnchanged.Text = "Unchanged";
            this.toolTip1.SetToolTip(this.rbUnchanged, "원본 사용");
            this.rbUnchanged.UseVisualStyleBackColor = true;
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Location = new System.Drawing.Point(6, 20);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(110, 23);
            this.btnOpenImg.TabIndex = 0;
            this.btnOpenImg.Text = "Open Image";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(205, 26);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(110, 23);
            this.btnOpenCamera.TabIndex = 1;
            this.btnOpenCamera.Text = "Open Camera";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Feature";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(858, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zoom In/Out";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.btnZoom);
            this.groupBox8.Controls.Add(this.rbZoomOut);
            this.groupBox8.Controls.Add(this.rbZoomIn);
            this.groupBox8.Location = new System.Drawing.Point(7, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(391, 391);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Zoom";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnZoomWithOption);
            this.groupBox10.Controls.Add(this.groupBox9);
            this.groupBox10.Controls.Add(this.rbIsolated);
            this.groupBox10.Controls.Add(this.rbTransparent);
            this.groupBox10.Controls.Add(this.rbReflect101);
            this.groupBox10.Controls.Add(this.rbWrap);
            this.groupBox10.Controls.Add(this.rbReflect);
            this.groupBox10.Controls.Add(this.rbReplicate);
            this.groupBox10.Controls.Add(this.rbConstant);
            this.groupBox10.Location = new System.Drawing.Point(148, 20);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 365);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "BorderTypes";
            // 
            // btnZoomWithOption
            // 
            this.btnZoomWithOption.Location = new System.Drawing.Point(6, 302);
            this.btnZoomWithOption.Name = "btnZoomWithOption";
            this.btnZoomWithOption.Size = new System.Drawing.Size(165, 23);
            this.btnZoomWithOption.TabIndex = 1;
            this.btnZoomWithOption.Text = "Zoom with option";
            this.btnZoomWithOption.UseVisualStyleBackColor = true;
            this.btnZoomWithOption.Click += new System.EventHandler(this.btnZoomWithOption_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.tbZoomHeight);
            this.groupBox9.Controls.Add(this.tbZoomWidth);
            this.groupBox9.Location = new System.Drawing.Point(6, 186);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(172, 82);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Zoom Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // tbZoomHeight
            // 
            this.tbZoomHeight.Location = new System.Drawing.Point(65, 45);
            this.tbZoomHeight.Name = "tbZoomHeight";
            this.tbZoomHeight.Size = new System.Drawing.Size(100, 21);
            this.tbZoomHeight.TabIndex = 0;
            this.tbZoomHeight.Text = "100";
            this.tbZoomHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbZoomWidth
            // 
            this.tbZoomWidth.Location = new System.Drawing.Point(65, 18);
            this.tbZoomWidth.Name = "tbZoomWidth";
            this.tbZoomWidth.Size = new System.Drawing.Size(100, 21);
            this.tbZoomWidth.TabIndex = 0;
            this.tbZoomWidth.Text = "100";
            this.tbZoomWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbIsolated
            // 
            this.rbIsolated.AutoSize = true;
            this.rbIsolated.Location = new System.Drawing.Point(6, 153);
            this.rbIsolated.Name = "rbIsolated";
            this.rbIsolated.Size = new System.Drawing.Size(67, 16);
            this.rbIsolated.TabIndex = 0;
            this.rbIsolated.Text = "Isolated";
            this.rbIsolated.UseVisualStyleBackColor = true;
            // 
            // rbTransparent
            // 
            this.rbTransparent.AutoSize = true;
            this.rbTransparent.Location = new System.Drawing.Point(6, 131);
            this.rbTransparent.Name = "rbTransparent";
            this.rbTransparent.Size = new System.Drawing.Size(91, 16);
            this.rbTransparent.TabIndex = 0;
            this.rbTransparent.Text = "Transparent";
            this.rbTransparent.UseVisualStyleBackColor = true;
            // 
            // rbReflect101
            // 
            this.rbReflect101.AutoSize = true;
            this.rbReflect101.Checked = true;
            this.rbReflect101.Location = new System.Drawing.Point(6, 109);
            this.rbReflect101.Name = "rbReflect101";
            this.rbReflect101.Size = new System.Drawing.Size(79, 16);
            this.rbReflect101.TabIndex = 0;
            this.rbReflect101.TabStop = true;
            this.rbReflect101.Text = "Reflect101";
            this.rbReflect101.UseVisualStyleBackColor = true;
            // 
            // rbWrap
            // 
            this.rbWrap.AutoSize = true;
            this.rbWrap.Location = new System.Drawing.Point(6, 87);
            this.rbWrap.Name = "rbWrap";
            this.rbWrap.Size = new System.Drawing.Size(51, 16);
            this.rbWrap.TabIndex = 0;
            this.rbWrap.Text = "Wrap";
            this.rbWrap.UseVisualStyleBackColor = true;
            // 
            // rbReflect
            // 
            this.rbReflect.AutoSize = true;
            this.rbReflect.Location = new System.Drawing.Point(7, 65);
            this.rbReflect.Name = "rbReflect";
            this.rbReflect.Size = new System.Drawing.Size(61, 16);
            this.rbReflect.TabIndex = 0;
            this.rbReflect.Text = "Reflect";
            this.rbReflect.UseVisualStyleBackColor = true;
            // 
            // rbReplicate
            // 
            this.rbReplicate.AutoSize = true;
            this.rbReplicate.Location = new System.Drawing.Point(7, 43);
            this.rbReplicate.Name = "rbReplicate";
            this.rbReplicate.Size = new System.Drawing.Size(75, 16);
            this.rbReplicate.TabIndex = 0;
            this.rbReplicate.Text = "Replicate";
            this.rbReplicate.UseVisualStyleBackColor = true;
            // 
            // rbConstant
            // 
            this.rbConstant.AutoSize = true;
            this.rbConstant.Location = new System.Drawing.Point(7, 21);
            this.rbConstant.Name = "rbConstant";
            this.rbConstant.Size = new System.Drawing.Size(73, 16);
            this.rbConstant.TabIndex = 0;
            this.rbConstant.Text = "Constant";
            this.rbConstant.UseVisualStyleBackColor = true;
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(7, 66);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 1;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // rbZoomOut
            // 
            this.rbZoomOut.AutoSize = true;
            this.rbZoomOut.Location = new System.Drawing.Point(7, 43);
            this.rbZoomOut.Name = "rbZoomOut";
            this.rbZoomOut.Size = new System.Drawing.Size(79, 16);
            this.rbZoomOut.TabIndex = 0;
            this.rbZoomOut.Text = "Zoom Out";
            this.rbZoomOut.UseVisualStyleBackColor = true;
            // 
            // rbZoomIn
            // 
            this.rbZoomIn.AutoSize = true;
            this.rbZoomIn.Checked = true;
            this.rbZoomIn.Location = new System.Drawing.Point(7, 21);
            this.rbZoomIn.Name = "rbZoomIn";
            this.rbZoomIn.Size = new System.Drawing.Size(70, 16);
            this.rbZoomIn.TabIndex = 0;
            this.rbZoomIn.TabStop = true;
            this.rbZoomIn.Text = "Zoom In";
            this.rbZoomIn.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxLog);
            this.splitContainer2.Size = new System.Drawing.Size(868, 96);
            this.splitContainer2.SplitterDistance = 522;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(520, 94);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.btnResizeOpenImage);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.tbResizeWidth);
            this.groupBox11.Controls.Add(this.tbResizeHeight);
            this.groupBox11.Location = new System.Drawing.Point(404, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(451, 390);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Resize";
            // 
            // btnResizeOpenImage
            // 
            this.btnResizeOpenImage.Location = new System.Drawing.Point(28, 84);
            this.btnResizeOpenImage.Name = "btnResizeOpenImage";
            this.btnResizeOpenImage.Size = new System.Drawing.Size(152, 23);
            this.btnResizeOpenImage.TabIndex = 0;
            this.btnResizeOpenImage.Text = "Resize Open Image";
            this.btnResizeOpenImage.UseVisualStyleBackColor = true;
            this.btnResizeOpenImage.Click += new System.EventHandler(this.btnResizeOpenImage_Click);
            // 
            // tbResizeWidth
            // 
            this.tbResizeWidth.Location = new System.Drawing.Point(80, 20);
            this.tbResizeWidth.Name = "tbResizeWidth";
            this.tbResizeWidth.Size = new System.Drawing.Size(100, 21);
            this.tbResizeWidth.TabIndex = 0;
            this.tbResizeWidth.Text = "100";
            this.tbResizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResizeHeight
            // 
            this.tbResizeHeight.Location = new System.Drawing.Point(80, 47);
            this.tbResizeHeight.Name = "tbResizeHeight";
            this.tbResizeHeight.Size = new System.Drawing.Size(100, 21);
            this.tbResizeHeight.TabIndex = 0;
            this.tbResizeHeight.Text = "100";
            this.tbResizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Height";
            // 
            // rbResizeAbsolute
            // 
            this.rbResizeAbsolute.AutoSize = true;
            this.rbResizeAbsolute.Checked = true;
            this.rbResizeAbsolute.Location = new System.Drawing.Point(6, 22);
            this.rbResizeAbsolute.Name = "rbResizeAbsolute";
            this.rbResizeAbsolute.Size = new System.Drawing.Size(101, 16);
            this.rbResizeAbsolute.TabIndex = 2;
            this.rbResizeAbsolute.TabStop = true;
            this.rbResizeAbsolute.Text = "Absolute Size";
            this.rbResizeAbsolute.UseVisualStyleBackColor = true;
            // 
            // rbResizeRelative
            // 
            this.rbResizeRelative.AutoSize = true;
            this.rbResizeRelative.Location = new System.Drawing.Point(6, 44);
            this.rbResizeRelative.Name = "rbResizeRelative";
            this.rbResizeRelative.Size = new System.Drawing.Size(96, 16);
            this.rbResizeRelative.TabIndex = 2;
            this.rbResizeRelative.Text = "Relative Size";
            this.rbResizeRelative.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rbResizeAbsolute);
            this.groupBox12.Controls.Add(this.rbResizeRelative);
            this.groupBox12.Location = new System.Drawing.Point(28, 128);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(120, 72);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Size Mode";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.rbResizeFlagLanczos4);
            this.groupBox13.Controls.Add(this.rbResizeFlagCubic);
            this.groupBox13.Controls.Add(this.rbResizeFlagArea);
            this.groupBox13.Controls.Add(this.rbResizeFlagLinear);
            this.groupBox13.Controls.Add(this.rbResizeFlagNearest);
            this.groupBox13.Location = new System.Drawing.Point(221, 20);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(200, 146);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "InterpolationFlags";
            // 
            // rbResizeFlagNearest
            // 
            this.rbResizeFlagNearest.AutoSize = true;
            this.rbResizeFlagNearest.Location = new System.Drawing.Point(7, 22);
            this.rbResizeFlagNearest.Name = "rbResizeFlagNearest";
            this.rbResizeFlagNearest.Size = new System.Drawing.Size(67, 16);
            this.rbResizeFlagNearest.TabIndex = 0;
            this.rbResizeFlagNearest.Text = "Nearest";
            this.toolTip1.SetToolTip(this.rbResizeFlagNearest, "가장 가까운 이웃 보간법");
            this.rbResizeFlagNearest.UseVisualStyleBackColor = true;
            // 
            // rbResizeFlagLinear
            // 
            this.rbResizeFlagLinear.AutoSize = true;
            this.rbResizeFlagLinear.Checked = true;
            this.rbResizeFlagLinear.Location = new System.Drawing.Point(7, 42);
            this.rbResizeFlagLinear.Name = "rbResizeFlagLinear";
            this.rbResizeFlagLinear.Size = new System.Drawing.Size(58, 16);
            this.rbResizeFlagLinear.TabIndex = 0;
            this.rbResizeFlagLinear.TabStop = true;
            this.rbResizeFlagLinear.Text = "Linear";
            this.toolTip1.SetToolTip(this.rbResizeFlagLinear, "쌍 선형 보간법");
            this.rbResizeFlagLinear.UseVisualStyleBackColor = true;
            // 
            // rbResizeFlagArea
            // 
            this.rbResizeFlagArea.AutoSize = true;
            this.rbResizeFlagArea.Location = new System.Drawing.Point(6, 64);
            this.rbResizeFlagArea.Name = "rbResizeFlagArea";
            this.rbResizeFlagArea.Size = new System.Drawing.Size(49, 16);
            this.rbResizeFlagArea.TabIndex = 0;
            this.rbResizeFlagArea.Text = "Area";
            this.toolTip1.SetToolTip(this.rbResizeFlagArea, "영역 보간법");
            this.rbResizeFlagArea.UseVisualStyleBackColor = true;
            // 
            // rbResizeFlagCubic
            // 
            this.rbResizeFlagCubic.AutoSize = true;
            this.rbResizeFlagCubic.Location = new System.Drawing.Point(6, 86);
            this.rbResizeFlagCubic.Name = "rbResizeFlagCubic";
            this.rbResizeFlagCubic.Size = new System.Drawing.Size(56, 16);
            this.rbResizeFlagCubic.TabIndex = 0;
            this.rbResizeFlagCubic.Text = "Cubic";
            this.toolTip1.SetToolTip(this.rbResizeFlagCubic, "4×4 바이 큐빅 보간법");
            this.rbResizeFlagCubic.UseVisualStyleBackColor = true;
            // 
            // rbResizeFlagLanczos4
            // 
            this.rbResizeFlagLanczos4.AutoSize = true;
            this.rbResizeFlagLanczos4.Location = new System.Drawing.Point(7, 108);
            this.rbResizeFlagLanczos4.Name = "rbResizeFlagLanczos4";
            this.rbResizeFlagLanczos4.Size = new System.Drawing.Size(78, 16);
            this.rbResizeFlagLanczos4.TabIndex = 0;
            this.rbResizeFlagLanczos4.Text = "Lanczos4";
            this.toolTip1.SetToolTip(this.rbResizeFlagLanczos4, "8×8 란초스 보간법");
            this.rbResizeFlagLanczos4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 525);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OpenCvSharp Demo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUnchanged;
        private System.Windows.Forms.RadioButton rbIgnoreOrientation;
        private System.Windows.Forms.RadioButton rbReducedColor8;
        private System.Windows.Forms.RadioButton rbReducedGrayscale8;
        private System.Windows.Forms.RadioButton rbReducedColor4;
        private System.Windows.Forms.RadioButton rbReducedGrayscale4;
        private System.Windows.Forms.RadioButton rbReducedColor2;
        private System.Windows.Forms.RadioButton rbReducedGrayscale2;
        private System.Windows.Forms.RadioButton rbLoadGdal;
        private System.Windows.Forms.RadioButton rbAnyColor;
        private System.Windows.Forms.RadioButton rbAnyDepth;
        private System.Windows.Forms.RadioButton rbColor;
        private System.Windows.Forms.RadioButton rbGrayscale;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAvFileOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2BGRA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbSpaceColorChannel4;
        private System.Windows.Forms.RadioButton rbSpaceColorChannel3;
        private System.Windows.Forms.RadioButton rbSpaceColorChannel1;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2XYZ;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2BGR565;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeGRAY2RGB;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2GRAY;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbColorSpaceBit64;
        private System.Windows.Forms.RadioButton rbColorSpaceBit32;
        private System.Windows.Forms.RadioButton rbColorSpaceBit16;
        private System.Windows.Forms.RadioButton rbColorSpaceBit8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbColorSpaceFloat;
        private System.Windows.Forms.RadioButton rbColorSpaceSigned;
        private System.Windows.Forms.RadioButton rbColorSpaceUnsigned;
        private System.Windows.Forms.RadioButton rbSpaceColorChannel2;
        private System.Windows.Forms.Button btnColorSpaceOpenImage;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2YCrCb;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2Luv;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2Lab;
        private System.Windows.Forms.RadioButton rbColorSpaceChangeBGR2HSV;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbFlipXy;
        private System.Windows.Forms.RadioButton rbFlipY;
        private System.Windows.Forms.RadioButton rbFlipX;
        private System.Windows.Forms.Button btnFlipOpenImage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.RadioButton rbZoomOut;
        private System.Windows.Forms.RadioButton rbZoomIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbZoomHeight;
        private System.Windows.Forms.TextBox tbZoomWidth;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rbConstant;
        private System.Windows.Forms.RadioButton rbTransparent;
        private System.Windows.Forms.RadioButton rbReflect101;
        private System.Windows.Forms.RadioButton rbWrap;
        private System.Windows.Forms.RadioButton rbReflect;
        private System.Windows.Forms.RadioButton rbReplicate;
        private System.Windows.Forms.RadioButton rbIsolated;
        private System.Windows.Forms.Button btnZoomWithOption;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResizeOpenImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResizeWidth;
        private System.Windows.Forms.TextBox tbResizeHeight;
        private System.Windows.Forms.RadioButton rbResizeRelative;
        private System.Windows.Forms.RadioButton rbResizeAbsolute;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton rbResizeFlagLanczos4;
        private System.Windows.Forms.RadioButton rbResizeFlagCubic;
        private System.Windows.Forms.RadioButton rbResizeFlagArea;
        private System.Windows.Forms.RadioButton rbResizeFlagLinear;
        private System.Windows.Forms.RadioButton rbResizeFlagNearest;
    }
}

