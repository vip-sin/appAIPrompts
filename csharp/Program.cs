// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// create a local data source for list of students with their names, surname, id and list of scores for 5 subjects

var students = new List<Student>
{
    new Student{Name = "Kari", Surname = "Thornton", Id = 1, Scores = new List<int> {1, 2, 3, 4, 5}},
        new Student{Name = "Karim", Surname = "Mornton", Id = 2, Scores = new List<int> {6, 7, 8, 9, 10}},
        new Student{Name = "gh",Surname = "Thornton", Id = 3, Scores = new List<int>{1, 2, 3, 4, 5}},
};
// create a query to select students whose name contains "Th"

var query = from s in students
            where s.Name.Contains("Th")
            select s;

var result = query.ToList();
foreach (var student in result)
{
    Console.WriteLine("test", student.Name + " " + student.Surname);
    Console.WriteLine("{0},{1},{2}", student.Id, student.Name, student);
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<int> Scores { get; set; }

}