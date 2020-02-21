using Cars.Api.Models;
using System.Collections.Generic;

namespace Cars.Api
{
    public class CarsDataStore
    {
        public static CarsDataStore current { get; set; }
            = new CarsDataStore();
        public List<BrandDto> Brands { get; set; }
        public CarsDataStore()
        {
            Brands = new List<BrandDto>()
            {
                new BrandDto
                {
                    Id = 1,
                    Name = "Ford",
                    Models = new List<ModelDto>()
                    {
                        new ModelDto { Id=1, Name="Fiesta" },
                        new ModelDto { Id=2, Name="Focus" },
                        new ModelDto { Id=3, Name="Mondeo" },
                        new ModelDto { Id=4, Name="Mustang" }
                    }
                },
                new BrandDto
                {
                    Id = 2,
                    Name = "Subaru",
                    Models = new List<ModelDto>()
                    {
                        new ModelDto { Id=1, Name="Impreza" },
                        new ModelDto { Id=2, Name="Forester" },
                        new ModelDto { Id=3, Name="WRX" }
                    }
                },
                new BrandDto
                {
                    Id = 3,
                    Name = "Opel",
                    Models = new List<ModelDto>()
                    {
                        new ModelDto { Id=1, Name="Corsa" },
                        new ModelDto { Id=2, Name="Astra" },
                        new ModelDto { Id=3, Name="Insignia" },
                        new ModelDto { Id=4, Name="Zafira" }
                    }
                }
            };
        }
    }
}

