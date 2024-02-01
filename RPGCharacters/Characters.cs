namespace RPGCharacters;

public class Characters
{
    // A "class" parameter that decides which of the sub-classes the character is...
    // A character has default low stats that is overriden by the classes.
    public string Name;
    public string Job; // Jobless is set if no Job has been selected yet.
    public string? Weapon;
    public string? Description;

// Sub-Classes:
//  Fighter
//  Mage
//  Rogue
//  Ranger
}

