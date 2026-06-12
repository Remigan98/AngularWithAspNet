namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            WebApplication app = builder.Build();

            app.MapControllers();

            app.MapGet("/", () => 
            {
                return Results.Redirect("/api/books");
            });

            app.Run();
        }
    }
}
