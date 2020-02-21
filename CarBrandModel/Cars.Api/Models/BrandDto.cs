using System.Collections.Generic;

namespace Cars.Api.Models
{
    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfModels
        {
            get { return Models.Count; }
        }
        public ICollection<ModelDto> Models { get; set; }
            = new List<ModelDto>();
    }
}
