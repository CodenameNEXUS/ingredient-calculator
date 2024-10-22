using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Collections.LowLevel.Unsafe;
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
    TMP_InputField i_TrotillaChipAmt;
    [SerializeField]
    TMP_InputField i_TortillaChipCost;
    [SerializeField]
    TMP_InputField i_EctAmt;
    [SerializeField]
    TMP_InputField i_EctCost;
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
            
            
            float Cost = (flourSAmt + ChiliSAmt + PorkSAmt);
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
            i_Total.text = PricePerServing;
        }
    }
}
