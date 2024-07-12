using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExeSwfFile
{
    public static class SwfExeCreator
    {
        public static void createExeStream(Stream projectorStream, Stream swfStream, Stream outProjectorStream)
        {
            using (BinaryWriter swfExe = new BinaryWriter(outProjectorStream))
            {
                SwfExeExtractor.extractRawProjectorStream(projectorStream, swfExe.BaseStream);
                StreamMgr.CopyBytesToStream(swfStream, swfExe.BaseStream, Convert.ToUInt32(swfStream.Length));
                swfExe.Write(SwfExeFormat.SWF_PROJ_MAGIC);
                swfExe.Write(Convert.ToUInt32(swfStream.Length));
            }
        }
        public static void CreateExe(String projectorExe, String swfFile, String outSwfExe)
        {
            using (FileStream projectorStream = File.OpenRead(projectorExe))
            {
                using (FileStream swfStream = File.OpenRead(swfFile))
                {
                    using (FileStream outProjectorStream = File.OpenWrite(outSwfExe))
                    {
                        outProjectorStream.SetLength(0);
                        createExeStream(projectorStream, swfStream, outProjectorStream);
                    }
                }
            }
        }
    }
}
