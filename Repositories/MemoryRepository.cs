using System;
using System.Collections.Generic;
using System.Linq;
using codificando_api.Models;

namespace codificando_api.Repositories
{
  public class MemoryRepository
  {
    public static List<Memory> Memories { get; set; } = new List<Memory>
    {
        new Memory {
          Id = 1,
          Content = "Contenido de la memoria",
          Title = "Memoria 1",
          DateTime = DateTime.Now
        },
        new Memory {
          Id = 2,
          Content = "Contenido de la memoria",
          Title = "Memoria 2",
          DateTime = DateTime.Now
        },
        new Memory {
          Id = 3,
          Content = "Contenido de la memoria",
          Title = "Memoria 3",
          DateTime = DateTime.Now
        }
    };
  }
}