using System.Runtime.InteropServices;

namespace ArucoUnity.Plugin
{
  public static partial class Std
  {
    public class VectorMat : Utility.HandleCppPtr
    {
      // Native functions

      [DllImport("ArucoUnityPlugin")]
      static extern System.IntPtr au_std_vectorMat_new();

      [DllImport("ArucoUnityPlugin")]
      static extern void au_std_vectorMat_delete(System.IntPtr vector);

      [DllImport("ArucoUnityPlugin")]
      static extern System.IntPtr au_std_vectorMat_at(System.IntPtr vector, uint pos, System.IntPtr exception);

      [DllImport("ArucoUnityPlugin")]
      static extern unsafe System.IntPtr* au_std_vectorMat_data(System.IntPtr vector);

      [DllImport("ArucoUnityPlugin")]
      static extern void au_std_vectorMat_push_back(System.IntPtr vector, System.IntPtr value);

      [DllImport("ArucoUnityPlugin")]
      static extern uint au_std_vectorMat_size(System.IntPtr vector);

      // Constructors & destructor

      public VectorMat() : base(au_std_vectorMat_new())
      {
      }

      public VectorMat(System.IntPtr vectorMatPtr, Utility.DeleteResponsibility deleteResponsibility = Utility.DeleteResponsibility.True)
        : base(vectorMatPtr, deleteResponsibility)
      {
      }

      protected override void DeleteCppPtr()
      {
        au_std_vectorMat_delete(CppPtr);
      }

      // Methods

      public Cv.Mat At(uint pos)
      {
        Cv.Exception exception = new Cv.Exception();
        Cv.Mat element = new Cv.Mat(au_std_vectorMat_at(CppPtr, pos, exception.CppPtr), Utility.DeleteResponsibility.False);
        exception.Check();
        return element;
      }

      public unsafe Cv.Mat[] Data()
      {
        System.IntPtr* dataPtr = au_std_vectorMat_data(CppPtr);
        uint size = Size();

        Cv.Mat[] data = new Cv.Mat[size];
        for (int i = 0; i < size; i++)
        {
          data[i] = new Cv.Mat(dataPtr[i], Utility.DeleteResponsibility.False);
        }

        return data;
      }

      public void PushBack(Cv.Mat value)
      {
        au_std_vectorMat_push_back(CppPtr, value.CppPtr);
      }

      public uint Size()
      {
        return au_std_vectorMat_size(CppPtr);
      }
    }
  }
}