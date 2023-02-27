using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum BookGenre
    {
        Aventure, Classics, Crime, Fables, Fantasy, Roman, Drama, Historical_fiction, Horror, Humour_and_satire, Literary_fiction, Mystery, Poetry, Plays, Romance, Science_fiction, Short_stories, Thrillers, War, Women_s_fiction, Young_adult, Autobiography_and_memoir, Biography, Essays, Non_fiction_novel, Self_help, Superhero, Slice_of_Life, Humor, Non_fiction, Shonen, Seinen, Shojo, Josei, Yuri, Yaoi, Hentai, Comedy,  Action, Other
    }
}