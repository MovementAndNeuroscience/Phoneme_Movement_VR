using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles selection of avatars.
/// </summary>
public class PickAvatar : MonoBehaviour
{
    public enum Gender { Male, Female, Nonbinary }
    public enum Age { Young, Old }

    [System.Serializable]
    private class Settings
    {
        [Header("READ-ONLY")]
        [Tooltip("Will be set by this script.")] public static Gender Gender;
        [Tooltip("Will be set by this script.")] public static Age Age;
    }


    [System.Serializable]
    private class References
    {
        [Header("Avatars")]
        public GameObject ElderMale;
        //public GameObject YoungMale;
        public GameObject ElderLady;
        //public GameObject YoungMaiden;

        //[Header("Questionnaire Input")]
        //public QuestionnaireAnswers questionnaireVnswers;

        [Header("Hands")]
        public SkinnedMeshRenderer LeftHand;
        public SkinnedMeshRenderer RightHand;
        public Material YoungHandSkin;
        public Material OldHandSkin;
    }

    public bool Load;

    //private readonly Settings settings = new Settings();
    [SerializeField] private References references;

    private GameObject[] Avatars;

    private void Awake() { Avatars = new GameObject[] { references.ElderMale, /*references.YoungMale,*/ references.ElderLady, /*references.YoungMaiden*/ }; }

    private void Start() { if (Load) LoadAvatar(); }

    private void DisableAllAvatars() { foreach (GameObject avatar in Avatars) avatar.SetActive(false); }

    public void SelectAvatarFromQuestionnaire(bool enableAvatar)
    {
        throw new System.Exception("Deprecated in Wedding simulation.");
        //int index = 0;
        //var vnswers = references.questionnaireVnswers.ExtractAnswers();

        //foreach (Answer v in vnswers)
        //    if (v.name.Contains("sex"))
        //        Settings.Gender = (Gender)(v.button_value - 1); // Questionnaire is not 0-indexed.
        //Settings.Age = (Random.value > 0.5) ? Age.Old : Age.Young;

        //if (Settings.Gender == Gender.Female) index += 2;
        //if (Settings.Age == Age.Young) index += 1;

        //PlayerPrefs.SetInt("AvatarChoice", index);
        //PlayerPrefs.Save();

        //if (!enableAvatar || Avatars[0] == null) return;
        //DisableAllAvatars();
        //Avatars[index].SetActive(true);
        //GetRigReferences();
        //SetHandTextures(Settings.Age);
    }

    public void LoadAvatar()
    {
        DisableAllAvatars();

        //Avatars[Mathf.RoundToInt(Random.value * 3)].SetActive(true); // Assign random avatar.

        if (!PlayerPrefs.HasKey("AvatarChoice"))
            references.ElderMale.SetActive(true);
        else
            Avatars[PlayerPrefs.GetInt("AvatarChoice")].SetActive(true);

        GetRigReferences();
        SetHandTextures(Settings.Age);
    }

    public Age GetAge()
    {
        return Settings.Age = (Age)((1 + PlayerPrefs.GetInt("AvatarChoice")) % 2);
    }

    public static Gender GetGender()
    {
        int avatarChoice = PlayerPrefs.GetInt("AvatarChoice");
        if (avatarChoice == 0) // First two are male, last two are female
            return Gender.Male;
        else
            return Gender.Female;
    }

    private void GetRigReferences()
    {
        var rig = FindObjectOfType<LimitReach_CameraRig>();
        if (rig != null)
            rig.GetAvatarHandReferences();
    }

    private void SetHandTextures(Age age) { references.LeftHand.material = references.RightHand.material = (age == Age.Young) ? references.YoungHandSkin : references.OldHandSkin; }


    public void PickMale()
    {
        Settings.Gender = Gender.Male;
        SaveSettings();
    }

    public void PickFemale()
    {
        Settings.Gender = Gender.Female;
        SaveSettings();
    }

    public void PickOther()
    {
        Settings.Gender = Gender.Nonbinary;
        SaveSettings();
    }

    private void SaveSettings()
    {
        Settings.Age = Age.Old;
        int index = (Settings.Gender == Gender.Male) ? 0 : 1;

        PlayerPrefs.SetInt("AvatarChoice", index);
        PlayerPrefs.Save();
    }
}
