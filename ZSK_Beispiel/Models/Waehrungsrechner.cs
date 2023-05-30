namespace ZSK_Beispiel.Models {
    public static class Waehrungsrechner {

        public static int Euro { get; set; }
        public static int PreisKuh { get; set; } = 2800;
        public static int PreisSchaf { get; set; } = 650;
        public static int PreisZiege { get; set; } = 500;
        public static int PreisKleineZiege { get; set; } = 50;

        public static int PreisDorsch { get; set; } = 8000;
        public static int PreisAal { get; set; } = 8000 / 11;
        public static int PreisHering { get; set; } = (8000 / 11) / 5;
        public static int PreisRochen { get; set; } = (9 * 8000 / 11 / 5) + (7 * 8000 / 11);
        public static int PreisSprotte { get; set; } = 8000 / 11 / 5 / 11;



        public static ZSK Euro2ZSK(int euro) {
            int rest = 0;
            ZSK ergebnis = new ZSK();

            rest = euro;

            ergebnis.AnzahlKuh = rest / PreisKuh;
            rest = rest % PreisKuh;

            ergebnis.AnzahlSchaf = rest / PreisSchaf;
            rest = rest % PreisSchaf;

            ergebnis.AnzahlZiege = rest / PreisZiege;
            rest = rest % PreisZiege;

            ergebnis.AnzahlKleineZiege = rest / PreisKleineZiege;
            rest = rest % PreisKleineZiege;

            return ergebnis;
        }

        public static int ZSK2Euro(ZSK zsk) {
            int ergebnis = 0;

            ergebnis = zsk.AnzahlKuh * PreisKuh +
            zsk.AnzahlSchaf * PreisSchaf +
            zsk.AnzahlZiege * PreisZiege +
            zsk.AnzahlKleineZiege * PreisKleineZiege;

            return ergebnis;
        }

        public static DAHRS Euro2DAHRS(int euro) {
            int rest = euro;

            DAHRS ergebnis = new DAHRS();

            ergebnis.AnzahlDorsch = rest / PreisDorsch;
            rest = rest % PreisDorsch;

            ergebnis.AnzahlRochen = rest / PreisRochen;
            rest = rest % PreisRochen;

            ergebnis.AnzahlAal = rest / PreisAal;
            rest = rest % PreisAal;

            ergebnis.AnzahlHering = rest / PreisHering;
            rest = rest % PreisHering;

            ergebnis.AnzahlSprotte = rest / PreisSprotte;
            rest = rest % PreisSprotte;

            return ergebnis;
        }

        public static int DAHRS2Euro(DAHRS dahrs) {
            int ergebnis = 0;

            ergebnis = dahrs.AnzahlDorsch * PreisDorsch +
            dahrs.AnzahlRochen * PreisRochen +
            dahrs.AnzahlAal * PreisAal +
            dahrs.AnzahlHering * PreisHering +
            dahrs.AnzahlSprotte * PreisSprotte;

            return ergebnis;
        }
    }
}
