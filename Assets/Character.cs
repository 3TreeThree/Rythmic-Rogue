using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Character : MonoBehaviour
{

  public float inputTimer;
  const float moveDelay = 0.25f;
  public Spell primarySpell;

  // list for equipment and corresponding buffs

  // list for inventory

  // Start is called before the first frame update
  void Start()
  {
    primarySpell = FathomSpell();
  }

  Spell FathomSpell()
  {
    
    Spell testSpell = new("testName", 5);
    return testSpell;
  }

  // Update is called once per frame
  void Update()
  {
    Move();

    
  }
  // TODO: make the highest if statement not take priority
  void Move()
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
    
    if (inputTimer != 0)
    {
      inputTimer += Time.deltaTime;
      if (inputTimer >= moveDelay)
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

}


