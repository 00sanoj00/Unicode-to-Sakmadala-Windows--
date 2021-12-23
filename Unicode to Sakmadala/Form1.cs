using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode_to_Sakmadala
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinmanager;
        public Form1()
        {
            InitializeComponent();
            materialSkinmanager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinmanager.EnforceBackcolorOnAllComponents = true;
            materialSkinmanager.AddFormToManage(this);
            materialSkinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }




        public void unicode()
        {
            String text = textBox1.Text;
            text = text.Replace(",", ",");
            text = text.Replace(".", ".");
            text = text.Replace("ත්‍රෛ", "t|rAI");//
            text = text.Replace("ශෛ", "xAI");//
            text = text.Replace("චෛ", "cAI");//
            text = text.Replace("ජෛ", "jAI");//
            text = text.Replace("කෛ", "kAI");//
            text = text.Replace("මෛ", "mAI");//
            text = text.Replace("පෛ", "pAI");//
            text = text.Replace("දෛ", "zAI");//
            text = text.Replace("තෛ", "wAI");//
            text = text.Replace("නෛ", "nAI");//
            text = text.Replace("ධෛ", "ZAI");//
            text = text.Replace("වෛ", "vAI");//
            text = text.Replace("ප්‍රෞ", "fm%!");
            text = text.Replace("ෂ්‍යෝ", "fIHda");
            text = text.Replace("ඡ්‍යෝ", "fPHda");
            text = text.Replace("ඪ්‍යෝ", "fVHda");
            text = text.Replace("ඝ්‍යෝ", "f>Hda");
            text = text.Replace("ඛ්‍යෝ", "fLHda");
            text = text.Replace("ළ්‍යෝ", "f<Hda");
            text = text.Replace("ඵ්‍යෝ", "fMHda");
            text = text.Replace("ඨ්‍යෝ", "fGHda");
            text = text.Replace("ශ්‍යෝ", "fYHda");
            text = text.Replace("ක්‍ෂ්‍යෝ", "fÌHda");
            text = text.Replace("බ්‍යෝ", "fnHda");
            text = text.Replace("ච්‍යෝ", "fpHda");
            text = text.Replace("ඩ්‍යෝ", "fâHda");
            text = text.Replace("ෆ්‍යෝ", "f*Hda");
            text = text.Replace("ග්‍යෝ", "f.Hda");
            text = text.Replace("ජ්‍යෝ", "fcHda");
            text = text.Replace("ක්‍යෝ", "flHda");
            text = text.Replace("ල්‍යෝ", "f,Hda");
            text = text.Replace("ම්‍යෝ", "fuHda");
            text = text.Replace("න්‍යෝ", "fkHda");
            text = text.Replace("ප්‍යෝ", "fmHda");
            text = text.Replace("ද්‍යෝ", "foHda");
            text = text.Replace("ස්‍යෝ", "fiHda");
            text = text.Replace("ට්‍යෝ", "fgHda");
            text = text.Replace("ව්‍යෝ", "fjHda");
            text = text.Replace("ත්‍යෝ", "f;Hda");
            text = text.Replace("භ්‍යෝ", "fNHda");
            text = text.Replace("ධ්‍යෝ", "fOHda");
            text = text.Replace("ථ්‍යෝ", "f:Hda");
            text = text.Replace("ෂ්‍යො", "fIHd");
            text = text.Replace("ශ්‍යො", "fYHd");
            text = text.Replace("ඛ්‍යො", "fLHd");
            text = text.Replace("ක්‍ෂ්‍යො", "fÌHd");
            text = text.Replace("බ්‍යො", "fnHd");
            text = text.Replace("ව්‍යො", "fjHd");
            text = text.Replace("ඩ්‍යො", "fvHd");
            text = text.Replace("ෆ්‍යො", "f*Hd");
            text = text.Replace("ග්‍යො", "f.Hd");
            text = text.Replace("ජ්‍යො", "fcHd");
            text = text.Replace("ක්‍යො", "flHd");
            text = text.Replace("ම්‍යො", "fuHd");
            text = text.Replace("ප්‍යො", "fmHd");
            text = text.Replace("ද්‍යො", "foHd");
            text = text.Replace("ස්‍යො", "fiHd");
            text = text.Replace("ට්‍යො", "fgHd");
            text = text.Replace("ව්‍යො", "fjHd");
            text = text.Replace("ත්‍යො", "f;Hd");
            text = text.Replace("භ්‍යො", "fNHd");
            text = text.Replace("ධ්‍යො", "fOHd");
            text = text.Replace("ථ්‍යො", "f:Hd");
            text = text.Replace("ෂ්‍යෙ", "fIH");
            text = text.Replace("ඡ්‍යෙ", "fPH");
            text = text.Replace("ළ්‍යෙ", "f<H");
            text = text.Replace("ණ්‍යෙ", "fKH");
            text = text.Replace("ච්‍යෙ", "fpH");
            text = text.Replace("ල්‍යෙ", "f,H");
            text = text.Replace("න්‍යෙ", "fkH");
            text = text.Replace("ශ්‍යෙ", "fYH");
            text = text.Replace("ඛ්‍යෙ", "fLH");
            text = text.Replace("ක්‍ෂ්යෙ", "fÌH");
            text = text.Replace("බ්‍යෙ", "fnH");
            text = text.Replace("ඩ්‍යෙ", "fvH");
            text = text.Replace("ෆ්‍යෙ", "f*H");
            text = text.Replace("ග්‍යෙ", "f.H");
            text = text.Replace("ජ්‍යෙ", "fcH");
            text = text.Replace("ක්‍යෙ", "flH");
            text = text.Replace("ම්‍යෙ", "fuH");
            text = text.Replace("ප්‍යෙ", "fmH");
            text = text.Replace("ද්‍යෙ", "foH");
            text = text.Replace("ස්‍යෙ", "fiH");
            text = text.Replace("ට්‍යෙ", "fgH");
            text = text.Replace("ව්‍යෙ", "fjH");
            text = text.Replace("ත්‍යෙ", "f;H");
            text = text.Replace("භ්‍යෙ", "fNH");
            text = text.Replace("ධ්‍යෙ", "fOH");
            text = text.Replace("ථ්‍යෙ", "f:H");
            text = text.Replace("ෂ්‍රෝ", "fI%da");
            text = text.Replace("ඝ්‍රෝ", "f>%da");
            text = text.Replace("ශ්‍රෝ", "s&r\\");//
            text = text.Replace("ක්‍ෂ්‍රෝ", "fÌ%da");
            text = text.Replace("බ්‍රෝ", "fn%da");
            text = text.Replace("ඩ්‍රෝ", "fv%da");
            text = text.Replace("ෆ්‍රෝ", "f*%da");
            text = text.Replace("ග්‍රෝ", "f.%da");
            text = text.Replace("ක්‍රෝ", "fl%da");
            text = text.Replace("ප්‍රෝ", "fm%da");
            text = text.Replace("ද්‍රෝ", "føda");
            text = text.Replace("ස්‍රෝ", "fi%da");
            text = text.Replace("ට්‍රෝ", "fg%da");
            text = text.Replace("ත්‍රෝ", "f;%da");
            text = text.Replace("ශ්‍රො", "s&rO");
            text = text.Replace("ඩ්‍රො", "fv%d");
            text = text.Replace("ෆ්‍රො", "f*%d");
            text = text.Replace("ග්‍රො", "f.%d");
            text = text.Replace("ක්‍රො", "fl%d");
            text = text.Replace("ප්‍රො", "fm%d");
            text = text.Replace("ද්‍රො", "fød");
            text = text.Replace("ස්‍රො", "fi%d");
            text = text.Replace("ට්‍රො", "fg%d");
            text = text.Replace("ත්‍රො", "f;%d");
            text = text.Replace("ශ්‍රේ", "fYa%");
            text = text.Replace("බ්‍රේ", "fí%");
            text = text.Replace("ඩ්‍රේ", "fâ%");
            text = text.Replace("ෆ්‍රේ", "f*a%");
            text = text.Replace("ග්‍රේ", "f.a%");
            text = text.Replace("ක්‍රේ", "fla%");
            text = text.Replace("ප්‍රේ", "fma%");
            text = text.Replace("ද්‍රේ", "føa");
            text = text.Replace("ස්‍රේ", "fia%");
            text = text.Replace("ත්‍රේ", "f;a%");
            text = text.Replace("ධ්‍රේ", "fè%");
            text = text.Replace("ෂ්‍රෙ", "x&Er");//
            text = text.Replace("ශ්‍රෙ", "s&Er");//
            text = text.Replace("බ්‍රෙ", "b&Er");//
            text = text.Replace("ෆ්‍රෙ", "f&Er");//
            text = text.Replace("ග්‍රෙ", "g&Er");//
            text = text.Replace("ක්‍රෙ", "l&Er");//
            text = text.Replace("ප්‍රෙ", "p&Er");//
            text = text.Replace("ශ්‍ර", "s&r");//new add
            text = text.Replace("ප්\u200Dර", "p|U");//new add
            text = text.Replace("ශ්\u200Dරී", "s&r{");//new add
            text = text.Replace("ද්‍රෙ", "fø");
            text = text.Replace("ස්‍රෙ", "fi%");
            text = text.Replace("ත්‍රෙ", "f;%");
            text = text.Replace("භ්‍රෙ", "fN%");
            text = text.Replace("ධ්‍රෙ", "fO%");
            text = text.Replace("්‍ය", "H");
            text = text.Replace("්‍ර", "%");
            text = text.Replace("ෂෞ", "fI!");
            text = text.Replace("ඡෞ", "fP!");
            text = text.Replace("ශෞ", "fY!");
            text = text.Replace("බෞ", "fn!");
            text = text.Replace("චෞ", "fp!");
            text = text.Replace("ඩෞ", "fv!");
            text = text.Replace("ෆෞ", "f*!");
            text = text.Replace("ගෞ", "g&u");//
            text = text.Replace("ජෞ", "fc!");
            text = text.Replace("කෞ", "fl!");
            text = text.Replace("ලෞ", "f,!");
            text = text.Replace("මෞ", "fu!");
            text = text.Replace("නෞ", "fk!");
            text = text.Replace("පෞ", "fm!");
            text = text.Replace("දෞ", "fo!");
            text = text.Replace("රෞ", "fr!");
            text = text.Replace("සෞ", "fi!");
            text = text.Replace("ටෞ", "fg!");
            text = text.Replace("තෞ", "f;!");
            text = text.Replace("භෞ", "BUA");//
            text = text.Replace("ඤෞ", "f[!");
            text = text.Replace("ෂෝ", "fIda");
            text = text.Replace("ඹෝ", "fUda");
            text = text.Replace("ඡෝ", "fPda");
            text = text.Replace("ඪෝ", "fVda");
            text = text.Replace("ඝෝ", "G\\");//
            text = text.Replace("ඛෝ", "fLda");
            text = text.Replace("ළෝ", "L\\");//
            text = text.Replace("ඟෝ", "fÛda");
            text = text.Replace("ණෝ", "fKda");
            text = text.Replace("ඵෝ", "fMda");
            text = text.Replace("ඨෝ", "fGda");
            text = text.Replace("ඬෝ", "fËda");
            text = text.Replace("ශෝ", "fYda");
            text = text.Replace("ඥෝ", "f{da");
            text = text.Replace("ඳෝ", "f|da");
            text = text.Replace("ක්‍ෂෝ", "fÌda");
            text = text.Replace("බෝ", "b\\");//
            text = text.Replace("චෝ", "c\\");//
            text = text.Replace("ඩෝ", "d\\");//
            text = text.Replace("ෆෝ", "f\\");//
            text = text.Replace("ගෝ", "g\\");//h
            text = text.Replace("හෝ", "h\\");//
            text = text.Replace("ජෝ", "j\\");//
            text = text.Replace("කෝ", "k\\");//
            text = text.Replace("ලෝ", "l\\");//
            text = text.Replace("මෝ", "m\\");//
            text = text.Replace("නෝ", "n\\");//
            text = text.Replace("පෝ", "p\\");//
            text = text.Replace("දෝ", "z\\");//
            text = text.Replace("රෝ", "r\\");//
            text = text.Replace("සෝ", "s\\");//
            text = text.Replace("ටෝ", "t\\");//
            text = text.Replace("වෝ", "v\\");//
            text = text.Replace("තෝ", "t\\");//
            text = text.Replace("භෝ", "B\\");//
            text = text.Replace("යෝ", "y\\");//
            text = text.Replace("ඤෝ", "f[da");
            text = text.Replace("ධෝ", "fOda");
            text = text.Replace("ථෝ", "f:da");
            text = text.Replace("ෂො", "fId");
            text = text.Replace("ඹො", "fUd");
            text = text.Replace("ඡො", "fPd");
            text = text.Replace("ඪො", "fVd");
            text = text.Replace("ඝො", "f>d");
            text = text.Replace("ඛො", "fLd");
            text = text.Replace("ළො", "f<d");
            text = text.Replace("ඟො", "fÕd");
            text = text.Replace("ණො", "fKd");
            text = text.Replace("ඵො", "fMd");
            text = text.Replace("ඨො", "fGd");
            text = text.Replace("ඬො", "fËd");
            text = text.Replace("ශො", "fYd");
            text = text.Replace("ඥො", "f{d");
            text = text.Replace("ඳො", "f|d");
            text = text.Replace("ක්‍ෂො", "fÌd");
            text = text.Replace("බො", "bO");//
            text = text.Replace("චො", "cO");//
            text = text.Replace("ඩො", "dO");//
            text = text.Replace("ෆො", "fO");//
            text = text.Replace("ගො", "gO");//
            text = text.Replace("හො", "hO");//
            text = text.Replace("ජො", "jO");//
            text = text.Replace("කො", "kO");//
            text = text.Replace("ලො", "lO");//
            text = text.Replace("මො", "mO");//
            text = text.Replace("නො", "nO");//
            text = text.Replace("පො", "pO");//
            text = text.Replace("දො", "zO");//
            text = text.Replace("රො", "rO");//
            text = text.Replace("සො", "sO");//
            text = text.Replace("ටො", "tO");//
            text = text.Replace("වො", "vO");//
            text = text.Replace("තො", "wO");//
            text = text.Replace("භො", "BO");//
            text = text.Replace("යො", "yO");//
            text = text.Replace("ඤො", "f[d");
            text = text.Replace("ධො", "fOd");
            text = text.Replace("ථො", "f:d");
            text = text.Replace("ෂේ", "fIa");
            text = text.Replace("ඹේ", "fò");
            text = text.Replace("ඡේ", "fþ");
            text = text.Replace("ඝේ", "f>a");
            text = text.Replace("ඛේ", "fÄ");
            text = text.Replace("ළේ", "f<a");
            text = text.Replace("ඟේ", "fÛa");
            text = text.Replace("ණේ", "fKa");
            text = text.Replace("ඵේ", "fMa");
            text = text.Replace("ඨේ", "fGa");
            text = text.Replace("ඬේ", "få");
            text = text.Replace("ශේ", "fYa");
            text = text.Replace("ඥේ", "f{a");
            text = text.Replace("ඳේ", "f|a");
            text = text.Replace("ක්‍ෂේ", "fÌa");
            text = text.Replace("බේ", "<b");//
            text = text.Replace("චේ", "<c");//
            text = text.Replace("ඩේ", "<d");//
            text = text.Replace("ෆේ", "<f");//
            text = text.Replace("ගේ", "<g");//
            text = text.Replace("හේ", "<h");//
            text = text.Replace("පේ", "<p");//
            text = text.Replace("කේ", "<k");//
            text = text.Replace("ලේ", "<l");//
            text = text.Replace("මේ", "<m");//
            text = text.Replace("නේ", "<n");//
            text = text.Replace("ජේ", "<j");//
            text = text.Replace("දේ", "<z");//
            text = text.Replace("රේ", "<r");//
            text = text.Replace("සේ", "<s");//
            text = text.Replace("ටේ", "<t");//
            text = text.Replace("වේ", "<v");//
            text = text.Replace("තේ", "<w");//
            text = text.Replace("භේ", "fNa");
            text = text.Replace("යේ", "<y");//
            text = text.Replace("ඤේ", "f[a");
            text = text.Replace("ධේ", "fè");
            text = text.Replace("ථේ", "f:a");
            text = text.Replace("ෂෙ", "fI");
            text = text.Replace("ඹෙ", "fU");
            text = text.Replace("ඓ", "a&y|");
            text = text.Replace("ඡෙ", "fP");
            text = text.Replace("ඪෙ", "fV");
            text = text.Replace("ඝෙ", "f>");
            text = text.Replace("ඛෙ", "fn");
            text = text.Replace("ළෙ", "f<");
            text = text.Replace("ඟෙ", "fÛ");
            text = text.Replace("ණෙ", "fK");
            text = text.Replace("ඵෙ", "fM");
            text = text.Replace("ඨෙ", "fG");
            text = text.Replace("ඬෙ", "fË");
            text = text.Replace("ශෙ", "fY");
            text = text.Replace("ඥෙ", "f{");
            text = text.Replace("ඳෙ", "fË");
            text = text.Replace("ක්‍ෂෙ", "fÌ");
            text = text.Replace("බෙ", "Eb");//
            text = text.Replace("චෙ", "Ec");//
            text = text.Replace("ඩෙ", "Ed");//
            text = text.Replace("ෆෙ", "Ef");//
            text = text.Replace("ගෙ", "Eg");//
            text = text.Replace("හෙ", "Eh");//
            text = text.Replace("ජෙ", "Ej");//
            text = text.Replace("කෙ", "Ek");//
            text = text.Replace("ලෙ", "El");//
            text = text.Replace("මෙ", "Em");//
            text = text.Replace("නෙ", "En");//
            text = text.Replace("පෙ", "Ep");//
            text = text.Replace("දෙ", "Ez");//
            text = text.Replace("රෙ", "Er");//
            text = text.Replace("සෙ", "Es");//
            text = text.Replace("ටෙ", "Et");//
            text = text.Replace("වෙ", "Ev");//
            text = text.Replace("තෙ", "Ew");//
            text = text.Replace("භෙ", "EB");//
            text = text.Replace("යෙ", "Ey");//
            text = text.Replace("ඤෙ", "f[");
            text = text.Replace("ධෙ", "fO");
            text = text.Replace("ථෙ", "f:");
            text = text.Replace("තු", "wU");//
            text = text.Replace("ගු", "gU");//
            text = text.Replace("කු", "kU");//
            text = text.Replace("තූ", "w}");//
            text = text.Replace("ගූ", "g}");//
            text = text.Replace("කූ", "k}");//
            text = text.Replace("රු", "rU");//
            text = text.Replace("රූ", "r}");//
            text = text.Replace("ආ", "aA");//
            text = text.Replace("ඇ", "q");//
            text = text.Replace("ඈ", "qQ");//
            text = text.Replace("ඌ", "uU");//
            text = text.Replace("ඖ", "aU");//
            text = text.Replace("ඒ", "Ee");//
            text = text.Replace("ඕ", "oO");//
            text = text.Replace("ඳි", "XI");//
            text = text.Replace("ඳී", "X{");//
            text = text.Replace("දූ", "¥");
            text = text.Replace("දී", "§");
            text = text.Replace("ලූ", "¨");
            text = text.Replace("ර්‍ය", "©");
            text = text.Replace("ඳූ", "ª");
            text = text.Replace("ර්", "r|");
            text = text.Replace("ඨි", "À");
            text = text.Replace("ඨී", "Á");
            text = text.Replace("ඡී", "Â");
            text = text.Replace("ඛ්", "Ä");
            text = text.Replace("ඛි", "Å");
            text = text.Replace("ලු", "lU");//
            text = text.Replace("ඛී", "Ç");
            text = text.Replace("දි", "È");
            text = text.Replace("ච්", "c|");
            text = text.Replace("ජ්", "j|");
            text = text.Replace("රී", "r{");//
            text = text.Replace("ඪී", "Î");
            text = text.Replace("ඪී", "Ð,");
            text = text.Replace("චි", "cI");
            text = text.Replace("ථී", "Ò");
            text = text.Replace("ථී", "Ó");
            text = text.Replace("ජී", "j");
            text = text.Replace("චී", "Ö");
            text = text.Replace("ඞ්", "Ù");
            text = text.Replace("ඵී", "Ú");
            text = text.Replace("ට්", "t|");//
            text = text.Replace("ඵි", "Ý");
            text = text.Replace("රි", "rI");//
            text = text.Replace("ටී", "t{");//
            text = text.Replace("ටි", "tI");//
            text = text.Replace("ඩ්", "d|");//
            text = text.Replace("ඩී", "d{");//
            text = text.Replace("ඩි", "dI");//
            text = text.Replace("ඬ්", "å");
            text = text.Replace("ඬි", "ç");
            text = text.Replace("ධ්", "è");
            text = text.Replace("ඬී", "é");
            text = text.Replace("ධි", "ZI");//
            text = text.Replace("ධී", "Z{");//
            text = text.Replace("බි", "ì");
            text = text.Replace("බ්", "b|");//
            text = text.Replace("බී", "î");
            text = text.Replace("ම්", "m|");
            text = text.Replace("ජි", "ð");
            text = text.Replace("මි", "mI");//
            text = text.Replace("ඹ්", "ò");
            text = text.Replace("මී", "m{");//
            text = text.Replace("ඹි", "B{");//
            text = text.Replace("ව්", "v|");//
            text = text.Replace("ඹී", "ö");
            text = text.Replace("ඳු", "XU");//
            text = text.Replace("ද්‍ර", "z&r");//
            text = text.Replace("වී", "v{");//
            text = text.Replace("වි", "vI");//
            text = text.Replace("ඞ්", "û");
            text = text.Replace("ඞී", "ü");
            text = text.Replace("ඡි", "ý");
            text = text.Replace("ඡ්", "C|");//
            text = text.Replace("දු", "zU");//
            text = text.Replace("ජ්", "j|");//
            text = text.Replace("ර්‍ණ", "“");
            text = text.Replace("ණී", "N{");//
            text = text.Replace("ජී", "j{");//
            text = text.Replace("ඡි", "‰");
            text = text.Replace("ඩි", "dI");//
            text = text.Replace("ඤු", "™");
            text = text.Replace("ග", "g");//
            text = text.Replace("ළු", "¿");
            text = text.Replace("ෂ", "x");//
            text = text.Replace("ං", "]");//
            text = text.Replace("ඃ", "[");//
            text = text.Replace("ඹ", "B");//
            text = text.Replace("ඡ", "J");//
            text = text.Replace("ඪ", "C");//
            text = text.Replace("ඝ", "G");//
            text = text.Replace("ඊ", "iI");//
            text = text.Replace("ඣ", "k&D");//
            text = text.Replace("ඛ", "K");//
            text = text.Replace("ළ", "L");//
            text = text.Replace("ඟ", "ඟ");
            text = text.Replace("ණ", "N");//
            text = text.Replace("ඵ", "P");//
            text = text.Replace("ඨ", "T");//
            text = text.Replace("ඃ", "#");
            text = text.Replace(":", "(");
            text = text.Replace("-", ")");
            text = text.Replace("ෆ", "f");//
            text = text.Replace("ල", "l");//f
            text = text.Replace("-", "-");
            text = text.Replace("රැ", "/");
            text = text.Replace("ථ", "W");//
            text = text.Replace("ත", "w");//
            text = text.Replace("ළ", "L");//
            text = text.Replace("ඝ", ">");
            text = text.Replace("රෑ", "r>");
            text = text.Replace("ඊ", "B");
            text = text.Replace("ක‍", "C");
            text = text.Replace("‍ෘ", "D");
            text = text.Replace("ෑ", ">");
            text = text.Replace("ත‍", "t");
            text = text.Replace("ඨ", "G");
            text = text.Replace("්‍ය", "H");
            text = text.Replace("ෂ", "x");//
            text = text.Replace("න‍", "n");//
            text = text.Replace("ණ", "N");//
            text = text.Replace("ඛ", "K");//
            text = text.Replace("ඵ", "P");//
            text = text.Replace("භ", "B");//
            text = text.Replace("ධ", "O");
            text = text.Replace("ඡ", "P");
            text = text.Replace("ඍ", "ඍ");
            text = text.Replace("ඔ", "o");//
            text = text.Replace("ඹ", "U");
            text = text.Replace("ඪ", "y");//
            text = text.Replace("උ", "u");//
            text = text.Replace("ශ", "x");//
            text = text.Replace("ඤ", "[");
            text = text.Replace("ඉ", "i");//
            text = text.Replace("ජ", "j");//i
            text = text.Replace("ට", "t");//
            text = text.Replace("ය", "y");//
            text = text.Replace("ස", "s");//y
            text = text.Replace("ව", "v");//
            text = text.Replace("න", "n");//
            text = text.Replace("ක", "k");//
            text = text.Replace("ප", "p");//
            text = text.Replace("බ", "b");//
            text = text.Replace("ද", "z");//
            text = text.Replace("ච", "c");//
            text = text.Replace("ර", "r");//
            text = text.Replace("එ", "e");//
            text = text.Replace("ම", "m");//
            text = text.Replace("ඩ", "d");//
            text = text.Replace("අ", "a");//
            text = text.Replace("හ", "h");//
            text = text.Replace("ඥ", "{");
            text = text.Replace("ඳ", "X");//a
            text = text.Replace("ක්‍ෂ", "Ì");
            text = text.Replace("ැ", "Q");//
            text = text.Replace("ෑ", ">");//
            text = text.Replace("ෙ", "f");
            text = text.Replace("ු", "U");//
            text = text.Replace("ි", "I");//
            text = text.Replace("ූ", "UU");//
            text = text.Replace("ී", "{");
            text = text.Replace("ෘ", "D");
            text = text.Replace("ෲ", "DD");
            text = text.Replace("ෟ", "!");
            text = text.Replace("ා", "AA");//
            text = text.Replace("්", "|");//
            text = text.Replace("￦", "\"");
            text = text.Replace("�", "'");
            text = text.Replace("￫", "^");
            text = text.Replace("￩", "&");
            text = text.Replace("ￔ", ")");
            text = text.Replace("ￓ", "@");
            text = text.Replace("ￒ", "`");
            text = text.Replace("ￏ", "}");
            text = text.Replace("ￎ", "~");
            text = text.Replace("ඟු", "GU");//new add
            text = text.Replace("ශ්\u200Dරී", "x{U");//new add
            textBox2.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            textBox1.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            textBox1.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            textBox1.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            textBox1.WordWrap = true;


            textBox2.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            textBox2.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            textBox2.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            textBox2.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            textBox2.WordWrap = true;

            this.textBox1.Text =  File.ReadAllText("hodiya.txt");

            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile("sak.otf");
            textBox2.Font = new Font(modernFont.Families[0], 15);

            PrivateFontCollection modernFont1 = new PrivateFontCollection();
            modernFont1.AddFontFile("emanee.ttf");
            textBox1.Font = new Font(modernFont1.Families[0], 15);


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            unicode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fontsize = textBox1.Font.Size;
            float nf = fontsize + 5;

            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile("sak.otf");
            textBox2.Font = new Font(modernFont.Families[0], nf);

            PrivateFontCollection modernFont1 = new PrivateFontCollection();
            modernFont1.AddFontFile("emanee.ttf");
            textBox1.Font = new Font(modernFont1.Families[0], nf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float fontsize = textBox1.Font.Size;
            float nf = fontsize - 5;


            

            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile("sak.otf");
            textBox2.Font = new Font(modernFont.Families[0], nf);

            PrivateFontCollection modernFont1 = new PrivateFontCollection();
            modernFont1.AddFontFile("emanee.ttf");
            textBox1.Font = new Font(modernFont1.Families[0], nf);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
   
}
