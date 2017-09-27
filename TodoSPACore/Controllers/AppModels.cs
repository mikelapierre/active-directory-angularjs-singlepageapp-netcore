
namespace TodoSPA.Controllers
{
    public class Todo
    {
        public int ID { get; set; }
        [Newtonsoft.Json.JsonProperty("Description")]
        public string Description { get; set; }
        public string Owner { get; set; }
    }
}