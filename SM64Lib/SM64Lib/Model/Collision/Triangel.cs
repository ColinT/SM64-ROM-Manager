﻿
using Newtonsoft.Json;

namespace SM64Lib.Model.Collision
{
    public class Triangle
    {
        public byte CollisionType { get; set; } = 0;

        public byte[] ColParams { get; set; } = new byte[] { 0, 0 };
        [JsonConverter(typeof(Json.ArrayReferencePreservngConverter))]
        public Vertex[] Vertices { get; set; } = new Vertex[3];

        public TriangleList ParentList { get; set; } = null;

        public int Index
        {
            get
            {
                return ParentList.IndexOf(this);
            }
        }
    }
}