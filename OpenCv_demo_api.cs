using OpenCvSharp;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCVSharp_demo
{
    public partial class Form1 : Form
    {
        public void OpenCv_ImgOpen()
        {
            try
            {
                String path = ShowFileOpenDialog(FILE_FILTER_IMAGE);
                //var src = new Mat("lenna.png", ImreadModes.Grayscale);
                var src = new Mat(path, ImreadModes.Grayscale);
                var dst = new Mat();

                //Cv2.Canny(src, dst, 50, 200);
                /*using (new Window("src image", src))
                using (new Window("dst image", dst))
                {
                    Cv2.WaitKey();
                }*/
                Cv2.ImShow("press any key to exit", src);
               // Cv2.ImShow("dst image", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception e) { ERR(e.ToString()); }
        }

        public void OpenCv_CameraOpen()
        {
            try
            {
                VideoCapture video = new VideoCapture(0);
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

        const String FILE_FILTER_IMAGE = "그림 파일 (*.jpg, *.gif, *.bmp, *.png, *.svd) | *.jpg; *.gif; *.bmp; *.png; *.svd; | 모든 파일 (*.*) | *.*";
        const String FILE_FILTER_VIDEO = "비디오 파일 (*.mp4, *.avi, *.mpeg) | *.mp4; *.avi; *.mpeg; | 모든 파일 (*.*) | *.*";

        public String ShowFileOpenDialog(String fileFilter)
        {
            try
            {
                //파일오픈창 생성 및 설정
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "이미지 열기";
                ofd.FileName = "image";
                //ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp, *.png, *.svd) | *.jpg; *.gif; *.bmp; *.png; *.svd; | 모든 파일 (*.*) | *.*";
                ofd.Filter = fileFilter;
                ofd.InitialDirectory = Application.StartupPath; // 현재 실행파일 경로를 사용하도록 설정


                //파일 오픈창 로드
                DialogResult dr = ofd.ShowDialog();

                //OK버튼 클릭시
                if (dr == DialogResult.OK)
                {
                    //File명과 확장자를 가지고 온다.
                    String fileName = ofd.SafeFileName;
                    //File경로와 File명을 모두 가지고 온다.
                    String fileFullName = ofd.FileName;
                    //File경로만 가지고 온다.
                    String filePath = fileFullName.Replace(fileName, "");

                    //File경로 + 파일명 리턴
                    return fileFullName;
                }
                //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
                else if (dr == DialogResult.Cancel)
                {
                    return "";
                }

                return "";
            }
            catch (Exception e)
            {
                ERR(e.ToString());
                return "";
            }
        }
    }
}
