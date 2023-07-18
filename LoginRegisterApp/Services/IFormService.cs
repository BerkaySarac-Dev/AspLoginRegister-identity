using System.Drawing;

namespace LoginRegisterApp.Services
{
    public interface IFormService
    {
       Image ByteToArrayImage(byte[] data);
    }
}
