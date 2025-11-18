class ProfileService
{
  private ProfileRegistry userRegistry;

  public ProfileService()
  {
    userRegistry = new ProfileRegistry();
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
