using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExeSwfFile
{
    public static class SwfExeExtractor
    {

        internal static void extractRawProjectorStream(Stream inProjectorStream, Stream outProjectorStream)
        {
            using (BinaryReader pexe = new BinaryReader(inProjectorStream))
            {
                pexe.BaseStream.Seek(-8, SeekOrigin.End);
                UInt32 magic = pexe.ReadUInt32();
                UInt32 swfSize = pexe.ReadUInt32();

                UInt64 rawProjectorSize = Convert.ToUInt64(pexe.BaseStream.Length);
                if (magic == SwfExeFormat.SWF_PROJ_MAGIC) rawProjectorSize -= (8 + swfSize);

                pexe.BaseStream.Seek(0, SeekOrigin.Begin);
                StreamMgr.CopyBytesToStream(pexe.BaseStream, outProjectorStream, Convert.ToUInt32(rawProjectorSize));
            }
        }
        public static void ExtractRawProjector(String bundledProjectorExe, String rawProjectorExe)
        {
            using (FileStream bundledProjectorStream = File.OpenRead(bundledProjectorExe))
            {
                using (FileStream rawProjectorStream = File.OpenWrite(rawProjectorExe))
                {
                    rawProjectorStream.SetLength(0);
                    extractRawProjectorStream(bundledProjectorStream, rawProjectorStream);
                }
            }
        }

        internal static void extractSwfStream(Stream projectorStream, Stream swfStream)
        {
            using (BinaryReader pexe = new BinaryReader(projectorStream))
            {
                pexe.BaseStream.Seek(-8, SeekOrigin.End);
                UInt32 magic = pexe.ReadUInt32();
                UInt32 swfSize = pexe.ReadUInt32();

                if (magic == SwfExeFormat.SWF_PROJ_MAGIC)
                {
                    pexe.BaseStream.Seek(((swfSize + 8) / -1), SeekOrigin.End);
                    StreamMgr.CopyBytesToStream(pexe.BaseStream, swfStream, swfSize);
                }
                else
                {
                    throw new InvalidDataException("magic number was not 0x" + SwfExeFormat.SWF_PROJ_MAGIC.ToString("X") + " (got: 0x" + magic.ToString("X") + ")");
                }
            }
        }
        public static void ExtractSwf(String bundledProjectorExe, String swfFile)
        {
            using (FileStream projectorStream = File.OpenRead(bundledProjectorExe))
            {
                using (FileStream swfStream = File.OpenWrite(swfFile))
                {
                    swfStream.SetLength(0);
                    extractSwfStream(projectorStream, swfStream);
                }
            }
        }
    }
}
