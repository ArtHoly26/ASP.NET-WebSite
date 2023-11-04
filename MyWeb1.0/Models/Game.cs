using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace MyWeb1._0.Models
{
    public class Game
    {
        private int id;
        private string? name;
        private string? description;
        private int price;
        private string? genre;
        private string? img;
        public int Id { get { return id; } set { id = value; } }

        public string? Name { get { return name; } set { name = value; } }

        public string? Description { get { return description; } set { description = value; } }

        public int Price { get { return price; } set { price = value; } }

        public string? Genre { get { return genre; } set { genre = value; } }

        public string? Img { get { return img; } set { img = value; } }

    }
}
