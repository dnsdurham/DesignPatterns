
namespace DesignPatterns.Creational.AbstractFactory
{
    enum Resolution
    {
        Lo,
        Hi
    }
    class AfClient
    {
        public Resolution Resolution { get; set; }
        // ...
        public void DoDraw()
        {
            // ...
            switch (Resolution)
            {
                case Resolution.Lo:
                    // use LRDD
                    break;
                case Resolution.Hi:
                    // use HRDD
                    break;
            }
        }

        public void DoPrint()
        {
            //...
            switch (Resolution)
            {
                case Resolution.Lo:
                    // use LRDD
                    break;
                case Resolution.Hi:
                    // use HRDD
                    break;
            }
        }
    }
}
