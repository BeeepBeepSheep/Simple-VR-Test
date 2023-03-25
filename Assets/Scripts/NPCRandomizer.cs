//jacob lueke npc randomizer system,  started 25/03/2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomizer : MonoBehaviour
{

    public Color[] npcSkinColours;

    public Transform[] body; //contains all possible torso parts
    public Transform[] feet;
    public Transform[] head; // all heads
    public Transform[] legs;

    public Transform[] myBody; //my body will contain each selected item, for random skintone
    // in my body element 0 will be body, followed by: feet, head, legs
    private int myBodyIndex = 0;
    void Start()
    {
        ActivateRandomBodyParts(body);
        ActivateRandomBodyParts(feet);
        ActivateRandomBodyParts(head);
        ActivateRandomBodyParts(legs);

        SkinTone();
    }
    private void ActivateRandomBodyParts(Transform[] bodyparts)
    {
        int randomSelectIndex = Random.Range(0, bodyparts.Length);// select random to set active
        bodyparts[randomSelectIndex].gameObject.SetActive(true);


        for (int index = 0; index < bodyparts.Length; index++)//for each item in array
        {
            if (index != randomSelectIndex) //if item is not the selected item to be used
            {
                Destroy(bodyparts[index].gameObject);// destroy
            }
            else if(index == randomSelectIndex)
            {
                //adds the selected item into the myBody array
                myBody[myBodyIndex] = bodyparts[randomSelectIndex];
                myBodyIndex++;
            }
        }
    }

    private void SkinTone()
    {
        //select random for this character
        Color myColour = npcSkinColours[Random.Range(0, npcSkinColours.Length)];

        //get currant skin material
        for (int index = 0; index < myBody.Length; index++)//for each item in array 
        {
            SkinnedMeshRenderer renderer = myBody[index].GetComponent<SkinnedMeshRenderer>();
            foreach (Material material in renderer.materials) //for each material in renderer
            {
                if(material.name.StartsWith("Skin"))// if found material is skin
                {
                    Debug.Log("found");

                    material.color = myColour;
                }
            }
        }
    }
}