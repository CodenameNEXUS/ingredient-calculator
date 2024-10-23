using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Collections.LowLevel.Unsafe;
using System.Runtime.CompilerServices;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;

    [SerializeField]
    TMP_InputField i_ChiliAmt;
    [SerializeField]
    TMP_InputField i_ChiliCost;

    [SerializeField]
    TMP_InputField i_PorkAmt;
    [SerializeField]
    TMP_InputField i_PorkCost;

    [SerializeField]
    TMP_InputField i_HominyAmt;
    [SerializeField]
    TMP_InputField i_HominyCost;

    [SerializeField]
    TMP_InputField i_LimeAmt;
    [SerializeField]
    TMP_InputField i_LimeCost;

    [SerializeField]
    TMP_InputField i_TortillaChipAmt;
    [SerializeField]
    TMP_InputField i_TortillaChipCost;

    [SerializeField]
    TMP_InputField i_SaltAmt;
    [SerializeField]
    TMP_InputField i_SaltCost;

    [SerializeField]
    TMP_InputField i_EctAmt;
    [SerializeField]
    TMP_InputField i_EctCost;

    [SerializeField]
    TMP_InputField i_RiceAmt;
    [SerializeField]
    TMP_InputField i_RiceCost;

    [SerializeField]
    TMP_InputField i_SugerAmt;
    [SerializeField]
    TMP_InputField i_SugerCost;

    [SerializeField]
    TMP_InputField i_butterAmt;
    [SerializeField]
    TMP_InputField i_butterCost;

    [SerializeField]
    TMP_InputField i_onionAmt;
    [SerializeField]
    TMP_InputField i_onionCost;

    [SerializeField]
    TMP_InputField i_eggAmt;
    [SerializeField]
    TMP_InputField i_eggCost;

    [SerializeField]
    TMP_InputField i_cinnamonAmt;
    [SerializeField]
    TMP_InputField i_cinnamonCost;

    [SerializeField]
    TMP_InputField i_BakingPowderAmt;
    [SerializeField]
    TMP_InputField i_BakingPowderCost;

    [SerializeField]
    TMP_InputField i_MarkUpPrice;
    [SerializeField]
    TMP_InputField i_NumberOfServings;

    [SerializeField]
    TMP_Text i_Total;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //input fields for cost and amount
            float flourCost = -1;
            Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
            float flourAmt = -1;
            Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));
            float flourSAmt = (flourAmt * flourCost);
            Debug.Log(flourSAmt);

            float ChiliCost = -1;
            Debug.Log(float.TryParse(i_ChiliCost.text, out ChiliCost));
            float ChiliAmt = -1;
            Debug.Log(float.TryParse(i_ChiliAmt.text, out ChiliAmt));
            float ChiliSAmt = (ChiliAmt * ChiliCost);
            Debug.Log(ChiliSAmt);

            float PorkCost = -1;
            Debug.Log(float.TryParse(i_PorkCost.text, out PorkCost));
            float PorkAmt = -1;
            Debug.Log(float.TryParse(i_PorkAmt.text, out PorkAmt));
            float PorkSAmt = (PorkAmt * PorkCost);
            Debug.Log(PorkSAmt);

            float HominyCost = -1;
            Debug.Log(float.TryParse(i_HominyCost.text, out HominyCost));
            float HominyAmt = -1;
            Debug.Log(float.TryParse(i_HominyAmt.text, out HominyAmt));
            float HominySAmt = (HominyAmt * HominyCost);
            Debug.Log(HominySAmt);

            float LimeCost = -1;
            Debug.Log(float.TryParse(i_LimeCost.text, out LimeCost));
            float LimeAmt = -1;
            Debug.Log(float.TryParse(i_LimeAmt.text, out LimeAmt));
            float LimeSAmt = (LimeAmt * LimeCost);
            Debug.Log(LimeSAmt);

            float TortillaChipCost = -1;
            Debug.Log(float.TryParse(i_TortillaChipCost.text, out TortillaChipCost));
            float TortillaChipAmt = -1;
            Debug.Log(float.TryParse(i_TortillaChipAmt.text, out TortillaChipAmt));
            float TortillaChipSAmt = (TortillaChipAmt * TortillaChipCost);
            Debug.Log(TortillaChipSAmt);

            float SaltCost = -1;
            Debug.Log(float.TryParse(i_SaltCost.text, out SaltCost));
            float SaltAmt = -1;
            Debug.Log(float.TryParse(i_SaltAmt.text, out SaltAmt));
            float SaltSAmt = (SaltAmt * SaltCost);
            Debug.Log(SaltSAmt);

            float EctCost = -1;
            Debug.Log(float.TryParse(i_EctCost.text, out EctCost));
            float EctAmt = -1;
            Debug.Log(float.TryParse(i_EctAmt.text, out EctAmt));
            float EctSAmt = (EctAmt * EctCost);
            Debug.Log(EctSAmt);

            float RiceCost = -1;
            Debug.Log(float.TryParse(i_RiceCost.text, out RiceCost));
            float RiceAmt = -1;
            Debug.Log(float.TryParse(i_RiceAmt.text, out RiceAmt));
            float RiceSAmt = (RiceAmt * RiceCost);
            Debug.Log(RiceSAmt);

            float SugerCost = -1;
            Debug.Log(float.TryParse(i_SugerCost.text, out SugerCost));
            float SugerAmt = -1;
            Debug.Log(float.TryParse(i_SugerAmt.text, out SugerAmt));
            float SugerSAmt = (SugerAmt * SugerCost);
            Debug.Log(SugerSAmt);

            float butterCost = -1;
            Debug.Log(float.TryParse(i_butterCost.text, out butterCost));
            float butterAmt = -1;
            Debug.Log(float.TryParse(i_butterAmt.text, out butterAmt));
            float butterSAmt = (butterAmt * butterCost);
            Debug.Log(butterSAmt);

            float onionCost = -1;
            Debug.Log(float.TryParse(i_onionCost.text, out onionCost));
            float onionAmt = -1;
            Debug.Log(float.TryParse(i_onionAmt.text, out onionAmt));
            float onionSAmt = (onionAmt * onionCost);
            Debug.Log(onionSAmt);

            float eggCost = -1;
            Debug.Log(float.TryParse(i_eggCost.text, out eggCost));
            float eggAmt = -1;
            Debug.Log(float.TryParse(i_eggAmt.text, out eggAmt));
            float eggSAmt = (eggAmt * eggCost);
            Debug.Log(eggSAmt);

            float cinnamonCost = -1;
            Debug.Log(float.TryParse(i_cinnamonCost.text, out cinnamonCost));
            float cinnamonAmt = -1;
            Debug.Log(float.TryParse(i_cinnamonAmt.text, out cinnamonAmt));
            float cinnamonSAmt = (cinnamonAmt * cinnamonCost);
            Debug.Log(cinnamonSAmt);

            float BakingPowderCost = -1;
            Debug.Log(float.TryParse(i_BakingPowderCost.text, out BakingPowderCost));
            float BakingPowderAmt = -1;
            Debug.Log(float.TryParse(i_BakingPowderCost.text, out BakingPowderCost));
            float BakingPowderSAmt = (BakingPowderAmt * BakingPowderCost);
            Debug.Log(BakingPowderSAmt);

            float Cost = (flourSAmt + ChiliSAmt + PorkSAmt + SugerSAmt + RiceSAmt + EctSAmt + SaltSAmt + TortillaChipSAmt + LimeSAmt + HominySAmt + butterSAmt + onionSAmt + eggSAmt + cinnamonSAmt + BakingPowderSAmt);
            Debug.Log(Cost);
            float NOS = -1;
            Debug.Log(float.TryParse(i_NumberOfServings.text, out NOS));
            float MarkUpPrice = -1;
            Debug.Log(float.TryParse(i_MarkUpPrice.text, out MarkUpPrice));
            float CostPerServing = (Cost / NOS);
            Debug.Log(CostPerServing);
            float PPS = (CostPerServing * MarkUpPrice);
            Debug.Log(PPS);
            string PricePerServing = PPS.ToString();
            i_Total.text = "Total:" + PricePerServing + "$";
        }
        // for coping and pasting for new ingredients
        /*float Cost = -1;
        Debug.Log(float.TryParse(i_Cost.text, out Cost));
        float Amt = -1;
        Debug.Log(float.TryParse(i_Amt.text, out Amt));
        float SAmt = (Amt * Cost);
        Debug.Log(SAmt);*/
    }
}
