namespace TyreManagementAppOOP.Models
{
    public class Tyre : Product
    {
        // Unique product properties
        public int Width { get; set; }

        public int AspectRatio { get; set; }

        public int Diameter { get; set; }

        public int LoadRating { get; set; }

        public string? SpeedRating { get; set; }

        public string? Type { get; set; }

    }
}
