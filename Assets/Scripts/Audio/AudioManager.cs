using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource coin, currency, menutoggle, payment;

    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        coin = GameObject.Find("CoinSounds").GetComponent<AudioSource>();
        currency = GameObject.Find("CurrencySound").GetComponent<AudioSource>();
        menutoggle = GameObject.Find("MenuToggleSound").GetComponent<AudioSource>();
        payment = GameObject.Find("PaymentSound").GetComponent<AudioSource>();


    }

    public void PlayCoinSound() => coin.Play();



    public void PlayCurrencySound() => currency.Play();




    public void PlayPaymentSound() => payment.Play();




    public void PlayMenuToggleSound() => menutoggle.Play();




}
