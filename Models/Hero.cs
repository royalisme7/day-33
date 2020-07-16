using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace superhero.Models
{
    public class Hero
    {
        [Key]
        
      public int SuperHeroName { get; set; }
      public string Ego { get; set; }
      public string PrimaryAbility { get; set; }
      public string SecondaryAbility { get; set; }
      public string CatchPhrase { get; set; }

    }

    
    

}
 