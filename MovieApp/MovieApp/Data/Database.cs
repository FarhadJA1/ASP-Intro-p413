using MovieApp.Models;

namespace MovieApp.Data;
public class Database
{
    public static List<Movie> Movies { get; set; } = new List<Movie>(0);
    public static List<Director> Directors { get; set; } = new List<Director>(0);
}
