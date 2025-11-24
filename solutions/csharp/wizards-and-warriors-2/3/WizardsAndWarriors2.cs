using System.Threading.Channels;

static class GameMaster
{
    public static string Describe(Character character)
    {
        return $"You're a level {character.Level.ToString()} {character.Class} with {character.HitPoints.ToString()} hit points.";
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(Character) method");
    }

    public static string Describe(Destination destination)
    {
        return $"You've arrived at {destination.Name}, which has {destination.Inhabitants.ToString()} inhabitants.";
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(Destination) method");
    }

    public static string Describe(TravelMethod travelMethod)
    {
        return $"You're traveling to your destination by {travelMethod.ToString().ToLower()}.";
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(TravelMethod) method");
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
        return $"You're a level {character.Level.ToString()} {character.Class} with {character.HitPoints.ToString()} hit points. You're traveling to your destination on {travelMethod}. You've arrived at {destination.Name}, which has {destination.Inhabitants.ToString()} inhabitants";
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(Character, Destination, TravelMethod) method");
    }

    public static string Describe(Character character, Destination destination)
    {
        return $"You're a level {character.Level.ToString()} {character.Class} with {character.HitPoints.ToString()} hit points. You're traveling to your destination by walking. You've arrived at {destination.Name}, which has {destination.Inhabitants.ToString()} inhabitants.";
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(Character, Destination) method");
    }
}

class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}
