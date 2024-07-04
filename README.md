# OpecCvSharp_demo


## Project Description

- OpenCV C# version demo application


## History

- 2024.06.28 : First commit
- File open and apply Opencv api added : first try
- Image open with flag added
- Camera open added
- Video file open added
    - it works well at the first time but after then, blank screen
    - Fixed. Cv2.WaitKey shouldn't be 0, roughtly 33 (30frame)
    - Checks fps of av file and apply to waitkey value
- Color Space Change added (색공간변환)
    - Color Space didn't added all
- Flip mode added
- Zoom in/out added
- Resize absolute/relative added
    - InterpolationFlags option added
- Subtract added with rectangle param
- Binarization added
- Image Math, add/sub/mul/div/max/min/abs/abs diff
- Image bitwise, and/or/xor/not/compare added

## TODO

- Add OpenCV additional features
- Yolo feature
- tflite feature


