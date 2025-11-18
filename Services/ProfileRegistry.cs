
class ProfileRegistry
{
  private List<Profile> profiles;

  public ProfileRegistry()
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
    var newProfile = new Profile { Alias = info.Alias, Email = info.Email, Bio = info.Bio };
    profiles.Add(newProfile);
    return newProfile;
  }
}
