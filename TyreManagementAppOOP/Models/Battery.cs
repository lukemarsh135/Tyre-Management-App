namespace TyreManagementAppOOP.Models
{
    public class Battery : Product
    {
        // Unique battery properties
        public decimal Voltage { get; set; }

        public decimal Capacity { get; set; }

        public decimal StartupPower { get; set; }
    }
}
