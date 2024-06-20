using System.Collections.Generic;
using UnityEngine;
public class Spell : MonoBehaviour
{
  
  public float velocity;
  public List<SpellComponent> components;

  // way for components to be turned into rhythm sections
  public class SpellComponent
  {
    public List<int> positions;
    
    public List<float> timings;
  }

  public Spell(float velocity)
  {
    this.velocity = velocity;
  }

  public void BeginCasting()
  {
    Debug.Log("CAST!!!!!!");
    return;
  }
}