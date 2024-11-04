using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Library: IEnumerator, IEnumerable
    {

        int curpos = -1;
        Book[] books;




      public Library(Book[] books)
        {
            this.books = books;
        }


 public Library(int len)
    {
        books = new Book[len];
        for (int i = 0; i < len; i++)
        {
            books[i] = new Book();
        }
    }


  public void ShowBooks()
    {
        for (int i = 0; i < books.Length; i++)
            books[i].Print();
    }




           public IEnumerator GetEnumerator()
    {
        Console.WriteLine("\nВыполняется метод GetEnumerator");
        // возвращается ссылка на объект класса, реализующего перечислитель
        return this;
    }

    // реализация перечислителя
    #region enumerator

    //Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции
    public void Reset()
    {
        Console.WriteLine("\nВыполняется метод Reset");
        curpos = -1;
    }
    public object Current // Получает текущий элемент в коллекции
    {
        get
        {
            Console.WriteLine("\nВыполняется свойство Current");
            return books[curpos];
        }
    }

    // Перемещает перечислитель к следующему элементу коллекции
    public bool MoveNext()
    {
        Console.WriteLine("\nВыполняется метод MoveNext");
        if (curpos < books.Length - 1)
        {
            curpos++;
            return true;
        }
        else
        {
            Reset();
            return false;
        }

    }
    #endregion enumerator

    }
}