class ProfileService
{
  private UserRegistry userRegistry;

  public ProfileService()
  {
    userRegistry = new UserRegistry();
  }

  public RegistrationSuccess RegisterNewProfile(RegistrationInfo info)
  {
    info.Verifiy();

    var isRegistered = userRegistry.IsRegistered(info);

    if (isRegistered)
    {
      throw new ProfileRegistrationException();
    }

    var result = userRegistry.Register(info);

    return new RegistrationSuccess();
  }
}

class RegistrationSuccess
{
  public bool Status;
  public string? Error;
}

class RegistrationInfo
{
  public required string Alias;
  public required string Email;
  public string? Bio;

  public bool Verifiy()
  {
    if (Alias.Length > 3)
    {
      return false;
    }

    return true;
  }
}

class ProfileRegistrationException : Exception { }


class UserRegistry
{
  private List<Profile> profiles;

  public UserRegistry()
  {
    profiles = new List<Profile>();
  }

  public bool IsRegistered(RegistrationInfo info)
  {
    var profile = profiles.Find(profile => profile.Email == info.Email);
    if (profile == null)
    {
      return false;
    }
    else
    {
      return true;
    }
  }

  // This was from after we took lunch
  public Profile Register(RegistrationInfo info)
  {
    var newProfile = new Profile { Alias = info.Alias, Email = info.Email, Bio = info.Bio }
    profiles.Add(newProfile);
    return newProfile;
  }
}

class Profile
{
  public required string Alias;
  public required string Email;
  public string? Bio;
}