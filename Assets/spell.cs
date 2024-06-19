using System.Collections.Generic;

public class Spell {
  
  public float velocity;
  public List<SpellComponent> components;

  public class SpellComponent {
    public int position;
  }

}