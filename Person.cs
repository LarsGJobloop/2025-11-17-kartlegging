class Person
{
  // This is public data for this object
  public string Name;

  // Constructor, logic for how to create new Person instances
  public Person(string name)
  {
    if (name.Length == 0)
    {
      // Throw means crash program
      throw new Exception();
    }

    Name = name;
  }
}
