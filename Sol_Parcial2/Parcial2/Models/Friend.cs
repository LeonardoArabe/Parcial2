using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Ingrese entre 3 a 30 caracteres")]
        public string Name { get; set; }
        public string NickName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}