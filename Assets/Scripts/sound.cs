using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;

    public void ChangeImage()
    {
        if (but.image.sprite == OnSprite)
            but.image.sprite = OffSprite;
        else
        {
            but.image.sprite = OnSprite;
        }
    }
}

