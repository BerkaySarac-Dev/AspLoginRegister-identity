using System.Drawing;

namespace LoginRegisterApp.Services
{
    public class FormService : IFormService
    {
        public Image ByteToArrayImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
    }
}