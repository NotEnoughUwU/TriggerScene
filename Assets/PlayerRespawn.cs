using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    Vector3 OriginalPos;
    public CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        OriginalPos = new Vector3(-25.366f, -2.19f, -19);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillLight"))
        {
            cc.enabled = false;
            transform.position = OriginalPos;
            cc.enabled = true;
        }
    }
}
