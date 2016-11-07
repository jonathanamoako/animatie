using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ImageArray : MonoBehaviour
{
   
    public Image imagePrefab;

   
    List<Sprite> images = new List<Sprite>();

    // For testing try this
    // Remember to mark the image file as "Sprite UI" in the import settings in Unity
    public Sprite testSprite;

    void Start()
    {
        // Put test image in array or list
        images.Add(testSprite);

        // Instantiate the imagePrefab
        Image imageInstance = Instantiate(imagePrefab);

        // Set the parent to the Canvas or whatever UI element it needs to be.
        // Place this script on that object or get a new reference instead of this.transform
        imageInstance.transform.SetParent(this.transform, true);

        // Assign the first image of the list or array or chose the one you need.
        imageInstance.sprite = images[0];
    }

}