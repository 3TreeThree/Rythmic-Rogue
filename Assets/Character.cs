using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Character : MonoBehaviour
{
  // stats for modifiers; speed, dmg, etc.
  public float inputTimer;
  const float UserInputDelay = 0.25f;
  public Spell primarySpell;

  public GameObject menu;

  public class Equipment : Item 
  {
    private List<Item> equiped;
  }

  public class SpellSegment : Item
  {
    private List<Item> inUse;
  }

  // list for equipment and corresponding buffs
  private List<Equipment> onCharacter;
  // list for inventory
  private List<Item> inventory;

  // Start is called before the first frame update
  void Start()
  {
    primarySpell = FathomSpell();
  }

  Spell FathomSpell()
  {
    
    Spell testSpell = new(5);
    return testSpell;
  }

  // Update is called once per frame
  void Update()
  {
    UserInput();
    
  }
  // TODO: make the highest if statement not take priority
  void UserInput()
  {
    if (Input.GetKey(KeyCode.W) && inputTimer == 0)
    {
      this.transform.Translate(Vector2.up, Space.Self);
      inputTimer += Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.S) && inputTimer == 0)
    {
      this.transform.Translate(Vector2.down, Space.Self);
      inputTimer += Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.D) && inputTimer == 0)
    {
      this.transform.Translate(Vector2.right, Space.Self);
      inputTimer += Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.A) && inputTimer == 0)
    {
      this.transform.Translate(Vector2.left, Space.Self);
      inputTimer += Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.E) && inputTimer == 0)
    {
      Cast();
      inputTimer += Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.Escape) && inputTimer == 0)
    {
      if (CloseWindow() == false)
      {
        Pause();
      }
      inputTimer += Time.deltaTime;
    }
    
    if (inputTimer != 0)
    {
      inputTimer += Time.deltaTime;
      if (inputTimer >= UserInputDelay)
      {
        inputTimer = 0;
      }
    }
  }

  bool Cast()
  {

    primarySpell.BeginCasting();
    return true;
  }

  // if there is a window open -> close it, return true
  bool CloseWindow()
  {
    // TODO: maybe keep a list of windows and check if any are open?
    // https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
    GameObject[] menus = GameObject.FindGameObjectsWithTag("Menu");
    foreach (GameObject menu in menus)
    {
      menu.SetActive(false);
      return true;
    }
    return false;
  }

  // TODO: figure out how to pause
  void Pause()
  {
    menu.SetActive(!menu.activeInHierarchy);
    return;
  }


  
}


