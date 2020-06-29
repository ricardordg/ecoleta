namespace webapiserver.Mvc.Dto
{
    public class PointReadDto
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Whatsapp { get; set; }

        public string City { get; set; }

        public string Uf { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }
    }
}