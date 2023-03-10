using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Employee { get; set; }
    public string Details { get; set; }
    public List<Client> Clients { get; set; }
  }
}