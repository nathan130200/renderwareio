﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RenderWareBuilders
{
    public class Triangle
    {
        internal ushort Index { get; set; }
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public Vertex Vertex3 { get; set; }
        public Material Material { get; set; }
    }
}
