// See https://aka.ms/new-console-template for more information

class MamWylewException : Exception
{

}

throw new ArgumentNullException("Coś się mocno zepsuło :)");

throw new MamWylewException();

try
{
    var x = int.Parse(Console.ReadLine());
    var y = int.Parse(Console.ReadLine());

    Console.WriteLine($"{x / y}");

    //var f = File.OpenRead("C:\\plik_ktory_nie_istnieje.txt");
}
catch (FileNotFoundException ex)
    when (ex.FileName == "jacek placek")
{
    Console.WriteLine(ex.Message);
}
catch (FileNotFoundException ex)
{

}
catch (Exception ex)
{
    Console.WriteLine("Pamiętaj cholero nie dziel przez 0!");
}
finally
{
    Console.WriteLine("Zawsze czy był czy nie było wyjątku");
}
