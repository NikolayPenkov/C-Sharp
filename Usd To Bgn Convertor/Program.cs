const decimal usdToBgn = 1.79549m;


decimal usd = decimal.Parse(Console.ReadLine());

decimal resultInBgn = usd *  usdToBgn;
Console.WriteLine(resultInBgn);