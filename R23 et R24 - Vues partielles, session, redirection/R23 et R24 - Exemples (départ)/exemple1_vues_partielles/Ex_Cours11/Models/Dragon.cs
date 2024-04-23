using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours11.Models
{
    public class Dragon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public Dragon(int id, string name, string imgUrl)
        {
            Id = id;
            Name = name;
            ImgUrl = imgUrl;
        }

        public Dragon() { }
    }
}
