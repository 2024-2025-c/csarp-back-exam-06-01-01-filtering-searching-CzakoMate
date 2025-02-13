using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Dtos.Query
{
    public class StudentQueryDto
    {
        public string NamePart {  get; set; } =string.Empty;
        public int BirthYear { get; set; }
        public int BirthMonth { get; set;}
        public bool IsGenderFilteringNeeded { get; set; }
        public bool IsWoman {  get; set; }

        //BirthYear ==0 -> nem kell szűrni
        //BirthMomnth ==0 vagy > 12 -> nem kell szűrni
        //NamePart=string.Empty -> nem kell szűrni
    }
}
