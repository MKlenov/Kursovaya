//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Userman
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronomyc { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> BirthName { get; set; }
        public Nullable<int> Roleid { get; set; }
        public string Direction { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<double> Rate { get; set; }
        public string Achievements { get; set; }
        public string Education { get; set; }
        public string photo { get; set; }
        public Nullable<int> orderid { get; set; }
        public Nullable<int> Serviceid { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Service Service { get; set; }
    }
}
