using EmreDemir.Core.Entites.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.Entities.Concrete
{
    public class WhoAmI : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string MyPhotoName { get; set; }
        public string Text { get; set; }
        public string ImgName { get; set; }
        [NotMapped]
        public IFormFile FileImg { get; set; }
        public string Pdf { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
