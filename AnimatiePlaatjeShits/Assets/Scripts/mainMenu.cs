using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mainMenu : MonoBehaviour
{

    public Sprite[] gallery;
    public Image displayImage;
    public Button nextImg;
    public Button prevImg;
    public Button i1;
    public Button i2;
    public Button i3;
    public int currentIndex = 0;


  

    public void BtnNext()
    {
            currentIndex++;

        if (currentIndex > gallery.Length - 1)
        {
            currentIndex = 0;
        }

    }

    public void BtnPrev()
    {
        
            currentIndex--;


        if (currentIndex < 0)
        {
            currentIndex = gallery.Length - 1;
        }

    }

    public void image1()
    {
        currentIndex = 0;
    }
    public void image2()
    {
        currentIndex = 1;
    }
    public void image3()
    {
        currentIndex = 2;
    }
    public void image4()
    {
        currentIndex = 3;
    }

    void Update()
    {
        Sprite currentSprite = gallery[currentIndex];
        displayImage.sprite = currentSprite;
       
            

        

    }
}

