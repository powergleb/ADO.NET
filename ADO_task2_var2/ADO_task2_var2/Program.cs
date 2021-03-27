using ADO_task2_var2.InputValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.Design;
using ADO_task2_var2.Entities;

namespace ADO_task2_var2
{
    class Program
    {

        static void Main(string[] args)
        {


            
            GetMan();
            GetStudent();
            GetAuthor();
            GetBook();
            Console.ReadKey();
            
        }
        private static double GetDouble()
        {
            FormatterResult<double> res;
            do
            {
                string input = Console.ReadLine();
                res = StringFormatter.GetDouble(input);

                if (res.IsValid)
                {
                    Console.WriteLine("Нармальна!");
                }
                else
                {
                    Console.WriteLine("Ашыпки:");
                    string s = string.Join(Environment.NewLine, res.Errors.Select(xs => xs.Message));
                    Console.WriteLine(s);

                }
            }
            while (!res.IsValid);

            return res.Value;
        }
        private static int GetInt()
        {
            FormatterResult<int> res = null;
            do
            {
                string inp = Console.ReadLine();
                res = StringFormatter.GetInt(inp);

                if (res.IsValid)
                {
                    Console.WriteLine("Нармальна!");
                }
                else
                {
                    Console.WriteLine("Ашыпки:");
                    string s = string.Join(Environment.NewLine, res.Errors.Select(xs => xs.Message));
                    Console.WriteLine(s);

                }
            }
            while (!res.IsValid);

            return res.Value;
        }
        private static string GetWord()
        {
            FormatterResult<string> res = null;
            do
            {
                string inp = Console.ReadLine();
                res = StringFormatter.GetString(inp);

                if (res.IsValid)
                {
                    Console.WriteLine("Нармальна!");
                }
                else
                {
                    Console.WriteLine("Ашыпки:");
                    string s = string.Join(Environment.NewLine, res.Errors.Select(xs => xs.Message));
                    Console.WriteLine(s);

                }
            }
            while (!res.IsValid);

            return res.Value;
        }
        private static DateTime GetDateTime()
        {
            FormatterResult<DateTime> res = null;
            do
            {
                string input = Console.ReadLine();
                res = StringFormatter.GetDateTime(input);

                if (res.IsValid)
                {
                    Console.WriteLine("Нармальна!");
                }
                else
                {
                    Console.WriteLine("Ашыпки:");
                    string s = string.Join(Environment.NewLine, res.Errors.Select(xs => xs.Message));
                    Console.WriteLine(s);

                }
            }
            while (!res.IsValid);

            return res.Value;
        }




        private static Man GetMan()
        {
            Console.WriteLine($"Введите Имя:");
            string name = GetWord();
            Console.WriteLine($"Введите возраст");
            int age = GetInt();
            Console.WriteLine($"Введите вес");
            double weight = GetDouble();
            Console.WriteLine($"Введите рост");
            int height = GetInt();

            Man man = new Man(name, age, weight, height);

            Console.WriteLine($"Имя:{man.Name}");
            Console.WriteLine($"Возраст{man.Age}");
            Console.WriteLine($"Вес{man.Weight}");
            Console.WriteLine($"Рост{man.Height}");
            var m = $"Человек:" +
             $"Имя:{man.Name}" +
             $"Возраст{man.Age}" +
             $"Вес{man.Weight}" +
             $"Рост{man.Height}";
            Console.WriteLine(m);

            return man;
        }
        private static Student GetStudent()
        {
            Student student;
            Man man = GetMan();
            Console.WriteLine($"Введите курс");
            int cource = GetInt();
            Console.WriteLine($"Введите год начала обучения ");
            int yearOfStart = GetInt();
            Console.WriteLine($"Введите номер группы");
            int group = GetInt();
            student = new Student(cource, yearOfStart, group, man);
            var m = $"Студент:" +
             $"Имя:{student.Name}" +
             $"Возраст{student.Age}" +
             $"Вес{student.Weight}" +
             $"Рост{student.Height}" +
             $"Курс:{student.Cource}" +
             $"Год начала обучения{student.YearOfStart}" +
             $"Номер группы{student.Group}";

            Console.WriteLine(m);



            return student;
        }
        private static Author GetAuthor()
        {
            Author author;
            Console.WriteLine("Введите имя автора");
            string name = GetWord();
            Console.WriteLine("Введите фамилию автора");
            string secondname = GetWord();
            Console.WriteLine("Введите дату рождения");
            DateTime date = GetDateTime();
            author = new Author(name, secondname, date);
            Console.WriteLine($"Имя:{author.Name}");
            Console.WriteLine($"Возраст{author.SecondName}");
            Console.WriteLine($"Дата рождения{author.BirthDate}");

            var m = $"Автор:" +
             $"Имя:{author.Name}" +
             $"Возраст{author.SecondName}" +
             $"Дата рождения{author.BirthDate}";

            Console.WriteLine(m);

            return author;
        }

        private static Book GetBook()
        {
            Book book;
            Console.WriteLine("Введите название книги");
            string name = GetWord();
            Console.WriteLine("Введите количество страниц");
            int numberOfPages = GetInt();
            Console.WriteLine("Введите публикующую компанию");
            string publisher = GetWord();
            Console.WriteLine("Введите дату публикации");
            DateTime publicationDate = GetDateTime();
            Console.WriteLine("Введите дату написания");
            DateTime writingDate = GetDateTime();
            Author author = GetAuthor();
            book = new Book(name, numberOfPages, publisher, publicationDate, writingDate, author);
            
            var m = $"Название книги:{book.Name}" +
             $"Возраст{book.NumberOfPages}" +
             $"Публикующая компания:{book.Publisher}" +
             $"Дата публикации{book.PublicationDate}" +
             $"Дата написания:{book.WritingDate}" +
             $"Автор:" +
             $"Имя:{author.Name}" +
             $"Возраст{author.SecondName}" +
             $"Дата рождения{author.BirthDate}";

            Console.WriteLine(m);
            
            return book;
        }

    }
    
    







}

