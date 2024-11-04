// See https://aka.ms/new-console-template for more information
using hw;

Console.WriteLine("Hello, World!");



Book[] books = new Book[5];
            books[0] = new Book("Война и мир", 500, 1869, "Лев Толстой", "Роман");
            books[1] = new Book("Преступление и наказание", 300, 1866, "Федор Достоевский", "Роман");
            books[2] = new Book("Мастер и Маргарита", 450, 1967, "Михаил Булгаков", "Фантастика");
            books[3] = new Book("Евгений Онегин", 350, 1833, "Александр Пушкин", "Поэма");
            books[4] = new Book("Анна Каренина", 400, 1877, "Лев Толстой", "Роман");

            Console.WriteLine("Неупорядоченный массив:");
            foreach (Book book in books)
            {
                book.Print();
            }

            // Сортируем массив книг по умолчанию (по имени)
            Array.Sort(books);

            Console.WriteLine("\nУпорядоченный массив:");
            foreach (Book book in books)
            {
                book.Print();
            }



             Library library = new(books);
        foreach (Book temp in library)
            temp.Print();
     