using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minServiceAPI.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("firstName")]
    [JsonPropertyName("firstName")]
    public string firstName { get; set; } = null!;

    public string lastName { get; set; } = null!;

    public string password { get; set; } = null!;
}