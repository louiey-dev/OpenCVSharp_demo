using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCVSharp_demo
{
    public partial class Form1 : Form
    {
        COpenCvDemo Cv = null;

        public Form1()
        {
            InitializeComponent();

            Cv = new COpenCvDemo(LOG, ERR, DBG);
        }
        
        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            //OpenCv_CameraOpen();

            Cv.CameraOpen(0);
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            ImreadModes flag = GetImgFlag();
            LOG("Img Flag = " + flag.ToString() + "\n");

            Cv.ImgOpen(path, flag);
        }

        public ImreadModes GetImgFlag()
        {
            try
            {
                if (RBGet(rbUnchanged) == true)
                    return ImreadModes.Unchanged;
                else if(RBGet(rbGrayscale) == true)
                    return ImreadModes.Grayscale;
                else if (RBGet(rbColor) == true)
                    return ImreadModes.Color;
                else if (RBGet(rbAnyDepth) == true)
                    return ImreadModes.AnyDepth;
                else if (RBGet(rbAnyColor) == true)
                    return ImreadModes.AnyColor;
                else if (RBGet(rbLoadGdal) == true)
                    return ImreadModes.LoadGdal;
                else if (RBGet(rbReducedGrayscale2) == true)
                    return ImreadModes.ReducedGrayscale2;
                else if (RBGet(rbReducedColor2) == true)
                    return ImreadModes.ReducedColor2;
                else if (RBGet(rbReducedGrayscale4) == true)
                    return ImreadModes.ReducedGrayscale4;
                else if (RBGet(rbReducedColor4) == true)
                    return ImreadModes.ReducedColor4;
                else if (RBGet(rbReducedGrayscale8) == true)
                    return ImreadModes.ReducedGrayscale8;
                else if (RBGet(rbReducedColor8) == true)
                    return ImreadModes.ReducedColor8;
                else if (RBGet(rbIgnoreOrientation) == true)
                    return ImreadModes.IgnoreOrientation;
                else
                    return ImreadModes.Unchanged;
            }
            catch (Exception e)
            {
                ERR(e.ToString());
                return ImreadModes.Unchanged;
            }
        }

        public ColorConversionCodes GetColorSpaceMode()
        {
            try
            {
                ColorConversionCodes ret = ColorConversionCodes.BGR2BGRA;

                if(RBGet(rbColorSpaceChangeBGR2BGRA) == true)
                    ret = ColorConversionCodes.BGR2BGRA;
                else if (RBGet(rbColorSpaceChangeBGR2GRAY) == true)
                    ret = ColorConversionCodes.BGR2GRAY;
                else if (RBGet(rbColorSpaceChangeGRAY2RGB) == true)
                    ret = ColorConversionCodes.GRAY2RGB;
                else if (RBGet(rbColorSpaceChangeBGR2BGR565) == true)
                    ret = ColorConversionCodes.BGR2BGR565;
                else if (RBGet(rbColorSpaceChangeBGR2XYZ) == true)
                    ret = ColorConversionCodes.BGR2XYZ;
                else if (RBGet(rbColorSpaceChangeBGR2YCrCb) == true)
                    ret = ColorConversionCodes.BGR2YCrCb;
                else if (RBGet(rbColorSpaceChangeBGR2HSV) == true)
                    ret = ColorConversionCodes.BGR2HSV;
                else if (RBGet(rbColorSpaceChangeBGR2Lab) == true)
                    ret = ColorConversionCodes.BGR2Lab;
                else if (RBGet(rbColorSpaceChangeBGR2Luv) == true)
                    ret = ColorConversionCodes.BGR2Luv;

                return ret;
            }
            catch (Exception e ){
                ERR(e.ToString());
                return ColorConversionCodes.BGR2GRAY;
            }
        }


        public MatType GetColorSpaceChannel()
        {
            try
            {
                MatType ret = MatType.CV_8UC1;

                if (RBGet(rbColorSpaceBit8) == true)
                {
                    if (RBGet(rbColorSpaceUnsigned) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_8UC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_8UC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_8UC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_8UC4;
                    }
                    else if (RBGet(rbColorSpaceSigned) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_8SC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_8SC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_8SC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_8SC4;
                    }
                    else
                    {
                        ERR("Unknown format");
                        ret = MatType.CV_8UC1;
                    }
                }
                else if (RBGet(rbColorSpaceBit16) == true)
                {
                    if (RBGet(rbColorSpaceUnsigned) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_16UC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_16UC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_16UC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_16UC4;
                    }
                    else if (RBGet(rbColorSpaceSigned) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_16SC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_16SC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_16SC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_16SC4;
                    }
                    else
                    {
                        ERR("Unknown format");
                        ret = MatType.CV_8UC1;
                    }
                }
                else if (RBGet(rbColorSpaceBit32) == true)
                {
                    if (RBGet(rbColorSpaceSigned) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_32SC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_32SC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_32SC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_32SC4;
                    }
                    else if (RBGet(rbColorSpaceFloat) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_32FC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_32FC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_32FC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_32FC4;
                    }
                    else
                    {
                        ERR("Unknown format");
                        ret = MatType.CV_8UC1;
                    }
                }
                else if (RBGet(rbColorSpaceBit64) == true)
                {
                    if (RBGet(rbColorSpaceFloat) == true)
                    {
                        if (RBGet(rbSpaceColorChannel1) == true)
                            ret = MatType.CV_64FC1;
                        else if (RBGet(rbSpaceColorChannel2) == true)
                            ret = MatType.CV_64FC2;
                        else if (RBGet(rbSpaceColorChannel3) == true)
                            ret = MatType.CV_64FC3;
                        else if (RBGet(rbSpaceColorChannel4) == true)
                            ret = MatType.CV_64FC4;
                    }
                    else
                    {
                        ERR("Unknown format");
                        ret = MatType.CV_8UC1;
                    }
                }
                return ret;
            }
            catch (Exception e)
            {
                ERR(e.ToString());
                return MatType.CV_8UC1;
            }
        }

        private void btnAvFileOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_VIDEO);
            Cv.AvFileOpen(path);
        }

        private void btnColorSpaceOpenImage_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            MatType channel = GetColorSpaceChannel();
            ColorConversionCodes cvt = GetColorSpaceMode();
            LOG("Color Space Mode : CH " + channel.ToString() + ", Cvc : " + cvt.ToString());
            Cv.ColorSpaceChange(path, channel, cvt);
        }

        private void btnFlipOpenImage_Click(object sender, EventArgs e)
        {
            try
            {
                String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);

                FlipMode mode = GetFlipMode();
                Cv.FlipImgMode(path, MatType.CV_8UC3, mode);
            }
            catch(Exception ex) {  ERR(ex.ToString()); }
        }


        public FlipMode GetFlipMode()
        {
            try
            {
                FlipMode mode = FlipMode.X;

                if (RBGet(rbFlipX) == true)
                    mode = FlipMode.X;
                else if (RBGet(rbFlipY) == true)
                    mode = FlipMode.Y;
                else if (RBGet(rbFlipXy) == true)
                    mode = FlipMode.XY;
                else
                    mode = FlipMode.X;

                return mode;
            }
            catch (Exception e)
            {
                ERR(e.ToString());
                return FlipMode.X;
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            bool inout = false;


            if (RBGet(rbZoomIn) == true)
                inout = true;
            else if (RBGet(rbZoomOut) == true)
                inout = false;

            Cv.Zoom(path, inout);
        }


        public BorderTypes GetZoomBorderType()
        {
            try
            {
                BorderTypes border = BorderTypes.Default;

                if(RBGet(rbConstant))
                    border = BorderTypes.Constant;
                else if (RBGet(rbReplicate))
                    border = BorderTypes.Replicate;
                else if (RBGet(rbReflect))
                    border = BorderTypes.Reflect;
                else if (RBGet(rbWrap))
                    border = BorderTypes.Wrap;
                else if (RBGet(rbReflect101))
                    border = BorderTypes.Reflect101;
                else if (RBGet(rbTransparent))
                    border = BorderTypes.Transparent;
                else if (RBGet(rbIsolated))
                    border = BorderTypes.Isolated;
                else
                    border = BorderTypes.Default;

                return border;
            }
            catch (Exception e)
            {
                ERR(e.ToString());
                return BorderTypes.Default;
            }
        }

        private void btnZoomWithOption_Click(object sender, EventArgs e)
        {
            BorderTypes border = GetZoomBorderType();
            int width = Convert.ToInt32(TBGet(tbZoomWidth));
            int height = Convert.ToInt32(TBGet(tbZoomHeight));

            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            bool inout = false;


            if (RBGet(rbZoomIn) == true)
                inout = true;
            else if (RBGet(rbZoomOut) == true)
                inout = false;

            Cv.Zoom(path, inout, width, height, border);

        }

        private void btnResizeOpenImage_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);

            int width = Convert.ToInt32(TBGet(tbResizeWidth));
            int height = Convert.ToInt32(TBGet(tbResizeHeight));
            InterpolationFlags flag = GetInterpolationFlags();

            LOG($"Resize {flag}, {width}, {height}\n");

            if (RBGet(rbResizeAbsolute))
                Cv.ResizeAbsolute(path, flag, width, height);
            else if(RBGet(rbResizeRelative))
                Cv.ResizeRelative(path, flag, width, height);
        }

        public InterpolationFlags GetInterpolationFlags()
        {
            try
            {
                InterpolationFlags flag = InterpolationFlags.Linear;

                if(RBGet(rbResizeFlagNearest)) flag = InterpolationFlags.Nearest;
                else if (RBGet(rbResizeFlagLinear)) flag = InterpolationFlags.Linear;
                else if (RBGet(rbResizeFlagArea)) flag = InterpolationFlags.Area;
                else if (RBGet(rbResizeFlagCubic)) flag = InterpolationFlags.Cubic;
                else if (RBGet(rbResizeFlagLanczos4)) flag = InterpolationFlags.Lanczos4;
                else flag = InterpolationFlags.Linear;

                return flag;
            }
            catch (Exception ex)
            {
                ERR(ex.ToString());
                return InterpolationFlags.Linear;
            }
        }

        private void btnSubtractOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);

            int x = Convert.ToInt32(TBGet(tbSubtractX));
            int y = Convert.ToInt32(TBGet(tbSubtractY));
            int w = Convert.ToInt32(TBGet(tbSubtractWidth));
            int h = Convert.ToInt32(TBGet(tbSubtractHeight));

            LOG($"Subtract : x {x}, y {y}, w {w}, h {h}\n");

            Cv.Subtract(path, x, y, w, h);
        }

        private void btnBinOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);

            double threshold = Convert.ToDouble(TBGet(tbBinThreshold));
            double max = Convert.ToDouble(TBGet(tbBinMaxValue));
            ThresholdTypes thresholdTypes = GetThresholdTypes();

            LOG($"Binarization : threshold {threshold}, max value {max}\n");

            Cv.Binarization(path, threshold, max, thresholdTypes);
        }

        public ThresholdTypes GetThresholdTypes()
        {
            try
            {
                ThresholdTypes th = ThresholdTypes.Binary;

                if(RBGet(rbBinTypeBinary))
                    th = ThresholdTypes.Binary;
                else if(RBGet(rbBinTypeBinaryInv))
                    th = ThresholdTypes.BinaryInv;
                else if (RBGet(rbBinTypeTrunc))
                    th = ThresholdTypes.Trunc;
                else if (RBGet(rbBinTypeTozero))
                    th = ThresholdTypes.Tozero;
                else if (RBGet(rbBinTypeTozeroInv))
                    th = ThresholdTypes.TozeroInv;
                else if (RBGet(rbBinTypeMask))
                    th = ThresholdTypes.Mask;
                else if (RBGet(rbBinTypeOtsu))
                    th = ThresholdTypes.Otsu;
                else if (RBGet(rbBinTypeTriangle))
                    th = ThresholdTypes.Triangle;

                return th;
            }
            catch (Exception ex)
            {
                ERR(ex.ToString());
                return ThresholdTypes.Binary;
            }
        }

        private void btnAddImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);

            Cv.AddImage(path);
        }

        private void btnSubImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.SubtractImage(path);
        }

        private void btnMulImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.MultiplyImage(path);
        }

        private void btnDivImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.DivideImage(path);
        }

        private void btnMaxImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.MaxImage(path);
        }

        private void btnMinImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.MinImage(path);
        }

        private void btnAbsImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.AbsImage(path);
        }

        private void btnAbsDiffImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.AbsDiffImage(path);
        }

        private void btnAndImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.AndImage(path);
        }

        private void btnOrImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.OrImage(path);
        }

        private void btnXorImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.XorImage(path);
        }

        private void btnNotImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.NotImage(path);
        }

        private void btnCompareImgOpen_Click(object sender, EventArgs e)
        {
            String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            Cv.CompareImage(path);
        }
    }
}
