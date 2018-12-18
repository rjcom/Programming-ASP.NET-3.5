using System.Collections.Generic;
using System.Linq;

public class BookStats
{
   public int Sales { get; set; }
   public int Pages { get; set; }
   public int Rank { get; set; }
   public string ISBN { get; set; }

   public static IEnumerable<BookStats> GetBookStats()
   {
      BookStats[] stats = {
         new BookStats { ISBN = "0596529562", Pages=904, Rank=1, Sales=109000},
         new BookStats { ISBN = "0596527438", Pages=607, Rank=2, Sales=58000},
         new BookStats { ISBN = "059652756X", Pages=704, Rank=3, Sales=75000},
         new BookStats { ISBN = "0596518455", Pages=552, Rank=4, Sales=120000},
         new BookStats { ISBN = "0596518439", Pages=752, Rank=5, Sales=37500}
      };

      return stats.OfType<BookStats>();
   }
}
