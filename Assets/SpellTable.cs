using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellTable : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    public GameObject spellEditingMenu;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Q))
        {
            OpenSpellEditing();
        }
    }

    public void OpenSpellEditing()
    {
        spellEditingMenu.SetActive(!spellEditingMenu.activeInHierarchy);
    }
}
