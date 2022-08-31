namespace NZWalksAPI.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public string Code { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Population { get; set; }

        //Navigation Properties

        public IEnumerable<Walk> Walks { get; set; }

    }
}
