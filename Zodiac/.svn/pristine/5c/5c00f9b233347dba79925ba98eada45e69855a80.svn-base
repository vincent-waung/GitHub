using System.IO;

namespace MvcZodiac.Areas.TMS_Areas.Controllers
{
    public class NpoiMemoryStream: MemoryStream
    {
        public NpoiMemoryStream()
        {
            AllowClose = true;
        }

        public bool AllowClose { get; set; }

        public override void Close()
        {
            if (AllowClose)
                base.Close();
        }
    }
}