using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ksiega_gosci
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[,] wyrazy = new string[23, 21];

            wyrazy[0, 0] = "akordeon";
            wyrazy[0, 1] = "arbuz";
            wyrazy[0, 2] = "abordaz";
            wyrazy[0, 3] = "aborygen";
            wyrazy[0, 4] = "aparat";
            wyrazy[0, 5] = "antena";
            wyrazy[0, 6] = "abazur";
            wyrazy[0, 7] = "agresja";
            wyrazy[0, 8] = "abstrakcja";
            wyrazy[0, 9] = "asortyment";
            wyrazy[0, 10] = "abstynent";
            wyrazy[0, 11] = "apstrachuje";
            wyrazy[0, 12] = "ambulans";
            wyrazy[0, 13] = "armagedon";
            wyrazy[0, 14] = "auto";
            wyrazy[0, 15] = "autyzm";
            wyrazy[0, 16] = "amfiteatr";
            wyrazy[0, 17] = "archetyp";
            wyrazy[0, 18] = "architekt";
            wyrazy[0, 19] = "agrafka";
            wyrazy[0, 20] = "artykuł";

            wyrazy[1, 0] = "baton";
            wyrazy[1, 1] = "brzoza";
            wyrazy[1, 2] = "brzoskwinia";
            wyrazy[1, 3] = "brokol";
            wyrazy[1, 4] = "bronzowy";
            wyrazy[1, 5] = "bukiet";
            wyrazy[1, 6] = "bat";
            wyrazy[1, 7] = "browar";
            wyrazy[1, 8] = "branzoletka";
            wyrazy[1, 9] = "banan";
            wyrazy[1, 10] = "bog";
            wyrazy[1, 11] = "biskup";
            wyrazy[1, 12] = "bakalie";
            wyrazy[1, 13] = "bizancjum";
            wyrazy[1, 14] = "bariera";
            wyrazy[1, 15] = "barka";
            wyrazy[1, 16] = "babochlop";
            wyrazy[1, 17] = "bachor";
            wyrazy[1, 18] = "bar";
            wyrazy[1, 19] = "bidon";
            wyrazy[1, 20] = "brat";

            wyrazy[2, 0] = "cebula";
            wyrazy[2, 1] = "czas";
            wyrazy[2, 2] = "czlowiek";
            wyrazy[2, 3] = "cma";
            wyrazy[2, 4] = "cwaniak";
            wyrazy[2, 5] = "cynamon";
            wyrazy[2, 6] = "cymbal";
            wyrazy[2, 7] = "czara";
            wyrazy[2, 8] = "czar";
            wyrazy[2, 9] = "cysterna";
            wyrazy[2, 10] = "cytrus";
            wyrazy[2, 11] = "cmok";
            wyrazy[2, 12] = "car";
            wyrazy[2, 13] = "cesarz";
            wyrazy[2, 14] = "cegła";
            wyrazy[2, 15] = "cytat";
            wyrazy[2, 16] = "cukrzyca";
            wyrazy[2, 17] = "cud";
            wyrazy[2, 18] = "cialo";
            wyrazy[2, 19] = "cena";
            wyrazy[2, 20] = "cytryna";

            wyrazy[3, 0] = "drzewo";
            wyrazy[3, 1] = "drzazga";
            wyrazy[3, 2] = "dom";
            wyrazy[3, 3] = "dyrektor";
            wyrazy[3, 4] = "dysfuzja";
            wyrazy[3, 5] = "dyferencjal";
            wyrazy[3, 6] = "dyskoteka";
            wyrazy[3, 7] = "dysk";
            wyrazy[3, 8] = "diabel";
            wyrazy[3, 9] = "droga";
            wyrazy[3, 10] = "dorsz";
            wyrazy[3, 11] = "drob";
            wyrazy[3, 12] = "dzieciol";
            wyrazy[3, 13] = "deszcz";
            wyrazy[3, 14] = "dlug";
            wyrazy[3, 15] = "dar";
            wyrazy[3, 16] = "dziob";
            wyrazy[3, 17] = "dana";
            wyrazy[3, 18] = "dart";
            wyrazy[3, 19] = "dystrykt";
            wyrazy[3, 20] = "domino";

            wyrazy[4, 0] = "ekierka";
            wyrazy[4, 1] = "eukaliptus";
            wyrazy[4, 2] = "ekran";
            wyrazy[4, 3] = "era";
            wyrazy[4, 4] = "echo";
            wyrazy[4, 5] = "euro";
            wyrazy[4, 6] = "ekspert";
            wyrazy[4, 7] = "ekonomia";
            wyrazy[4, 8] = "eksplozja";
            wyrazy[4, 9] = "erozja";
            wyrazy[4, 10] = "euforia";
            wyrazy[4, 11] = "elektroda";
            wyrazy[4, 12] = "emancypacja";
            wyrazy[4, 13] = "elektryk";
            wyrazy[4, 14] = "emu";
            wyrazy[4, 15] = "elf";
            wyrazy[4, 16] = "ekierka";
            wyrazy[4, 17] = "echograf";
            wyrazy[4, 18] = "egzemplarz";
            wyrazy[4, 19] = "egoizm";
            wyrazy[4, 20] = "elementarz";

            wyrazy[5, 0] = "fakir";
            wyrazy[5, 1] = "fabula";
            wyrazy[5, 2] = "fajka";
            wyrazy[5, 3] = "firana";
            wyrazy[5, 4] = "fabryka";
            wyrazy[5, 5] = "futro";
            wyrazy[5, 6] = "futeral";
            wyrazy[5, 7] = "filam";
            wyrazy[5, 8] = "filtr";
            wyrazy[5, 9] = "fachowiec";
            wyrazy[5, 10] = "furia";
            wyrazy[5, 11] = "falstart";
            wyrazy[5, 12] = "fujarka";
            wyrazy[5, 13] = "fantazja";
            wyrazy[5, 14] = "final";
            wyrazy[5, 15] = "fason";
            wyrazy[5, 16] = "fala";
            wyrazy[5, 17] = "fakultet";
            wyrazy[5, 18] = "fant";
            wyrazy[5, 19] = "fizyka";
            wyrazy[5, 20] = "flet";

            wyrazy[6, 0] = "gruszka";
            wyrazy[6, 1] = "gorset";
            wyrazy[6, 2] = "gitara";
            wyrazy[6, 3] = "gra";
            wyrazy[6, 4] = "gosc";
            wyrazy[6, 5] = "gigant";
            wyrazy[6, 6] = "gospodarz";
            wyrazy[6, 7] = "garncarz";
            wyrazy[6, 8] = "gogle";
            wyrazy[6, 9] = "groza";
            wyrazy[6, 10] = "garnek";
            wyrazy[6, 12] = "guz";
            wyrazy[6, 13] = "galka";
            wyrazy[6, 14] = "gaszcz";
            wyrazy[6, 15] = "guziec";
            wyrazy[6, 16] = "gora";
            wyrazy[6, 17] = "garaz";
            wyrazy[6, 18] = "gasnica";
            wyrazy[6, 19] = "gastronomia";
            wyrazy[6, 20] = "gral";

            wyrazy[7, 0] = "haslo";
            wyrazy[7, 1] = "hak";
            wyrazy[7, 2] = "haft";
            wyrazy[7, 3] = "harfa";
            wyrazy[7, 4] = "hektar";
            wyrazy[7, 5] = "handlarz";
            wyrazy[7, 6] = "hamburger";
            wyrazy[7, 7] = "hamulec";
            wyrazy[7, 8] = "hobby";
            wyrazy[7, 9] = "hodowla";
            wyrazy[7, 10] = "hustawka";
            wyrazy[7, 11] = "hymn";
            wyrazy[7, 12] = "hydrant";
            wyrazy[7, 13] = "humor";
            wyrazy[7, 14] = "humanista";
            wyrazy[7, 15] = "hostessa";
            wyrazy[7, 16] = "huk";
            wyrazy[7, 17] = "historia";
            wyrazy[7, 18] = "hel";
            wyrazy[7, 19] = "helikopter";
            wyrazy[7, 20] = "hamak";

            wyrazy[8, 0] = "islam";
            wyrazy[8, 1] = "igla";
            wyrazy[8, 2] = "igrzyska";
            wyrazy[8, 3] = "imie";
            wyrazy[8, 4] = "istota";
            wyrazy[8, 5] = "iran";
            wyrazy[8, 6] = "iloraz";
            wyrazy[8, 7] = "imadlo";
            wyrazy[8, 8] = "inwalida";
            wyrazy[8, 9] = "izolacja";
            wyrazy[8, 10] = "iskra";
            wyrazy[8, 11] = "inzynier";
            wyrazy[8, 12] = "inwestycja";
            wyrazy[8, 13] = "indyk";
            wyrazy[8, 14] = "ilustracja";
            wyrazy[8, 15] = "iluzja";
            wyrazy[8, 16] = "impreza";
            wyrazy[8, 17] = "imperium";
            wyrazy[8, 18] = "impuls";
            wyrazy[8, 19] = "inspekcja";
            wyrazy[8, 20] = "iglo";

            wyrazy[9, 0] = "jajko";
            wyrazy[9, 1] = "jablko";
            wyrazy[9, 2] = "jak";
            wyrazy[9, 3] = "jez";
            wyrazy[9, 4] = "jelen";
            wyrazy[9, 5] = "jastrzab";
            wyrazy[9, 6] = "jarzyna";
            wyrazy[9, 7] = "jamnik";
            wyrazy[9, 8] = "jazda";
            wyrazy[9, 9] = "jajecznica";
            wyrazy[9, 10] = "jarmark";
            wyrazy[9, 11] = "jadro";
            wyrazy[9, 12] = "jagnie";
            wyrazy[9, 13] = "jagoda";
            wyrazy[9, 14] = "jaguar";
            wyrazy[9, 15] = "jama";
            wyrazy[9, 16] = "jalito";
            wyrazy[9, 17] = "jaselka";
            wyrazy[9, 18] = "jamajczyk";
            wyrazy[9, 19] = "jesiotr";
            wyrazy[9, 20] = "jasmin";

            wyrazy[10, 0] = "kontur";
            wyrazy[10, 1] = "karuzela";
            wyrazy[10, 2] = "krok";
            wyrazy[10, 3] = "kasa";
            wyrazy[10, 4] = "karmnik";
            wyrazy[10, 5] = "kwas";
            wyrazy[10, 6] = "klej";
            wyrazy[10, 7] = "kara";
            wyrazy[10, 8] = "kisiel";
            wyrazy[10, 9] = "kanapka";
            wyrazy[10, 10] = "kurczak";
            wyrazy[10, 11] = "kurwa";
            wyrazy[10, 12] = "koszmar";
            wyrazy[10, 13] = "karton";
            wyrazy[10, 14] = "krokodyl";
            wyrazy[10, 15] = "kosa";
            wyrazy[10, 16] = "kosz";
            wyrazy[10, 17] = "kiwi";
            wyrazy[10, 18] = "kubek";
            wyrazy[10, 19] = "kapsel";
            wyrazy[10, 20] = "kanar";

            wyrazy[11, 0] = "ladacznica";
            wyrazy[11, 1] = "lodowka";
            wyrazy[11, 2] = "lasso";
            wyrazy[11, 3] = "laska";
            wyrazy[11, 4] = "lod";
            wyrazy[11, 5] = "laik";
            wyrazy[11, 6] = "lewo";
            wyrazy[11, 7] = "las";
            wyrazy[11, 8] = "latarka";
            wyrazy[11, 9] = "lek";
            wyrazy[11, 10] = "lot";
            wyrazy[11, 11] = "lezak";
            wyrazy[11, 12] = "lisc";
            wyrazy[11, 13] = "lustro";
            wyrazy[11, 14] = "ludojad";
            wyrazy[11, 15] = "lalka";
            wyrazy[11, 16] = "lipa";
            wyrazy[11, 17] = "luneta";
            wyrazy[11, 18] = "los";
            wyrazy[11, 19] = "lampa";
            wyrazy[11, 20] = "lawina";

            wyrazy[12, 0] = "morswin";
            wyrazy[12, 1] = "marionetka";
            wyrazy[12, 2] = "maruda";
            wyrazy[12, 3] = "morela";
            wyrazy[12, 4] = "masakra";
            wyrazy[12, 5] = "mors";
            wyrazy[12, 6] = "marzenie";
            wyrazy[12, 7] = "maskotka";
            wyrazy[12, 8] = "mieso";
            wyrazy[12, 9] = "molo";
            wyrazy[12, 10] = "malarz";
            wyrazy[12, 11] = "mysz";
            wyrazy[12, 12] = "maska";
            wyrazy[12, 13] = "miednica";
            wyrazy[12, 14] = "metryka";
            wyrazy[12, 15] = "motyl";
            wyrazy[12, 16] = "majonez";
            wyrazy[12, 17] = "mleko";
            wyrazy[12, 18] = "makrela";
            wyrazy[12, 19] = "maslo";
            wyrazy[12, 20] = "morze";

            wyrazy[13, 0] = "nos";
            wyrazy[13, 1] = "nasienie";
            wyrazy[13, 2] = "nozyczki";
            wyrazy[13, 3] = "nobel";
            wyrazy[13, 4] = "nurek";
            wyrazy[13, 5] = "nawyk";
            wyrazy[13, 6] = "nauka";
            wyrazy[13, 7] = "noga";
            wyrazy[13, 8] = "nuta";
            wyrazy[13, 9] = "narty";
            wyrazy[13, 10] = "napad";
            wyrazy[13, 11] = "noz";
            wyrazy[13, 12] = "naramiennik";
            wyrazy[13, 13] = "nocnik";
            wyrazy[13, 14] = "narcyz";
            wyrazy[13, 15] = "napad";
            wyrazy[13, 16] = "noc";
            wyrazy[13, 17] = "nic";
            wyrazy[13, 18] = "noz";
            wyrazy[13, 19] = "nerka";
            wyrazy[13, 20] = "norka";

            wyrazy[14, 0] = "opera";
            wyrazy[14, 1] = "ogien";
            wyrazy[14, 2] = "orygami";
            wyrazy[14, 3] = "orangutan";
            wyrazy[14, 4] = "oslona";
            wyrazy[14, 5] = "olej";
            wyrazy[14, 6] = "ogorek";
            wyrazy[14, 7] = "owad";
            wyrazy[14, 8] = "osad";
            wyrazy[14, 9] = "osad";
            wyrazy[14, 10] = "osada";
            wyrazy[14, 11] = "operacja";
            wyrazy[14, 12] = "ortodonta";
            wyrazy[14, 13] = "ogier";
            wyrazy[14, 14] = "okrzyk";
            wyrazy[14, 15] = "owoc";
            wyrazy[14, 16] = "ogranicznik";
            wyrazy[14, 17] = "orkiestra";
            wyrazy[14, 18] = "obrus";
            wyrazy[14, 19] = "omlet";
            wyrazy[14, 20] = "oprawca";

            wyrazy[15, 0] = "praca";
            wyrazy[15, 1] = "prawo";
            wyrazy[15, 2] = "porecz";
            wyrazy[15, 3] = "pas";
            wyrazy[15, 4] = "panna";
            wyrazy[15, 5] = "prokurator";
            wyrazy[15, 6] = "policja";
            wyrazy[15, 7] = "pan";
            wyrazy[15, 8] = "pantofel";
            wyrazy[15, 9] = "pokolenie";
            wyrazy[15, 10] = "pirat";
            wyrazy[15, 11] = "pies";
            wyrazy[15, 12] = "piernik";
            wyrazy[15, 13] = "proca";
            wyrazy[15, 14] = "puszka";
            wyrazy[15, 15] = "pokoj";
            wyrazy[15, 16] = "piornik";
            wyrazy[15, 17] = "przepaska";
            wyrazy[15, 18] = "pieprz";
            wyrazy[15, 19] = "pierogi";
            wyrazy[15, 20] = "program";

            wyrazy[16, 0] = "rak";
            wyrazy[16, 1] = "radny";
            wyrazy[16, 2] = "rozsadek";
            wyrazy[16, 3] = "rosol";
            wyrazy[16, 4] = "rozwoj";
            wyrazy[16, 5] = "rajd";
            wyrazy[16, 6] = "rola";
            wyrazy[16, 7] = "rower";
            wyrazy[16, 8] = "ruch";
            wyrazy[16, 9] = "rog";
            wyrazy[16, 10] = "recznik";
            wyrazy[16, 11] = "ryba";
            wyrazy[16, 12] = "rekin";
            wyrazy[16, 13] = "rampa";
            wyrazy[16, 14] = "robotnik";
            wyrazy[16, 15] = "robak";
            wyrazy[16, 16] = "rejs";
            wyrazy[16, 17] = "remis";
            wyrazy[16, 18] = "rekord";
            wyrazy[16, 19] = "rozbojnik";
            wyrazy[16, 20] = "roj";

            wyrazy[17, 0] = "safari";
            wyrazy[17, 1] = "szatan";
            wyrazy[17, 2] = "slawa";
            wyrazy[17, 3] = "szkola";
            wyrazy[17, 4] = "szmata";
            wyrazy[17, 5] = "szczerosc";
            wyrazy[17, 6] = "szczaw";
            wyrazy[17, 7] = "szal";
            wyrazy[17, 8] = "szept";
            wyrazy[17, 9] = "sejk";
            wyrazy[17, 10] = "slon";
            wyrazy[17, 11] = "slonce";
            wyrazy[17, 12] = "sok";
            wyrazy[17, 13] = "sofa";
            wyrazy[17, 14] = "super";
            wyrazy[17, 15] = "sejm";
            wyrazy[17, 16] = "serce";
            wyrazy[17, 17] = "sygnal";
            wyrazy[17, 18] = "sennik";
            wyrazy[17, 19] = "serial";
            wyrazy[17, 20] = "slowo";

            wyrazy[18, 0] = "tarzan";
            wyrazy[18, 1] = "telepatia";
            wyrazy[18, 2] = "teczka";
            wyrazy[18, 3] = "torba";
            wyrazy[18, 4] = "turek";
            wyrazy[18, 5] = "teleportacja";
            wyrazy[18, 6] = "tasak";
            wyrazy[18, 7] = "terytorium";
            wyrazy[18, 8] = "tafla";
            wyrazy[18, 9] = "telemark";
            wyrazy[18, 10] = "trawa";
            wyrazy[18, 11] = "tata";
            wyrazy[18, 12] = "turysta";
            wyrazy[18, 13] = "tarcza";
            wyrazy[18, 14] = "telefon";
            wyrazy[18, 15] = "towar";
            wyrazy[18, 16] = "tekst";
            wyrazy[18, 17] = "tarka";
            wyrazy[18, 18] = "temat";
            wyrazy[18, 19] = "tworzywo";
            wyrazy[18, 20] = "tsunami";


            wyrazy[19, 0] = "ul";
            wyrazy[19, 1] = "uczen";
            wyrazy[19, 2] = "uwaga";
            wyrazy[19, 3] = "ustroj";
            wyrazy[19, 4] = "ubranie";
            wyrazy[19, 5] = "ulga";
            wyrazy[19, 6] = "ustawa";
            wyrazy[19, 7] = "uczelnia";
            wyrazy[19, 8] = "umiar";
            wyrazy[19, 9] = "usta";
            wyrazy[19, 10] = "udo";
            wyrazy[19, 11] = "uczta";
            wyrazy[19, 12] = "usterka";
            wyrazy[19, 13] = "umowa";
            wyrazy[19, 14] = "uklad";
            wyrazy[19, 15] = "umysl";
            wyrazy[19, 16] = "upior";
            wyrazy[19, 17] = "urodziny";
            wyrazy[19, 18] = "usmiech";
            wyrazy[19, 19] = "usluga";
            wyrazy[19, 20] = "ulica";

            wyrazy[20, 0] = "wiklina";
            wyrazy[20, 1] = "worek";
            wyrazy[20, 2] = "wiadro";
            wyrazy[20, 3] = "wyjscie";
            wyrazy[20, 4] = "wiezienie";
            wyrazy[20, 5] = "wampir";
            wyrazy[20, 6] = "wegiel";
            wyrazy[20, 7] = "wdowa";
            wyrazy[20, 8] = "wilk";
            wyrazy[20, 9] = "wino";
            wyrazy[20, 10] = "wybrzeze";
            wyrazy[20, 11] = "wol";
            wyrazy[20, 12] = "wosk";
            wyrazy[20, 13] = "watroba";
            wyrazy[20, 14] = "wrog";
            wyrazy[20, 15] = "wlokno";
            wyrazy[20, 16] = "wachlarz";
            wyrazy[20, 17] = "wahacz";
            wyrazy[20, 18] = "wykop";
            wyrazy[20, 19] = "warcaby";
            wyrazy[20, 20] = "wazon";

            wyrazy[21, 0] = "yeti";
            wyrazy[21, 1] = "yellow";
            wyrazy[21, 2] = "yesterday";
            wyrazy[21, 3] = "you";
            wyrazy[21, 4] = "youth";
            wyrazy[21, 5] = "yet";
            wyrazy[21, 6] = "yoga";
            wyrazy[21, 7] = "year";
            wyrazy[21, 8] = "yellowstone";
            wyrazy[21, 9] = "yacht";
            wyrazy[21, 10] = "yell";
            wyrazy[21, 11] = "yen";
            wyrazy[21, 12] = "yoyo";
            wyrazy[21, 13] = "yasmina";
            wyrazy[21, 14] = "yep";
            wyrazy[21, 15] = "yesman";
            wyrazy[21, 16] = "yep";
            wyrazy[21, 17] = "yegg";
            wyrazy[21, 18] = "yarmulke";
            wyrazy[21, 19] = "yelp";
            wyrazy[21, 20] = "yew";

            wyrazy[22, 0] = "zamek";
            wyrazy[22, 1] = "zakupy";
            wyrazy[22, 2] = "zarobek";
            wyrazy[22, 3] = "zero";
            wyrazy[22, 4] = "zaloga";
            wyrazy[22, 5] = "zegarek";
            wyrazy[22, 6] = "zeszyt";
            wyrazy[22, 7] = "zupa";
            wyrazy[22, 8] = "znak";
            wyrazy[22, 9] = "zjawisko";
            wyrazy[22, 10] = "zgon";
            wyrazy[22, 11] = "zjazd";
            wyrazy[22, 12] = "zima";
            wyrazy[22, 13] = "zainteresowanie";
            wyrazy[22, 14] = "zielony";
            wyrazy[22, 15] = "zapal";
            wyrazy[22, 16] = "zebra";
            wyrazy[22, 17] = "ziarno";
            wyrazy[22, 18] = "zadanie";
            wyrazy[22, 19] = "zespol";
            wyrazy[22, 20] = "znajomi";


            string litera = TextBox2.Text.Substring(TextBox2.Text.Length - 1, 1);
            //Label1.Text = litera;

     

      
            string last = Label1.Text.Substring(Label1.Text.Length - 1, 1);

            string pierwsza = TextBox2.Text.Substring(0,1);

            if (pierwsza != last)
            {
                Label2.Text = "Error! Pierwsza litera Twojego słowa nie równa sie ostatatniej literze słowa wprowadzonego przez program!";
            }
            else
            {
                Label2.Text = "";
                Random rnd = new Random();
                int i = rnd.Next(20);

                if (litera == "a")
                {

                    Label1.Text = wyrazy[0, i];
                }

                if (litera == "b")
                {

                    Label1.Text = wyrazy[1, i];
                }
                if (litera == "c")
                {

                    Label1.Text = wyrazy[2, i];
                }
                if (litera == "d")
                {

                    Label1.Text = wyrazy[3, i];
                }
                if (litera == "e")
                {

                    Label1.Text = wyrazy[4, i];
                }
                if (litera == "f")
                {

                    Label1.Text = wyrazy[5, i];
                }
                if (litera == "g")
                {

                    Label1.Text = wyrazy[6, i];
                }
                if (litera == "h")
                {

                    Label1.Text = wyrazy[7, i];
                }
                if (litera == "i")
                {

                    Label1.Text = wyrazy[8, i];
                }
                if (litera == "j")
                {

                    Label1.Text = wyrazy[9, i];
                }
                if (litera == "k")
                {

                    Label1.Text = wyrazy[10, i];
                }
                if (litera == "l")
                {

                    Label1.Text = wyrazy[11, i];
                }
                if (litera == "m")
                {

                    Label1.Text = wyrazy[12, i];
                }
                if (litera == "n")
                {

                    Label1.Text = wyrazy[13, i];
                }
                if (litera == "o")
                {

                    Label1.Text = wyrazy[14, i];
                }
                if (litera == "p")
                {

                    Label1.Text = wyrazy[15, i];
                }
                if (litera == "r")
                {

                    Label1.Text = wyrazy[16, i];
                }
                if (litera == "s")
                {

                    Label1.Text = wyrazy[17, i];
                }
                if (litera == "t")
                {

                    Label1.Text = wyrazy[18, i];
                }
                if (litera == "u")
                {

                    Label1.Text = wyrazy[19, i];
                }
                if (litera == "w")
                {

                    Label1.Text = wyrazy[20, i];
                }
                if (litera == "y")
                {

                    Label1.Text = wyrazy[21, i];
                }
                if (litera == "z")
                {

                    Label1.Text = wyrazy[22, i];
                }
            }
            TextBox2.Text = "";
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}