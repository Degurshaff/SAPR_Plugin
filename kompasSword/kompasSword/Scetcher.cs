using Kompas6API5;
using Kompas6Constants3D;


namespace KompasSword
{
    public static class Scetcher
    {
        public static ksEntity CreateScetch(ksPart part, short plane)
        {
            var sketch = (ksEntity)part.NewEntity((short)Obj3dType.o3d_sketch);
            var definition = (ksSketchDefinition)sketch.GetDefinition();
            definition.SetPlane(part.GetDefaultEntity(plane));
            sketch.Create();
            return sketch;
        }
        public static ksDocument2D Edit(this ksSketchDefinition definition)
        {
            return (ksDocument2D)definition.BeginEdit();
        }
    }
}
