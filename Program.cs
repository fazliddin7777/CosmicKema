using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        string koordinat = Console.ReadLine();

        
        MySpaceShip(koordinat);
    }

    private static void MySpaceShip(string koordinat)
    {
        SpaceShip spaceShip = new SpaceShip();

        for(int i = 0; i < koordinat.Length; i++)
        {
            if(koordinat[i] == 'R' && spaceShip.Direction == "yuqori")
            {
                spaceShip.Direction = "o'ng";
            }

            else if(koordinat[i] == 'R' && spaceShip.Direction == "o'ng")
            {
                spaceShip.Direction = "past";
            }
            
            else if(koordinat[i] == 'R' && spaceShip.Direction == "past")
            {
                spaceShip.Direction = "chap";
            }

            else if(koordinat[i] == 'R' && spaceShip.Direction == "chap")
            {
                spaceShip.Direction = "yuqori";
            }

            if(koordinat[i] == 'L' && spaceShip.Direction == "yuqori")
            {
                spaceShip.Direction = "o'ng";
            }

            else if(koordinat[i] == 'L' && spaceShip.Direction == "o'ng")
            {
                spaceShip.Direction = "past";
            }

            else if(koordinat[i] == 'L' && spaceShip.Direction == "past")
            {
                spaceShip.Direction = "chap";
            }

            else if(koordinat[i] == 'L' && spaceShip.Direction == "chap")
            {
                spaceShip.Direction = "yuqori";
            }

            if(koordinat[i] == 'A' && spaceShip.Direction == "yuqori")
            {
                spaceShip.Y--;
            }

            else if(koordinat[i] == 'A' && spaceShip.Direction == "o'ng")
            {
                spaceShip.X++;
            }

            else if(koordinat[i] == 'A' && spaceShip.Direction == "past")
            {
                spaceShip.Y++;
            }

            else if(koordinat[i] == 'A' && spaceShip.Direction == "chap")
            {
                spaceShip.X--;
            }
        }
        Console.WriteLine($"x: {spaceShip.X}, y: {spaceShip.Y}, direction: '{spaceShip.Direction}'");
    }
}