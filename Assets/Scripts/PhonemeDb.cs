using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PhonemeDb : MonoBehaviour
{
    public string activeLetters = "l l l å å å"; 
    public VideoClip a;
    private PhonemeVideoClass aClass; 
    public VideoClip b;
    private PhonemeVideoClass bClass;
    public VideoClip c;
    private PhonemeVideoClass cClass;
    public VideoClip d;
    private PhonemeVideoClass dClass;
    public VideoClip e;
    private PhonemeVideoClass eClass;
    public VideoClip f;
    private PhonemeVideoClass fClass;
    public VideoClip g;
    private PhonemeVideoClass gClass;
    public VideoClip h;
    private PhonemeVideoClass hClass;
    public VideoClip i;
    private PhonemeVideoClass iClass;
    public VideoClip j;
    private PhonemeVideoClass jClass;
    public VideoClip k;
    private PhonemeVideoClass kClass;
    public VideoClip l;
    private PhonemeVideoClass lClass;
    public VideoClip m;
    private PhonemeVideoClass mClass;
    public VideoClip n;
    private PhonemeVideoClass nClass;
    public VideoClip o;
    private PhonemeVideoClass oClass;
    public VideoClip p;
    private PhonemeVideoClass pClass;
    public VideoClip r;
    private PhonemeVideoClass rClass;
    public VideoClip s;
    private PhonemeVideoClass sClass;
    public VideoClip t;
    private PhonemeVideoClass tClass;
    public VideoClip uLyd1;
    private PhonemeVideoClass uLyd1Class;
    public VideoClip uLyd2;
    private PhonemeVideoClass uLyd2Class;
    public VideoClip vLyd1;
    private PhonemeVideoClass vLyd1Class;
    public VideoClip vLyd2;
    private PhonemeVideoClass vLyd2Class;
    public VideoClip y;
    private PhonemeVideoClass yClass;
    public VideoClip æ;
    private PhonemeVideoClass æClass;
    public VideoClip ø;
    private PhonemeVideoClass øClass;
    public VideoClip å;
    private PhonemeVideoClass åClass;
    public LinkedList<PhonemeVideoClass> phonemeVideoList = new LinkedList<PhonemeVideoClass>();



    // FOR S E GAME 
    // FOR E Lyd 1
    public Texture2D bamse;
    private PicturePhonemeClass bamseClass;
    public Texture2D aeble;
    private PicturePhonemeClass aebleClass;
    public Texture2D egern;
    private PicturePhonemeClass egernClass;
    public Texture2D fe;
    private PicturePhonemeClass feClass;
    public Texture2D vest;
    private PicturePhonemeClass vestClass;

    // FOR S lyd
    public Texture2D stop;
    private PicturePhonemeClass stopClass;
    public Texture2D svamp;
    private PicturePhonemeClass svampClass;

    // for L Å GAME 
    // L lyd
    public Texture2D laas;
    private PicturePhonemeClass laasClass;
    public Texture2D le;
    private PicturePhonemeClass leClass;

    // Å lyd
    public Texture2D aal;
    private PicturePhonemeClass aalClass;
    public Texture2D gaas;
    private PicturePhonemeClass gaasClass;

    // FOR O T GAME 
    // O lyd et
    public Texture2D skoO;
    private PicturePhonemeClass skoOClass;
    public Texture2D koO; 
    private PicturePhonemeClass koOClass;
    public Texture2D sol;
    private PicturePhonemeClass solClass;
    public Texture2D to;
    private PicturePhonemeClass toClass;
    public Texture2D orm;
    private PicturePhonemeClass ormClass;
    public Texture2D kano;
    private PicturePhonemeClass kanoClass;
    
    // O lyd to 
    public Texture2D kopO;
    private PicturePhonemeClass kopOClass;
    public Texture2D sokO;
    private PicturePhonemeClass sokOClass;
    public Texture2D ost;
    private PicturePhonemeClass ostClass;
    public Texture2D otte;
    private PicturePhonemeClass otteClass;
    public Texture2D boldO;
    private PicturePhonemeClass boldOClass;

    // T lyd
    public Texture2D tog; 
    private PicturePhonemeClass togClass;
    public Texture2D kat;
    private PicturePhonemeClass katClass;
    public Texture2D hatT;
    private PicturePhonemeClass hatClass;
    public Texture2D trold; 
    private PicturePhonemeClass troldClass;
    public Texture2D sutT;
    private PicturePhonemeClass sutTClass;

    //FOR K A B GAME 
    // A lyd et
    public Texture2D kageA;
    private PicturePhonemeClass kageAClass;
    public Texture2D hatA;
    private PicturePhonemeClass hatAClass;
    public Texture2D abeA;
    private PicturePhonemeClass abeAClass;
    public Texture2D and;
    private PicturePhonemeClass andClass;
    public Texture2D cola;
    private PicturePhonemeClass colaClass;

    // A lyd to
    public Texture2D kar;
    private PicturePhonemeClass karClass;
    public Texture2D mark;
    private PicturePhonemeClass markClass;
    public Texture2D kaffe;
    private PicturePhonemeClass kaffeClass;
    public Texture2D hare;
    private PicturePhonemeClass hareClass;
    public Texture2D giraf;
    private PicturePhonemeClass girafClass;

    // K lyd
    public Texture2D kageK; 
    private PicturePhonemeClass kageKClass;
    public Texture2D kopK;
    private PicturePhonemeClass kopKClass;
    public Texture2D sokK;
    private PicturePhonemeClass sokKClass;
    public Texture2D koK;
    private PicturePhonemeClass koKClass;
    public Texture2D skoK;
    private PicturePhonemeClass skoKClass;

    // B lyd
    public Texture2D boldB;
    private PicturePhonemeClass boldBClass;
    public Texture2D abeB;
    private PicturePhonemeClass abeBClass;
    public Texture2D skab;
    private PicturePhonemeClass skabClass;
    public Texture2D skib; 
    private PicturePhonemeClass skibClass;
    public Texture2D busB; 
    private PicturePhonemeClass busBClass;

    // FOR M U GAME 
    // U lyd et 
    public Texture2D busU;
    private PicturePhonemeClass busUClass;
    public Texture2D ugle;
    private PicturePhonemeClass ugleClass;
    public Texture2D murU;
    private PicturePhonemeClass murUClass;
    public Texture2D ur;
    private PicturePhonemeClass urClass;
    public Texture2D sutU;
    private PicturePhonemeClass sutUClass;

    // U lyd to 
    public Texture2D frugt;
    private PicturePhonemeClass frugtClass;
    public Texture2D vugge; 
    private PicturePhonemeClass vuggeClass;
    public Texture2D dukke;
    private PicturePhonemeClass dukkeClass;
    public Texture2D nul;
    private PicturePhonemeClass nulClass;
    public Texture2D gulv; 
    private PicturePhonemeClass gulvClass;

    // M lyd 
    public Texture2D mus;
    private PicturePhonemeClass musClass;
    public Texture2D murM;
    private PicturePhonemeClass murMClass;
    public Texture2D fem;
    private PicturePhonemeClass femClass;
    public Texture2D kam;
    private PicturePhonemeClass kamClass;
    public Texture2D kamel;
    private PicturePhonemeClass kamelClass;

    // FOR R I N GAME 
    // I lyd
    public Texture2D vin; 
    private PicturePhonemeClass vinClass;
    public Texture2D ti;
    private PicturePhonemeClass tiClass;
    public Texture2D nisse; 
    private PicturePhonemeClass nisseClass;
    public Texture2D isbjoern;
    private PicturePhonemeClass isbjoernClass;
    public Texture2D iglo; 
    private PicturePhonemeClass igloClass;
    public Texture2D girafI;
    private PicturePhonemeClass girafIClass;

    // R lyd et 
    public Texture2D girafR; 
    private PicturePhonemeClass girafRClass;
    public Texture2D hareR;
    private PicturePhonemeClass hareRClass;
    public Texture2D oereR; 
    private PicturePhonemeClass oereRClass;
    public Texture2D raket;
    private PicturePhonemeClass raketClass;
    public Texture2D rose; 
    private PicturePhonemeClass roseClass;

    // R lyd to 
    public Texture2D aender; 
    private PicturePhonemeClass aenderClass;
    public Texture2D biler; 
    private PicturePhonemeClass bilerClass;
    public Texture2D saeler; 
    private PicturePhonemeClass saelerClass;
    public Texture2D loever;
    private PicturePhonemeClass loeverClass;

    // N lyd 
    public Texture2D hane;
    private PicturePhonemeClass haneClass;
    public Texture2D delfin; 
    private PicturePhonemeClass delfinClass;
    public Texture2D kane; 
    private PicturePhonemeClass kaneClass;
    public Texture2D naale; 
    private PicturePhonemeClass naaleClass;
    public Texture2D net; 
    private PicturePhonemeClass netClass;

    // FOR D Y GAME 
    // FOR HÅRD D LYD 
    public Texture2D doer; 
    private PicturePhonemeClass doerClass;
    public Texture2D boldD;
    private PicturePhonemeClass boldDClass;
    public Texture2D daase;
    private PicturePhonemeClass daaseClass;
    public Texture2D drage;
    private PicturePhonemeClass drageClass;

    // FOR BLØD D LYD 
    public Texture2D bad;
    private PicturePhonemeClass badClass;
    public Texture2D baad; 
    private PicturePhonemeClass baadClass;
    public Texture2D glad; 
    private PicturePhonemeClass gladClass;
    public Texture2D kaede;
    private PicturePhonemeClass kaedeClass;
    public Texture2D lade;
    private PicturePhonemeClass ladeClass;

    // FOR Y LYD 
    public Texture2D sky; 
    private PicturePhonemeClass skyClass;
    public Texture2D nys;
    private PicturePhonemeClass nysClass;
    public Texture2D yver; 
    private PicturePhonemeClass yverClass;
    public Texture2D fly; 
    private PicturePhonemeClass flyClass;
    public Texture2D by; 
    private PicturePhonemeClass byClass;

    // FOR V Ø G GAME 
    // FOR V LYD ET
    public Texture2D vinV;
    private PicturePhonemeClass vinVClass;
    public Texture2D vestV;
    private PicturePhonemeClass vestVClass;
    public Texture2D loeve; 
    private PicturePhonemeClass loeveClass;
    public Texture2D rive;
    private PicturePhonemeClass riveClass;

    // FOR V LYD TO
    public Texture2D hav;
    private PicturePhonemeClass havClass;
    public Texture2D sav;
    private PicturePhonemeClass savClass;
    public Texture2D raev;
    private PicturePhonemeClass raevClass;
    public Texture2D skov;
    private PicturePhonemeClass skovClass;

    // FOR Ø LYD 
    public Texture2D boef;
    private PicturePhonemeClass boefClass;
    public Texture2D broed;
    private PicturePhonemeClass broedClass;
    public Texture2D noegle;
    private PicturePhonemeClass noegleClass;
    public Texture2D oern;
    private PicturePhonemeClass oernClass;
    public Texture2D oere;
    private PicturePhonemeClass oereClass;

    // FOR G LYD
    public Texture2D aeg;
    private PicturePhonemeClass aegClass;
    public Texture2D ged;
    private PicturePhonemeClass gedClass;
    public Texture2D girafG;
    private PicturePhonemeClass girafGClass;
    public Texture2D gris;
    private PicturePhonemeClass grisClass;
    public Texture2D vaeg; 
    private PicturePhonemeClass vaegClass;






    public List<PicturePhonemeClass> picturePhonemeList = new List<PicturePhonemeClass>();

    // Start is called before the first frame update
    void Start()
    {
        aClass = new PhonemeVideoClass(a);
        aClass.SetClipName(a);
        aClass.SetEnableRightHand(true);
        aClass.SetEnableLeftHand(true);
        aClass.SetPos1ReadyToHit(true);
        aClass.SetPos2ReadyToHit(true);
        aClass.SetNoOfPos(2);
        aClass.SetVisibleFromTime(3.25);
        aClass.SetPosShiftTime(6.60);

        aClass.SetLeftHandPos1(new Vector3(0.037f, 1.331f, -0.7251865f));
        aClass.SetLeftHandPos2(new Vector3(0.496f, 0.899f, -0.7251865f));
        aClass.SetRightHandPos1(new Vector3(-0.047f, 1.331f, -0.7251865f));
        aClass.SetRightHandPos2(new Vector3(-0.487f, 0.907f, -0.7251865f));

        aClass.SetLeftHandAngle1(new Vector3(0f, 0f, 36.939f));
        aClass.SetLeftHandAngle2(new Vector3(0f, 0f, -90.064f));
        aClass.SetRightHandAngle1(new Vector3(0f, 0f, -33.559f));
        aClass.SetRightHandAngle2(new Vector3(0.002f, -0.01f, 86.933f));


        bClass = new PhonemeVideoClass(b);
        bClass.SetClipName(b);
        bClass.SetEnableRightHand(true);
        bClass.SetEnableLeftHand(false);
        bClass.SetPos1ReadyToHit(true);
        bClass.SetPos2ReadyToHit(true);
        bClass.SetPos3ReadyToHit(true);
        bClass.SetNoOfPos(3);
        bClass.SetVisibleFromTime(2.90);
        bClass.SetPosShiftTime(3.2);
        bClass.SetPosShiftTime2(3.85);

        bClass.SetRightHandPos1(new Vector3(0.002f, 0.873f, -0.7251865f));
        bClass.SetRightHandPos2(new Vector3(-0.006f, 1.263f, -0.7251865f));
        bClass.SetRightHandPos3(new Vector3(-0.472f, 1.366f, -0.7251865f));

        bClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        bClass.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        bClass.SetRightHandAngle3(new Vector3(0f, 0f, 10.918f));

        cClass = new PhonemeVideoClass(c);
        cClass.SetClipName(c);
        // MANGLER D
        dClass = new PhonemeVideoClass(d);
        dClass.SetClipName(d);
        dClass.SetEnableRightHand(true);
        dClass.SetEnableLeftHand(true);
        dClass.SetPos1ReadyToHit(true);
        dClass.SetPos2ReadyToHit(true);
        dClass.SetPos3ReadyToHit(true);
        dClass.SetPos4ReadyToHit(true);
        dClass.SetPos5ReadyToHit(true);
        dClass.SetNoOfPos(5);
        dClass.SetVisibleFromTime(3.4);
        dClass.SetPosShiftTime(3.9);
        dClass.SetPosShiftTime2(6.7);
        dClass.SetPosShiftTime3(6.9);
        dClass.SetPosShiftTime4(7.4);

        dClass.SetLeftHandPos1(new Vector3(-0.0499f, 1.1752f, -0.7251865f));
        dClass.SetLeftHandPos2(new Vector3(-0.2366f, 1.1868f, -0.7251865f));
        dClass.SetLeftHandPos3(new Vector3(0.283f, 0.672f, -0.7251865f));
        dClass.SetLeftHandPos4(new Vector3(0.149f, 1.376f, -0.7251865f));
        dClass.SetLeftHandPos5(new Vector3(-0.182f, 0.768f, -0.7251865f));


        dClass.SetLeftHandAngle1(new Vector3(0f, 0f, 90f));
        dClass.SetLeftHandAngle2(new Vector3(0f, 0f, 90f));
        dClass.SetLeftHandAngle3(new Vector3(0f, 0f, 90f));
        dClass.SetLeftHandAngle4(new Vector3(0f, 0f, 90f));
        dClass.SetLeftHandAngle5(new Vector3(0f, 0f, 90f));

        dClass.SetRightHandPos1(new Vector3(-0.0277f, 1.1563f, -0.7251865f));
        dClass.SetRightHandPos2(new Vector3(-0.2367f, 1.1867f, -0.7251865f));
        dClass.SetRightHandPos3(new Vector3(0.226f, 0.784f, -0.7242f));
        dClass.SetRightHandPos4(new Vector3(-0.149f, 1.376f, -0.7242f));
        dClass.SetRightHandPos5(new Vector3(-0.451f, 0.773f, -0.7242f));


        dClass.SetRightHandAngle1(new Vector3(0f, 0f, 90f));
        dClass.SetRightHandAngle2(new Vector3(0f, 0f, 90f));
        dClass.SetRightHandAngle3(new Vector3(0f, 0f, 90f));
        dClass.SetRightHandAngle4(new Vector3(0f, 0f, 90f));
        dClass.SetRightHandAngle5(new Vector3(0f, 0f, 90f));

        eClass = new PhonemeVideoClass(e);
        eClass.SetClipName(e);
        eClass.SetEnableRightHand(true);
        eClass.SetEnableLeftHand(true);
        eClass.SetPos1ReadyToHit(true);
        eClass.SetPos2ReadyToHit(true);
        eClass.SetPos3ReadyToHit(true);
        eClass.SetNoOfPos(3);
        eClass.SetVisibleFromTime(3.07);
        eClass.SetPosShiftTime(5.0);
        eClass.SetPosShiftTime2(7.0);

        eClass.SetLeftHandPos1(new Vector3(0.087f, 1.283f, -0.7251865f));
        eClass.SetLeftHandPos2(new Vector3(0.243f, 1.161f, -0.7251865f));
        eClass.SetLeftHandPos3(new Vector3(0.128f, 0.755f, -0.7251865f));

        eClass.SetLeftHandAngle1(new Vector3(0f, 0f, 90f));
        eClass.SetLeftHandAngle2(new Vector3(0f, 0f, 90f));
        eClass.SetLeftHandAngle3(new Vector3(0f, 0f, 90f));

        eClass.SetRightHandPos1(new Vector3(-0.085f, 1.283f, -0.725f));
        eClass.SetRightHandPos2(new Vector3(-0.241f, 1.161f, -0.725f));
        eClass.SetRightHandPos3(new Vector3(-0.129f, 0.755f, -0.724f));

        eClass.SetRightHandAngle1(new Vector3(-0.24f, -0.249f, -90f));
        eClass.SetRightHandAngle2(new Vector3(-0.24f, -0.249f, -90f));
        eClass.SetRightHandAngle3(new Vector3(-0.24f, -0.249f, -90f));

        fClass = new PhonemeVideoClass(f);
        fClass.SetClipName(f);
        // MANGELR G
        gClass = new PhonemeVideoClass(g);
        gClass.SetClipName(g);
        gClass.SetEnableLeftHand(true);
        gClass.SetPos1ReadyToHit(true);
        gClass.SetPos2ReadyToHit(true);
        gClass.SetPos3ReadyToHit(true);
        gClass.SetNoOfPos(3);
        gClass.SetVisibleFromTime(3.2);
        gClass.SetPosShiftTime(3.7);
        gClass.SetPosShiftTime2(4.2);

        gClass.SetLeftHandPos1(new Vector3(0.462f, 0.925f, -0.7251865f));
        gClass.SetLeftHandPos2(new Vector3(0.072f, 0.658f, -0.7251865f));
        gClass.SetLeftHandPos3(new Vector3(-0.252f, 0.914f, -0.7251865f));

        gClass.SetLeftHandAngle1(new Vector3(0f, 0f, 90f));
        gClass.SetLeftHandAngle2(new Vector3(0f, 0f, 90f));
        gClass.SetLeftHandAngle3(new Vector3(0f, 0f, 90f));

        hClass = new PhonemeVideoClass(h);
        hClass.SetClipName(h);

        // MANGLER I 
        iClass = new PhonemeVideoClass(i);
        iClass.SetClipName(i);

        iClass.SetEnableRightHand(true);
        iClass.SetEnableLeftHand(true);
        iClass.SetPos1ReadyToHit(true);
        iClass.SetPos2ReadyToHit(true);
        iClass.SetPos3ReadyToHit(true);
        iClass.SetNoOfPos(3);
        iClass.SetVisibleFromTime(1.8);
        iClass.SetPosShiftTime(2.5);
        iClass.SetPosShiftTime2(3.1);

        iClass.SetLeftHandPos1(new Vector3(0.275f, 0.656f, -0.7251865f));
        iClass.SetLeftHandPos2(new Vector3(0.126f, 0.975f, -0.7251865f));
        iClass.SetLeftHandPos3(new Vector3(0.144f, 1.615f, -0.7251865f));

        iClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        iClass.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        iClass.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));

        iClass.SetRightHandPos1(new Vector3(-0.16f, 0.648f, -0.725f));
        iClass.SetRightHandPos2(new Vector3(-0.002f, 0.978f, -0.725f));
        iClass.SetRightHandPos3(new Vector3(-0.017f, 1.616f, -0.724f));

        iClass.SetRightHandAngle1(new Vector3(-0f, -0f, -0f));
        iClass.SetRightHandAngle2(new Vector3(0f, -0f, -0f));
        iClass.SetRightHandAngle3(new Vector3(-0f, -0f, -0f));

        jClass = new PhonemeVideoClass(j);
        jClass.SetClipName(j);

        kClass = new PhonemeVideoClass(k);
        kClass.SetClipName(k);
        kClass.SetEnableRightHand(true);
        kClass.SetEnableLeftHand(true);
        kClass.SetPos1ReadyToHit(true);
        kClass.SetPos2ReadyToHit(true);
        kClass.SetNoOfPos(2);
        kClass.SetVisibleFromTime(3.0);
        kClass.SetPosShiftTime(3.4);

        kClass.SetLeftHandPos1(new Vector3(0.115f, 1.039f, -0.7251865f));
        kClass.SetLeftHandPos2(new Vector3(0.174f, 0.777f, -0.7251865f));
        kClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        kClass.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));

        kClass.SetRightHandPos1(new Vector3(-0.12f, 1.044f, -0.7242f));
        kClass.SetRightHandPos2(new Vector3(-0.182f, 0.779f, -0.7242f));
        kClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        kClass.SetRightHandAngle2(new Vector3(0f, 0f, 0f));

        lClass = new PhonemeVideoClass(l);
        lClass.SetClipName(l);
        lClass.SetEnableRightHand(true);
        lClass.SetEnableLeftHand(true);
        lClass.SetPos1ReadyToHit(true);
        lClass.SetPos2ReadyToHit(true);
        lClass.SetPos3ReadyToHit(true);
        lClass.SetNoOfPos(3);
        lClass.SetVisibleFromTime(3.4);
        lClass.SetPosShiftTime(4.0);
        lClass.SetPosShiftTime2(4.4);

        lClass.SetLeftHandPos1(new Vector3(0.508f, 0.798f, -0.7251865f));
        lClass.SetLeftHandPos2(new Vector3(0.096f, 0.854f, -0.7251865f));
        lClass.SetLeftHandPos3(new Vector3(0.096f, 1.244f, -0.7251865f));
        lClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        lClass.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        lClass.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));

        lClass.SetRightHandPos1(new Vector3(-0.498f, 0.798f, -0.7242f));
        lClass.SetRightHandPos2(new Vector3(-0.089f, 0.854f, -0.7242f));
        lClass.SetRightHandPos3(new Vector3(-0.089f, 1.244f, -0.7242f));
        lClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        lClass.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        lClass.SetRightHandAngle3(new Vector3(0f, 0f, 0f));

        //MANGLER M 
        mClass = new PhonemeVideoClass(m);
        mClass.SetClipName(m);
        mClass.SetEnableRightHand(true);
        mClass.SetEnableLeftHand(false);
        mClass.SetPos1ReadyToHit(true);
        mClass.SetPos2ReadyToHit(true);
        mClass.SetPos3ReadyToHit(true);
        mClass.SetPos4ReadyToHit(true);
        mClass.SetPos5ReadyToHit(true);
        mClass.SetNoOfPos(5);
        mClass.SetVisibleFromTime(3.0);
        mClass.SetPosShiftTime(3.3);
        mClass.SetPosShiftTime2(3.6);
        mClass.SetPosShiftTime3(3.9);
        mClass.SetPosShiftTime4(4.2);

        mClass.SetRightHandPos1(new Vector3(0.087f, 0.755f, -0.7251865f));
        mClass.SetRightHandPos2(new Vector3(0.143f, 1.031f, -0.7242f));
        mClass.SetRightHandPos3(new Vector3(-0.006f, 1.153f, -0.7242f));
        mClass.SetRightHandPos4(new Vector3(-0.127f, 0.965f, -0.7251865f));
        mClass.SetRightHandPos5(new Vector3(0.001f, 0.842f, -0.7242f));

        mClass.SetRightHandAngle1(new Vector3(0f, 0f, 90f));
        mClass.SetRightHandAngle2(new Vector3(0f, 0f, 90f));
        mClass.SetRightHandAngle3(new Vector3(0f, 0f, 90f));
        mClass.SetRightHandAngle4(new Vector3(0f, 0f, 90f));
        mClass.SetRightHandAngle5(new Vector3(0f, 0f, 90f));

        // MANGLER N 
        nClass = new PhonemeVideoClass(n);
        nClass.SetClipName(n);
        nClass.SetEnableRightHand(true);
        nClass.SetPos1ReadyToHit(true);
        nClass.SetNoOfPos(1);
        nClass.SetVisibleFromTime(3.20);

        nClass.SetRightHandPos1(new Vector3(0.01f, 1.242f, -0.7251865f));

        nClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));

        oClass = new PhonemeVideoClass(o);
        oClass.SetClipName(o);
        oClass.SetEnableRightHand(true);
        oClass.SetEnableLeftHand(true);
        oClass.SetPos1ReadyToHit(true);
        oClass.SetPos2ReadyToHit(true);
        oClass.SetPos3ReadyToHit(true);
        oClass.SetPos4ReadyToHit(true);
        oClass.SetNoOfPos(4);
        oClass.SetVisibleFromTime(2.60);
        oClass.SetPosShiftTime(3.40);
        oClass.SetPosShiftTime2(4.15);
        oClass.SetPosShiftTime3(6.10);

        oClass.SetLeftHandPos1(new Vector3(-0.182f, 0.768f, -0.7251865f));
        oClass.SetLeftHandPos2(new Vector3(0.149f, 1.376f, -0.7251865f));
        oClass.SetLeftHandPos3(new Vector3(0.283f, 0.672f, -0.7251865f));
        oClass.SetLeftHandPos4(new Vector3(0.333f, 1.345f, -0.7251865f));

        oClass.SetLeftHandAngle1(new Vector3(0f, 0f, 90f));
        oClass.SetLeftHandAngle2(new Vector3(0f, 0f, 90f));
        oClass.SetLeftHandAngle3(new Vector3(0f, 0f, 90f));
        oClass.SetLeftHandAngle4(new Vector3(0f, 0f, 0f));


        oClass.SetRightHandPos1(new Vector3(-0.451f, 0.773f, -0.7242f));
        oClass.SetRightHandPos2(new Vector3(-0.149f, 1.376f, -0.7242f));
        oClass.SetRightHandPos3(new Vector3(0.226f, 0.784f, -0.7242f));
        oClass.SetRightHandPos4(new Vector3(-0.348f, 1.357f, -0.7242f));

        oClass.SetRightHandAngle1(new Vector3(0f, 0f, 90f));
        oClass.SetRightHandAngle2(new Vector3(0f, 0f, 90f));
        oClass.SetRightHandAngle3(new Vector3(0f, 0f, 90f));
        oClass.SetRightHandAngle4(new Vector3(0f, 0f, 0f));

        pClass = new PhonemeVideoClass(p);
        pClass.SetClipName(p);

        // MANGLER R 
        rClass = new PhonemeVideoClass(r);
        rClass.SetClipName(r);

        rClass.SetEnableRightHand(true);
        rClass.SetEnableLeftHand(true);
        rClass.SetPos1ReadyToHit(true);
        rClass.SetPos2ReadyToHit(true);
        rClass.SetPos3ReadyToHit(true);
        rClass.SetPos4ReadyToHit(true);
        rClass.SetNoOfPos(4);
        rClass.SetVisibleFromTime(2.5);
        rClass.SetPosShiftTime(3.30);
        rClass.SetPosShiftTime2(5.10);
        rClass.SetPosShiftTime3(5.58);

        rClass.SetLeftHandPos1(new Vector3(0.335f, 1.232f, -0.7251865f));
        rClass.SetLeftHandPos2(new Vector3(0.354f, 0.84f, -0.7251865f));
        rClass.SetLeftHandPos3(new Vector3(0.365f, 1.269f, -0.7251865f));
        rClass.SetLeftHandPos4(new Vector3(0.365f, 1.198f, -0.7251865f));

        rClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        rClass.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        rClass.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));
        rClass.SetLeftHandAngle4(new Vector3(0f, 0f, 0f));

        rClass.SetRightHandPos1(new Vector3(-0.213f, 1.215f, -0.725f));
        rClass.SetRightHandPos2(new Vector3(-0.247f, 0.851f, -0.725f));
        rClass.SetRightHandPos3(new Vector3(-0.236f, 1.272f, -0.724f));
        rClass.SetRightHandPos4(new Vector3(-0.236f, 1.201f, -0.724f));

        rClass.SetRightHandAngle1(new Vector3(-0f, -0f, -0f));
        rClass.SetRightHandAngle2(new Vector3(0f, -0f, -0f));
        rClass.SetRightHandAngle3(new Vector3(-0f, -0f, -0f));
        rClass.SetRightHandAngle4(new Vector3(-0f, -0f, -0f));

        sClass = new PhonemeVideoClass(s);
        sClass.SetClipName(s);
        sClass.SetEnableRightHand(true);
        sClass.SetPos1ReadyToHit(true);
        sClass.SetPos2ReadyToHit(true);
        sClass.SetPos3ReadyToHit(true);
        sClass.SetNoOfPos(3);
        sClass.SetVisibleFromTime(2.40);
        sClass.SetPosShiftTime(3.10);
        sClass.SetPosShiftTime2(3.48);

        sClass.SetLeftHandPos1(new Vector3(0.0f, -0.5f, 0.0f));
        sClass.SetLeftHandPos2(new Vector3(0.0f, -0.5f, 0.0f));
        sClass.SetLeftHandPos3(new Vector3(0.0f, -0.5f, 0.0f));

        sClass.SetRightHandPos1(new Vector3(-0.3841f, 1.2778f, -0.7251865f));
        sClass.SetRightHandPos2(new Vector3(0.174f, 0.9739f, -0.72518f));
        sClass.SetRightHandPos3(new Vector3(0.4713f, 1.154f, -0.7251865f));

        sClass.SetLeftHandAngle1(new Vector3(0f, 0f, 90f));
        sClass.SetLeftHandAngle2(new Vector3(0f, 0f, 90));
        sClass.SetLeftHandAngle3(new Vector3(0f, 0f, 90f));

        tClass = new PhonemeVideoClass(t);
        tClass.SetClipName(t);
        tClass.SetEnableRightHand(true);
        tClass.SetEnableLeftHand(true);
        tClass.SetPos1ReadyToHit(true);
        tClass.SetPos2ReadyToHit(true);
        tClass.SetPos3ReadyToHit(true);
        tClass.SetNoOfPos(3);
        tClass.SetVisibleFromTime(2.60);
        tClass.SetPosShiftTime(3.05);
        tClass.SetPosShiftTime2(3.45);

        tClass.SetLeftHandPos1(new Vector3(0.268f, 0.91f, -0.7251865f));
        tClass.SetLeftHandPos2(new Vector3(0.268f, 1.37f, -0.7251865f));
        tClass.SetLeftHandPos3(new Vector3(0.32f, 0.78f, -0.7251865f));

        tClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        tClass.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        tClass.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));

        tClass.SetRightHandPos1(new Vector3(-0.257f, 0.91f, -0.725f));
        tClass.SetRightHandPos2(new Vector3(-0.257f, 1.37f, -0.725f));
        tClass.SetRightHandPos3(new Vector3(-0.31f, 0.78f, -0.724f));

        tClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        tClass.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        tClass.SetRightHandAngle3(new Vector3(0f, 0f, 0f));

        // MANGLER U Lyd 1 
        uLyd1Class = new PhonemeVideoClass(uLyd1);
        uLyd1Class.SetClipName(uLyd1);
        uLyd1Class.SetEnableRightHand(true);
        uLyd1Class.SetEnableLeftHand(true);
        uLyd1Class.SetPos1ReadyToHit(true);
        uLyd1Class.SetPos2ReadyToHit(true);
        uLyd1Class.SetPos3ReadyToHit(true);
        uLyd1Class.SetPos4ReadyToHit(true);
        uLyd1Class.SetNoOfPos(4);
        uLyd1Class.SetVisibleFromTime(2.30);
        uLyd1Class.SetPosShiftTime(2.93);
        uLyd1Class.SetPosShiftTime2(3.30);
        uLyd1Class.SetPosShiftTime3(3.93);

        uLyd1Class.SetLeftHandPos1(new Vector3(0.095f, 0.803f, -0.7251865f));
        uLyd1Class.SetLeftHandPos2(new Vector3(0.259f, 0.584f, -0.7251865f));
        uLyd1Class.SetLeftHandPos3(new Vector3(0.548f, 0.916f, -0.7251865f));
        uLyd1Class.SetLeftHandPos4(new Vector3(0.433f, 1.391f, -0.7251865f));

        uLyd1Class.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        uLyd1Class.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        uLyd1Class.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));
        uLyd1Class.SetLeftHandAngle4(new Vector3(0f, 0f, 0f));

        uLyd1Class.SetRightHandPos1(new Vector3(0.016f, 0.802f, -0.725f));
        uLyd1Class.SetRightHandPos2(new Vector3(-0.16f, 0.589f, -0.725f));
        uLyd1Class.SetRightHandPos3(new Vector3(-0.411f, 0.908f, -0.724f));
        uLyd1Class.SetRightHandPos4(new Vector3(-0.332f, 1.394f, -0.724f));

        uLyd1Class.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        uLyd1Class.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        uLyd1Class.SetRightHandAngle3(new Vector3(0f, 0f, 0f));
        uLyd1Class.SetRightHandAngle4(new Vector3(0f, 0f, 0f));

        // MANGLER U Lyd 2 
        uLyd2Class = new PhonemeVideoClass(uLyd2);
        uLyd2Class.SetClipName(uLyd2);
        uLyd2Class.SetEnableRightHand(true);
        uLyd2Class.SetEnableLeftHand(true);
        uLyd2Class.SetPos1ReadyToHit(true);
        uLyd2Class.SetPos2ReadyToHit(true);
        uLyd2Class.SetPos3ReadyToHit(true);
        uLyd2Class.SetPos4ReadyToHit(true);
        uLyd2Class.SetNoOfPos(4);
        uLyd2Class.SetVisibleFromTime(3.40);
        uLyd2Class.SetPosShiftTime(3.93);
        uLyd2Class.SetPosShiftTime2(4.44);
        uLyd2Class.SetPosShiftTime3(5.00);

        uLyd2Class.SetLeftHandPos1(new Vector3(0.1219f, 1.528f, -0.7251865f));
        uLyd2Class.SetLeftHandPos2(new Vector3(0.049f, 1.528f, -0.7251865f));
        uLyd2Class.SetLeftHandPos3(new Vector3(0.1219f, 1.528f, -0.7251865f));
        uLyd2Class.SetLeftHandPos4(new Vector3(0.049f, 1.528f, -0.7251865f));

        uLyd2Class.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        uLyd2Class.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        uLyd2Class.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));
        uLyd2Class.SetLeftHandAngle4(new Vector3(0f, 0f, 0f));

        uLyd2Class.SetRightHandPos1(new Vector3(-0.126f, 1.528f, -0.725f));
        uLyd2Class.SetRightHandPos2(new Vector3(-0.056f, 1.528f, -0.725f));
        uLyd2Class.SetRightHandPos3(new Vector3(-0.126f, 1.528f, -0.724f));
        uLyd2Class.SetRightHandPos4(new Vector3(-0.056f, 1.528f, -0.724f));

        uLyd2Class.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        uLyd2Class.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        uLyd2Class.SetRightHandAngle3(new Vector3(0f, 0f, 0f));
        uLyd2Class.SetRightHandAngle4(new Vector3(0f, 0f, 0f));

        // MANGLER V
        vLyd1Class = new PhonemeVideoClass(vLyd1);
        vLyd1Class.SetClipName(vLyd1);
        vLyd1Class.SetEnableRightHand(true);
        vLyd1Class.SetEnableLeftHand(true);
        vLyd1Class.SetPos1ReadyToHit(true);
        vLyd1Class.SetPos2ReadyToHit(true);
        vLyd1Class.SetNoOfPos(2);
        vLyd1Class.SetVisibleFromTime(2.00);
        vLyd1Class.SetPosShiftTime(2.92);

        vLyd1Class.SetLeftHandPos1(new Vector3(0.433f, 1.391f, -0.7251865f));
        vLyd1Class.SetLeftHandPos2(new Vector3(0.111f, 0.653f, -0.7251865f));

        vLyd1Class.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        vLyd1Class.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));

        vLyd1Class.SetRightHandPos1(new Vector3(-0.332f, 1.394f, -0.725f));
        vLyd1Class.SetRightHandPos2(new Vector3(0.024f, 0.655f, -0.725f));

        vLyd1Class.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        vLyd1Class.SetRightHandAngle2(new Vector3(0f, 0f, 0f));

        vLyd2Class = new PhonemeVideoClass(vLyd2);
        vLyd2Class.SetClipName(vLyd2);
        vLyd2Class.SetEnableRightHand(true);
        vLyd2Class.SetEnableLeftHand(true);
        vLyd2Class.SetPos1ReadyToHit(true);
        vLyd2Class.SetPos2ReadyToHit(true);
        vLyd2Class.SetPos3ReadyToHit(true);
        vLyd2Class.SetPos4ReadyToHit(true);
        vLyd2Class.SetNoOfPos(4);
        vLyd2Class.SetVisibleFromTime(1.80);
        vLyd2Class.SetPosShiftTime(2.39);
        vLyd2Class.SetPosShiftTime2(2.76);
        vLyd2Class.SetPosShiftTime3(3.28);

        vLyd2Class.SetLeftHandPos1(new Vector3(0.095f, 0.803f, -0.7251865f));
        vLyd2Class.SetLeftHandPos2(new Vector3(0.259f, 0.584f, -0.7251865f));
        vLyd2Class.SetLeftHandPos3(new Vector3(0.548f, 0.916f, -0.7251865f));
        vLyd2Class.SetLeftHandPos4(new Vector3(0.433f, 1.391f, -0.7251865f));

        vLyd2Class.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        vLyd2Class.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        vLyd2Class.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));
        vLyd2Class.SetLeftHandAngle4(new Vector3(0f, 0f, 0f));

        vLyd2Class.SetRightHandPos1(new Vector3(0.016f, 0.802f, -0.725f));
        vLyd2Class.SetRightHandPos2(new Vector3(-0.16f, 0.589f, -0.725f));
        vLyd2Class.SetRightHandPos3(new Vector3(-0.411f, 0.908f, -0.724f));
        vLyd2Class.SetRightHandPos4(new Vector3(-0.332f, 1.394f, -0.724f));

        vLyd2Class.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        vLyd2Class.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        vLyd2Class.SetRightHandAngle3(new Vector3(0f, 0f, 0f));
        vLyd2Class.SetRightHandAngle4(new Vector3(0f, 0f, 0f));

        // MANGLER Y
        yClass = new PhonemeVideoClass(y);
        yClass.SetClipName(y);

        yClass.SetEnableRightHand(true);
        yClass.SetEnableLeftHand(true);
        yClass.SetPos1ReadyToHit(true);
        yClass.SetNoOfPos(1);
        yClass.SetVisibleFromTime(3.80);

        yClass.SetLeftHandPos1(new Vector3(0.455f, 1.534f, -0.7251865f));
        yClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        yClass.SetRightHandPos1(new Vector3(-0.36f, 1.53f, -0.725f));
        yClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));

        æClass = new PhonemeVideoClass(æ);
        æClass.SetClipName(æ);
        // MANGLER Ø
        øClass = new PhonemeVideoClass(ø);
        øClass.SetClipName(ø);

        øClass.SetEnableRightHand(true);
        øClass.SetEnableLeftHand(true);
        øClass.SetPos1ReadyToHit(true);
        øClass.SetNoOfPos(1);
        øClass.SetVisibleFromTime(4.30);
        øClass.SetLeftHandPos1(new Vector3(0.16f, 1.355f, -0.7251865f));
        øClass.SetLeftHandAngle1(new Vector3(0f, 0f, 90f));
        øClass.SetRightHandPos1(new Vector3(-0.028f, 1.356f, -0.725f));
        øClass.SetRightHandAngle1(new Vector3(0f, 0f, 90f));

        åClass = new PhonemeVideoClass(å);
        åClass.SetClipName(å);
        åClass.SetEnableRightHand(true);
        åClass.SetEnableLeftHand(true);
        åClass.SetPos1ReadyToHit(true);
        åClass.SetPos2ReadyToHit(true);
        åClass.SetPos3ReadyToHit(true);
        åClass.SetPos4ReadyToHit(true);
        åClass.SetNoOfPos(4);
        åClass.SetVisibleFromTime(2.75);
        åClass.SetPosShiftTime(3.41);
        åClass.SetPosShiftTime2(4.07);
        åClass.SetPosShiftTime3(4.75);

        åClass.SetLeftHandPos1(new Vector3(0.1219f, 1.528f, -0.7251865f));
        åClass.SetLeftHandPos2(new Vector3(0.049f, 1.528f, -0.7251865f));
        åClass.SetLeftHandPos3(new Vector3(0.1219f, 1.528f, -0.7251865f));
        åClass.SetLeftHandPos4(new Vector3(0.049f, 1.528f, -0.7251865f));

        åClass.SetLeftHandAngle1(new Vector3(0f, 0f, 0f));
        åClass.SetLeftHandAngle2(new Vector3(0f, 0f, 0f));
        åClass.SetLeftHandAngle3(new Vector3(0f, 0f, 0f));
        åClass.SetLeftHandAngle4(new Vector3(0f, 0f, 0f));

        åClass.SetRightHandPos1(new Vector3(-0.126f, 1.528f, -0.725f));
        åClass.SetRightHandPos2(new Vector3(-0.056f, 1.528f, -0.725f));
        åClass.SetRightHandPos3(new Vector3(-0.126f, 1.528f, -0.724f));
        åClass.SetRightHandPos4(new Vector3(-0.056f, 1.528f, -0.724f));

        åClass.SetRightHandAngle1(new Vector3(0f, 0f, 0f));
        åClass.SetRightHandAngle2(new Vector3(0f, 0f, 0f));
        åClass.SetRightHandAngle3(new Vector3(0f, 0f, 0f));
        åClass.SetRightHandAngle4(new Vector3(0f, 0f, 0f));

        phonemeVideoList.AddLast(aClass);
        phonemeVideoList.AddLast(bClass);
        phonemeVideoList.AddLast(cClass);
        phonemeVideoList.AddLast(dClass);
        phonemeVideoList.AddLast(eClass);
        phonemeVideoList.AddLast(fClass);
        phonemeVideoList.AddLast(gClass);
        phonemeVideoList.AddLast(hClass);
        phonemeVideoList.AddLast(iClass);
        phonemeVideoList.AddLast(jClass);
        phonemeVideoList.AddLast(kClass);
        phonemeVideoList.AddLast(lClass);
        phonemeVideoList.AddLast(mClass);
        phonemeVideoList.AddLast(nClass);
        phonemeVideoList.AddLast(oClass);
        phonemeVideoList.AddLast(pClass);
        phonemeVideoList.AddLast(rClass);
        phonemeVideoList.AddLast(sClass);
        phonemeVideoList.AddLast(tClass);
        phonemeVideoList.AddLast(uLyd1Class);
        phonemeVideoList.AddLast(uLyd2Class);
        phonemeVideoList.AddLast(vLyd1Class);
        phonemeVideoList.AddLast(vLyd2Class);
        phonemeVideoList.AddLast(yClass);
        phonemeVideoList.AddLast(æClass);
        phonemeVideoList.AddLast(øClass);
        phonemeVideoList.AddLast(åClass);


        //a Lyd et 
        abeAClass = new PicturePhonemeClass(abeA);
        abeAClass.SetImageName("abe");
        abeAClass.SetAssignment("Hvad er den første lyd i ordet");
        abeAClass.SetAssignmentLetter("a");
        abeAClass.SetNoOfPos(1);
        abeAClass.SetEnableLeftHand(true);
        abeAClass.SetEnableRightHand(true);
        abeAClass.SetPos1ReadyToHit(true);
        abeAClass.SetRightHandAngle1(aClass.GetRightHandAngle1());
        abeAClass.SetRightHandPos1(aClass.GetRightHandpos1());
        abeAClass.SetLeftHandAngle1(aClass.GetLeftHandAngle1());
        abeAClass.SetLeftHandPos1(aClass.GetLeftHandpos1());

        //b lyd
        abeBClass = new PicturePhonemeClass(abeB);
        abeBClass.SetImageName("abe");
        abeBClass.SetAssignment("Hvad er den midterste lyd i ordet");
        abeBClass.SetAssignmentLetter("b");
        abeBClass.SetNoOfPos(3);
        abeBClass.SetEnableRightHand(true);
        abeBClass.SetPos1ReadyToHit(true);
        abeBClass.SetPos2ReadyToHit(true);
        abeBClass.SetPos3ReadyToHit(true);
        abeBClass.SetRightHandAngle1(bClass.GetRightHandAngle1());
        abeBClass.SetRightHandAngle2(bClass.GetRightHandAngle2());
        abeBClass.SetRightHandAngle3(bClass.GetRightHandAngle3());
        abeBClass.SetRightHandPos1(bClass.GetRightHandpos1());
        abeBClass.SetRightHandPos2(bClass.GetRightHandpos2());
        abeBClass.SetRightHandPos3(bClass.GetRightHandpos3());

        boldBClass = new PicturePhonemeClass(boldB);
        boldBClass.SetImageName("bold");
        boldBClass.SetAssignment("Hvad er den første lyd i ordet");
        boldBClass.SetAssignmentLetter("b");
        boldBClass.SetNoOfPos(3);
        boldBClass.SetEnableRightHand(true);
        boldBClass.SetPos1ReadyToHit(true);
        boldBClass.SetPos2ReadyToHit(true);
        boldBClass.SetPos3ReadyToHit(true);
        boldBClass.SetRightHandAngle1(bClass.GetRightHandAngle1());
        boldBClass.SetRightHandAngle2(bClass.GetRightHandAngle2());
        boldBClass.SetRightHandAngle3(bClass.GetRightHandAngle3());
        boldBClass.SetRightHandPos1(bClass.GetRightHandpos1());
        boldBClass.SetRightHandPos2(bClass.GetRightHandpos2());
        boldBClass.SetRightHandPos3(bClass.GetRightHandpos3());

        skabClass = new PicturePhonemeClass(skab);
        skabClass.SetImageName("skab");
        skabClass.SetAssignment("Hvad er den sidste lyd i ordet");
        skabClass.SetAssignmentLetter("b");
        skabClass.SetNoOfPos(3);
        skabClass.SetEnableRightHand(true);
        skabClass.SetPos1ReadyToHit(true);
        skabClass.SetPos2ReadyToHit(true);
        skabClass.SetPos3ReadyToHit(true);
        skabClass.SetRightHandAngle1(bClass.GetRightHandAngle1());
        skabClass.SetRightHandAngle2(bClass.GetRightHandAngle2());
        skabClass.SetRightHandAngle3(bClass.GetRightHandAngle3());
        skabClass.SetRightHandPos1(bClass.GetRightHandpos1());
        skabClass.SetRightHandPos2(bClass.GetRightHandpos2());
        skabClass.SetRightHandPos3(bClass.GetRightHandpos3());

        skibClass = new PicturePhonemeClass(skib);
        skibClass.SetImageName("skib");
        skibClass.SetAssignment("Hvad er den sidste lyd i ordet");
        skibClass.SetAssignmentLetter("b");
        skibClass.SetNoOfPos(3);
        skibClass.SetEnableRightHand(true);
        skibClass.SetPos1ReadyToHit(true);
        skibClass.SetPos2ReadyToHit(true);
        skibClass.SetPos3ReadyToHit(true);
        skibClass.SetRightHandAngle1(bClass.GetRightHandAngle1());
        skibClass.SetRightHandAngle2(bClass.GetRightHandAngle2());
        skibClass.SetRightHandAngle3(bClass.GetRightHandAngle3());
        skibClass.SetRightHandPos1(bClass.GetRightHandpos1());
        skibClass.SetRightHandPos2(bClass.GetRightHandpos2());
        skibClass.SetRightHandPos3(bClass.GetRightHandpos3());

        busBClass = new PicturePhonemeClass(busB);
        busBClass.SetImageName("bus");
        busBClass.SetAssignment("Hvad er den første lyd i ordet");
        busBClass.SetAssignmentLetter("b");
        busBClass.SetNoOfPos(3);
        busBClass.SetEnableRightHand(true);
        busBClass.SetPos1ReadyToHit(true);
        busBClass.SetPos2ReadyToHit(true);
        busBClass.SetPos3ReadyToHit(true);
        busBClass.SetRightHandAngle1(bClass.GetRightHandAngle1());
        busBClass.SetRightHandAngle2(bClass.GetRightHandAngle2());
        busBClass.SetRightHandAngle3(bClass.GetRightHandAngle3());
        busBClass.SetRightHandPos1(bClass.GetRightHandpos1());
        busBClass.SetRightHandPos2(bClass.GetRightHandpos2());
        busBClass.SetRightHandPos3(bClass.GetRightHandpos3());


        //a Lyd et 
        andClass = new PicturePhonemeClass(and);
        andClass.SetImageName("and");
        andClass.SetAssignment("Hvad er den første lyd i ordet");
        andClass.SetAssignmentLetter("a");
        andClass.SetNoOfPos(1);
        andClass.SetEnableLeftHand(true);
        andClass.SetEnableRightHand(true);
        andClass.SetPos1ReadyToHit(true);
        andClass.SetRightHandAngle1(aClass.GetRightHandAngle1());
        andClass.SetRightHandPos1(aClass.GetRightHandpos1());
        andClass.SetLeftHandAngle1(aClass.GetLeftHandAngle1());
        andClass.SetLeftHandPos1(aClass.GetLeftHandpos1());


        kageAClass = new PicturePhonemeClass(kageA);
        kageAClass.SetImageName("kage");
        kageAClass.SetAssignment("Hvad er den første vokal i ordett");
        kageAClass.SetAssignmentLetter("a");
        kageAClass.SetNoOfPos(1);
        kageAClass.SetEnableLeftHand(true);
        kageAClass.SetEnableRightHand(true);
        kageAClass.SetPos1ReadyToHit(true);
        kageAClass.SetRightHandAngle1(aClass.GetRightHandAngle1());
        kageAClass.SetRightHandPos1(aClass.GetRightHandpos1());
        kageAClass.SetLeftHandAngle1(aClass.GetLeftHandAngle1());
        kageAClass.SetLeftHandPos1(aClass.GetLeftHandpos1());

        hatAClass = new PicturePhonemeClass(hatA);
        hatAClass.SetImageName("hat");
        hatAClass.SetAssignment("Hvad er den midterste lyd i ordet");
        hatAClass.SetAssignmentLetter("a");
        hatAClass.SetNoOfPos(1);
        hatAClass.SetEnableLeftHand(true);
        hatAClass.SetEnableRightHand(true);
        hatAClass.SetPos1ReadyToHit(true);
        hatAClass.SetRightHandAngle1(aClass.GetRightHandAngle1());
        hatAClass.SetRightHandPos1(aClass.GetRightHandpos1());
        hatAClass.SetLeftHandAngle1(aClass.GetLeftHandAngle1());
        hatAClass.SetLeftHandPos1(aClass.GetLeftHandpos1());

        colaClass = new PicturePhonemeClass(cola);
        colaClass.SetImageName("cola");
        colaClass.SetAssignment("Hvad er den sidste lyd i ordet");
        colaClass.SetAssignmentLetter("a");
        colaClass.SetNoOfPos(1);
        colaClass.SetEnableLeftHand(true);
        colaClass.SetEnableRightHand(true);
        colaClass.SetPos1ReadyToHit(true);
        colaClass.SetRightHandAngle1(aClass.GetRightHandAngle1());
        colaClass.SetRightHandPos1(aClass.GetRightHandpos1());
        colaClass.SetLeftHandAngle1(aClass.GetLeftHandAngle1());
        colaClass.SetLeftHandPos1(aClass.GetLeftHandpos1());

        //a Lyd to
        bamseClass = new PicturePhonemeClass(bamse);
        bamseClass.SetImageName("bamse");
        bamseClass.SetAssignment("Hvad er den anden lyd i ordet");
        bamseClass.SetAssignmentLetter("a");
        bamseClass.SetNoOfPos(1);
        bamseClass.SetEnableLeftHand(true);
        bamseClass.SetEnableRightHand(true);
        bamseClass.SetPos1ReadyToHit(true);
        bamseClass.SetLeftHandPos1(aClass.GetLeftHandpos2());
        bamseClass.SetRightHandPos1(aClass.GetRightHandpos2());
        bamseClass.SetLeftHandAngle1(aClass.GetLeftHandAngle2());
        bamseClass.SetRightHandAngle1(aClass.GetRightHandAngle2());

        karClass = new PicturePhonemeClass(kar);
        karClass.SetImageName("har");
        karClass.SetAssignment("Hvad er den midterste lyd");
        karClass.SetAssignmentLetter("a");
        karClass.SetNoOfPos(1);
        karClass.SetEnableLeftHand(true);
        karClass.SetEnableRightHand(true);
        karClass.SetPos1ReadyToHit(true);
        karClass.SetLeftHandPos1(aClass.GetLeftHandpos2());
        karClass.SetRightHandPos1(aClass.GetRightHandpos2());
        karClass.SetLeftHandAngle1(aClass.GetLeftHandAngle2());
        karClass.SetRightHandAngle1(aClass.GetRightHandAngle2());

        markClass = new PicturePhonemeClass(mark);
        markClass.SetImageName("mark");
        markClass.SetAssignment("Hvad er den midterste lyd");
        markClass.SetAssignmentLetter("a");
        markClass.SetNoOfPos(1);
        markClass.SetEnableLeftHand(true);
        markClass.SetEnableRightHand(true);
        markClass.SetPos1ReadyToHit(true);
        markClass.SetLeftHandPos1(aClass.GetLeftHandpos2());
        markClass.SetRightHandPos1(aClass.GetRightHandpos2());
        markClass.SetLeftHandAngle1(aClass.GetLeftHandAngle2());
        markClass.SetRightHandAngle1(aClass.GetRightHandAngle2());

        kaffeClass = new PicturePhonemeClass(kaffe);
        kaffeClass.SetImageName("kaffe");
        kaffeClass.SetAssignment("Hvad er den første vokal lyd");
        kaffeClass.SetAssignmentLetter("a");
        kaffeClass.SetNoOfPos(1);
        kaffeClass.SetEnableLeftHand(true);
        kaffeClass.SetEnableRightHand(true);
        kaffeClass.SetPos1ReadyToHit(true);
        kaffeClass.SetLeftHandPos1(aClass.GetLeftHandpos2());
        kaffeClass.SetRightHandPos1(aClass.GetRightHandpos2());
        kaffeClass.SetLeftHandAngle1(aClass.GetLeftHandAngle2());
        kaffeClass.SetRightHandAngle1(aClass.GetRightHandAngle2());

        hareClass = new PicturePhonemeClass(hare);
        hareClass.SetImageName("hare");
        hareClass.SetAssignment("Hvad er den første vokal lyd");
        hareClass.SetAssignmentLetter("a");
        hareClass.SetNoOfPos(1);
        hareClass.SetEnableLeftHand(true);
        hareClass.SetEnableRightHand(true);
        hareClass.SetPos1ReadyToHit(true);
        hareClass.SetLeftHandPos1(aClass.GetLeftHandpos2());
        hareClass.SetRightHandPos1(aClass.GetRightHandpos2());
        hareClass.SetLeftHandAngle1(aClass.GetLeftHandAngle2());
        hareClass.SetRightHandAngle1(aClass.GetRightHandAngle2());

        girafClass = new PicturePhonemeClass(giraf);
        girafClass.SetImageName("giraf");
        girafClass.SetAssignment("Hvad er den sidste vokal lyd");
        girafClass.SetAssignmentLetter("a");
        girafClass.SetNoOfPos(1);
        girafClass.SetEnableLeftHand(true);
        girafClass.SetEnableRightHand(true);
        girafClass.SetPos1ReadyToHit(true);
        girafClass.SetLeftHandPos1(aClass.GetLeftHandpos2());
        girafClass.SetRightHandPos1(aClass.GetRightHandpos2());
        girafClass.SetLeftHandAngle1(aClass.GetLeftHandAngle2());
        girafClass.SetRightHandAngle1(aClass.GetRightHandAngle2());

        // e lyd et
        egernClass = new PicturePhonemeClass(egern);
        egernClass.SetImageName("egern");
        egernClass.SetAssignment("Hvad er den første lyd i ordet");
        egernClass.SetAssignmentLetter("e");
        egernClass.SetNoOfPos(1);
        egernClass.SetEnableRightHand(true);
        egernClass.SetEnableLeftHand(true);
        egernClass.SetPos1ReadyToHit(true);
        egernClass.SetLeftHandPos1(eClass.GetLeftHandpos1());
        egernClass.SetLeftHandAngle1(eClass.GetLeftHandAngle1());
        egernClass.SetRightHandPos1(eClass.GetRightHandpos1());
        egernClass.SetRightHandAngle1(eClass.GetRightHandAngle1());

        // D lyd 1 
            
        doerClass = new PicturePhonemeClass(doer);
        doerClass.SetImageName("doer");
        doerClass.SetAssignment("Hvad er den første lyd i ordet");
        doerClass.SetAssignmentLetter("d");
        doerClass.SetNoOfPos(2);
        doerClass.SetEnableLeftHand(true);
        doerClass.SetEnableRightHand(true);
        doerClass.SetPos1ReadyToHit(true);
        doerClass.SetPos2ReadyToHit(true);
        doerClass.SetRightHandAngle1(dClass.GetRightHandAngle1());
        doerClass.SetRightHandAngle2(dClass.GetRightHandAngle2());
        doerClass.SetRightHandPos1(dClass.GetRightHandpos1());
        doerClass.SetRightHandPos2(dClass.GetRightHandpos2());
        doerClass.SetLeftHandAngle1(dClass.GetLeftHandAngle1());
        doerClass.SetLeftHandAngle2(dClass.GetLeftHandAngle2());
        doerClass.SetLeftHandPos1(dClass.GetLeftHandpos1());
        doerClass.SetLeftHandPos2(dClass.GetLeftHandpos2());

        boldDClass = new PicturePhonemeClass(boldD);
        boldDClass.SetImageName("bold");
        boldDClass.SetAssignment("Hvad er den sidste lyd i ordet");
        boldDClass.SetAssignmentLetter("d");
        boldDClass.SetNoOfPos(2);
        boldDClass.SetEnableLeftHand(true);
        boldDClass.SetEnableRightHand(true);
        boldDClass.SetPos1ReadyToHit(true);
        boldDClass.SetPos2ReadyToHit(true);
        boldDClass.SetRightHandAngle1(dClass.GetRightHandAngle1());
        boldDClass.SetRightHandAngle2(dClass.GetRightHandAngle2());
        boldDClass.SetRightHandPos1(dClass.GetRightHandpos1());
        boldDClass.SetRightHandPos2(dClass.GetRightHandpos2());
        boldDClass.SetLeftHandAngle1(dClass.GetLeftHandAngle1());
        boldDClass.SetLeftHandAngle2(dClass.GetLeftHandAngle2());
        boldDClass.SetLeftHandPos1(dClass.GetLeftHandpos1());
        boldDClass.SetLeftHandPos2(dClass.GetLeftHandpos2());

        daaseClass = new PicturePhonemeClass(daase);
        daaseClass.SetImageName("daase");
        daaseClass.SetAssignment("Hvad er den første lyd i ordet");
        daaseClass.SetAssignmentLetter("d");
        daaseClass.SetNoOfPos(2);
        daaseClass.SetEnableLeftHand(true);
        daaseClass.SetEnableRightHand(true);
        daaseClass.SetPos1ReadyToHit(true);
        daaseClass.SetPos2ReadyToHit(true);
        daaseClass.SetRightHandAngle1(dClass.GetRightHandAngle1());
        daaseClass.SetRightHandAngle2(dClass.GetRightHandAngle2());
        daaseClass.SetRightHandPos1(dClass.GetRightHandpos1());
        daaseClass.SetRightHandPos2(dClass.GetRightHandpos2());
        daaseClass.SetLeftHandAngle1(dClass.GetLeftHandAngle1());
        daaseClass.SetLeftHandAngle2(dClass.GetLeftHandAngle2());
        daaseClass.SetLeftHandPos1(dClass.GetLeftHandpos1());
        daaseClass.SetLeftHandPos2(dClass.GetLeftHandpos2());

        drageClass = new PicturePhonemeClass(drage);
        drageClass.SetImageName("drage");
        drageClass.SetAssignment("Hvad er den første lyd i ordet");
        drageClass.SetAssignmentLetter("d");
        drageClass.SetNoOfPos(2);
        drageClass.SetEnableLeftHand(true);
        drageClass.SetEnableRightHand(true);
        drageClass.SetPos1ReadyToHit(true);
        drageClass.SetPos2ReadyToHit(true);
        drageClass.SetRightHandAngle1(dClass.GetRightHandAngle1());
        drageClass.SetRightHandAngle2(dClass.GetRightHandAngle2());
        drageClass.SetRightHandPos1(dClass.GetRightHandpos1());
        drageClass.SetRightHandPos2(dClass.GetRightHandpos2());
        drageClass.SetLeftHandAngle1(dClass.GetLeftHandAngle1());
        drageClass.SetLeftHandAngle2(dClass.GetLeftHandAngle2());
        drageClass.SetLeftHandPos1(dClass.GetLeftHandpos1());
        drageClass.SetLeftHandPos2(dClass.GetLeftHandpos2());

        // D lyd 2 blød 

        badClass = new PicturePhonemeClass(bad);
        badClass.SetImageName("bad");
        badClass.SetAssignment("Hvad er den sidste lyd i ordet");
        badClass.SetAssignmentLetter("d");
        badClass.SetNoOfPos(3);
        badClass.SetEnableLeftHand(true);
        badClass.SetEnableRightHand(true);
        badClass.SetPos1ReadyToHit(true);
        badClass.SetPos2ReadyToHit(true);
        badClass.SetPos3ReadyToHit(true);
        badClass.SetRightHandAngle1(dClass.GetRightHandAngle3());
        badClass.SetRightHandAngle2(dClass.GetRightHandAngle4());
        badClass.SetRightHandAngle3(dClass.GetRightHandAngle5());
        badClass.SetRightHandPos1(dClass.GetRightHandpos3());
        badClass.SetRightHandPos2(dClass.GetRightHandpos4());
        badClass.SetRightHandPos3(dClass.GetRightHandpos5());
        badClass.SetLeftHandAngle1(dClass.GetLeftHandAngle3());
        badClass.SetLeftHandAngle2(dClass.GetLeftHandAngle4());
        badClass.SetLeftHandAngle3(dClass.GetLeftHandAngle5());
        badClass.SetLeftHandPos1(dClass.GetLeftHandpos3());
        badClass.SetLeftHandPos2(dClass.GetLeftHandpos4());
        badClass.SetLeftHandPos3(dClass.GetLeftHandpos5());

        baadClass = new PicturePhonemeClass(baad);
        baadClass.SetImageName("baad");
        baadClass.SetAssignment("Hvad er den sidste lyd i ordet");
        baadClass.SetAssignmentLetter("d");
        baadClass.SetNoOfPos(3);
        baadClass.SetEnableLeftHand(true);
        baadClass.SetEnableRightHand(true);
        baadClass.SetPos1ReadyToHit(true);
        baadClass.SetPos2ReadyToHit(true);
        baadClass.SetPos3ReadyToHit(true);
        baadClass.SetRightHandAngle1(dClass.GetRightHandAngle3());
        baadClass.SetRightHandAngle2(dClass.GetRightHandAngle4());
        baadClass.SetRightHandAngle3(dClass.GetRightHandAngle5());
        baadClass.SetRightHandPos1(dClass.GetRightHandpos3());
        baadClass.SetRightHandPos2(dClass.GetRightHandpos4());
        baadClass.SetRightHandPos3(dClass.GetRightHandpos5());
        baadClass.SetLeftHandAngle1(dClass.GetLeftHandAngle3());
        baadClass.SetLeftHandAngle2(dClass.GetLeftHandAngle4());
        baadClass.SetLeftHandAngle3(dClass.GetLeftHandAngle5());
        baadClass.SetLeftHandPos1(dClass.GetLeftHandpos3());
        baadClass.SetLeftHandPos2(dClass.GetLeftHandpos4());
        baadClass.SetLeftHandPos3(dClass.GetLeftHandpos5());

        gladClass = new PicturePhonemeClass(glad);
        gladClass.SetImageName("glad");
        gladClass.SetAssignment("Hvad er den sidste lyd i ordet");
        gladClass.SetAssignmentLetter("d");
        gladClass.SetNoOfPos(3);
        gladClass.SetEnableLeftHand(true);
        gladClass.SetEnableRightHand(true);
        gladClass.SetPos1ReadyToHit(true);
        gladClass.SetPos2ReadyToHit(true);
        gladClass.SetPos3ReadyToHit(true);
        gladClass.SetRightHandAngle1(dClass.GetRightHandAngle3());
        gladClass.SetRightHandAngle2(dClass.GetRightHandAngle4());
        gladClass.SetRightHandAngle3(dClass.GetRightHandAngle5());
        gladClass.SetRightHandPos1(dClass.GetRightHandpos3());
        gladClass.SetRightHandPos2(dClass.GetRightHandpos4());
        gladClass.SetRightHandPos3(dClass.GetRightHandpos5());
        gladClass.SetLeftHandAngle1(dClass.GetLeftHandAngle3());
        gladClass.SetLeftHandAngle2(dClass.GetLeftHandAngle4());
        gladClass.SetLeftHandAngle3(dClass.GetLeftHandAngle5());
        gladClass.SetLeftHandPos1(dClass.GetLeftHandpos3());
        gladClass.SetLeftHandPos2(dClass.GetLeftHandpos4());
        gladClass.SetLeftHandPos3(dClass.GetLeftHandpos5());

        kaedeClass = new PicturePhonemeClass(kaede);
        kaedeClass.SetImageName("kaede");
        kaedeClass.SetAssignment("Hvad er den sidste konsonant i ordet");
        kaedeClass.SetAssignmentLetter("d");
        kaedeClass.SetNoOfPos(3);
        kaedeClass.SetEnableLeftHand(true);
        kaedeClass.SetEnableRightHand(true);
        kaedeClass.SetPos1ReadyToHit(true);
        kaedeClass.SetPos2ReadyToHit(true);
        kaedeClass.SetPos3ReadyToHit(true);
        kaedeClass.SetRightHandAngle1(dClass.GetRightHandAngle3());
        kaedeClass.SetRightHandAngle2(dClass.GetRightHandAngle4());
        kaedeClass.SetRightHandAngle3(dClass.GetRightHandAngle5());
        kaedeClass.SetRightHandPos1(dClass.GetRightHandpos3());
        kaedeClass.SetRightHandPos2(dClass.GetRightHandpos4());
        kaedeClass.SetRightHandPos3(dClass.GetRightHandpos5());
        kaedeClass.SetLeftHandAngle1(dClass.GetLeftHandAngle3());
        kaedeClass.SetLeftHandAngle2(dClass.GetLeftHandAngle4());
        kaedeClass.SetLeftHandAngle3(dClass.GetLeftHandAngle5());
        kaedeClass.SetLeftHandPos1(dClass.GetLeftHandpos3());
        kaedeClass.SetLeftHandPos2(dClass.GetLeftHandpos4());
        kaedeClass.SetLeftHandPos3(dClass.GetLeftHandpos5());

        ladeClass = new PicturePhonemeClass(lade);
        ladeClass.SetImageName("lade");
        ladeClass.SetAssignment("Hvad er den sidste konsonant i ordet");
        ladeClass.SetAssignmentLetter("d");
        ladeClass.SetNoOfPos(3);
        ladeClass.SetEnableLeftHand(true);
        ladeClass.SetEnableRightHand(true);
        ladeClass.SetPos1ReadyToHit(true);
        ladeClass.SetPos2ReadyToHit(true);
        ladeClass.SetRightHandAngle1(dClass.GetRightHandAngle3());
        ladeClass.SetRightHandAngle2(dClass.GetRightHandAngle4());
        ladeClass.SetRightHandAngle3(dClass.GetRightHandAngle5());
        ladeClass.SetRightHandPos1(dClass.GetRightHandpos3());
        ladeClass.SetRightHandPos2(dClass.GetRightHandpos4());
        ladeClass.SetRightHandPos3(dClass.GetRightHandpos5());
        ladeClass.SetLeftHandAngle1(dClass.GetLeftHandAngle3());
        ladeClass.SetLeftHandAngle2(dClass.GetLeftHandAngle4());
        ladeClass.SetLeftHandAngle3(dClass.GetLeftHandAngle5());
        ladeClass.SetLeftHandPos1(dClass.GetLeftHandpos3());
        ladeClass.SetLeftHandPos2(dClass.GetLeftHandpos4());
        ladeClass.SetLeftHandPos3(dClass.GetLeftHandpos5());

        // e lyd et
        feClass = new PicturePhonemeClass(fe);
        feClass.SetImageName("fe");
        feClass.SetAssignment("Hvad er den sidste lyd i ordet");
        feClass.SetAssignmentLetter("e");
        feClass.SetNoOfPos(1);
        feClass.SetEnableRightHand(true);
        feClass.SetEnableLeftHand(true);
        feClass.SetPos1ReadyToHit(true);
        feClass.SetLeftHandPos1(eClass.GetLeftHandpos1());
        feClass.SetLeftHandAngle1(eClass.GetLeftHandAngle1());
        feClass.SetRightHandPos1(eClass.GetRightHandpos1());
        feClass.SetRightHandAngle1(eClass.GetRightHandAngle1());

        // e lyd to 
        femClass = new PicturePhonemeClass(fem);
        femClass.SetImageName("fem");
        femClass.SetAssignment("Hvad er den midterste lyd");
        femClass.SetAssignmentLetter("e");
        femClass.SetNoOfPos(1);
        femClass.SetEnableRightHand(true);
        femClass.SetEnableLeftHand(true);
        femClass.SetPos1ReadyToHit(true);
        femClass.SetLeftHandPos1(eClass.GetLeftHandpos2());
        femClass.SetLeftHandAngle1(eClass.GetLeftHandAngle2());
        femClass.SetRightHandPos1(eClass.GetRightHandpos2());
        femClass.SetRightHandAngle1(eClass.GetLeftHandAngle2());

        // e lyd to 
        vestClass = new PicturePhonemeClass(vest);
        vestClass.SetImageName("vest");
        vestClass.SetAssignment("Hvad er den første vokal lyd");
        vestClass.SetAssignmentLetter("e");
        vestClass.SetNoOfPos(1);
        vestClass.SetEnableRightHand(true);
        vestClass.SetEnableLeftHand(true);
        vestClass.SetPos1ReadyToHit(true);
        vestClass.SetLeftHandPos1(eClass.GetLeftHandpos2());
        vestClass.SetLeftHandAngle1(eClass.GetLeftHandAngle2());
        vestClass.SetRightHandPos1(eClass.GetRightHandpos2());
        vestClass.SetRightHandAngle1(eClass.GetLeftHandAngle2());

        // e lyd tre
        daaseClass = new PicturePhonemeClass(daase);
        daaseClass.SetImageName("daase");
        daaseClass.SetAssignment("Hvad er den sidste lyd");
        daaseClass.SetAssignmentLetter("e");
        daaseClass.SetNoOfPos(1);
        daaseClass.SetEnableRightHand(true);
        daaseClass.SetEnableLeftHand(true);
        daaseClass.SetPos1ReadyToHit(true);
        daaseClass.SetLeftHandPos1(eClass.GetLeftHandpos3());
        daaseClass.SetRightHandPos1(eClass.GetRightHandpos3());
        daaseClass.SetLeftHandAngle1(eClass.GetLeftHandAngle3());
        daaseClass.SetRightHandAngle1(eClass.GetRightHandAngle3());

        // e lyd tre
        aebleClass = new PicturePhonemeClass(aeble);
        aebleClass.SetImageName("æble");
        aebleClass.SetAssignment("Hvad er den sidste lyd");
        aebleClass.SetAssignmentLetter("e");
        aebleClass.SetNoOfPos(1);
        aebleClass.SetEnableRightHand(true);
        aebleClass.SetEnableLeftHand(true);
        aebleClass.SetPos1ReadyToHit(true);
        aebleClass.SetLeftHandPos1(eClass.GetLeftHandpos3());
        aebleClass.SetRightHandPos1(eClass.GetRightHandpos3());
        aebleClass.SetLeftHandAngle1(eClass.GetLeftHandAngle3());
        aebleClass.SetRightHandAngle1(eClass.GetRightHandAngle3());

        //g lyd 

        aegClass = new PicturePhonemeClass(aeg);
        aegClass.SetImageName("aeg");
        aegClass.SetAssignment("Hvad er den sidste lyd i ordet");
        aegClass.SetAssignmentLetter("g");
        aegClass.SetNoOfPos(3);
        aegClass.SetEnableLeftHand(true);
        aegClass.SetPos1ReadyToHit(true);
        aegClass.SetPos2ReadyToHit(true);
        aegClass.SetPos3ReadyToHit(true);
        aegClass.SetLeftHandAngle1(gClass.GetLeftHandAngle1());
        aegClass.SetLeftHandAngle2(gClass.GetLeftHandAngle2());
        aegClass.SetLeftHandAngle3(gClass.GetLeftHandAngle3());
        aegClass.SetLeftHandPos1(gClass.GetLeftHandpos1());
        aegClass.SetLeftHandPos2(gClass.GetLeftHandpos2());
        aegClass.SetLeftHandPos3(gClass.GetLeftHandpos3());

        gedClass = new PicturePhonemeClass(ged);
        gedClass.SetImageName("ged");
        gedClass.SetAssignment("Hvad er den først lyd i ordet");
        gedClass.SetAssignmentLetter("g");
        gedClass.SetNoOfPos(3);
        gedClass.SetEnableLeftHand(true);
        gedClass.SetPos1ReadyToHit(true);
        gedClass.SetPos2ReadyToHit(true);
        gedClass.SetPos3ReadyToHit(true);
        gedClass.SetLeftHandAngle1(gClass.GetLeftHandAngle1());
        gedClass.SetLeftHandAngle2(gClass.GetLeftHandAngle2());
        gedClass.SetLeftHandAngle3(gClass.GetLeftHandAngle3());
        gedClass.SetLeftHandPos1(gClass.GetLeftHandpos1());
        gedClass.SetLeftHandPos2(gClass.GetLeftHandpos2());
        gedClass.SetLeftHandPos3(gClass.GetLeftHandpos3());

        girafGClass = new PicturePhonemeClass(girafG);
        girafGClass.SetImageName("giraf");
        girafGClass.SetAssignment("Hvad er den første lyd i ordet");
        girafGClass.SetAssignmentLetter("g");
        girafGClass.SetNoOfPos(3);
        girafGClass.SetEnableLeftHand(true);
        girafGClass.SetPos1ReadyToHit(true);
        girafGClass.SetPos2ReadyToHit(true);
        girafGClass.SetPos3ReadyToHit(true);
        girafGClass.SetLeftHandAngle1(gClass.GetLeftHandAngle1());
        girafGClass.SetLeftHandAngle2(gClass.GetLeftHandAngle2());
        girafGClass.SetLeftHandAngle3(gClass.GetLeftHandAngle3());
        girafGClass.SetLeftHandPos1(gClass.GetLeftHandpos1());
        girafGClass.SetLeftHandPos2(gClass.GetLeftHandpos2());
        girafGClass.SetLeftHandPos3(gClass.GetLeftHandpos3());

        grisClass = new PicturePhonemeClass(gris);
        grisClass.SetImageName("gris");
        grisClass.SetAssignment("Hvad er den første lyd i ordet");
        grisClass.SetAssignmentLetter("g");
        grisClass.SetNoOfPos(3);
        grisClass.SetEnableLeftHand(true);
        grisClass.SetPos1ReadyToHit(true);
        grisClass.SetPos2ReadyToHit(true);
        grisClass.SetPos3ReadyToHit(true);
        grisClass.SetLeftHandAngle1(gClass.GetLeftHandAngle1());
        grisClass.SetLeftHandAngle2(gClass.GetLeftHandAngle2());
        grisClass.SetLeftHandAngle3(gClass.GetLeftHandAngle3());
        grisClass.SetLeftHandPos1(gClass.GetLeftHandpos1());
        grisClass.SetLeftHandPos2(gClass.GetLeftHandpos2());
        grisClass.SetLeftHandPos3(gClass.GetLeftHandpos3());

        vaegClass = new PicturePhonemeClass(vaeg);
        vaegClass.SetImageName("vaeg");
        vaegClass.SetAssignment("Hvad er den sidste lyd i ordet");
        vaegClass.SetAssignmentLetter("g");
        vaegClass.SetNoOfPos(3);
        vaegClass.SetEnableLeftHand(true);
        vaegClass.SetPos1ReadyToHit(true);
        vaegClass.SetPos2ReadyToHit(true);
        vaegClass.SetPos3ReadyToHit(true);
        vaegClass.SetLeftHandAngle1(gClass.GetLeftHandAngle1());
        vaegClass.SetLeftHandAngle2(gClass.GetLeftHandAngle2());
        vaegClass.SetLeftHandAngle3(gClass.GetLeftHandAngle3());
        vaegClass.SetLeftHandPos1(gClass.GetLeftHandpos1());
        vaegClass.SetLeftHandPos2(gClass.GetLeftHandpos2());
        vaegClass.SetLeftHandPos3(gClass.GetLeftHandpos3());


        //i lyd
        vinClass = new PicturePhonemeClass(vin);
        vinClass.SetImageName("vin");
        vinClass.SetAssignment("Hvad er den midterste lyd i ordet");
        vinClass.SetAssignmentLetter("i");
        vinClass.SetNoOfPos(3);
        vinClass.SetEnableLeftHand(true);
        vinClass.SetEnableRightHand(true);
        vinClass.SetPos1ReadyToHit(true);
        vinClass.SetPos2ReadyToHit(true);
        vinClass.SetPos3ReadyToHit(true);
        vinClass.SetLeftHandPos1(iClass.GetLeftHandpos1());
        vinClass.SetLeftHandPos2(iClass.GetLeftHandpos2());
        vinClass.SetLeftHandPos3(iClass.GetLeftHandpos3());
        vinClass.SetLeftHandAngle1(iClass.GetLeftHandAngle1());
        vinClass.SetLeftHandAngle2(iClass.GetLeftHandAngle2());
        vinClass.SetLeftHandAngle3(iClass.GetLeftHandAngle3());
        vinClass.SetRightHandPos1(iClass.GetRightHandpos1());
        vinClass.SetRightHandPos2(iClass.GetRightHandpos2());
        vinClass.SetRightHandPos3(iClass.GetRightHandpos3());
        vinClass.SetRightHandAngle1(iClass.GetRightHandAngle1());
        vinClass.SetRightHandAngle2(iClass.GetRightHandAngle2());
        vinClass.SetRightHandAngle3(iClass.GetRightHandAngle3());

        tiClass = new PicturePhonemeClass(ti);
        tiClass.SetImageName("ti");
        tiClass.SetAssignment("Hvad er den sidste lyd i ordet");
        tiClass.SetAssignmentLetter("i");
        tiClass.SetNoOfPos(3);
        tiClass.SetEnableRightHand(true);
        tiClass.SetEnableLeftHand(true);
        tiClass.SetPos1ReadyToHit(true);
        tiClass.SetPos2ReadyToHit(true);
        tiClass.SetPos3ReadyToHit(true);
        tiClass.SetLeftHandPos1(iClass.GetLeftHandpos1());
        tiClass.SetLeftHandPos2(iClass.GetLeftHandpos2());
        tiClass.SetLeftHandPos3(iClass.GetLeftHandpos3());
        tiClass.SetLeftHandAngle1(iClass.GetLeftHandAngle1());
        tiClass.SetLeftHandAngle2(iClass.GetLeftHandAngle2());
        tiClass.SetLeftHandAngle3(iClass.GetLeftHandAngle3());
        tiClass.SetRightHandPos1(iClass.GetRightHandpos1());
        tiClass.SetRightHandPos2(iClass.GetRightHandpos2());
        tiClass.SetRightHandPos3(iClass.GetRightHandpos3());
        tiClass.SetRightHandAngle1(iClass.GetRightHandAngle1());
        tiClass.SetRightHandAngle2(iClass.GetRightHandAngle2());
        tiClass.SetRightHandAngle3(iClass.GetRightHandAngle3());

        nisseClass = new PicturePhonemeClass(nisse);
        nisseClass.SetImageName("nisse");
        nisseClass.SetAssignment("Hvad er den første vokal lyd i ordet");
        nisseClass.SetAssignmentLetter("i");
        nisseClass.SetNoOfPos(3);
        nisseClass.SetEnableRightHand(true);
        nisseClass.SetEnableLeftHand(true);
        nisseClass.SetPos1ReadyToHit(true);
        nisseClass.SetPos2ReadyToHit(true);
        nisseClass.SetPos3ReadyToHit(true);
        nisseClass.SetLeftHandPos1(iClass.GetLeftHandpos1());
        nisseClass.SetLeftHandPos2(iClass.GetLeftHandpos2());
        nisseClass.SetLeftHandPos3(iClass.GetLeftHandpos3());
        nisseClass.SetLeftHandAngle1(iClass.GetLeftHandAngle1());
        nisseClass.SetLeftHandAngle2(iClass.GetLeftHandAngle2());
        nisseClass.SetLeftHandAngle3(iClass.GetLeftHandAngle3());
        nisseClass.SetRightHandPos1(iClass.GetRightHandpos1());
        nisseClass.SetRightHandPos2(iClass.GetRightHandpos2());
        nisseClass.SetRightHandPos3(iClass.GetRightHandpos3());
        nisseClass.SetRightHandAngle1(iClass.GetRightHandAngle1());
        nisseClass.SetRightHandAngle2(iClass.GetRightHandAngle2());
        nisseClass.SetRightHandAngle3(iClass.GetRightHandAngle3());

        isbjoernClass = new PicturePhonemeClass(isbjoern);
        isbjoernClass.SetImageName("isbjoern");
        isbjoernClass.SetAssignment("Hvad er den første lyd i ordet");
        isbjoernClass.SetAssignmentLetter("i");
        isbjoernClass.SetNoOfPos(3);
        isbjoernClass.SetEnableRightHand(true);
        isbjoernClass.SetEnableLeftHand(true);
        isbjoernClass.SetPos1ReadyToHit(true);
        isbjoernClass.SetPos2ReadyToHit(true);
        isbjoernClass.SetPos3ReadyToHit(true);
        isbjoernClass.SetLeftHandPos1(iClass.GetLeftHandpos1());
        isbjoernClass.SetLeftHandPos2(iClass.GetLeftHandpos2());
        isbjoernClass.SetLeftHandPos3(iClass.GetLeftHandpos3());
        isbjoernClass.SetLeftHandAngle1(iClass.GetLeftHandAngle1());
        isbjoernClass.SetLeftHandAngle2(iClass.GetLeftHandAngle2());
        isbjoernClass.SetLeftHandAngle3(iClass.GetLeftHandAngle3());
        isbjoernClass.SetRightHandPos1(iClass.GetRightHandpos1());
        isbjoernClass.SetRightHandPos2(iClass.GetRightHandpos2());
        isbjoernClass.SetRightHandPos3(iClass.GetRightHandpos3());
        isbjoernClass.SetRightHandAngle1(iClass.GetRightHandAngle1());
        isbjoernClass.SetRightHandAngle2(iClass.GetRightHandAngle2());
        isbjoernClass.SetRightHandAngle3(iClass.GetRightHandAngle3());

        igloClass = new PicturePhonemeClass(iglo);
        igloClass.SetImageName("iglo");
        igloClass.SetAssignment("Hvad er den første lyd i ordet");
        igloClass.SetAssignmentLetter("i");
        igloClass.SetNoOfPos(3);
        igloClass.SetEnableRightHand(true);
        igloClass.SetEnableLeftHand(true);
        igloClass.SetPos1ReadyToHit(true);
        igloClass.SetPos2ReadyToHit(true);
        igloClass.SetPos3ReadyToHit(true);
        igloClass.SetLeftHandPos1(iClass.GetLeftHandpos1());
        igloClass.SetLeftHandPos2(iClass.GetLeftHandpos2());
        igloClass.SetLeftHandPos3(iClass.GetLeftHandpos3());
        igloClass.SetLeftHandAngle1(iClass.GetLeftHandAngle1());
        igloClass.SetLeftHandAngle2(iClass.GetLeftHandAngle2());
        igloClass.SetLeftHandAngle3(iClass.GetLeftHandAngle3());
        igloClass.SetRightHandPos1(iClass.GetRightHandpos1());
        igloClass.SetRightHandPos2(iClass.GetRightHandpos2());
        igloClass.SetRightHandPos3(iClass.GetRightHandpos3());
        igloClass.SetRightHandAngle1(iClass.GetRightHandAngle1());
        igloClass.SetRightHandAngle2(iClass.GetRightHandAngle2());
        igloClass.SetRightHandAngle3(iClass.GetRightHandAngle3());

        girafIClass = new PicturePhonemeClass(girafI);
        girafIClass.SetImageName("giraf");
        girafIClass.SetAssignment("Hvad er den første vokal lyd i ordet");
        girafIClass.SetAssignmentLetter("i");
        girafIClass.SetNoOfPos(3);
        girafIClass.SetEnableRightHand(true);
        girafIClass.SetEnableLeftHand(true);
        girafIClass.SetPos1ReadyToHit(true);
        girafIClass.SetPos2ReadyToHit(true);
        girafIClass.SetPos3ReadyToHit(true);
        girafIClass.SetLeftHandPos1(iClass.GetLeftHandpos1());
        girafIClass.SetLeftHandPos2(iClass.GetLeftHandpos2());
        girafIClass.SetLeftHandPos3(iClass.GetLeftHandpos3());
        girafIClass.SetLeftHandAngle1(iClass.GetLeftHandAngle1());
        girafIClass.SetLeftHandAngle2(iClass.GetLeftHandAngle2());
        girafIClass.SetLeftHandAngle3(iClass.GetLeftHandAngle3());
        girafIClass.SetRightHandPos1(iClass.GetRightHandpos1());
        girafIClass.SetRightHandPos2(iClass.GetRightHandpos2());
        girafIClass.SetRightHandPos3(iClass.GetRightHandpos3());
        girafIClass.SetRightHandAngle1(iClass.GetRightHandAngle1());
        girafIClass.SetRightHandAngle2(iClass.GetRightHandAngle2());
        girafIClass.SetRightHandAngle3(iClass.GetRightHandAngle3());


        // k lyd 
        kageKClass = new PicturePhonemeClass(kageK);
        kageKClass.SetImageName("kage");
        kageKClass.SetAssignment("Hvad er den første lyd");
        kageKClass.SetAssignmentLetter("k");
        kageKClass.SetNoOfPos(2);
        kageKClass.SetEnableLeftHand(true);
        kageKClass.SetEnableRightHand(true);
        kageKClass.SetPos1ReadyToHit(true);
        kageKClass.SetPos2ReadyToHit(true);
        kageKClass.SetLeftHandPos1(kClass.GetLeftHandpos1());
        kageKClass.SetLeftHandPos2(kClass.GetLeftHandpos2());
        kageKClass.SetRightHandPos1(kClass.GetRightHandpos1());
        kageKClass.SetRightHandPos2(kClass.GetRightHandpos2());
        kageKClass.SetLeftHandAngle1(kClass.GetLeftHandAngle1());
        kageKClass.SetLeftHandAngle2(kClass.GetLeftHandAngle2());
        kageKClass.SetRightHandAngle1(kClass.GetRightHandAngle1());
        kageKClass.SetRightHandAngle2(kClass.GetRightHandAngle2());

        kopKClass = new PicturePhonemeClass(kopK);
        kopKClass.SetImageName("kop");
        kopKClass.SetAssignment("Hvad er den første lyd");
        kopKClass.SetAssignmentLetter("k");
        kopKClass.SetNoOfPos(2);
        kopKClass.SetEnableLeftHand(true);
        kopKClass.SetEnableRightHand(true);
        kopKClass.SetPos1ReadyToHit(true);
        kopKClass.SetPos2ReadyToHit(true);
        kopKClass.SetLeftHandPos1(kClass.GetLeftHandpos1());
        kopKClass.SetLeftHandPos2(kClass.GetLeftHandpos2());
        kopKClass.SetRightHandPos1(kClass.GetRightHandpos1());
        kopKClass.SetRightHandPos2(kClass.GetRightHandpos2());
        kopKClass.SetLeftHandAngle1(kClass.GetLeftHandAngle1());
        kopKClass.SetLeftHandAngle2(kClass.GetLeftHandAngle2());
        kopKClass.SetRightHandAngle1(kClass.GetRightHandAngle1());
        kopKClass.SetRightHandAngle2(kClass.GetRightHandAngle2());

        sokKClass = new PicturePhonemeClass(sokK);
        sokKClass.SetImageName("sok");
        sokKClass.SetAssignment("Hvad er den sidste lyd");
        sokKClass.SetAssignmentLetter("k");
        sokKClass.SetNoOfPos(2);
        sokKClass.SetEnableLeftHand(true);
        sokKClass.SetEnableRightHand(true);
        sokKClass.SetPos1ReadyToHit(true);
        sokKClass.SetPos2ReadyToHit(true);
        sokKClass.SetLeftHandPos1(kClass.GetLeftHandpos1());
        sokKClass.SetLeftHandPos2(kClass.GetLeftHandpos2());
        sokKClass.SetRightHandPos1(kClass.GetRightHandpos1());
        sokKClass.SetRightHandPos2(kClass.GetRightHandpos2());
        sokKClass.SetLeftHandAngle1(kClass.GetLeftHandAngle1());
        sokKClass.SetLeftHandAngle2(kClass.GetLeftHandAngle2());
        sokKClass.SetRightHandAngle1(kClass.GetRightHandAngle1());
        sokKClass.SetRightHandAngle2(kClass.GetRightHandAngle2());

        koKClass = new PicturePhonemeClass(koK);
        koKClass.SetImageName("ko");
        koKClass.SetAssignment("Hvad er den første lyd");
        koKClass.SetAssignmentLetter("k");
        koKClass.SetNoOfPos(2);
        koKClass.SetEnableLeftHand(true);
        koKClass.SetEnableRightHand(true);
        koKClass.SetPos1ReadyToHit(true);
        koKClass.SetPos2ReadyToHit(true);
        koKClass.SetLeftHandPos1(kClass.GetLeftHandpos1());
        koKClass.SetLeftHandPos2(kClass.GetLeftHandpos2());
        koKClass.SetRightHandPos1(kClass.GetRightHandpos1());
        koKClass.SetRightHandPos2(kClass.GetRightHandpos2());
        koKClass.SetLeftHandAngle1(kClass.GetLeftHandAngle1());
        koKClass.SetLeftHandAngle2(kClass.GetLeftHandAngle2());
        koKClass.SetRightHandAngle1(kClass.GetRightHandAngle1());
        koKClass.SetRightHandAngle2(kClass.GetRightHandAngle2());

        skoKClass = new PicturePhonemeClass(skoK);
        skoKClass.SetImageName("sko");
        skoKClass.SetAssignment("Hvad er den midterste lyd");
        skoKClass.SetAssignmentLetter("k");
        skoKClass.SetNoOfPos(2);
        skoKClass.SetEnableLeftHand(true);
        skoKClass.SetEnableRightHand(true);
        skoKClass.SetPos1ReadyToHit(true);
        skoKClass.SetPos2ReadyToHit(true);
        skoKClass.SetLeftHandPos1(kClass.GetLeftHandpos1());
        skoKClass.SetLeftHandPos2(kClass.GetLeftHandpos2());
        skoKClass.SetRightHandPos1(kClass.GetRightHandpos1());
        skoKClass.SetRightHandPos2(kClass.GetRightHandpos2());
        skoKClass.SetLeftHandAngle1(kClass.GetLeftHandAngle1());
        skoKClass.SetLeftHandAngle2(kClass.GetLeftHandAngle2());
        skoKClass.SetRightHandAngle1(kClass.GetRightHandAngle1());
        skoKClass.SetRightHandAngle2(kClass.GetRightHandAngle2());

        // l lyd et 
        laasClass = new PicturePhonemeClass(laas);
        laasClass.SetImageName("laas");
        laasClass.SetAssignment("Hvad er den første lyd");
        laasClass.SetAssignmentLetter("l");
        laasClass.SetNoOfPos(3);
        laasClass.SetEnableRightHand(true);
        laasClass.SetEnableLeftHand(true);
        laasClass.SetPos1ReadyToHit(true);
        laasClass.SetPos2ReadyToHit(true);
        laasClass.SetPos3ReadyToHit(true);
        laasClass.SetLeftHandPos1(lClass.GetLeftHandpos1());
        laasClass.SetLeftHandPos2(lClass.GetLeftHandpos2());
        laasClass.SetLeftHandPos3(lClass.GetLeftHandpos3());
        laasClass.SetRightHandPos1(lClass.GetRightHandpos1());
        laasClass.SetRightHandPos2(lClass.GetRightHandpos2());
        laasClass.SetRightHandPos3(lClass.GetRightHandpos3());
        laasClass.SetRightHandAngle1(lClass.GetRightHandAngle1());
        laasClass.SetRightHandAngle2(lClass.GetRightHandAngle2());
        laasClass.SetRightHandAngle3(lClass.GetRightHandAngle3());
        laasClass.SetLeftHandAngle1(lClass.GetLeftHandAngle1());
        laasClass.SetLeftHandAngle2(lClass.GetLeftHandAngle2());
        laasClass.SetLeftHandAngle3(lClass.GetLeftHandAngle3());

        // l lyd et 
        leClass = new PicturePhonemeClass(le);
        leClass.SetImageName("le");
        leClass.SetAssignment("Hvad er den første lyd");
        leClass.SetAssignmentLetter("l");
        leClass.SetNoOfPos(3);
        leClass.SetEnableRightHand(true);
        leClass.SetEnableLeftHand(true);
        leClass.SetPos1ReadyToHit(true);
        leClass.SetPos2ReadyToHit(true);
        leClass.SetPos3ReadyToHit(true);
        leClass.SetLeftHandPos1(lClass.GetLeftHandpos1());
        leClass.SetLeftHandPos2(lClass.GetLeftHandpos2());
        leClass.SetLeftHandPos3(lClass.GetLeftHandpos3());
        leClass.SetRightHandPos1(lClass.GetRightHandpos1());
        leClass.SetRightHandPos2(lClass.GetRightHandpos2());
        leClass.SetRightHandPos3(lClass.GetRightHandpos3());
        leClass.SetRightHandAngle1(lClass.GetRightHandAngle1());
        leClass.SetRightHandAngle2(lClass.GetRightHandAngle2());
        leClass.SetRightHandAngle3(lClass.GetRightHandAngle3());
        leClass.SetLeftHandAngle1(lClass.GetLeftHandAngle1());
        leClass.SetLeftHandAngle2(lClass.GetLeftHandAngle2());
        leClass.SetLeftHandAngle3(lClass.GetLeftHandAngle3());

        //m lyd 
        musClass = new PicturePhonemeClass(mus);
        musClass.SetImageName("mus");
        musClass.SetAssignment("Hvad er den første lyd");
        musClass.SetAssignmentLetter("m");
        musClass.SetNoOfPos(5);
        musClass.SetEnableRightHand(true);
        musClass.SetPos1ReadyToHit(true);
        musClass.SetPos2ReadyToHit(true);
        musClass.SetPos3ReadyToHit(true);
        musClass.SetPos4ReadyToHit(true);
        musClass.SetPos5ReadyToHit(true);

        musClass.SetRightHandPos1(mClass.GetRightHandpos1());
        musClass.SetRightHandPos2(mClass.GetRightHandpos2());
        musClass.SetRightHandPos3(mClass.GetRightHandpos3());
        musClass.SetRightHandPos4(mClass.GetRightHandpos4());
        musClass.SetRightHandPos5(mClass.GetRightHandpos5());

        musClass.SetRightHandAngle1(mClass.GetRightHandAngle1());
        musClass.SetRightHandAngle2(mClass.GetRightHandAngle2());
        musClass.SetRightHandAngle3(mClass.GetRightHandAngle3());
        musClass.SetRightHandAngle4(mClass.GetRightHandAngle4());
        musClass.SetRightHandAngle5(mClass.GetRightHandAngle5());

        murMClass = new PicturePhonemeClass(murM);
        musClass.SetImageName("mus");
        musClass.SetAssignment("Hvad er den første lyd");
        musClass.SetAssignmentLetter("m");
        musClass.SetNoOfPos(5);
        musClass.SetEnableRightHand(true);
        musClass.SetPos1ReadyToHit(true);
        musClass.SetPos2ReadyToHit(true);
        musClass.SetPos3ReadyToHit(true);
        musClass.SetPos4ReadyToHit(true);
        musClass.SetPos5ReadyToHit(true);

        musClass.SetRightHandPos1(mClass.GetRightHandpos1());
        musClass.SetRightHandPos2(mClass.GetRightHandpos2());
        musClass.SetRightHandPos3(mClass.GetRightHandpos3());
        musClass.SetRightHandPos4(mClass.GetRightHandpos4());
        musClass.SetRightHandPos5(mClass.GetRightHandpos5());

        musClass.SetRightHandAngle1(mClass.GetRightHandAngle1());
        musClass.SetRightHandAngle2(mClass.GetRightHandAngle2());
        musClass.SetRightHandAngle3(mClass.GetRightHandAngle3());
        musClass.SetRightHandAngle4(mClass.GetRightHandAngle4());
        musClass.SetRightHandAngle5(mClass.GetRightHandAngle5());

        femClass = new PicturePhonemeClass(fem);
        femClass.SetImageName("fem");
        femClass.SetAssignment("Hvad er den sidste lyd");
        femClass.SetAssignmentLetter("m");
        femClass.SetNoOfPos(5);
        femClass.SetEnableRightHand(true);
        femClass.SetPos1ReadyToHit(true);
        femClass.SetPos2ReadyToHit(true);
        femClass.SetPos3ReadyToHit(true);
        femClass.SetPos4ReadyToHit(true);
        femClass.SetPos5ReadyToHit(true);

        femClass.SetRightHandPos1(mClass.GetRightHandpos1());
        femClass.SetRightHandPos2(mClass.GetRightHandpos2());
        femClass.SetRightHandPos3(mClass.GetRightHandpos3());
        femClass.SetRightHandPos4(mClass.GetRightHandpos4());
        femClass.SetRightHandPos5(mClass.GetRightHandpos5());

        femClass.SetRightHandAngle1(mClass.GetRightHandAngle1());
        femClass.SetRightHandAngle2(mClass.GetRightHandAngle2());
        femClass.SetRightHandAngle3(mClass.GetRightHandAngle3());
        femClass.SetRightHandAngle4(mClass.GetRightHandAngle4());
        femClass.SetRightHandAngle5(mClass.GetRightHandAngle5());

        kamClass = new PicturePhonemeClass(kam);
        kamClass.SetImageName("kam");
        kamClass.SetAssignment("Hvad er den sidste lyd");
        kamClass.SetAssignmentLetter("m");
        kamClass.SetNoOfPos(5);
        kamClass.SetEnableRightHand(true);
        kamClass.SetPos1ReadyToHit(true);
        kamClass.SetPos2ReadyToHit(true);
        kamClass.SetPos3ReadyToHit(true);
        kamClass.SetPos4ReadyToHit(true);
        kamClass.SetPos5ReadyToHit(true);

        kamClass.SetRightHandPos1(mClass.GetRightHandpos1());
        kamClass.SetRightHandPos2(mClass.GetRightHandpos2());
        kamClass.SetRightHandPos3(mClass.GetRightHandpos3());
        kamClass.SetRightHandPos4(mClass.GetRightHandpos4());
        kamClass.SetRightHandPos5(mClass.GetRightHandpos5());

        kamClass.SetRightHandAngle1(mClass.GetRightHandAngle1());
        kamClass.SetRightHandAngle2(mClass.GetRightHandAngle2());
        kamClass.SetRightHandAngle3(mClass.GetRightHandAngle3());
        kamClass.SetRightHandAngle4(mClass.GetRightHandAngle4());
        kamClass.SetRightHandAngle5(mClass.GetRightHandAngle5());

        kamelClass = new PicturePhonemeClass(kamel);
        kamelClass.SetImageName("kam");
        kamelClass.SetAssignment("Hvad er den midterste lyd");
        kamelClass.SetAssignmentLetter("m");
        kamelClass.SetNoOfPos(5);
        kamelClass.SetEnableRightHand(true);
        kamelClass.SetPos1ReadyToHit(true);
        kamelClass.SetPos2ReadyToHit(true);
        kamelClass.SetPos3ReadyToHit(true);
        kamelClass.SetPos4ReadyToHit(true);
        kamelClass.SetPos5ReadyToHit(true);

        kamelClass.SetRightHandPos1(mClass.GetRightHandpos1());
        kamelClass.SetRightHandPos2(mClass.GetRightHandpos2());
        kamelClass.SetRightHandPos3(mClass.GetRightHandpos3());
        kamelClass.SetRightHandPos4(mClass.GetRightHandpos4());
        kamelClass.SetRightHandPos5(mClass.GetRightHandpos5());

        kamelClass.SetRightHandAngle1(mClass.GetRightHandAngle1());
        kamelClass.SetRightHandAngle2(mClass.GetRightHandAngle2());
        kamelClass.SetRightHandAngle3(mClass.GetRightHandAngle3());
        kamelClass.SetRightHandAngle4(mClass.GetRightHandAngle4());
        kamelClass.SetRightHandAngle5(mClass.GetRightHandAngle5());

        //n lyd
        haneClass = new PicturePhonemeClass(hane);
        haneClass.SetImageName("hane");
        haneClass.SetAssignment("Hvad er den sidste konsonant lyd");
        haneClass.SetAssignmentLetter("n");
        haneClass.SetNoOfPos(1);
        haneClass.SetEnableRightHand(true);
        haneClass.SetPos1ReadyToHit(true);
        haneClass.SetRightHandPos1(nClass.GetRightHandpos1());
        haneClass.SetRightHandAngle1(nClass.GetRightHandAngle1());

        delfinClass = new PicturePhonemeClass(delfin);
        delfinClass.SetImageName("delfin");
        delfinClass.SetAssignment("Hvad er den sidste lyd");
        delfinClass.SetAssignmentLetter("n");
        delfinClass.SetNoOfPos(1);
        delfinClass.SetEnableRightHand(true);
        delfinClass.SetPos1ReadyToHit(true);
        delfinClass.SetRightHandPos1(nClass.GetRightHandpos1());
        delfinClass.SetRightHandAngle1(nClass.GetRightHandAngle1());

        kaneClass = new PicturePhonemeClass(kane);
        kaneClass.SetImageName("kane");
        kaneClass.SetAssignment("Hvad er den sidste konsonant lyd");
        kaneClass.SetAssignmentLetter("n");
        kaneClass.SetNoOfPos(1);
        kaneClass.SetEnableRightHand(true);
        kaneClass.SetPos1ReadyToHit(true);
        kaneClass.SetRightHandPos1(nClass.GetRightHandpos1());
        kaneClass.SetRightHandAngle1(nClass.GetRightHandAngle1());

        naaleClass = new PicturePhonemeClass(naale);
        naaleClass.SetImageName("naale");
        naaleClass.SetAssignment("Hvad er den første lyd");
        naaleClass.SetAssignmentLetter("n");
        naaleClass.SetNoOfPos(1);
        naaleClass.SetEnableRightHand(true);
        naaleClass.SetPos1ReadyToHit(true);
        naaleClass.SetRightHandPos1(nClass.GetRightHandpos1());
        naaleClass.SetRightHandAngle1(nClass.GetRightHandAngle1());

        netClass = new PicturePhonemeClass(net);
        netClass.SetImageName("net");
        netClass.SetAssignment("Hvad er den første lyd");
        netClass.SetAssignmentLetter("n");
        netClass.SetNoOfPos(1);
        netClass.SetEnableRightHand(true);
        netClass.SetPos1ReadyToHit(true);
        netClass.SetRightHandPos1(nClass.GetRightHandpos1());
        netClass.SetRightHandAngle1(nClass.GetRightHandAngle1());

        //o lyd et 
        ormClass = new PicturePhonemeClass(orm);
        ormClass.SetImageName("orm");
        ormClass.SetAssignment("Hvad er den første lyd");
        ormClass.SetAssignmentLetter("o");
        ormClass.SetNoOfPos(3);
        ormClass.SetEnableLeftHand(true);
        ormClass.SetEnableRightHand(true);
        ormClass.SetPos1ReadyToHit(true);
        ormClass.SetPos2ReadyToHit(true);
        ormClass.SetPos3ReadyToHit(true);
        ormClass.SetLeftHandPos1(oClass.GetLeftHandpos1());
        ormClass.SetLeftHandPos2(oClass.GetLeftHandpos2());
        ormClass.SetLeftHandPos3(oClass.GetLeftHandpos3());
        ormClass.SetRightHandPos1(oClass.GetRightHandpos1());
        ormClass.SetRightHandPos2(oClass.GetRightHandpos2());
        ormClass.SetRightHandPos3(oClass.GetRightHandpos3());
        ormClass.SetLeftHandAngle1(oClass.GetLeftHandAngle1());
        ormClass.SetLeftHandAngle2(oClass.GetLeftHandAngle2());
        ormClass.SetLeftHandAngle3(oClass.GetLeftHandAngle3());
        ormClass.SetRightHandAngle1(oClass.GetRightHandAngle1());
        ormClass.SetRightHandAngle2(oClass.GetRightHandAngle2());
        ormClass.SetRightHandAngle3(oClass.GetRightHandAngle3());

        skoOClass = new PicturePhonemeClass(skoO);
        skoOClass.SetImageName("sko");
        skoOClass.SetAssignment("Hvad er den sidste lyd");
        skoOClass.SetAssignmentLetter("o");
        skoOClass.SetNoOfPos(3);
        skoOClass.SetEnableLeftHand(true);
        skoOClass.SetEnableRightHand(true);
        skoOClass.SetPos1ReadyToHit(true);
        skoOClass.SetPos2ReadyToHit(true);
        skoOClass.SetPos3ReadyToHit(true);
        skoOClass.SetLeftHandPos1(oClass.GetLeftHandpos1());
        skoOClass.SetLeftHandPos2(oClass.GetLeftHandpos2());
        skoOClass.SetLeftHandPos3(oClass.GetLeftHandpos3());
        skoOClass.SetRightHandPos1(oClass.GetRightHandpos1());
        skoOClass.SetRightHandPos2(oClass.GetRightHandpos2());
        skoOClass.SetRightHandPos3(oClass.GetRightHandpos3());
        skoOClass.SetLeftHandAngle1(oClass.GetLeftHandAngle1());
        skoOClass.SetLeftHandAngle2(oClass.GetLeftHandAngle2());
        skoOClass.SetLeftHandAngle3(oClass.GetLeftHandAngle3());
        skoOClass.SetRightHandAngle1(oClass.GetRightHandAngle1());
        skoOClass.SetRightHandAngle2(oClass.GetRightHandAngle2());
        skoOClass.SetRightHandAngle3(oClass.GetRightHandAngle3());

        koOClass = new PicturePhonemeClass(koO);
        koOClass.SetImageName("ko");
        koOClass.SetAssignment("Hvad er den sidste lyd");
        koOClass.SetAssignmentLetter("o");
        koOClass.SetNoOfPos(3);
        koOClass.SetEnableLeftHand(true);
        koOClass.SetEnableRightHand(true);
        koOClass.SetPos1ReadyToHit(true);
        koOClass.SetPos2ReadyToHit(true);
        koOClass.SetPos3ReadyToHit(true);
        koOClass.SetLeftHandPos1(oClass.GetLeftHandpos1());
        koOClass.SetLeftHandPos2(oClass.GetLeftHandpos2());
        koOClass.SetLeftHandPos3(oClass.GetLeftHandpos3());
        koOClass.SetRightHandPos1(oClass.GetRightHandpos1());
        koOClass.SetRightHandPos2(oClass.GetRightHandpos2());
        koOClass.SetRightHandPos3(oClass.GetRightHandpos3());
        koOClass.SetLeftHandAngle1(oClass.GetLeftHandAngle1());
        koOClass.SetLeftHandAngle2(oClass.GetLeftHandAngle2());
        koOClass.SetLeftHandAngle3(oClass.GetLeftHandAngle3());
        koOClass.SetRightHandAngle1(oClass.GetRightHandAngle1());
        koOClass.SetRightHandAngle2(oClass.GetRightHandAngle2());
        koOClass.SetRightHandAngle3(oClass.GetRightHandAngle3());

        solClass = new PicturePhonemeClass(sol);
        solClass.SetImageName("sol");
        solClass.SetAssignment("Hvad er den midterste lyd");
        solClass.SetAssignmentLetter("o");
        solClass.SetNoOfPos(3);
        solClass.SetEnableLeftHand(true);
        solClass.SetEnableRightHand(true);
        solClass.SetPos1ReadyToHit(true);
        solClass.SetPos2ReadyToHit(true);
        solClass.SetPos3ReadyToHit(true);
        solClass.SetLeftHandPos1(oClass.GetLeftHandpos1());
        solClass.SetLeftHandPos2(oClass.GetLeftHandpos2());
        solClass.SetLeftHandPos3(oClass.GetLeftHandpos3());
        solClass.SetRightHandPos1(oClass.GetRightHandpos1());
        solClass.SetRightHandPos2(oClass.GetRightHandpos2());
        solClass.SetRightHandPos3(oClass.GetRightHandpos3());
        solClass.SetLeftHandAngle1(oClass.GetLeftHandAngle1());
        solClass.SetLeftHandAngle2(oClass.GetLeftHandAngle2());
        solClass.SetLeftHandAngle3(oClass.GetLeftHandAngle3());
        solClass.SetRightHandAngle1(oClass.GetRightHandAngle1());
        solClass.SetRightHandAngle2(oClass.GetRightHandAngle2());
        solClass.SetRightHandAngle3(oClass.GetRightHandAngle3());

        toClass = new PicturePhonemeClass(to);
        toClass.SetImageName("to");
        toClass.SetAssignment("Hvad er den sidste lyd");
        toClass.SetAssignmentLetter("o");
        toClass.SetNoOfPos(3);
        toClass.SetEnableLeftHand(true);
        toClass.SetEnableRightHand(true);
        toClass.SetPos1ReadyToHit(true);
        toClass.SetPos2ReadyToHit(true);
        toClass.SetPos3ReadyToHit(true);
        toClass.SetLeftHandPos1(oClass.GetLeftHandpos1());
        toClass.SetLeftHandPos2(oClass.GetLeftHandpos2());
        toClass.SetLeftHandPos3(oClass.GetLeftHandpos3());
        toClass.SetRightHandPos1(oClass.GetRightHandpos1());
        toClass.SetRightHandPos2(oClass.GetRightHandpos2());
        toClass.SetRightHandPos3(oClass.GetRightHandpos3());
        toClass.SetLeftHandAngle1(oClass.GetLeftHandAngle1());
        toClass.SetLeftHandAngle2(oClass.GetLeftHandAngle2());
        toClass.SetLeftHandAngle3(oClass.GetLeftHandAngle3());
        toClass.SetRightHandAngle1(oClass.GetRightHandAngle1());
        toClass.SetRightHandAngle2(oClass.GetRightHandAngle2());
        toClass.SetRightHandAngle3(oClass.GetRightHandAngle3());

        kanoClass = new PicturePhonemeClass(kano);
        kanoClass.SetImageName("kano");
        kanoClass.SetAssignment("Hvad er den sidste lyd");
        kanoClass.SetAssignmentLetter("o");
        kanoClass.SetNoOfPos(3);
        kanoClass.SetEnableLeftHand(true);
        kanoClass.SetEnableRightHand(true);
        kanoClass.SetPos1ReadyToHit(true);
        kanoClass.SetPos2ReadyToHit(true);
        kanoClass.SetPos3ReadyToHit(true);
        kanoClass.SetLeftHandPos1(oClass.GetLeftHandpos1());
        kanoClass.SetLeftHandPos2(oClass.GetLeftHandpos2());
        kanoClass.SetLeftHandPos3(oClass.GetLeftHandpos3());
        kanoClass.SetRightHandPos1(oClass.GetRightHandpos1());
        kanoClass.SetRightHandPos2(oClass.GetRightHandpos2());
        kanoClass.SetRightHandPos3(oClass.GetRightHandpos3());
        kanoClass.SetLeftHandAngle1(oClass.GetLeftHandAngle1());
        kanoClass.SetLeftHandAngle2(oClass.GetLeftHandAngle2());
        kanoClass.SetLeftHandAngle3(oClass.GetLeftHandAngle3());
        kanoClass.SetRightHandAngle1(oClass.GetRightHandAngle1());
        kanoClass.SetRightHandAngle2(oClass.GetRightHandAngle2());
        kanoClass.SetRightHandAngle3(oClass.GetRightHandAngle3());


        //o lyd to
        stopClass = new PicturePhonemeClass(stop);
        stopClass.SetImageName("stop");
        stopClass.SetAssignment("Hvad er den første vokal lyd");
        stopClass.SetAssignmentLetter("o");
        stopClass.SetNoOfPos(1);
        stopClass.SetEnableLeftHand(true);
        stopClass.SetEnableRightHand(true);
        stopClass.SetPos1ReadyToHit(true);
        stopClass.SetLeftHandPos1(oClass.GetLeftHandpos4());
        stopClass.SetRightHandPos1(oClass.GetRightHandpos4());
        stopClass.SetLeftHandAngle1(oClass.GetLeftHandAngle4());
        stopClass.SetRightHandAngle1(oClass.GetRightHandAngle4());

        kopOClass = new PicturePhonemeClass(kopO);
        kopOClass.SetImageName("kop");
        kopOClass.SetAssignment("Hvad er den midterste lyd");
        kopOClass.SetAssignmentLetter("o");
        kopOClass.SetNoOfPos(1);
        kopOClass.SetEnableLeftHand(true);
        kopOClass.SetEnableRightHand(true);
        kopOClass.SetPos1ReadyToHit(true);
        kopOClass.SetLeftHandPos1(oClass.GetLeftHandpos4());
        kopOClass.SetRightHandPos1(oClass.GetRightHandpos4());
        kopOClass.SetLeftHandAngle1(oClass.GetLeftHandAngle4());
        kopOClass.SetRightHandAngle1(oClass.GetRightHandAngle4());

        sokOClass = new PicturePhonemeClass(sokO);
        sokOClass.SetImageName("sok");
        sokOClass.SetAssignment("Hvad er den midterste lyd");
        sokOClass.SetAssignmentLetter("o");
        sokOClass.SetNoOfPos(1);
        sokOClass.SetEnableLeftHand(true);
        sokOClass.SetEnableRightHand(true);
        sokOClass.SetPos1ReadyToHit(true);
        sokOClass.SetLeftHandPos1(oClass.GetLeftHandpos4());
        sokOClass.SetRightHandPos1(oClass.GetRightHandpos4());
        sokOClass.SetLeftHandAngle1(oClass.GetLeftHandAngle4());
        sokOClass.SetRightHandAngle1(oClass.GetRightHandAngle4());

        ostClass = new PicturePhonemeClass(ost);
        ostClass.SetImageName("ost");
        ostClass.SetAssignment("Hvad er den første lyd");
        ostClass.SetAssignmentLetter("o");
        ostClass.SetNoOfPos(1);
        ostClass.SetEnableLeftHand(true);
        ostClass.SetEnableRightHand(true);
        ostClass.SetPos1ReadyToHit(true);
        ostClass.SetLeftHandPos1(oClass.GetLeftHandpos4());
        ostClass.SetRightHandPos1(oClass.GetRightHandpos4());
        ostClass.SetLeftHandAngle1(oClass.GetLeftHandAngle4());
        ostClass.SetRightHandAngle1(oClass.GetRightHandAngle4());

        otteClass = new PicturePhonemeClass(otte);
        otteClass.SetImageName("otte");
        otteClass.SetAssignment("Hvad er den første lyd");
        otteClass.SetAssignmentLetter("o");
        otteClass.SetNoOfPos(1);
        otteClass.SetEnableLeftHand(true);
        otteClass.SetEnableRightHand(true);
        otteClass.SetPos1ReadyToHit(true);
        otteClass.SetLeftHandPos1(oClass.GetLeftHandpos4());
        otteClass.SetRightHandPos1(oClass.GetRightHandpos4());
        otteClass.SetLeftHandAngle1(oClass.GetLeftHandAngle4());
        otteClass.SetRightHandAngle1(oClass.GetRightHandAngle4());

        boldOClass = new PicturePhonemeClass(boldD);
        boldOClass.SetImageName("bold");
        boldOClass.SetAssignment("Hvad er den første vokal lyd");
        boldOClass.SetAssignmentLetter("o");
        boldOClass.SetNoOfPos(1);
        boldOClass.SetEnableLeftHand(true);
        boldOClass.SetEnableRightHand(true);
        boldOClass.SetPos1ReadyToHit(true);
        boldOClass.SetLeftHandPos1(oClass.GetLeftHandpos4());
        boldOClass.SetRightHandPos1(oClass.GetRightHandpos4());
        boldOClass.SetLeftHandAngle1(oClass.GetLeftHandAngle4());
        boldOClass.SetRightHandAngle1(oClass.GetRightHandAngle4());

        // r lyd 1 

        girafRClass = new PicturePhonemeClass(girafR);
        girafRClass.SetImageName("giraf");
        girafRClass.SetAssignment("Hvad er den midterste lyd");
        girafRClass.SetAssignmentLetter("r");
        girafRClass.SetNoOfPos(2);
        girafRClass.SetEnableLeftHand(true);
        girafRClass.SetEnableRightHand(true);
        girafRClass.SetPos1ReadyToHit(true);
        girafRClass.SetPos2ReadyToHit(true);
        girafRClass.SetLeftHandPos1(rClass.GetLeftHandpos1());
        girafRClass.SetLeftHandPos2(rClass.GetLeftHandpos2());
        girafRClass.SetRightHandPos1(rClass.GetRightHandpos1());
        girafRClass.SetRightHandPos2(rClass.GetRightHandpos2());
        girafRClass.SetLeftHandAngle1(rClass.GetLeftHandAngle1());
        girafRClass.SetLeftHandAngle2(rClass.GetLeftHandAngle2());
        girafRClass.SetRightHandAngle1(rClass.GetRightHandAngle1());
        girafRClass.SetRightHandAngle2(rClass.GetRightHandAngle2());

        hareRClass = new PicturePhonemeClass(hareR);
        hareRClass.SetImageName("hare");
        hareRClass.SetAssignment("Hvad er den sidste konsonant lyd");
        hareRClass.SetAssignmentLetter("r");
        hareRClass.SetNoOfPos(2);
        hareRClass.SetEnableLeftHand(true);
        hareRClass.SetEnableRightHand(true);
        hareRClass.SetPos1ReadyToHit(true);
        hareRClass.SetPos2ReadyToHit(true);
        hareRClass.SetLeftHandPos1(rClass.GetLeftHandpos1());
        hareRClass.SetLeftHandPos2(rClass.GetLeftHandpos2());
        hareRClass.SetRightHandPos1(rClass.GetRightHandpos1());
        hareRClass.SetRightHandPos2(rClass.GetRightHandpos2());
        hareRClass.SetLeftHandAngle1(rClass.GetLeftHandAngle1());
        hareRClass.SetLeftHandAngle2(rClass.GetLeftHandAngle2());
        hareRClass.SetRightHandAngle1(rClass.GetRightHandAngle1());
        hareRClass.SetRightHandAngle2(rClass.GetRightHandAngle2());

        oereRClass = new PicturePhonemeClass(oereR);
        oereRClass.SetImageName("oere");
        oereRClass.SetAssignment("Hvad er den midterste lyd");
        oereRClass.SetAssignmentLetter("r");
        oereRClass.SetNoOfPos(2);
        oereRClass.SetEnableLeftHand(true);
        oereRClass.SetEnableRightHand(true);
        oereRClass.SetPos1ReadyToHit(true);
        oereRClass.SetPos2ReadyToHit(true);
        oereRClass.SetLeftHandPos1(rClass.GetLeftHandpos1());
        oereRClass.SetLeftHandPos2(rClass.GetLeftHandpos2());
        oereRClass.SetRightHandPos1(rClass.GetRightHandpos1());
        oereRClass.SetRightHandPos2(rClass.GetRightHandpos2());
        oereRClass.SetLeftHandAngle1(rClass.GetLeftHandAngle1());
        oereRClass.SetLeftHandAngle2(rClass.GetLeftHandAngle2());
        oereRClass.SetRightHandAngle1(rClass.GetRightHandAngle1());
        oereRClass.SetRightHandAngle2(rClass.GetRightHandAngle2());

        raketClass = new PicturePhonemeClass(raket);
        raketClass.SetImageName("raket");
        raketClass.SetAssignment("Hvad er den første lyd");
        raketClass.SetAssignmentLetter("r");
        raketClass.SetNoOfPos(2);
        raketClass.SetEnableLeftHand(true);
        raketClass.SetEnableRightHand(true);
        raketClass.SetPos1ReadyToHit(true);
        raketClass.SetPos2ReadyToHit(true);
        raketClass.SetLeftHandPos1(rClass.GetLeftHandpos1());
        raketClass.SetLeftHandPos2(rClass.GetLeftHandpos2());
        raketClass.SetRightHandPos1(rClass.GetRightHandpos1());
        raketClass.SetRightHandPos2(rClass.GetRightHandpos2());
        raketClass.SetLeftHandAngle1(rClass.GetLeftHandAngle1());
        raketClass.SetLeftHandAngle2(rClass.GetLeftHandAngle2());
        raketClass.SetRightHandAngle1(rClass.GetRightHandAngle1());
        raketClass.SetRightHandAngle2(rClass.GetRightHandAngle2());

        roseClass = new PicturePhonemeClass(rose);
        roseClass.SetImageName("rose");
        roseClass.SetAssignment("Hvad er den første lyd");
        roseClass.SetAssignmentLetter("r");
        roseClass.SetNoOfPos(2);
        roseClass.SetEnableLeftHand(true);
        roseClass.SetEnableRightHand(true);
        roseClass.SetPos1ReadyToHit(true);
        roseClass.SetPos2ReadyToHit(true);
        roseClass.SetLeftHandPos1(rClass.GetLeftHandpos1());
        roseClass.SetLeftHandPos2(rClass.GetLeftHandpos2());
        roseClass.SetRightHandPos1(rClass.GetRightHandpos1());
        roseClass.SetRightHandPos2(rClass.GetRightHandpos2());
        roseClass.SetLeftHandAngle1(rClass.GetLeftHandAngle1());
        roseClass.SetLeftHandAngle2(rClass.GetLeftHandAngle2());
        roseClass.SetRightHandAngle1(rClass.GetRightHandAngle1());
        roseClass.SetRightHandAngle2(rClass.GetRightHandAngle2());

        // r lyd 2 

        aenderClass = new PicturePhonemeClass(aender);
        aenderClass.SetImageName("aender");
        aenderClass.SetAssignment("Hvad er den sidste lyd");
        aenderClass.SetAssignmentLetter("r");
        aenderClass.SetNoOfPos(2);
        aenderClass.SetEnableLeftHand(true);
        aenderClass.SetEnableRightHand(true);
        aenderClass.SetPos1ReadyToHit(true);
        aenderClass.SetPos2ReadyToHit(true);
        aenderClass.SetLeftHandPos1(rClass.GetLeftHandpos3());
        aenderClass.SetLeftHandPos2(rClass.GetLeftHandpos4());
        aenderClass.SetRightHandPos1(rClass.GetRightHandpos3());
        aenderClass.SetRightHandPos2(rClass.GetRightHandpos4());
        aenderClass.SetLeftHandAngle1(rClass.GetLeftHandAngle3());
        aenderClass.SetLeftHandAngle2(rClass.GetLeftHandAngle4());
        aenderClass.SetRightHandAngle1(rClass.GetRightHandAngle3());
        aenderClass.SetRightHandAngle2(rClass.GetRightHandAngle4());

        bilerClass = new PicturePhonemeClass(biler);
        bilerClass.SetImageName("biler");
        bilerClass.SetAssignment("Hvad er den sidste lyd");
        bilerClass.SetAssignmentLetter("r");
        bilerClass.SetNoOfPos(2);
        bilerClass.SetEnableLeftHand(true);
        bilerClass.SetEnableRightHand(true);
        bilerClass.SetPos1ReadyToHit(true);
        bilerClass.SetPos2ReadyToHit(true);
        bilerClass.SetLeftHandPos1(rClass.GetLeftHandpos3());
        bilerClass.SetLeftHandPos2(rClass.GetLeftHandpos4());
        bilerClass.SetRightHandPos1(rClass.GetRightHandpos3());
        bilerClass.SetRightHandPos2(rClass.GetRightHandpos4());
        bilerClass.SetLeftHandAngle1(rClass.GetLeftHandAngle3());
        bilerClass.SetLeftHandAngle2(rClass.GetLeftHandAngle4());
        bilerClass.SetRightHandAngle1(rClass.GetRightHandAngle3());
        bilerClass.SetRightHandAngle2(rClass.GetRightHandAngle4());

        saelerClass = new PicturePhonemeClass(saeler);
        saelerClass.SetImageName("saeler");
        saelerClass.SetAssignment("Hvad er den sidste lyd");
        saelerClass.SetAssignmentLetter("r");
        saelerClass.SetNoOfPos(2);
        saelerClass.SetEnableLeftHand(true);
        saelerClass.SetEnableRightHand(true);
        saelerClass.SetPos1ReadyToHit(true);
        saelerClass.SetPos2ReadyToHit(true);
        saelerClass.SetLeftHandPos1(rClass.GetLeftHandpos3());
        saelerClass.SetLeftHandPos2(rClass.GetLeftHandpos4());
        saelerClass.SetRightHandPos1(rClass.GetRightHandpos3());
        saelerClass.SetRightHandPos2(rClass.GetRightHandpos4());
        saelerClass.SetLeftHandAngle1(rClass.GetLeftHandAngle3());
        saelerClass.SetLeftHandAngle2(rClass.GetLeftHandAngle4());
        saelerClass.SetRightHandAngle1(rClass.GetRightHandAngle3());
        saelerClass.SetRightHandAngle2(rClass.GetRightHandAngle4());

        loeverClass = new PicturePhonemeClass(loever);
        loeverClass.SetImageName("loever");
        loeverClass.SetAssignment("Hvad er den sidste lyd");
        loeverClass.SetAssignmentLetter("r");
        loeverClass.SetNoOfPos(2);
        loeverClass.SetEnableLeftHand(true);
        loeverClass.SetEnableRightHand(true);
        loeverClass.SetPos1ReadyToHit(true);
        loeverClass.SetPos2ReadyToHit(true);
        loeverClass.SetLeftHandPos1(rClass.GetLeftHandpos3());
        loeverClass.SetLeftHandPos2(rClass.GetLeftHandpos4());
        loeverClass.SetRightHandPos1(rClass.GetRightHandpos3());
        loeverClass.SetRightHandPos2(rClass.GetRightHandpos4());
        loeverClass.SetLeftHandAngle1(rClass.GetLeftHandAngle3());
        loeverClass.SetLeftHandAngle2(rClass.GetLeftHandAngle4());
        loeverClass.SetRightHandAngle1(rClass.GetRightHandAngle3());
        loeverClass.SetRightHandAngle2(rClass.GetRightHandAngle4());

        //t lyd
        togClass = new PicturePhonemeClass(tog);
        togClass.SetImageName("tog");
        togClass.SetAssignment("Hvad er den første lyd");
        togClass.SetAssignmentLetter("t");
        togClass.SetNoOfPos(3);
        togClass.SetEnableLeftHand(true);
        togClass.SetEnableRightHand(true);
        togClass.SetPos1ReadyToHit(true);
        togClass.SetPos2ReadyToHit(true);
        togClass.SetPos3ReadyToHit(true);
        togClass.SetLeftHandPos1(tClass.GetLeftHandpos1());
        togClass.SetLeftHandPos2(tClass.GetLeftHandpos2());
        togClass.SetLeftHandPos3(tClass.GetLeftHandpos3());
        togClass.SetRightHandPos1(tClass.GetRightHandpos1());
        togClass.SetRightHandPos2(tClass.GetRightHandpos2());
        togClass.SetRightHandPos3(tClass.GetRightHandpos3());
        togClass.SetLeftHandAngle1(tClass.GetLeftHandAngle1());
        togClass.SetLeftHandAngle2(tClass.GetLeftHandAngle2());
        togClass.SetLeftHandAngle3(tClass.GetLeftHandAngle3());
        togClass.SetRightHandAngle1(tClass.GetRightHandAngle1());
        togClass.SetRightHandAngle2(tClass.GetRightHandAngle2());
        togClass.SetRightHandAngle3(tClass.GetRightHandAngle3());

        katClass = new PicturePhonemeClass(kat);
        katClass.SetImageName("kat");
        katClass.SetAssignment("Hvad er den sidste lyd");
        katClass.SetAssignmentLetter("t");
        katClass.SetNoOfPos(3);
        katClass.SetEnableLeftHand(true);
        katClass.SetEnableRightHand(true);
        katClass.SetPos1ReadyToHit(true);
        katClass.SetPos2ReadyToHit(true);
        katClass.SetPos3ReadyToHit(true);
        katClass.SetLeftHandPos1(tClass.GetLeftHandpos1());
        katClass.SetLeftHandPos2(tClass.GetLeftHandpos2());
        katClass.SetLeftHandPos3(tClass.GetLeftHandpos3());
        katClass.SetRightHandPos1(tClass.GetRightHandpos1());
        katClass.SetRightHandPos2(tClass.GetRightHandpos2());
        katClass.SetRightHandPos3(tClass.GetRightHandpos3());
        katClass.SetLeftHandAngle1(tClass.GetLeftHandAngle1());
        katClass.SetLeftHandAngle2(tClass.GetLeftHandAngle2());
        katClass.SetLeftHandAngle3(tClass.GetLeftHandAngle3());
        katClass.SetRightHandAngle1(tClass.GetRightHandAngle1());
        katClass.SetRightHandAngle2(tClass.GetRightHandAngle2());
        katClass.SetRightHandAngle3(tClass.GetRightHandAngle3());

        hatClass = new PicturePhonemeClass(hatT);
        hatClass.SetImageName("hat");
        hatClass.SetAssignment("Hvad er den sidste lyd");
        hatClass.SetAssignmentLetter("t");
        hatClass.SetNoOfPos(3);
        hatClass.SetEnableLeftHand(true);
        hatClass.SetEnableRightHand(true);
        hatClass.SetPos1ReadyToHit(true);
        hatClass.SetPos2ReadyToHit(true);
        hatClass.SetPos3ReadyToHit(true);
        hatClass.SetLeftHandPos1(tClass.GetLeftHandpos1());
        hatClass.SetLeftHandPos2(tClass.GetLeftHandpos2());
        hatClass.SetLeftHandPos3(tClass.GetLeftHandpos3());
        hatClass.SetRightHandPos1(tClass.GetRightHandpos1());
        hatClass.SetRightHandPos2(tClass.GetRightHandpos2());
        hatClass.SetRightHandPos3(tClass.GetRightHandpos3());
        hatClass.SetLeftHandAngle1(tClass.GetLeftHandAngle1());
        hatClass.SetLeftHandAngle2(tClass.GetLeftHandAngle2());
        hatClass.SetLeftHandAngle3(tClass.GetLeftHandAngle3());
        hatClass.SetRightHandAngle1(tClass.GetRightHandAngle1());
        hatClass.SetRightHandAngle2(tClass.GetRightHandAngle2());
        hatClass.SetRightHandAngle3(tClass.GetRightHandAngle3());

        troldClass = new PicturePhonemeClass(trold);
        troldClass.SetImageName("trold");
        troldClass.SetAssignment("Hvad er den første lyd");
        troldClass.SetAssignmentLetter("t");
        troldClass.SetNoOfPos(3);
        troldClass.SetEnableLeftHand(true);
        troldClass.SetEnableRightHand(true);
        troldClass.SetPos1ReadyToHit(true);
        troldClass.SetPos2ReadyToHit(true);
        troldClass.SetPos3ReadyToHit(true);
        troldClass.SetLeftHandPos1(tClass.GetLeftHandpos1());
        troldClass.SetLeftHandPos2(tClass.GetLeftHandpos2());
        troldClass.SetLeftHandPos3(tClass.GetLeftHandpos3());
        troldClass.SetRightHandPos1(tClass.GetRightHandpos1());
        troldClass.SetRightHandPos2(tClass.GetRightHandpos2());
        troldClass.SetRightHandPos3(tClass.GetRightHandpos3());
        troldClass.SetLeftHandAngle1(tClass.GetLeftHandAngle1());
        troldClass.SetLeftHandAngle2(tClass.GetLeftHandAngle2());
        troldClass.SetLeftHandAngle3(tClass.GetLeftHandAngle3());
        troldClass.SetRightHandAngle1(tClass.GetRightHandAngle1());
        troldClass.SetRightHandAngle2(tClass.GetRightHandAngle2());
        troldClass.SetRightHandAngle3(tClass.GetRightHandAngle3());

        sutTClass = new PicturePhonemeClass(sutT);
        sutTClass.SetImageName("sut");
        sutTClass.SetAssignment("Hvad er den sidste lyd");
        sutTClass.SetAssignmentLetter("t");
        sutTClass.SetNoOfPos(3);
        sutTClass.SetEnableLeftHand(true);
        sutTClass.SetEnableRightHand(true);
        sutTClass.SetPos1ReadyToHit(true);
        sutTClass.SetPos2ReadyToHit(true);
        sutTClass.SetPos3ReadyToHit(true);
        sutTClass.SetLeftHandPos1(tClass.GetLeftHandpos1());
        sutTClass.SetLeftHandPos2(tClass.GetLeftHandpos2());
        sutTClass.SetLeftHandPos3(tClass.GetLeftHandpos3());
        sutTClass.SetRightHandPos1(tClass.GetRightHandpos1());
        sutTClass.SetRightHandPos2(tClass.GetRightHandpos2());
        sutTClass.SetRightHandPos3(tClass.GetRightHandpos3());
        sutTClass.SetLeftHandAngle1(tClass.GetLeftHandAngle1());
        sutTClass.SetLeftHandAngle2(tClass.GetLeftHandAngle2());
        sutTClass.SetLeftHandAngle3(tClass.GetLeftHandAngle3());
        sutTClass.SetRightHandAngle1(tClass.GetRightHandAngle1());
        sutTClass.SetRightHandAngle2(tClass.GetRightHandAngle2());
        sutTClass.SetRightHandAngle3(tClass.GetRightHandAngle3());

        //s lyd et 
        //skibClass = new PicturePhonemeClass(skib);
        //skibClass.SetImageName("skib");
        //skibClass.SetAssignment("Hvad er den første lyd i ordet");
        //skibClass.SetAssignmentLetter("s");
        //skibClass.SetNoOfPos(3);
        //skibClass.SetEnableRightHand(true);
        //skibClass.SetPos1ReadyToHit(true);
        //skibClass.SetPos2ReadyToHit(true);
        //skibClass.SetPos3ReadyToHit(true);
        //skibClass.SetRightHandPos1(sClass.GetRightHandpos1());
        //skibClass.SetRightHandPos2(sClass.GetRightHandpos2());
        //skibClass.SetRightHandPos3(sClass.GetRightHandpos3());
        //skibClass.SetRightHandAngle1(sClass.GetRightHandAngle1());
        //skibClass.SetRightHandAngle2(sClass.GetRightHandAngle2());
        //skibClass.SetRightHandAngle3(sClass.GetRightHandAngle3());
        //skibClass.SetLeftHandPos1(sClass.GetLeftHandpos1());
        //skibClass.SetLeftHandPos2(sClass.GetLeftHandpos2());
        //skibClass.SetLeftHandPos3(sClass.GetLeftHandpos3());
        //skibClass.SetLeftHandAngle1(sClass.GetLeftHandAngle1());
        //skibClass.SetLeftHandAngle2(sClass.GetLeftHandAngle2());
        //skibClass.SetLeftHandAngle3(sClass.GetLeftHandAngle3());

        //s lyd et 
        svampClass = new PicturePhonemeClass(svamp);
        svampClass.SetImageName("svamp");
        svampClass.SetAssignment("Hvad er den første lyd i ordet");
        svampClass.SetAssignmentLetter("s");
        svampClass.SetNoOfPos(3);
        svampClass.SetEnableRightHand(true);
        svampClass.SetPos1ReadyToHit(true);
        svampClass.SetPos2ReadyToHit(true);
        svampClass.SetPos3ReadyToHit(true);
        svampClass.SetRightHandPos1(sClass.GetRightHandpos1());
        svampClass.SetRightHandPos2(sClass.GetRightHandpos2());
        svampClass.SetRightHandPos3(sClass.GetRightHandpos3());
        svampClass.SetRightHandAngle1(sClass.GetRightHandAngle1());
        svampClass.SetRightHandAngle2(sClass.GetRightHandAngle2());
        svampClass.SetRightHandAngle3(sClass.GetRightHandAngle3());
        svampClass.SetLeftHandPos1(sClass.GetLeftHandpos1());
        svampClass.SetLeftHandPos2(sClass.GetLeftHandpos2());
        svampClass.SetLeftHandPos3(sClass.GetLeftHandpos3());
        svampClass.SetLeftHandAngle1(sClass.GetLeftHandAngle1());
        svampClass.SetLeftHandAngle2(sClass.GetLeftHandAngle2());
        svampClass.SetLeftHandAngle3(sClass.GetLeftHandAngle3());

        //t lyd et 
        tiClass = new PicturePhonemeClass(ti);
        tiClass.SetImageName("ti");
        tiClass.SetAssignment("Hvad er den første lyd i ordet");
        tiClass.SetAssignmentLetter("t");
        tiClass.SetNoOfPos(3);
        tiClass.SetEnableRightHand(true);
        tiClass.SetEnableLeftHand(true);
        tiClass.SetPos1ReadyToHit(true);
        tiClass.SetPos2ReadyToHit(true);
        tiClass.SetPos3ReadyToHit(true);
        tiClass.SetRightHandPos1(tClass.GetRightHandpos1());
        tiClass.SetRightHandPos2(tClass.GetRightHandpos2());
        tiClass.SetRightHandPos3(tClass.GetRightHandpos3());
        tiClass.SetLeftHandPos1(tClass.GetLeftHandpos1());
        tiClass.SetLeftHandPos2(tClass.GetLeftHandpos2());
        tiClass.SetLeftHandPos3(tClass.GetLeftHandpos3());
        tiClass.SetRightHandAngle1(tClass.GetRightHandAngle1());
        tiClass.SetRightHandAngle2(tClass.GetRightHandAngle2());
        tiClass.SetRightHandAngle3(tClass.GetRightHandAngle3());
        tiClass.SetLeftHandAngle1(tClass.GetLeftHandAngle1());
        tiClass.SetLeftHandAngle2(tClass.GetLeftHandAngle2());
        tiClass.SetLeftHandAngle3(tClass.GetLeftHandAngle3());

        //U lyd et 
        busUClass = new PicturePhonemeClass(busU);
        busUClass.SetImageName("bus");
        busUClass.SetAssignment("Hvad er den midterste lyd");
        busUClass.SetAssignmentLetter("u");
        busUClass.SetNoOfPos(4);
        busUClass.SetEnableLeftHand(true);
        busUClass.SetEnableRightHand(true);
        busUClass.SetPos1ReadyToHit(true);
        busUClass.SetPos2ReadyToHit(true);
        busUClass.SetPos3ReadyToHit(true);
        busUClass.SetPos4ReadyToHit(true);
        busUClass.SetLeftHandPos1(uLyd1Class.GetLeftHandpos1());
        busUClass.SetLeftHandPos2(uLyd1Class.GetLeftHandpos2());
        busUClass.SetLeftHandPos3(uLyd1Class.GetLeftHandpos3());
        busUClass.SetLeftHandPos4(uLyd1Class.GetLeftHandpos4());
        busUClass.SetRightHandPos1(uLyd1Class.GetRightHandpos1());
        busUClass.SetRightHandPos2(uLyd1Class.GetRightHandpos2());
        busUClass.SetRightHandPos3(uLyd1Class.GetRightHandpos3());
        busUClass.SetRightHandPos4(uLyd1Class.GetRightHandpos4());
        busUClass.SetLeftHandAngle1(uLyd1Class.GetLeftHandAngle1());
        busUClass.SetLeftHandAngle2(uLyd1Class.GetLeftHandAngle2());
        busUClass.SetLeftHandAngle3(uLyd1Class.GetLeftHandAngle3());
        busUClass.SetLeftHandAngle4(uLyd1Class.GetLeftHandAngle4());
        busUClass.SetRightHandAngle1(uLyd1Class.GetRightHandAngle1());
        busUClass.SetRightHandAngle2(uLyd1Class.GetRightHandAngle2());
        busUClass.SetRightHandAngle3(uLyd1Class.GetRightHandAngle3());
        busUClass.SetRightHandAngle4(uLyd1Class.GetRightHandAngle4());


        ugleClass = new PicturePhonemeClass(ugle);
        ugleClass.SetImageName("ugle");
        ugleClass.SetAssignment("Hvad er den første lyd");
        ugleClass.SetAssignmentLetter("u");
        ugleClass.SetNoOfPos(4);
        ugleClass.SetEnableLeftHand(true);
        ugleClass.SetEnableRightHand(true);
        ugleClass.SetPos1ReadyToHit(true);
        ugleClass.SetPos2ReadyToHit(true);
        ugleClass.SetPos3ReadyToHit(true);
        ugleClass.SetPos4ReadyToHit(true);
        ugleClass.SetLeftHandPos1(uLyd1Class.GetLeftHandpos1());
        ugleClass.SetLeftHandPos2(uLyd1Class.GetLeftHandpos2());
        ugleClass.SetLeftHandPos3(uLyd1Class.GetLeftHandpos3());
        ugleClass.SetLeftHandPos4(uLyd1Class.GetLeftHandpos4());
        ugleClass.SetRightHandPos1(uLyd1Class.GetRightHandpos1());
        ugleClass.SetRightHandPos2(uLyd1Class.GetRightHandpos2());
        ugleClass.SetRightHandPos3(uLyd1Class.GetRightHandpos3());
        ugleClass.SetRightHandPos4(uLyd1Class.GetRightHandpos4());
        ugleClass.SetLeftHandAngle1(uLyd1Class.GetLeftHandAngle1());
        ugleClass.SetLeftHandAngle2(uLyd1Class.GetLeftHandAngle2());
        ugleClass.SetLeftHandAngle3(uLyd1Class.GetLeftHandAngle3());
        ugleClass.SetLeftHandAngle4(uLyd1Class.GetLeftHandAngle4());
        ugleClass.SetRightHandAngle1(uLyd1Class.GetRightHandAngle1());
        ugleClass.SetRightHandAngle2(uLyd1Class.GetRightHandAngle2());
        ugleClass.SetRightHandAngle3(uLyd1Class.GetRightHandAngle3());
        ugleClass.SetRightHandAngle4(uLyd1Class.GetRightHandAngle4());

        murUClass = new PicturePhonemeClass(murU);
        murUClass.SetImageName("mur");
        murUClass.SetAssignment("Hvad er den midterste lyd");
        murUClass.SetAssignmentLetter("u");
        murUClass.SetNoOfPos(4);
        murUClass.SetEnableLeftHand(true);
        murUClass.SetEnableRightHand(true);
        murUClass.SetPos1ReadyToHit(true);
        murUClass.SetPos2ReadyToHit(true);
        murUClass.SetPos3ReadyToHit(true);
        murUClass.SetPos4ReadyToHit(true);
        murUClass.SetLeftHandPos1(uLyd1Class.GetLeftHandpos1());
        murUClass.SetLeftHandPos2(uLyd1Class.GetLeftHandpos2());
        murUClass.SetLeftHandPos3(uLyd1Class.GetLeftHandpos3());
        murUClass.SetLeftHandPos4(uLyd1Class.GetLeftHandpos4());
        murUClass.SetRightHandPos1(uLyd1Class.GetRightHandpos1());
        murUClass.SetRightHandPos2(uLyd1Class.GetRightHandpos2());
        murUClass.SetRightHandPos3(uLyd1Class.GetRightHandpos3());
        murUClass.SetRightHandPos4(uLyd1Class.GetRightHandpos4());
        murUClass.SetLeftHandAngle1(uLyd1Class.GetLeftHandAngle1());
        murUClass.SetLeftHandAngle2(uLyd1Class.GetLeftHandAngle2());
        murUClass.SetLeftHandAngle3(uLyd1Class.GetLeftHandAngle3());
        murUClass.SetLeftHandAngle4(uLyd1Class.GetLeftHandAngle4());
        murUClass.SetRightHandAngle1(uLyd1Class.GetRightHandAngle1());
        murUClass.SetRightHandAngle2(uLyd1Class.GetRightHandAngle2());
        murUClass.SetRightHandAngle3(uLyd1Class.GetRightHandAngle3());
        murUClass.SetRightHandAngle4(uLyd1Class.GetRightHandAngle4());

        urClass = new PicturePhonemeClass(ur);
        urClass.SetImageName("ur");
        urClass.SetAssignment("Hvad er den første lyd");
        urClass.SetAssignmentLetter("u");
        urClass.SetNoOfPos(4);
        urClass.SetEnableLeftHand(true);
        urClass.SetEnableRightHand(true);
        urClass.SetPos1ReadyToHit(true);
        urClass.SetPos2ReadyToHit(true);
        urClass.SetPos3ReadyToHit(true);
        urClass.SetPos4ReadyToHit(true);
        urClass.SetLeftHandPos1(uLyd1Class.GetLeftHandpos1());
        urClass.SetLeftHandPos2(uLyd1Class.GetLeftHandpos2());
        urClass.SetLeftHandPos3(uLyd1Class.GetLeftHandpos3());
        urClass.SetLeftHandPos4(uLyd1Class.GetLeftHandpos4());
        urClass.SetRightHandPos1(uLyd1Class.GetRightHandpos1());
        urClass.SetRightHandPos2(uLyd1Class.GetRightHandpos2());
        urClass.SetRightHandPos3(uLyd1Class.GetRightHandpos3());
        urClass.SetRightHandPos4(uLyd1Class.GetRightHandpos4());
        urClass.SetLeftHandAngle1(uLyd1Class.GetLeftHandAngle1());
        urClass.SetLeftHandAngle2(uLyd1Class.GetLeftHandAngle2());
        urClass.SetLeftHandAngle3(uLyd1Class.GetLeftHandAngle3());
        urClass.SetLeftHandAngle4(uLyd1Class.GetLeftHandAngle4());
        urClass.SetRightHandAngle1(uLyd1Class.GetRightHandAngle1());
        urClass.SetRightHandAngle2(uLyd1Class.GetRightHandAngle2());
        urClass.SetRightHandAngle3(uLyd1Class.GetRightHandAngle3());
        urClass.SetRightHandAngle4(uLyd1Class.GetRightHandAngle4());

        sutUClass = new PicturePhonemeClass(sutU);
        sutUClass.SetImageName("sut");
        sutUClass.SetAssignment("Hvad er den midterste lyd");
        sutUClass.SetAssignmentLetter("u");
        sutUClass.SetNoOfPos(4);
        sutUClass.SetEnableLeftHand(true);
        sutUClass.SetEnableRightHand(true);
        sutUClass.SetPos1ReadyToHit(true);
        sutUClass.SetPos2ReadyToHit(true);
        sutUClass.SetPos3ReadyToHit(true);
        sutUClass.SetPos4ReadyToHit(true);
        sutUClass.SetLeftHandPos1(uLyd1Class.GetLeftHandpos1());
        sutUClass.SetLeftHandPos2(uLyd1Class.GetLeftHandpos2());
        sutUClass.SetLeftHandPos3(uLyd1Class.GetLeftHandpos3());
        sutUClass.SetLeftHandPos4(uLyd1Class.GetLeftHandpos4());
        sutUClass.SetRightHandPos1(uLyd1Class.GetRightHandpos1());
        sutUClass.SetRightHandPos2(uLyd1Class.GetRightHandpos2());
        sutUClass.SetRightHandPos3(uLyd1Class.GetRightHandpos3());
        sutUClass.SetRightHandPos4(uLyd1Class.GetRightHandpos4());
        sutUClass.SetLeftHandAngle1(uLyd1Class.GetLeftHandAngle1());
        sutUClass.SetLeftHandAngle2(uLyd1Class.GetLeftHandAngle2());
        sutUClass.SetLeftHandAngle3(uLyd1Class.GetLeftHandAngle3());
        sutUClass.SetLeftHandAngle4(uLyd1Class.GetLeftHandAngle4());
        sutUClass.SetRightHandAngle1(uLyd1Class.GetRightHandAngle1());
        sutUClass.SetRightHandAngle2(uLyd1Class.GetRightHandAngle2());
        sutUClass.SetRightHandAngle3(uLyd1Class.GetRightHandAngle3());
        sutUClass.SetRightHandAngle4(uLyd1Class.GetRightHandAngle4());

        //U lyd to

        frugtClass = new PicturePhonemeClass(frugt);
        frugtClass.SetImageName("frugt");
        frugtClass.SetAssignment("Hvad er den midterste lyd");
        frugtClass.SetAssignmentLetter("u");
        frugtClass.SetNoOfPos(4);
        frugtClass.SetEnableLeftHand(true);
        frugtClass.SetEnableRightHand(true);
        frugtClass.SetPos1ReadyToHit(true);
        frugtClass.SetPos2ReadyToHit(true);
        frugtClass.SetPos3ReadyToHit(true);
        frugtClass.SetPos4ReadyToHit(true);
        frugtClass.SetLeftHandPos1(uLyd2Class.GetLeftHandpos1());
        frugtClass.SetLeftHandPos2(uLyd2Class.GetLeftHandpos2());
        frugtClass.SetLeftHandPos3(uLyd2Class.GetLeftHandpos3());
        frugtClass.SetLeftHandPos4(uLyd2Class.GetLeftHandpos4());
        frugtClass.SetRightHandPos1(uLyd2Class.GetRightHandpos1());
        frugtClass.SetRightHandPos2(uLyd2Class.GetRightHandpos2());
        frugtClass.SetRightHandPos3(uLyd2Class.GetRightHandpos3());
        frugtClass.SetRightHandPos4(uLyd2Class.GetRightHandpos4());
        frugtClass.SetLeftHandAngle1(uLyd2Class.GetLeftHandAngle1());
        frugtClass.SetLeftHandAngle2(uLyd2Class.GetLeftHandAngle2());
        frugtClass.SetLeftHandAngle3(uLyd2Class.GetLeftHandAngle3());
        frugtClass.SetLeftHandAngle4(uLyd2Class.GetLeftHandAngle4());
        frugtClass.SetRightHandAngle1(uLyd2Class.GetRightHandAngle1());
        frugtClass.SetRightHandAngle2(uLyd2Class.GetRightHandAngle2());
        frugtClass.SetRightHandAngle3(uLyd2Class.GetRightHandAngle3());
        frugtClass.SetRightHandAngle4(uLyd2Class.GetRightHandAngle4());

        vuggeClass = new PicturePhonemeClass(vugge);
        vuggeClass.SetImageName("vugge");
        vuggeClass.SetAssignment("Hvad er den første vokal lyd");
        vuggeClass.SetAssignmentLetter("u");
        vuggeClass.SetNoOfPos(4);
        vuggeClass.SetEnableLeftHand(true);
        vuggeClass.SetEnableRightHand(true);
        vuggeClass.SetPos1ReadyToHit(true);
        vuggeClass.SetPos2ReadyToHit(true);
        vuggeClass.SetPos3ReadyToHit(true);
        vuggeClass.SetPos4ReadyToHit(true);
        vuggeClass.SetLeftHandPos1(uLyd2Class.GetLeftHandpos1());
        vuggeClass.SetLeftHandPos2(uLyd2Class.GetLeftHandpos2());
        vuggeClass.SetLeftHandPos3(uLyd2Class.GetLeftHandpos3());
        vuggeClass.SetLeftHandPos4(uLyd2Class.GetLeftHandpos4());
        vuggeClass.SetRightHandPos1(uLyd2Class.GetRightHandpos1());
        vuggeClass.SetRightHandPos2(uLyd2Class.GetRightHandpos2());
        vuggeClass.SetRightHandPos3(uLyd2Class.GetRightHandpos3());
        vuggeClass.SetRightHandPos4(uLyd2Class.GetRightHandpos4());
        vuggeClass.SetLeftHandAngle1(uLyd2Class.GetLeftHandAngle1());
        vuggeClass.SetLeftHandAngle2(uLyd2Class.GetLeftHandAngle2());
        vuggeClass.SetLeftHandAngle3(uLyd2Class.GetLeftHandAngle3());
        vuggeClass.SetLeftHandAngle4(uLyd2Class.GetLeftHandAngle4());
        vuggeClass.SetRightHandAngle1(uLyd2Class.GetRightHandAngle1());
        vuggeClass.SetRightHandAngle2(uLyd2Class.GetRightHandAngle2());
        vuggeClass.SetRightHandAngle3(uLyd2Class.GetRightHandAngle3());
        vuggeClass.SetRightHandAngle4(uLyd2Class.GetRightHandAngle4());

        dukkeClass = new PicturePhonemeClass(dukke);
        dukkeClass.SetImageName("dukke");
        dukkeClass.SetAssignment("Hvad er den første vokal lyd");
        dukkeClass.SetAssignmentLetter("u");
        dukkeClass.SetNoOfPos(4);
        dukkeClass.SetEnableLeftHand(true);
        dukkeClass.SetEnableRightHand(true);
        dukkeClass.SetPos1ReadyToHit(true);
        dukkeClass.SetPos2ReadyToHit(true);
        dukkeClass.SetPos3ReadyToHit(true);
        dukkeClass.SetPos4ReadyToHit(true);
        dukkeClass.SetLeftHandPos1(uLyd2Class.GetLeftHandpos1());
        dukkeClass.SetLeftHandPos2(uLyd2Class.GetLeftHandpos2());
        dukkeClass.SetLeftHandPos3(uLyd2Class.GetLeftHandpos3());
        dukkeClass.SetLeftHandPos4(uLyd2Class.GetLeftHandpos4());
        dukkeClass.SetRightHandPos1(uLyd2Class.GetRightHandpos1());
        dukkeClass.SetRightHandPos2(uLyd2Class.GetRightHandpos2());
        dukkeClass.SetRightHandPos3(uLyd2Class.GetRightHandpos3());
        dukkeClass.SetRightHandPos4(uLyd2Class.GetRightHandpos4());
        dukkeClass.SetLeftHandAngle1(uLyd2Class.GetLeftHandAngle1());
        dukkeClass.SetLeftHandAngle2(uLyd2Class.GetLeftHandAngle2());
        dukkeClass.SetLeftHandAngle3(uLyd2Class.GetLeftHandAngle3());
        dukkeClass.SetLeftHandAngle4(uLyd2Class.GetLeftHandAngle4());
        dukkeClass.SetRightHandAngle1(uLyd2Class.GetRightHandAngle1());
        dukkeClass.SetRightHandAngle2(uLyd2Class.GetRightHandAngle2());
        dukkeClass.SetRightHandAngle3(uLyd2Class.GetRightHandAngle3());
        dukkeClass.SetRightHandAngle4(uLyd2Class.GetRightHandAngle4());

        nulClass = new PicturePhonemeClass(nul);
        nulClass.SetImageName("nul");
        nulClass.SetAssignment("Hvad er den midterste lyd");
        nulClass.SetAssignmentLetter("u");
        nulClass.SetNoOfPos(4);
        nulClass.SetEnableLeftHand(true);
        nulClass.SetEnableRightHand(true);
        nulClass.SetPos1ReadyToHit(true);
        nulClass.SetPos2ReadyToHit(true);
        nulClass.SetPos3ReadyToHit(true);
        nulClass.SetPos4ReadyToHit(true);
        nulClass.SetLeftHandPos1(uLyd2Class.GetLeftHandpos1());
        nulClass.SetLeftHandPos2(uLyd2Class.GetLeftHandpos2());
        nulClass.SetLeftHandPos3(uLyd2Class.GetLeftHandpos3());
        nulClass.SetLeftHandPos4(uLyd2Class.GetLeftHandpos4());
        nulClass.SetRightHandPos1(uLyd2Class.GetRightHandpos1());
        nulClass.SetRightHandPos2(uLyd2Class.GetRightHandpos2());
        nulClass.SetRightHandPos3(uLyd2Class.GetRightHandpos3());
        nulClass.SetRightHandPos4(uLyd2Class.GetRightHandpos4());
        nulClass.SetLeftHandAngle1(uLyd2Class.GetLeftHandAngle1());
        nulClass.SetLeftHandAngle2(uLyd2Class.GetLeftHandAngle2());
        nulClass.SetLeftHandAngle3(uLyd2Class.GetLeftHandAngle3());
        nulClass.SetLeftHandAngle4(uLyd2Class.GetLeftHandAngle4());
        nulClass.SetRightHandAngle1(uLyd2Class.GetRightHandAngle1());
        nulClass.SetRightHandAngle2(uLyd2Class.GetRightHandAngle2());
        nulClass.SetRightHandAngle3(uLyd2Class.GetRightHandAngle3());
        nulClass.SetRightHandAngle4(uLyd2Class.GetRightHandAngle4());

        gulvClass = new PicturePhonemeClass(gulv);
        gulvClass.SetImageName("gulv");
        gulvClass.SetAssignment("Hvad er den midterste lyd");
        gulvClass.SetAssignmentLetter("u");
        gulvClass.SetNoOfPos(4);
        gulvClass.SetEnableLeftHand(true);
        gulvClass.SetEnableRightHand(true);
        gulvClass.SetPos1ReadyToHit(true);
        gulvClass.SetPos2ReadyToHit(true);
        gulvClass.SetPos3ReadyToHit(true);
        gulvClass.SetPos4ReadyToHit(true);
        gulvClass.SetLeftHandPos1(uLyd2Class.GetLeftHandpos1());
        gulvClass.SetLeftHandPos2(uLyd2Class.GetLeftHandpos2());
        gulvClass.SetLeftHandPos3(uLyd2Class.GetLeftHandpos3());
        gulvClass.SetLeftHandPos4(uLyd2Class.GetLeftHandpos4());
        gulvClass.SetRightHandPos1(uLyd2Class.GetRightHandpos1());
        gulvClass.SetRightHandPos2(uLyd2Class.GetRightHandpos2());
        gulvClass.SetRightHandPos3(uLyd2Class.GetRightHandpos3());
        gulvClass.SetRightHandPos4(uLyd2Class.GetRightHandpos4());
        gulvClass.SetLeftHandAngle1(uLyd2Class.GetLeftHandAngle1());
        gulvClass.SetLeftHandAngle2(uLyd2Class.GetLeftHandAngle2());
        gulvClass.SetLeftHandAngle3(uLyd2Class.GetLeftHandAngle3());
        gulvClass.SetLeftHandAngle4(uLyd2Class.GetLeftHandAngle4());
        gulvClass.SetRightHandAngle1(uLyd2Class.GetRightHandAngle1());
        gulvClass.SetRightHandAngle2(uLyd2Class.GetRightHandAngle2());
        gulvClass.SetRightHandAngle3(uLyd2Class.GetRightHandAngle3());
        gulvClass.SetRightHandAngle4(uLyd2Class.GetRightHandAngle4());

        // V lyd 1 

        vinVClass = new PicturePhonemeClass(vinV);
        vinVClass.SetImageName("vin");
        vinVClass.SetAssignment("Hvad er den første lyd");
        vinVClass.SetAssignmentLetter("v");
        vinVClass.SetNoOfPos(2);
        vinVClass.SetEnableLeftHand(true);
        vinVClass.SetEnableRightHand(true);
        vinVClass.SetPos1ReadyToHit(true);
        vinVClass.SetPos2ReadyToHit(true);
        vinVClass.SetLeftHandPos1(vLyd1Class.GetLeftHandpos1());
        vinVClass.SetLeftHandPos2(vLyd1Class.GetLeftHandpos2());
        vinVClass.SetRightHandPos1(vLyd1Class.GetRightHandpos1());
        vinVClass.SetRightHandPos2(vLyd1Class.GetRightHandpos2());
        vinVClass.SetLeftHandAngle1(vLyd1Class.GetLeftHandAngle1());
        vinVClass.SetLeftHandAngle2(vLyd1Class.GetLeftHandAngle2());
        vinVClass.SetRightHandAngle1(vLyd1Class.GetRightHandAngle1());
        vinVClass.SetRightHandAngle2(vLyd1Class.GetRightHandAngle2());

        vestVClass = new PicturePhonemeClass(vestV);
        vestVClass.SetImageName("vest");
        vestVClass.SetAssignment("Hvad er den første lyd");
        vestVClass.SetAssignmentLetter("v");
        vestVClass.SetNoOfPos(2);
        vestVClass.SetEnableLeftHand(true);
        vestVClass.SetEnableRightHand(true);
        vestVClass.SetPos1ReadyToHit(true);
        vestVClass.SetPos2ReadyToHit(true);
        vestVClass.SetLeftHandPos1(vLyd1Class.GetLeftHandpos1());
        vestVClass.SetLeftHandPos2(vLyd1Class.GetLeftHandpos2());
        vestVClass.SetRightHandPos1(vLyd1Class.GetRightHandpos1());
        vestVClass.SetRightHandPos2(vLyd1Class.GetRightHandpos2());
        vestVClass.SetLeftHandAngle1(vLyd1Class.GetLeftHandAngle1());
        vestVClass.SetLeftHandAngle2(vLyd1Class.GetLeftHandAngle2());
        vestVClass.SetRightHandAngle1(vLyd1Class.GetRightHandAngle1());
        vestVClass.SetRightHandAngle2(vLyd1Class.GetRightHandAngle2());

        loeveClass = new PicturePhonemeClass(loeve);
        loeveClass.SetImageName("loeve");
        loeveClass.SetAssignment("Hvad er den sidste konsonant i ordet");
        loeveClass.SetAssignmentLetter("v");
        loeveClass.SetNoOfPos(2);
        loeveClass.SetEnableLeftHand(true);
        loeveClass.SetEnableRightHand(true);
        loeveClass.SetPos1ReadyToHit(true);
        loeveClass.SetPos2ReadyToHit(true);
        loeveClass.SetLeftHandPos1(vLyd1Class.GetLeftHandpos1());
        loeveClass.SetLeftHandPos2(vLyd1Class.GetLeftHandpos2());
        loeveClass.SetRightHandPos1(vLyd1Class.GetRightHandpos1());
        loeveClass.SetRightHandPos2(vLyd1Class.GetRightHandpos2());
        loeveClass.SetLeftHandAngle1(vLyd1Class.GetLeftHandAngle1());
        loeveClass.SetLeftHandAngle2(vLyd1Class.GetLeftHandAngle2());
        loeveClass.SetRightHandAngle1(vLyd1Class.GetRightHandAngle1());
        loeveClass.SetRightHandAngle2(vLyd1Class.GetRightHandAngle2());

        riveClass = new PicturePhonemeClass(rive);
        riveClass.SetImageName("rive");
        riveClass.SetAssignment("Hvad er den sidste konsonant i ordet");
        riveClass.SetAssignmentLetter("v");
        riveClass.SetNoOfPos(2);
        riveClass.SetEnableLeftHand(true);
        riveClass.SetEnableRightHand(true);
        riveClass.SetPos1ReadyToHit(true);
        riveClass.SetPos2ReadyToHit(true);
        riveClass.SetLeftHandPos1(vLyd1Class.GetLeftHandpos1());
        riveClass.SetLeftHandPos2(vLyd1Class.GetLeftHandpos2());
        riveClass.SetRightHandPos1(vLyd1Class.GetRightHandpos1());
        riveClass.SetRightHandPos2(vLyd1Class.GetRightHandpos2());
        riveClass.SetLeftHandAngle1(vLyd1Class.GetLeftHandAngle1());
        riveClass.SetLeftHandAngle2(vLyd1Class.GetLeftHandAngle2());
        riveClass.SetRightHandAngle1(vLyd1Class.GetRightHandAngle1());
        riveClass.SetRightHandAngle2(vLyd1Class.GetRightHandAngle2());

        // V lyd to 

        havClass = new PicturePhonemeClass(hav);
        havClass.SetImageName("hav");
        havClass.SetAssignment("Hvad er den sidste lyd");
        havClass.SetAssignmentLetter("v");
        havClass.SetNoOfPos(4);
        havClass.SetEnableLeftHand(true);
        havClass.SetEnableRightHand(true);
        havClass.SetPos1ReadyToHit(true);
        havClass.SetPos2ReadyToHit(true);
        havClass.SetPos3ReadyToHit(true);
        havClass.SetPos4ReadyToHit(true);
        havClass.SetLeftHandPos1(vLyd2Class.GetLeftHandpos1());
        havClass.SetLeftHandPos2(vLyd2Class.GetLeftHandpos2());
        havClass.SetLeftHandPos3(vLyd2Class.GetLeftHandpos3());
        havClass.SetLeftHandPos4(vLyd2Class.GetLeftHandpos4());
        havClass.SetRightHandPos1(vLyd2Class.GetRightHandpos1());
        havClass.SetRightHandPos2(vLyd2Class.GetRightHandpos2());
        havClass.SetRightHandPos3(vLyd2Class.GetRightHandpos3());
        havClass.SetRightHandPos4(vLyd2Class.GetRightHandpos4());
        havClass.SetLeftHandAngle1(vLyd2Class.GetLeftHandAngle1());
        havClass.SetLeftHandAngle2(vLyd2Class.GetLeftHandAngle2());
        havClass.SetLeftHandAngle3(vLyd2Class.GetLeftHandAngle3());
        havClass.SetLeftHandAngle4(vLyd2Class.GetLeftHandAngle4());
        havClass.SetRightHandAngle1(vLyd2Class.GetRightHandAngle1());
        havClass.SetRightHandAngle2(vLyd2Class.GetRightHandAngle2());
        havClass.SetRightHandAngle3(vLyd2Class.GetRightHandAngle3());
        havClass.SetRightHandAngle4(vLyd2Class.GetRightHandAngle4());

        savClass = new PicturePhonemeClass(sav);
        savClass.SetImageName("sav");
        savClass.SetAssignment("Hvad er den sidste lyd");
        savClass.SetAssignmentLetter("v");
        savClass.SetNoOfPos(4);
        savClass.SetEnableLeftHand(true);
        savClass.SetEnableRightHand(true);
        savClass.SetPos1ReadyToHit(true);
        savClass.SetPos2ReadyToHit(true);
        savClass.SetPos3ReadyToHit(true);
        savClass.SetPos4ReadyToHit(true);
        savClass.SetLeftHandPos1(vLyd2Class.GetLeftHandpos1());
        savClass.SetLeftHandPos2(vLyd2Class.GetLeftHandpos2());
        savClass.SetLeftHandPos3(vLyd2Class.GetLeftHandpos3());
        savClass.SetLeftHandPos4(vLyd2Class.GetLeftHandpos4());
        savClass.SetRightHandPos1(vLyd2Class.GetRightHandpos1());
        savClass.SetRightHandPos2(vLyd2Class.GetRightHandpos2());
        savClass.SetRightHandPos3(vLyd2Class.GetRightHandpos3());
        savClass.SetRightHandPos4(vLyd2Class.GetRightHandpos4());
        savClass.SetLeftHandAngle1(vLyd2Class.GetLeftHandAngle1());
        savClass.SetLeftHandAngle2(vLyd2Class.GetLeftHandAngle2());
        savClass.SetLeftHandAngle3(vLyd2Class.GetLeftHandAngle3());
        savClass.SetLeftHandAngle4(vLyd2Class.GetLeftHandAngle4());
        savClass.SetRightHandAngle1(vLyd2Class.GetRightHandAngle1());
        savClass.SetRightHandAngle2(vLyd2Class.GetRightHandAngle2());
        savClass.SetRightHandAngle3(vLyd2Class.GetRightHandAngle3());
        savClass.SetRightHandAngle4(vLyd2Class.GetRightHandAngle4());

        raevClass = new PicturePhonemeClass(raev);
        raevClass.SetImageName("raev");
        raevClass.SetAssignment("Hvad er den sidste lyd");
        raevClass.SetAssignmentLetter("v");
        raevClass.SetNoOfPos(4);
        raevClass.SetEnableLeftHand(true);
        raevClass.SetEnableRightHand(true);
        raevClass.SetPos1ReadyToHit(true);
        raevClass.SetPos2ReadyToHit(true);
        raevClass.SetPos3ReadyToHit(true);
        raevClass.SetPos4ReadyToHit(true);
        raevClass.SetLeftHandPos1(vLyd2Class.GetLeftHandpos1());
        raevClass.SetLeftHandPos2(vLyd2Class.GetLeftHandpos2());
        raevClass.SetLeftHandPos3(vLyd2Class.GetLeftHandpos3());
        raevClass.SetLeftHandPos4(vLyd2Class.GetLeftHandpos4());
        raevClass.SetRightHandPos1(vLyd2Class.GetRightHandpos1());
        raevClass.SetRightHandPos2(vLyd2Class.GetRightHandpos2());
        raevClass.SetRightHandPos3(vLyd2Class.GetRightHandpos3());
        raevClass.SetRightHandPos4(vLyd2Class.GetRightHandpos4());
        raevClass.SetLeftHandAngle1(vLyd2Class.GetLeftHandAngle1());
        raevClass.SetLeftHandAngle2(vLyd2Class.GetLeftHandAngle2());
        raevClass.SetLeftHandAngle3(vLyd2Class.GetLeftHandAngle3());
        raevClass.SetLeftHandAngle4(vLyd2Class.GetLeftHandAngle4());
        raevClass.SetRightHandAngle1(vLyd2Class.GetRightHandAngle1());
        raevClass.SetRightHandAngle2(vLyd2Class.GetRightHandAngle2());
        raevClass.SetRightHandAngle3(vLyd2Class.GetRightHandAngle3());
        raevClass.SetRightHandAngle4(vLyd2Class.GetRightHandAngle4());

        skovClass = new PicturePhonemeClass(skov);
        skovClass.SetImageName("skov");
        skovClass.SetAssignment("Hvad er den sidste lyd");
        skovClass.SetAssignmentLetter("v");
        skovClass.SetNoOfPos(4);
        skovClass.SetEnableLeftHand(true);
        skovClass.SetEnableRightHand(true);
        skovClass.SetPos1ReadyToHit(true);
        skovClass.SetPos2ReadyToHit(true);
        skovClass.SetPos3ReadyToHit(true);
        skovClass.SetPos4ReadyToHit(true);
        skovClass.SetLeftHandPos1(vLyd2Class.GetLeftHandpos1());
        skovClass.SetLeftHandPos2(vLyd2Class.GetLeftHandpos2());
        skovClass.SetLeftHandPos3(vLyd2Class.GetLeftHandpos3());
        skovClass.SetLeftHandPos4(vLyd2Class.GetLeftHandpos4());
        skovClass.SetRightHandPos1(vLyd2Class.GetRightHandpos1());
        skovClass.SetRightHandPos2(vLyd2Class.GetRightHandpos2());
        skovClass.SetRightHandPos3(vLyd2Class.GetRightHandpos3());
        skovClass.SetRightHandPos4(vLyd2Class.GetRightHandpos4());
        skovClass.SetLeftHandAngle1(vLyd2Class.GetLeftHandAngle1());
        skovClass.SetLeftHandAngle2(vLyd2Class.GetLeftHandAngle2());
        skovClass.SetLeftHandAngle3(vLyd2Class.GetLeftHandAngle3());
        skovClass.SetLeftHandAngle4(vLyd2Class.GetLeftHandAngle4());
        skovClass.SetRightHandAngle1(vLyd2Class.GetRightHandAngle1());
        skovClass.SetRightHandAngle2(vLyd2Class.GetRightHandAngle2());
        skovClass.SetRightHandAngle3(vLyd2Class.GetRightHandAngle3());
        skovClass.SetRightHandAngle4(vLyd2Class.GetRightHandAngle4());


        // Y lyd
        skyClass = new PicturePhonemeClass(sky);
        skyClass.SetImageName("sky");
        skyClass.SetAssignment("Hvad er den sidste lyd i ordet");
        skyClass.SetAssignmentLetter("y");
        skyClass.SetNoOfPos(1);
        skyClass.SetEnableRightHand(true);
        skyClass.SetEnableLeftHand(true);
        skyClass.SetPos1ReadyToHit(true);
        skyClass.SetLeftHandPos1(yClass.GetLeftHandpos1());
        skyClass.SetLeftHandAngle1(yClass.GetLeftHandAngle1());
        skyClass.SetRightHandPos1(yClass.GetRightHandpos1());
        skyClass.SetRightHandAngle1(yClass.GetRightHandAngle1());

        nysClass = new PicturePhonemeClass(nys);
        nysClass.SetImageName("nys");
        nysClass.SetAssignment("Hvad er den midterste lyd i ordet");
        nysClass.SetAssignmentLetter("y");
        nysClass.SetNoOfPos(1);
        nysClass.SetEnableRightHand(true);
        nysClass.SetEnableLeftHand(true);
        nysClass.SetPos1ReadyToHit(true);
        nysClass.SetLeftHandPos1(yClass.GetLeftHandpos1());
        nysClass.SetLeftHandAngle1(yClass.GetLeftHandAngle1());
        nysClass.SetRightHandPos1(yClass.GetRightHandpos1());
        nysClass.SetRightHandAngle1(yClass.GetRightHandAngle1());

        yverClass = new PicturePhonemeClass(yver);
        yverClass.SetImageName("yver");
        yverClass.SetAssignment("Hvad er den første lyd i ordet");
        yverClass.SetAssignmentLetter("y");
        yverClass.SetNoOfPos(1);
        yverClass.SetEnableRightHand(true);
        yverClass.SetEnableLeftHand(true);
        yverClass.SetPos1ReadyToHit(true);
        yverClass.SetLeftHandPos1(yClass.GetLeftHandpos1());
        yverClass.SetLeftHandAngle1(yClass.GetLeftHandAngle1());
        yverClass.SetRightHandPos1(yClass.GetRightHandpos1());
        yverClass.SetRightHandAngle1(yClass.GetRightHandAngle1());

        flyClass = new PicturePhonemeClass(fly);
        flyClass.SetImageName("fly");
        flyClass.SetAssignment("Hvad er den sidste lyd i ordet");
        flyClass.SetAssignmentLetter("y");
        flyClass.SetNoOfPos(1);
        flyClass.SetEnableRightHand(true);
        flyClass.SetEnableLeftHand(true);
        flyClass.SetPos1ReadyToHit(true);
        flyClass.SetLeftHandPos1(yClass.GetLeftHandpos1());
        flyClass.SetLeftHandAngle1(yClass.GetLeftHandAngle1());
        flyClass.SetRightHandPos1(yClass.GetRightHandpos1());
        flyClass.SetRightHandAngle1(yClass.GetRightHandAngle1());

        byClass = new PicturePhonemeClass(by);
        byClass.SetImageName("by");
        byClass.SetAssignment("Hvad er den sidste lyd i ordet");
        byClass.SetAssignmentLetter("y");
        byClass.SetNoOfPos(1);
        byClass.SetEnableRightHand(true);
        byClass.SetEnableLeftHand(true);
        byClass.SetPos1ReadyToHit(true);
        byClass.SetLeftHandPos1(yClass.GetLeftHandpos1());
        byClass.SetLeftHandAngle1(yClass.GetLeftHandAngle1());
        byClass.SetRightHandPos1(yClass.GetRightHandpos1());
        byClass.SetRightHandAngle1(yClass.GetRightHandAngle1());

        // ø lyd
        boefClass = new PicturePhonemeClass(boef);
        boefClass.SetImageName("bøf");
        boefClass.SetAssignment("Hvad er den midterste lyd i ordet");
        boefClass.SetAssignmentLetter("ø");
        boefClass.SetNoOfPos(1);
        boefClass.SetEnableRightHand(true);
        boefClass.SetEnableLeftHand(true);
        boefClass.SetPos1ReadyToHit(true);
        boefClass.SetLeftHandPos1(øClass.GetLeftHandpos1());
        boefClass.SetLeftHandAngle1(øClass.GetLeftHandAngle1());
        boefClass.SetRightHandPos1(øClass.GetRightHandpos1());
        boefClass.SetRightHandAngle1(øClass.GetRightHandAngle1());

        broedClass = new PicturePhonemeClass(broed);
        broedClass.SetImageName("brød");
        broedClass.SetAssignment("Hvad er den første vokal lyd");
        broedClass.SetAssignmentLetter("ø");
        broedClass.SetNoOfPos(1);
        broedClass.SetEnableRightHand(true);
        broedClass.SetEnableLeftHand(true);
        broedClass.SetPos1ReadyToHit(true);
        broedClass.SetLeftHandPos1(øClass.GetLeftHandpos1());
        broedClass.SetLeftHandAngle1(øClass.GetLeftHandAngle1());
        broedClass.SetRightHandPos1(øClass.GetRightHandpos1());
        broedClass.SetRightHandAngle1(øClass.GetRightHandAngle1());

        noegleClass = new PicturePhonemeClass(noegle);
         noegleClass.SetImageName("nøgle");
         noegleClass.SetAssignment("Hvad er den første vokal lyd");
         noegleClass.SetAssignmentLetter("ø");
         noegleClass.SetNoOfPos(1);
         noegleClass.SetEnableRightHand(true);
         noegleClass.SetEnableLeftHand(true);
         noegleClass.SetPos1ReadyToHit(true);
         noegleClass.SetLeftHandPos1(øClass.GetLeftHandpos1());
         noegleClass.SetLeftHandAngle1(øClass.GetLeftHandAngle1());
         noegleClass.SetRightHandPos1(øClass.GetRightHandpos1());
         noegleClass.SetRightHandAngle1(øClass.GetRightHandAngle1());

        oernClass = new PicturePhonemeClass(oern);
       oernClass.SetImageName("ørn");
       oernClass.SetAssignment("Hvad er den første lyd");
       oernClass.SetAssignmentLetter("ø");
       oernClass.SetNoOfPos(1);
       oernClass.SetEnableRightHand(true);
       oernClass.SetEnableLeftHand(true);
       oernClass.SetPos1ReadyToHit(true);
       oernClass.SetLeftHandPos1(øClass.GetLeftHandpos1());
       oernClass.SetLeftHandAngle1(øClass.GetLeftHandAngle1());
       oernClass.SetRightHandPos1(øClass.GetRightHandpos1());
       oernClass.SetRightHandAngle1(øClass.GetRightHandAngle1());

        oereClass = new PicturePhonemeClass(oere);
       oereClass.SetImageName("øre");
       oereClass.SetAssignment("Hvad er den første vokal lyd");
       oereClass.SetAssignmentLetter("ø");
       oereClass.SetNoOfPos(1);
       oereClass.SetEnableRightHand(true);
       oereClass.SetEnableLeftHand(true);
       oereClass.SetPos1ReadyToHit(true);
       oereClass.SetLeftHandPos1(øClass.GetLeftHandpos1());
       oereClass.SetLeftHandAngle1(øClass.GetLeftHandAngle1());
       oereClass.SetRightHandPos1(øClass.GetRightHandpos1());
       oereClass.SetRightHandAngle1(øClass.GetRightHandAngle1());



        //å lyd et
        aalClass = new PicturePhonemeClass(aal);
        aalClass.SetImageName("aal");
        aalClass.SetAssignment("Hvad er den første lyd i ordet");
        aalClass.SetAssignmentLetter("å");
        aalClass.SetNoOfPos(4);
        aalClass.SetEnableLeftHand(true);
        aalClass.SetEnableRightHand(true);
        aalClass.SetPos1ReadyToHit(true);
        aalClass.SetPos2ReadyToHit(true);
        aalClass.SetPos3ReadyToHit(true);
        aalClass.SetPos4ReadyToHit(true);
        aalClass.SetLeftHandPos1(åClass.GetLeftHandpos1());
        aalClass.SetLeftHandPos2(åClass.GetLeftHandpos2());
        aalClass.SetLeftHandPos3(åClass.GetLeftHandpos3());
        aalClass.SetLeftHandPos4(åClass.GetLeftHandpos4());
        aalClass.SetRightHandPos1(åClass.GetRightHandpos1());
        aalClass.SetRightHandPos2(åClass.GetRightHandpos2());
        aalClass.SetRightHandPos3(åClass.GetRightHandpos3());
        aalClass.SetRightHandPos4(åClass.GetRightHandpos4());
        aalClass.SetLeftHandAngle1(åClass.GetLeftHandAngle1());
        aalClass.SetLeftHandAngle2(åClass.GetLeftHandAngle2());
        aalClass.SetLeftHandAngle3(aClass.GetLeftHandAngle3());
        aalClass.SetLeftHandAngle4(åClass.GetLeftHandAngle4());
        aalClass.SetRightHandAngle1(åClass.GetRightHandAngle1());
        aalClass.SetRightHandAngle2(åClass.GetRightHandAngle2());
        aalClass.SetRightHandAngle3(aClass.GetRightHandAngle3());
        aalClass.SetRightHandAngle4(åClass.GetRightHandAngle4());

        //å lyd et
        gaasClass = new PicturePhonemeClass(gaas);
        gaasClass.SetImageName("gaas");
        gaasClass.SetAssignment("Hvad er den midterste lyd i ordet");
        gaasClass.SetAssignmentLetter("å");
        gaasClass.SetNoOfPos(4);
        gaasClass.SetEnableLeftHand(true);
        gaasClass.SetEnableRightHand(true);
        gaasClass.SetPos1ReadyToHit(true);
        gaasClass.SetPos2ReadyToHit(true);
        gaasClass.SetPos3ReadyToHit(true);
        gaasClass.SetPos4ReadyToHit(true);
        gaasClass.SetLeftHandPos1(åClass.GetLeftHandpos1());
        gaasClass.SetLeftHandPos2(åClass.GetLeftHandpos2());
        gaasClass.SetLeftHandPos3(åClass.GetLeftHandpos3());
        gaasClass.SetLeftHandPos4(åClass.GetLeftHandpos4());
        gaasClass.SetRightHandPos1(åClass.GetRightHandpos1());
        gaasClass.SetRightHandPos2(åClass.GetRightHandpos2());
        gaasClass.SetRightHandPos3(åClass.GetRightHandpos3());
        gaasClass.SetRightHandPos4(åClass.GetRightHandpos4());
        gaasClass.SetLeftHandAngle1(åClass.GetLeftHandAngle1());
        gaasClass.SetLeftHandAngle2(åClass.GetLeftHandAngle2());
        gaasClass.SetLeftHandAngle3(aClass.GetLeftHandAngle3());
        gaasClass.SetLeftHandAngle4(åClass.GetLeftHandAngle4());
        gaasClass.SetRightHandAngle1(åClass.GetRightHandAngle1());
        gaasClass.SetRightHandAngle2(åClass.GetRightHandAngle2());
        gaasClass.SetRightHandAngle3(aClass.GetRightHandAngle3());
        gaasClass.SetRightHandAngle4(åClass.GetRightHandAngle4());


        //All Letters
        picturePhonemeList.Add(bamseClass);
        picturePhonemeList.Add(egernClass);
        picturePhonemeList.Add(feClass);
        picturePhonemeList.Add(daaseClass);
        picturePhonemeList.Add(aebleClass);
        picturePhonemeList.Add(gaasClass);
        picturePhonemeList.Add(laasClass);
        picturePhonemeList.Add(leClass);
        picturePhonemeList.Add(stopClass);
        picturePhonemeList.Add(svampClass);
        picturePhonemeList.Add(vestClass);
        picturePhonemeList.Add(aalClass);

        picturePhonemeList.Add(skoOClass);
        picturePhonemeList.Add(koOClass);
        picturePhonemeList.Add(solClass);
        picturePhonemeList.Add(toClass);
        picturePhonemeList.Add(ormClass);
        picturePhonemeList.Add(kanoClass);
        picturePhonemeList.Add(kopOClass);
        picturePhonemeList.Add(sokOClass);
        picturePhonemeList.Add(ostClass);
        picturePhonemeList.Add(otteClass);
        picturePhonemeList.Add(boldOClass);
        picturePhonemeList.Add(togClass);
        picturePhonemeList.Add(katClass);
        picturePhonemeList.Add(hatClass);
        picturePhonemeList.Add(troldClass);
        picturePhonemeList.Add(sutTClass);
        picturePhonemeList.Add(kageAClass);
        picturePhonemeList.Add(hatAClass);
        picturePhonemeList.Add(abeAClass);
        picturePhonemeList.Add(andClass);
        picturePhonemeList.Add(colaClass);
        picturePhonemeList.Add(karClass);
        picturePhonemeList.Add(markClass);
        picturePhonemeList.Add(kaffeClass);
        picturePhonemeList.Add(hareClass);
        picturePhonemeList.Add(girafClass);
        picturePhonemeList.Add(kageKClass);
        picturePhonemeList.Add(kopKClass);
        picturePhonemeList.Add(sokKClass);
        picturePhonemeList.Add(koKClass);
        picturePhonemeList.Add(skoKClass);
        picturePhonemeList.Add(boldBClass);
        picturePhonemeList.Add(abeBClass);
        picturePhonemeList.Add(skabClass);
        picturePhonemeList.Add(skibClass);
        picturePhonemeList.Add(busBClass);
        picturePhonemeList.Add(busUClass);
        picturePhonemeList.Add(ugleClass);
        picturePhonemeList.Add(murUClass);
        picturePhonemeList.Add(urClass);
        picturePhonemeList.Add(sutUClass);
        picturePhonemeList.Add(frugtClass);
        picturePhonemeList.Add(vuggeClass);
        picturePhonemeList.Add(dukkeClass);
        picturePhonemeList.Add(nulClass);
        picturePhonemeList.Add(gulvClass);
        picturePhonemeList.Add(musClass);
        picturePhonemeList.Add(murMClass);
        picturePhonemeList.Add(femClass);
        picturePhonemeList.Add(kamClass);
        picturePhonemeList.Add(kamelClass);
        picturePhonemeList.Add(vinClass);
        picturePhonemeList.Add(tiClass);
        picturePhonemeList.Add(nisseClass);
        picturePhonemeList.Add(isbjoernClass);
        picturePhonemeList.Add(igloClass);
        picturePhonemeList.Add(girafIClass);
        picturePhonemeList.Add(girafRClass);
        picturePhonemeList.Add(hareRClass);
        picturePhonemeList.Add(oereRClass);
        picturePhonemeList.Add(raketClass);
        picturePhonemeList.Add(roseClass);
        picturePhonemeList.Add(aenderClass);
        picturePhonemeList.Add(bilerClass);
        picturePhonemeList.Add(saelerClass);
        picturePhonemeList.Add(loeverClass);
        picturePhonemeList.Add(haneClass);
        picturePhonemeList.Add(delfinClass);
        picturePhonemeList.Add(kaneClass);
        picturePhonemeList.Add(naaleClass);
        picturePhonemeList.Add(netClass);

        picturePhonemeList.Add(doerClass);
        picturePhonemeList.Add(boldDClass);
        picturePhonemeList.Add(daaseClass);
        picturePhonemeList.Add(drageClass);
        picturePhonemeList.Add(badClass);
        picturePhonemeList.Add(baadClass);
        picturePhonemeList.Add(gladClass);
        picturePhonemeList.Add(kaedeClass);
        picturePhonemeList.Add(ladeClass);
        picturePhonemeList.Add(skyClass);
        picturePhonemeList.Add(nysClass);
        picturePhonemeList.Add(yverClass);
        picturePhonemeList.Add(flyClass);
        picturePhonemeList.Add(byClass);
        picturePhonemeList.Add(vinVClass);
        picturePhonemeList.Add(vestVClass);
        picturePhonemeList.Add(loeveClass);
        picturePhonemeList.Add(riveClass);
        picturePhonemeList.Add(havClass);
        picturePhonemeList.Add(savClass);
        picturePhonemeList.Add(raevClass);
        picturePhonemeList.Add(skovClass);
        picturePhonemeList.Add(boefClass);
        picturePhonemeList.Add(broedClass);
        picturePhonemeList.Add(noegleClass);
        picturePhonemeList.Add(oernClass);
        picturePhonemeList.Add(oereClass);
        picturePhonemeList.Add(aegClass);
        picturePhonemeList.Add(gedClass);
        picturePhonemeList.Add(girafGClass);
        picturePhonemeList.Add(grisClass);
        picturePhonemeList.Add(vaegClass);
    }
}
