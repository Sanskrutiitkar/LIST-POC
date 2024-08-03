using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_POC__CollegeAPP.Model
{
    internal class College
    {
        public int collegeId { get; set; }
        public string collegeName { get; set; }

        public List<Professor> Professors { get; set; } = new List<Professor>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Department> Departments { get; set; } = new List<Department>();
        public static List<College> Colleges { get; set; } = new List<College>();

        //READ --> ALl details
        public static void ReadCollegeInfo(int collegeId)
        {
            College college = null;
            foreach (College clg in Colleges)
            {
                if (clg.collegeId == collegeId)
                {
                    college = clg;
                    break;
                }
            }
            if (college != null)
            {
                Console.WriteLine($"College Name: {college.collegeName}");
                PrintProfessors(college);
                PrintStudents(college);
                PrintDepartments(college);
            }
            else
            {
                Console.WriteLine("College not found.");
            }
        }

        public static void PrintStudents(College college)
        {
            Console.WriteLine("Students:");
            foreach (Student student in college.Students)
            {
                Console.WriteLine($"- ID: {student.studentId}, Name: {student.studentName}");
            }
        }

        public static void PrintProfessors(College college)
        {
            Console.WriteLine("Professors:");
            foreach (Professor professor in college.Professors)
            {
                Console.WriteLine($"- ID: {professor.professorId}, Name: {professor.professorName}");
            }
        }

        public static void PrintDepartments(College college)
        {
            Console.WriteLine("Departments:");
            foreach (Department department in college.Departments)
            {
                Console.WriteLine($"- ID: {department.departmentId}, Name: {department.departmentName}");
            }
        }

        //REMOVE --> college
        public static void RemoveCollege(int collegeId)
        {
            College college = null;
            foreach (College clg in Colleges)
            {
                if (clg.collegeId == collegeId)
                {
                    college = clg;
                    break;
                }
            }
            if (college != null)
            {
                Colleges.Remove(college);
                Console.WriteLine("College removed successfully.");
            }
            else
            {
                Console.WriteLine("College not found.");
            }
        }

        //UPDATE-->college
        public static void UpdateCollege(int collegeId)
        {
            College college = null;
            foreach (College clg in Colleges)
            {
                if (clg.collegeId == collegeId)
                {
                    college = clg;
                    break;
                }
            }
            if (college != null)
            {
                Console.WriteLine("Choose what you want to update:");
                Console.WriteLine("1. College ID");
                Console.WriteLine("2. College Name");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new college ID:");
                        int newCollegeId = int.Parse(Console.ReadLine());
                        college.collegeId = newCollegeId;
                        Console.WriteLine("College ID updated successfully.");
                        break;

                    case 2:
                        Console.WriteLine("Enter new college name:");
                        string newCollegeName = Console.ReadLine();
                        college.collegeName = newCollegeName;
                        Console.WriteLine("College name updated successfully.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("College not found.");
            }
        }
    }

}
