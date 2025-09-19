using Session_02.Contexts;

namespace Session_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyG03DbContext dbContext = new CompanyG03DbContext();

            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

            #region Add
            //Emploee employee = new Emploee()
            //{
            //    //EmpId = 1,
            //    EmpName = "Mohamed Tarek",
            //    Age = 21,
            //    Salary = 50000,
            //    PhoneNumber= "01234567890",
            //    Password = "1234",
            //    Email = "Mohamed@gmail.com"
            //};

            //Console.WriteLine(dbContext.Entry<Emploee>(employee).State); // Detached

            //dbContext.Employees.Add(employee);
            //dbContext.Add(employee);
            //dbContext.Set<Emploee>().Add(employee);
            //dbContext.Entry<Emploee>(employee).State = EntityState.Added;

            //Console.WriteLine(dbContext.Entry<Emploee>(employee).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry<Emploee>(employee).State); // Unchanged

            #endregion

            #region Select
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var Emp = dbContext.Employees.AsNoTracking().Where(E => E.EmpId == 1).FirstOrDefault();
            //var Emp = dbContext.Employees.Where(E => E.EmpId == 1).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State); // Unchanged

            //if (Emp != null)
            //{
            //    Console.WriteLine($"ID : {Emp.EmpId}");
            //    Console.WriteLine($"Name : {Emp.EmpName}");
            //    Console.WriteLine($"Age : {Emp.Age}");
            //    Console.WriteLine($"Salary : {Emp.Salary}");
            //    Console.WriteLine($"Phone Number : {Emp.PhoneNumber}");
            //    Console.WriteLine($"Password : {Emp.Password}");
            //    Console.WriteLine($"Email : {Emp.Email}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            #endregion

            #region Update
            //var Emp = dbContext.Employees.AsNoTracking().Where(E => E.EmpId == 1).FirstOrDefault();
            //var Emp = dbContext.Employees.Where(E => E.EmpId == 1).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State);
            //Console.WriteLine(Emp.EmpName);

            //Emp.EmpName = "Mona Tamer";

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State);
            //Console.WriteLine(Emp.EmpName);

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State);
            //Console.WriteLine(Emp.EmpName);


            #endregion

            #region Delete
            //var Emp = dbContext.Employees.Where(E => E.EmpId == 1).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State);
            //Console.WriteLine(Emp.EmpName);

            //dbContext.Remove(Emp);

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State);
            //Console.WriteLine(Emp.EmpName);

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry<Emploee>(Emp).State);
            //Console.WriteLine(Emp.EmpName);

            #endregion
        }
    }
}
