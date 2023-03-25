using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomizer : MonoBehaviour
{

    public Color[] npcSkinColours;
    public Transform[] body;
    public Transform[] feet;
    public Transform[] head;
    public Transform[] legs;

    void Start()
    {
        ActivateRandomBodyParts(body);
        ActivateRandomBodyParts(feet);
        ActivateRandomBodyParts(head);
        ActivateRandomBodyParts(legs);
    }

    void Update()
    {

    }

    private void ActivateRandomBodyParts(Transform[] bodyparts)
    {
        for (int index = 0; index < bodyparts.Length; index++)//for each item in array turn off
        {
            bodyparts[index].gameObject.SetActive(false); //sets each item to not active
        }

        int randomIndex = Random.Range(0, bodyparts.Length);// select random to set active
        bodyparts[randomIndex].gameObject.SetActive(true);
    }
}