using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScript : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    public int hpBoost = 20;

    public void collect()
    {
        Destroy(gameObject);
    }
}
