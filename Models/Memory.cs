using System;

namespace codificando_api.Models
{
  public class Memory
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateTime { get; set; }

    public override string ToString() => Title;
  }
}