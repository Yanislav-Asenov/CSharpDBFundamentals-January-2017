//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gringotts.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WizzardDeposit
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Age { get; set; }
        public string MagicWandCreator { get; set; }
        public Nullable<short> MagicWandSize { get; set; }
        public string DepositGroup { get; set; }
        public Nullable<System.DateTime> DepositStartDate { get; set; }
        public Nullable<decimal> DepositAmount { get; set; }
        public Nullable<decimal> DepositInterest { get; set; }
        public Nullable<decimal> DepositCharge { get; set; }
        public Nullable<System.DateTime> DepositExpirationDate { get; set; }
        public Nullable<bool> IsDepositExpired { get; set; }
    }
}
