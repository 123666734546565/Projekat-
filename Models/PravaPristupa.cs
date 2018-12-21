using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekat_20_dec_v_2.Models
{
    public class PravaPristupa
    {
        public PravaPristupa() { }

        public PravaPristupa(ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }

        public string  Id { get; set; }
        public string  Name { get; set; }
    }
}