using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;

public class AddPoints : MonoBehaviour
{
    public TextMeshProUGUI Pointer;
    public float points;
    public float clickpoints;
    public TextMeshProUGUI butonclickpoints;
    public float timepass = 0.0f;
    public float tmpass = 0.0f;
    public float pointspersec;
    public float multiPT;

    public Sprite[] TunI;
    public Sprite[] FondT;
    public float tun;
    public int TUN;
    public TextMeshProUGUI tunT;
    public TextMeshProUGUI tunTx;
    public float tunP;
    public Button tunb;
    public int tunIn;
    public int tunFn;
    public Image tuni;
    public Image Tunf;

    public Sprite[] FondL;
    public float lib;
    public int LIB;
    public TextMeshProUGUI libT;
    public TextMeshProUGUI libTx;
    public float libP;
    public Button libb;
    public Image libf;

    public Sprite[] FondP;
    public float per;
    public int PER;
    public TextMeshProUGUI perT;
    public TextMeshProUGUI perTx;
    public float perP;
    public Button perb;
    public Image perf;

    public float pdh;
    public int PDH;
    public TextMeshProUGUI PdhT;
    public TextMeshProUGUI PdhTx;
    public float PdhP;
    public Button pdhb;

    public float ajo;
    public int AJO;
    public TextMeshProUGUI AjoT;
    public TextMeshProUGUI AjoTx;
    public float AjoP;
    public Button ajob;

    public float hgr;
    public int HGR;
    public TextMeshProUGUI HgrT;
    public TextMeshProUGUI HgrTx;
    public float HgrP;
    public Button hgrb;

    public float trg;
    public int TRG;
    public TextMeshProUGUI TrgT;
    public TextMeshProUGUI TrgTx;
    public float TrgP;
    public Button trgb;

    public float hgv;
    public int HGV;
    public TextMeshProUGUI HgvT;
    public TextMeshProUGUI HgvTx;
    public float HgvP;
    public Button hgvb;

    public float lvd;
    public int LVD;
    public TextMeshProUGUI LvdT;
    public TextMeshProUGUI LvdTx;
    public float LvdP;
    public Button lvdb;

    public float sdf;
    public int SDF;
    public TextMeshProUGUI SdfT;
    public TextMeshProUGUI SdfTx;
    public float SdfP;
    public Button sdfb;

    public float hga;
    public int HGA;
    public TextMeshProUGUI HgaT;
    public TextMeshProUGUI HgaTx;
    public float HgaP;
    public Button hgab;

    public float sde;
    public int SDE;
    public TextMeshProUGUI SdeT;
    public TextMeshProUGUI SdeTx;
    public float SdeP;
    public Button sdeb;

    public float hgm;
    public int HGM;
    public TextMeshProUGUI HgmT;
    public TextMeshProUGUI HgmTx;
    public float HgmP;
    public Button hgmb;

    public float sdv;
    public int SDV;
    public TextMeshProUGUI SdvT;
    public TextMeshProUGUI SdvTx;
    public float SdvP;
    public Button sdvb;

    public float rdt;
    public int RDT;
    public TextMeshProUGUI RdtT;
    public TextMeshProUGUI RdtTx;
    public float RdtP;
    public Button rdtb;

    public float pdv;
    public int PDV;
    public TextMeshProUGUI PdvT;
    public TextMeshProUGUI PdvTx;
    public float PdvP;
    public Button pdvb;

    public float rdn;
    public int RDN;
    public TextMeshProUGUI RdnT;
    public TextMeshProUGUI RdnTx;
    public float RdnP;
    public Button rdnb;

    public float edd;
    public int EDD;
    public TextMeshProUGUI EddT;
    public TextMeshProUGUI EddTx;
    public float EddP;
    public Button eddb;

    public float rnc;
    public int RNC;
    public TextMeshProUGUI RncT;
    public TextMeshProUGUI RncTx;
    public float RncP;
    public Button rncb;

    public float gra;
    public int GRA;
    public TextMeshProUGUI GraT;
    public TextMeshProUGUI GraTx;
    public float GraP;
    public Button grab;

    public float com;
    public int COM;
    public TextMeshProUGUI ComT;
    public TextMeshProUGUI ComTx;
    public float ComP;
    public Button Comb;

    public float gua;
    public int GUA;
    public TextMeshProUGUI GuaT;
    public TextMeshProUGUI GuaTx;
    public float GuaP;
    public Button Guab;

    public float mag;
    public int MAG;
    public TextMeshProUGUI MagT;
    public TextMeshProUGUI MagTx;
    public float MagP;
    public Button Magb;

    public float esq;
    public int ESQ;
    public TextMeshProUGUI EsqT;
    public TextMeshProUGUI EsqTx;
    public float EsqP;
    public Button Esqb;

    public float md;
    public int MD;
    public TextMeshProUGUI MdT;
    public TextMeshProUGUI MdTx;
    public float MdP;
    public Button Mdb;

    public float dvk;
    public int DVK;
    public TextMeshProUGUI DvkT;
    public TextMeshProUGUI DvkTx;
    public float DvkP;
    public Button Dvkb;

    public float pbl;
    public int PBL;
    public TextMeshProUGUI PblT;
    public TextMeshProUGUI PblTx;
    public float PblP;
    public Button Pblb;

    public float prj;
    public int PRJ;
    public TextMeshProUGUI PrjT;
    public TextMeshProUGUI PrjTx;
    public float PrjP;
    public Button Prjb;

    public float paz;
    public int PAZ;
    public TextMeshProUGUI PazT;
    public TextMeshProUGUI PazTx;
    public float PazP;
    public Button Pazb;

    public float pve;
    public int PVE;
    public TextMeshProUGUI PveT;
    public TextMeshProUGUI PveTx;
    public float PveP;
    public Button Pveb;

    public float pam;
    public int PAM;
    public TextMeshProUGUI PamT;
    public TextMeshProUGUI PamTx;
    public float PamP;
    public Button Pamb;

    public float prs;
    public int PRS;
    public TextMeshProUGUI PrsT;
    public TextMeshProUGUI PrsTx;
    public float PrsP;
    public Button Prsb;

    public float pma;
    public int PMA;
    public TextMeshProUGUI PmaT;
    public TextMeshProUGUI PmaTx;
    public float PmaP;
    public Button Pmab;

    public float pna;
    public int PNA;
    public TextMeshProUGUI PnaT;
    public TextMeshProUGUI PnaTx;
    public float PnaP;
    public Button Pnab;

    public float pmo;
    public int PMO;
    public TextMeshProUGUI PmoT;
    public TextMeshProUGUI PmoTx;
    public float PmoP;
    public Button Pmob;

    public float pva;
    public int PVA;
    public TextMeshProUGUI PvaT;
    public TextMeshProUGUI PvaTx;
    public float PvaP;
    public Button Pvab;

    SavePoints SaveP;
    string rute;

    public GameObject pause;

    public DateTime exitTime;
    public DateTime enterTime;
    public double secondsPassed;

    public TextMeshProUGUI texto;
    public int num;

    public int year;
    public int month;
    public int day;
    public int hour;
    public int minute;
    public int second;
    public int Y;
    public int M;
    public int D;
    public int h;
    public int m;
    public int s;
    public int DpY;
    public int DpM;
    public int hpY;
    public int mpY;
    public int spY;

    // Start is called before the first frame update
    void Start()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, "AlchemyData.json");

        if (File.Exists(filePath))
        {
            rute = Application.streamingAssetsPath + "/AlchemyData.json";
            string json = System.IO.File.ReadAllText(rute);
            SaveP = JsonUtility.FromJson<SavePoints>(json);

            points = (SaveP.TTpoints);
            pointspersec = (SaveP.PPsec);
            clickpoints = (SaveP.ClickP);
            Y = (SaveP.year);
            M = (SaveP.month);
            D = (SaveP.day);
            h = (SaveP.hour);
            m = (SaveP.minute);
            s = (SaveP.second);
            PDH = (SaveP.PDH);
            AJO = (SaveP.AJO);
            HGR = (SaveP.HGR);
            TRG = (SaveP.TRG);
            HGV = (SaveP.HGV);
            LVD = (SaveP.LVD);
            SDF = (SaveP.SDF);
            HGA = (SaveP.HGA);
            SDE = (SaveP.SDE);
            HGM = (SaveP.HGM);
            SDV = (SaveP.SDV);
            RDT = (SaveP.RDT);
            PDV = (SaveP.PDV);
            RDN = (SaveP.RDN);
            EDD = (SaveP.EDD);
            RNC = (SaveP.RNC);
            GRA = (SaveP.GRA);
            COM = (SaveP.COM);
            GUA = (SaveP.GUA);
            MAG = (SaveP.MAG);
            ESQ = (SaveP.ESQ);
            MD = (SaveP.MD);
            DVK = (SaveP.DVK);
            PBL = (SaveP.PBL);
            PRJ = (SaveP.PRJ);
            PAZ = (SaveP.PAZ);
            PVE = (SaveP.PVE);
            PAM = (SaveP.PAM);
            PRS = (SaveP.PRS);
            PMA = (SaveP.PMA);
            PNA = (SaveP.PNA);
            PMO = (SaveP.PMO);
            PVA = (SaveP.PVA);
            TUN = (SaveP.TUN);
            tunFn = (SaveP.tunFn);
            tunIn = (SaveP.tunIn);
            LIB = (SaveP.LIB);
            PER = (SaveP.PER);
            
            if (TUN == 60)
            {
                Tunf.sprite = FondT[9];
            }
            else
            {
                Tunf.sprite = FondT[tunFn];
            }
            
            if (TUN == 60)
            {
                tuni.sprite = TunI[5];
            }
            else
            {
                tuni.sprite = TunI[tunIn];
            }
            
            if (LIB == 10)
            {
                libf.sprite = FondL[9];
            }
            else
            {
                libf.sprite = FondL[LIB];
            }
            
            if (PER == 10)
            {
                perf.sprite = FondP[9];
            }
            else
            {
                perf.sprite = FondP[PER];
            }

            Date();

            DpY = (year - Y) * 365;
            DpM = (month - M) * 30;
            hpY = (hour - h) + (((day - D) + DpM + DpY) * 24);
            mpY = ((minute - m) + (hpY * 60));
            spY = ((second - s) + (mpY * 60));

            Xsec();

            points = points + (pointspersec * spY);
            Pointer.text = points.ToString("#,##0.00") + "\n" + pointspersec + "PPS";

            Xsec();
        }
        else
        {
            points = 0.0f;
            pointspersec = 0.0f;
            clickpoints = 1.0f;
            PDH = 0;
            AJO = 0;
            HGR = 0;
            TRG = 0;
            HGV = 0;
            LVD = 0;
            SDF = 0;
            HGA = 0;
            SDE = 0;
            HGM = 0;
            SDV = 0;
            RDT = 0;
            PDV = 0;
            RDN = 0;
            EDD = 0;
            RNC = 0;
            GRA = 0;
            COM = 0;
            GUA = 0;
            MAG = 0;
            ESQ = 0;
            MD = 0;
            DVK = 0;
            PBL = 0;
            PRJ = 0;
            PAZ = 0;
            PVE = 0;
            PAM = 0;
            PRS = 0;
            PMA = 0;
            PNA = 0;
            PMO = 0;
            PVA = 0;
            secondsPassed = 0;
            Xsec();
        }
        num = UnityEngine.Random.Range(0,38);
        frases();
    }

    void Update()
    {
        Xsec();
        timepass += Time.deltaTime;
        tmpass += Time.deltaTime;

        if (timepass >= 1.0f)
        {
            points = points + pointspersec;
            Pointer.text = points.ToString("#,##0.00") + "\n" + pointspersec + "PPS";
            timepass = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            buton();
        }

        buttonsactive();

        Save();

        num = UnityEngine.Random.Range(0,38);

        if (tmpass >= 10.0f)
        {
            frases();
            tmpass = 0.0f;
        }
    }

    public void buton()
    {
        points = points + clickpoints;
        Pointer.text = points.ToString("#,##0.00");
        
        Save();
    }

    public void buttonsactive() {
        if (points >= pdh)
        {
            pdhb.interactable = true;
        }
        else
        {
            pdhb.interactable = false;
        }

        if (points >= ajo)
        {
            ajob.interactable = true;
        }
        else
        {
            ajob.interactable = false;
        }

        if (points >= hgr)
        {
            hgrb.interactable = true;
        }
        else
        {
            hgrb.interactable = false;
        }

        if (points >= trg)
        {
            trgb.interactable = true;
        }
        else
        {
            trgb.interactable = false;
        }

        if (points >= hgv)
        {
            hgvb.interactable = true;
        }
        else
        {
            hgvb.interactable = false;
        }

        if (points >= lvd)
        {
            lvdb.interactable = true;
        }
        else
        {
            lvdb.interactable = false;
        }

        if (points >= sdf)
        {
            sdfb.interactable = true;
        }
        else
        {
            sdfb.interactable = false;
        }

        if (points >= hga)
        {
            hgab.interactable = true;
        }
        else
        {
            hgab.interactable = false;
        }

        if (points >= sde)
        {
            sdeb.interactable = true;
        }
        else
        {
            sdeb.interactable = false;
        }

        if (points >= hgm)
        {
            hgmb.interactable = true;
        }
        else
        {
            hgmb.interactable = false;
        }

        if (points >= sdv)
        {
            sdvb.interactable = true;
        }
        else
        {
            sdvb.interactable = false;
        }

        if (points >= rdt)
        {
            rdtb.interactable = true;
        }
        else
        {
            rdtb.interactable = false;
        }

        if (points >= pdv)
        {
            pdvb.interactable = true;
        }
        else
        {
            pdvb.interactable = false;
        }

        if (points >= rdn)
        {
            rdnb.interactable = true;
        }
        else
        {
            rdnb.interactable = false;
        }

        if (points >= edd)
        {
            eddb.interactable = true;
        }
        else
        {
            eddb.interactable = false;
        }

        if (points >= rnc)
        {
            rncb.interactable = true;
        }
        else
        {
            rncb.interactable = false;
        }

        if (points >= gra)
        {
            grab.interactable = true;
        }
        else
        {
            grab.interactable = false;
        }

        if (points >= com)
        {
            Comb.interactable = true;
        }
        else
        {
            Comb.interactable = false;
        }

        if (points >= gua)
        {
            Guab.interactable = true;
        }
        else
        {
            Guab.interactable = false;
        }

        if (points >= mag)
        {
            Magb.interactable = true;
        }
        else
        {
            Magb.interactable = false;
        }

        if (points >= esq)
        {
            Esqb.interactable = true;
        }
        else
        {
            Esqb.interactable = false;
        }

        if (points >= md)
        {
            Mdb.interactable = true;
        }
        else
        {
            Mdb.interactable = false;
        }

        if (points >= dvk)
        {
            Dvkb.interactable = true;
        }
        else
        {
            Dvkb.interactable = false;
        }

        if (points >= pbl)
        {
            Pblb.interactable = true;
        }
        else
        {
            Pblb.interactable = false;
        }

        if (points >= prj)
        {
            Prjb.interactable = true;
        }
        else
        {
            Prjb.interactable = false;
        }

        if (points >= paz)
        {
            Pazb.interactable = true;
        }
        else
        {
            Pazb.interactable = false;
        }

        if (points >= pve)
        {
            Pveb.interactable = true;
        }
        else
        {
            Pveb.interactable = false;
        }

        if (points >= pam)
        {
            Pamb.interactable = true;
        }
        else
        {
            Pamb.interactable = false;
        }

        if (points >= prs)
        {
            Prsb.interactable = true;
        }
        else
        {
            Prsb.interactable = false;
        }

        if (points >= pma)
        {
            Pmab.interactable = true;
        }
        else
        {
            Pmab.interactable = false;
        }

        if (points >= pna)
        {
            Pnab.interactable = true;
        }
        else
        {
            Pnab.interactable = false;
        }

        if (points >= pmo)
        {
            Pmob.interactable = true;
        }
        else
        {
            Pmob.interactable = false;
        }

        if (points >= pva)
        {
            Pvab.interactable = true;
        }
        else
        {
            Pvab.interactable = false;
        }

        if (TUN <= 59 && points >= tun)
        {
            tunb.interactable = true;
        }
        else
        {
            tunb.interactable = false;
        }

        if (LIB <= 9 && points >= lib)
        {
            libb.interactable = true;
        }
        else
        {
            libb.interactable = false;
        }

        if (PER <= 9 && points >= per)
        {
            perb.interactable = true;
        }
        else
        {
            perb.interactable = false;
        }
    }

    public void polvoDeHueso()
    {
        if (points >= pdh)
        {
            points = points - pdh;
            pdhb.interactable = false;
            PDH ++;
            texto.text = "compraste: polvo de hueso";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Ajo() 
    {
        if (points >= ajo)
        {
            points = points - ajo;
            ajob.interactable = false;
            AJO++;
            texto.text = "compraste: ajo";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void HongoRojo() 
    {
        if (points >= hgr)
        {
            points = points - hgr;
            hgrb.interactable = false;
            HGR++;
            texto.text = "compraste: hongo rojo";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Trigo()
    {
        if (points >= trg)
        {
            points = points - trg;
            trgb.interactable = false;
            TRG ++;
            texto.text = "compraste: trigo";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void HongoVerde()
    {
        if (points >= hgv)
        {
            points = points - hgv;
            hgvb.interactable = false;
            HGV ++;
            texto.text = "compraste: hongo verde";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Lavanda()
    {
        if (points >= lvd)
        {
            points = points - lvd;
            lvdb.interactable = false;
            LVD ++;
            texto.text = "compraste: lavanda";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void SalesDeFuego()
    {
        if (points >= sdf)
        {
            points = points - sdf;
            sdfb.interactable = false;
            SDF ++;
            texto.text = "compraste: sales de fuego";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void HongoAzul()
    {
        if (points >= hga)
        {
            points = points - hga;
            hgab.interactable = false;
            HGA ++;
            texto.text = "compraste: hongo azul";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void SalesDeEscarcha()
    {
        if (points >= sde)
        {
            points = points - sde;
            sdeb.interactable = false;
            SDE ++;
            texto.text = "compraste: sales de escarcha";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void HongoMorado()
    {
        if (points >= hgm)
        {
            points = points - hgm;
            hgmb.interactable = false;
            HGM ++;
            texto.text = "compraste: hongo morado";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void SalesDeVacio()
    {
        if (points >= sdv)
        {
            points = points - sdv;
            sdvb.interactable = false;
            SDV ++;
            texto.text = "compraste: sales de vacio";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void RaizDeTenmeaca()
    {
        if (points >= rdt)
        {
            points = points - rdt;
            rdtb.interactable = false;
            RDT ++;
            texto.text = "compraste: raiz de tenmeaca?... eso no era una forma de pedir amablemente a alguien que se vaya a la #!$%&@";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PolvoDeVampiro()
    {
        if (points >= pdv)
        {
            points = points - pdv;
            pdvb.interactable = false;
            PDV ++;
            texto.text = "compraste: polvo de vampiro";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void RaizDeNirn()
    {
        if (points >= rdn)
        {
            points = points - rdn;
            rdnb.interactable = false;
            RDN ++;
            texto.text = "compraste: raiz de nirn";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void EscamasDeDragon()
    {
        if (points >= edd)
        {
            points = points - edd;
            eddb.interactable = false;
            EDD ++;
            texto.text = "compraste: escama de dragon";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void RaizDeNirnCarmesi()
    {
        if (points >= rnc)
        {
            points = points - rnc;
            rncb.interactable = false;
            RNC ++;
            texto.text = "compraste: raiz de nirn carmesi";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Granjero() 
    {
        if (points >= gra)
        {
            points = points - gra;
            grab.interactable = false;
            GRA++;
            texto.text = "contrataste: granjero";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Comprador() 
    {
        if (points >= com)
        {
            points = points - com;
            Comb.interactable = false;
            COM++;
            texto.text = "contrataste: comerciante";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Guardia() 
    {
        if (points >= gua)
        {
            points = points - gua;
            Guab.interactable = false;
            GUA++;
            texto.text = "contrataste: guardia";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Mago() 
    {
        if (points >= mag)
        {
            points = points - mag;
            Magb.interactable = false;
            MAG++;
            texto.text = "contrataste: mago principiante";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Esqueleto() 
    {
        if (points >= esq)
        {
            points = points - esq;
            Esqb.interactable = false;
            ESQ++;
            texto.text = "Reanimaste: esqueleto";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void MythicDawn() 
    {
        if (points >= md)
        {
            points = points - md;
            Mdb.interactable = false;
            MD++;
            texto.text = "contrataste: miembro de la secta del amanecer mitico";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Dovahkiin() 
    {
        if (points >= dvk)
        {
            points = points - dvk;
            Dvkb.interactable = false;
            DVK++;
            texto.text = "contrataste: un sangre de dragon";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionBlanca() 
    {
        if (points >= pbl)
        {
            points = points - pbl;
            Pblb.interactable = false;
            PBL++;
            texto.text = "compraste: receta de pocion de invisivilidad";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionRoja() 
    {
        if (points >= prj)
        {
            points = points - prj;
            Prjb.interactable = false;
            PRJ++;
            texto.text = "compraste: receta de pocion de salud";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionAzul() 
    {
        if (points >= paz)
        {
            points = points - paz;
            Pazb.interactable = false;
            PAZ++;
            texto.text = "compraste: receta de pocion de regeneracion de magia";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionVerde()
    {
        if (points >= pve)
        {
            points = points - pve;
            Pveb.interactable = false;
            PVE++;
            texto.text = "compraste: receta de pocion de resistencia";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionAmarillo() 
    {
        if (points >= pam)
        {
            points = points - pam;
            Pamb.interactable = false;
            PAM++;
            texto.text = "compraste: receta de pocion de fuerza";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionRosa() 
    {
        if (points >= prs)
        {
            points = points - prs;
            Prsb.interactable = false;
            PRS++;
            texto.text = "compraste: receta de pocion de amor";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionMagenta() 
    {
        if (points >= pma)
        {
            points = points - pma;
            Pmab.interactable = false;
            PMA++;
            texto.text = "compraste: receta de pocion de agilidad";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionNaranja() 
    {
        if (points >= pna)
        {
            points = points - pna;
            Pnab.interactable = false;
            PNA++;
            texto.text = "compraste: receta de pocion de velocidad";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionMorada() 
    {
        if (points >= pmo)
        {
            points = points - pmo;
            Pmob.interactable = false;
            PMO++;
            texto.text = "compraste: receta de pocion de suerte";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void PocionVerdeAzulada() 
    {
        if (points >= pva)
        {
            points = points - pva;
            Pvab.interactable = false;
            PVA++;
            texto.text = "compraste: receta de pocion de inteligencia";
            tmpass = 7.0f;
        }
        Xsec();
    }

    public void Tunicas()
    {
        if (points >= tun)
        {
            points = points - tun;
            tunb.interactable = false;
            TUN ++;
            texto.text = "compraste: una tunica nueva";
            tmpass = 7.0f;

            if (tunFn < 9)
            {
                tunFn ++;
                Tunf.sprite = FondT[tunFn];
            }
            else 
            {
                tunFn = 0;
                Tunf.sprite = FondT[tunFn];

                if (tunIn < 5)
                {
                    tunIn ++;
                    tuni.sprite = TunI[tunIn];
                }
            }
            if (TUN == 60)
            {
                Tunf.sprite = FondT[9];
            }
        }
        Xsec();
    }

    public void Libros()
    {
        if (points >= lib)
        {
            points = points - lib;
            libb.interactable = false;
            LIB ++;
            texto.text = "compraste: libro oscuro";
            tmpass = 7.0f;

            if (LIB < 10)
            {
                libf.sprite = FondL[LIB];
            }
        }
        Xsec();
    }

    public void Pergaminos()
    {
        if (points >= per)
        {
            points = points - per;
            perb.interactable = false;
            PER ++;
            texto.text = "compraste: pergamino antiguo";
            tmpass = 7.0f;

            if (PER < 10)
            {
                perf.sprite = FondP[PER];
            }
        }
        Xsec();
    }

    public void Xsec() 
    {
        tun = Mathf.Abs((500 * (TUN + 1))*(500 * (TUN + 1)));
        if (TUN < 60)
        {
            tunT.text = "Siguiente Cuesta: \n" + tun.ToString("#,##0.00");
        }
        else 
        {
            tunT.text = " ";
        }
        tunP = (2f);
        tunTx.text = "Tunica\n Nivel:" + TUN.ToString();
        
        lib = Mathf.Abs((1000 * (LIB + 1))*(1000 * (LIB + 1)));
        if (LIB < 10)
        {
            libT.text = "Siguiente Cuesta: \n" + lib.ToString("#,##0.00");
        }
        else 
        {
            libT.text = " ";
        }
        libP = (2f);
        libTx.text = "Libros Oscuros:\n" + LIB.ToString();
        
        per = Mathf.Abs((2000 * (PER + 1))*(2000 * (PER + 1)));
        if (PER < 10)
        {
            perT.text = "Siguiente Cuesta: \n" + per.ToString("#,##0.00");
        }
        else 
        {
            perT.text = " ";
        }
        perP = 1 - (PER * (0.05f));
        perTx.text = "Pergaminos Antiguos:\n" + PER.ToString();

        pbl = Mathf.Abs(((PBL + 10) * (PBL + 10)) * perP);
        PblT.text = "Tienes: " + PBL.ToString("#,##0.00") + "\n1 Cuesta: " + pbl.ToString("#,##0.00");
        PblP = (0.1f) * ((LIB * libP) + 1);
        PblTx.text = "Pocion Blanca\n +" + PblP + " PPC";

        prj = Mathf.Abs(((PRJ + 20) * (PRJ + 20)) * perP);
        PrjT.text = "Tienes: " + PRJ.ToString("#,##0.00") + "\n1 Cuesta: " + prj.ToString("#,##0.00");
        PrjP = (0.2f) * ((LIB * libP) + 1);
        PrjTx.text = "Pocion Roja\n +" + PrjP + " PPC";

        paz = Mathf.Abs(((PAZ + 30) * (PAZ + 30)) * perP);
        PazT.text = "Tienes: " + PAZ.ToString("#,##0.00") + "\n1 Cuesta: " + paz.ToString("#,##0.00");
        PazP = (0.3f) * ((LIB * libP) + 1);
        PazTx.text = "Pocion Azul\n +" + PazP + " PPC";

        pve = Mathf.Abs(((PVE + 50) * (PVE + 50)) * perP);
        PveT.text = "Tienes: " + PVE.ToString("#,##0.00") + "\n1 Cuesta: " + pve.ToString("#,##0.00");
        PveP = (0.5f) * ((LIB * libP) + 1);
        PveTx.text = "Pocion Verde\n +" + PveP + " PPC";

        pam = Mathf.Abs(((PAM + 80) * (PAM + 80)) * perP);
        PamT.text = "Tienes: " + PAM.ToString("#,##0.00") + "\n1 Cuesta: " + pam.ToString("#,##0.00");
        PamP = (0.8f) * ((LIB * libP) + 1);
        PamTx.text = "Pocion Amarilla\n +" + PamP + " PPC";

        prs = Mathf.Abs(((PRS + 130) * (PRS + 130)) * perP);
        PrsT.text = "Tienes: " + PRS.ToString("#,##0.00") + "\n1 Cuesta: " + prs.ToString("#,##0.00");
        PrsP = (1.3f) * ((LIB * libP) + 1);
        PrsTx.text = "Pocion Rosa\n +" + PrsP + " PPC";

        pma = Mathf.Abs(((PMA + 210) * (PMA + 210)) * perP);
        PmaT.text = "Tienes: " + PMA.ToString("#,##0.00") + "\n1 Cuesta: " + pma.ToString("#,##0.00");
        PmaP = (2.1f) * ((LIB * libP) + 1);
        PmaTx.text = "Pocion Magenta\n +" + PmaP + " PPC";

        pna = Mathf.Abs(((PNA + 340) * (PNA + 340)) * perP);
        PnaT.text = "Tienes: " + PNA.ToString("#,##0.00") + "\n1 Cuesta: " + pna.ToString("#,##0.00");
        PnaP = (3.4f) * ((LIB * libP) + 1);
        PnaTx.text = "Pocion Naranja\n +" + PnaP + " PPC";

        pmo = Mathf.Abs(((PMO + 550) * (PMO + 550)) * perP);
        PmoT.text = "Tienes: " + PMO.ToString("#,##0.00") + "\n1 Cuesta: " + pmo.ToString("#,##0.00");
        PmoP = (5.5f) * ((LIB * libP) + 1);
        PmoTx.text = "Pocion Morada\n +" + PmoP + " PPC";

        pva = Mathf.Abs(((PVA + 890) * (PVA + 890)) * perP);
        PvaT.text = "Tienes: " + PVA.ToString("#,##0.00") + "\n1 Cuesta: " + pva.ToString("#,##0.00");
        PvaP = (8.9f) * ((LIB * libP) + 1);
        PvaTx.text = "Pocion VerdeAzulada\n +" + PvaP + " PPC";

        clickpoints = 1000000000 * (PBL * PblP + 1) * (PRJ * PrjP + 1) * (PAZ * PazP + 1) * (PVE * PveP + 1) * (PAM * PamP + 1) * (PRS * PrsP + 1) * (PMA * PmaP + 1) * (PNA * PnaP + 1) * (PMO * PmoP + 1) * (PVA * PvaP + 1);
        butonclickpoints.text = clickpoints.ToString() + " PPC";

        gra = Mathf.Abs(((GRA + 20) * (GRA + 20)) * perP);
        GraT.text = "Tienes: " + GRA.ToString("#,##0.00") + "\n1 Cuesta: " + gra.ToString("#,##0.00");
        GraP = (0.2f) * ((LIB * libP) + 1);
        GraTx.text = "Granjeros\n x " + GraP + " PPS";

        com = Mathf.Abs(((COM + 40) * (COM + 40)) * perP);
        ComT.text = "Tienes: " + COM.ToString("#,##0.00") + "\n1 Cuesta: " + com.ToString("#,##0.00");
        ComP = (0.4f) * ((LIB * libP) + 1);
        ComTx.text = "Comerciantes\n x " + ComP + " PPS";

        gua = Mathf.Abs(((GUA + 80) * (GUA + 80)) * perP);
        GuaT.text = "Tienes: " + GUA.ToString("#,##0.00") + "\n1 Cuesta: " + gua.ToString("#,##0.00");
        GuaP = (0.8f) * ((LIB * libP) + 1);
        GuaTx.text = "Guardias\n x " + GuaP + " PPS";

        mag = Mathf.Abs(((MAG + 160) * (MAG + 160)) * perP);
        MagT.text = "Tienes: " + MAG.ToString("#,##0.00") + "\n1 Cuesta: " + mag.ToString("#,##0.00");
        MagP = (1.6f) * ((LIB * libP) + 1);
        MagTx.text = "Magos Principiantes\n x " + MagP + " PPS";

        esq = Mathf.Abs(((ESQ + 320) * (ESQ + 320))/2) * perP;
        EsqT.text = "Tienes: " + ESQ.ToString("#,##0.00") + "\n1 Cuesta: " + esq.ToString("#,##0.00");
        EsqP = (3.2f) * ((LIB * libP) + 1);
        EsqTx.text = "Esqueletos\n x " + EsqP + " PPS";

        md = Mathf.Abs(((MD + 640) * (MD + 640))/2) * perP;
        MdT.text = "Tienes: " + MD.ToString("#,##0.00") + "\n1 Cuesta: " + md.ToString("#,##0.00");
        MdP = (6.4f) * ((LIB * libP) + 1);
        MdTx.text = "Magos del Amanecer Mitico\n x " + MdP + " PPS";

        dvk = Mathf.Abs(((DVK + 1280) * (DVK + 1280))/2) * perP;
        DvkT.text = "Tienes: " + DVK.ToString("#,##0.00") + "\n1 Cuesta: " + dvk.ToString("#,##0.00");
        DvkP = (12.8f) * ((LIB * libP) + 1);
        DvkTx.text = "Sangres de Dragon\n x " + DvkP + " PPS";

        multiPT = (GRA * GraP + 1) * (COM * ComP + 1) * (GUA * GuaP + 1) * (MAG * MagP + 1) * (ESQ * EsqP + 1) * (MD * MdP + 1) * (DVK * DvkP + 1);

        pdh = Mathf.Abs(((PDH + 10) * (PDH + 10))/10) * perP;
        PdhT.text = "Tienes: " + PDH.ToString("#,##0.00") + "\n1 Cuesta: " + pdh.ToString("#,##0.00");
        PdhP = (0.1f) * multiPT * ((TUN * tunP) + 1);
        PdhTx.text = "Polvo de Hueso\n +" + PdhP + " PPS";

        ajo = Mathf.Abs(((AJO + 20) * (AJO + 20)) / 10) * perP;
        AjoT.text = "Tienes: " + AJO.ToString("#,##0.00") + "\n1 Cuesta: " + ajo.ToString("#,##0.00");
        AjoP = (0.2f) * multiPT * ((TUN * tunP) + 1);
        AjoTx.text = "Ajo\n +" + AjoP + " PPS";

        hgr = Mathf.Abs(((HGR + 30) * (HGR + 30))/10) * perP;
        HgrT.text = "Tienes: " + HGR.ToString("#,##0.00") + "\n1 Cuesta: " + hgr.ToString("#,##0.00");
        HgrP = (0.3f) * multiPT * ((TUN * tunP) + 1);
        HgrTx.text = "Hongo Rojo\n +" + HgrP + " PPS";

        trg = Mathf.Abs(((TRG + 50) * (TRG + 50))/10) * perP;
        TrgT.text = "Tienes: " + TRG.ToString("#,##0.00") + "\n1 Cuesta: " + trg.ToString("#,##0.00");
        TrgP = (0.5f) * multiPT * ((TUN * tunP) + 1);
        TrgTx.text = "Trigo\n +" + TrgP + " PPS";

        hgv = Mathf.Abs(((HGV + 80) * (HGV + 80))/10) * perP;
        HgvT.text = "Tienes: " + HGV.ToString("#,##0.00") + "\n1 Cuesta: " + hgv.ToString("#,##0.00");
        HgvP = (0.8f) * multiPT * ((TUN * tunP) + 1);
        HgvTx.text = "Hongo Verde\n +" + HgvP + " PPS";

        lvd = Mathf.Abs(((LVD + 130) * (LVD + 130))/10) * perP;
        LvdT.text = "Tienes: " + LVD.ToString("#,##0.00") + "\n1 Cuesta: " + lvd.ToString("#,##0.00");
        LvdP = (1.3f) * multiPT * ((TUN * tunP) + 1);
        LvdTx.text = "Lavanda\n +" + LvdP + " PPS";

        sdf = Mathf.Abs(((SDF + 210) * (SDF + 210))/10) * perP;
        SdfT.text = "Tienes: " + SDF.ToString("#,##0.00") + "\n1 Cuesta: " + sdf.ToString("#,##0.00");
        SdfP = (2.1f) * multiPT * ((TUN * tunP) + 1);
        SdfTx.text = "Sales de Fuego\n +" + SdfP + " PPS";

        hga = Mathf.Abs(((HGA + 340) * (HGA + 340))/10) * perP;
        HgaT.text = "Tienes: " + HGA.ToString("#,##0.00") + "\n1 Cuesta: " + hga.ToString("#,##0.00");
        HgaP = (3.4f) * multiPT * ((TUN * tunP) + 1);
        HgaTx.text = "Hongo Azul\n +" + HgaP + " PPS";

        sde = Mathf.Abs(((SDE + 550) * (SDE + 550))/10) * perP;
        SdeT.text = "Tienes: " + SDE.ToString("#,##0.00") + "\n1 Cuesta: " + sde.ToString("#,##0.00");
        SdeP = (5.5f) * multiPT * ((TUN * tunP) + 1);
        SdeTx.text = "Sales de Escarcha\n +" + SdeP + " PPS";

        hgm = Mathf.Abs(((HGM + 890) * (HGM + 890))/10) * perP;
        HgmT.text = "Tienes: " + HGM.ToString("#,##0.00") + "\n1 Cuesta: " + hgm.ToString("#,##0.00");
        HgmP = (8.9f) * multiPT * ((TUN * tunP) + 1);
        HgmTx.text = "Hongo Morado\n +" + HgmP + " PPS";

        sdv = Mathf.Abs(((SDV + 1440) * (SDV + 1440))/10) * perP;
        SdvT.text = "Tienes: " + SDV.ToString("#,##0.00") + "\n1 Cuesta: " + sdv.ToString("#,##0.00");
        SdvP = (14.4f) * multiPT * ((TUN * tunP) + 1);
        SdvTx.text = "Sales de Vacio\n +" + SdvP + " PPS";

        rdt = Mathf.Abs(((RDT + 2330) * (RDT + 2330))/10) * perP;
        RdtT.text = "Tienes: " + RDT.ToString("#,##0.00") + "\n1 Cuesta: " + rdt.ToString("#,##0.00");
        RdtP = (23.3f) * multiPT * ((TUN * tunP) + 1);
        RdtTx.text = "Ramita de Tenme-aca\n +" + RdtP + " PPS";

        pdv = Mathf.Abs(((PDV + 3770) * (PDV + 3770))/10) * perP;
        PdvT.text = "Tienes: " + PDV.ToString("#,##0.00") + "\n1 Cuesta: " + pdv.ToString("#,##0.00");
        PdvP = (37.7f) * multiPT * ((TUN * tunP) + 1);
        PdvTx.text = "Polvo de Vampiro\n +" + PdvP + " PPS";

        rdn = Mathf.Abs(((RDN + 6100) * (RDN + 6100))/10) * perP;
        RdnT.text = "Tienes: " + RDN.ToString("#,##0.00") + "\n1 Cuesta: " + rdn.ToString("#,##0.00");
        RdnP = (61f) * multiPT * ((TUN * tunP) + 1);
        RdnTx.text = "Raiz de Nirn\n +" + RdnP + " PPS";

        edd = Mathf.Abs(((EDD + 9870) * (EDD + 9870))/10) * perP;
        EddT.text = "Tienes: " + EDD.ToString("#,##0.00") + "\n1 Cuesta: " + edd.ToString("#,##0.00");
        EddP = (98.7f) * multiPT * ((TUN * tunP) + 1);
        EddTx.text = "Escama de Dragon\n +" + EddP + " PPS";

        rnc = Mathf.Abs(((RNC + 15970) * (RNC + 15970))/10) * perP;
        RncT.text = "Tienes: " + RNC.ToString("#,##0.00") + "\n1 Cuesta: " + rnc.ToString("#,##0.00");
        RncP = (159.7f) * multiPT * ((TUN * tunP) + 1);
        RncTx.text = "Raiz de Nirn Carmesi\n +" + RncP + " PPS";


        pointspersec = ((PDH *PdhP) + (AJO * AjoP) + (HGR * HgrP) + (TRG * TrgP) + (HGV * HgvP) + (LVD * LvdP) + (SDF * SdfP) + (HGA * HgaP) + (SDE * SdeP) + (HGM * HgmP) + (SDV * SdvP) + (RDT * RdtP) + (PDV * PdvP) + (RDN * RdnP) + (EDD * EddP) + (RNC * RncP)) ;
        Pointer.text = points.ToString("#,##0.00") + "\n" + pointspersec + " PPS";
    }

    public void Date()
    {
        exitTime = DateTime.Now;
        year = exitTime.Year;
        month = exitTime.Month;
        day = exitTime.Day;
        hour = exitTime.Hour;
        minute = exitTime.Minute;
        second = exitTime.Second;
    }

    public void Save()
    {
        Date();
        rute = Application.streamingAssetsPath + "/AlchemyData.json";
        SaveP = new SavePoints(points, pointspersec, clickpoints, year, month, day, hour, minute, second, PDH, AJO, HGR, TRG, HGV, LVD, SDF, HGA, SDE, HGM, SDV, RDT, PDV, RDN, EDD, RNC, GRA, COM, GUA, MAG, ESQ, MD, DVK, PBL, PRJ, PAZ, PVE, PAM, PRS, PMA, PNA, PMO, PVA, TUN, tunFn, tunIn, LIB, PER);
        string json = JsonUtility.ToJson(SaveP, true);
        print(json);
        System.IO.File.WriteAllText(rute, json);
    }

    public void Reinicio()
    {
        Date();
        rute = Application.streamingAssetsPath + "/AlchemyDataBackUp.json";
        SaveP = new SavePoints(points, pointspersec, clickpoints, year, month, day, hour, minute, second, PDH, AJO, HGR, TRG, HGV, LVD, SDF, HGA, SDE, HGM, SDV, RDT, PDV, RDN, EDD, RNC, GRA, COM, GUA, MAG, ESQ, MD, DVK, PBL, PRJ, PAZ, PVE, PAM, PRS, PMA, PNA, PMO, PVA, TUN, tunFn, tunIn, LIB, PER);
        string json = JsonUtility.ToJson(SaveP, true);
        print(json);
        System.IO.File.WriteAllText(rute, json);

        rute = Application.streamingAssetsPath + "/AlchemyData.json";
        SaveP = new SavePoints(0, 0, 1, year, month, day, hour, minute, second, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        json = JsonUtility.ToJson(SaveP, true);
        print(json);
        System.IO.File.WriteAllText(rute, json);

        points = 0.0f;
        pointspersec = 0.0f;
        clickpoints = 1.0f;
        PDH = 0;
        AJO = 0;
        HGR = 0;
        TRG = 0;
        HGV = 0;
        LVD = 0;
        SDF = 0;
        HGA = 0;
        SDE = 0;
        HGM = 0;
        SDV = 0;
        RDT = 0;
        PDV = 0;
        RDN = 0;
        EDD = 0;
        RNC = 0;
        GRA = 0;
        COM = 0;
        GUA = 0;
        MAG = 0;
        ESQ = 0;
        MD = 0;
        DVK = 0;
        PBL = 0;
        PRJ = 0;
        PAZ = 0;
        PVE = 0;
        PAM = 0;
        PRS = 0;
        PMA = 0;
        PNA = 0;
        PMO = 0;
        PVA = 0;
        TUN = 0;
        tunFn = 0;
        tunIn = 0;
        LIB = 0;
        PER = 0;
        secondsPassed = 0;


        if (TUN == 60)
        {
            Tunf.sprite = FondT[9];
        }
        else
        {
            Tunf.sprite = FondT[tunFn];
        }

        if (TUN == 60)
        {
            tuni.sprite = TunI[5];
        }
        else
        {
            tuni.sprite = TunI[tunIn];
        }

        if (LIB == 10)
        {
            libf.sprite = FondL[9];
        }
        else
        {
            libf.sprite = FondL[LIB];
        }

        if (PER == 10)
        {
            perf.sprite = FondP[9];
        }
        else
        {
            perf.sprite = FondP[PER];
        }

        pause.SetActive(false);
    }

    public void pausaG()
    {
        pause.SetActive(true);
    }

    public void pausaP()
    {
        pause.SetActive(false);
    }

    public void frases()
    {
        if (num == 0)
        {
            texto.text = "Hola que hace";
        }

        if (num == 1)
        {
            texto.text = "Click click click ... click";
        }
        
        if (num == 2)
        {
            texto.text = "Quibo";
        }
        
        if (num == 3)
        {
            texto.text = "Fus Ro click!";
        }
        
        if (num == 4)
        {
            texto.text = "clicky";
        }

        if (num == 5)
        {
            texto.text = "no escaparas de los clicks!";
        }
        
        if (num == 6)
        {
            texto.text = "un click mas... otro mas...";
        }
        
        if (num == 7)
        {
            texto.text = "Dale!";
        }
        
        if (num == 8)
        {
            texto.text = "tienes cierta habilidad con las pociones";
        }
        
        if (num == 9)
        {
            texto.text = "Usted esta aqui para aprender la ciencia sutil y el arte exacto de hacer pociones";
        }
        
        if (num == 10)
        {
            texto.text = "Debes tener cuidado. La gente pensara que estas... tramando algo";
        }
        
        if (num == 11)
        {
            texto.text = "Yo solia ser un aventurero como tu. Pero un dia me hirieron en la rodilla con una flecha...";
        }
        
        if (num == 12)
        {
            texto.text = "Dejame adivinar... alguien te ha robado tu bollo dulce";
        }
        
        if (num == 13)
        {
            texto.text = "... pues si, yo podria haber ido a ese concurso de alquimistas y haberlo ganado, pero ese dia estaba enfermo...";
        }
        
        if (num == 14)
        {
            texto.text = "No tengo nada contra la magia de la destruccion, pero procura no quemar ningun edificio";
        }
        
        if (num == 15)
        {
            texto.text = "Asi que tu eres alquimista. Nunca consegui dominarlo";
        }
        
        if (num == 16)
        {
            texto.text = "Asi que elaboras pociones. No podrias elaborarme una cerveza?";
        }
        
        if (num == 17)
        {
            texto.text = "Harias una pocion por una paleta?";
        }
        
        if (num == 18)
        {
            texto.text = "Existen paletas hechas con alquimia?";
        }
        
        if (num == 19)
        {
            texto.text = "Si lees esto es porque sabes leer";
        }
        
        if (num == 20)
        {
            texto.text = "tal vez funcionaria si juntas el este con la desta en el coso ese... solo digo";
        }
        
        if (num == 21)
        {
            texto.text = "Quieres una paleta?... no?... bueno mas para mi";
        }
        
        if (num == 22)
        {
            texto.text = "y... si mejor haces halgo de comer... no? bueno, que lastima";
        }
        
        if (num == 23)
        {
            texto.text = "Ese polvo blanco... a cierto, es... polvo de hueso... verdad?... verdad?!! ";
        }
        
        if (num == 24)
        {
            texto.text = "Alguien realmente lee esto?";
        }
        
        if (num == 25)
        {
            texto.text = "realmente no entiendo que estas haciendo pero fingire que si";
        }
        
        if (num == 26)
        {
            texto.text = "ACHUU!!! los siento esos polvos me hacen estornudar";
        }
        
        if (num == 27)
        {
            texto.text = "LA CARTULINA!!!";
        }
        
        if (num == 28)
        {
            texto.text = "El camino asi es";
        }
        
        if (num == 29)
        {
            texto.text = "This is the way";
        }
        
        if (num == 30)
        {
            texto.text = "No existe el bien o el mal, solo hay clicks y aquellos demasiado debiles para clickearlos";
        }
        
        if (num == 31)
        {
            texto.text = "Alquimia: Antigua practica protocientifica y disciplina filosofica que combina elementos de la quimica, la fisica, la medicina, la astrologia y otros";
        }
        
        if (num == 32)
        {
            texto.text = "El que escribio esto le falta un tornillo";
        }
        
        if (num == 33)
        {
            texto.text = "si hago una gelatina soy alquimista?";
        }
        
        if (num == 34)
        {
            texto.text = "Quiero dormir... hay una pocion para eso?";
        }
        
        if (num == 35)
        {
            texto.text = "Realmente alguien lee esto?";
        }
        
        if (num == 36)
        {
            texto.text = "hey te faltan unos cuantos clicks";
        }
        
        if (num == 37)
        {
            texto.text = "Te veo...";
        }
    }
}