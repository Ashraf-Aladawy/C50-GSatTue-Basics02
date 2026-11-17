namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            Book book = new Book() { title = "ASP.net", pages = 100 };
            object obj = book;
            Console.WriteLine(obj.ToString());
            #endregion endQuestion1

            #region Question2

            //Console.WriteLine("ToString(): " + book.ToString());

            //Console.WriteLine("Equals(): " + book.Equals(book));

            //Console.WriteLine("GetHashCode(): " + book.GetHashCode());

            //Console.WriteLine("GetType(): " + book.GetType());
            #endregion endQuestion2

            #region Question3
            /*
             int pages = "646";
            -Compile time error(can, t assign string to int)
            -fix: using TryParse() or Parse() or Convert.ToInt32();
            */
            //int pagesUsingParse = int.Parse("646");
            //Console.WriteLine($"Pages: {pagesUsingParse}");
            //int pagesUsingTryParse;
            //bool isParsed = int.TryParse("646", out pagesUsingTryParse);
            //if (isParsed)
            //{
            //    Console.WriteLine($"Pages (using TryParse): {pagesUsingTryParse}");
            //}
            //int pagesUsingConvert = Convert.ToInt32("646");
            //Console.WriteLine($"Pages (using Convert.ToInt32): {pagesUsingConvert}");
            #endregion endQuestion3

            #region Question4


            //int x = 10, y = 0;
            //try
            //{
            //    Console.WriteLine(x / y);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}

            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question5

            //int pages = 300;
            //double pagesInDouble = pages;
            //Console.WriteLine($"Pages in double: {pagesInDouble}");
            #endregion

            #region Question6

            //double price = 49.99;
            //int priceInInt = Convert.ToInt32(price);
            //Console.WriteLine($"Price in integer: {priceInInt}");
            #endregion

            #region Question7

            //string pagesText = "464";
            //int pagesFromText = Convert.ToInt32(pagesText);
            //Console.WriteLine($"Pages from text: {pagesFromText}");
            #endregion

            #region Question8

            //string yearText = "2023";
            //int yearFromText = Convert.ToInt32(yearText);
            //string badText = "abc";
            //int yearsInInt;
            //bool isValid = int.TryParse(badText, out yearsInInt);
            //if (isValid)
            //{
            //    Console.WriteLine($"Years from text: {yearsInInt}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region Question9

            //int pagess = 464;
            //string pagesInString = pagess.ToString();
            //Console.WriteLine($"Pages in string: {pagesInString}");
            //Console.WriteLine("pagesInString.GetType(): " + pagesInString.GetType());
            #endregion

            #region Question10

            //int copies = 100;
            //object copiesBoxing = copies;
            //int copiesUnboxing = (int)copiesBoxing;
            //Console.WriteLine($"Copies in Boxing: {copiesBoxing}");
            //Console.WriteLine($"Copies in Unboxing: {copiesUnboxing}");
            #endregion

            #region Question11

            //int? year = null;
            //Console.WriteLine($"Year: {year}");
            //year = 2023;
            //Console.WriteLine($"Year: {year}");
            #endregion

            #region Question12

            //string? reviewer = null;

            //if (reviewer == null)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            #endregion

            #region Question13

            //Book? book1 = null;
            //Console.WriteLine(book1?.title);
            #endregion

            #region Question14
            //string bookTitle = book1?.title ?? "Untitled";
            //Console.WriteLine(bookTitle);
            //Console.WriteLine(book1?.title ?? "Untitled");

            #endregion

            #region Question15
            //string? name = "Ahmed";
            //string confirmedName = name!;
            #endregion


        }




    }
}