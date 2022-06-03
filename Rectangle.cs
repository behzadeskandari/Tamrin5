namespace Tamrin5
{
    public class Rectangle : Shape
    {
      private bool isRectangle;
      public Rectangle(int Tooal, int Arrz,bool IsRectangle) : base(Tooal , Arrz)
      {
            this.isRectangle = IsRectangle;
      }


        public override void GetResults()
        {
            if (isRectangle)
            {
                base.GetResults();
            }
            else
            {
                System.Console.WriteLine("Cann't Get The Results");
            }
        }

    }
}