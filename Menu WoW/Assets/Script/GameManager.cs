using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int ChoiceMod;
    public TextMeshProUGUI TextChoix;
    public GameObject BoutonA;
    public GameObject BoutonB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BoutonA.activeInHierarchy)
        {
            ChoiceMod = 1;
            BoutonB.SetActive(false);
        }

        if (BoutonB.activeInHierarchy)
        {
            ChoiceMod = 0;
            BoutonA.SetActive(false);
        }

        if (ChoiceMod == 0)
        {
            TextChoix.text = "Non Classé";
        }

        if (ChoiceMod == 1)
        {
            TextChoix.text = "Classé";
        }
    }
}