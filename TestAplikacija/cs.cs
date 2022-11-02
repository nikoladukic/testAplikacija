using System;

public class Person
{
	string ime;
	string prezime;
	int godine;
	public Person(global::System.String ime, global::System.String prezime)
	{
		this.ime = ime;
		this.prezime = prezime;
	}
	public static void ispis()
	{
		global::System.Console.WriteLine("ovo je globalno");
	}

	



}
