using System;
    internal class qno3

{ 

    internal class Distance
    {
       private  int feet, inches;
        public Distance() { }
        public Distance(int feet, int inches)
        {
            this.feet = feet;
            this.inches = inches;

            while (this.inches >= 12)
            {
                this.inches -= 12;
                this.feet++;
            }
        }

        public Distance addDistance(Distance d1)
        {
            int tmpFeet = this.feet;
            int tmpInches = this.inches;
            tmpFeet += d1.feet;
            tmpInches += d1.inches;

            while (tmpInches >= 12)
            {
                tmpInches -= 12;
                tmpFeet++;
            }

            return new Distance(tmpFeet, tmpInches);
        }

        public void displayDistance()
        {
            Console.WriteLine(" This is "  +this.feet+ " "+ "Feets " +"And" +" " +this.inches+" Inches.");
        }
    }
    internal class MyDistance
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(18, 20);
            d1.displayDistance();

            Distance d2 = new Distance(10, 20);
            Distance d3 = d1.addDistance(d2);

            d3.displayDistance();
            Console.ReadKey();
        }
       
    }
}
