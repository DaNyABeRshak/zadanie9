using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Zadan5
{


    class RS
    {
        public static int Length { get; set; }

        public static string Id()
        {
            Random r = new Random();
            StringBuilder @string = new StringBuilder();

            for (int i = 0; i < Length; i++)
            {
                @string.Append((Char)r.Next(50, 100));
            }
            return @string.ToString();
        }

        public class Student
        {
            public int Vozrast { get; set; }
            public string FIO { get; set; }
            public string Gruppa { get; set; }
            public string Id { get; set; }
            private string Id1 { get; set; }

            public override string ToString()
            {

                return string.Format("ФИО:{0},Группа:{1},Ваш Возраст:{2}, Id:{3},", FIO, Gruppa, Vozrast, Id);

            }






            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Ваш уникальный идентификатор студента:");
                    Length = 10;
                    Console.WriteLine(RS.Id());
                    Console.WriteLine("Сегодня прекрасный день вот на сегодня дата");
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Введите дату регистрации в формате (DD.MM.YYYY): \n");
                    string input = Console.ReadLine();
                    string[] split = input.Split('.');
                    double day = Double.Parse(split[0]);
                    double month = Double.Parse(split[1]);
                    double year = Double.Parse(split[2]);

                    bool kones = true;
                    ArrayList al = new ArrayList();


                    while (kones)
                    {
                        Console.WriteLine("            Главная меню");
                        PrintMessage();
                        int a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            NewStudent(al);
                        }
                        else if (a == 2)
                        {
                            DeleteStudent(al);
                        }

                        else if (a == 3)
                        {
                            IzmStudenta(al);
                        }

                        else if (a == 4)
                        {
                            Spisok(al);
                        }
                        else if (a == 5)
                        {
                            IdpoSpiskuStudenta(al);

                        }
                        else if (a == 6)
                        {
                            VozrastpoidStudenta(al);

                        }
                        else if (a == 7)
                        {
                            inizialy(al);
                        }
                        else if (a == 8)
                        {
                            vosrast(al);
                        }
                        else if (a == 9)
                        {
                            vosrast1(al);
                        }
                        else if (a == 10)
                        {
                            FindFioStudent(al);
                        }
                    }

                }


                private static void DeleteStudent(ArrayList al)
                {
                    Console.WriteLine("Введите фамилию:");
                    string findFIO = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findFIO == st.FIO)
                        {
                            findSt = st;
                            al.Remove(st);
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }
                }


                private static void IzmStudenta(ArrayList al)
                {
                    Console.WriteLine("Введите фио:");
                    string findFIO = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findFIO == st.FIO)
                        {
                            findSt = st;
                            al.Remove(st);
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }

                    string fio; int vozrast; string grupa;
                    Console.WriteLine("Введите  фио студента для изменения");
                    fio = Console.ReadLine();
                    Console.WriteLine("Возраст дял изменения:");
                    vozrast = int.Parse(Console.ReadLine());
                    Console.WriteLine("Группа для изменения:");
                    grupa = Console.ReadLine();
                    al.Add(new Student { Vozrast = vozrast, FIO = fio, Gruppa = grupa });
                }


                private static void PrintMessage()
                {
                    Console.WriteLine("Для добавления студента нажмите на 1");
                    Console.WriteLine("Для удаления студента нажмите на 2");
                    Console.WriteLine("Для изменения студента нажмите на 3");
                    Console.WriteLine("Для получения списка нажмите на 4");
                    Console.WriteLine("Выводящий по id студента всю информацию о нем нажмите на 5");
                    Console.WriteLine("Выводящий количество лет студента по id нажмите на 6");
                    Console.WriteLine("Выводящий инициал студента  нажмите на 7");
                    Console.WriteLine("Выводящий старше 18 лет студента  нажмите на 8");
                    Console.WriteLine("Выводящий меньше 18 лет студента  нажмите на 9");
                    Console.WriteLine("Поиск по фамилии нажмите на 0");
                }

                private static void Spisok(ArrayList al) //поиск студента для удаления
                {
                    foreach (var item in al)
                    {
                        Student p = (Student)item;
                        Console.WriteLine(p.ToString());
                    }
                }

                private static void NewStudent(ArrayList al) //добавление студента
                {
                    string fio; int vozrast; string grupa; string id;
                    Console.WriteLine("Введите  фио студента");
                    fio = Console.ReadLine();
                    Console.WriteLine("Возраст:");
                    vozrast = int.Parse(Console.ReadLine());
                    Console.WriteLine("Группа:");
                    grupa = Console.ReadLine();
                    Console.WriteLine("Id:");
                    id = Console.ReadLine();
                    al.Add(new Student { Vozrast = vozrast, FIO = fio, Gruppa = grupa, Id = id });

                }
                private static void IdpoSpiskuStudenta(ArrayList al)
                {
                    Console.WriteLine("Введите Id:");
                    string findId = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findId == st.Id)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }
                }
                private static void VozrastpoidStudenta(ArrayList al)
                {
                    Console.WriteLine("Введите Id:");
                    string findAge;
                    findAge = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findAge == st.Id)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.Vozrast); }
                    else { Console.WriteLine(" Студент не найден"); }
                }
                private static void inizialy(ArrayList al)
                {
                    Console.WriteLine("Введите свое ФИО в формате:Смирнов Алексей Дмитриевич");
                    string[] fio = Console.ReadLine().Split(' ');
                    Console.WriteLine(fio[0] + " " + fio[1][0] + " " + fio[2][0]); 
                }
                private static void vosrast(ArrayList al)
                {


                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (st.Vozrast >= 18)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Не найдены"); }



                }
                private static void vosrast1(ArrayList al)
                {


                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (st.Vozrast < 18)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Не найдены"); }



                }
                private static void FindFioStudent(ArrayList al)
                {

                    Console.WriteLine("Введите фамилию:");
                    string findFIO = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findFIO == st.FIO)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }
                }

                private static void LoadStudent(ArrayList al) //загрузка данных
                {
                    al.Add(new Student { Vozrast = 1, FIO = "", Gruppa = "", Id = "" });
                    al.Add(new Student { Vozrast = 2, FIO = "", Gruppa = "", Id = "" });
                    al.Add(new Student { Vozrast = 3, FIO = "", Gruppa = "", Id = "" });
                }

            }

        }
    }

}

