bool isValidInput = false;

while (!isValidInput) // Döngü yanlışsa dönecek
{
    try
    {
        Console.Write("Lütfen sayı giriniz: ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        Console.WriteLine($"Girdiğiniz sayının karesi: {number * number}");
        isValidInput = true;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Hatalı veri girdiniz. Lütfen bir sayı girin.");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Girdiğiniz sayı çok büyük veya çok küçük. Lütfen daha küçük bir değer girin.");
    }
}
