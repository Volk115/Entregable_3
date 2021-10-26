using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);


    }

    // Update is called once per frame
    void Update()
    {

        ScaleGameObject(KeyCode.X, scale: new Vector3(x: 0.5f, y: 0, z: 0));
        ScaleGameObject(KeyCode.Y, scale: new Vector3(x: 0, y: 0.5f, z: 0));
        ScaleGameObject(KeyCode.Z, scale: new Vector3(x: 0, y: 0, z: 0.5f));

    }
    public void ScaleGameObject(KeyCode kcode, Vector3 scale)
    {
        if (Input.GetKeyDown(kcode))
        {
            transform.localScale += scale;
        }


    }
}
