using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellTable : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("before tag check");
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
            Debug.Log("Player in collider");
        }
    }

    private void OnTriggerExit(Collider other)
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
        Debug.Log("OpenSpellEditing");
    }
}
