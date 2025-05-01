namespace Base.Domain.Consts;

public static class DefaultRoles
{
    public partial class Admin
    {
        public const string Name = nameof(Admin);
        public const string Id = "0191d311-2918-7f76-bd8a-0bded8535075";
        public const string ConcurrencyStamp = "0191d311-2918-7f76-bd8a-0be08dd83078";
    }


    public partial class User
    {
        public const string Name = nameof(User);
        public const string Id = "0191d311-2918-7f76-bd8a-0bdf740adff8";
        public const string ConcurrencyStamp = "0191d311-2918-7f76-bd8a-0be100f11384";
    }

    public partial class Doctor
    {
        public const string Name = nameof(Doctor);
        public const string Id = "0191d311-2918-7f76-bd8a-0bdf740adff9";
        public const string ConcurrencyStamp = "0191d311-2918-7f76-bd8a-0bdf740adff9";
    }

    public partial class Student
    {
        public const string Name = nameof(Student);
        public const string Id = "0191d311-2918-7f76-bd8a-0bdf740adfA9";
        public const string ConcurrencyStamp = "0191d311-2918-7f76-bd8a-0bdf740adfA9";
    }

}
