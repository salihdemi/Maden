using System.Collections;
using System.Collections.Generic;

using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    // Start is called before the first frame update
    public int altin;
    public int madenci;
    public int maden;
    public TextMeshProUGUI altinText;
    public TextMeshProUGUI madenciText;
    public TextMeshProUGUI madenText;
    private bool madencicalisiyormu;
    private bool madencalisiyormu;

    public GameObject kazandinresmi;
    public void madencicalistirF()
    {
        if (madencicalisiyormu == false)
        {

        StartCoroutine(madencicalistir());

        }
    } 
    public void madencalistirF()
    {
        if (madencalisiyormu == false) {
       StartCoroutine (madencalistir());
        
        }
        
    }
    public void Update ()
    {
        


    }

    public void MadencisatinalF()
    {
        if (altin >= 5)
        {
            madenci++;
            altin -= 5;
            madenciText.text = "madenci: " + madenci.ToString();
            altinText.text = "altýn: " + altin.ToString(); 
        }
    }
    public void MadenSatinAl()
    {
        if (madenci >= 5)
        {
            maden++;
            madenci -= 5;
            madenText.text = "maden: " + maden.ToString();
            madenciText.text = "madenci: " + madenci.ToString();
        }

        

    }



    IEnumerator madencicalistir()
    {
        
        madencicalisiyormu = true;
        yield return new WaitForSeconds(0.5f);
        madencicalisiyormu = false;
        altin += madenci;
        altinText.text = "altýn: " + altin.ToString();

        oyunbittimi();
    }
    IEnumerator madencalistir()
    {
        madencalisiyormu = true;
        yield return new WaitForSeconds(1);
        madenci += maden;
        madenciText.text ="madenci: " + madenci.ToString();
        madencalisiyormu = false;
    }

    void oyunbittimi()
    {
        if(altin >= 100000)
        {
            kazandinresmi.SetActive(true);
        }
    }
}
