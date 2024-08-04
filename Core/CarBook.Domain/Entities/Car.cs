using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId {  get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Mileage { get; set; }
        public string Transmission {  get; set; }//vites türü
        public byte Seat {  get; set; }
        public byte Luggage { get; set; } //bagaj
        public string Fuel {  get; set; }
        public string BigImageUrl { get; set; }
        public List<CarFeature> Features { get; set; }
        public List<CarDescription> carDescriptions { get; set; }
        public List<CarPricing> carPricings { get; set; }


    }
}
