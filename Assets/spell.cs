using System.Collections.Generic;
using UnityEngine;
public class Spell : MonoBehaviour
{
  
  public string name;
  public float velocity;
  public List<SpellComponent> components;

  // way for components to be turned into rhythm sections
  public class SpellComponent
  {
    public List<int> positions;
    
    public List<float> timings;
  }

  public Spell(string name, float velocity)
  {
    this.name = name;
    this.velocity = velocity;
  }

  public void BeginCasting()
  {
    Debug.Log("CAST!!!!!!");
    return;
  }
}