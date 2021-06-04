using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinFTEntities = new HashSet<FlavorTreat>();
    }
    
    public int FlavorId { get; set; }
    public string Type { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinFTEntities { get; }
  }
}