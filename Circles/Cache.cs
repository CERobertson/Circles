using System;
using System.IO;

namespace Circles {
    public class Cache {
        static Cache() {
            using (BinaryReader br = new BinaryReader(File.OpenRead("CirclePoints_60585"))) {
                var cache_size = br.ReadInt32();
                CirclePoints = new CirclePoint[cache_size];
                for (int i = 0; i < cache_size; i++) {
                    CirclePoints[i] = new CirclePoint(
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32());
                }
            }
        }
        public static ICirclePoint[] CirclePoints { get; }
    }
    public class CirclePoint : ICirclePoint {
        public CirclePoint(int x, int y, int n, int c) {
            this.x = x;
            this.y = y;
            this.n = n;
            this.c = c;
        }
        public int x { get; }
        public int y { get; }
        public int n { get; }
        public int c { get; }
    }
    public interface ICirclePoint {
        int x { get; }
        int y { get; }
        int n { get; }
        int c { get; }
    }
}
