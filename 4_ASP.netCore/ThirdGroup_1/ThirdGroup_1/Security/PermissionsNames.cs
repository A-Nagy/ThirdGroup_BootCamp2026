namespace ThirdGroup_1.Security
{
    public class PermissionsNames
    {
        public const string ClaimType = "Permission";
        //Employee
        public const string EmployeesView   = "Employee.View";
        public const string EmployeesCreate = "Employee.Create";
        public const string EmployeesEdit   = "Employee.Edit";
        public const string EmployeesDelete = "Employee.Delete";
        //Department
        public const string DepartmentsView   = "Department.View";
        public const string DepartmentsCreate = "Department.Create";
        public const string DepartmentsEdit   = "Department.Edit";
        public const string DepartmentsDelete = "Department.Delete";
        //All Permissions
        public static readonly string[] All =
        {
                EmployeesView    , 
                EmployeesCreate  ,
                EmployeesEdit    ,
                EmployeesDelete  ,
                DepartmentsView  ,
                DepartmentsCreate,
                DepartmentsEdit  ,
                DepartmentsDelete
        };
    }
}
