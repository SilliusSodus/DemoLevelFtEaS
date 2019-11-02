using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMana : MonoBehaviour
{
    public GameObject Mana;


    // Start is called before the first frame update
    public IEnumerator WaitAndSpawn(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Mana.SetActive(true);
    }
}
