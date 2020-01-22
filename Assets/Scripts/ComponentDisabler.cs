using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteMover spriteMover;
    void Start()
    {
        spriteMover = gameObject.GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            spriteMover.enabled = (!spriteMover.enabled);
        }
    }
}
