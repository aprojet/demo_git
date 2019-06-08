/* */
//
// classe "Bonjour"
public class Bonjour 
{
	// Declaration des variables
	public String nom = "NGAI NYEMB";
	// Methode principale "main"
	public static void main (String[] args)
	{
		System.out.println("Bonjour tout le monde !!!");
		System.out.println();
		System.out.println("" + getName("Bonjour ") + getName(nom));
	}
	//
	public String getName(String name)
	{
		return "" + name;
	}
	//
	public double somme(double a, double b)
	{
		return (a+b);
	}
}