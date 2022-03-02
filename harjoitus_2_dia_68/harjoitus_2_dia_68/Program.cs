alku:
int luku1;
Console.WriteLine("1. Kirjoita ohjelma, joka laskee kaksi numeroa yhteen");
Console.WriteLine("2. Kirjoita ohjelma, joka muuttaa Celsius-asteet Fahrenheiteiksi ");
Console.WriteLine("3. Kirjoita ohjelma, joka tekee kaikki 4 peruslaskutoimitusta annetuille luvuille ");
Console.WriteLine("4. Kirjoita ohjelma, joka palauttaa jakojäännöksen.");
Console.WriteLine("5. Kirjoita ohjelma, joka pyytää käyttäjän nimeä ja palauttaa viestin");
Console.WriteLine("6. Kirjoita tehtävä 1 uudelleen siten, että käyttäjä voi antaa ko. numerot");
Console.WriteLine("7. Kirjoita tehtävä 2 uudelleen siten, että käyttäjä voi antaa Celsius arvon.");
Console.WriteLine("8. Kirjoita tehtävä 3 uudelleen siten, että käyttäjä voi antaa ko. numerot");
Console.WriteLine("9. Kirjoita tehtävä 4 uudelleen siten, että käyttäjä voi antaa ko. numerot");
Console.WriteLine("10. Kirjoita ohjelma, joka kysyy käyttäjältä kokonaislukua välillä 1 – 10 ja tulostaa sitten ko. luvun kertotaulun");
Console.WriteLine("11. Kirjoita ohjelma, joka kysyy käyttäjän ikää");
Console.WriteLine("12. Kirjoita ohjelma, joka pyytää käyttäjältä 10 suuremman kokonaisluvun");
Console.WriteLine("13. Kirjoita ohjelma, joka pyytää sanaa käyttäjältä ja vaihtaa sanan ensimmäisen ja viimeisen kirjaimen keskenään");
Console.WriteLine("14. Kirjoita ohjelma, joka pyytää kahta kokonaislukua käyttäjältä ja tulostaa joko");
Console.WriteLine("15. Kirjoita ohjelma, joka pyytää käyttäjältä lausetta ja tulostaa ko. lauseen pisimmän sanan");
Console.WriteLine("16. Kirjoita ohjelma, joka tulostaa parittomat luvut välillä 1-99");
Console.WriteLine("17. Muuta edellistä ohjelmaa siten, että se tulostaa vain 3:lla jaolliset luvut ");
Console.WriteLine("Valitese numero:");
try
{
    luku1 =  Int32.Parse( Console.ReadLine());
    if (luku1 < 0 || luku1 > 18)
    {
        Console.WriteLine("Ole hyvä ja Syötä numerot väliltä 1-17 ");
        goto alku;
    }

}
catch
{
   
    Console.WriteLine("Ole hyvä ja Syötä numero");
    goto alku;
}

switch (luku1)
{
    case 1:
        function1();
        break;
    case 2:
        function2();
        break;
    case 3:
        function3();
        break;
    case 4:
        function4();
        break;
    case 5:
        function5();
        break;
    case 6:
        function6();
        break;
    case 7:
        function7();
        break;
    case 8:
        function8();
        break;
    case 9:
        function9();
        break;
    case 10:
        function10();
        break;
    case 11:
        function11();
        break;
    case 12:
        function12();
        break;
    case 13:
        function13();
        break;
    case 14:
        function14();
        break;
    case 15:
        function15();
        break;
    case 16:
        function16();
        break;
    case 17:
        function17();
        break;
}


static void function1()
{
    Console.Clear();
    virhe:
    string  a, b;
    Console.WriteLine(" anna luku1:");
    a = Console.ReadLine();
    Console.WriteLine(" anna luku2:");
    b = Console.ReadLine();
    try
    {
        int c = Int32.Parse(a) + Int32.Parse(b);
        Console.WriteLine(a + " + "+ b +" = "+c  );
    }
    catch
    {
        Console.WriteLine("Ole hyvä ja syötä vain numeroa");
        goto virhe;
    }
}
static void function2()
{
    Console.Clear();
virhe:
    string a;

    Console.WriteLine("Anna Fahrenhetiksi arvo :");
    a = Console.ReadLine();
    try
    {
        int b = (Int32.Parse(a) - 32) * 5 / 9;
        Console.WriteLine(a + " Fahrenheitiksi kuin " + b + " Celcium");
    }
    catch
    {
        
        Console.WriteLine("Ole hyvä ja syötä vain numeroa");
        goto virhe;
    }
}
static void function3()
{
    Console.Clear();
    virhe:
    int a, b;
    try
    {
    Console.WriteLine(" anna luku1:");
    a = Int32.Parse(Console.ReadLine());
    Console.WriteLine(" anna luku2:");
    b = Int32.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine(a + " + " + b + " = " + c);
        c = a - b;
        Console.WriteLine(a + " - " + b + " = " + c);
        c = a *b;
        Console.WriteLine(a + " * " + b + " = " + c);
        double d = (double)a / (double)b;
        Console.WriteLine(a + " / " + b + " = " + d.ToString("N2")) ;
    }
    catch
    {
        
        Console.WriteLine("Ole hyvä ja syötä vain numeroa");
        goto virhe;
    }
}
static void function4()
{
    Console.Clear();
    virhe:
    string a, b;
    Console.WriteLine(" anna jakonumero :");
    a = Console.ReadLine();
    Console.WriteLine(" anna jakojanumera:");
    b = Console.ReadLine();
    try
    {
        int c = Int32.Parse(a) % Int32.Parse(b);
        Console.WriteLine(a + " / " + b + " jakojäänöksen on " + c);
    }
    catch
    {
        
        Console.WriteLine("Ole hyvä ja syötä vain numeroa");
        goto virhe;
    }
}
static void function5()
{
    Console.Clear();
    string a;
    Console.WriteLine(" Ole hyvä ja anna nimesi:");
    a = Console.ReadLine();
    
        Console.WriteLine("Hei {0}", a);
    

}
static void function6()
{


}
static void function7()
{
    Console.Clear();
virhe:
    string a;

    Console.WriteLine("Anna Celcium astetta arvo :");
    a = Console.ReadLine();
    try
    {
        int b = (Int32.Parse(a) * 9 / 5) +32;
        Console.WriteLine(a + " Celcium kuin " + b + " Fahrenheitiksi");
    }
    catch
    {
        
        Console.WriteLine("Ole hyvä ja syötä vain numeroa");
        goto virhe;
    }

}
static void function8()
{


}
static void function9()
{

}
static void function10()
{
    Console.Clear();
virhe:
    int a;

    Console.WriteLine("Anna luku valillä 1 - 10");
    
    try
    {
        a = Int32.Parse(Console.ReadLine());
        if (a > 0 && a < 11)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
        }
       else
        {
            Console.WriteLine("Ole hyvä ja syötä numeroa 1 -10");
            goto virhe;
        }
    }
    catch
    {
        Console.WriteLine("Ole hyvä ja syötä vain numeroa");
        goto virhe;
    }


}
static void function11()
{
    Console.Clear();
virhe:
    int a;

    Console.WriteLine("Ole hyvä ja syötä ikaistesi");

    try
    {
        a = Int32.Parse(Console.ReadLine());
        if ( a < 14)
        {
          Console.WriteLine("Näytät ikäistäsi lapsi");
        }
        else if (a < 30)
        {
          Console.WriteLine("Näytät ikäistäsi nuori ");
        }
        else if (a < 50)
        {
            Console.WriteLine("Näytät ikäistäsi keskiikä");
        }
        else
        {
            Console.WriteLine("Näytät ikäistäsi vanha");
        }
    }
    catch
    {
        Console.WriteLine("Ole hyvä ja syötä ikaisi numeroksi");
        goto virhe;
    } 
}
static void function12()
{
    Console.Clear();
virhe:
    int a;
    string tulos="";
    Console.WriteLine("anna luku suuremman 10 : ");
    try
    {
        a = Int32.Parse(Console.ReadLine());
        if (a < 10)
        {
            Console.WriteLine("------Ole hyvä ja syötä suuremman 10--------");
            goto virhe;
        }
    }
    catch
    {
        Console.WriteLine("-------------Ole hyvä ja syötä vain numeroa------------");
        goto virhe;
    }
    Console.WriteLine("--------------------------------------------------------------------------------");
    for (int i = 0; i < a; i++)
    {
        tulos += a.ToString() +" ";
    }
    for(int i = 0; i < a; i++)
    {
        Console.WriteLine(tulos);
        Console.WriteLine(tulos.Replace(" ", ""));
    }
}
static void function13()
{
    Console.Clear();
    virhe:
    string a ="";
    Console.WriteLine(" Ole hyvä ja anna sana:");
    a = Console.ReadLine();
    a = a[a.Length - 1] + a.Substring(1, a.Length - 2) + a[0];
    Console.WriteLine("Hei {0}", a);
    goto virhe;
}
static void function14()
{
    Console.Clear();
virhe:
    int a,b;
    try
    {
        Console.WriteLine("anna luku1 : ");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("anna luku2 : ");
        b = Int32.Parse(Console.ReadLine());
        if (a > 0 && b > 0)
        {
            Console.WriteLine("Molemmat on Positivinen");
        }
        else if (a < 0 && b < 0)
        {
            Console.WriteLine("Molemmat on negativinen");
        }
        else if (a < 0 && b > 0)
        {
            Console.WriteLine("Luku1 on negativinen , Luku2 on Positivinen ");
        }
        else
        {
            Console.WriteLine("Luku2 on negativinen , Luku1 on Positivinen");
        }
    }
    catch
    {
        Console.WriteLine("Ole hyvä ja syötää kokonaisuslukua");
    }
    goto virhe;
}

static void function15()
{
    Console.Clear();
virhe:
    string a = "";
    Console.WriteLine(" Ole hyvä ja anna Lause:");
    a = Console.ReadLine();
    string [] b = a.Split(' ');
    if (b.Length < 2)
    {
        Console.WriteLine(" Syötä lausa jossa voi olla ainekin 2 sana ");
        goto virhe;
    }
    string d = "";
    foreach (string s in b)
    {
        if (d.Length < s.Length)
        {
            d = s;
        }
    }
    Console.WriteLine(d);
    goto virhe;
}
static void function16()
{
    string a = "";
    for(int i = 1; i < 100; i++)
    {
        a = (i % 2 == 0) ? a : a+i + ", ";
    }
    Console.WriteLine(" Parittomat luvut ovat : {0}", a);
}
static void function17()
{
    string a = "";
    for (int i = 1; i < 100; i++)
    {
        a = (i % 3 == 0 && i%2 > 0) ? a + i + ", " : a;
    }
    Console.WriteLine(" vain 3:lla jaolliset luvut ovat  : {0}", a);
}