using System;
using System.Collections.Generic;

class Contact
{
  public string Name;
  public string Phone;
  public string Address;
}

class Program
{
  public static void Main()
  {
    Contact hendrix = new Contact();
    hendrix.Name = "Jimi Hendrix";
    hendrix.Phone = "503-890-4820";
    hendrix.Address = "4134 SW 5th St. Portland, OR 82497";

    Contact elvis = new Contact();
    elvis.Name = "Elvis Presley";
    elvis.Phone = "617-356-3571";
    elvis.Address = "Graceland, TN";

    Contact einstein= new Contact();
    einstein.Name = "Albert Einstein";
    einstein.Phone = "415-738-4935";
    einstein.Address = "3718 MLK Blvd. Oakland, CA 94609";
    }
}
