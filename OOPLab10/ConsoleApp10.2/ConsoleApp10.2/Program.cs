using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Dictionary<int, TeachersWorkload> workloadDictionary = new Dictionary<int, TeachersWorkload>();

        workloadDictionary.Add(1, new TeachersWorkload("Математика", 1, 20, new SemesterControlInfo()));
        workloadDictionary.Add(2, new TeachersWorkload("Фізика", 2, 25, new SemesterControlInfo("Залік", "100-бальна", DateTime.Now, DateTime.Now.AddDays(7), 3)));

        Console.WriteLine("Елементи Dictionary:");
        foreach (var pair in workloadDictionary)
        {
            Console.WriteLine($"Ключ: {pair.Key}, Значення: {pair.Value}");
        }

        int searchKey = 1;
        if (workloadDictionary.ContainsKey(searchKey))
        {
            Console.WriteLine($"\nЗнайдено за ключем {searchKey}: {workloadDictionary[searchKey]}");
        }

        workloadDictionary.Remove(1);
        Console.WriteLine("\nПісля видалення елемента:");
        foreach (var pair in workloadDictionary)
        {
            Console.WriteLine($"Ключ: {pair.Key}, Значення: {pair.Value}");
        }

        Console.WriteLine($"Кількість елементів у Dictionary: {workloadDictionary.Count}");

        workloadDictionary.Clear();
        Console.WriteLine($"Dictionary очищено. Кількість елементів: {workloadDictionary.Count}");
    }
}

public class TeachersWorkload
{
    public string SubjectName;
    public int Semester;
    public int StudentCount;
    public SemesterControlInfo SemesterControl;

    public TeachersWorkload() { }
    public TeachersWorkload(string subjectName, int semester, int studentCount, SemesterControlInfo semesterControl)
    {
        SubjectName = subjectName;
        Semester = semester;
        StudentCount = studentCount;
        SemesterControl = semesterControl;
    }

    public override string ToString()
    {
        return $"Назва предмета: {SubjectName}, Семестр: {Semester}, Кількість студентів: {StudentCount}";
    }
}

public class SemesterControlInfo
{
    public string ControlForm;
    public string Scale;
    public DateTime ExaminationDate;
    public DateTime ResultsFillingDate;
    public int Hours;

    public SemesterControlInfo() { }
    public SemesterControlInfo(string controlForm, string scale, DateTime examinationDate, DateTime resultsFillingDate, int hours)
    {
        ControlForm = controlForm;
        Scale = scale;
        ExaminationDate = examinationDate;
        ResultsFillingDate = resultsFillingDate;
        Hours = hours;
    }

    public override string ToString()
    {
        return $"Контроль: {ControlForm}, Шкала: {Scale}, Дата іспиту: {ExaminationDate.ToShortDateString()}";
    }
}
