using System.Globalization;
using OpenTK.Mathematics;

namespace MiodenusAnimationConverter.Scene.Models.Meshes
{
    public struct Transformation
    {
        public Vector3 Location;
        public Quaternion Rotation;
        public Vector3 Scale;

        public Transformation(Vector3 location, Quaternion rotation, Vector3 scale)
        {
            Location = location;
            Rotation = rotation;
            Scale = scale;
        }

        public void Reset()
        {
            Location = Vector3.Zero;
            Rotation = Quaternion.Identity;
            Scale = Vector3.One;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                    $"Transformation: [ Location: ({Location.X}, {Location.Y}, {Location.Z}) "
                    + $"| Rotation: ({Rotation.X}, {Rotation.Y}, {Rotation.Z}, {Rotation.W}) "
                    + $"| Scale: ({Scale.X}, {Scale.Y}, {Scale.Z}) ]");
        }
    }
}