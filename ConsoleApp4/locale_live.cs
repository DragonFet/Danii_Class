using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class locale_live
    {
        public string country;
        public string region;
        public string city;
        public string street;
        public int number_house;

        public locale_live(string country,string region,string city,string street,int number_house)
        {
            this.country = country;
            this.region = region;
            this.city = city;
            this.street = street;
            this.number_house = number_house;

        }
        public void Print()
        {
            Console.WriteLine($"Country: {country} Region: {region} City: {city} Street: {street} Number house: {number_house}");
        }
        public void DeadClass(out string country, out string region, out string city, out string street, out int number_house)
        {
            country =this.country;
            region =this.region;
            city =this.city;
            street =this.street;
            number_house =this.number_house;
        }

    }
}
