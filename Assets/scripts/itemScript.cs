using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string title;

    public void InteractWithPlayer(characterController controller)
    {
        Debug.Log("interaction");
    }

    public void Collect()
    {
        Destroy(gameObject);
    }
}
