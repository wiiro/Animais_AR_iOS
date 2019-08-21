using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BiomaController : MonoBehaviour
{

    public Button PlayButton, Button3D;
    public Button prevButton, nextButton;
    public GameObject rotateLeft, rotateRight;
    public bool On360 = false;
    public RectTransform scrollPanelTransform;

    public AudioClip oncaPintada;
    public AudioClip tartarugaVerde;
    public AudioClip araraLear;
    public AudioClip cavaloMarinho;
    public AudioClip tamanduaBandeira;
    public AudioClip donzela;
    public AudioClip macacoPrego;
    public AudioClip botoRosa;
    public AudioClip preguiçaColeira;
    public AudioClip peixeBoi;
    public AudioClip loboGuara;
    public AudioClip mero;
    public AudioClip araraVermelha;
    public AudioClip tucano;
    public AudioClip micoLeao;
    public AudioClip caranguejoAmarelo;
    public AudioClip estrelaMar;
    public AudioClip marlinAzul;

    public GameObject oncaPintadaModel;
    public GameObject tartarugaVerdeModel;
    public GameObject araraLearModel;
    public GameObject cavaloMarinhoModel;
    public GameObject tamanduaBandeiraModel;
    public GameObject donzelaModel;
    public GameObject macacoPregoModel;
    public GameObject botoRosaModel;
    public GameObject preguiçaColeiraModel;
    public GameObject peixeBoiModel;
    public GameObject loboGuaraModel;
    public GameObject meroModel;
    public GameObject araraVermelhaModel;
    public GameObject tucanoModel;
    public GameObject micoLeaoModel;
    public GameObject caranguejoAmareloModel;
    public GameObject estrelaMarModel;
    public GameObject marlinAzulModel;

    public GameObject oncaimage;
    public GameObject tartarugaImage;
    public GameObject araraAimage;
    public GameObject cavaloimage;
    public GameObject tamanduaimage;
    public GameObject donzelaImage;
    public GameObject macacoImage;
    public GameObject botoImage;
    public GameObject preguiçaImage;
    public GameObject peixeBoiImage;
    public GameObject loboImage;
    public GameObject meroImage;
    public GameObject araraVimage;
    public GameObject tucanoimage;
    public GameObject micoimage;
    public GameObject caranguejoimage;
    public GameObject estrelaimage;
    public GameObject marlinimage;

    public Sprite layout360;

    public Sprite oncaSprite;
    public Sprite tartarugaSprite;
    public Sprite araraASprite;
    public Sprite cavaloSprite;
    public Sprite tamanduaSprite;
    public Sprite donzelaSprite;
    public Sprite macacoSprite;
    public Sprite botoSprite;
    public Sprite preguiçaSprite;
    public Sprite peixeBoiSprite;
    public Sprite loboSprite;
    public Sprite meroSprite;
    public Sprite aravaVSprite;
    public Sprite tucanoSprite;
    public Sprite micoSprite;
    public Sprite caranguejoSprite;
    public Sprite estrelaSprite;
    public Sprite marlinSprite;

    Color corLayout = new Color(1, 1, 1, 0.8f);
    Color corSprite = new Color(1, 1, 1, 1);

    private AudioSource audioSource;
    private float position;
    int modelPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        position = scrollPanelTransform.localPosition.x;
        //Button3D.onClick.AddListener(Toggle360);
        audioSource.volume = StaticVariables.effects;
        //ReturnPosition();

        if (position <= 16320 && position >= 16220)
        {
            audioSource.clip = oncaPintada;
            prevButton.interactable = false;
            tartarugaVerdeModel.SetActive(false);

            StaticVariables.modelNumber = 0;
            
            if(On360 == true)
            {
                oncaPintadaModel.SetActive(true);
                oncaimage.GetComponent<Image>().sprite = layout360;
                oncaimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                oncaPintadaModel.SetActive(false);
                oncaimage.GetComponent<Image>().sprite = oncaSprite;
                oncaimage.GetComponent<Image>().color = corSprite;
            }

        }else if(position <=14400 && position >= 14300){

            audioSource.clip = tartarugaVerde;
            oncaPintadaModel.SetActive(false);
            araraLearModel.SetActive(false);

            StaticVariables.modelNumber = 1;

            if (On360 == true)
            {
                tartarugaVerdeModel.SetActive(true);
                tartarugaImage.GetComponent<Image>().sprite = layout360;
                tartarugaImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                tartarugaVerdeModel.SetActive(false);
                tartarugaImage.GetComponent<Image>().sprite = tartarugaSprite;
                tartarugaImage.GetComponent<Image>().color = corSprite;
            }


        }
        else if(position <=12480 && position >= 12380) {

            audioSource.clip = araraLear;
            tartarugaVerdeModel.SetActive(false);
            cavaloMarinhoModel.SetActive(false);

            StaticVariables.modelNumber = 2;

            if (On360 == true)
            {
                araraLearModel.SetActive(true);
                araraAimage.GetComponent<Image>().sprite = layout360;
                araraAimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                araraLearModel.SetActive(false);
                araraAimage.GetComponent<Image>().sprite = araraASprite;
                araraAimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position <= 10560 && position >= 10460)
        {

            audioSource.clip = cavaloMarinho;
            araraLearModel.SetActive(false);
            tamanduaBandeiraModel.SetActive(false);

            StaticVariables.modelNumber = 3;

            if (On360 == true)
            {
                cavaloMarinhoModel.SetActive(true);
                cavaloimage.GetComponent<Image>().sprite = layout360;
                cavaloimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                cavaloMarinhoModel.SetActive(false);
                cavaloimage.GetComponent<Image>().sprite = cavaloSprite;
                cavaloimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if(position <=8640 && position >= 8540) {

            audioSource.clip = tamanduaBandeira;
            cavaloMarinhoModel.SetActive(false);
            donzelaModel.SetActive(false);

            StaticVariables.modelNumber = 4;

            if (On360 == true)
            {
                tamanduaBandeiraModel.SetActive(true);
                tamanduaimage.GetComponent<Image>().sprite = layout360;
                tamanduaimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                tamanduaBandeiraModel.SetActive(false);
                tamanduaimage.GetComponent<Image>().sprite = tamanduaSprite;
                tamanduaimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position <= 6720 && position >= 6620)
        {

            audioSource.clip = donzela;
            tamanduaBandeiraModel.SetActive(false);
            macacoPregoModel.SetActive(false);

            StaticVariables.modelNumber = 5;

            if (On360 == true)
            {
                donzelaModel.SetActive(true);
                donzelaImage.GetComponent<Image>().sprite = layout360;
                donzelaImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                donzelaModel.SetActive(false);
                donzelaImage.GetComponent<Image>().sprite = donzelaSprite;
                donzelaImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position <= 4800 && position >= 4700)
        {

            audioSource.clip = macacoPrego;
            donzelaModel.SetActive(false);
            botoRosaModel.SetActive(false);

            StaticVariables.modelNumber = 6;

            if (On360 == true)
            {
                macacoPregoModel.SetActive(true);
                macacoImage.GetComponent<Image>().sprite = layout360;
                macacoImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                macacoPregoModel.SetActive(false);
                macacoImage.GetComponent<Image>().sprite = macacoSprite;
                macacoImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position <= 2880 && position >= 2780)
        {

            audioSource.clip = botoRosa;
            macacoPregoModel.SetActive(false);
            preguiçaColeiraModel.SetActive(false);

            StaticVariables.modelNumber = 7;

            if (On360 == true)
            {
                botoRosaModel.SetActive(true);
                botoImage.GetComponent<Image>().sprite = layout360;
                botoImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                botoRosaModel.SetActive(false);
                botoImage.GetComponent<Image>().sprite = botoSprite;
                botoImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position <= 960 && position >= 860)
        {

            audioSource.clip = preguiçaColeira;
            botoRosaModel.SetActive(false);
            peixeBoiModel.SetActive(false);

            StaticVariables.modelNumber = 8;

            if (On360 == true)
            {
                preguiçaColeiraModel.SetActive(true);
                preguiçaImage.GetComponent<Image>().sprite = layout360;
                preguiçaImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                preguiçaColeiraModel.SetActive(false);
                preguiçaImage.GetComponent<Image>().sprite = preguiçaSprite;
                preguiçaImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if(position >= -960 && position <= -860)
        {

            audioSource.clip = peixeBoi;
            preguiçaColeiraModel.SetActive(false);
            loboGuaraModel.SetActive(false);

            StaticVariables.modelNumber = 9;

            if (On360 == true)
            {
                peixeBoiModel.SetActive(true);
                peixeBoiImage.GetComponent<Image>().sprite = layout360;
                peixeBoiImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                peixeBoiModel.SetActive(false);
                peixeBoiImage.GetComponent<Image>().sprite = peixeBoiSprite;
                peixeBoiImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if(position >= -2880 && position <= -2780)
        {

            audioSource.clip = loboGuara;
            peixeBoiModel.SetActive(false);
            meroModel.SetActive(false);

            StaticVariables.modelNumber = 10;

            if (On360 == true)
            {
                loboGuaraModel.SetActive(true);
                loboImage.GetComponent<Image>().sprite = layout360;
                loboImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                loboGuaraModel.SetActive(false);
                loboImage.GetComponent<Image>().sprite = loboSprite;
                loboImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if(position >= -4800 && position <= -4700)
        {

            audioSource.clip = mero;
            loboGuaraModel.SetActive(false);
            araraVermelhaModel.SetActive(false);

            StaticVariables.modelNumber = 11;

            if (On360 == true)
            {
                meroModel.SetActive(true);
                meroImage.GetComponent<Image>().sprite = layout360;
                meroImage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                meroModel.SetActive(false);
                meroImage.GetComponent<Image>().sprite = meroSprite;
                meroImage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position >= -6720 && position <= -6620)
        {

            audioSource.clip = araraVermelha;
            meroModel.SetActive(false);
            tucanoModel.SetActive(false);

            StaticVariables.modelNumber = 12;

            if (On360 == true)
            {
                araraVermelhaModel.SetActive(true);
                araraVimage.GetComponent<Image>().sprite = layout360;
                araraVimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                araraVermelhaModel.SetActive(false);
                araraVimage.GetComponent<Image>().sprite = aravaVSprite;
                araraVimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position >= -8640 && position <= -8540)
        {

            audioSource.clip = tucano;
            araraVermelhaModel.SetActive(false);
            micoLeaoModel.SetActive(false);

            StaticVariables.modelNumber = 13;

            if (On360 == true)
            {
                tucanoModel.SetActive(true);
                tucanoimage.GetComponent<Image>().sprite = layout360;
                tucanoimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                tucanoModel.SetActive(false);
                tucanoimage.GetComponent<Image>().sprite = tucanoSprite;
                tucanoimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position >= -10560 && position <= -10460)
        {

            audioSource.clip = micoLeao;
            tucanoModel.SetActive(false);
            caranguejoAmareloModel.SetActive(false);

            StaticVariables.modelNumber = 14;

            if (On360 == true)
            {
                micoLeaoModel.SetActive(true);
                micoimage.GetComponent<Image>().sprite = layout360;
                micoimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                micoLeaoModel.SetActive(false);
                micoimage.GetComponent<Image>().sprite = micoSprite;
                micoimage.GetComponent<Image>().color = corSprite;
            }
        }
        else if (position >= -12480 && position <= -12380)
        {

            audioSource.clip = caranguejoAmarelo;
            micoLeaoModel.SetActive(false);
            estrelaMarModel.SetActive(false);

            StaticVariables.modelNumber = 15;

            if (On360 == true)
            {
                caranguejoAmareloModel.SetActive(true);
                caranguejoimage.GetComponent<Image>().sprite = layout360;
                caranguejoimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                caranguejoAmareloModel.SetActive(false);
                caranguejoimage.GetComponent<Image>().sprite = caranguejoSprite;
                caranguejoimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position >= -14400 && position <= -14300)
        {

            audioSource.clip = estrelaMar;
            caranguejoAmareloModel.SetActive(false);
            marlinAzulModel.SetActive(false);

            StaticVariables.modelNumber = 16;

            if (On360 == true)
            {
                estrelaMarModel.SetActive(true);
                estrelaimage.GetComponent<Image>().sprite = layout360;
                estrelaimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                estrelaMarModel.SetActive(false);
                estrelaimage.GetComponent<Image>().sprite = estrelaSprite;
                estrelaimage.GetComponent<Image>().color = corSprite;
            }

        }
        else if (position >= -16320 && position <= -16220)
        {

            audioSource.clip = marlinAzul;
            estrelaMarModel.SetActive(false);
            nextButton.interactable = false;

            StaticVariables.modelNumber = 17;

            if (On360 == true)
            {
                marlinAzulModel.SetActive(true);
                marlinimage.GetComponent<Image>().sprite = layout360;
                marlinimage.GetComponent<Image>().color = corLayout;
            }
            else
            {
                marlinAzulModel.SetActive(false);
                marlinimage.GetComponent<Image>().sprite = marlinSprite;
                marlinimage.GetComponent<Image>().color = corSprite;
            }

        }
        else
        {
            audioSource.clip = null;
            On360 = false;
            prevButton.interactable = true;
            nextButton.interactable = true;
        }
    }

    private void ReturnPosition()
    {
        StartCoroutine(_ReturnPosition());
    }

    private IEnumerator _ReturnPosition()
    {
        yield return new WaitForSeconds(3);
        print(position);
    }

    public void Toggle360()
    {
        if(On360 == true)
        {
            On360 = false;
            rotateLeft.SetActive(false);
            rotateRight.SetActive(false);
        }
        else
        {
            On360 = true;
            rotateLeft.SetActive(true);
            rotateRight.SetActive(true);
        }
        
    }

    public void DisableAll()
    {

        On360 = false;

    }
}
