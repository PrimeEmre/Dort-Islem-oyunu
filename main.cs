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
        int kullaniciCevap;
        if (int.TryParse(sonucInput.text, out kullaniciCevap))
        {
            if (kullaniciCevap == islemSonucu)
            {
                sonuc.text = "DOGRU";
            }
            else
            {
                sonuc.text = "Yanlis";
            }
        }
        else
        {
            sonuc.text = "Lütfen bir sayı girin.";
        }
    }

    public void Yenisoru()
    {
        sonuc.text = "";
        sonucInput.text = "";
        islemIsareti = Random.Range(1, 5);
        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                sayi1 = Random.Range(1, 100);
                sayi2 = Random.Range(1, 100);
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                sayi1 = Random.Range(1, 100);
                sayi2 = Random.Range(1, 100);
                // Ensure the result isn't negative by swapping if needed
                if (sayi1 < sayi2)
                {
                    int temp = sayi1;
                    sayi1 = sayi2;
                    sayi2 = temp;
                }
                islemSonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "*";
                sayi1 = Random.Range(1, 11);
                sayi2 = Random.Range(1, 11);
                islemSonucu = sayi1 * sayi2;
                break;

            // --- THIS IS THE FIXED DIVISION PART ---
            case 4:
                islem.text = "/";

                // This new logic guarantees a clean division with a whole number answer.
                int answer = Random.Range(2, 11);  // First, create the answer (e.g., 5)
                sayi2 = Random.Range(2, 11);       // Then, create the second number (e.g., 4)
                sayi1 = sayi2 * answer;            // Calculate the first number (4 * 5 = 20)
                                                   // The problem becomes 20 / 4 = 5.
                islemSonucu = answer;              // Store the correct answer.
                break;
        }

        ilkSayi.text = sayi1.ToString();
        ikinciSayi.text = sayi2.ToString();
    }
}