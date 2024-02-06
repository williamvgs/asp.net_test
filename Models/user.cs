public class UserResult
{
    public string Gender { get; set; }
    public Name Name { get; set; }
    public Location Location { get; set; }
    public string Email { get; set; }
    public Login Login { get; set; }
    public DateOfBirth Dob { get; set; }
    public RegisteredInfo Registered { get; set; }
    public string Phone { get; set; }
    public string Cell { get; set; }
    public IdInfo Id { get; set; }
    public PictureInfo Picture { get; set; }
    public string Nat { get; set; }
}

public class Name
{
    public string Title { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
}

public class Location
{
    public StreetInfo Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int Postcode { get; set; }
    public CoordinatesInfo Coordinates { get; set; }
    public TimezoneInfo Timezone { get; set; }
}
public class StreetInfo
{
    public int Number { get; set; }
    public string Name { get; set; }
}

public class CoordinatesInfo
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}

public class TimezoneInfo
{
    public string Offset { get; set; }
    public string Description { get; set; }
}

public class Login
{
    public string Uuid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Md5 { get; set; }
    public string Sha1 { get; set; }
    public string Sha256 { get; set; }
}

public class DateOfBirth
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}

public class RegisteredInfo
{
    public DateTime Date { get; set; }
    public int Age { get; set; }
}

public class IdInfo
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class PictureInfo
{
    public string Large { get; set; }
    public string Medium { get; set; }
    public string Thumbnail { get; set; }
}