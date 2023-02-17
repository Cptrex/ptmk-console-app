using PTMKConsoleApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMKConsoleApp.Models.ViewModels
{
    public class ClientViewModel
    {
        public string FullName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }

    }
}
