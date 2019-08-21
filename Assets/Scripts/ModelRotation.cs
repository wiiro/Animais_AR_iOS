using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModelRotation : MonoBehaviour
{
    private bool _rotate;
    private bool left = true;

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

    void Update()
    {
        if (_rotate)
        {
            if (left)
            {
                switch (StaticVariables.modelNumber)
                {
                    case 0:
                        oncaPintadaModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 1:
                        tartarugaVerdeModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 2:
                        araraLearModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 3:
                        cavaloMarinhoModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 4:
                        tamanduaBandeiraModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 5:
                        donzelaModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 6:
                        macacoPregoModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 7:
                        botoRosaModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 8:
                        preguiçaColeiraModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 9:
                        peixeBoiModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 10:
                        loboGuaraModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 11:
                        meroModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 12:
                        araraVermelhaModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 13:
                        tucanoModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 14:
                        micoLeaoModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 15:
                        caranguejoAmareloModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                    case 16:
                        estrelaMarModel.transform.Rotate(new Vector3(0, 0, 1));
                        break;
                    case 17:
                        marlinAzulModel.transform.Rotate(new Vector3(0, 1, 0));
                        break;
                }
                oncaPintadaModel.transform.Rotate(new Vector3(0, 1, 0));
            }
            else
            {
                switch (StaticVariables.modelNumber)
                {
                    case 0:
                        oncaPintadaModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 1:
                        tartarugaVerdeModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 2:
                        araraLearModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 3:
                        cavaloMarinhoModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 4:
                        tamanduaBandeiraModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 5:
                        donzelaModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 6:
                        macacoPregoModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 7:
                        botoRosaModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 8:
                        preguiçaColeiraModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 9:
                        peixeBoiModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 10:
                        loboGuaraModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 11:
                        meroModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 12:
                        araraVermelhaModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 13:
                        tucanoModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 14:
                        micoLeaoModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 15:
                        caranguejoAmareloModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                    case 16:
                        estrelaMarModel.transform.Rotate(new Vector3(0, 0, -1));
                        break;
                    case 17:
                        marlinAzulModel.transform.Rotate(new Vector3(0, -1, 0));
                        break;
                }
            }
        }
    }

    public void OnPress()
    {
        _rotate = true;
    }

    public void OnRelease()
    {
        _rotate = false;
    }

    public void SetRotationLeft() {

        left = true;

    }
    public void SetRotationRight()
    {

        left = false;

    }
}
