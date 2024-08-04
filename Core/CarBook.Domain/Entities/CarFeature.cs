using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFeature
    {
        public int Id { get; set; }
        public int CarId {  get; set; }
        public Car car { get; set; }
        public int FeatureId {  get; set; }
        public Feature feature { get; set; }
        public bool Avaible { get; set; }   

    }
}
