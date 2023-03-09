using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banner : MonoBehaviour
{
    public List<Sprite> images; // Liste des images � afficher
    public Image displayImage; // Image � afficher
    public Image displayImageProfile;


    private int currentIndex = 0; // Index courant de l'image affich�e

    private void Start()
    {
        currentIndex = PlayerPrefs.GetInt("playerBanner");
        displayImage.sprite = images[currentIndex]; // Afficher la premi�re image de la liste au d�marrage
        displayImageProfile.sprite = images[currentIndex];
    }

    public void ChangeBanner()
    {
        currentIndex = (currentIndex + 1) % images.Count;
        displayImage.sprite = images[currentIndex];
        displayImageProfile.sprite = images[currentIndex];
        PlayerPrefs.SetInt("playerBanner", currentIndex);
    }
}
