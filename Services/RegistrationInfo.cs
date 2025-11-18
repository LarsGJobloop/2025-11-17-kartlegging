
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
