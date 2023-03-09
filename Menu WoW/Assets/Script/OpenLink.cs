using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string Lien;

    public void open()
    {
        Application.OpenURL(Lien);
    }
}
