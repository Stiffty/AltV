using System.Numerics;
using System.Text.Json.Serialization;

namespace AltV
{
    public class PostionJson
    {
        public string Name { get; set; }
        public long Hash { get; set; }
        public vec3 Position { get; set; }
        public vec3 Rotation { get; set; }

        public PostionJson()
        {
        }
    }

    public struct vec3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public override string ToString() => $"{{{this.X},{this.Y},{this.Z}}}";
    }

}