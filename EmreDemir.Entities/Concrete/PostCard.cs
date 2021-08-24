using EmreDemir.Core.Entites.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.Entities.Conrete
{
    public class PostCard: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string PostHeader { get; set; }
        public string PostText { get; set; }
        public string PostOwner { get; set; }
        public string PostCategory { get; set; }
    }
}
