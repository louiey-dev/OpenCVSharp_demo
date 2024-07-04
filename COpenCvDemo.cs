using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCVSharp_demo
{
    internal class COpenCvDemo
    {
        public delegate void Log(String str);
        public delegate void Err(String str);
        public delegate void Dbg(String str);

        private readonly Log LOG = null;
        private readonly Err ERR = null;
        private readonly Dbg DBG = null;

        String version;

        public COpenCvDemo(Log _log, Err _err, Dbg _dbg)
        {
            LOG = _log;
            ERR = _err;
            DBG = _dbg;

            version = Cv2.GetVersionString();
            LOG("OpenCV version : " + version + "\n");
        }

        public void ImgOpen(String path)
        {
            try
            {
                var src = new Mat(path, ImreadModes.Unchanged);

                Cv2.ImShow("press any key to exit", src);                
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e) { ERR(e.ToString()); }
        }

        public void ImgOpen(String path, ImreadModes imgMode)
        {
            try
            {
                var src = new Mat(path, imgMode);

                Cv2.ImShow("press any key to exit", src);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e) { ERR(e.ToString()); }
        }

        public void CameraOpen(int camNumber)
        {
            try
            {
                VideoCapture video = new VideoCapture(camNumber);
                Mat frame = new Mat();

                while (Cv2.WaitKey(33) != 'q')
                {
                    video.Read(frame);
                    Cv2.ImShow("Press \"q\" button to exit", frame);
                }

                frame.Dispose();
                video.Release();
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void AvFileOpen(String path)
        {
            try
            {
                VideoCapture av = new VideoCapture(path);
                Mat frame = new Mat();
                int fps = ((int)av.Fps);

                LOG("fps : " + fps.ToString() + "\n");

                while (av.PosFrames != av.FrameCount)
                {
                    av.Read(frame);
                    Cv2.ImShow(path, frame);
                    if(Cv2.WaitKey(fps) != -1)
                    {
                        LOG("End of AV play\n");
                        break;
                    }
                    //Cv2.WaitKey(0);
                }

                frame.Dispose();
                av.Release();
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void ColorSpaceChange(String path, MatType channel, ColorConversionCodes colorCode)
        {
            try
            {
                Mat src = Cv2.ImRead(path);
                Mat dst = new Mat(src.Size(), channel);

                Cv2.CvtColor(src, dst, colorCode);

                Cv2.ImShow("Color Space Mode", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void FlipImgMode(String path, MatType type, FlipMode mode)
        {
            try
            {
                Mat src = Cv2.ImRead(path);
                Mat dst = new Mat(src.Size(), type);

                Cv2.Flip(src, dst, mode);

                Cv2.ImShow("FlipMode", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void Zoom(String path, bool inout, int width, int height, BorderTypes borderType)
        {
            try
            {
                Mat src = new Mat(path);
                Mat pyr = new Mat();
                Size size = new Size(width, height);

                if (inout)
                    Cv2.PyrUp(src, pyr, size, borderType);
                else
                    Cv2.PyrDown(src, pyr, size, borderType);

                Cv2.ImShow("Zoom In", pyr);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void Zoom(String path, bool inout)
        {
            try
            {
                Mat src = new Mat(path);
                Mat pyr = new Mat();

                if(inout)
                    Cv2.PyrUp(src, pyr);
                else
                    Cv2.PyrDown(src, pyr);

                Cv2.ImShow("Zoom In", pyr);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void ResizeAbsolute(String path, InterpolationFlags flag, int width, int height)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dst = new Mat();

                Cv2.Resize(src, dst, new Size(width, height), 0, 0, flag);

                Cv2.ImShow("src", src);
                Cv2.ImShow("dst", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch(Exception e) { ERR(e.ToString());}
        }

        public void ResizeRelative(String path, InterpolationFlags flag, int width, int height)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dst = new Mat();

                Cv2.Resize(src, dst, new Size(0, 0), width, height, flag);

                Cv2.ImShow("src", src);
                Cv2.ImShow("dst", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e) { ERR(e.ToString()); }
        }


        public void Subtract(String path, int x, int y, int width, int height)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dst = src.SubMat(new Rect(x, y, width, height));

                Cv2.ImShow("src", src);
                Cv2.ImShow($"dst x {x} y {y} w {width} h {height}", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void Binarization(String path, double threshold, double maxValue, ThresholdTypes thType)
        {
            try
            {
                Mat src = new Mat(path);
                Mat gray = new Mat();
                Mat binary = new Mat();

                Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(gray, binary, 150, 255, thType);

                Cv2.ImShow("src", src);
                Cv2.ImShow("binary", binary);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void AddImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat add = new Mat();

                Cv2.Add(src, val, add);

                Cv2.ImShow("src", src);
                Cv2.ImShow("add", add);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void SubtractImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat sub = new Mat();

                Cv2.Subtract(src, val, sub);

                Cv2.ImShow("src", src);
                Cv2.ImShow("sub", sub);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void MultiplyImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat mul = new Mat();

                Cv2.Multiply(src, val, mul);

                Cv2.ImShow("src", src);
                Cv2.ImShow("mul", mul);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void DivideImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat div = new Mat();

                Cv2.Divide(src, val, div);

                Cv2.ImShow("src", src);
                Cv2.ImShow("div", div);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }
        public void MaxImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat max = new Mat();

                Cv2.Max(src, val, max);

                Cv2.ImShow("src", src);
                Cv2.ImShow("max", max);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void MinImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat min = new Mat();

                Cv2.Min(src, val, min);

                Cv2.ImShow("src", src);
                Cv2.ImShow("min", min);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void AbsImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat abs = new Mat();
                Mat mul = new Mat();

                Cv2.Multiply(src, val, mul);

                abs = Cv2.Abs(mul);

                Cv2.ImShow("src", src);
                Cv2.ImShow("abs", abs);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void AbsDiffImage(String path)
        {
            try
            {
                Mat src = new Mat(path, ImreadModes.ReducedColor2);
                Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
                Mat mul = new Mat();
                Mat absdiff = new Mat();

                Cv2.Multiply(src, val, mul);

                Cv2.Absdiff(src, mul, absdiff);

                Cv2.ImShow("src", src);
                Cv2.ImShow("absdiff", absdiff);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void AndImage(String path)
        {
            try
            {
                Mat src1 = new Mat(path, ImreadModes.ReducedColor2);
                Mat src2 = src1.Flip(FlipMode.Y);
                Mat and = new Mat();

                Cv2.BitwiseAnd(src1, src2, and);

                Cv2.ImShow("src", src1);
                Cv2.ImShow("and", and);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void OrImage(String path)
        {
            try
            {
                Mat src1 = new Mat(path, ImreadModes.ReducedColor2);
                Mat src2 = src1.Flip(FlipMode.Y);
                Mat or = new Mat();

                Cv2.BitwiseOr(src1, src2, or);

                Cv2.ImShow("src", src1);
                Cv2.ImShow("or", or);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void XorImage(String path)
        {
            try
            {
                Mat src1 = new Mat(path, ImreadModes.ReducedColor2);
                Mat src2 = src1.Flip(FlipMode.Y);
                Mat xor = new Mat();

                Cv2.BitwiseXor(src1, src2, xor);

                Cv2.ImShow("src", src1);
                Cv2.ImShow("xor", xor);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void NotImage(String path)
        {
            try
            {
                Mat src1 = new Mat(path, ImreadModes.ReducedColor2);
                Mat not = new Mat();

                Cv2.BitwiseNot(src1, not);

                Cv2.ImShow("src", src1);
                Cv2.ImShow("not", not);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void CompareImage(String path)
        {
            try
            {
                Mat src1 = new Mat(path, ImreadModes.ReducedColor2);
                Mat src2 = src1.Flip(FlipMode.Y);
                Mat cmp = new Mat();

                Cv2.Compare(src1, src2, cmp, CmpType.EQ);

                Cv2.ImShow("src", src1);
                Cv2.ImShow("cmp", cmp);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }
    }
}
