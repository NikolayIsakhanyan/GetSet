using System.Runtime.CompilerServices;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Number mytiv = new Number();
        int a = mytiv.Num + mytiv.Num;//ptivatei hamar chi toghnum galisa {get; set;}
        Console.WriteLine(a);
        StringBuilder b = new StringBuilder();
        b.Append("My");
        b.Append("name");
        b.Append("is");
        b.Append("Superman");//ashxatuma ira memory i het avelacnelov
        string esi = "My";
        Console.WriteLine(esi);
        esi = "Name";
        Console.WriteLine(  esi);//var orinak vor chi ashxatum ira het ashxatuma copy i het

        Console.WriteLine(b);
    }

}
public class Number
{
    private int number = 5;
    public int Num
    {
        get { return number; }//privat toghuma ashxatel ira klasi nersum get setov hanum enq
        set { }

    }

}