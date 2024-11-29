
public class Lasana{
    private  int x = 5;
    private int y = 10;

    public bool teste(){
        string z = $"Olá {this.x}!";
        if (this.x == 5 ^ this.y == 10) return true;
        System.Console.WriteLine(z);
        return false;
    }

}