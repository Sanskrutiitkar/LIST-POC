using List_POC__CollegeAPP.Model;

class Program
{
    public static void Main(string[] args)
    {
        //CREATE
        College college1 = new College { collegeId = 1, collegeName = "BVCOE" };
        college1.Departments.Add(new Department { departmentId = 1, departmentName = "CS" });
        college1.Departments.Add(new Department { departmentId = 2, departmentName = "IT" });
        college1.Students.Add(new Student { studentId = 1, studentName = "Ram" });
        college1.Students.Add(new Student { studentId = 2, studentName = "Shyam" });
        college1.Professors.Add(new Professor { professorId = 1, professorName = "Dr. Ramesh shahbde" });
        College.Colleges.Add(college1);

        College college2 = new College { collegeId = 2, collegeName = "TERNA" };
        college2.Departments.Add(new Department { departmentId = 1, departmentName = " EXTC" });
        college2.Departments.Add(new Department { departmentId = 2, departmentName = "MECH" });
        college2.Students.Add(new Student { studentId = 1, studentName = "Sanskruti" });
        college2.Students.Add(new Student { studentId = 2, studentName = "srushti" });
        college2.Professors.Add(new Professor { professorId = 1, professorName = "Dr. Sathe" });
        College.Colleges.Add(college2);

        while (true)
        {
            Console.WriteLine("College APP");
            Console.WriteLine("1. Read College Info");
            Console.WriteLine("2. Update College");
            Console.WriteLine("3. Remove College");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Read
                    Console.Write("Enter College ID to read: ");
                    int inputCollegeId = int.Parse(Console.ReadLine());
                    College.ReadCollegeInfo(inputCollegeId);
                    break;

                case 2:
                    // Update
                    Console.Write("Enter College ID to update: ");
                    int inputCollegeIdUpdate = int.Parse(Console.ReadLine());
                    College.UpdateCollege(inputCollegeIdUpdate);
                    break;

                case 3:
                    // Remove
                    Console.Write("Enter College ID to remove: ");
                    int inputCollegeIdRemove = int.Parse(Console.ReadLine());
                    College.RemoveCollege(inputCollegeIdRemove);
                    break;

                case 4:
                    // Exit
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }





        }

    }
}