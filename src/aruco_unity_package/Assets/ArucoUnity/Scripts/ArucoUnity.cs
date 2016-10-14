﻿using System.Runtime.InteropServices;
using ArucoUnity.Utility;
using UnityEngine;

namespace ArucoUnity
{
  public enum PREDEFINED_DICTIONARY_NAME
  {
    DICT_4X4_50 = 0,
    DICT_4X4_100,
    DICT_4X4_250,
    DICT_4X4_1000,
    DICT_5X5_50,
    DICT_5X5_100,
    DICT_5X5_250,
    DICT_5X5_1000,
    DICT_6X6_50,
    DICT_6X6_100,
    DICT_6X6_250,
    DICT_6X6_1000,
    DICT_7X7_50,
    DICT_7X7_100,
    DICT_7X7_250,
    DICT_7X7_1000,
    DICT_ARUCO_ORIGINAL
  }

  public enum CALIB
  {
    USE_INTRINSIC_GUESS = 0x00001,
    FIX_ASPECT_RATIO = 0x00002,
    FIX_PRINCIPAL_POINT = 0x00004,
    ZERO_TANGENT_DIST = 0x00008,
    FIX_FOCAL_LENGTH = 0x00010,
    FIX_K1 = 0x00020,
    FIX_K2 = 0x00040,
    FIX_K3 = 0x00080,
    FIX_K4 = 0x00800,
    FIX_K5 = 0x01000,
    FIX_K6 = 0x02000,
    RATIONAL_MODEL = 0x04000,
    THIN_PRISM_MODEL = 0x08000,
    FIX_S1_S2_S3_S4 = 0x10000,
    TILTED_MODEL = 0x40000,
    FIX_TAUX_TAUY = 0x80000,
    FIX_INTRINSIC = 0x00100,
    SAME_FOCAL_LENGTH = 0x00200,
    ZERO_DISPARITY = 0x00400,
    USE_LU = (1 << 17)
  };


  public class Methods
  {
    [DllImport("ArucoUnity")]
    static extern double au_calibrateCameraAruco1(System.IntPtr corners, System.IntPtr ids, System.IntPtr counter, System.IntPtr board, 
    System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, out System.IntPtr tvecs, int flags, 
    System.IntPtr criteria, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern double au_calibrateCameraAruco2(System.IntPtr corners, System.IntPtr ids, System.IntPtr counter, System.IntPtr board, 
    System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, out System.IntPtr tvecs, int flags, 
    System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern double au_calibrateCameraAruco3(System.IntPtr corners, System.IntPtr ids, System.IntPtr counter, System.IntPtr board, 
    System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, out System.IntPtr tvecs, 
    System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern double au_calibrateCameraAruco4(System.IntPtr corners, System.IntPtr ids, System.IntPtr counter, System.IntPtr board, 
    System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern double au_calibrateCameraAruco5(System.IntPtr corners, System.IntPtr ids, System.IntPtr counter, System.IntPtr board, 
    System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_detectMarkers1(System.IntPtr image, System.IntPtr dictionary, out System.IntPtr corners, out System.IntPtr ids,
      System.IntPtr parameters, out System.IntPtr rejectedImgPoints, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_detectMarkers2(System.IntPtr image, System.IntPtr dictionary, out System.IntPtr corners, out System.IntPtr ids,
      System.IntPtr parameters, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_detectMarkers3(System.IntPtr image, System.IntPtr dictionary, out System.IntPtr corners, out System.IntPtr ids,
      System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_drawDetectedMarkers1(System.IntPtr image, System.IntPtr corners, System.IntPtr ids, System.IntPtr borderColor, 
      System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_drawDetectedMarkers2(System.IntPtr image, System.IntPtr corners, System.IntPtr ids, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_drawDetectedMarkers3(System.IntPtr image, System.IntPtr corners, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_drawDetectedMarkers4(System.IntPtr image, System.IntPtr corners, System.IntPtr borderColor, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_estimatePoseSingleMarkers(System.IntPtr corners, float markerLength, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, 
      out System.IntPtr rvecs, out System.IntPtr tvecs, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern System.IntPtr au_generateCustomDictionary1(int nMarkers, int markerSize, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern System.IntPtr au_generateCustomDictionary2(int nMarkers, int markerSize, System.IntPtr baseDictionary, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern System.IntPtr au_getPredefinedDictionary(PREDEFINED_DICTIONARY_NAME name);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers1(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, float minRepDistance, float errorCorrectionRate, 
      bool checkAllOrders, System.IntPtr recoveredIdxs, System.IntPtr parameters, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers2(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, float minRepDistance, float errorCorrectionRate, 
      bool checkAllOrders, System.IntPtr recoveredIdxs, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers3(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, float minRepDistance, float errorCorrectionRate, 
      bool checkAllOrders, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers4(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, float minRepDistance, float errorCorrectionRate, 
      System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers5(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, float minRepDistance, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers6(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers7(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds, 
      System.IntPtr rejectedCorners, System.IntPtr cameraMatrix, System.IntPtr exception);

    [DllImport("ArucoUnity")]
    static extern void au_refineDetectedMarkers8(System.IntPtr image, System.IntPtr board, System.IntPtr detectedCorners, System.IntPtr detectedIds,
      System.IntPtr rejectedCorners, System.IntPtr exception);

    public static double CalibrateCameraAruco(VectorVectorPoint2f corners, VectorInt ids, VectorInt counter, Board board, Size imageSize, 
      Mat cameraMatrix, Mat distCoeffs, out VectorMat rvecs, out VectorMat tvecs, int flags, TermCriteria criteria) 
    {
      Exception exception = new Exception();
      System.IntPtr rvecsPtr, tvecsPtr;

      double reProjectionError = au_calibrateCameraAruco1(corners.cvPtr, ids.cvPtr, counter.cvPtr, board.cvPtr, imageSize.cvPtr, cameraMatrix.cvPtr, 
        distCoeffs.cvPtr, out rvecsPtr, out tvecsPtr, flags, criteria.cvPtr, exception.cvPtr);
      rvecs = new VectorMat(rvecsPtr);
      tvecs = new VectorMat(tvecsPtr);

      exception.Check();
      return reProjectionError;
    }

    public static double CalibrateCameraAruco(VectorVectorPoint2f corners, VectorInt ids, VectorInt counter, Board board, Size imageSize,
      Mat cameraMatrix, Mat distCoeffs, out VectorMat rvecs, out VectorMat tvecs, int flags) 
    {
      Exception exception = new Exception();
      System.IntPtr rvecsPtr, tvecsPtr;

      double reProjectionError = au_calibrateCameraAruco2(corners.cvPtr, ids.cvPtr, counter.cvPtr, board.cvPtr, imageSize.cvPtr, cameraMatrix.cvPtr, 
        distCoeffs.cvPtr, out rvecsPtr, out tvecsPtr, flags, exception.cvPtr);
      rvecs = new VectorMat(rvecsPtr);
      tvecs = new VectorMat(tvecsPtr);

      exception.Check();
      return reProjectionError;
    }

    public static double CalibrateCameraAruco(VectorVectorPoint2f corners, VectorInt ids, VectorInt counter, Board board, Size imageSize,
      Mat cameraMatrix, Mat distCoeffs, out VectorMat rvecs, out VectorMat tvecs) 
    {
      Exception exception = new Exception();
      System.IntPtr rvecsPtr, tvecsPtr;

      double reProjectionError = au_calibrateCameraAruco3(corners.cvPtr, ids.cvPtr, counter.cvPtr, board.cvPtr, imageSize.cvPtr, cameraMatrix.cvPtr, 
        distCoeffs.cvPtr, out rvecsPtr, out tvecsPtr, exception.cvPtr);
      rvecs = new VectorMat(rvecsPtr);
      tvecs = new VectorMat(tvecsPtr);

      exception.Check();
      return reProjectionError;
    }

    public static double CalibrateCameraAruco(VectorVectorPoint2f corners, VectorInt ids, VectorInt counter, Board board, Size imageSize,
      Mat cameraMatrix, Mat distCoeffs, out VectorMat rvecs) 
    {
      Exception exception = new Exception();
      System.IntPtr rvecsPtr;

      double reProjectionError = au_calibrateCameraAruco4(corners.cvPtr, ids.cvPtr, counter.cvPtr, board.cvPtr, imageSize.cvPtr, cameraMatrix.cvPtr, 
        distCoeffs.cvPtr, out rvecsPtr, exception.cvPtr);
      rvecs = new VectorMat(rvecsPtr);
      
      exception.Check();
      return reProjectionError;
    }

    public static double CalibrateCameraAruco(VectorVectorPoint2f corners, VectorInt ids, VectorInt counter, Board board, Size imageSize,
      Mat cameraMatrix, Mat distCoeffs) 
    {
      Exception exception = new Exception();
      
      double reProjectionError = au_calibrateCameraAruco5(corners.cvPtr, ids.cvPtr, counter.cvPtr, board.cvPtr, imageSize.cvPtr, cameraMatrix.cvPtr, 
        distCoeffs.cvPtr, exception.cvPtr);
      
      exception.Check();
      return reProjectionError;
    }

    public static void DetectMarkers(Mat image, Dictionary dictionary, out VectorVectorPoint2f corners,
      out VectorInt ids, DetectorParameters parameters, out VectorVectorPoint2f rejectedImgPoints)
    {
      Exception exception = new Exception();
      System.IntPtr cornersPtr, idsPtr, rejectedPtr;

      au_detectMarkers1(image.cvPtr, dictionary.cvPtr, out cornersPtr, out idsPtr, parameters.cvPtr, out rejectedPtr, exception.cvPtr);
      corners = new VectorVectorPoint2f(cornersPtr);
      ids = new VectorInt(idsPtr);
      rejectedImgPoints = new VectorVectorPoint2f(rejectedPtr);

      exception.Check();
    }

    public static void DetectMarkers(Mat image, Dictionary dictionary, out VectorVectorPoint2f corners,
      out VectorInt ids, DetectorParameters parameters)
    {
      Exception exception = new Exception();
      System.IntPtr cornersPtr, idsPtr;

      au_detectMarkers2(image.cvPtr, dictionary.cvPtr, out cornersPtr, out idsPtr, parameters.cvPtr, exception.cvPtr);
      corners = new VectorVectorPoint2f(cornersPtr);
      ids = new VectorInt(idsPtr);

      exception.Check();
    }

    public static void DetectMarkers(Mat image, Dictionary dictionary, out VectorVectorPoint2f corners,
      out VectorInt ids)
    {
      Exception exception = new Exception();
      System.IntPtr cornersPtr, idsPtr;

      au_detectMarkers3(image.cvPtr, dictionary.cvPtr, out cornersPtr, out idsPtr, exception.cvPtr);
      corners = new VectorVectorPoint2f(cornersPtr);
      ids = new VectorInt(idsPtr);

      exception.Check();
    }

    public static void DrawDetectedMarkers(Mat image, VectorVectorPoint2f corners, VectorInt ids, Color borderColor)
    {
      Exception exception = new Exception();
      Scalar borderColorScalar = borderColor;
      au_drawDetectedMarkers1(image.cvPtr, corners.cvPtr, ids.cvPtr, borderColorScalar.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void DrawDetectedMarkers(Mat image, VectorVectorPoint2f corners, VectorInt ids)
    {
      Exception exception = new Exception();
      au_drawDetectedMarkers2(image.cvPtr, corners.cvPtr, ids.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void DrawDetectedMarkers(Mat image, VectorVectorPoint2f corners)
    {
      Exception exception = new Exception();
      au_drawDetectedMarkers3(image.cvPtr, corners.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void DrawDetectedMarkers(Mat image, VectorVectorPoint2f corners, Color borderColor)
    {
      Exception exception = new Exception();
      Scalar borderColorScalar = borderColor;
      au_drawDetectedMarkers4(image.cvPtr, corners.cvPtr, borderColorScalar.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void EstimatePoseSingleMarkers(VectorVectorPoint2f corners, float markerLength, VectorMat cameraMatrix, VectorMat distCoeffs,
      out VectorMat rvecs, out VectorMat tvecs)
    {
      Exception exception = new Exception();
      System.IntPtr rvecsPtr, tvecsPtr;
      
      au_estimatePoseSingleMarkers(corners.cvPtr, markerLength, cameraMatrix.cvPtr, distCoeffs.cvPtr, out rvecsPtr, out tvecsPtr, exception.cvPtr);
      rvecs = new VectorMat(rvecsPtr);
      tvecs = new VectorMat(tvecsPtr);

      exception.Check();
    }

    public static Dictionary GenerateCustomDictionary(int nMarkers, int markerSize)
    {
      Exception exception = new Exception();
      System.IntPtr dictionaryPtr = au_generateCustomDictionary1(nMarkers, markerSize, exception.cvPtr);
      exception.Check();
      return new Dictionary(dictionaryPtr);
    }

    public static Dictionary GenerateCustomDictionary(int nMarkers, int markerSize, Dictionary baseDictionary)
    {
      Exception exception = new Exception();
      System.IntPtr dictionaryPtr = au_generateCustomDictionary2(nMarkers, markerSize, baseDictionary.cvPtr, exception.cvPtr);
      exception.Check();
      return new Dictionary(dictionaryPtr);
    }

    public static Dictionary GetPredefinedDictionary(PREDEFINED_DICTIONARY_NAME name)
    {
      return new Dictionary(au_getPredefinedDictionary(name));
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds, 
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate, 
      bool checkAllOrders, ref VectorInt recoveredIdxs, DetectorParameters parameters) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers1(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr, 
        distCoeffs.cvPtr, minRepDistance, errorCorrectionRate, checkAllOrders, recoveredIdxs.cvPtr, parameters.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate,
      bool checkAllOrders, ref VectorInt recoveredIdxs) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers2(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr,
        distCoeffs.cvPtr, minRepDistance, errorCorrectionRate, checkAllOrders, recoveredIdxs.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate,
      bool checkAllOrders) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers3(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr,
        distCoeffs.cvPtr, minRepDistance, errorCorrectionRate, checkAllOrders, exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance, float errorCorrectionRate) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers4(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr,
        distCoeffs.cvPtr, minRepDistance, errorCorrectionRate, exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix, Mat distCoeffs, float minRepDistance) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers5(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr,
        distCoeffs.cvPtr, minRepDistance, exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix, Mat distCoeffs) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers6(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr,
        distCoeffs.cvPtr, exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners, Mat cameraMatrix) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers7(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, cameraMatrix.cvPtr,
        exception.cvPtr);
      exception.Check();
    }

    public static void RefineDetectedMarkers(Mat image, Board board, ref VectorVectorPoint2f detectedCorners, ref VectorInt detectedIds,
      ref VectorVectorPoint2f rejectedCorners) 
    {
      Exception exception = new Exception();
      au_refineDetectedMarkers8(image.cvPtr, board.cvPtr, detectedCorners.cvPtr, detectedIds.cvPtr, rejectedCorners.cvPtr, exception.cvPtr);
      exception.Check();
    }
  }
}