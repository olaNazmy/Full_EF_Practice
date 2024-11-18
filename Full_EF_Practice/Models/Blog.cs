using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_EF_Practice.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public List<Post> Posts {  get; set; }


    }
}
