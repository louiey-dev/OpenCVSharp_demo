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


        public void Blur(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat blur = new Mat();

                Cv2.Blur(src, blur, new Size(9, 9), new Point(-1, -1), BorderTypes.Default);

                Cv2.ImShow("src", src);
                Cv2.ImShow("blur", blur);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void BoxFilter(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat box_filter = new Mat();

                Cv2.BoxFilter(src, box_filter, MatType.CV_8UC3, new Size(9, 9), new Point(-1, -1), true, BorderTypes.Default);

                Cv2.ImShow("src", src);
                Cv2.ImShow("box_filter", box_filter);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void MedianBlur(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat median_blur = new Mat();

                Cv2.MedianBlur(src, median_blur, 9);

                Cv2.ImShow("src", src);
                Cv2.ImShow("median_blur", median_blur);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void GaussianBlur(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat gaussian_blur = new Mat();

                Cv2.GaussianBlur(src, gaussian_blur, new Size(9, 9), 1, 1, BorderTypes.Default);

                Cv2.ImShow("src", src);
                Cv2.ImShow("gaussian_blur ", gaussian_blur);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void BilateralFilter(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat bilateral_filter = new Mat();

                Cv2.BilateralFilter(src, bilateral_filter, 9, 3, 3, BorderTypes.Default);

                Cv2.ImShow("src", src);
                Cv2.ImShow("bilateral_filter  ", bilateral_filter);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void Sobel(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat blur = new Mat();
                Mat sobel = new Mat();

                Cv2.GaussianBlur(src, blur, new Size(3, 3), 1, 0, BorderTypes.Default);

                Cv2.Sobel(blur, sobel, MatType.CV_32F, 1, 0, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
                sobel.ConvertTo(sobel, MatType.CV_8UC1);

                Cv2.ImShow("src", src);
                Cv2.ImShow("sobel   ", sobel);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void Scharr(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat blur = new Mat();
                Mat scharr = new Mat();

                Cv2.GaussianBlur(src, blur, new Size(3, 3), 1, 0, BorderTypes.Default);

                Cv2.Scharr(blur, scharr, MatType.CV_32F, 1, 0, scale: 1, delta: 0, BorderTypes.Default);
                scharr.ConvertTo(scharr, MatType.CV_8UC1);

                Cv2.ImShow("src", src);
                Cv2.ImShow("scharr    ", scharr);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void Laplacian(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat blur = new Mat();
                Mat laplacian = new Mat();

                Cv2.GaussianBlur(src, blur, new Size(3, 3), 1, 0, BorderTypes.Default);

                Cv2.Laplacian(blur, laplacian, MatType.CV_32F, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
                laplacian.ConvertTo(laplacian, MatType.CV_8UC1);

                Cv2.ImShow("src", src);
                Cv2.ImShow("laplacian ", laplacian);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void Canny(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat blur = new Mat();
                Mat canny = new Mat();

                Cv2.GaussianBlur(src, blur, new Size(3, 3), 1, 0, BorderTypes.Default);

                Cv2.Canny(blur, canny, 100, 200, 3, true);

                Cv2.ImShow("src", src);
                Cv2.ImShow("canny  ", canny);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void Contours(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat yellow = new Mat();
                Mat dst = src.Clone();

                Point[][] contours;
                HierarchyIndex[] hierarchy;

                Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
                Cv2.FindContours(yellow, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

                List<Point[]> new_contours = new List<Point[]>();
                foreach (Point[] p in contours)
                {
                    double length = Cv2.ArcLength(p, true);
                    if (length > 100)
                    {
                        new_contours.Add(p);
                    }
                }

                Cv2.ImShow("src", src);
                Cv2.DrawContours(dst, new_contours, -1, new Scalar(255, 0, 0), 2, LineTypes.AntiAlias, null, 1);
                Cv2.ImShow("contours", dst);
                
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void ApproxPoly(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat yellow = new Mat();
                Mat dst = src.Clone();

                Point[][] contours;
                HierarchyIndex[] hierarchy;

                Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
                Cv2.FindContours(yellow, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

                List<Point[]> new_contours = new List<Point[]>();
                foreach (Point[] p in contours)
                {
                    double length = Cv2.ArcLength(p, true);
                    if (length < 100) continue;

                    new_contours.Add(Cv2.ApproxPolyDP(p, length * 0.02, true));
                }

                Cv2.ImShow("src", src);
                Cv2.DrawContours(dst, new_contours, -1, new Scalar(255, 0, 0), 2, LineTypes.AntiAlias, null, 1);
                Cv2.ImShow("contours", dst);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void ContourTest1(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat yellow = new Mat();
                Mat dst = src.Clone();

                Point[][] contours;
                HierarchyIndex[] hierarchy;

                Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
                Cv2.FindContours(yellow, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

                foreach (Point[] p in contours)
                {
                    double length = Cv2.ArcLength(p, true);
                    double area = Cv2.ContourArea(p, true);

                    if (length < 100 && area < 1000 && p.Length < 5) continue;

                    Rect boundingRect = Cv2.BoundingRect(p);
                    RotatedRect rotatedRect = Cv2.MinAreaRect(p);
                    RotatedRect ellipse = Cv2.FitEllipse(p);

                    Point2f center;
                    float radius;
                    Cv2.MinEnclosingCircle(p, out center, out radius);

                    Cv2.Rectangle(dst, boundingRect, Scalar.Red, 2);
                    Cv2.Ellipse(dst, rotatedRect, Scalar.Blue, 2);
                    Cv2.Ellipse(dst, ellipse, Scalar.Green, 2);
                    Cv2.Circle(dst, (int)center.X, (int)center.Y, (int)radius, Scalar.Yellow, 2);
                }

                Cv2.ImShow("src", src);
                Cv2.ImShow("contours", dst);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void ContourTest2(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat yellow = new Mat();
                Mat dst = src.Clone();

                Point[][] contours;
                HierarchyIndex[] hierarchy;

                Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
                Cv2.FindContours(yellow, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

                foreach (Point[] p in contours)
                {
                    double length = Cv2.ArcLength(p, true);
                    double area = Cv2.ContourArea(p, true);

                    if (length < 100 && area < 1000 && p.Length < 5) continue;

                    bool convex = Cv2.IsContourConvex(p);
                    Point[] hull = Cv2.ConvexHull(p, true);
                    Moments moments = Cv2.Moments(p, false);

                    //Cv2.FillConvexPoly(dst, hull, Scalar.White);
                    //Cv2.Polylines(dst, new Point[][] { hull }, true, Scalar.White, 1);
                    Cv2.DrawContours(dst, new Point[][] { hull }, -1, Scalar.White, 1);
                    Cv2.Circle(dst, (int)(moments.M10 / moments.M00), (int)(moments.M01 / moments.M00), 5, Scalar.Black, -1);
                }

                Cv2.ImShow("src", src);
                Cv2.ImShow("contours", dst);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }


        public void WarpAffine(String path, double angle)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dst = new Mat();

                Mat matrix = Cv2.GetRotationMatrix2D(new Point2f(src.Width / 2, src.Height / 2), angle, 1.0);
                Cv2.WarpAffine(src, dst, matrix, new Size(src.Width, src.Height));

                Cv2.ImShow("src", src);
                Cv2.ImShow("WarpAffine", dst);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void AffineTranform(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dst = new Mat();

                List<Point2f> src_pts = new List<Point2f>()
            {
                new Point2f(0.0f, 0.0f),
                new Point2f(0.0f, src.Height),
                new Point2f(src.Width, src.Height)
            };

                List<Point2f> dst_pts = new List<Point2f>()
            {
               new Point2f(300.0f, 300.0f),
               new Point2f(300.0f, src.Height),
               new Point2f(src.Width - 400.0f, src.Height - 200.0f)
            };

                Mat matrix = Cv2.GetAffineTransform(src_pts, dst_pts);
                Cv2.WarpAffine(src, dst, matrix, new Size(src.Width, src.Height));

                Cv2.ImShow("src", src);
                Cv2.ImShow("Affine", dst);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void WarpPerspective(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dst = new Mat();

                List<Point2f> src_pts = new List<Point2f>()
                {
                    new Point2f(0.0f, 0.0f),
                    new Point2f(0.0f, src.Height),
                    new Point2f(src.Width, src.Height),
                    new Point2f(src.Width, 0.0f)
                };

                List<Point2f> dst_pts = new List<Point2f>()
                {
                   new Point2f(300.0f, 100.0f),
                   new Point2f(300.0f, src.Height),
                   new Point2f(src.Width - 400.0f, src.Height - 200.0f),
                   new Point2f(src.Width - 200.0f, 200.0f)
                };

                Mat matrix = Cv2.GetPerspectiveTransform(src_pts, dst_pts);
                Cv2.WarpPerspective(src, dst, matrix, new Size(src.Width, src.Height));

                Cv2.ImShow("src", src);
                Cv2.ImShow("WarpPerspective", dst);

                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }

        public void PerspectiveTransformation(String path)
        {
            try
            {
                Mat src = new Mat(path);
                Mat dilate = new Mat();
                Mat erode = new Mat();
                Mat dst = new Mat();

                Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, new Size(5, 5));
                Cv2.Dilate(src, dilate, element, new Point(2, 2), 3);
                Cv2.Erode(src, erode, element, new Point(-1, -1), 3);

                Cv2.HConcat(new Mat[] { dilate, erode }, dst);


                Cv2.ImShow("src", src);
                Cv2.ImShow("Perspective Transformation", dst);

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
