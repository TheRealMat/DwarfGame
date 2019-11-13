using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walktest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TickSystem.OnTick += delegate (object sender, TickSystem.OnTickEventArgs e)
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }

    }
}
