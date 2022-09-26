
demonstrate1();

//Section 2
static void demonstrate1()
{
    //Creating the actual product object and setting attributes
    ExamSection2.Product product1 = new ExamSection2.Product("11111", "Computer", 99.99M);
    //Calling functions from Product class
    Console.WriteLine(product1.showDescription());
    Console.WriteLine(product1.showPrice());
    Console.WriteLine();

    //Creating a book object and setting attributes
    ExamSection2.Book book1 = new ExamSection2.Book("22222","Book", 199.99m, "Andrew Moore");
    //Calling functions from Product class
    Console.WriteLine(book1.showDescription());
    Console.WriteLine(book1.showPrice());
    //Calling function specific to Book class
    Console.WriteLine(book1.showAuthor());
    Console.WriteLine();

    //Creating a software object and setting attributes
    ExamSection2.Software software1 = new ExamSection2.Software("33333", "Software", 299.99m, "Version 1.0");
    //Calling functions from Product class
    Console.WriteLine(software1.showDescription());
    Console.WriteLine(software1.showPrice());
    //Calling function specific to Software Class
    Console.WriteLine(software1.showVersion());
    Console.WriteLine();

    //Question 4
    ExamSection2.Stacks.createStack();


}