using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    // Update is called once per frame

    private void OnCollisionEnter(Collision other) {
        gameObject.SetActive(false);
        GetComponentInParent<SpawnMana>().StartCoroutine(GetComponentInParent<SpawnMana>().WaitAndSpawn(20f));
    }
}
