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


        public void FlipMode(String path, MatType type, FlipMode mode)
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
    }
}
