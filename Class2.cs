using System;

public class Class1
{
	public Class1()
	{
        using (File.Create(Book1.txt)) { }
    }
}
