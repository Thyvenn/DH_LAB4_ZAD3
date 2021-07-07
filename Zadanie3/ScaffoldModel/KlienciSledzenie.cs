using System;
using System.Collections.Generic;

#nullable disable

namespace Zadanie3.ScaffoldModel
{
    public partial class KlienciSledzenie
    {
        public DateTime? SledzData { get; set; }
        public string SledzTyp { get; set; }
        public int? SlIdklienta { get; set; }
        public string SlNazwa { get; set; }
    }
}
