using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DortIslem : MonoBehaviour
{
    public UnityEngine.UI.Text ilkSayi, ikinciSayi, islem, esittir, cevap, sonuc;
    public UnityEngine.UI.InputField sonucInput;
    int sayi1, sayi2, islemIsareti;
    int islemSonucu;

    void Start()
    {
     
        Yenisoru();
    }
    void Update()
    {

    }

    public void cevapKontrol()
    {
        if (int.Parse(cevap.text) == islemSonucu)
        {
            sonuc.text = "DOGRU";
        }
        else
        {
            sonuc.text = "Yanlis";
        }

    }

     public void Yenisoru()
    {
        sonuc.text = "";
        sonucInput.text = "";
        sayi1 = Random.Range(1, 100);
        sayi2 = Random.Range(1, 100);
        islemIsareti = Random.Range(1, 5);
        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayi2 - sayi1;
                break;
            case 3:
                islem.text = "*";
                islemSonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                islemSonucu = sayi2 / sayi1;
                break;
        }

        ilkSayi.text = sayi1.ToString();
        ikinciSayi.text = sayi2.ToString();
    }
    
}