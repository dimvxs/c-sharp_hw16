using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{
    public class Book: ICloneable, IComparable
    {
// Создать класс Книга(5 полей полей).
// Создать класс Библиотека, который инкапсулирует массив книг.
// Для библиотеки реализовать утипизацию.
// Для Книги реализовать, глубокое копирование(IClonable),
//  сортировка по умолчанию(IComparable), сортировка по определенным критериям (IComparer)


public string Name { get; set; }
public double Price { get; set; }
public int Year { get; set; }

public string Author { get; set; }
public string Genre { get; set; }



public Book(string n, double p, int y, string a, string g){
    Name = n;
    Price = p;
    Year = y;
    Author = a;
    Genre = g;
}
public Book(){
 Write("Book successfully created \n");


 WriteLine("enter the name: ");
string name = ReadLine();
Name = name;

 WriteLine("enter the price: ");
string p = ReadLine();
if(p != null){
int price = int.Parse(p);
Price = price;
}
else{
    Write("incorrect value");
}



 WriteLine("enter the year: ");
string y = ReadLine();
if(y != null){
int year = int.Parse(y);
Year = year;
}
else{
    Write("incorrect value");
}


 WriteLine("enter the author: ");
string author = ReadLine();
Author = author;


 WriteLine("enter the genre: ");
string genre = ReadLine();
Genre = genre;
}

 public object Clone()
    {
        return new Book(Name, Price, Year, Author, Genre);
    }


public override string ToString()
{
    return string.Format("\n{0}, {1:C}, {2}, {3}, {4}", Name, Price, Year, Author, Genre);
}


  public int CompareTo(object obj)
    {
        if(obj is Book)
            return Name.CompareTo((obj as Book).Name);

        throw new NotImplementedException();
    }




public void Print(){
    Write("Name: " + Name + " " + "Price: " + Price + " " + "Year: " + Year + " " + "Author: " + Author + " " + "Genre: " + Genre + "\n");
}

    }
}