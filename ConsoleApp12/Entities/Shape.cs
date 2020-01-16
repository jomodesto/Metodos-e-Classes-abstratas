using Metodos_e_classes_abstratas.Entities.Enums;

namespace Metodos_e_classes_abstratas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = Color;
        }

        public abstract double Area();
        
    }
}
