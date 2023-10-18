﻿using SapphireD.Core.Memory;

namespace SapphireD.Core.Data.Chunks.FrameChunks.Events.Parameters
{
    public class ParameterEvery : ParameterChunk
    {
        public int Delay;
        public int Compteur;

        public ParameterEvery()
        {
            ChunkName = "ParameterEvery";
        }

        public override void ReadCCN(ByteReader reader, params object[] extraInfo)
        {
            Delay = reader.ReadInt();
            Compteur = reader.ReadInt();
        }
    }
}
