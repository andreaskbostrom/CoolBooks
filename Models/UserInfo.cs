// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoolBooks.Models
{
    public partial class UserInfo
    {
        [Key]
        public int UserInfoID { get; set; }
        public int UserID { get; set; }
        public int ReviewsID { get; set; }
        public int BooksID { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Adress { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Created { get; set; }

        [ForeignKey(nameof(BooksID))]
        [InverseProperty("UserInfo")]
        public virtual Books Books { get; set; }
        [ForeignKey(nameof(ReviewsID))]
        [InverseProperty("UserInfo")]
        public virtual Reviews Reviews { get; set; }
    }
}