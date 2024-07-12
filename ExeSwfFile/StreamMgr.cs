using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExeSwfFile
{
    internal static class StreamMgr
    {
        public const int BUFFER_SIZE = 0x8024;
        public static void CopyBytesToStream(Stream source, Stream dest, UInt32 totalSize)
        {
            byte[] sdata = new byte[BUFFER_SIZE];
            UInt32 totalRead = 0;
            int toRead = sdata.Length;
            do
            {
                if (totalRead + sdata.Length >= totalSize) toRead = Convert.ToInt32(totalSize - totalRead);
                int rd = source.Read(sdata, 0, toRead);
                dest.Write(sdata, 0, rd);

                totalRead += Convert.ToUInt32(rd);
            } while (totalRead < totalSize);
        }
    }
}
