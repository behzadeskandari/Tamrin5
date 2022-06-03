namespace Tamrin5
{
    public class Shape
    {
        private int Tooal;
        private int Arrz;
        public int Masahat;
        public Shape(int Tooal,int Arrz)
        {
            this.Arrz = Arrz;
            this.Tooal = Tooal;
        }


        public virtual void GetResults(){

            Masahat = Arrz * Tooal;
            //System.Console.WriteLine("Base Get Results is Called");
        }
    }
}