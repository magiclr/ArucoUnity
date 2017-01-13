#include "aruco_unity/utility/cv/calib3d.hpp"
#include "aruco_unity/utility/cv/exception.hpp"

extern "C" {
  // Static member functions
  void au_calib3d_Rodrigues(cv::Vec3d* src, cv::Mat** dst, cv::Exception* exception) {
    try {
      *dst = new cv::Mat();
      cv::Rodrigues(*src, **dst);
    }
    catch (const cv::Exception& e) {
      ARUCO_UNITY_COPY_EXCEPTION(exception, e);
      return;
    }
  }
}