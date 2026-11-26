namespace RentaCar_Express_Frenlly
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmAlquileres());
        }
    }
}
